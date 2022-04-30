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
    public partial class BaseBoardForm : Form
    {
        public BaseBoardForm()
        {
            InitializeComponent();
            //if(mainCLASS.now_PLAYER == mainCLASS.kikai)
            //{
            //    this.btn_pass.Enabled = false;
            //}
        }

      
        public virtual void checkAndSaveCurrentBannti(int currentBannti)
        {
            DialogResult saveOrNo = MessageBox.Show("次に置く場所は" + currentBannti + "ですね？保存します。",
                "",
                MessageBoxButtons.YesNo);
            if (saveOrNo == DialogResult.No) { return; }

        }

        //ピクチャーボックスshow.chenge
        private void showChenge(Control pic_board, Control pic_p, Control pic_c)
        {
            if (mainCLASS.FirstOrSecond == 1)
            {
                pic_board.Visible = false;
                pic_p.Visible = true;
                pic_c.Visible = false;
            }
            else
            {
                pic_board.Visible = false;
                pic_p.Visible = false;
                pic_c.Visible = true;
            }
        }

        //ボードチェンジ
        public virtual void boardChenge(int bannti,string color)
        {
            mainCLASS.boardIdentitiy[bannti] = color;
            //if (mainCLASS.FirstOrSecond == 1)
            //{
            //    mainCLASS.boardIdentitiy[bannti] = "S;
            //}
            //else
            //{
            //    mainCLASS.boardIdentitiy[bannti] = "KURO";
            //}
        }
        private void changePlayer()
        {
            mainCLASS.now_PLAYER = mainCLASS.chengePlayer(mainCLASS.now_PLAYER);
            mainCLASS.gameCount++;
        }


        //ひっくり返せたら　True
        //ひっくり返せないなら　False
        //public bool canClickOrNot(int i)
        //{
        //    int count = 0;
        //    for (int x = -1; x <= 1; x++)
        //    {
        //        for (int y = -1; y <= 1; y++)
        //        {
        //            if (x == 0 && y == 0) { }
        //            else
        //            {
        //                count += AI.countStoneReturn(x, y, i);
        //            }
        //        }
        //    }
        //    if (count == 0)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        return true;
        //    }
        //}

        //何個ひっくり返せるか
        public int howManyReturn(int i)
        {
            int count = 0;
            for (int x = -1; x <= 1; x++)
            {
                for (int y = -1; y <= 1; y++)
                {
                    if (x == 0 && y == 0) { }
                    else
                    {
                        count += AI.countStoneReturn(x, y, i);
                    }
                }
            }

            return count;
        }
       public virtual void click_event(int i)
        {
            if (mainCLASS.onlyShowFlag==false&&mainCLASS.alreadyClickFlag ==false)
            {
                mainCLASS.bannti = i;
                mainCLASS.x = AI.getX(i);
                mainCLASS.y = AI.getY(i);
                if (howManyReturn(i) == 0)
                {
                    MessageBox.Show(i + "はひっくり返せる場所がないのでおけません。", "", MessageBoxButtons.OK);
                    return;
                }

                string pic_board = string.Format("pic_board{0}", (i + 1).ToString().PadLeft(2, '0'));
                string pic_p = string.Format("pic_p{0}", (i + 1).ToString().PadLeft(2, '0'));
                string pic_c = string.Format("pic_c{0}", (i + 1).ToString().PadLeft(2, '0'));
                string color = mainCLASS.now_PLAYER == mainCLASS.human ? mainCLASS.humancolor : mainCLASS.kikaicolor;


                checkAndSaveCurrentBannti(i);
                mainCLASS.boardIdentitiy[i] = color;
                AI.checkBetween(i);
                trueNextVisible();
                falsePassVisible();
                mainCLASS.alreadyClickFlag = true;
                this.Close();
                //this.btn_next.Visible = false;
            }

        }
    
        public virtual void trueNextVisible()
        {
            this.btn_next.Visible = true;
        }

        public virtual void falseNextVisible()
        {
            this.btn_next.Visible = false;
        }
        public virtual void falsePassVisible()
        {
            this.btn_pass.Visible = false;
        }

        public virtual void truePassVisible()
        {
            this.btn_pass.Visible = true;
        }

        public void showCurrentBoard()
        {
            for (int i = 0; i < (mainCLASS.x_size * mainCLASS.y_size); i++)
            {
                string pic_board = string.Format("pic_board{0}", (i + 1).ToString().PadLeft(2, '0'));
                string pic_p = string.Format("pic_p{0}",( i + 1).ToString().PadLeft(2, '0'));
                string pic_c = string.Format("pic_c{0}",( i + 1).ToString().PadLeft(2, '0'));

                BanntiInShowCurrentBoard(this.Controls[pic_board], this.Controls[pic_p], this.Controls[pic_c], i);

            }
        }

        //showCurrentBoardの中で使う関数
        //controlとはpictureBoxの親クラス
        public virtual void BanntiInShowCurrentBoard(Control pic_board, Control pic_p, Control pic_c, int bannti)
        {

            if (mainCLASS.boardIdentitiy[bannti] == "SHIRO")
            {
                pic_board.Visible = false;
                pic_p.Visible = true;
                pic_c.Visible = false;
            }
            else if (mainCLASS.boardIdentitiy[bannti] == "KURO")
            {
                pic_board.Visible = false;
                pic_p.Visible = false;
                pic_c.Visible = true;
            }
            else
            {
                pic_board.Visible = true;
                pic_p.Visible = false;
                pic_c.Visible = false;
            }
        }

        public int putCorner()
        {
            int returnNumber = -1;
            int first = 0;
            int second = mainCLASS.x_size-1;
            int thard = AI.coordinateBannti(0, mainCLASS.y_size - 1);
            int forth = mainCLASS.x_size * mainCLASS.y_size -1;
            if (howManyReturn(first) > 0)
            {
                returnNumber=first;
            }
            if(howManyReturn(second) > 0){
                returnNumber= second;
            }
            if(howManyReturn(thard) > 0){
                returnNumber = thard;
            }
            if(howManyReturn(forth) > 0){
                returnNumber = forth;
            }
            //mainCLASS.boardIdentitiy[returnNumber] = mainCLASS.kikaicolor;
            return returnNumber;
        }

        private void pic_board01_Click(object sender, EventArgs e)
        {
            click_event(0);
        }


        private void pic_board02_Click(object sender, EventArgs e)
        {
            click_event(1);
        }

        private void pic_board03_Click(object sender, EventArgs e)
        {
            click_event(2);
        }
        private void pic_board04_Click(object sender, EventArgs e)
        {
            click_event(3);
        }

        private void pic_board05_Click(object sender, EventArgs e)
        {
            click_event(4);
        }

        private void pic_board06_Click(object sender, EventArgs e)
        {
            click_event(5);
        }
        private void pic_board07_Click(object sender, EventArgs e)
        {
            click_event(6);
        }
        private void pic_board08_Click(object sender, EventArgs e)
        {
            click_event(7);
        }

        private void pic_board09_Click(object sender, EventArgs e)
        {
            click_event(8);
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BaseBoardForm_Load(object sender, EventArgs e)
        {
            if (mainCLASS.now_PLAYER == 1)
            {
                if (mainCLASS.onlyShowFlag == false)
                {
                    truePassVisible();
                    falseNextVisible();
                }
                else
                {
                    falsePassVisible();
                    trueNextVisible();
                }
            }
            showCurrentBoard();
           
        }

        private void pic_board10_Click(object sender, EventArgs e)
        {
            click_event(9);
        }

        private void pic_board11_Click(object sender, EventArgs e)
        {
            click_event(10);
        }

        private void pic_board12_Click(object sender, EventArgs e)
        {
            click_event(11);
        }

        private void pic_board13_Click(object sender, EventArgs e)
        {
            click_event(12);
        }

        private void pic_board14_Click(object sender, EventArgs e)
        {
            click_event(13);
        }

        private void pic_board15_Click(object sender, EventArgs e)
        {
            click_event(14);
        }

        private void pic_p16_Click(object sender, EventArgs e)
        {

        }

        private void pic_board16_Click(object sender, EventArgs e)
        {
            click_event(15);
        }

        private void pic_board17_Click(object sender, EventArgs e)
        {
            click_event(16);
        }

        private void pic_board18_Click(object sender, EventArgs e)
        {
            click_event(17);
        }

        private void pic_board19_Click(object sender, EventArgs e)
        {
            click_event(18);
        }

        private void pic_board20_Click(object sender, EventArgs e)
        {
            click_event(19);
        }

        private void pic_board21_Click(object sender, EventArgs e)
        {
            click_event(20);
        }

        private void pic_board22_Click(object sender, EventArgs e)
        {
            click_event(21);
        }

        private void pic_board23_Click(object sender, EventArgs e)
        {
            click_event(22);
        }

        private void pic_board24_Click(object sender, EventArgs e)
        {
            click_event(23);
        }

        private void pic_board25_Click(object sender, EventArgs e)
        {
            click_event(24);
        }

        private void pic_board26_Click(object sender, EventArgs e)
        {
            click_event(25);
        }

        private void pic_board27_Click(object sender, EventArgs e)
        {
            click_event(26);
        }

        private void pic_board28_Click(object sender, EventArgs e)
        {
            click_event(27);
        }

        private void pic_board29_Click(object sender, EventArgs e)
        {
            click_event(28);
        }

        private void pic_board30_Click(object sender, EventArgs e)
        {
            click_event(29);
        }

        private void pic_board31_Click(object sender, EventArgs e)
        {
            click_event(30);
        }

        private void pic_board32_Click(object sender, EventArgs e)
        {
            click_event(31);
        }

        private void pic_board33_Click(object sender, EventArgs e)
        {
            click_event(32);
        }

        private void pic_board34_Click(object sender, EventArgs e)
        {
            click_event(33);
        }

        private void pic_board35_Click(object sender, EventArgs e)
        {
            click_event(34);
        }

        private void pic_board36_Click(object sender, EventArgs e)
        {
            click_event(35);
        }

        private void pic_board37_Click(object sender, EventArgs e)
        {
            click_event(36);
        }

        private void pic_board38_Click(object sender, EventArgs e)
        {
            click_event(37);
        }

        private void pic_board39_Click(object sender, EventArgs e)
        {
            click_event(38);
        }

        private void pic_board40_Click(object sender, EventArgs e)
        {
            click_event(39);
        }

        private void pic_board41_Click(object sender, EventArgs e)
        {
            click_event(40);
        }

        private void pic_board42_Click(object sender, EventArgs e)
        {
            click_event(41);
        }

        private void pic_board43_Click(object sender, EventArgs e)
        {
            click_event(42);
        }

        private void pic_board44_Click(object sender, EventArgs e)
        {
            click_event(43);
        }

        private void pic_board45_Click(object sender, EventArgs e)
        {
            click_event(44);
        }

        private void pic_board46_Click(object sender, EventArgs e)
        {
            click_event(45);
        }

        private void pic_board47_Click(object sender, EventArgs e)
        {
            click_event(46);
        }

        private void pic_board48_Click(object sender, EventArgs e)
        {
            click_event(47);
        }

        private void pic_board49_Click(object sender, EventArgs e)
        {
            click_event(48);
        }

        private void pic_board50_Click(object sender, EventArgs e)
        {
            click_event(49);
        }

        private void pic_board51_Click(object sender, EventArgs e)
        {
            click_event(50);
        }

        private void pic_board52_Click(object sender, EventArgs e)
        {
            click_event(51);
        }

        private void pic_board53_Click(object sender, EventArgs e)
        {
            click_event(52);
        }

        private void pic_board54_Click(object sender, EventArgs e)
        {
            click_event(53);
        }

        private void pic_board55_Click(object sender, EventArgs e)
        {
            click_event(54);
        }

        private void pic_board56_Click(object sender, EventArgs e)
        {
            click_event(55);
        }

        private void pic_c56_Click(object sender, EventArgs e)
        {

        }

        private void pic_board57_Click(object sender, EventArgs e)
        {
            click_event(56);
        }

        private void pic_board58_Click(object sender, EventArgs e)
        {
            click_event(57);
        }

        private void pic_board59_Click(object sender, EventArgs e)
        {
            click_event(58);
        }

        private void pic_board60_Click(object sender, EventArgs e)
        {
            click_event(59);
        }

        private void pic_board61_Click(object sender, EventArgs e)
        {
            click_event(60);
        }

        private void pic_board62_Click(object sender, EventArgs e)
        {
            click_event(61);
        }

        private void pic_board63_Click(object sender, EventArgs e)
        {
            click_event(62);
        }

        private void pic_board64_Click(object sender, EventArgs e)
        {
            click_event(63);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainCLASS.showWinner();
        }

        private void btn_pass_Click(object sender, EventArgs e)
        {
            //パスを押す
            mainCLASS.passFlag = true;
            //string color = mainCLASS.now_PLAYER == mainCLASS.human ? mainCLASS.humancolor : mainCLASS.kikaicolor;
            //

            this.Close();
        }


    }
}
