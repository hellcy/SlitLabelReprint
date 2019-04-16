namespace SaveSlitCoil
{
    partial class SaveSlitedCoil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaveSlitedCoil));
            this.RackNumberText = new System.Windows.Forms.TextBox();
            this.FrontColorText = new System.Windows.Forms.TextBox();
            this.BackColorText = new System.Windows.Forms.TextBox();
            this.RackNumberLabel = new System.Windows.Forms.Label();
            this.FrontColorLabel = new System.Windows.Forms.Label();
            this.BackColorLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.PreviewButton = new System.Windows.Forms.Button();
            this.PrintButton = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.ErrMsg = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.TypeText = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // RackNumberText
            // 
            this.RackNumberText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RackNumberText.Location = new System.Drawing.Point(192, 47);
            this.RackNumberText.Name = "RackNumberText";
            this.RackNumberText.Size = new System.Drawing.Size(100, 31);
            this.RackNumberText.TabIndex = 0;
            // 
            // FrontColorText
            // 
            this.FrontColorText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FrontColorText.Location = new System.Drawing.Point(192, 94);
            this.FrontColorText.Name = "FrontColorText";
            this.FrontColorText.Size = new System.Drawing.Size(100, 31);
            this.FrontColorText.TabIndex = 1;
            // 
            // BackColorText
            // 
            this.BackColorText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackColorText.Location = new System.Drawing.Point(192, 145);
            this.BackColorText.Name = "BackColorText";
            this.BackColorText.Size = new System.Drawing.Size(100, 31);
            this.BackColorText.TabIndex = 2;
            // 
            // RackNumberLabel
            // 
            this.RackNumberLabel.AutoSize = true;
            this.RackNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RackNumberLabel.Location = new System.Drawing.Point(44, 47);
            this.RackNumberLabel.Name = "RackNumberLabel";
            this.RackNumberLabel.Size = new System.Drawing.Size(142, 25);
            this.RackNumberLabel.TabIndex = 3;
            this.RackNumberLabel.Text = "Rack Number";
            // 
            // FrontColorLabel
            // 
            this.FrontColorLabel.AutoSize = true;
            this.FrontColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FrontColorLabel.Location = new System.Drawing.Point(44, 94);
            this.FrontColorLabel.Name = "FrontColorLabel";
            this.FrontColorLabel.Size = new System.Drawing.Size(119, 25);
            this.FrontColorLabel.TabIndex = 4;
            this.FrontColorLabel.Text = "Front Color";
            // 
            // BackColorLabel
            // 
            this.BackColorLabel.AutoSize = true;
            this.BackColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackColorLabel.Location = new System.Drawing.Point(44, 145);
            this.BackColorLabel.Name = "BackColorLabel";
            this.BackColorLabel.Size = new System.Drawing.Size(117, 25);
            this.BackColorLabel.TabIndex = 5;
            this.BackColorLabel.Text = "Back Color";
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WidthLabel.Location = new System.Drawing.Point(44, 196);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(67, 25);
            this.WidthLabel.TabIndex = 6;
            this.WidthLabel.Text = "Width";
            // 
            // PreviewButton
            // 
            this.PreviewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviewButton.Location = new System.Drawing.Point(395, 47);
            this.PreviewButton.Name = "PreviewButton";
            this.PreviewButton.Size = new System.Drawing.Size(130, 61);
            this.PreviewButton.TabIndex = 8;
            this.PreviewButton.Text = "Preview";
            this.PreviewButton.UseVisualStyleBackColor = true;
            this.PreviewButton.Click += new System.EventHandler(this.PreviewButton_Click);
            // 
            // PrintButton
            // 
            this.PrintButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintButton.Location = new System.Drawing.Point(395, 145);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(130, 61);
            this.PrintButton.TabIndex = 9;
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // ErrMsg
            // 
            this.ErrMsg.AutoSize = true;
            this.ErrMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrMsg.ForeColor = System.Drawing.Color.Red;
            this.ErrMsg.Location = new System.Drawing.Point(44, 283);
            this.ErrMsg.Name = "ErrMsg";
            this.ErrMsg.Size = new System.Drawing.Size(0, 29);
            this.ErrMsg.TabIndex = 10;
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeLabel.Location = new System.Drawing.Point(44, 246);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(60, 25);
            this.TypeLabel.TabIndex = 11;
            this.TypeLabel.Text = "Type";
            // 
            // TypeText
            // 
            this.TypeText.AutoSize = true;
            this.TypeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeText.Location = new System.Drawing.Point(192, 246);
            this.TypeText.Name = "TypeText";
            this.TypeText.Size = new System.Drawing.Size(44, 25);
            this.TypeText.TabIndex = 12;
            this.TypeText.Text = "SM";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "51",
            "67",
            "83",
            "92",
            "108"});
            this.comboBox1.Location = new System.Drawing.Point(192, 196);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 33);
            this.comboBox1.TabIndex = 13;
            // 
            // SaveSlitedCoil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 339);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.TypeText);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.ErrMsg);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.PreviewButton);
            this.Controls.Add(this.WidthLabel);
            this.Controls.Add(this.BackColorLabel);
            this.Controls.Add(this.FrontColorLabel);
            this.Controls.Add(this.RackNumberLabel);
            this.Controls.Add(this.BackColorText);
            this.Controls.Add(this.FrontColorText);
            this.Controls.Add(this.RackNumberText);
            this.Name = "SaveSlitedCoil";
            this.Text = "Slit Label Reprint";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RackNumberText;
        private System.Windows.Forms.TextBox FrontColorText;
        private System.Windows.Forms.TextBox BackColorText;
        private System.Windows.Forms.Label RackNumberLabel;
        private System.Windows.Forms.Label FrontColorLabel;
        private System.Windows.Forms.Label BackColorLabel;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Button PreviewButton;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label ErrMsg;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label TypeText;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

