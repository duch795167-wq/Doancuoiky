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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pnl_chessBoard = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            label1 = new Label();
            btnLAN = new Button();
            txtIP = new TextBox();
            img_Player = new PictureBox();
            prcb_CoolDown = new ProgressBar();
            txt_PlayerName = new TextBox();
            tm_CountDown = new System.Windows.Forms.Timer(components);
            menuStrip1 = new MenuStrip();
            menu = new ToolStripMenuItem();
            newGameToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            txtStatus = new TextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)img_Player).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_chessBoard
            // 
            pnl_chessBoard.BackColor = SystemColors.Control;
            pnl_chessBoard.Location = new Point(10, 40);
            pnl_chessBoard.Margin = new Padding(2);
            pnl_chessBoard.Name = "pnl_chessBoard";
            pnl_chessBoard.Size = new Size(623, 696);
            pnl_chessBoard.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(639, 40);
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
            pictureBox1.Location = new Point(4, 3);
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
            panel3.Controls.Add(label1);
            panel3.Controls.Add(btnLAN);
            panel3.Controls.Add(txtIP);
            panel3.Controls.Add(img_Player);
            panel3.Controls.Add(prcb_CoolDown);
            panel3.Controls.Add(txt_PlayerName);
            panel3.Location = new Point(639, 298);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(236, 228);
            panel3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Elephant", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 166);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(174, 29);
            label1.TabIndex = 5;
            label1.Text = "5 in line to win";
            // 
            // btnLAN
            // 
            btnLAN.Location = new Point(4, 118);
            btnLAN.Margin = new Padding(2);
            btnLAN.Name = "btnLAN";
            btnLAN.Size = new Size(122, 22);
            btnLAN.TabIndex = 4;
            btnLAN.Text = "LAN";
            btnLAN.UseVisualStyleBackColor = true;
            btnLAN.Click += btnLAN_Click;
            // 
            // txtIP
            // 
            txtIP.Location = new Point(4, 78);
            txtIP.Margin = new Padding(2);
            txtIP.Name = "txtIP";
            txtIP.Size = new Size(123, 23);
            txtIP.TabIndex = 3;
            txtIP.Text = "127.0.0.1";
            // 
            // img_Player
            // 
            img_Player.BackColor = SystemColors.Control;
            img_Player.Location = new Point(131, 3);
            img_Player.Margin = new Padding(2);
            img_Player.Name = "img_Player";
            img_Player.Size = new Size(102, 135);
            img_Player.SizeMode = PictureBoxSizeMode.StretchImage;
            img_Player.TabIndex = 2;
            img_Player.TabStop = false;
            // 
            // prcb_CoolDown
            // 
            prcb_CoolDown.Location = new Point(4, 42);
            prcb_CoolDown.Margin = new Padding(2);
            prcb_CoolDown.Name = "prcb_CoolDown";
            prcb_CoolDown.Size = new Size(122, 22);
            prcb_CoolDown.TabIndex = 1;
            // 
            // txt_PlayerName
            // 
            txt_PlayerName.Location = new Point(4, 3);
            txt_PlayerName.Margin = new Padding(2);
            txt_PlayerName.Name = "txt_PlayerName";
            txt_PlayerName.ReadOnly = true;
            txt_PlayerName.Size = new Size(123, 23);
            txt_PlayerName.TabIndex = 0;
            // 
            // tm_CountDown
            // 
            tm_CountDown.Tick += tm_CountDown_Tick;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(880, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // menu
            // 
            menu.DropDownItems.AddRange(new ToolStripItem[] { newGameToolStripMenuItem, quitToolStripMenuItem });
            menu.Name = "menu";
            menu.Size = new Size(50, 20);
            menu.Text = "Menu";
            // 
            // newGameToolStripMenuItem
            // 
            newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            newGameToolStripMenuItem.Size = new Size(132, 22);
            newGameToolStripMenuItem.Text = "New Game";
            newGameToolStripMenuItem.Click += newGameToolStripMenuItem_Click;
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.Size = new Size(132, 22);
            quitToolStripMenuItem.Text = "Quit";
            quitToolStripMenuItem.Click += quitToolStripMenuItem_Click;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(643, 541);
            txtStatus.Margin = new Padding(2);
            txtStatus.Multiline = true;
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(209, 152);
            txtStatus.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 747);
            Controls.Add(txtStatus);
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
        private System.Windows.Forms.Button btnLAN;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.PictureBox img_Player;
        private System.Windows.Forms.ProgressBar prcb_CoolDown;
        private System.Windows.Forms.TextBox txt_PlayerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tm_CountDown;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.TextBox txtStatus;
    }
}

