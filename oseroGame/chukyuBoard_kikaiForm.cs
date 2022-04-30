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
    public partial class chukyuBoard_kikaiForm : BaseBoardForm
    {
        public chukyuBoard_kikaiForm()
        {
            InitializeComponent();
            
        }

        private void chukyuBoard_kikaiForm_Load(object sender, EventArgs e)
        {
            this.btn_next.Visible = true;
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
                    mainCLASS.boardIdentitiy[nextBannti] = mainCLASS.kikaicolor;
                    AI.allDirReturn(nextBannti);
                    this.Close();
                }
            } 
        }

        public override void click_event(int i)
        {
           // base.click_event(i);
        }
    }
}
