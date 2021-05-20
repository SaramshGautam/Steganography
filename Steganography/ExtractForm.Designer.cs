﻿namespace Steganography
{
    partial class ExtractForm
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
            this.picStegImage = new System.Windows.Forms.PictureBox();
            this.btnExtract = new System.Windows.Forms.Button();
            this.txtExtractPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtExtractFilePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtextractedText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblStegSize = new System.Windows.Forms.Label();
            this.txtStegSize = new System.Windows.Forms.TextBox();
            this.lblKB = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picStegImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picStegImage
            // 
            this.picStegImage.BackColor = System.Drawing.SystemColors.ControlLight;
            this.picStegImage.Location = new System.Drawing.Point(22, 70);
            this.picStegImage.Name = "picStegImage";
            this.picStegImage.Size = new System.Drawing.Size(256, 240);
            this.picStegImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStegImage.TabIndex = 0;
            this.picStegImage.TabStop = false;
            // 
            // btnExtract
            // 
            this.btnExtract.Font = new System.Drawing.Font("Miriam Mono CLM", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnExtract.Location = new System.Drawing.Point(22, 422);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(105, 32);
            this.btnExtract.TabIndex = 1;
            this.btnExtract.Text = "Extract";
            this.btnExtract.UseVisualStyleBackColor = true;
            this.btnExtract.Click += new System.EventHandler(this.btnExtract_Click);
            // 
            // txtExtractPassword
            // 
            this.txtExtractPassword.Font = new System.Drawing.Font("Miriam Mono CLM", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtExtractPassword.Location = new System.Drawing.Point(22, 388);
            this.txtExtractPassword.Name = "txtExtractPassword";
            this.txtExtractPassword.Size = new System.Drawing.Size(256, 28);
            this.txtExtractPassword.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Miriam Mono CLM", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(18, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Password";
            // 
            // txtExtractFilePath
            // 
            this.txtExtractFilePath.Font = new System.Drawing.Font("Miriam Mono CLM", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtExtractFilePath.Location = new System.Drawing.Point(22, 335);
            this.txtExtractFilePath.Name = "txtExtractFilePath";
            this.txtExtractFilePath.Size = new System.Drawing.Size(256, 28);
            this.txtExtractFilePath.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Miriam Mono CLM", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(18, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "File Path:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Miriam Mono CLM", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnBrowse.Location = new System.Drawing.Point(299, 274);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(94, 36);
            this.btnBrowse.TabIndex = 6;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtextractedText
            // 
            this.txtextractedText.Font = new System.Drawing.Font("Miriam Mono CLM", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtextractedText.Location = new System.Drawing.Point(22, 479);
            this.txtextractedText.Name = "txtextractedText";
            this.txtextractedText.Size = new System.Drawing.Size(256, 28);
            this.txtextractedText.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Miriam Mono CLM", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(18, 457);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Hidden Message:";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Miriam Mono CLM", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnBack.Location = new System.Drawing.Point(506, 473);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(76, 34);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblStegSize
            // 
            this.lblStegSize.AutoSize = true;
            this.lblStegSize.Font = new System.Drawing.Font("Miriam Mono CLM", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblStegSize.Location = new System.Drawing.Point(333, 457);
            this.lblStegSize.Name = "lblStegSize";
            this.lblStegSize.Size = new System.Drawing.Size(49, 19);
            this.lblStegSize.TabIndex = 10;
            this.lblStegSize.Text = "Size";
            // 
            // txtStegSize
            // 
            this.txtStegSize.Font = new System.Drawing.Font("Miriam Mono CLM", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtStegSize.Location = new System.Drawing.Point(331, 479);
            this.txtStegSize.Name = "txtStegSize";
            this.txtStegSize.Size = new System.Drawing.Size(62, 28);
            this.txtStegSize.TabIndex = 11;
            // 
            // lblKB
            // 
            this.lblKB.AutoSize = true;
            this.lblKB.Font = new System.Drawing.Font("Miriam Mono CLM", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblKB.Location = new System.Drawing.Point(399, 488);
            this.lblKB.Name = "lblKB";
            this.lblKB.Size = new System.Drawing.Size(29, 19);
            this.lblKB.TabIndex = 12;
            this.lblKB.Text = "KB";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 43);
            this.panel1.TabIndex = 13;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Miriam Mono CLM", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(22, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Extraction";
            // 
            // ExtractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(594, 533);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblKB);
            this.Controls.Add(this.txtStegSize);
            this.Controls.Add(this.lblStegSize);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtextractedText);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtExtractFilePath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtExtractPassword);
            this.Controls.Add(this.btnExtract);
            this.Controls.Add(this.picStegImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExtractForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExtractForm";
            ((System.ComponentModel.ISupportInitialize)(this.picStegImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picStegImage;
        private System.Windows.Forms.Button btnExtract;
        private System.Windows.Forms.TextBox txtExtractPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtExtractFilePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtextractedText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblStegSize;
        private System.Windows.Forms.TextBox txtStegSize;
        private System.Windows.Forms.Label lblKB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
    }
}