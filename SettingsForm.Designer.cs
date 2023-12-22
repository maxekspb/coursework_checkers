namespace checkers
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            tabPagePvE = new TabPage();
            groupBox3 = new GroupBox();
            checkBoxForceJumpPvE = new CheckBox();
            checkBoxShowMovesPvE = new CheckBox();
            comboBoxFirstMovePvE = new ComboBox();
            label5 = new Label();
            comboBoxBoardSizePvE = new ComboBox();
            label6 = new Label();
            groupBox4 = new GroupBox();
            textBoxPlayer1PvE = new TextBox();
            label8 = new Label();
            buttonStartGamePvE = new Button();
            tabPagePvP = new TabPage();
            groupBox1 = new GroupBox();
            checkBoxForceJumpPvP = new CheckBox();
            checkBoxShowMovesPvP = new CheckBox();
            comboBoxFirstMovePvP = new ComboBox();
            label4 = new Label();
            comboBoxBoardSizePvP = new ComboBox();
            label3 = new Label();
            groupBox2 = new GroupBox();
            textBoxPlayer2PvP = new TextBox();
            textBoxPlayer1PvP = new TextBox();
            label2 = new Label();
            label1 = new Label();
            buttonStartGamePvP = new Button();
            tabControlSetting = new TabControl();
            tabPagePvE.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            tabPagePvP.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            tabControlSetting.SuspendLayout();
            SuspendLayout();
            // 
            // tabPagePvE
            // 
            tabPagePvE.Controls.Add(groupBox3);
            tabPagePvE.Controls.Add(groupBox4);
            tabPagePvE.Controls.Add(buttonStartGamePvE);
            tabPagePvE.Location = new Point(4, 39);
            tabPagePvE.Margin = new Padding(5, 6, 5, 6);
            tabPagePvE.Name = "tabPagePvE";
            tabPagePvE.Size = new Size(755, 573);
            tabPagePvE.TabIndex = 2;
            tabPagePvE.Text = "Игрок против компьютера";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(checkBoxForceJumpPvE);
            groupBox3.Controls.Add(checkBoxShowMovesPvE);
            groupBox3.Controls.Add(comboBoxFirstMovePvE);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(comboBoxBoardSizePvE);
            groupBox3.Controls.Add(label6);
            groupBox3.Location = new Point(12, 12);
            groupBox3.Margin = new Padding(5, 6, 5, 6);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(5, 6, 5, 6);
            groupBox3.Size = new Size(357, 374);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Настройки игры";
            // 
            // checkBoxForceJumpPvE
            // 
            checkBoxForceJumpPvE.AutoSize = true;
            checkBoxForceJumpPvE.Checked = true;
            checkBoxForceJumpPvE.CheckState = CheckState.Checked;
            checkBoxForceJumpPvE.Location = new Point(12, 288);
            checkBoxForceJumpPvE.Margin = new Padding(5, 6, 5, 6);
            checkBoxForceJumpPvE.Name = "checkBoxForceJumpPvE";
            checkBoxForceJumpPvE.Size = new Size(157, 34);
            checkBoxForceJumpPvE.TabIndex = 6;
            checkBoxForceJumpPvE.Text = "Обязан есть";
            checkBoxForceJumpPvE.UseVisualStyleBackColor = true;
            // 
            // checkBoxShowMovesPvE
            // 
            checkBoxShowMovesPvE.AutoSize = true;
            checkBoxShowMovesPvE.Checked = true;
            checkBoxShowMovesPvE.CheckState = CheckState.Checked;
            checkBoxShowMovesPvE.Location = new Point(12, 238);
            checkBoxShowMovesPvE.Margin = new Padding(5, 6, 5, 6);
            checkBoxShowMovesPvE.Name = "checkBoxShowMovesPvE";
            checkBoxShowMovesPvE.Size = new Size(207, 34);
            checkBoxShowMovesPvE.TabIndex = 4;
            checkBoxShowMovesPvE.Text = "Показывать ходы";
            checkBoxShowMovesPvE.UseVisualStyleBackColor = true;
            // 
            // comboBoxFirstMovePvE
            // 
            comboBoxFirstMovePvE.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFirstMovePvE.FormattingEnabled = true;
            comboBoxFirstMovePvE.Items.AddRange(new object[] { "Компьютер", "Игрок" });
            comboBoxFirstMovePvE.Location = new Point(12, 180);
            comboBoxFirstMovePvE.Margin = new Padding(5, 6, 5, 6);
            comboBoxFirstMovePvE.Name = "comboBoxFirstMovePvE";
            comboBoxFirstMovePvE.Size = new Size(205, 38);
            comboBoxFirstMovePvE.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 144);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(190, 30);
            label5.TabIndex = 2;
            label5.Text = "Кто ходит первый:";
            // 
            // comboBoxBoardSizePvE
            // 
            comboBoxBoardSizePvE.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxBoardSizePvE.FormattingEnabled = true;
            comboBoxBoardSizePvE.Items.AddRange(new object[] { "8x8" });
            comboBoxBoardSizePvE.Location = new Point(12, 74);
            comboBoxBoardSizePvE.Margin = new Padding(5, 6, 5, 6);
            comboBoxBoardSizePvE.MaxDropDownItems = 3;
            comboBoxBoardSizePvE.Name = "comboBoxBoardSizePvE";
            comboBoxBoardSizePvE.Size = new Size(205, 38);
            comboBoxBoardSizePvE.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 38);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(149, 30);
            label6.TabIndex = 0;
            label6.Text = "Размер доски:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(textBoxPlayer1PvE);
            groupBox4.Controls.Add(label8);
            groupBox4.Location = new Point(379, 12);
            groupBox4.Margin = new Padding(5, 6, 5, 6);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(5, 6, 5, 6);
            groupBox4.Size = new Size(357, 374);
            groupBox4.TabIndex = 7;
            groupBox4.TabStop = false;
            groupBox4.Text = "Настройки игрока";
            // 
            // textBoxPlayer1PvE
            // 
            textBoxPlayer1PvE.ForeColor = SystemColors.MenuText;
            textBoxPlayer1PvE.Location = new Point(10, 98);
            textBoxPlayer1PvE.Margin = new Padding(5, 6, 5, 6);
            textBoxPlayer1PvE.Name = "textBoxPlayer1PvE";
            textBoxPlayer1PvE.Size = new Size(225, 35);
            textBoxPlayer1PvE.TabIndex = 3;
            textBoxPlayer1PvE.Text = "Игрок";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(10, 62);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(131, 30);
            label8.TabIndex = 1;
            label8.Text = "Имя игрока:";
            // 
            // buttonStartGamePvE
            // 
            buttonStartGamePvE.Location = new Point(310, 470);
            buttonStartGamePvE.Margin = new Padding(5, 6, 5, 6);
            buttonStartGamePvE.Name = "buttonStartGamePvE";
            buttonStartGamePvE.Size = new Size(127, 62);
            buttonStartGamePvE.TabIndex = 8;
            buttonStartGamePvE.Text = "Начать";
            buttonStartGamePvE.UseVisualStyleBackColor = true;
            buttonStartGamePvE.Click += ButtonStartPvE;
            // 
            // tabPagePvP
            // 
            tabPagePvP.Controls.Add(groupBox1);
            tabPagePvP.Controls.Add(groupBox2);
            tabPagePvP.Controls.Add(buttonStartGamePvP);
            tabPagePvP.Location = new Point(4, 39);
            tabPagePvP.Margin = new Padding(5, 6, 5, 6);
            tabPagePvP.Name = "tabPagePvP";
            tabPagePvP.Padding = new Padding(5, 6, 5, 6);
            tabPagePvP.Size = new Size(755, 573);
            tabPagePvP.TabIndex = 1;
            tabPagePvP.Text = "Игрок против игрока";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBoxForceJumpPvP);
            groupBox1.Controls.Add(checkBoxShowMovesPvP);
            groupBox1.Controls.Add(comboBoxFirstMovePvP);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(comboBoxBoardSizePvP);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Margin = new Padding(5, 6, 5, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5, 6, 5, 6);
            groupBox1.Size = new Size(357, 374);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Настройки игры";
            // 
            // checkBoxForceJumpPvP
            // 
            checkBoxForceJumpPvP.AutoSize = true;
            checkBoxForceJumpPvP.Checked = true;
            checkBoxForceJumpPvP.CheckState = CheckState.Checked;
            checkBoxForceJumpPvP.Location = new Point(12, 288);
            checkBoxForceJumpPvP.Margin = new Padding(5, 6, 5, 6);
            checkBoxForceJumpPvP.Name = "checkBoxForceJumpPvP";
            checkBoxForceJumpPvP.Size = new Size(157, 34);
            checkBoxForceJumpPvP.TabIndex = 5;
            checkBoxForceJumpPvP.Text = "Обязан есть";
            checkBoxForceJumpPvP.UseVisualStyleBackColor = true;
            // 
            // checkBoxShowMovesPvP
            // 
            checkBoxShowMovesPvP.AutoSize = true;
            checkBoxShowMovesPvP.Checked = true;
            checkBoxShowMovesPvP.CheckState = CheckState.Checked;
            checkBoxShowMovesPvP.Location = new Point(12, 238);
            checkBoxShowMovesPvP.Margin = new Padding(5, 6, 5, 6);
            checkBoxShowMovesPvP.Name = "checkBoxShowMovesPvP";
            checkBoxShowMovesPvP.Size = new Size(207, 34);
            checkBoxShowMovesPvP.TabIndex = 4;
            checkBoxShowMovesPvP.Text = "Показывать ходы";
            checkBoxShowMovesPvP.UseVisualStyleBackColor = true;
            // 
            // comboBoxFirstMovePvP
            // 
            comboBoxFirstMovePvP.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFirstMovePvP.FormattingEnabled = true;
            comboBoxFirstMovePvP.Items.AddRange(new object[] { "Игрок 2", "Игрок 1" });
            comboBoxFirstMovePvP.Location = new Point(12, 180);
            comboBoxFirstMovePvP.Margin = new Padding(5, 6, 5, 6);
            comboBoxFirstMovePvP.Name = "comboBoxFirstMovePvP";
            comboBoxFirstMovePvP.Size = new Size(205, 38);
            comboBoxFirstMovePvP.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 144);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(190, 30);
            label4.TabIndex = 2;
            label4.Text = "Кто ходит первый:";
            // 
            // comboBoxBoardSizePvP
            // 
            comboBoxBoardSizePvP.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxBoardSizePvP.FormattingEnabled = true;
            comboBoxBoardSizePvP.Items.AddRange(new object[] { "8x8" });
            comboBoxBoardSizePvP.Location = new Point(12, 74);
            comboBoxBoardSizePvP.Margin = new Padding(5, 6, 5, 6);
            comboBoxBoardSizePvP.MaxDropDownItems = 3;
            comboBoxBoardSizePvP.Name = "comboBoxBoardSizePvP";
            comboBoxBoardSizePvP.Size = new Size(205, 38);
            comboBoxBoardSizePvP.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 38);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(149, 30);
            label3.TabIndex = 0;
            label3.Text = "Размер доски:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxPlayer2PvP);
            groupBox2.Controls.Add(textBoxPlayer1PvP);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(379, 12);
            groupBox2.Margin = new Padding(5, 6, 5, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(5, 6, 5, 6);
            groupBox2.Size = new Size(357, 374);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Настройки игрока";
            // 
            // textBoxPlayer2PvP
            // 
            textBoxPlayer2PvP.Location = new Point(10, 214);
            textBoxPlayer2PvP.Margin = new Padding(5, 6, 5, 6);
            textBoxPlayer2PvP.Name = "textBoxPlayer2PvP";
            textBoxPlayer2PvP.Size = new Size(225, 35);
            textBoxPlayer2PvP.TabIndex = 4;
            textBoxPlayer2PvP.Text = "Игрок 2";
            // 
            // textBoxPlayer1PvP
            // 
            textBoxPlayer1PvP.ForeColor = SystemColors.MenuText;
            textBoxPlayer1PvP.Location = new Point(10, 98);
            textBoxPlayer1PvP.Margin = new Padding(5, 6, 5, 6);
            textBoxPlayer1PvP.Name = "textBoxPlayer1PvP";
            textBoxPlayer1PvP.Size = new Size(225, 35);
            textBoxPlayer1PvP.TabIndex = 3;
            textBoxPlayer1PvP.Text = "Игрок 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 178);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(148, 30);
            label2.TabIndex = 2;
            label2.Text = "Имя игрока 2:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 62);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(148, 30);
            label1.TabIndex = 1;
            label1.Text = "Имя игрока 1:";
            // 
            // buttonStartGamePvP
            // 
            buttonStartGamePvP.Location = new Point(310, 470);
            buttonStartGamePvP.Margin = new Padding(5, 6, 5, 6);
            buttonStartGamePvP.Name = "buttonStartGamePvP";
            buttonStartGamePvP.Size = new Size(127, 62);
            buttonStartGamePvP.TabIndex = 4;
            buttonStartGamePvP.Text = "Начать";
            buttonStartGamePvP.UseVisualStyleBackColor = true;
            buttonStartGamePvP.Click += ButtonStartPvP;
            // 
            // tabControlSetting
            // 
            tabControlSetting.Controls.Add(tabPagePvP);
            tabControlSetting.Controls.Add(tabPagePvE);
            tabControlSetting.Location = new Point(2, 2);
            tabControlSetting.Margin = new Padding(5, 6, 5, 6);
            tabControlSetting.Name = "tabControlSetting";
            tabControlSetting.SelectedIndex = 0;
            tabControlSetting.Size = new Size(763, 616);
            tabControlSetting.TabIndex = 6;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(765, 620);
            Controls.Add(tabControlSetting);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            Name = "SettingsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Настройки";
            tabPagePvE.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            tabPagePvP.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tabControlSetting.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPagePvE;
        private GroupBox groupBox3;
        private CheckBox checkBoxForceJumpPvE;
        private CheckBox checkBoxShowMovesPvE;
        private ComboBox comboBoxFirstMovePvE;
        private Label label5;
        private ComboBox comboBoxBoardSizePvE;
        private Label label6;
        private GroupBox groupBox4;
        private TextBox textBoxPlayer1PvE;
        private Label label8;
        private Button buttonStartGamePvE;
        private TabPage tabPagePvP;
        private GroupBox groupBox1;
        private CheckBox checkBoxForceJumpPvP;
        private CheckBox checkBoxShowMovesPvP;
        private ComboBox comboBoxFirstMovePvP;
        private Label label4;
        private ComboBox comboBoxBoardSizePvP;
        private Label label3;
        private GroupBox groupBox2;
        private TextBox textBoxPlayer2PvP;
        private TextBox textBoxPlayer1PvP;
        private Label label2;
        private Label label1;
        private Button buttonStartGamePvP;
        private TabControl tabControlSetting;
    }
}