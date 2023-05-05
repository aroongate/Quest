namespace Quest
{
    partial class formTextWizard
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(33, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(357, 96);
            this.button2.TabIndex = 3;
            this.button2.Text = "2. Не обращайте внимания на горожан и продолжайте свое путешествие.";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(357, 96);
            this.button1.TabIndex = 2;
            this.button1.Text = "1. Помогите горожанам и встретьтесь лицом к лицу с колдуном.";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // formTextWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(433, 268);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "formTextWizard";
            this.Text = "Выбор 1";
            this.Load += new System.EventHandler(this.formTextWizard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}