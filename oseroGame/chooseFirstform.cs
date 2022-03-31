using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oseroGame
{
    public partial class chooseFirstform : Form
    {
        public chooseFirstform()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmb_firstOrSecond_SelectedIndexChanged(object sender, EventArgs e)
        {
              
        }

        private int btn_save_Click(object sender, EventArgs e)
        {
            while (cmb_firstOrSecond.SelectedIndex == 0) { 
            
                MessageBox.Show("先攻、後攻を選択して下さい。",
                    "　",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation
                );
                if (cmb_firstOrSecond.SelectedIndex != 0) { break; }
            

            }

            //もし何かエラーが起きた時のために何も選択せずに進めてしまったときは先攻にする。
            int firstOrSecond = cmb_firstOrSecond.SelectedItem == null ? 1  : Convert.ToInt32( cmb_firstOrSecond.SelectedItem);

            return firstOrSecond;
        }

        int firstOrSecond = btn_save_Click(sender, e);
    }
}
