namespace MyEncripter
{
    partial class MyEncrypter
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.pfadBox = new System.Windows.Forms.TextBox();
            this.btn_encript = new System.Windows.Forms.Button();
            this.btn_decript = new System.Windows.Forms.Button();
            this.IVbox = new System.Windows.Forms.TextBox();
            this.KeyBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pfadBox
            // 
            this.pfadBox.Location = new System.Drawing.Point(87, 45);
            this.pfadBox.Name = "pfadBox";
            this.pfadBox.Size = new System.Drawing.Size(353, 26);
            this.pfadBox.TabIndex = 0;
            // 
            // btn_encript
            // 
            this.btn_encript.Location = new System.Drawing.Point(67, 170);
            this.btn_encript.Name = "btn_encript";
            this.btn_encript.Size = new System.Drawing.Size(93, 48);
            this.btn_encript.TabIndex = 1;
            this.btn_encript.Text = "Encript";
            this.btn_encript.UseVisualStyleBackColor = true;
            this.btn_encript.Click += new System.EventHandler(this.btn_encript_Click);
            // 
            // btn_decript
            // 
            this.btn_decript.Location = new System.Drawing.Point(175, 170);
            this.btn_decript.Name = "btn_decript";
            this.btn_decript.Size = new System.Drawing.Size(109, 48);
            this.btn_decript.TabIndex = 2;
            this.btn_decript.Text = "Decript";
            this.btn_decript.UseVisualStyleBackColor = true;
            this.btn_decript.Click += new System.EventHandler(this.btn_decript_Click);
            // 
            // IVbox
            // 
            this.IVbox.Location = new System.Drawing.Point(87, 106);
            this.IVbox.Name = "IVbox";
            this.IVbox.Size = new System.Drawing.Size(353, 26);
            this.IVbox.TabIndex = 3;
            // 
            // KeyBox
            // 
            this.KeyBox.Location = new System.Drawing.Point(67, 138);
            this.KeyBox.Name = "KeyBox";
            this.KeyBox.Size = new System.Drawing.Size(373, 26);
            this.KeyBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "IV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Key32";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "Pfad";
            // 
            // MyEncrypter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 270);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KeyBox);
            this.Controls.Add(this.IVbox);
            this.Controls.Add(this.btn_decript);
            this.Controls.Add(this.btn_encript);
            this.Controls.Add(this.pfadBox);
            this.Name = "MyEncrypter";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pfadBox;
        private System.Windows.Forms.Button btn_encript;
        private System.Windows.Forms.Button btn_decript;
        private System.Windows.Forms.TextBox IVbox;
        private System.Windows.Forms.TextBox KeyBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

