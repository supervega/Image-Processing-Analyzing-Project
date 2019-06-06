using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Collections;
using Image_Lib;

namespace IPA_Project
{
    public partial class Form1 : Form
    {
        public Bitmap MyImage;
        public Bitmap[] OldImages;
        public int Index = 0;
        public main MyFunctions = new main();
        public ConvexHull CH = new ConvexHull();

        public bool Flag = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OldImages = new Bitmap[30];
            this.Location = new Point(150, 50);
            CH.graphics = ImagePB.CreateGraphics();
        }

        private void LoadImagebtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog Odlg = new OpenFileDialog();
            Odlg.Title = "Sample";
            string file = "";
            Odlg.Filter = "Bitmaps/Gif/jpeg (*.bmp;*.gif)|*.gif;*.bmp;*.jpg";
            if (Odlg.ShowDialog() == DialogResult.OK)
            {
                file = Odlg.FileName;
            }
            else
            {
                MessageBox.Show("Please Enter a Valid File");
                return;
            }
            MyImage = new Bitmap(file);
            MyImage = new Bitmap(MyImage, ImagePB.Width, ImagePB.Height);
            Index = 0;
            OldImages = new Bitmap[30];
            OldImages[Index] = (Bitmap)MyImage.Clone();
            Index++;
            ImagePB.Image = MyImage;	
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Undobtn_Click(object sender, EventArgs e)
        {
            Index--;
            MyImage = (Bitmap)OldImages[Index].Clone();
            ImagePB.Image = MyImage;
            this.Invalidate();
        }
        
        private void Convertbtn_Click(object sender, EventArgs e)
        {
            if (MyImage != null)
            {
                if (Index < 30)
                {
                    OldImages[Index] = (Bitmap)MyImage.Clone();
                    Index++;
                }
                if (BinaryCB.Checked)
                {
                    if (MyFunctions.GetBinaryImage(MyImage, true, Convert.ToInt32(ThresholdNUD.Value)))
                    {
                        ImagePB.Image = MyImage;
                        Convertlbl.Text = "binary";
                        this.Invalidate();
                    }
                }
                else
                {
                    if (MyFunctions.GetGrayScaleImage(MyImage))
                    {
                        ImagePB.Image = MyImage;
                        Convertlbl.Text = "GrayScale";
                        this.Invalidate();
                    }
                }
            }
            else            
            {
                MessageBox.Show("Please Load an Image first...");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MyImage != null)
            {
                byte[,] sele = new byte[3, 3];
                if (Index < 30)
                {
                    OldImages[Index] = (Bitmap)MyImage.Clone();
                    Index++;
                }
                try
                {
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            sele[i, j] = (byte)Convert.ToInt32(((TextBox)tableLayoutPanel1.GetControlFromPosition(i, j)).Text);
                        }
                    }
                }
                catch (Exception ee)
                {
                    MessageBox.Show(this, "Unimpliable Mask");
                }

                if (Convertlbl.Text == "binary")
                {
                    MyFunctions.GetBinaryImage(MyImage, true, 128);
                    MyFunctions.binary_Dilation(sele, ref MyImage);
                }
                else
                    MyFunctions.gray_Dilation(sele, ref MyImage);

