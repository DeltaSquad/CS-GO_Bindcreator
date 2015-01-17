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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //fail
        #region erros
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_none1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This button can not be bind to a command", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }
        private void button_none2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This button can not be bind to a command", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        private void button_none3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This button can not be bind to a command", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        private void button_none_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This button can not be bind to a command", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        private void button_none4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This button can not be bind to a command", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        private void button_none6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This button can not be bind to a command", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        private void button_none5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This button can not be bind to a command", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }
        #endregion
        #region fails
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tB_end_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_getcommand_Click(object sender, EventArgs e)
        {
            if(cb_glock.Checked == true)
            {
                tB_end.Text = "bind " + tb_key.Text + rtb_commands.Text;
            }
            else
            {
                if(cb_p250.Checked == true)
                {
                    tB_end.Text = "bind " + tb_key.Text + rtb_commands.Text;
                }
                else
                {
                    if(cb_deagle.Checked == true)
                    {
                        tB_end.Text = "bind " + tb_key.Text + rtb_commands.Text;
                    }
                    else
                    {
                        tB_end
                    }
                }
            }
        }
        #endregion

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_savetoclip_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tB_end.Text);
        }

        private void btn_delall_Click(object sender, EventArgs e)
        {
            tB_end.Text = "";
        }
    }
}
