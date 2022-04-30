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
    public partial class chukyuBoard_Human : BaseBoardForm
    {
        public chukyuBoard_Human()
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
    }
}
