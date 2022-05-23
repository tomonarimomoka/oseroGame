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
    public partial class syokyuBoard_kikaiForm : BaseBoardForm
    {
        public syokyuBoard_kikaiForm()
        {
            InitializeComponent();
        }

        private void syokyuBoard_kikaiForm_Load(object sender, EventArgs e)
        {
            this.btn_next.Visible = true;
            if (mainCLASS.onlyShowFlag == false)
            {
                int blankCount = 0;
                int[] boardBlank = new int[mainCLASS.x_size * mainCLASS.y_size + 1];
                //ランダムで打つために空いているばんちを boardBlankに記録しておく。
                for (int i = 0; i < mainCLASS.x_size * mainCLASS.y_size; i++)
                {
                    if (mainCLASS.boardIdentitiy[i] == " " && howManyReturn(i) > 0)
                    {
                        boardBlank[blankCount] = i;
                        blankCount++;
                    }
                }

                if (blankCount > 0)
                {
                    Random random = new Random();
                    int randomvalue = random.Next(blankCount);
                    int bannti = boardBlank[randomvalue];
                    mainCLASS.boardIdentitiy[bannti] = mainCLASS.kikaicolor;
                    //ひっくり返す
                    AI.allDirReturn(bannti);
                }

                

                ////要回収
                ////ひっくり返す
                //if (computerRondom(blankBoardRandom()) != 0)
                //{
                //    AI.allDirReturn(computerRondom(blankBoardRandom()));
                //}

                this.Close();

            }
            
        }


        public override void click_event(int i)
        {
           // base.click_event(i);    
        }

        //javaより
        //機械がランダムで打つとき
        public static int[] blankBoardRandom()
        {
            int blankCount = 0;
            int[] boardBlank = new int[mainCLASS.x_size * mainCLASS.y_size + 1];

            for (int i = 0; i < mainCLASS.x_size * mainCLASS.y_size; i++)
            {
                //もし元のボードが空いていれば
                if (mainCLASS.boardIdentitiy[i] == " ")
                {
                    //その空いている場所と同じ場所のボードブランクに数字を入れる
                    boardBlank[blankCount + 1] = i;
                    //ブランクカウントに１＋
                    blankCount++;
                }
            }
            boardBlank[0] = blankCount;
            // System.out.println(boardBlank[0] + "," + boardBlank[1] + "," + boardBlank[2] + "," + boardBlank[3] + "," + boardBlank[4] + "," + boardBlank[5] + "," + boardBlank[6] + "," + boardBlank[7] + "," + boardBlank[8] + "," + boardBlank[9]);
            return boardBlank;
        }


        public static int computerRondom(int[] boardBlankRandom)
        {
            //boardBlankRandomが０より多きい（＝空きがある）なら、ランダムにうつ。
            int bannti = -1;
            if (0 < boardBlankRandom[0])
            {
                Random random = new Random();
                int randomvalue = random.Next(1,boardBlankRandom[0]);
                bannti = boardBlankRandom[randomvalue];
                mainCLASS.boardIdentitiy[bannti] = mainCLASS.kikaicolor;

            }

            return bannti;
        }
    }
}
    

