namespace IdeaCipher
{
    partial class cipherForm
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
            this.inputKey = new System.Windows.Forms.TextBox();
            this.lblKey = new System.Windows.Forms.Label();
            this.inputPlainText = new System.Windows.Forms.TextBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.inputEncryptedText = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnEncryptedSave = new System.Windows.Forms.Button();
            this.btnEncryptedLoad = new System.Windows.Forms.Button();
            this.btnPlainSave = new System.Windows.Forms.Button();
            this.btnPlainLoad = new System.Windows.Forms.Button();
            this.dlgEncryptedFile = new System.Windows.Forms.OpenFileDialog();
            this.dlgPlainFile = new System.Windows.Forms.OpenFileDialog();
            this.dlgEncryptedFileSave = new System.Windows.Forms.SaveFileDialog();
            this.dlgPlainFileSave = new System.Windows.Forms.SaveFileDialog();
            this.chkViewKey = new System.Windows.Forms.CheckBox();
            this.btnClearPlain = new System.Windows.Forms.Button();
            this.btnClearCiper = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.usernametext = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputKey
            // 
            this.inputKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputKey.Location = new System.Drawing.Point(199, 67);
            this.inputKey.Name = "inputKey";
            this.inputKey.Size = new System.Drawing.Size(588, 29);
            this.inputKey.TabIndex = 0;
            this.inputKey.UseSystemPasswordChar = true;
            this.inputKey.TextChanged += new System.EventHandler(this.inputKey_TextChanged);
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKey.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblKey.Location = new System.Drawing.Point(35, 67);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(99, 24);
            this.lblKey.TabIndex = 1;
            this.lblKey.Text = "Kata Kunci";
            // 
            // inputPlainText
            // 
            this.inputPlainText.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.inputPlainText.Location = new System.Drawing.Point(39, 208);
            this.inputPlainText.Multiline = true;
            this.inputPlainText.Name = "inputPlainText";
            this.inputPlainText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.inputPlainText.Size = new System.Drawing.Size(348, 177);
            this.inputPlainText.TabIndex = 2;
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInput.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblInput.Location = new System.Drawing.Point(44, 177);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(93, 24);
            this.lblInput.TabIndex = 3;
            this.lblInput.Text = "Plain Text";
            this.lblInput.Click += new System.EventHandler(this.lblInput_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(542, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ciphertext";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // inputEncryptedText
            // 
            this.inputEncryptedText.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.inputEncryptedText.Location = new System.Drawing.Point(546, 208);
            this.inputEncryptedText.Multiline = true;
            this.inputEncryptedText.Name = "inputEncryptedText";
            this.inputEncryptedText.ReadOnly = true;
            this.inputEncryptedText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.inputEncryptedText.Size = new System.Drawing.Size(348, 177);
            this.inputEncryptedText.TabIndex = 4;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEncrypt.Location = new System.Drawing.Point(199, 102);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(118, 40);
            this.btnEncrypt.TabIndex = 9;
            this.btnEncrypt.Text = "Encrypt =>";
            this.btnEncrypt.UseVisualStyleBackColor = false;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrypt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDecrypt.Location = new System.Drawing.Point(670, 102);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(117, 38);
            this.btnDecrypt.TabIndex = 8;
            this.btnDecrypt.Text = "<= Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = false;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnEncryptedSave
            // 
            this.btnEncryptedSave.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEncryptedSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncryptedSave.Location = new System.Drawing.Point(745, 391);
            this.btnEncryptedSave.Name = "btnEncryptedSave";
            this.btnEncryptedSave.Size = new System.Drawing.Size(149, 28);
            this.btnEncryptedSave.TabIndex = 19;
            this.btnEncryptedSave.Text = "Simpan";
            this.btnEncryptedSave.UseVisualStyleBackColor = false;
            this.btnEncryptedSave.Click += new System.EventHandler(this.btnEncryptedSave_Click);
            // 
            // btnEncryptedLoad
            // 
            this.btnEncryptedLoad.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEncryptedLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncryptedLoad.Location = new System.Drawing.Point(546, 391);
            this.btnEncryptedLoad.Name = "btnEncryptedLoad";
            this.btnEncryptedLoad.Size = new System.Drawing.Size(193, 29);
            this.btnEncryptedLoad.TabIndex = 18;
            this.btnEncryptedLoad.Text = "Import CipherText";
            this.btnEncryptedLoad.UseVisualStyleBackColor = false;
            this.btnEncryptedLoad.Click += new System.EventHandler(this.btnEncryptedLoad_Click);
            // 
            // btnPlainSave
            // 
            this.btnPlainSave.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnPlainSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlainSave.Location = new System.Drawing.Point(206, 391);
            this.btnPlainSave.Name = "btnPlainSave";
            this.btnPlainSave.Size = new System.Drawing.Size(181, 28);
            this.btnPlainSave.TabIndex = 17;
            this.btnPlainSave.Text = "Simpan";
            this.btnPlainSave.UseVisualStyleBackColor = false;
            this.btnPlainSave.Click += new System.EventHandler(this.btnPlainSave_Click);
            // 
            // btnPlainLoad
            // 
            this.btnPlainLoad.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnPlainLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlainLoad.Location = new System.Drawing.Point(39, 391);
            this.btnPlainLoad.Name = "btnPlainLoad";
            this.btnPlainLoad.Size = new System.Drawing.Size(161, 28);
            this.btnPlainLoad.TabIndex = 16;
            this.btnPlainLoad.Text = "Import Dokumen";
            this.btnPlainLoad.UseVisualStyleBackColor = false;
            this.btnPlainLoad.Click += new System.EventHandler(this.btnPlainLoad_Click);
            // 
            // dlgEncryptedFile
            // 
            this.dlgEncryptedFile.Filter = "Ecrypted files|*.dat";
            // 
            // dlgPlainFile
            // 
            this.dlgPlainFile.Filter = "All Files|*.*";
            // 
            // dlgEncryptedFileSave
            // 
            this.dlgEncryptedFileSave.Filter = "Encrypted data|*.dat";
            // 
            // dlgPlainFileSave
            // 
            this.dlgPlainFileSave.Filter = "Plain text|*.txt";
            // 
            // chkViewKey
            // 
            this.chkViewKey.AutoSize = true;
            this.chkViewKey.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkViewKey.Location = new System.Drawing.Point(792, 74);
            this.chkViewKey.Margin = new System.Windows.Forms.Padding(2);
            this.chkViewKey.Name = "chkViewKey";
            this.chkViewKey.Size = new System.Drawing.Size(79, 17);
            this.chkViewKey.TabIndex = 20;
            this.chkViewKey.Text = "Lihat Kunci";
            this.chkViewKey.UseVisualStyleBackColor = true;
            this.chkViewKey.CheckedChanged += new System.EventHandler(this.chkViewKey_CheckedChanged);
            // 
            // btnClearPlain
            // 
            this.btnClearPlain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearPlain.Location = new System.Drawing.Point(289, 433);
            this.btnClearPlain.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearPlain.Name = "btnClearPlain";
            this.btnClearPlain.Size = new System.Drawing.Size(348, 30);
            this.btnClearPlain.TabIndex = 21;
            this.btnClearPlain.Text = "Hapus Plaintext";
            this.btnClearPlain.UseVisualStyleBackColor = true;
            this.btnClearPlain.Click += new System.EventHandler(this.btnClearPlain_Click);
            // 
            // btnClearCiper
            // 
            this.btnClearCiper.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearCiper.Location = new System.Drawing.Point(289, 477);
            this.btnClearCiper.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearCiper.Name = "btnClearCiper";
            this.btnClearCiper.Size = new System.Drawing.Size(348, 30);
            this.btnClearCiper.TabIndex = 22;
            this.btnClearCiper.Text = "Hapus Ciperthext";
            this.btnClearCiper.UseVisualStyleBackColor = true;
            this.btnClearCiper.Click += new System.EventHandler(this.btnClearCiper_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.Location = new System.Drawing.Point(289, 520);
            this.btnClearAll.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(348, 30);
            this.btnClearAll.TabIndex = 23;
            this.btnClearAll.Text = "Hapus Semua";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(456, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "counting....";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(289, 565);
            this.Exit.Margin = new System.Windows.Forms.Padding(2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(348, 30);
            this.Exit.TabIndex = 26;
            this.Exit.Text = "Keluar";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // usernametext
            // 
            this.usernametext.AutoSize = true;
            this.usernametext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernametext.ForeColor = System.Drawing.Color.Snow;
            this.usernametext.Location = new System.Drawing.Point(773, 18);
            this.usernametext.Name = "usernametext";
            this.usernametext.Size = new System.Drawing.Size(0, 15);
            this.usernametext.TabIndex = 27;
            this.usernametext.Click += new System.EventHandler(this.usernametext_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(373, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 37);
            this.label3.TabIndex = 28;
            this.label3.Text = "IDEA Algorithm";
            // 
            // cipherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(932, 749);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.usernametext);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnClearCiper);
            this.Controls.Add(this.btnClearPlain);
            this.Controls.Add(this.chkViewKey);
            this.Controls.Add(this.btnEncryptedSave);
            this.Controls.Add(this.btnEncryptedLoad);
            this.Controls.Add(this.btnPlainSave);
            this.Controls.Add(this.btnPlainLoad);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputEncryptedText);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.inputPlainText);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.inputKey);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MaximizeBox = false;
            this.Name = "cipherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IDEA CRYPT";
            this.Load += new System.EventHandler(this.cipherForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputKey;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.TextBox inputPlainText;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputEncryptedText;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnEncryptedSave;
        private System.Windows.Forms.Button btnEncryptedLoad;
        private System.Windows.Forms.Button btnPlainSave;
        private System.Windows.Forms.Button btnPlainLoad;
        private System.Windows.Forms.OpenFileDialog dlgEncryptedFile;
        private System.Windows.Forms.OpenFileDialog dlgPlainFile;
        private System.Windows.Forms.SaveFileDialog dlgEncryptedFileSave;
        private System.Windows.Forms.SaveFileDialog dlgPlainFileSave;
        private System.Windows.Forms.CheckBox chkViewKey;
        private System.Windows.Forms.Button btnClearPlain;
        private System.Windows.Forms.Button btnClearCiper;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label usernametext;
        private System.Windows.Forms.Label label3;
    }
}

