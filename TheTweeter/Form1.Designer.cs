namespace TheTweeter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.Username_TextBox = new System.Windows.Forms.TextBox();
            this.Password_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Tweet_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.Tweet_BTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Username_TextBox
            // 
            this.Username_TextBox.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_TextBox.Location = new System.Drawing.Point(102, 15);
            this.Username_TextBox.Name = "Username_TextBox";
            this.Username_TextBox.Size = new System.Drawing.Size(317, 32);
            this.Username_TextBox.TabIndex = 1;
            this.Username_TextBox.Text = " ";
            // 
            // Password_TextBox
            // 
            this.Password_TextBox.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_TextBox.Location = new System.Drawing.Point(102, 71);
            this.Password_TextBox.Name = "Password_TextBox";
            this.Password_TextBox.Size = new System.Drawing.Size(317, 32);
            this.Password_TextBox.TabIndex = 3;
            this.Password_TextBox.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Aqua;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // Tweet_RichTextBox
            // 
            this.Tweet_RichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tweet_RichTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Tweet_RichTextBox.Location = new System.Drawing.Point(16, 133);
            this.Tweet_RichTextBox.Name = "Tweet_RichTextBox";
            this.Tweet_RichTextBox.Size = new System.Drawing.Size(403, 247);
            this.Tweet_RichTextBox.TabIndex = 4;
            this.Tweet_RichTextBox.Text = "Enter Your Tweet Here:";
            this.Tweet_RichTextBox.TextChanged += new System.EventHandler(this.Tweet_RichTextBox_TextChanged);
            this.Tweet_RichTextBox.Enter += new System.EventHandler(this.Tweet_RichTextBox_Enter);
            // 
            // Tweet_BTN
            // 
            this.Tweet_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tweet_BTN.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tweet_BTN.Location = new System.Drawing.Point(305, 406);
            this.Tweet_BTN.Name = "Tweet_BTN";
            this.Tweet_BTN.Size = new System.Drawing.Size(114, 43);
            this.Tweet_BTN.TabIndex = 5;
            this.Tweet_BTN.Text = "Tweet";
            this.Tweet_BTN.UseVisualStyleBackColor = true;
            this.Tweet_BTN.Click += new System.EventHandler(this.Tweet_BTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(431, 469);
            this.Controls.Add(this.Tweet_BTN);
            this.Controls.Add(this.Tweet_RichTextBox);
            this.Controls.Add(this.Password_TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Username_TextBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "The Tweeter";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Username_TextBox;
        private System.Windows.Forms.TextBox Password_TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox Tweet_RichTextBox;
        private System.Windows.Forms.Button Tweet_BTN;
    }
}

