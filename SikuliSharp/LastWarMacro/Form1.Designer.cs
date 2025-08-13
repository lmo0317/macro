namespace LastWarMacro
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
            GoldZmobieStartButton = new System.Windows.Forms.Button();
            GoldZmobieStopButton = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            MissionStopButton = new System.Windows.Forms.Button();
            MissionStartButton = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            textResult = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // GoldZmobieStartButton
            // 
            GoldZmobieStartButton.Location = new System.Drawing.Point(73, 5);
            GoldZmobieStartButton.Name = "GoldZmobieStartButton";
            GoldZmobieStartButton.Size = new System.Drawing.Size(75, 23);
            GoldZmobieStartButton.TabIndex = 0;
            GoldZmobieStartButton.Text = "시작";
            GoldZmobieStartButton.UseVisualStyleBackColor = true;
            GoldZmobieStartButton.Click += GoldZombieStartButton_Click;
            // 
            // GoldZmobieStopButton
            // 
            GoldZmobieStopButton.Location = new System.Drawing.Point(154, 5);
            GoldZmobieStopButton.Name = "GoldZmobieStopButton";
            GoldZmobieStopButton.Size = new System.Drawing.Size(75, 23);
            GoldZmobieStopButton.TabIndex = 1;
            GoldZmobieStopButton.Text = "종료";
            GoldZmobieStopButton.UseVisualStyleBackColor = true;
            GoldZmobieStopButton.Click += GoldZombieStopButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(55, 15);
            label1.TabIndex = 2;
            label1.Text = "황금좀비";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 54);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(31, 15);
            label2.TabIndex = 3;
            label2.Text = "보물";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(49, 50);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "시작";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(130, 50);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "종료";
            button2.UseVisualStyleBackColor = true;
            // 
            // MissionStopButton
            // 
            MissionStopButton.Location = new System.Drawing.Point(130, 101);
            MissionStopButton.Name = "MissionStopButton";
            MissionStopButton.Size = new System.Drawing.Size(75, 23);
            MissionStopButton.TabIndex = 8;
            MissionStopButton.Text = "종료";
            MissionStopButton.UseVisualStyleBackColor = true;
            MissionStopButton.Click += MissionStopButton_Click;
            // 
            // MissionStartButton
            // 
            MissionStartButton.Location = new System.Drawing.Point(49, 101);
            MissionStartButton.Name = "MissionStartButton";
            MissionStartButton.Size = new System.Drawing.Size(75, 23);
            MissionStartButton.TabIndex = 7;
            MissionStartButton.Text = "시작";
            MissionStartButton.UseVisualStyleBackColor = true;
            MissionStartButton.Click += MissionStartButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 105);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(31, 15);
            label3.TabIndex = 6;
            label3.Text = "은밀";
            // 
            // textResult
            // 
            textResult.Location = new System.Drawing.Point(402, 12);
            textResult.Multiline = true;
            textResult.Name = "textResult";
            textResult.Size = new System.Drawing.Size(386, 426);
            textResult.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(textResult);
            Controls.Add(MissionStopButton);
            Controls.Add(MissionStartButton);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(GoldZmobieStopButton);
            Controls.Add(GoldZmobieStartButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button GoldZmobieStartButton;
        private System.Windows.Forms.Button GoldZmobieStopButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button MissionStopButton;
        private System.Windows.Forms.Button MissionStartButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textResult;
    }
}
