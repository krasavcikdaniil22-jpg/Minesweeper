namespace Minesweeper
{
    public partial class FormMain : Form
    {
        private const int Rows = 9;
        private const int Columns = 9;
        private const int MinesCount = 10;

        private Button[,] buttons = new Button[Rows, Columns];
        private bool[,] mines = new bool[Rows, Columns];
        private int[,] adjacentMines = new int[Rows, Columns];
        private bool[,] revealed = new bool[Rows, Columns];
        private bool[,] flagged = new bool[Rows, Columns];

        private int cellSize = 40;
        private int openedCells = 0;
        private bool gameOver = false;
        private int flagsPlaced = 0;
        private bool firstClick = true;

        private Random random = new Random();
        public FormMain()
        {
            InitializeComponent();
            CreateGameField();
            PlaceMines();
            CalculateNumbers();
        }


        private void UpdateMinesCounter()
        {
            lblMinesLeft.Text = "Мин осталось: " + (MinesCount - flagsPlaced);
        }

        private void ResetGame()
        {
            for (int row=0;row<Rows;row++)
            {
                for (int col=0;col<Columns;col++)
                {
                    this.Controls.Remove(buttons[row, col]);
                }
            }
            Array.Clear(mines, 0, mines.Length);
            Array.Clear(adjacentMines, 0, adjacentMines.Length);
            Array.Clear(revealed, 0, revealed.Length);
            Array.Clear(flagged,0,flagged.Length);

            firstClick = true;
            openedCells = 0;
            flagsPlaced = 0;
            gameOver = false;

            CreateGameField();
            PlaceMines();
            CalculateNumbers();
            UpdateMinesCounter();
        }

        private void CreateGameField()
        {
            for (int row = 0; row < Rows; row++)
            {
                for (int col = 0; col < Columns; col++)
                {
                    Button btn = new Button();
                    btn.Width = cellSize;
                    btn.Height = cellSize;
                    btn.Left = col * cellSize;
                    btn.Top = row * cellSize;
                    btn.Font = new Font("Arial", 12, FontStyle.Bold);
                    btn.Tag = new Point(row, col);
                    btn.MouseUp += Btn_MouseUp;
                    buttons[row, col] = btn;
                    this.Controls.Add(btn);
                }
            }
        }

        private void Btn_MouseUp(object sender, MouseEventArgs e)
        {
            if (gameOver == true)
            {
                return;
            }

            Button btn = (Button)sender;
            Point position = (Point)btn.Tag;

            int row = position.X;
            int col = position.Y;

            if (revealed[row, col] == true)
            {
                return;
            }

            if (e.Button == MouseButtons.Right)
            {
                if (flagged[row, col] == false)
                {
                    if (flagsPlaced >= MinesCount)
                    {
                        return;
                    }

                    flagged[row, col] = true;
                    btn.Text = "🚩";
                    flagsPlaced++;
                    //MessageBox.Show("Флажков поставлено: " + flagsPlaced);
                }
                else
                {
                    flagged[row, col] = false;
                    btn.Text = "";
                    flagsPlaced--;
                }
                UpdateMinesCounter();
            }

            if (e.Button == MouseButtons.Left && flagged[row, col] == false)
            {
                Btn_Click(sender, EventArgs.Empty);
            }
        }

        private void PlaceMines()
        {
            int placeMines = 0;

            while (placeMines < MinesCount)
            {
                int row = random.Next(Rows);
                int col = random.Next(Columns);

                if (mines[row, col] == false)
                {
                    mines[row, col] = true;
                    placeMines++;
                }
            }
        }

        private void ProtectFirstClick(int row,int col)
        {
            Array.Clear(mines,0,mines.Length);

            int placedMines = 0;

            while(placedMines < MinesCount)
            {
                int newRow = random.Next(Rows);
                int newCol = random.Next(Columns);

                bool protectedCell = Math.Abs(newRow - row) <= 1 && Math.Abs(newCol - col) <= 1;

                if (protectedCell == false && mines[newRow, newCol] == false)
                {
                    mines[newRow, newCol]= true;
                    placedMines++;
                }
            }
            Array.Clear(adjacentMines,0,adjacentMines.Length);
            CalculateNumbers();
            firstClick = false;
            
        }

        private void CalculateNumbers()
        {
            for (int row = 0; row < Rows; row++)
            {
                for (int col = 0; col < Columns; col++)
                {
                    if (mines[row, col] == true)
                    {
                        continue;
                    }
                    int count = 0;
                    for (int r = -1; r <= 1; r++)
                    {
                        for (int c = -1; c <= 1; c++)
                        {
                            int newRow = row + r;
                            int newCol = col + c;
                            if (newRow >= 0 && newRow < Rows && newCol >= 0 && newCol < Columns)
                            {
                                if (mines[newRow, newCol] == true)
                                {
                                    count++;
                                }
                            }
                        }
                    }
                    adjacentMines[row, col] = count;
                }
            }
        }

        private void OpenCell(int row, int col)
        {
            if (row < 0 || row >= Rows || col < 0 || col >= Columns)
            {
                return;
            }

            if (revealed[row, col] == true || mines[row, col] == true)
            {
                return;
            }

            revealed[row, col] = true;
            Button btn = buttons[row, col];
            btn.Enabled = false;

            openedCells++;
            int count = adjacentMines[row, col];
            if (count > 0)
            {
                btn.Text = count.ToString();
                return;
            }

            for (int r = -1; r <= 1; r++)
            {
                for (int c = -1; c <= 1; c++)
                {
                    if (r != 0 || c != 0)
                    {
                        OpenCell(row + r, col + c);
                    }
                }
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            if (gameOver == true)
            {
                return;
            }

            Button btn = (Button)sender;
            Point position = (Point)btn.Tag;

            int row = position.X;
            int col = position.Y;

            if (firstClick==true)
            {
                ProtectFirstClick(row, col);
                //MessageBox.Show("Первый клик! Число соседних мин: " + adjacentMines[row, col]);
            }
           

            if (mines[row, col] == true)
            {
                btn.Text = "X";
                btn.BackColor = Color.Red;

                gameOver = true;
                MessageBox.Show("Ты проиграл! Попробуй еще раз)"); return;
            }
            OpenCell(row, col);

            if (openedCells == Rows * Columns - MinesCount)
            {
                gameOver = true;
                MessageBox.Show("Поздравляем с победой)))");
            }
        }
        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetGame();
        }
    }
}
