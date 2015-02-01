using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_GO_Bind_creator
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            #region language
            if (Properties.Settings.Default.english == true)
            {
                rb_english.Checked = true;
                rb_german.Checked = false;
                this.Text = "Options";
                gb_language.Text = "Language";
                gb_keyboard.Text = "Keyboard";
                rb_english.Text = "English";
                rb_german.Text = "German";
                lb_warning.Text = "--- Restart on change ---";
            }
            else
            {
                rb_german.Checked = true;
                rb_english.Checked = false;
                this.Text = "Einstellungen";
                gb_language.Text = "Sprache";
                gb_keyboard.Text = "Tastatur";
                rb_english.Text = "Englisch";
                rb_german.Text = "Deutsch";
                lb_warning.Text = "--- Bei änderung Neustarten ---";
            }
            #endregion
            #region keyboard
            if (Properties.Settings.Default.qwerty == true)
            {
                rb_qwerty.Checked = true;
                rb_qwertz.Checked = false;
            }
            else
            {
                rb_qwerty.Checked = true;
                rb_qwertz.Checked = false;
            }
            #endregion
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default["english"] = true;
            Properties.Settings.Default.Save();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default["english"] = false;
            Properties.Settings.Default.Save();
        }

        private void rb_qwerty_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default["qwerty"] = true;
            Properties.Settings.Default.Save();
        }

        private void rb_qwertz_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default["qwerty"] = false;
            Properties.Settings.Default.Save();
        }
    }
}
