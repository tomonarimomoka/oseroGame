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
    public partial class joukyuBoard_human : BaseBoardForm
    {
        public joukyuBoard_human()
        {
            InitializeComponent();
        }

        public override void trueNextVisible()
        {
            this.btn_next.Visible = true;
        }

        public override void falsePassVisible()
        {
            //base.falsePassVisible();
            this.btn_pass.Visible = false;
        }

        public override void falseNextVisible()
        {
            // base.falseNextVisible();

            this.btn_next.Visible = false;
        }

        public override void truePassVisible()
        {
            //base.truePassVisible();

            this.btn_pass.Visible = true;
        }

        //これすらもいらない
        //public override void click_event(int i)
        //{
        //    base.click_event(i);
        //    mainCLASS.lastHumanBannti = i;
        //}
    }
}

