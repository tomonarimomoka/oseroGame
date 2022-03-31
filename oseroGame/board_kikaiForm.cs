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
    public partial class board_kikaiForm : BaseBoardForm
    {
        public board_kikaiForm()
        {
            InitializeComponent();
        }

        //ボードチェンジ
        //public override  void boardChenge(int bannti)
        //{
        //    if (mainCLASS.FirstOrSecond == 2)
        //    {
        //        mainCLASS.boardIdentitiy[bannti] = "SHIRO";
        //    }
        //    else
        //    {
        //        mainCLASS.boardIdentitiy[bannti] = "KURO" ;
        //    }
        //}
        
        private void board_kikaiForm_Load(object sender, EventArgs e)
        {
            if (mainCLASS.onlyShowFlag == false)
            {
                int nextBannti;
                if (putCorner() == -1)
                {
                    nextBannti = AI.saveKikaiBannti(mainCLASS.kikaicolor);
                    AI.allDirReturn(nextBannti);
                    this.Close();
                }
                else
                {
                    nextBannti = putCorner();
                    AI.allDirReturn(nextBannti);
                    this.Close();
                }
            }

            
        }

    }
}
