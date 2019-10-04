using PortableKnowledge.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlTesters 
{
    public partial class frmTrafficLightTester : Form
    {
        public frmTrafficLightTester()
        {
            InitializeComponent();
            trafficLightControl1.Message = "Traffic Light Control Message";
            trafficLightControl1.BlinkRate = 0;
        }

        private void chkState_CheckedChanged(object sender, EventArgs e)
        {
            if ((chkGood.Checked && chkBad.Checked && chkWarning.Checked))
                trafficLightControl1.State = TrafficLightControlState.All;
            else if (chkGood.Checked)
            {
                if (chkWarning.Checked)
                    trafficLightControl1.State = TrafficLightControlState.GoodWarning;
                else if (chkBad.Checked)
                    trafficLightControl1.State = TrafficLightControlState.GoodBad;
                else
                    trafficLightControl1.State = TrafficLightControlState.Good;
            }
            else if (chkBad.Checked)
            {
                if (chkWarning.Checked)
                    trafficLightControl1.State = TrafficLightControlState.BadWarning;
                else
                    trafficLightControl1.State = TrafficLightControlState.Bad;
            }
            else
                trafficLightControl1.State = (chkWarning.Checked ? TrafficLightControlState.Warning : TrafficLightControlState.None);
        }
    }
}