                ImagePB.Image = MyImage;
                this.Invalidate();
            }
            else
            {
                MessageBox.Show("Please Load an Image first...");
            }
        }

        private void Erosionbtn_Click(object sender, EventArgs e)
        {
            if (MyImage != null)
            {
                byte[,] sele = new byte[3, 3];
                if (Index < 30)
                {
                    OldImages[Index] = (Bitmap)MyImage.Clone();
                    Index++;
                }
                try
                {
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            sele[i, j] = (byte)Convert.ToInt32(((TextBox)tableLayoutPanel1.GetControlFromPosition(i, j)).Text);
                        }
                    }
                }
                catch (Exception ee)
                {
                    MessageBox.Show(this, "Unimpliable Mask");
                }

                if (Convertlbl.Text == "binary")
                {
                    MyFunctions.binary_Erosion(sele, ref MyImage);
                }
                else
                    MyFunctions.gray_Erosion(sele, ref MyImage);

                ImagePB.Image = MyImage;
                this.Invalidate();
            }
            else
            {
                MessageBox.Show("Please Load an Image First..");
            }
        }

        private void Histogrambtn_Click(object sender, EventArgs e)
        {
            if (MyImage != null)
                drawHistogram(MyFunctions.calcHisto(MyImage));
            else
                MessageBox.Show("Please Load an Image..");
        }

        public void drawHistogram(int[] histogram)
        {
            Bitmap bmp = new Bitmap(histogram.Length + 10, 310);
            HistogramPB.Image = bmp;
            int keep = 0;
            BitmapData data = bmp.LockBits(new System.Drawing.Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            unsafe
            {
                int remain = data.Stride - data.Width * 3;
                byte* ptr = (byte*)data.Scan0;

                for (int i = 0; i < data.Height; i++)
                {

                    for (int j = 0; j < data.Width; j++)
                    {
                        ptr[0] = ptr[1] = ptr[2] = 150;
                        ptr += 3;
                    }
                    ptr += remain;
                }
                int max = 0;
                for (int i = 0; i < histogram.Length; i++)
                {

                    if (max < histogram[i])
                        max = histogram[i];

                }

                for (int i = 0; i < histogram.Length; i++)
                {
                    ptr = (byte*)data.Scan0;
                    ptr += data.Stride * (305) + (i + 5) * 3;

                    int length = (int)(1.0 * histogram[i] * 300 / max);

                    for (int j = 0; j < length; j++)
                    {
                        ptr[0] = 255;
                        ptr[1] = ptr[2] = 0;
                        ptr -= data.Stride;
                    }
                }
            }
            bmp.UnlockBits(data);
            HistogramPB.Image = new Bitmap(HistogramPB.Image, HistogramPB.Width, HistogramPB.Height);
            this.Invalidate();
        }

        private void Equalizebtn_Click(object sender, EventArgs e)
        {
            if (MyImage != null)
            {
                if (Index < 30)
                {
                    OldImages[Index] = (Bitmap)MyImage.Clone();
                    Index++;
                }
                drawHistogram(MyFunctions.equilizeHist(MyImage));
                ImagePB.Image = MyImage;
                this.Invalidate();
            }
            else
                MessageBox.Show("Please Load an Image...");
        }

        private void SaveImagebtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = "c:\\";
            saveFileDialog.Filter = "Bitmap files (*.bmp)|*.bmp|Jpeg files (*.jpg)|*.jpg|All valid files (*.bmp/*.jpg)|*.bmp/*.jpg";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;
            if (DialogResult.OK == saveFileDialog.ShowDialog())
            {
                MyImage.Save(saveFileDialog.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modifiersbtn.Text = "<<";
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!Flag)
            {
                this.Size = new Size(this.Width + 4, Height);
                if (this.Width >= 1004)
                {
                    timer1.Stop();
                    Flag = true;
                }
            }
            else
            {
                this.Size = new Size(this.Width - 4, Height);
                if (this.Width <= 668)
                {
                    timer1.Stop();
                    Flag = false;
                }
            }
        }

        private void Computebtn_Click(object sender, EventArgs e)
        {
            CH.Go();
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            CH.Clear();
        }

        private void AllowFillCB_CheckedChanged(object sender, EventArgs e)
        {
            if (AllowFillCB.Checked)
                CH.AllowFill = true;
            else
            {
                CH.AllowFill = false;
                CH.Clear();
                this.Invalidate();
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void ConvexHullControl_CheckedChanged(object sender, EventArgs e)
        {
            if (ConvexHullControl.Checked)
                ConvexHullGB.Enabled = true;
            else
                ConvexHullGB.Enabled = false;
        }

        private void ImagePB_Paint(object sender, PaintEventArgs e)
        {
            if (ConvexHullControl.Checked)
                CH.render();
        }

        private void ImagePB_MouseDown(object sender, MouseEventArgs e)
        {
            if (ConvexHullControl.Checked)
            {
                CH.render();
                CH.pID++;
                CH.renderPoint(e.X, e.Y, Color.Lime);
                PointF p = new PointF(e.X, e.Y);
                ConvexHull.SuperPoint sp = new ConvexHull.SuperPoint(p, CH.pID);
                CH.pointsList.Add(sp);
            }
        }

     
    }
}
