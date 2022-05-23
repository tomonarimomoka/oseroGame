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
    public partial class syokyuBoard_human : BaseBoardForm
    {
        public syokyuBoard_human()
        {
            InitializeComponent();
        }

        public override void trueNextVisible()
        {
            this.btn_next.Visible = true;
            //base.chengeNextVisible();
        }

        public override void falsePassVisible()
        {
            //base.falsePassVisible();
            this.btn_pass.Visible = false;
        }

        public override void truePassVisible()
        {
            //base.truePassVisible();
            this.btn_pass.Visible = true;
        }

        public override void falseNextVisible()
        {
            //base.falseNextVisible();
            this.btn_next.Visible = false;
        }
    }
}
