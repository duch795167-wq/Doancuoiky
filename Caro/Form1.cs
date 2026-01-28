using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace Caro
{

    public partial class Form1 : Form
    {
        #region Properties 

        ChessBoardManager ChessBoard;
        TcpClient client;
        NetworkStream stream;
        Thread receiveThread;
        bool myTurn = false;
        bool isO = false;
        int newgame = 0;
        int newChat = 0;


        #endregion 
        public Form1()
        {
            InitializeComponent();
            ChessBoard = new ChessBoardManager(pnl_chessBoard, txt_PlayerName, img_Player);

            ChessBoard.EndedGame += ChessBoard_EndedGame;
            ChessBoard.PlayerMarked += ChessBoard_PlayerMarked;
            ChessBoard.PlayerMoved += ChessBoard_PlayerMoved;

            prcb_CoolDown.Step = Cons.COOL_DOWN_STEP;
            prcb_CoolDown.Maximum = Cons.COOL_DOWN_TIME;
            prcb_CoolDown.Value = 0;
            tm_CountDown.Interval = Cons.COOL_DOWN_INTERVAL;
            newgame = 1;
            btnLAN.DisabledState.FillColor = Color.White;


            NewGame(newgame);

        }


        #region Methods

        private void tm_CountDown_Tick(object sender, EventArgs e)
        {

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }


        #endregion

        private void btnLAN_Click(object sender, EventArgs e)
        {

        }

        #region SendMethod

        void SendMove(int x, int y)
        {
            try
            {
                string msg = $"MOVE|{x}|{y}\n";
                byte[] data = Encoding.UTF8.GetBytes(msg);
                stream.Write(data, 0, data.Length);

                myTurn = false;
                tm_CountDown.Stop();
                pnl_chessBoard.Enabled = false;
                prcb_CoolDown.Enabled = false;
                prcb_CoolDown.Value = 0;


            }
            catch
            {
                MessageBox.Show("L?i g?i n??c ?i");
            }
        }

        void SendTimeOut()
        {
            try
            {
                string msg = "TIMEOUT\n";
                byte[] data = Encoding.UTF8.GetBytes(msg);
                stream.Write(data, 0, data.Length);


            }
            catch
            {
                MessageBox.Show("L?i end game");
            }
        }
        void SendEnd()
        {
            try
            {
                string msg = "ENDGAME\n";
                byte[] data = Encoding.UTF8.GetBytes(msg);
                stream.Write(data, 0, data.Length);

            }
            catch
            {
                MessageBox.Show("L?i end game");
            }
        }
        void SendOut()
        {
            try
            {
                string msg = "OUT\n";
                if (stream == null) return;

                byte[] data = Encoding.UTF8.GetBytes(msg);
                stream.Write(data, 0, data.Length);
            }
            catch { }
        }

        void SendChat(string msg)
        {
            try
            {

                if (stream == null) return;

                byte[] data = Encoding.UTF8.GetBytes(msg);
                stream.Write(data, 0, data.Length);
            }
            catch { }
        }



        #endregion


    }
}
