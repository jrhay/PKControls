using PortableKnowledge.Controls;

namespace ControlTesters
{
    partial class frmTrafficLightTester
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.trafficLightControl1 = new TrafficLightControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkBad = new System.Windows.Forms.CheckBox();
            this.chkWarning = new System.Windows.Forms.CheckBox();
            this.chkGood = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // trafficLightControl1
            // 
            this.trafficLightControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trafficLightControl1.Location = new System.Drawing.Point(17, 19);
            this.trafficLightControl1.Name = "trafficLightControl1";
            this.trafficLightControl1.Size = new System.Drawing.Size(168, 67);
            this.trafficLightControl1.State = TrafficLightControlState.None;
            this.trafficLightControl1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.trafficLightControl1);
            this.groupBox1.Location = new System.Drawing.Point(132, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Traffic Light Control";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkBad);
            this.groupBox2.Controls.Add(this.chkWarning);
            this.groupBox2.Controls.Add(this.chkGood);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(103, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "State";
            // 
            // chkBad
            // 
            this.chkBad.AutoSize = true;
            this.chkBad.Location = new System.Drawing.Point(17, 70);
            this.chkBad.Name = "chkBad";
            this.chkBad.Size = new System.Drawing.Size(45, 17);
            this.chkBad.TabIndex = 5;
            this.chkBad.Text = "Bad";
            this.chkBad.UseVisualStyleBackColor = true;
            this.chkBad.CheckedChanged += new System.EventHandler(this.chkState_CheckedChanged);
            // 
            // chkWarning
            // 
            this.chkWarning.AutoSize = true;
            this.chkWarning.Location = new System.Drawing.Point(17, 47);
            this.chkWarning.Name = "chkWarning";
            this.chkWarning.Size = new System.Drawing.Size(66, 17);
            this.chkWarning.TabIndex = 4;
            this.chkWarning.Text = "Warning";
            this.chkWarning.UseVisualStyleBackColor = true;
            this.chkWarning.CheckedChanged += new System.EventHandler(this.chkState_CheckedChanged);
            // 
            // chkGood
            // 
            this.chkGood.AutoSize = true;
            this.chkGood.Location = new System.Drawing.Point(17, 24);
            this.chkGood.Name = "chkGood";
            this.chkGood.Size = new System.Drawing.Size(52, 17);
            this.chkGood.TabIndex = 3;
            this.chkGood.Text = "Good";
            this.chkGood.UseVisualStyleBackColor = true;
            this.chkGood.CheckedChanged += new System.EventHandler(this.chkState_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 122);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Traffic Light Control Tester";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PortableKnowledge.Controls.TrafficLightControl trafficLightControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkGood;
        private System.Windows.Forms.CheckBox chkBad;
        private System.Windows.Forms.CheckBox chkWarning;
    }
}

