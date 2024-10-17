namespace CS311_Project2_JAR
{
    partial class Craps
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
            lblDie1 = new Label();
            lblDie2 = new Label();
            lblBalance = new Label();
            textBoxBet = new TextBox();
            btnRoll = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // lblDie1
            // 
            lblDie1.AutoSize = true;
            lblDie1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDie1.Location = new Point(48, 20);
            lblDie1.Name = "lblDie1";
            lblDie1.Size = new Size(47, 65);
            lblDie1.TabIndex = 0;
            lblDie1.Text = "-";
            // 
            // lblDie2
            // 
            lblDie2.AutoSize = true;
            lblDie2.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDie2.Location = new Point(144, 20);
            lblDie2.Name = "lblDie2";
            lblDie2.Size = new Size(47, 65);
            lblDie2.TabIndex = 1;
            lblDie2.Text = "-";
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBalance.Location = new Point(290, 20);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(151, 25);
            lblBalance.TabIndex = 2;
            lblBalance.Text = "Balance: $100.00";
            // 
            // textBoxBet
            // 
            textBoxBet.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxBet.Location = new Point(290, 52);
            textBoxBet.Name = "textBoxBet";
            textBoxBet.PlaceholderText = "enter your bet";
            textBoxBet.Size = new Size(151, 33);
            textBoxBet.TabIndex = 5;
            // 
            // btnRoll
            // 
            btnRoll.Font = new Font("Segoe UI", 14F);
            btnRoll.Location = new Point(290, 108);
            btnRoll.Name = "btnRoll";
            btnRoll.Size = new Size(151, 36);
            btnRoll.TabIndex = 3;
            btnRoll.Text = "Roll";
            btnRoll.UseVisualStyleBackColor = true;
            btnRoll.Click += btnRoll_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(48, 114);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(71, 25);
            lblResult.TabIndex = 5;
            lblResult.Text = "Result:";
            // 
            // Craps
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 219);
            Controls.Add(lblResult);
            Controls.Add(btnRoll);
            Controls.Add(textBoxBet);
            Controls.Add(lblBalance);
            Controls.Add(lblDie2);
            Controls.Add(lblDie1);
            Name = "Craps";
            Text = "Craps";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDie1;
        private Label lblDie2;
        private Label lblBalance;
        private TextBox textBoxBet;
        private Button btnRoll;
        private Label lblResult;
    }
}
