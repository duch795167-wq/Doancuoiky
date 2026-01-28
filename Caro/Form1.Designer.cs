namespace Caro
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pnl_chessBoard = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            label3 = new Label();
            label2 = new Label();
            img_Player = new PictureBox();
            prcb_CoolDown = new ProgressBar();
            txt_PlayerName = new TextBox();
            tm_CountDown = new System.Windows.Forms.Timer(components);
            label4 = new Label();
            lblRoomName = new Label();
            btnLAN = new Guna.UI2.WinForms.Guna2Button();
            txtRoomName = new Guna.UI2.WinForms.Guna2TextBox();
            menuStrip1 = new MenuStrip();
            mnMenu = new ToolStripMenuItem();
            mnNewGame = new ToolStripMenuItem();
            mnQuit = new ToolStripMenuItem();
            txtChatInput = new TextBox();
            btnSendChat = new Guna.UI2.WinForms.Guna2Button();
            txtChat = new Guna.UI2.WinForms.Guna2TextBox();
            txtStatus = new Guna.UI2.WinForms.Guna2TextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)img_Player).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_chessBoard
            // 
            pnl_chessBoard.BackColor = Color.Transparent;
            pnl_chessBoard.Location = new Point(13, 107);
            pnl_chessBoard.Margin = new Padding(2);
            pnl_chessBoard.Name = "pnl_chessBoard";
            pnl_chessBoard.Size = new Size(560, 588);
            pnl_chessBoard.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(906, 69);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(236, 253);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BackColor = SystemColors.AppWorkspace;
            pictureBox1.BackgroundImage = Properties.Resources.back_caro;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(2, 2);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(227, 246);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(img_Player);
            panel3.Controls.Add(prcb_CoolDown);
            panel3.Controls.Add(txt_PlayerName);
            panel3.Location = new Point(906, 344);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(236, 301);
            panel3.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F);
            label3.Location = new Point(92, 129);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 7;
            label3.Text = "Kí hiệu ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F);
            label2.Location = new Point(49, 9);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(121, 20);
            label2.TabIndex = 6;
            label2.Text = "Lượt đang đánh";
            // 
            // img_Player
            // 
            img_Player.BackColor = SystemColors.ButtonHighlight;
            img_Player.Location = new Point(64, 155);
            img_Player.Margin = new Padding(2);
            img_Player.Name = "img_Player";
            img_Player.Size = new Size(117, 115);
            img_Player.SizeMode = PictureBoxSizeMode.StretchImage;
            img_Player.TabIndex = 2;
            img_Player.TabStop = false;
            // 
            // prcb_CoolDown
            // 
            prcb_CoolDown.Location = new Point(2, 85);
            prcb_CoolDown.Margin = new Padding(2);
            prcb_CoolDown.Name = "prcb_CoolDown";
            prcb_CoolDown.Size = new Size(227, 42);
            prcb_CoolDown.TabIndex = 1;
            // 
            // txt_PlayerName
            // 
            txt_PlayerName.Font = new Font("Microsoft Sans Serif", 14F);
            txt_PlayerName.Location = new Point(72, 35);
            txt_PlayerName.Margin = new Padding(2);
            txt_PlayerName.Name = "txt_PlayerName";
            txt_PlayerName.ReadOnly = true;
            txt_PlayerName.Size = new Size(93, 29);
            txt_PlayerName.TabIndex = 0;
            txt_PlayerName.Text = "Player";
            txt_PlayerName.TextAlign = HorizontalAlignment.Center;
            // 
            // tm_CountDown
            // 
            tm_CountDown.Tick += tm_CountDown_Tick;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 15F);
            label4.Location = new Point(692, 46);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(107, 25);
            label4.TabIndex = 5;
            label4.Text = "Thông báo";
            // 
            // lblRoomName
            // 
            lblRoomName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblRoomName.AutoSize = true;
            lblRoomName.Font = new Font("Microsoft Sans Serif", 15F);
            lblRoomName.Location = new Point(238, 28);
            lblRoomName.Margin = new Padding(4, 0, 4, 0);
            lblRoomName.Name = "lblRoomName";
            lblRoomName.Size = new Size(107, 25);
            lblRoomName.TabIndex = 6;
            lblRoomName.Text = "Tên phòng";
            lblRoomName.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnLAN
            // 
            btnLAN.BackColor = Color.FromArgb(255, 224, 192);
            btnLAN.BorderRadius = 10;
            btnLAN.BorderThickness = 1;
            btnLAN.CustomizableEdges = customizableEdges1;
            btnLAN.DisabledState.BorderColor = Color.DarkGray;
            btnLAN.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLAN.DisabledState.FillColor = Color.DarkGray;
            btnLAN.DisabledState.ForeColor = Color.Black;
            btnLAN.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLAN.ForeColor = SystemColors.Window;
            btnLAN.Location = new Point(664, 328);
            btnLAN.Margin = new Padding(4, 3, 4, 3);
            btnLAN.Name = "btnLAN";
            btnLAN.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnLAN.Size = new Size(167, 51);
            btnLAN.TabIndex = 9;
            btnLAN.Text = "Tạo phòng";
            btnLAN.Click += btnLAN_Click;
            // 
            // txtRoomName
            // 
            txtRoomName.BorderRadius = 10;
            txtRoomName.Cursor = Cursors.IBeam;
            txtRoomName.CustomizableEdges = customizableEdges3;
            txtRoomName.DefaultText = "";
            txtRoomName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtRoomName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtRoomName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtRoomName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtRoomName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtRoomName.Font = new Font("Segoe UI", 9F);
            txtRoomName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtRoomName.Location = new Point(180, 60);
            txtRoomName.Margin = new Padding(4, 3, 4, 3);
            txtRoomName.Name = "txtRoomName";
            txtRoomName.PlaceholderText = "";
            txtRoomName.ReadOnly = true;
            txtRoomName.SelectedText = "";
            txtRoomName.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtRoomName.Size = new Size(233, 42);
            txtRoomName.TabIndex = 10;
            // 
            // menuStrip1
            // 
            menuStrip1.AllowMerge = false;
            menuStrip1.BackColor = Color.Silver;
            menuStrip1.BackgroundImage = Properties.Resources.background_san_go11;
            menuStrip1.BackgroundImageLayout = ImageLayout.Stretch;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnMenu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(1142, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnMenu
            // 
            mnMenu.DropDownItems.AddRange(new ToolStripItem[] { mnNewGame, mnQuit });
            mnMenu.Name = "mnMenu";
            mnMenu.Size = new Size(50, 20);
            mnMenu.Text = "Menu";
            // 
            // mnNewGame
            // 
            mnNewGame.Name = "mnNewGame";
            mnNewGame.Size = new Size(132, 22);
            mnNewGame.Text = "New Game";
            mnNewGame.Click += newGameToolStripMenuItem_Click;
            // 
            // mnQuit
            // 
            mnQuit.Name = "mnQuit";
            mnQuit.Size = new Size(132, 22);
            mnQuit.Text = "Quit";
            mnQuit.Click += quitToolStripMenuItem_Click;
            // 
            // txtChatInput
            // 
            txtChatInput.Font = new Font("Microsoft Sans Serif", 15F);
            txtChatInput.Location = new Point(632, 658);
            txtChatInput.Margin = new Padding(4, 3, 4, 3);
            txtChatInput.Name = "txtChatInput";
            txtChatInput.Size = new Size(167, 30);
            txtChatInput.TabIndex = 12;
            // 
            // btnSendChat
            // 
            btnSendChat.BorderColor = Color.DarkBlue;
            btnSendChat.BorderRadius = 10;
            btnSendChat.BorderThickness = 1;
            btnSendChat.CustomizableEdges = customizableEdges5;
            btnSendChat.DisabledState.BorderColor = Color.DarkGray;
            btnSendChat.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSendChat.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSendChat.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSendChat.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSendChat.ForeColor = Color.White;
            btnSendChat.Location = new Point(807, 653);
            btnSendChat.Margin = new Padding(4, 3, 4, 3);
            btnSendChat.Name = "btnSendChat";
            btnSendChat.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnSendChat.Size = new Size(80, 35);
            btnSendChat.TabIndex = 13;
            btnSendChat.Text = "Gửi";
            btnSendChat.Click += btnSendChat_Click;
            // 
            // txtChat
            // 
            txtChat.BorderColor = Color.FromArgb(128, 128, 255);
            txtChat.BorderRadius = 14;
            txtChat.BorderThickness = 2;
            txtChat.CustomizableEdges = customizableEdges7;
            txtChat.DefaultText = "";
            txtChat.DisabledState.BorderColor = Color.White;
            txtChat.DisabledState.FillColor = Color.White;
            txtChat.DisabledState.ForeColor = Color.DarkGray;
            txtChat.DisabledState.PlaceholderForeColor = Color.DarkGray;
            txtChat.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtChat.Font = new Font("Segoe UI", 9F);
            txtChat.ForeColor = Color.Black;
            txtChat.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtChat.Location = new Point(632, 385);
            txtChat.Multiline = true;
            txtChat.Name = "txtChat";
            txtChat.PlaceholderText = "";
            txtChat.ReadOnly = true;
            txtChat.ScrollBars = ScrollBars.Both;
            txtChat.SelectedText = "";
            txtChat.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtChat.Size = new Size(226, 243);
            txtChat.TabIndex = 14;
            // 
            // txtStatus
            // 
            txtStatus.BackColor = Color.FromArgb(243, 230, 216);
            txtStatus.BorderColor = Color.Lime;
            txtStatus.BorderRadius = 14;
            txtStatus.BorderThickness = 2;
            txtStatus.CustomizableEdges = customizableEdges9;
            txtStatus.DefaultText = "";
            txtStatus.DisabledState.BorderColor = Color.DarkGray;
            txtStatus.DisabledState.FillColor = Color.DarkGray;
            txtStatus.DisabledState.ForeColor = Color.DarkGray;
            txtStatus.DisabledState.PlaceholderForeColor = Color.DarkGray;
            txtStatus.FillColor = Color.WhiteSmoke;
            txtStatus.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtStatus.Font = new Font("Segoe UI", 9F);
            txtStatus.ForeColor = Color.Black;
            txtStatus.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtStatus.Location = new Point(632, 74);
            txtStatus.Multiline = true;
            txtStatus.Name = "txtStatus";
            txtStatus.PlaceholderForeColor = Color.PeachPuff;
            txtStatus.PlaceholderText = "";
            txtStatus.ReadOnly = true;
            txtStatus.SelectedText = "";
            txtStatus.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtStatus.Size = new Size(226, 243);
            txtStatus.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 230, 216);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1142, 773);
            Controls.Add(txtStatus);
            Controls.Add(txtChat);
            Controls.Add(btnSendChat);
            Controls.Add(txtChatInput);
            Controls.Add(txtRoomName);
            Controls.Add(btnLAN);
            Controls.Add(lblRoomName);
            Controls.Add(label4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(pnl_chessBoard);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Caro_game";
            FormClosing += Form1_FormClosing;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)img_Player).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_chessBoard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox img_Player;
        private System.Windows.Forms.ProgressBar prcb_CoolDown;
        private System.Windows.Forms.TextBox txt_PlayerName;
        private System.Windows.Forms.Timer tm_CountDown;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnMenu;
        private System.Windows.Forms.ToolStripMenuItem mnNewGame;
        private System.Windows.Forms.ToolStripMenuItem mnQuit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRoomName;
        private Guna.UI2.WinForms.Guna2Button btnLAN;
        private Guna.UI2.WinForms.Guna2TextBox txtRoomName;
        
        private System.Windows.Forms.TextBox txtChatInput;
        private Guna.UI2.WinForms.Guna2Button btnSendChat;
        private Guna.UI2.WinForms.Guna2TextBox txtChat;
        private Guna.UI2.WinForms.Guna2TextBox txtStatus;
    }
}

