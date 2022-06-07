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
    public partial class settaiBoard_human : BaseBoardForm
    {
        public settaiBoard_human()
        {
            InitializeComponent();
        }


        public override bool checkSaveCurrentBanntiOrNot(int currentBannti)
        {
            bool saveFlag = true;
            DialogResult saveOrNo = MessageBox.Show("次に置く場所は" + currentBannti + "でしょうか？保存させて頂きます🙇",
                "",
                MessageBoxButtons.YesNo);
            if (saveOrNo == DialogResult.No) { saveFlag = false; }

            return saveFlag;

        }


        public override void click_event(int i)
        {
            mainCLASS.bannti = i;
            mainCLASS.x = AI.getX(i);
            mainCLASS.y = AI.getY(i);
            int returnCount = howManyReturn(i);
            if (returnCount == 0)
            {
                MessageBox.Show("大変申し訳ございませんが、" + i + "はひっくり返せる場所がないのでおけません。", "", MessageBoxButtons.OK);
                return;
            }



            if (checkSaveCurrentBanntiOrNot(i))
            {
                string pic_board = string.Format("pic_board{0}", (i + 1).ToString().PadLeft(2, '0'));
                string pic_p = string.Format("pic_p{0}", (i + 1).ToString().PadLeft(2, '0'));
                string pic_c = string.Format("pic_c{0}", (i + 1).ToString().PadLeft(2, '0'));
                string color = mainCLASS.now_PLAYER == mainCLASS.human ? mainCLASS.humancolor : mainCLASS.kikaicolor;

                mainCLASS.boardIdentitiy[i] = color;
                AI.checkBetween(i);
                trueNextVisible();
                falsePassVisible();
                mainCLASS.alreadyClickFlag = true;
            }


            //this.btn_pass.Visible = false;
            if (returnCount >= 3)
            {
                MessageBox.Show(returnCount + "個もひっくり返せました！すごい♡♡♡", "", MessageBoxButtons.OK);
            }
            this.Close();


        }
        public override void trueNextVisible()
        {
            this.btn_next.Visible = true;
        }

        public override void falsePassVisible()
        {
            // base.falsePassVisible();
            this.btn_pass.Visible = false;
        }
    }
}
