namespace PCTemperatureAlert
{
    partial class Form1
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
            Button btnGetTemp;
            lblThreshold = new Label();
            txtThreshold = new TextBox();
            lblWarning = new Label();
            btnGetTemp = new Button();
            SuspendLayout();
            // 
            // btnGetTemp
            // 
            btnGetTemp.Location = new Point(57, 73);
            btnGetTemp.Name = "btnGetTemp";
            btnGetTemp.Size = new Size(115, 23);
            btnGetTemp.TabIndex = 0;
            btnGetTemp.Text = "Start";
            btnGetTemp.UseVisualStyleBackColor = true;
            btnGetTemp.Click += btnGetTemp_Click;
            // 
            // lblThreshold
            // 
            lblThreshold.AutoSize = true;
            lblThreshold.Location = new Point(12, 18);
            lblThreshold.Name = "lblThreshold";
            lblThreshold.Size = new Size(94, 15);
            lblThreshold.TabIndex = 1;
            lblThreshold.Text = "Threshold (in C):";
            // 
            // txtThreshold
            // 
            txtThreshold.Location = new Point(112, 15);
            txtThreshold.Name = "txtThreshold";
            txtThreshold.PlaceholderText = "Enter here";
            txtThreshold.Size = new Size(109, 23);
            txtThreshold.TabIndex = 2;
            txtThreshold.KeyPress += txtThreshold_KeyPress;
            // 
            // lblWarning
            // 
            lblWarning.AutoSize = true;
            lblWarning.ForeColor = Color.Red;
            lblWarning.Location = new Point(12, 45);
            lblWarning.Name = "lblWarning";
            lblWarning.Size = new Size(10, 15);
            lblWarning.TabIndex = 3;
            lblWarning.Text = " ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(244, 108);
            Controls.Add(lblWarning);
            Controls.Add(txtThreshold);
            Controls.Add(lblThreshold);
            Controls.Add(btnGetTemp);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblThreshold;
        private TextBox txtThreshold;
        private Label lblWarning;
    }
}