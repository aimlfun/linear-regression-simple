namespace Points
{
    partial class FormLinearRegression
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBoxCrosses = new System.Windows.Forms.PictureBox();
            this.pictureBoxNeuralNetworkOutput = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timerTrainAndPlot = new System.Windows.Forms.Timer(this.components);
            this.labelEpoch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCrosses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNeuralNetworkOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxCrosses
            // 
            this.pictureBoxCrosses.Location = new System.Drawing.Point(12, 29);
            this.pictureBoxCrosses.Name = "pictureBoxCrosses";
            this.pictureBoxCrosses.Size = new System.Drawing.Size(258, 214);
            this.pictureBoxCrosses.TabIndex = 0;
            this.pictureBoxCrosses.TabStop = false;
            // 
            // pictureBoxNeuralNetworkOutput
            // 
            this.pictureBoxNeuralNetworkOutput.Location = new System.Drawing.Point(282, 29);
            this.pictureBoxNeuralNetworkOutput.Name = "pictureBoxNeuralNetworkOutput";
            this.pictureBoxNeuralNetworkOutput.Size = new System.Drawing.Size(258, 214);
            this.pictureBoxNeuralNetworkOutput.TabIndex = 1;
            this.pictureBoxNeuralNetworkOutput.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Test Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "y=ax+c (TanH curvature)";
            // 
            // timerTrainAndPlot
            // 
            this.timerTrainAndPlot.Enabled = true;
            this.timerTrainAndPlot.Interval = 2;
            // 
            // labelEpoch
            // 
            this.labelEpoch.Location = new System.Drawing.Point(433, 9);
            this.labelEpoch.Name = "labelEpoch";
            this.labelEpoch.Size = new System.Drawing.Size(107, 16);
            this.labelEpoch.TabIndex = 4;
            this.labelEpoch.Text = "Epoch";
            this.labelEpoch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormLinearRegression
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 256);
            this.Controls.Add(this.labelEpoch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxNeuralNetworkOutput);
            this.Controls.Add(this.pictureBoxCrosses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLinearRegression";
            this.Text = "Linear Regression";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormLinearRegression_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCrosses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNeuralNetworkOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBoxCrosses;
        private PictureBox pictureBoxNeuralNetworkOutput;
        private Label label1;
        private Label label2;
        private System.Windows.Forms.Timer timerTrainAndPlot;
        private Label labelEpoch;
    }
}