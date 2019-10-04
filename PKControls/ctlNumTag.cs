using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortableKnowledge.Controls
{
    public partial class ctlNumTag : UserControl
    {
        public ctlNumTag()
        {
            InitializeComponent();
            lblText.Text = this.Name;
        }

        [Category("Appearance")]
        [Description("Numeric value displayed")]
        public int Value
        {
            get { return int.Parse(lblValue.Text); }
            set { lblValue.Text = value.ToString(); }
        }

        [Category("Appearance")]
        [Description("Description of value")]
        public string Description
        {
            get { return lblText.Text; }
            set { lblText.Text = value; }
        }

        [Category("Appearance")]
        [Description("Color of tag border")]
        public Color BorderColor
        {
            get { return pnlTop.BackColor; }
            set
            {
                pnlTop.BackColor = value;
                pnlBottom.BackColor = value;
                pnlLeft.BackColor = value;
                pnlRight.BackColor = value;
            }
        }

        public override Color BackColor {
            get => pnlTag.BackColor;
            set => pnlTag.BackColor = value;
        }

    }
}
