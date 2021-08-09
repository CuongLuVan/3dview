namespace _3dview
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnReset = new System.Windows.Forms.Button();
            this.tX = new System.Windows.Forms.TrackBar();
            this.tY = new System.Windows.Forms.TrackBar();
            this.tZ = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.picCube = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCube)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(905, 12);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 38);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "button1";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // tX
            // 
            this.tX.Location = new System.Drawing.Point(837, 80);
            this.tX.Name = "tX";
            this.tX.Size = new System.Drawing.Size(235, 45);
            this.tX.TabIndex = 1;
            // 
            // tY
            // 
            this.tY.Location = new System.Drawing.Point(837, 173);
            this.tY.Name = "tY";
            this.tY.Size = new System.Drawing.Size(245, 45);
            this.tY.TabIndex = 2;
            // 
            // tZ
            // 
            this.tZ.Location = new System.Drawing.Point(842, 252);
            this.tZ.Name = "tZ";
            this.tZ.Size = new System.Drawing.Size(230, 45);
            this.tZ.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(849, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "tx";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(849, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "ty";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(849, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "tz";
            // 
            // picCube
            // 
            this.picCube.Location = new System.Drawing.Point(-2, 0);
            this.picCube.Name = "picCube";
            this.picCube.Size = new System.Drawing.Size(817, 606);
            this.picCube.TabIndex = 7;
            this.picCube.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(878, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(837, 341);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(235, 113);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 610);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picCube);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tZ);
            this.Controls.Add(this.tY);
            this.Controls.Add(this.tX);
            this.Controls.Add(this.btnReset);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCube)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TrackBar tX;
        private System.Windows.Forms.TrackBar tY;
        private System.Windows.Forms.TrackBar tZ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picCube;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

