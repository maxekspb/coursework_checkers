namespace checkers
{
    partial class CheckersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckersForm));
            mainBoard = new PictureBox();
            PlayerWhiteScoreLabel = new Label();
            PlayerBlackScoreLabel = new Label();
            PlayerWhiteNameLabel = new Label();
            PlayerBlackNameLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            Player2Turn = new Label();
            PlayerWhiteTurn = new Label();
            panel1 = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            panel2 = new Panel();
            tableLayoutPanel5 = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            save_button = new Button();
            saving = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)mainBoard).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // mainBoard
            // 
            mainBoard.BackColor = SystemColors.ActiveBorder;
            mainBoard.Location = new Point(38, 51);
            mainBoard.Margin = new Padding(0);
            mainBoard.Name = "mainBoard";
            mainBoard.Size = new Size(1029, 1148);
            mainBoard.TabIndex = 0;
            mainBoard.TabStop = false;
            // 
            // PlayerWhiteScoreLabel
            // 
            PlayerWhiteScoreLabel.AutoSize = true;
            PlayerWhiteScoreLabel.Dock = DockStyle.Fill;
            PlayerWhiteScoreLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            PlayerWhiteScoreLabel.Location = new Point(126, 75);
            PlayerWhiteScoreLabel.Margin = new Padding(5, 0, 5, 0);
            PlayerWhiteScoreLabel.Name = "PlayerWhiteScoreLabel";
            PlayerWhiteScoreLabel.Size = new Size(112, 76);
            PlayerWhiteScoreLabel.TabIndex = 1;
            PlayerWhiteScoreLabel.Text = "0";
            PlayerWhiteScoreLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PlayerBlackScoreLabel
            // 
            PlayerBlackScoreLabel.AutoSize = true;
            PlayerBlackScoreLabel.Dock = DockStyle.Fill;
            PlayerBlackScoreLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            PlayerBlackScoreLabel.Location = new Point(126, 75);
            PlayerBlackScoreLabel.Margin = new Padding(5, 0, 5, 0);
            PlayerBlackScoreLabel.Name = "PlayerBlackScoreLabel";
            PlayerBlackScoreLabel.Size = new Size(112, 75);
            PlayerBlackScoreLabel.TabIndex = 2;
            PlayerBlackScoreLabel.Text = "0";
            PlayerBlackScoreLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PlayerWhiteNameLabel
            // 
            tableLayoutPanel5.SetColumnSpan(PlayerWhiteNameLabel, 2);
            PlayerWhiteNameLabel.Dock = DockStyle.Fill;
            PlayerWhiteNameLabel.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            PlayerWhiteNameLabel.Location = new Point(5, 0);
            PlayerWhiteNameLabel.Margin = new Padding(5, 0, 5, 0);
            PlayerWhiteNameLabel.Name = "PlayerWhiteNameLabel";
            PlayerWhiteNameLabel.Size = new Size(233, 75);
            PlayerWhiteNameLabel.TabIndex = 3;
            PlayerWhiteNameLabel.Text = "Игрок 1";
            PlayerWhiteNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PlayerBlackNameLabel
            // 
            PlayerBlackNameLabel.CausesValidation = false;
            tableLayoutPanel4.SetColumnSpan(PlayerBlackNameLabel, 2);
            PlayerBlackNameLabel.Dock = DockStyle.Fill;
            PlayerBlackNameLabel.FlatStyle = FlatStyle.Flat;
            PlayerBlackNameLabel.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            PlayerBlackNameLabel.Location = new Point(5, 0);
            PlayerBlackNameLabel.Margin = new Padding(5, 0, 5, 0);
            PlayerBlackNameLabel.Name = "PlayerBlackNameLabel";
            PlayerBlackNameLabel.Size = new Size(233, 75);
            PlayerBlackNameLabel.TabIndex = 4;
            PlayerBlackNameLabel.Text = "Игрок 2";
            PlayerBlackNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(5, 75);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(111, 76);
            label1.TabIndex = 5;
            label1.Text = "Счёт:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(5, 75);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(111, 75);
            label2.TabIndex = 6;
            label2.Text = "Счёт:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Player2Turn
            // 
            Player2Turn.AutoSize = true;
            tableLayoutPanel4.SetColumnSpan(Player2Turn, 2);
            Player2Turn.Dock = DockStyle.Fill;
            Player2Turn.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            Player2Turn.ForeColor = Color.Red;
            Player2Turn.Location = new Point(5, 150);
            Player2Turn.Margin = new Padding(5, 0, 5, 0);
            Player2Turn.Name = "Player2Turn";
            Player2Turn.Size = new Size(233, 78);
            Player2Turn.TabIndex = 7;
            Player2Turn.Text = "ВАШ ХОД!";
            Player2Turn.TextAlign = ContentAlignment.MiddleCenter;
            Player2Turn.Visible = false;
            // 
            // PlayerWhiteTurn
            // 
            PlayerWhiteTurn.AutoSize = true;
            tableLayoutPanel5.SetColumnSpan(PlayerWhiteTurn, 2);
            PlayerWhiteTurn.Dock = DockStyle.Fill;
            PlayerWhiteTurn.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            PlayerWhiteTurn.ForeColor = Color.Red;
            PlayerWhiteTurn.Location = new Point(5, 151);
            PlayerWhiteTurn.Margin = new Padding(5, 0, 5, 0);
            PlayerWhiteTurn.Name = "PlayerWhiteTurn";
            PlayerWhiteTurn.Size = new Size(233, 77);
            PlayerWhiteTurn.TabIndex = 10;
            PlayerWhiteTurn.Text = "ВАШ ХОД!";
            PlayerWhiteTurn.TextAlign = ContentAlignment.MiddleCenter;
            PlayerWhiteTurn.Visible = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(tableLayoutPanel4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(5, 18);
            panel1.Margin = new Padding(5, 18, 15, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(247, 232);
            panel1.TabIndex = 12;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(PlayerBlackScoreLabel, 1, 1);
            tableLayoutPanel4.Controls.Add(PlayerBlackNameLabel, 0, 0);
            tableLayoutPanel4.Controls.Add(label2, 0, 1);
            tableLayoutPanel4.Controls.Add(Player2Turn, 0, 2);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Margin = new Padding(5, 6, 5, 6);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.Size = new Size(243, 228);
            tableLayoutPanel4.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(tableLayoutPanel5);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(5, 625);
            panel2.Margin = new Padding(5, 6, 15, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(247, 232);
            panel2.TabIndex = 13;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(PlayerWhiteScoreLabel, 1, 1);
            tableLayoutPanel5.Controls.Add(label1, 0, 1);
            tableLayoutPanel5.Controls.Add(PlayerWhiteNameLabel, 0, 0);
            tableLayoutPanel5.Controls.Add(PlayerWhiteTurn, 0, 2);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Margin = new Padding(5, 6, 5, 6);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 3;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel5.Size = new Size(243, 228);
            tableLayoutPanel5.TabIndex = 11;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(5, 6, 5, 6);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1382, 1250);
            tableLayoutPanel1.TabIndex = 14;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 1029F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(mainBoard, 1, 1);
            tableLayoutPanel3.Controls.Add(save_button, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 1148F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(1105, 1250);
            tableLayoutPanel3.TabIndex = 8;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(panel1, 0, 0);
            tableLayoutPanel2.Controls.Add(panel2, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(1110, 6);
            tableLayoutPanel2.Margin = new Padding(5, 6, 5, 6);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(267, 1238);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // save_button
            // 
            save_button.Location = new Point(41, 3);
            save_button.Name = "save_button";
            save_button.Size = new Size(346, 45);
            save_button.TabIndex = 15;
            save_button.Text = "Сохранить";
            save_button.UseVisualStyleBackColor = true;
            save_button.Click += button1_Click;
            // 
            // CheckersForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1382, 1250);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            Name = "CheckersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Checkers";
            Load += UpdateGameBoard;
            ((System.ComponentModel.ISupportInitialize)mainBoard).EndInit();
            panel1.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            panel2.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox mainBoard;
        private Label PlayerWhiteScoreLabel;
        private Label PlayerBlackScoreLabel;
        private Label PlayerWhiteNameLabel;
        private Label PlayerBlackNameLabel;
        private Label label1;
        private Label label2;
        private Label Player2Turn;
        private Label PlayerWhiteTurn;
        private Panel panel1;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private Button save_button;
        private OpenFileDialog saving;
    }
}