using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zen.Barcode;

namespace SaveSlitCoil
{
    // This application is to record the time the slited coils have been used. 
    public partial class SaveSlitedCoil : Form
    {
        // declare all global variables here
        PaperSize paperSize = new PaperSize("papersize", 250, 800); //set the paper size
        string label = "tests";

        public SaveSlitedCoil()
        {
            InitializeComponent();
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            if (canPressButton())
            {
                printDocument1.DefaultPageSettings.PaperSize = paperSize;
                ErrMsg.Text = "";
                string printer = "ZDesigner S4M-203dpi ZPL";
                Printing(printer);

                // add timestamp and coil ID to a new file.
                string path = @"C:\SlitLabelReprint\files\coilSlits.csv";
                TextWriter txt = new StreamWriter(path, true); // true means text will be appended to the file.
                DateTime now = DateTime.Now;
                label = label.Replace('+', ',');

                txt.WriteLine(label + "," + now);
                txt.Close();
            }
        }

        private void PreviewButton_Click(object sender, EventArgs e)
        {
            if (canPressButton())
            {
                printDocument1.DefaultPageSettings.PaperSize = paperSize;
                printPreviewDialog1.ShowDialog();
            }
        }

        public void Printing(string printer)
        {

            try
            {
                PrintDocument pd = new PrintDocument();
                pd.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
                //pd.PrinterSettings.PrinterName = printer;
                pd.PrinterSettings.Copies = 1; // set number of copies for each page
                if (pd.PrinterSettings.IsValid)
                {
                    // clear everything
                    pd.Print();
                }
                else
                {
                    MessageBox.Show("Printer is invalid.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            if (BackColorText.Text == "")
            {
                label = RackNumberText.Text + "+" + TypeText.Text + "+" + FrontColorText.Text + "+" + comboBox1.Text;
            }
            else label = RackNumberText.Text + "+" + TypeText.Text + "+" + FrontColorText.Text.Substring(0, 2) + BackColorText.Text.Substring(0, 2) + "+" + comboBox1.Text;

            CodeQrBarcodeDraw QRcode = BarcodeDrawFactory.CodeQr; // to generate QR code
            System.Drawing.Image QRcodeImage = QRcode.Draw(label, 100);
            // RectangleF(The coordinates of the upper-left corner of the rectangle, width, height)
            RectangleF QRcodeRect = new RectangleF(20.0F, 40.0F, 150.0F, 150.0F);
            g.DrawImage(QRcodeImage, QRcodeRect);

            BarcodeDraw bdraw = BarcodeDrawFactory.GetSymbology(BarcodeSymbology.Code128);
            System.Drawing.Image barcodeImage = bdraw.Draw(label, 100);
            RectangleF barcodeRect = new RectangleF(350.0F, 60.0F, 430.0F, 110.0F);
            g.DrawImage(barcodeImage, barcodeRect);

            // Create string to draw.
            String drawString = label.ToUpper();

            // center the text in a specified rectangle.
            StringFormat sf = new StringFormat();
            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Center;

            SolidBrush drawBrush;

            // Back color
            if (BackColorText.Text != "")
            {
                drawBrush = new SolidBrush(Color.White);
                System.Drawing.Font colorFont2 = new System.Drawing.Font("Ariel", 40, FontStyle.Bold);
                g.FillRectangle(new SolidBrush(Color.Black), 170, 125, 170, 60);

                RectangleF colorRect2 = new RectangleF(160.0F, 120.0F, 180.0F, 80.0F);
                g.DrawString(BackColorText.Text.ToUpper(), colorFont2, drawBrush, colorRect2, sf);
            }

            // front color
            drawBrush = new SolidBrush(Color.Black);

            System.Drawing.Font colorFont = new System.Drawing.Font("Arial Black", 50, FontStyle.Bold);
            RectangleF colorRect = new RectangleF(150.0F, 40.0F, 220.0F, 80.0F);
            g.DrawString(FrontColorText.Text.ToUpper(), colorFont, drawBrush, colorRect, sf);

            // type
            System.Drawing.Font typeFont = new System.Drawing.Font("Ariel", 30, FontStyle.Bold);
            RectangleF typeRect = new RectangleF(400.0F, 15.0F, 100.0F, 60.0F);
            g.DrawString(TypeText.Text.ToUpper(), typeFont, drawBrush, typeRect, sf);

            // date
            string month_year = DateTime.Now.ToString("MMM").ToUpper() + "_" + DateTime.Now.ToString("yy");
            System.Drawing.Font timeFont = new System.Drawing.Font("Ariel", 20, FontStyle.Bold);
            RectangleF timeRect = new RectangleF(550.0F, 15.0F, 150.0F, 60.0F);
            g.DrawString(month_year, timeFont, drawBrush, timeRect, sf);

            // width
            System.Drawing.Font widthFont = new System.Drawing.Font("Ariel", 30, FontStyle.Bold);
            RectangleF widthRect = new RectangleF(700.0F, 15.0F, 100.0F, 60.0F);
            g.DrawString(comboBox1.Text, widthFont, drawBrush, widthRect, sf);

            // Coil ID
            System.Drawing.Font drawFont = new System.Drawing.Font("Ariel", 16);

            // Create point for upper-left corner of drawing.
            float x = 345.0F;
            float y = 170.0F;
            g.DrawString(drawString, drawFont, drawBrush, x, y);
            return;
        }

        private bool canPressButton()
        {
            if ((RackNumberText.Text != "" && FrontColorText.Text != "" && comboBox1.Text != "")) return true;
            else
            {
                ErrMsg.Text = "Please fill all required information.";
                return false;
            }
        }
    }
}
