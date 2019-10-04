namespace ControlTesters
{
    partial class frmMainTester
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
            this.button1 = new System.Windows.Forms.Button();
            this.ctlNumTag1 = new PortableKnowledge.Controls.ctlNumTag();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Test Traffic Light Control...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ctlNumTag1
            // 
            this.ctlNumTag1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ctlNumTag1.Description = "ctlNumTag";
            this.ctlNumTag1.Location = new System.Drawing.Point(283, 24);
            this.ctlNumTag1.Name = "ctlNumTag1";
            this.ctlNumTag1.Size = new System.Drawing.Size(153, 83);
            this.ctlNumTag1.TabIndex = 1;
            this.ctlNumTag1.Value = 100;
            // 
            // frmMainTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 140);
            this.Controls.Add(this.ctlNumTag1);
            this.Controls.Add(this.button1);
            this.Name = "frmMainTester";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private PortableKnowledge.Controls.ctlNumTag ctlNumTag1;
    }
}

