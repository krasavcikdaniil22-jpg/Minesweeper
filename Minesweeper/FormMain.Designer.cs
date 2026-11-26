namespace Minesweeper
{
    partial class FormMain
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
            components = new System.ComponentModel.Container();
            lblMinesLeft = new Label();
            btnReset = new Button();
            btnBackMenu = new Button();
            lblTimer = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblMinesLeft
            // 
            lblMinesLeft.AutoSize = true;
            lblMinesLeft.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblMinesLeft.Location = new Point(12, 593);
            lblMinesLeft.Name = "lblMinesLeft";
            lblMinesLeft.Size = new Size(183, 30);
            lblMinesLeft.TabIndex = 0;
            lblMinesLeft.Text = "Мин осталось: 10";
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnReset.Location = new Point(12, 526);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(100, 35);
            btnReset.TabIndex = 1;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnBackMenu
            // 
            btnBackMenu.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnBackMenu.Location = new Point(12, 448);
            btnBackMenu.Name = "btnBackMenu";
            btnBackMenu.Size = new Size(152, 41);
            btnBackMenu.TabIndex = 2;
            btnBackMenu.Text = "Return to the menu";
            btnBackMenu.UseVisualStyleBackColor = true;
            btnBackMenu.Click += btnBackMenu_Click;
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblTimer.Location = new Point(12, 388);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(96, 36);
            lblTimer.TabIndex = 3;
            lblTimer.Text = "00:00";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 644);
            Controls.Add(lblTimer);
            Controls.Add(btnBackMenu);
            Controls.Add(btnReset);
            Controls.Add(lblMinesLeft);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Сапёр";
            Load += FormMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMinesLeft;
        private Button btnReset;
        private Button btnBackMenu;
        private Label lblTimer;
        private System.Windows.Forms.Timer timer1;
    }
}
