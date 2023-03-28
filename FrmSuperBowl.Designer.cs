namespace WFA230328
{
    partial class FrmSuperBowl
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
            label1 = new Label();
            txtRomai = new TextBox();
            cmdAtvalt = new Button();
            label2 = new Label();
            txtArab = new TextBox();
            btnIrany = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(167, 25);
            label1.TabIndex = 0;
            label1.Text = "Római szám [I - X]:";
            // 
            // txtRomai
            // 
            txtRomai.Location = new Point(37, 56);
            txtRomai.Name = "txtRomai";
            txtRomai.Size = new Size(100, 32);
            txtRomai.TabIndex = 1;
            // 
            // cmdAtvalt
            // 
            cmdAtvalt.Location = new Point(249, 92);
            cmdAtvalt.Name = "cmdAtvalt";
            cmdAtvalt.Size = new Size(94, 38);
            cmdAtvalt.TabIndex = 4;
            cmdAtvalt.Text = "Átvált";
            cmdAtvalt.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(398, 28);
            label2.Name = "label2";
            label2.Size = new Size(169, 25);
            label2.TabIndex = 0;
            label2.Text = "Arab szám [1 - 10]:";
            // 
            // txtArab
            // 
            txtArab.Enabled = false;
            txtArab.Location = new Point(430, 56);
            txtArab.Name = "txtArab";
            txtArab.Size = new Size(100, 32);
            txtArab.TabIndex = 3;
            // 
            // btnIrany
            // 
            btnIrany.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnIrany.Location = new Point(249, 21);
            btnIrany.Name = "btnIrany";
            btnIrany.Size = new Size(94, 38);
            btnIrany.TabIndex = 2;
            btnIrany.Text = "--->";
            btnIrany.UseVisualStyleBackColor = true;
            // 
            // FrmSuperBowl
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 142);
            Controls.Add(btnIrany);
            Controls.Add(cmdAtvalt);
            Controls.Add(txtArab);
            Controls.Add(txtRomai);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "FrmSuperBowl";
            Text = "Átváltás";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtRomai;
        private Button cmdAtvalt;
        private Label label2;
        private TextBox txtArab;
        private Button btnIrany;
    }
}