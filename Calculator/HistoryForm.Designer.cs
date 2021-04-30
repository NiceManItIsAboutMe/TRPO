namespace Calculator
{
    partial class HistoryForm
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
            this.numSysTrackBar = new System.Windows.Forms.TrackBar();
            this.numSysLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numSysTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // numSysTrackBar
            // 
            this.numSysTrackBar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.numSysTrackBar.BackColor = System.Drawing.SystemColors.Control;
            this.numSysTrackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numSysTrackBar.Location = new System.Drawing.Point(12, 342);
            this.numSysTrackBar.Maximum = 16;
            this.numSysTrackBar.Minimum = 2;
            this.numSysTrackBar.Name = "numSysTrackBar";
            this.numSysTrackBar.Size = new System.Drawing.Size(458, 45);
            this.numSysTrackBar.TabIndex = 112;
            this.numSysTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.numSysTrackBar.Value = 10;
            this.numSysTrackBar.Scroll += new System.EventHandler(this.numSysTrackBar_Scroll);
            // 
            // numSysLabel
            // 
            this.numSysLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.numSysLabel.AutoSize = true;
            this.numSysLabel.BackColor = System.Drawing.SystemColors.Control;
            this.numSysLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)), true);
            this.numSysLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.numSysLabel.Location = new System.Drawing.Point(12, 316);
            this.numSysLabel.Name = "numSysLabel";
            this.numSysLabel.Size = new System.Drawing.Size(217, 24);
            this.numSysLabel.TabIndex = 111;
            this.numSysLabel.Text = "Система счисления: 10";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(249, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 23);
            this.button1.TabIndex = 113;
            this.button1.Text = "Очистить историю";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Multiline = true;
            this.label2.Name = "label2";
            this.label2.ReadOnly = true;
            this.label2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.label2.Size = new System.Drawing.Size(482, 310);
            this.label2.TabIndex = 114;
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 401);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numSysTrackBar);
            this.Controls.Add(this.numSysLabel);
            this.Name = "HistoryForm";
            this.Text = "HistoryForm";
            ((System.ComponentModel.ISupportInitialize)(this.numSysTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TrackBar numSysTrackBar;
        private System.Windows.Forms.Label numSysLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox label2;
    }
}