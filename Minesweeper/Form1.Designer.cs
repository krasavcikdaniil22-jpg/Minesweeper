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
            lblMinesLeft = new Label();
            btnReset = new Button();
            SuspendLayout();
            // 
            // lblMinesLeft
            // 
            lblMinesLeft.AutoSize = true;
            lblMinesLeft.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblMinesLeft.Location = new Point(3, 442);
            lblMinesLeft.Name = "lblMinesLeft";
            lblMinesLeft.Size = new Size(183, 30);
            lblMinesLeft.TabIndex = 0;
            lblMinesLeft.Text = "Мин осталось: 10";
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnReset.Location = new Point(3, 375);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(100, 35);
            btnReset.TabIndex = 1;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 481);
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
    }
}
