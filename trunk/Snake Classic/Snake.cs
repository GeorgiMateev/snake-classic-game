using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;


namespace SnakeInterfaces
{
    public enum Directions
    {
        Left,Right,Up,Down
    }
    
    public class Snake
    {
        Directions direction;
        bool running;
        Queue<SnakeFragment> snakeBody;
        GameMatrix gamePlatform;
        Timer snakeTimer;

        public Timer SnakeTimer
        {
            get { return snakeTimer; }
            set { snakeTimer = value; }
        }
        public Queue<SnakeFragment> SnakeBody
        {
            get { return snakeBody; }
            set { snakeBody = value; }
        }
        public bool Running
        {
            get { return running; }
            set { running = value; }
        }      
        public Directions Direction
        {
            get { return direction; }
            set { direction = value; }
        }

        public Snake(GameMatrix gamePlatform)
        {
            Direction = Directions.Left;
            this.gamePlatform = gamePlatform;
        }

        private void CreateBasicSnake()
        {
            this.SnakeBody.Enqueue
                (new SnakeFragment(gamePlatform.MiddleRow, gamePlatform.MiddleColum, gamePlatform.Matrix));
            for (int i = 1; i < 5; i++)
            {
                this.SnakeBody.Enqueue
                    (new SnakeFragment(gamePlatform.MiddleRow, gamePlatform.MiddleColum + i, gamePlatform.Matrix));
            }
        }     
        
    }

    public class SnakeFragment
    {
        int row;
        int col;

        public int Row
        {
            get { return row; }
            set { row = value; }
        }     
        public int Col
        {
            get { return col; }
            set { col = value; }
        }

        public SnakeFragment(int row, int col,Field[,] currentMatrix)
        {
            this.Row = row;
            this.Col = col;
            PutIntoMatrix(this.Row, this.Col, currentMatrix);
        }

        private void PutIntoMatrix(int row, int col, Field[,] currentMatrix)
        {
            currentMatrix[row, col] = new SnakeField();
        }

        
    }
}
