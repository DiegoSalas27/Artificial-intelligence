using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void resetLabelValues(int climbcount = 0) {
            printBoard();
            string message = "¡Se terminaron de iterar todas las columnas\npuedes empezar de nuevo!";
            MessageBox.Show(message);

            for (int i = 0; i < HC_board.Length; i++)
            {
                HC_board[7][i] = 1;
            }
            taken = 0;
            printBoard();

            Console.WriteLine("Hecho en " + (climbcount - 1) + " reinicios.");
            label6.Visible = false;
            lblAtaque.Visible = false;
            lblIterando.Visible = false;
            lblNoMejor.Visible = false;
            lblPrueba.Visible = false;
            Refresh();
        }

        private void mostrarLabelValues() {
            lblAtaque.Text = "Par de reinas que se atacan: ";
            lblIterando.Text = "Iterando columna:";
            lblPrueba.Text = "Prueba #: ";

            lblAtaque.Visible = true;
            lblIterando.Visible = true;
            lblPrueba.Visible = true;
            Refresh();
        }

        private void bnStart_Click(object sender, EventArgs e)
        {
            SolveHillClimbing((int)numericUpDown1.Value, (int)nudLatencia.Value);
        }

        int taken = 0;
        public static int TOTAL_QUEENS = 8;
        int[][] HC_board = new int[8][];
        private int[] queenPositions = new int[8];
        void SolveHillClimbing(int count, int latencia) {

            mostrarLabelValues();

            for (int i = 0; i < 8; i++) {
                HC_board[i] = new int[8];
            }

            Boolean climb = true;
            int climbcount = 0;

            while (climb) {
                // posicionar reinas de forma aleatoria

                placeQueens();
                Console.WriteLine("Prueba #: " + (climbcount + 1));
                lblPrueba.Text = "Prueba #: " + (climbcount + 1).ToString();
                Refresh();
                Console.WriteLine("Tablero original:");
                printBoard();
                Console.WriteLine("# Par de reinas que se atacan: "
                    + heuristic() + "\n");
                lblAtaque.Text = "Par de reinas que se atacan: " + heuristic().ToString();
                Refresh();
                // score a ser comparado
                int localMin = heuristic();
                Boolean best = false;
                // arreglo para almacenar la mejor posición de la reina por fila
                // (indice del arreglo es columna)
                int[] bestQueenPositions = new int[8];

                // itera cada columna
                for (int j = 0; j < HC_board.Length; j++) {

                    Console.WriteLine("Iterando columna " + j + ":");
                    lblIterando.Text = "Iterando columna: " + (j + 1).ToString();
                    Refresh();
                    best = false;
                    // itera cada fila
                    for (int i = 0; i < HC_board.Length; i++)
                    {

                        // no probar con la posición original de la reina
                        if (i != queenPositions[j])
                        {

                            //mover reina
                            moveQueen(i, j, latencia);
                            printBoard();
                            Console.WriteLine();
                            // calcula score, si encuentras uno mejor, entonces almacena la mejor
                            // posición de la reina
                            if (heuristic() < localMin)
                            {
                                best = true;
                                localMin = heuristic();
                                bestQueenPositions[j] = i;
                            }
                            // volver a la posición original de la reina
                            resetQueen(i, j);
                        }
                    }

                    taken++;

                    // cambia 2 a 1
                    resetBoard(j);
                    if (best)
                    {
                        lblNoMejor.Visible = false;
                        Refresh();
                        // Si se ha encontrado un mejor score poner las reinas en esta posición
                        placeBestQueen(j, bestQueenPositions[j]);
                        Console.WriteLine("Mejor tablero en esta iteración: ");
                        printBoard();
                        Console.WriteLine("# Par de reinas que se atacan: "
                            + heuristic() + "\n");
                        lblAtaque.Text = "Par de reinas que se atacan: " + heuristic().ToString();
                        Refresh();
                    }
                    else
                    {
                        Console.WriteLine("No se ha encontrado mejor solución.");
                        lblNoMejor.Visible = true;
                        Refresh();
                        printBoard();
                        Console.WriteLine("# Par de reinas que se atacan: "
                            + heuristic() + "\n");
                        lblAtaque.Text = "Par de reinas que se atacan: " + heuristic().ToString();
                        Refresh();
                    }
                }

                // if score = 0, hill climbing has solved the problem
                if (heuristic() == 0) {
                    climb = false;
                    resetLabelValues(climbcount);
                    return;
                }
                    
                climbcount++;

                if (climbcount == count) {
                    climb = false;
                    resetLabelValues(climbcount);
                    return;
                }
            }
        }

        int columna = 0;
        void SolveHillClimbing2(int count, int latencia) {

            mostrarLabelValues();

            if (columna == 8) {
                resetLabelValues();
                columna = 0;
                return;
            }

            Boolean climb = true;
            int climbcount = 0;

            if (columna == 0) {
                for (int i = 0; i < 8; i++)
                {
                    HC_board[i] = new int[8];
                }
            }

            while (climb)
            {
                if (columna == 0)
                    placeQueens();
                Console.WriteLine("Prueba #: " + (climbcount + 1));
                lblPrueba.Text = "Prueba #: " + (climbcount + 1).ToString();
                Refresh();
                Console.WriteLine("Tablero original:");
                printBoard();
                Console.WriteLine("# Par de reinas que se atacan: "
                    + heuristic() + "\n");
                lblAtaque.Text = "Par de reinas que se atacan: " + heuristic().ToString();
                Refresh();
                // score a ser comparado
                int localMin = heuristic();
                Boolean best = false;
                // arreglo para almacenar la mejor posición de la reina por fila
                // (indice del arreglo es columna)
                int[] bestQueenPositions = new int[8];

                // itera cada columna
                for (int j = columna; j <= columna; j++)
                {

                    Console.WriteLine("Iterando columna " + j + ":");
                    lblIterando.Text = "Iterando columna: " + (j + 1).ToString();
                    Refresh();
                    best = false;
                    // itera cada fila
                    for (int i = 0; i < HC_board.Length; i++)
                    {

                        // no probar con la posición original de la reina
                        if (i != queenPositions[j])
                        {

                            //mover reina
                            moveQueen(i, j, latencia);
                            printBoard();
                            Console.WriteLine();
                            // calcula score, si encuentras uno mejor, entonces almacena la mejor
                            // posición de la reina
                            if (heuristic() < localMin)
                            {
                                best = true;
                                localMin = heuristic();
                                bestQueenPositions[j] = i;
                            }
                            // volver a la posición original de la reina
                            resetQueen(i, j);
                        }
                    }

                    taken++;

                    // cambia 2 a 1
                    resetBoard(j);
                    if (best)
                    {
                        // Si se ha encontrado un mejor score poner las reinas en esta posición
                        lblNoMejor.Visible = false;
                        placeBestQueen(j, bestQueenPositions[j]);
                        Console.WriteLine("Mejor tablero en esta iteración: ");
                        printBoard();
                        Console.WriteLine("# Par de reinas que se atacan: "
                            + heuristic() + "\n");
                        lblAtaque.Text = "Par de reinas que se atacan: " + heuristic().ToString();
                        Refresh();
                    }
                    else
                    {
                        lblNoMejor.Visible = true;
                        Console.WriteLine("No se ha encontrado mejor solución.");
                        printBoard();
                        Console.WriteLine("# Par de reinas que se atacan: "
                            + heuristic() + "\n");
                        lblAtaque.Text = "Par de reinas que se atacan: " + heuristic().ToString();
                        Refresh();
                    }
                }
                    
                columna++;
                return;
            }
        }

        public void placeQueens() {
            queenPositions = generateQueens();

            for (int i = 0; i < HC_board.Length; i++) {
                HC_board[queenPositions[i]][i] = 1;
            }
        }

        private int[] generateQueens() {

            List<int> randomPos = new List<int>();

            Random r = new Random();
            for (int i = 0; i < TOTAL_QUEENS; i++) {
                randomPos.Add(r.Next(8));
            }

            int[] randomPositions = new int[TOTAL_QUEENS];

            for (int i = 0; i < randomPos.Count(); i++) {
                randomPositions[i] = randomPos.ElementAt(i);
            }

            return randomPositions;
        }

        public void printBoard() {
            for (int i = 0; i < HC_board.Length; i++) {
                for (int j = 0; j < HC_board.Length; j++) {
                    Console.Write(HC_board[i][j] + " ");
                }
                Console.WriteLine();
            }

            int[] sol = new int[TOTAL_QUEENS];
            for (int p = 0; p < TOTAL_QUEENS; p++)
            {
                for (int q = 0; q < TOTAL_QUEENS; q++)
                {
                    if (HC_board[q][p] == 1)
                    {
                        sol[p] = 7 - q;
                    }
                }

                board1.Genes = sol;
                board1.taken = taken;
            }
        }

        public int heuristic() {

            int totalPairs = 0;

            //chekear filas
            for (int i = 0; i < HC_board.Length; i++) {

                List<Boolean> pairs = new List<Boolean>();
                for (int j = 0; j < HC_board[i].Length; j++) {
                    if (HC_board[i][j] == 1) {
                        pairs.Add(true);
                    }
                }
                if (pairs.Count() != 0)
                    totalPairs = totalPairs + (pairs.Count() - 1);
            }

            // chekear diagonales de arriba a la izquierda
            int rows = HC_board.Count();
            int cols = HC_board.Count();
            int maxSum = rows + cols - 2;

            for (int sum = 0; sum <= maxSum; sum++)
            {
                List<Boolean> pairs = new List<Boolean>();

                for (int i = 0; i < rows; i++)
                {

                    for (int j = 0; j < cols; j++)
                    {

                        if (i + j - sum == 0)
                        {

                            if (HC_board[i][j] == 1)
                            {
                                pairs.Add(true);
                            }
                        }
                    }
                }
                if (pairs.Count() != 0)
                {
                    totalPairs = totalPairs + (pairs.Count() - 1);
                }
            }

            // checkear diagonales de abajo a la izquierda
            int pairss = checkMirrorDiagonal();

            return totalPairs + pairss;
        }

        private int checkMirrorDiagonal() {

            int[] b1 = { HC_board[7][0] };
            int[] b2 = { HC_board[7][1], HC_board[6][0] };
            int[] b3 = { HC_board[7][2], HC_board[6][1], HC_board[5][0] };
            int[] b4 = { HC_board[7][3], HC_board[6][2], HC_board[5][1], HC_board[4][0] };
            int[] b5 = { HC_board[7][4], HC_board[6][3], HC_board[5][2], HC_board[4][1],
                HC_board[3][0] };
            int[] b6 = { HC_board[7][5], HC_board[6][4], HC_board[5][3], HC_board[4][2],
                HC_board[3][1], HC_board[2][0] };
            int[] b7 = { HC_board[7][6], HC_board[6][5], HC_board[5][4], HC_board[4][3],
                HC_board[3][2], HC_board[2][1], HC_board[1][0] };
            int[] b8 = { HC_board[7][7], HC_board[6][6], HC_board[5][5], HC_board[4][4],
                HC_board[3][3], HC_board[2][2], HC_board[1][1], HC_board[0][0] };
            int[] b9 = { HC_board[6][7], HC_board[5][6], HC_board[4][5], HC_board[3][4],
                HC_board[2][3], HC_board[1][2], HC_board[0][1] };
            int[] b10 = { HC_board[5][7], HC_board[4][6], HC_board[3][5], HC_board[2][4],
                HC_board[1][3], HC_board[0][2] };
            int[] b11 = { HC_board[4][7], HC_board[3][6], HC_board[2][5], HC_board[1][4],
                HC_board[0][3] };
            int[] b12 = { HC_board[3][7], HC_board[2][6], HC_board[1][5], HC_board[0][4] };
            int[] b13 = { HC_board[2][7], HC_board[1][6], HC_board[0][5] };
            int[] b14 = { HC_board[1][7], HC_board[0][6] };
            int[] b15 = { HC_board[0][7] };

            int totalPairs = 0;

            totalPairs += checkMirrorHorizontal(b1);
            totalPairs += checkMirrorHorizontal(b2);
            totalPairs += checkMirrorHorizontal(b3);
            totalPairs += checkMirrorHorizontal(b4);
            totalPairs += checkMirrorHorizontal(b5);
            totalPairs += checkMirrorHorizontal(b6);
            totalPairs += checkMirrorHorizontal(b7);
            totalPairs += checkMirrorHorizontal(b8);
            totalPairs += checkMirrorHorizontal(b9);
            totalPairs += checkMirrorHorizontal(b10);
            totalPairs += checkMirrorHorizontal(b11);
            totalPairs += checkMirrorHorizontal(b12);
            totalPairs += checkMirrorHorizontal(b13);
            totalPairs += checkMirrorHorizontal(b14);
            totalPairs += checkMirrorHorizontal(b15);

            return totalPairs;
        }

        private int checkMirrorHorizontal(int[] b) {

            int totalPairs = 0;

            List<Boolean> pairs = new List<Boolean>();

            for (int i = 0; i < b.Length; i++) {
                if (b[i] == 1) {
                    pairs.Add(true);
                }
            }

            if (pairs.Count() != 0) {
                totalPairs = (pairs.Count() - 1);
            }

            return totalPairs;
        }

        public void moveQueen(int row, int col, int latencia) {
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(latencia));
            //la posición original de la reina es 2 y actua como marcador
            HC_board[queenPositions[col]][col] = 2;

            HC_board[row][col] = 1;

            lblAtaque.Text = "Par de reinas que se atacan: " + heuristic().ToString();
            Refresh();
        }

        public void resetQueen(int row, int col) {

            if (HC_board[row][col] == 1)
                HC_board[row][col] = 0;
        }

        public void resetBoard(int col) {

            for (int i = 0; i < HC_board.Count(); i++) {

                if (HC_board[i][col] == 2)
                    HC_board[i][col] = 1;
            }
        }

        public void placeBestQueen(int col, int queenPos) {

            for (int i = 0; i < HC_board.Length; i++) {

                if (HC_board[i][col] == 1)
                    HC_board[i][col] = 0;
            }
            HC_board[queenPos][col] = 1;

            for (int i = 0; i < HC_board.Length; i++) {

                if (HC_board[i][col] == 2)
                    HC_board[i][col] = 0;
            }
        }

        private void board1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SolveHillClimbing2((int)numericUpDown1.Value, (int)nudLatencia.Value);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
