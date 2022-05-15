using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GoViewer
{
    /// <summary>
    /// xử lý chuột, màn hình, v.v.
    /// </summary>
    public partial class MainForm : Form
    {
        private BoardPanel boardPanel;
        /// <summary>
        /// Khởi tạo một bảng mới
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            countingMode = false;
            board = new Board();
            this.boardPanel = new BoardPanel();
            this.boardPanel.Size = new System.Drawing.Size(this.Width - statPanel.Width - 16, this.Height - controlPanel.Height - 64);
            this.boardPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.boardPanel_Paint);
            this.boardPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.boardPanel_MouseClick);
            this.boardPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.boardPanel_MouseMove);
            this.boardPanel.Resize += new System.EventHandler(this.boardPanel_Resize);
            this.Controls.Add(this.boardPanel);

        }

        /// <summary>
        /// Mục menu thoát
        /// </summary>
        private void itemQuit_Click(object sender, EventArgs e)
        {
            Dispose();
        }
       
        private Board board;
        private const bool BLACK = true;
        private const bool WHITE = false;

        private int width;
        private int height;
        private int size;
        private int mouseI;
        private int mouseJ;
        private bool mouseIn = false;
        private int timerCount;

        private bool? turn;
        private Image img;

        //Vẽ lại bảng ô rô, vẽ các mảnh bảng ô vuông
        private void boardPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(img, 0, 0);
            if (board.Count == 0) return;
            drawSign(g, board.Moves[board.Count - 1].row, board.Moves[board.Count - 1].col, board.Moves[board.Count - 1].black);
        }

        /// <summary>
        /// 画棋子
        /// </summary>
        /// <param name="g"></param>
        /// <param name="i">hàng i</param>
        /// <param name="j">Cột</param>
        /// <param name="isBlack">Màu đen true， Màu trắng false, null trống</param>
        private void drawStone(Graphics g, int i, int j, bool? isBlack)
        {
            if (isBlack == null) return;
            int x = width / 2 - 9 * size + j * size;
            int y = height / 2 - 9 * size + i * size;

            //Đặt gradient màu để vẽ các quân cờ
            Brush brush;
            if (isBlack == BLACK)
                brush = new LinearGradientBrush(new Rectangle(x, y, size, size), Color.Gray, Color.Black, 60f);
            else
                brush = new LinearGradientBrush(new Rectangle(x, y, size, size), Color.White, Color.Gray, 60f);

            g.FillEllipse(brush, x, y, size, size);
        }

        /// <summary>
        /// Thay đổi kích thước cửa sổ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void boardPanel_Resize(object sender, EventArgs e)
        {
            width = boardPanel.Width;
            height = boardPanel.Height;
            size = Math.Min(width, height) / 21;
            img = new Bitmap(width, height);
            drawImage();
            Refresh();
        }
            
        private bool countingMode;
        /// <summary>
        /// Phản hồi bàn cờ nhấp chuột
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void boardPanel_MouseClick(object sender, MouseEventArgs e)
        {
            getMouse(e.X, e.Y, turn);
            if (countingMode)
            {
                if (mouseIn)
                {
                    board.setGridCount(mouseI, mouseJ);
                    JudgeAndRefresh();
                }
            }
            else
            {
                if (mouseIn)                    //Chuột có ở trên bàn cờ hay không
                {
                    board.setStone(mouseI, mouseJ, turn);
                   
                    if (board.isKo)
                    {
                        DisplayEnd();
                        mouseIn = false;
                        board.isKo = false;
                        return;
                    }
                    //Cập nhật bảng
                    drawImage();
                    Refresh();
                    //hoán đổi đen trắng
                    if (board.IsValid)
                        if (turn == true) turn = false;
                        else if (turn == false) turn = true;
                }
            }
            mouseIn = false;
        }

        /// <summary>
        /// Kiểm tra xem tọa độ có nằm trong giới hạn của bàn cờ hay không
        /// Nếu bạn đang chuyển đổi thành tọa độ ma trận bàn cờ và di chuyển
        /// </summary>
        /// <param name="p1">Bảng điều khiển bàn cờ</param>
        /// <param name="p2">Bảng điều khiển bàn cờ</param>
        /// <param name="turn">đen trắng hoặc trống rỗng</param>
        private void getMouse(int p1, int p2, bool? turn)
        {
            mouseI = (p2 - (height / 2 - 9 * size)) / size;
            mouseJ = (p1 - (width / 2 - 9 * size)) / size;
            if (mouseI < 0 || mouseI > 18 || mouseJ < 0 || mouseJ > 18)
            {
                mouseIn = false;
                return;
            }
            mouseIn = true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="g"></param>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <param name="isBlack"></param>
        private void drawSquare(Graphics g, int i, int j, bool? isBlack)
        {
            if (isBlack == null) return;
            int x = width / 2 - 9 * size + j * size + size / 2 - 5;
            int y = height / 2 - 9 * size + i * size + size / 2 - 5;
            if (isBlack == true)
                g.FillRectangle(Brushes.White, x, y, 10, 10);
            else
                g.FillRectangle(Brushes.Black, x, y, 10, 10);

        }

        private void drawSign(Graphics g, int i, int j, bool? isBlack)
        {
            int x = width / 2 - 9 * size + j * size + size / 2;
            int y = height / 2 - 9 * size + i * size + size / 2;
            Point[] p = { new Point(x, y), new Point(x + size / 2, y), new Point(x, y + size / 2) };
            Brush b = isBlack == true ? Brushes.Yellow : Brushes.Blue;
            g.FillPolygon(b, p);
        }
        /// <summary>
        /// Di chuyển chuột trên bàn cờ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void boardPanel_MouseMove(object sender, MouseEventArgs e)
        {
            //setIndex(e.X, e.Y);
        }

        /// <summary>
        /// Khởi tạo sau khi cửa sổ được tải
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            width = boardPanel.Width;
            height = boardPanel.Height;
            size = Math.Min(width, height) / 21;
            turn = BLACK;
            img = new Bitmap(width, height);
            drawImage();

        }

        /// <summary>
        /// Vẽ các quân cờ vào bimap
        /// </summary>
        private void drawImage()
        {
            //img = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(img);

            //Chất lượng bản vẽ tối đa tức là khử răng cưa
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.CompositingQuality = CompositingQuality.HighQuality;

            g.FillRectangle(Brushes.Gray, width / 2 - 9 * size - size / 4 + 3, height / 2 - 9 * size - size / 4 + 3, size * 19 + size / 2, size * 19 + size / 2);
            g.FillRectangle(Brushes.Peru, width / 2 - 9 * size - size / 4, height / 2 - 9 * size - size / 4, size * 19 + size / 2, size * 19 + size / 2);
            Pen pen = new Pen(Brushes.Black, 1);
            for (int i = 0; i < 19; i++)
            {
                g.DrawLine(pen, width / 2 - 9 * size + i * size + size / 2, height / 2 - 9 * size + size / 2,
                    width / 2 - 9 * size + i * size + size / 2, height / 2 + 9 * size + size / 2);
                g.DrawLine(pen, width / 2 - 9 * size + size / 2, height / 2 - 9 * size + i * size + size / 2,
                    width / 2 + 9 * size + size / 2, height / 2 - 9 * size + i * size + size / 2);
            }
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    g.FillEllipse(Brushes.Black, width / 2 - 9 * size + size / 2 + ((i + 1) * 6 - 3) * size - 4,
                        height / 2 - 9 * size + size / 2 + ((j + 1) * 6 - 3) * size - 4, 8, 8);
                }
            for (int i = 0; i < 19; i++)
                for (int j = 0; j < 19; j++)
                    drawStone(g, i, j, board.getStone(i, j));
        }

        private List<Move> moves;

        /// <summary>
        /// Xóa bảng và hẹn giờ
        /// Hiển thị thời gian của bản ghi cờ vua vừa được chơi hoặc tải từ một tệp
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMode_Click(object sender, EventArgs e)
        {
            
            moves = new List<Move>(board.Moves);
            board.clear();
            timerCount = 0;
            timerView.Enabled = true;
            drawImage();
            boardPanel.Refresh();
            
        }

        /// <summary>
        /// Hành động sự kiện hẹn giờ
        private System.Windows.Forms.Timer aTimer;
        private int counter = 0;
        private void aTimer_Tick(object sender, EventArgs e)

        {

            counter--;

            if (counter == 0)

                aTimer.Stop();
            else
            label1.Text = counter.ToString();

        }

        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerView_Tick(object sender, EventArgs e)
        {
            if (timerCount >= moves.Count)
            {
                timerView.Enabled = false;
                board.Moves = new List<Move>(moves);
                return;
            }
            board.setStone(moves[timerCount].row, moves[timerCount].col, moves[timerCount].black == BLACK);
            timerCount++;
            drawImage();
            boardPanel.Refresh();
        }

        /// <summary>
        /// Mở tệp và menu
        /// Phân tích cú pháp một số tệp gib
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Tep|*.gib;*.NGF|Sachhuongdan|*.gib|Co|*.NGF";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (dialog.FileName.ToLower().EndsWith(".gib"))
                    ParseEweiqiFile(dialog);
                else if (dialog.FileName.ToLower().EndsWith(".ngf"))
                    ParseSinaFile(dialog);
            }

            DisplayEnd();
        }

        /// <summary>
        /// Phân tích
        /// </summary>
        /// <param name="dialog"></param>
        private void ParseSinaFile(OpenFileDialog dialog)
        {
            FileStream aFile = new FileStream(dialog.FileName, FileMode.Open);
            StreamReader sr = new StreamReader(aFile);
            board.Moves = new List<Move>();


            string strLine = sr.ReadLine();
            while (strLine != null)
            {
                if (!strLine.StartsWith("PM"))
                {
                    strLine = sr.ReadLine();
                    continue;
                }
                board.Moves.Add(new Move(strLine[7] - 'B', strLine[8] - 'B', strLine[4] == 'B'));
                strLine = sr.ReadLine();
            }
            sr.Close();
        }

        /// <summary>
        /// Phân tích file cờ vua
        /// </summary>
        /// <param name="dialog"></param>
        private void ParseEweiqiFile(OpenFileDialog dialog)
        {
            FileStream aFile = new FileStream(dialog.FileName, FileMode.Open);
            StreamReader sr = new StreamReader(aFile);
            board.Moves = new List<Move>();


            string strLine = sr.ReadLine();
            while (strLine != null)
            {
                string[] Strs = strLine.Split(' ');
                if (Strs[0] != "STO")
                {
                    strLine = sr.ReadLine();
                    continue;
                }
                board.Moves.Add(new Move(int.Parse(Strs[5]), int.Parse(Strs[4]), Strs[3] == "1"));
                strLine = sr.ReadLine();
            }
            sr.Close();
        }

        /// <summary>
        /// kết thúc chương trình
        /// </summary>
        private void DisplayEnd()
        {
            moves = new List<Move>(board.Moves);
            board.clear();
            //drawImage();
            //boardPanel.Refresh();
            foreach (var item in moves)
            {
                board.setStone(item.row, item.col, item.black == BLACK);
            }
            drawImage();
            boardPanel.Refresh();
            board.Moves = new List<Move>(moves);
        }

        /// <summary>
        /// Hành động nút trước đó
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            board.Previous();
            drawImage();
            boardPanel.Refresh();
        }

        /// <summary>
        /// Hành động nút tiếp theo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Click(object sender, EventArgs e)
        {
            board.Next();
            drawImage();
            boardPanel.Refresh();
        }

        /// <summary>
        /// Nút bắt đầu hoạt động
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            board.clear();
            board.GotoStart();
            drawImage();
            boardPanel.Refresh();
            timeout();
        }
        private void timeout()
        {
            if (counter == 0)
            {
                counter = 30;
                aTimer = new System.Windows.Forms.Timer();

                aTimer.Tick += new EventHandler(aTimer_Tick);

                aTimer.Interval = 1000; // 1 second
                aTimer.Start();
            }
            else
            {
                counter = 30;
                aTimer.Start();
            }
        }
        /// <summary>
        /// nút kết thúc hành động
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnd_Click(object sender, EventArgs e)
        {
            DisplayEnd();
        }

        private void btnJudge_Click(object sender, EventArgs e)
        {
            if (!countingMode)
            {
                countingMode = true;
                lblResult.Text = "Xác nhận bên trắng thua";
                lblResult.Visible = true;
                btnJudge.Text = "Xác nhận bên đen thua";
                board.initGridCount();
            }
            else
            {
                JudgeAndRefresh();
                lblResult.Text = (board.NoOfBlackWin - 6.5 > 0 ? "Đen" : "Trắng") + " chiến thắng" + Math.Abs((int)(((float)board.NoOfBlackWin) - 6.5)) + ".5điểm";
                lblResult.Visible = true;
                btnJudge.Text = "Điểm";
                countingMode = false;
            }
        }

        private void JudgeAndRefresh()
        {
            board.Judge();
            drawImage();
            Graphics g = Graphics.FromImage(img);
            for (int i = 0; i < 19; i++)
            {
                for (int j = 0; j < 19; j++)
                {
                    if (board.Result[i, j] == 1) drawSquare(g, i, j, WHITE);
                    if (board.Result[i, j] == 2) drawSquare(g, i, j, BLACK);
                }
            }
            boardPanel.Refresh();
        }

        private void menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void statPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
