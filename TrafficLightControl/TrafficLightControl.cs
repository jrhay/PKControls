using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortableKnowledge.Controls
{
    /// <summary>
    /// State of the condition being monitored by the TrafficLightControl
    /// </summary>
    public enum TrafficLightControlState
    {
        None,
        Good,
        Warning,
        Bad,
        GoodWarning,
        BadWarning,
        GoodBad,
        All
    }

    public partial class TrafficLightControl : UserControl
    {
        private List<TrafficLightControl> _SlaveLights = new List<TrafficLightControl>();

        private TrafficLightControlState _State;
        /// <summary>
        /// Current state to display
        /// </summary>
        public TrafficLightControlState State
        {
            get { return _State; }
            set {
                _State = value;
                SetImageForState();

                foreach (TrafficLightControl light in _SlaveLights)
                    light.State = _State;
            }
        }

        /// <summary>
        /// Message to display to user on mouse-over
        /// </summary>
        public String Message
        {
            get { return GetMessage(); }
            set {
                SetMessage(value);
                foreach (TrafficLightControl light in _SlaveLights)
                    light.Message = Message;
            }
        }

        // BlinkTimer is a System.Threading.Timer rather than a Windows.Forms.Timer because we want
        // to blink properly, even if the main thread is tied up.
        System.Threading.Timer _blinkTimer;
        private Boolean _blinkOn = true;
        private int _blinkRate;

        /// <summary>
        /// The rate of blinking of the light, in milliseconds.  0 = no blinking.
        /// </summary>
        public int BlinkRate
        {
            get
            {
                return _blinkRate;
            }
            set
            {
                _blinkRate = value;

                _blinkTimer?.Dispose();

                _blinkOn = true;

                if (value > 0)
                    _blinkTimer = new System.Threading.Timer(BlinkTimerCallback, null, _blinkRate, 0);
                else
                    SetImageForState(false);

                foreach (TrafficLightControl light in _SlaveLights)
                    light.BlinkRate = _blinkRate;
            }
        }

        private void BlinkTimerCallback(Object state)
        {
            if (_blinkRate > 0)
            {
                SetImageForState(!_blinkOn);
                _blinkOn = !_blinkOn;
                _blinkTimer = new System.Threading.Timer(BlinkTimerCallback, null, _blinkRate, 0);
            }
            else
            {
                _blinkOn = true;
                SetImageForState(false);
            }
        }


        /// <summary>
        /// Update an external control to reflect the state of this control
        /// </summary>
        /// <param name="slave">Control to update</param>
        public void UpdateExternalControl(TrafficLightControl slave)
        {
            if (slave != null)
            {
                slave.State = _State;
                slave.Message = GetMessage();
                slave.BlinkRate = _blinkRate;
            }
        }

        /// <summary>
        /// Add a slave control that will always autmatically reflect the state of this
        /// control, until removed with RemoveSlave().
        /// </summary>
        /// <param name="slave">Slave control to add</param>
        public void AddSlave(TrafficLightControl slave)
        {
            if (slave != null)
            {
                _SlaveLights.Add(slave);
                UpdateExternalControl(slave);
            }
        }

        /// <summary>
        /// Remove an existing slaved control
        /// </summary>
        /// <param name="slave">Control to remove as a slave to this control</param>
        public void RemoveSlave(TrafficLightControl slave)
        {
            _SlaveLights.Remove(slave);
        }
                
        private Bitmap LightImages = null;

        public TrafficLightControl()
        {
            InitializeComponent();
            pictureBox1.BackColor = Color.Transparent;
            toolTip1.OwnerDraw = true;
            LightImages = global::PortableKnowledge.Controls.Properties.Resources.TrafficLightControlImages;
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            if (LightImages != null)
            {
                BlinkRate = 0;
                LightImages.Dispose();
                LightImages = null;
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Change the state and message of the traffic light control in one step
        /// </summary>
        /// <param name="State">New state to change to</param>
        /// <param name="Message">New Message, NULL for no message</param>
        public void ChangeState(TrafficLightControlState State, String Message = null)
        {
            this.State = State;
            this.Message = Message;
        }

        private Object ImageLock = new Object();
        private void SetImageForState(Boolean ForceOff = false)
        {
            Rectangle imageRect;

            if (LightImages == null)
                return;

            Debug.WriteLine("State: " + _State + "(Force Off: " + ForceOff + ")");
            switch (ForceOff ? TrafficLightControlState.None : _State)
            {
                case TrafficLightControlState.Good:
                    imageRect = new Rectangle(323, 163, 260, 100);
                    if (!ForceOff)
                        toolTip1.BackColor = Color.PaleGreen;
                    break;
                case TrafficLightControlState.Bad:
                    imageRect = new Rectangle(323, 449, 260, 100);
                    if (!ForceOff)
                        toolTip1.BackColor = Color.IndianRed;
                    break;
                case TrafficLightControlState.Warning:
                    imageRect = new Rectangle(323, 306, 260, 100);
                    if (!ForceOff)
                        toolTip1.BackColor = Color.Yellow;
                    break;
                case TrafficLightControlState.GoodWarning:
                    imageRect = new Rectangle(29, 449, 260, 100);
                    if (!ForceOff)
                        toolTip1.BackColor = Color.GreenYellow;
                    break;
                case TrafficLightControlState.GoodBad:
                    imageRect = new Rectangle(29, 306, 260, 100);
                    if (!ForceOff)
                        toolTip1.BackColor = Color.MediumVioletRed;
                    break;
                case TrafficLightControlState.BadWarning:
                    imageRect = new Rectangle(29, 163, 260, 100);
                    if (!ForceOff)
                        toolTip1.BackColor = Color.OrangeRed;
                    break;
                case TrafficLightControlState.All:
                    imageRect = new Rectangle(29, 20, 260, 100);
                    if (!ForceOff)
                        toolTip1.BackColor = Color.WhiteSmoke;
                    break;
                default:
                    imageRect = new Rectangle(323, 20, 260, 100);
                    toolTip1.BackColor = this.BackColor;
                    break;
            }

            SetPictureImage(imageRect);
        }

        private void SetPictureImage(Rectangle Frame)
        {
            if (pictureBox1.InvokeRequired)
            {
                //pictureBox1.BeginInvoke(new MethodInvoker(delegate () { SetPictureImage(Frame); }));
                pictureBox1.Invoke(new MethodInvoker(delegate () { SetPictureImage(Frame); }));
            }
            else
            {
                try
                {
                    pictureBox1.SuspendLayout();
                    if (pictureBox1.Image != null)
                        pictureBox1.Image.Dispose();

                    pictureBox1.Image = LightImages.Clone(Frame, LightImages.PixelFormat);
                    pictureBox1.ResumeLayout();
                } catch 
                {
                }
            }
        }

        private void SetMessage(String NewMessage)
        {
            if (pictureBox1.InvokeRequired)
            {
                pictureBox1.BeginInvoke(new MethodInvoker(delegate () { SetMessage(NewMessage); }));
            }
            else
                toolTip1.SetToolTip(pictureBox1, NewMessage);
        }

        private String GetMessage()
        {
            return toolTip1.GetToolTip(pictureBox1);
        }


        private void toolTip1_Draw(object sender, DrawToolTipEventArgs e)
        {
            e.DrawBackground();
            e.DrawBorder();
            e.DrawText();
        }
    }
}
