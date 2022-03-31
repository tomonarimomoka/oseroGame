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
    public partial class chooseFirstOrSecondForm : Form
    {
        public chooseFirstOrSecondForm()
        {
            InitializeComponent();
        }

        private void cmb_firstOrSecond_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    

        private void btn_save_Click(object sender, EventArgs e)
        {
            //whileにしていたが早田さんにアドバイスもらったのでifに変更
            if (cmb_firstOrSecond.SelectedIndex == 0
                &&cmb_firstOrSecond.SelectedIndex == -1)
            {

                MessageBox.Show("先攻、後攻を選択して下さい。",
                    "　",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation
                );
                return;
            }
            else { 
                mainCLASS.FirstOrSecond =cmb_firstOrSecond.SelectedIndex;
              if(cmb_firstOrSecond.SelectedIndex == 1)
                {
                    mainCLASS.humancolor = "SHIRO";
                    mainCLASS.kikaicolor = "KURO";
                    mainCLASS.now_PLAYER = mainCLASS.human;
                }
                else
                {
                    mainCLASS.humancolor = "KURO";
                    mainCLASS.kikaicolor = "SHIRO";
                    mainCLASS.now_PLAYER = mainCLASS.kikai;
                }
                //return;
            }
            Close();

            //もし何かエラーが起きた時のために何も選択せずに進めてしまったときは先攻にする。
            //int FirstOrSecond = cmb_firstOrSecond.SelectedItem == null ? 1 : Convert.ToInt32(cmb_firstOrSecond.SelectedItem);
            // public int pb_firstOrSecond = firstOrSecond;
            //return firstOrSecond;

          //  board_human board1 = new board();
            //board1.Show();

            ////board1.showFirst();
            ////board1.Show();
            //while (mainCLASS.checkBlank())
            //{

            //    board1.Show();
            //    //AI.checkBetween();
            //    //board_humanForm.Close();
            //    mainCLASS. now_PLAYER = mainCLASS. chengePlayer(mainCLASS.now_PLAYER);
            //    mainCLASS. gameCount++;


            //}
        }
    }
}
