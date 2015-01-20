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
        bool glock = false;
        bool p250 = false;
        bool deagle = false;
        bool dualb = false;
        bool tec9 = false;
        bool p2000 = false;
        bool usp = false;
        bool cz75 = false;
        bool awp = false;
        bool m4a4 = false;
        bool m4a1 = false;
        bool ak47 = false;
        bool scout = false;
        bool aug = false;
        bool sgg = false;
        bool ppbizon = false;
        bool autot = false;
        bool autoct = false;
        bool ump45 = false;
        bool negev = false;
        bool nova = false;
        bool mp7 = false;
        bool mp9 = false;
        bool swag7 = false;
        bool sawedoff = false;
        bool xm = false;
        bool mac10 = false;
        bool m249 = false;

        public Form1()
        {
            InitializeComponent();
            
        }
        //fail
        #region erros
        private void Form1_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.english == true)
            {
                btn_delall.Text = "Delete all";
            }
            else
            {
                btn_delall.Text = "Alles löschen";
            }
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
    #endregion
        #region if else

        private void btn_getcommand_Click(object sender, EventArgs e)
        {
            if(cb_glock.Checked == true)
            {
                tB_end.Text = "bind " + tb_key.Text + rtb_commands.Text;
                glock = true;
            }

            if(cb_p250.Checked == true)
            {
                tB_end.Text = "bind " + tb_key.Text + rtb_commands.Text;
                p250 = true;
            }

            if(cb_deagle.Checked == true)
            {
                tB_end.Text = "bind " + tb_key.Text + rtb_commands.Text;
                deagle = true;
            }

            if(cb_dualb.Checked == true)
            {
                tB_end.Text = "bind " + tb_key.Text + rtb_commands.Text;
                dualb = true;
            }

            if(cb_tecß.Checked == true)
            {
                tB_end.Text = "bind " + tb_key.Text + rtb_commands.Text;
                tec9 = true;
            }

            if(cb_p2000.Checked == true)
            {
                tB_end.Text = "bind " + tb_key.Text + rtb_commands.Text;
                p2000 = true;
            }

            if(cb_usp.Checked == true)
            {
                tB_end.Text = "bind " + tb_key.Text + rtb_commands.Text;
                usp = true;
            }

            if(cb_cz75.Checked == true)
            {
                tB_end.Text = "bind " + tb_key.Text + rtb_commands.Text;
                cz75 = true;
            }

            if(cb_awp.Checked == true)
            {
                tB_end.Text = "bind " + tb_key.Text + rtb_commands.Text;
                awp = true;
            }

            if(cb_m4a4.Checked == true)
            {
                tB_end.Text = "bind " + tb_key.Text + rtb_commands.Text;
                m4a4 = true;
            }

            if(cb_ak47.Checked == true)
            {
                tB_end.Text = "bind " + tb_key.Text + rtb_commands.Text;
                ak47 = true;
            }

            if(cb_scout.Checked == true)
            {
                tB_end.Text = "bind " + tb_key.Text + rtb_commands.Text;
                scout = true;
            }

            if(cb_aug.Checked == true)
            {
                tB_end.Text = "bind " + tb_key.Text + rtb_commands.Text;
                aug = true;
            }

            if(cb_sgg.Checked == true)
            {
                tB_end.Text = "bind " + tb_key.Text + rtb_commands.Text;
                sgg = true;
            }

            if(cb_ppbizon.Checked == true)
            {
                tB_end.Text = "bind " + tb_key.Text + rtb_commands.Text;
                ppbizon = true;
            }

            if(cb_autoct.Checked == true)
            {
                tB_end.Text = "bind " + tb_key.Text + rtb_commands.Text;
                autoct = true;
            }

            if(cb_autot.Checked == true)
            {
                tB_end.Text = "bind " + tb_key.Text + rtb_commands.Text;
                autot = true;
            }

            if(cb_ump45.Checked == true)
            {
                tB_end.Text = "bind " + tb_key.Text + rtb_commands.Text;
                ump45 = true;
            }

            if(cb_negev.Checked == true)
            {
                tB_end.Text = "bind " + tb_key.Text + rtb_commands.Text;
                negev = true;
            }

            if(cb_nova.Checked == true)
            {
                tB_end.Text = "bind " + tb_key.Text + rtb_commands.Text;
                nova = true;
            }

            if(cb_mp7.Checked == true)
            {
                tB_end.Text = "bind " + tb_key.Text + rtb_commands.Text;
                mp7 = true;
            }

            if(cb_swag7.Checked == true)
            {
                tB_end.Text = "bind " + tb_key.Text + rtb_commands.Text;
                swag7 = true;
            }

            if(cb_sawedoff.Checked == true)
            {
                tB_end.Text = "bind " + tb_key.Text + rtb_commands.Text;
                sawedoff = true;
            }

            if(cb_xm.Checked == true)
            {
                tB_end.Text = "bind " + tb_key.Text + rtb_commands.Text;
                xm = true;
            }

            if(cb_mp9.Checked == true)
            {
                tB_end.Text = "bind " + tb_key.Text + rtb_commands.Text;
                mp9 = true;
            }

            if(cb_mac10.Checked == true)
            {
                tB_end.Text = "bind " + tb_key.Text + rtb_commands.Text;
                mac10 = true;
            }

            if(cb_m249.Checked == true)
            {
                tB_end.Text = "bind " + tb_key.Text + rtb_commands.Text;
                m249 = true;
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
             glock = false;
             p250 = false;
             deagle = false;
             dualb = false;
             tec9 = false;
             p2000 = false;
             usp = false;
             cz75 = false;
             awp = false;
             m4a4 = false;
             m4a1 = false;
             ak47 = false;
             scout = false;
             aug = false;
             sgg = false;
             ppbizon = false;
             autot = false;
             autoct = false;
             ump45 = false;
             negev = false;
             nova = false;
             mp7 = false;
             mp9 = false;
             swag7 = false;
             sawedoff = false;
             xm = false;
             mac10 = false;
             m249 = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bt_options_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
        }
    }
}
