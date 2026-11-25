namespace Minesweeper
{
    partial class FormMenu
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
            label1 = new Label();
            label2 = new Label();
            btnEasy = new Button();
            btnMedium = new Button();
            btnHard = new Button();
            btnExtreme = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(99, 9);
            label1.Name = "label1";
            label1.Size = new Size(205, 25);
            label1.TabIndex = 0;
            label1.Text = "💣 MINESWEEPER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Small", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.Location = new Point(112, 45);
            label2.Name = "label2";
            label2.Size = new Size(191, 28);
            label2.TabIndex = 1;
            label2.Text = "Choose difficulty:";
            // 
            // btnEasy
            // 
            btnEasy.BackColor = Color.ForestGreen;
            btnEasy.FlatStyle = FlatStyle.Flat;
            btnEasy.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnEasy.ForeColor = SystemColors.ButtonHighlight;
            btnEasy.Location = new Point(51, 112);
            btnEasy.Name = "btnEasy";
            btnEasy.Size = new Size(116, 86);
            btnEasy.TabIndex = 2;
            btnEasy.Text = "EASY (9x9 • 10 mines)";
            btnEasy.UseVisualStyleBackColor = false;
            btnEasy.Click += btnEasy_Click;
            // 
            // btnMedium
            // 
            btnMedium.BackColor = Color.Orange;
            btnMedium.FlatStyle = FlatStyle.Flat;
            btnMedium.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnMedium.ForeColor = SystemColors.ButtonHighlight;
            btnMedium.Location = new Point(227, 112);
            btnMedium.Name = "btnMedium";
            btnMedium.Size = new Size(116, 86);
            btnMedium.TabIndex = 3;
            btnMedium.Text = "MEDIUM (12x12 • 25 mines)";
            btnMedium.UseVisualStyleBackColor = false;
            btnMedium.Click += btnMedium_Click;
            // 
            // btnHard
            // 
            btnHard.BackColor = Color.Chocolate;
            btnHard.FlatStyle = FlatStyle.Flat;
            btnHard.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnHard.ForeColor = SystemColors.ButtonHighlight;
            btnHard.Location = new Point(51, 222);
            btnHard.Name = "btnHard";
            btnHard.Size = new Size(116, 86);
            btnHard.TabIndex = 4;
            btnHard.Text = "HARD (16x16 • 40 mines)";
            btnHard.UseVisualStyleBackColor = false;
            btnHard.Click += btnHard_Click;
            // 
            // btnExtreme
            // 
            btnExtreme.BackColor = Color.DarkRed;
            btnExtreme.FlatStyle = FlatStyle.Flat;
            btnExtreme.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnExtreme.ForeColor = SystemColors.ButtonHighlight;
            btnExtreme.Location = new Point(227, 222);
            btnExtreme.Name = "btnExtreme";
            btnExtreme.Size = new Size(116, 86);
            btnExtreme.TabIndex = 5;
            btnExtreme.Text = "EXTREME (20x20 • 80 mines)";
            btnExtreme.UseVisualStyleBackColor = false;
            btnExtreme.Click += btnExtreme_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(406, 381);
            Controls.Add(btnExtreme);
            Controls.Add(btnHard);
            Controls.Add(btnMedium);
            Controls.Add(btnEasy);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Minesweeper - Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnEasy;
        private Button btnMedium;
        private Button btnHard;
        private Button btnExtreme;
    }
}