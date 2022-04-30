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
    public partial class settaiBoard_kikaiForm : BaseBoardForm
    {
        public settaiBoard_kikaiForm()
        {
            InitializeComponent();
        }

        private void settaiBoard_kikaiForm_Load(object sender, EventArgs e)
        {
            this.btn_next.Visible = true;
            if (mainCLASS.onlyShowFlag == false)
            {
                int nextBannti;
                //おけたら4角に置く。
                if (putCorner() == -1)
                {
                    nextBannti = AI.saveKikaiBannti(mainCLASS.kikaicolor);
                    AI.allDirReturn(nextBannti);
                    this.Close();
                }
                else
                {
                    nextBannti = putCorner();
                    mainCLASS.boardIdentitiy[nextBannti] = mainCLASS.kikaicolor;
                    AI.allDirReturn(nextBannti);
                    this.Close();
                }
            }

        }

        public override void click_event(int i)
        {
            //base.click_event(i);
        }

    }
}
