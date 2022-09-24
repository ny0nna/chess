using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
       


        //отрисовка доски

        public Panel[,] board; 

        private void Form1_Load(object sender, EventArgs e)
        {
            const int boardSize = 80; //размер 1 клетки
            const int cellSize = 8; //количесьво клеток

            //цвета клеток на доске
            var cell_color1 = Color.SlateGray;
            var cell_color2 = Color.Ivory;

            //манипуляции с формой
            this.Width = 700;
            this.Height = 700;
            this.Text = "Chess Game"; //имя вместо form1 

            board = new Panel[boardSize, cellSize];

            for (int i = 0; i < cellSize; i++)
                for(int j = 0; j < cellSize; j++)
                {
                    var newMap = new Panel
                    {
                        Size = new Size(boardSize, boardSize),
                        Location = new Point(boardSize * i, boardSize * j)
                    };
                    Controls.Add(newMap);

                    board[i, j] = newMap;

                    if ((i + j) % 2 == 0)  //если при делении на 2 остаток будет равен 0, то 
                        newMap.BackColor = cell_color1;
                    else
                        newMap.BackColor = cell_color2;
                }
        }
        
        /*
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            int xOffset;
            int yOffset;

            if (e.Button == MouseButtons.Left)
            {
                xOffset = -e.X - SystemInformation.FrameBorderSize.Width;
                yOffset = -e.Y - SystemInformation.CaptionHeight -
                    SystemInformation.FrameBorderSize.Height;

                mouseOffset = new Point(xOffset, yOffset);
                isMouseDown = true;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }
        */





    }

}
