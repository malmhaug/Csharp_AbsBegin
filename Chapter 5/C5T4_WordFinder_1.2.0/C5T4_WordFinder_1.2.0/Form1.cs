using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C5T4_WordFinder_1._2._0
{
    public partial class Form1 : Form
    {
        string[] words = new string[5] { "Ducktales", "Robocop", "StarWars", "Doom", "Rambo" };
        const int noRows = 20;
        const int noCols = 20;
        char[,] WordFinderMatrix = new char[noRows, noCols];
        int WordFinderMatrixSpacing = 20;
        int WordFinderMatrixPadding = 5;
        int[] solutionX = new int[100];
        int[] solutionY = new int[100];
        int lastXpos = 0;
        int lastYpos = 0;
        string solutionString = "";
        Graphics g;

        public Form1()
        {
            int FormWidth = noRows * WordFinderMatrixSpacing + WordFinderMatrixPadding + 5;
            int FormHeight = (noCols + 1) * WordFinderMatrixSpacing + WordFinderMatrixPadding + 10;

            InitializeComponent();
            this.Paint += new PaintEventHandler(PaintWordFinder);
            this.SetBounds(0, 0, FormWidth, FormHeight);
            InitializeWordFinderMatrix();
            InsertWords();
            FillWordFinder();
        }

        void InitializeWordFinderMatrix()
        {
            int i;
            int j;
            //Make each character position in the WordfinderMatrix blank
            for (i = 0; i < noRows; i++)
            {
                for (j = 0; j < noCols; j++)
                {
                    WordFinderMatrix[i, j] = ' ';
                }
            }
        }

        private void InsertWords()
        {
            Random RandonNo = new Random();

            foreach (String word in words)
            {
                bool WordInserted = false;

                String currentWord = word.Trim();
                currentWord = currentWord.ToUpper();

                while (WordInserted == false)
                {
                    int randomXDirection = 0;
                    int randomYDirection = 0;

                    int randomRow = RandonNo.Next(noRows);
                    int randomCol = RandonNo.Next(noCols);

                    while ((randomXDirection == 0) && (randomYDirection == 0))
                    {
                        randomXDirection = RandonNo.Next(3) - 1;
                        randomYDirection = RandonNo.Next(3) - 1;
                    }

                    WordInserted = InsertWord(currentWord, randomRow, randomCol, randomXDirection, randomYDirection);

                }
            }
        }

        private bool InsertWord(String word, int row, int col, int xDirection, int yDirection)
        {
            int wordLength = word.Length;
            int i;

            //Check if number of letters in word will be able to be inserted, given the position
            //(row and column) and the number of letter spaces available in the matrix
            if (xDirection > 0)
            {
                if (row + wordLength > noRows)
                {
                    return false;
                }
            }

            if (yDirection > 0)
            {
                if (col + wordLength > noCols)
                {
                    return false;
                }
            }

            if (xDirection < 0)
            {
                if (row - wordLength < 0)
                {
                    return false;
                }
            }

            if (yDirection < 0)
            {
                if (col - wordLength < 0)
                {
                    return false;
                }
            }

            //Check if another word is already inserted at col and row position
            for (i = 0; i < wordLength; i++)
            {
                int matrixXPos = row + (xDirection * i);
                int matrixYPos = col + (yDirection * i);

                if (WordFinderMatrix[matrixXPos, matrixYPos] != ' ')
                {
                    return false;
                }
            }

            //Ok to insert word into WordFinderMatrix
            for (i = 0; i < word.Length; i++)
            {
                int matrixXPos = row + (xDirection * i);
                int matrixYPos = col + (yDirection * i);
                WordFinderMatrix[matrixXPos, matrixYPos] = word[i];
                solutionX[i+lastXpos] = matrixXPos;
                solutionY[i+lastYpos] = matrixYPos;
            }
            lastXpos += wordLength;
            lastYpos += wordLength;

            return true;

        }

        private void FillWordFinder()
        {
            int i;
            int j;
            Random randomNo = new Random();

            for (i = 0; i < noRows; i++)
            {
                for (j = 0; j < noCols; j++)
                {
                    //If a position within the WordFinderMatrix is blank, fill it with a random upper case character
                    if (WordFinderMatrix[i, j] == ' ')
                    {
                        WordFinderMatrix[i, j] = (char)(randomNo.Next(26) + 65);
                    }
                }
            }
        }

        private void PaintWordFinder(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            int i;
            int j;
            g = e.Graphics;

            //Make the background white
            g.FillRectangle(Brushes.White, ClientRectangle);

            //Draw each character in the WordFinderMatrix
            for (i = 0; i < noRows; i++)
            {
                for (j = 0; j < noCols; j++)
                {
                    //Calculate the X and Y position of each character
                    int charXPos = i * WordFinderMatrixSpacing + WordFinderMatrixPadding;
                    int charYPos = j * WordFinderMatrixSpacing + WordFinderMatrixPadding;

                    g.DrawString(WordFinderMatrix[i, j].ToString(), this.Font, Brushes.Black, charXPos, charYPos);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Give the solution if the solution - button is pressed
            solutionString = "";
            Console.Write("\nThis is the X,Y values: \n\n");
            for (int i = 0; i < lastXpos; i++)
            {
                for (int j = 0; j < lastYpos; j++)
                {
                    if (i == j)
                    {
                        //Console.Write("[" + solutionX[i] + "," + solutionY[j] + "]");
                        solutionString += ("\n[" + solutionX[i] + "," + solutionY[j] + "]").ToString();
                    }
                }
            }
            System.Windows.Forms.MessageBox.Show("The solution is found in the following positions: " + solutionString);
        }
    }
}

