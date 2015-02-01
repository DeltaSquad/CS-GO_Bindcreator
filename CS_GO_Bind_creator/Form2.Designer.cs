namespace CS_GO_Bind_creator
{
    partial class Form2
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
            this.gb_language = new System.Windows.Forms.GroupBox();
            this.rb_german = new System.Windows.Forms.RadioButton();
            this.rb_english = new System.Windows.Forms.RadioButton();
            this.lb_warning = new System.Windows.Forms.Label();
            this.gb_keyboard = new System.Windows.Forms.GroupBox();
            this.rb_qwertz = new System.Windows.Forms.RadioButton();
            this.rb_qwerty = new System.Windows.Forms.RadioButton();
            this.gb_language.SuspendLayout();
            this.gb_keyboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_language
            // 
            this.gb_language.Controls.Add(this.rb_german);
            this.gb_language.Controls.Add(this.rb_english);
            this.gb_language.Location = new System.Drawing.Point(12, 12);
            this.gb_language.Name = "gb_language";
            this.gb_language.Size = new System.Drawing.Size(93, 71);
            this.gb_language.TabIndex = 0;
            this.gb_language.TabStop = false;
            this.gb_language.Text = "Language";
            // 
            // rb_german
            // 
            this.rb_german.AutoSize = true;
            this.rb_german.Location = new System.Drawing.Point(12, 42);
            this.rb_german.Name = "rb_german";
            this.rb_german.Size = new System.Drawing.Size(62, 17);
            this.rb_german.TabIndex = 1;
            this.rb_german.Text = "German";
            this.rb_german.UseVisualStyleBackColor = true;
            this.rb_german.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rb_english
            // 
            this.rb_english.AutoSize = true;
            this.rb_english.Location = new System.Drawing.Point(12, 19);
            this.rb_english.Name = "rb_english";
            this.rb_english.Size = new System.Drawing.Size(59, 17);
            this.rb_english.TabIndex = 0;
            this.rb_english.Text = "English";
            this.rb_english.UseVisualStyleBackColor = true;
            this.rb_english.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // lb_warning
            // 
            this.lb_warning.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_warning.ForeColor = System.Drawing.Color.Red;
            this.lb_warning.Location = new System.Drawing.Point(9, 86);
            this.lb_warning.Name = "lb_warning";
            this.lb_warning.Size = new System.Drawing.Size(207, 13);
            this.lb_warning.TabIndex = 2;
            this.lb_warning.Text = "-warning message-";
            this.lb_warning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gb_keyboard
            // 
            this.gb_keyboard.Controls.Add(this.rb_qwertz);
            this.gb_keyboard.Controls.Add(this.rb_qwerty);
            this.gb_keyboard.Location = new System.Drawing.Point(123, 12);
            this.gb_keyboard.Name = "gb_keyboard";
            this.gb_keyboard.Size = new System.Drawing.Size(93, 71);
            this.gb_keyboard.TabIndex = 3;
            this.gb_keyboard.TabStop = false;
            this.gb_keyboard.Text = "Keyboard";
            // 
            // rb_qwertz
            // 
            this.rb_qwertz.AutoSize = true;
            this.rb_qwertz.Location = new System.Drawing.Point(6, 42);
            this.rb_qwertz.Name = "rb_qwertz";
            this.rb_qwertz.Size = new System.Drawing.Size(73, 17);
            this.rb_qwertz.TabIndex = 1;
            this.rb_qwertz.Text = "QWERTZ";
            this.rb_qwertz.UseVisualStyleBackColor = true;
            this.rb_qwertz.CheckedChanged += new System.EventHandler(this.rb_qwertz_CheckedChanged);
            // 
            // rb_qwerty
            // 
            this.rb_qwerty.AutoSize = true;
            this.rb_qwerty.Location = new System.Drawing.Point(6, 19);
            this.rb_qwerty.Name = "rb_qwerty";
            this.rb_qwerty.Size = new System.Drawing.Size(73, 17);
            this.rb_qwerty.TabIndex = 0;
            this.rb_qwerty.Text = "QWERTY";
            this.rb_qwerty.UseVisualStyleBackColor = true;
            this.rb_qwerty.CheckedChanged += new System.EventHandler(this.rb_qwerty_CheckedChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 108);
            this.Controls.Add(this.gb_keyboard);
            this.Controls.Add(this.lb_warning);
            this.Controls.Add(this.gb_language);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.gb_language.ResumeLayout(false);
            this.gb_language.PerformLayout();
            this.gb_keyboard.ResumeLayout(false);
            this.gb_keyboard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_language;
        private System.Windows.Forms.RadioButton rb_german;
        private System.Windows.Forms.RadioButton rb_english;
        private System.Windows.Forms.Label lb_warning;
        private System.Windows.Forms.GroupBox gb_keyboard;
        private System.Windows.Forms.RadioButton rb_qwertz;
        private System.Windows.Forms.RadioButton rb_qwerty;
    }
}