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
    #endregion
        #region if else
        private void btn_getcommand_Click(object sender, EventArgs e)
        {
            if(cb_glock.Checked == true)
            {
                tB_end.Text = "bind " + tb_key.Text + rtb_commands.Text;
            }

            if(cb_p250.Checked == true)
            {
                tB_end.Text = "bind " + tb_key.Text + rtb_commands.Text;
            }

            if(cb_deagle.Checked == true)
            {
                tB_end.Text = "bind " + tb_key.Text + rtb_commands.Text;
            }

            if(cb_dualb.Checked == true)
            {
                tB_end.Text = "bind " + tb_key.Text + rtb_commands.Text;
            }

            if(cb_tecß.Checked == true)
            {
                tB_end.Text = "bind " + tb_key.Text + rtb_commands.Text;
            }

            if(cb_p2000.Checked == true)
            {
                tB_end.Text = "bind " + tb_key.Text + rtb_commands.Text;
            }

            if(cb_usp.Checked == true)
            {
                tB_end.Text = "bind " + tb_key.Text + rtb_commands.Text;
            }

            if(cb_cz75.Checked == true)
            {
                tB_end.Text = "bind " + tb_key.Text + rtb_commands.Text;
            }

            if(cb_awp.Checked == true)
            {
                tB_end.Text = "bind " + tb_key.Text + rtb_commands.Text;
            }

            if(cb_m4a4.Checked == true)
            {
                tB_end.Text = "bind " + tb_key.Text + rtb_commands.Text;
            }

            if(cb_ak47.Checked == true)
            {
                tB_end.Text = "bind " + tb_key.Text + rtb_commands.Text;
            }

            if(cb_scout.Checked == true)
            {
                tB_end.Text = "bind " + tb_key.Text + rtb_commands.Text;
            }

            if(cb_aug.Checked == true)
            {
                tB_end.Text = "bind " + tb_key.Text + rtb_commands.Text;
            }

            if(cb_sgg.Checked == true)
            {
                tB_end.Text = "bind " + tb_key.Text + rtb_commands.Text;
            }

            if(cb_ppbizon.Checked == true)
            {
                tB_end.Text = "bind " + tb_key.Text + rtb_commands.Text;
            }

            if(cb_autoct.Checked == true)
            {
                tB_end.Text = "bind " + tb_key.Text + rtb_commands.Text;
            }

            if(cb_autot.Checked == true)
            {
                tB_end.Text = "bind " + tb_key.Text + rtb_commands.Text;
            }

            if(cb_ump45.Checked == true)
            {
                tB_end.Text = "bind " + tb_key.Text + rtb_commands.Text;
            }

            if(cb_negev.Checked == true)
            {
                tB_end.Text = "bind " + tb_key.Text + rtb_commands.Text;
            }

            if(cb_nova.Checked == true)
            {
                tB_end.Text = "bind " + tb_key.Text + rtb_commands.Text;
            }

            if(cb_mp7.Checked == true)
            {
                tB_end.Text = "bind " + tb_key.Text + rtb_commands.Text;
            }

            if(cb_swag7.Checked == true)
            {
                tB_end.Text = "bind " + tb_key.Text + rtb_commands.Text;
            }

            if(cb_sawedoff.Checked == true)
            {
                tB_end.Text = "bind " + tb_key.Text + rtb_commands.Text;
            }

            if(cb_xm.Checked == true)
            {
                tB_end.Text = "bind " + tb_key.Text + rtb_commands.Text;
            }

            if(cb_mp9.Checked == true)
            {
                tB_end.Text = "bind " + tb_key.Text + rtb_commands.Text;
            }

            if(cb_mac10.Checked == true)
            {
                tB_end.Text = "bind " + tb_key.Text + rtb_commands.Text;
            }

            if(cb_m249.Checked == true)
            {
                tB_end.Text = "bind " + tb_key.Text + rtb_commands.Text;
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

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
