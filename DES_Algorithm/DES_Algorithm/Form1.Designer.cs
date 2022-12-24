namespace Buoi3Bai2
{
    partial class Form1
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
            this.btnGiaiMa = new System.Windows.Forms.Button();
            this.btnMaHoa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txbOriginText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbOutput = new System.Windows.Forms.TextBox();
            this.btnFile = new System.Windows.Forms.Button();
            this.txbFile = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGiaiMa
            // 
            this.btnGiaiMa.Location = new System.Drawing.Point(277, 101);
            this.btnGiaiMa.Name = "btnGiaiMa";
            this.btnGiaiMa.Size = new System.Drawing.Size(75, 23);
            this.btnGiaiMa.TabIndex = 19;
            this.btnGiaiMa.Text = "Giai ma";
            this.btnGiaiMa.UseVisualStyleBackColor = true;
            this.btnGiaiMa.Click += new System.EventHandler(this.btnGiaiMa_Click_1);
            // 
            // btnMaHoa
            // 
            this.btnMaHoa.Location = new System.Drawing.Point(175, 101);
            this.btnMaHoa.Name = "btnMaHoa";
            this.btnMaHoa.Size = new System.Drawing.Size(75, 23);
            this.btnMaHoa.TabIndex = 18;
            this.btnMaHoa.Text = "Ma hoa";
            this.btnMaHoa.UseVisualStyleBackColor = true;
            this.btnMaHoa.Click += new System.EventHandler(this.btnMaHoa_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Origin Text";
            // 
            // txbOriginText
            // 
            this.txbOriginText.Location = new System.Drawing.Point(109, 75);
            this.txbOriginText.Name = "txbOriginText";
            this.txbOriginText.Size = new System.Drawing.Size(384, 20);
            this.txbOriginText.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "EncryptText";
            // 
            // txbOutput
            // 
            this.txbOutput.Location = new System.Drawing.Point(109, 49);
            this.txbOutput.Name = "txbOutput";
            this.txbOutput.Size = new System.Drawing.Size(384, 20);
            this.txbOutput.TabIndex = 14;
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(28, 10);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(75, 23);
            this.btnFile.TabIndex = 11;
            this.btnFile.Text = "File";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // txbFile
            // 
            this.txbFile.Location = new System.Drawing.Point(109, 12);
            this.txbFile.Name = "txbFile";
            this.txbFile.Size = new System.Drawing.Size(384, 20);
            this.txbFile.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 142);
            this.Controls.Add(this.btnGiaiMa);
            this.Controls.Add(this.btnMaHoa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbOriginText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbOutput);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.txbFile);
            this.Name = "Form1";
            this.Text = "DES";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGiaiMa;
        private System.Windows.Forms.Button btnMaHoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbOriginText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbOutput;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.TextBox txbFile;
    }
}

