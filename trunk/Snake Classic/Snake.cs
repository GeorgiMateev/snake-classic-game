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
        List<SnakeFragment> snakeBody;
        GameMatrix gamePlatform;
        Timer snakeTimer;    
        SnakeFragment headFragment;

        public SnakeFragment HeadFragment
        {
            get { return headFragment; }
            set { headFragment = value; }
        }
        public Timer SnakeTimer
        {
            get { return snakeTimer; }
            set { snakeTimer = value; }
        }
        public List<SnakeFragment> SnakeBody
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

        public Snake(GameMatrix gamePlatform,int timeInterval)
        {
            Direction = Directions.Left;
            this.gamePlatform = gamePlatform;            
            this.snakeTimer.Interval = timeInterval;
            this.snakeTimer.Tick += new EventHandler(snakeTimer_Tick);
        }

        void snakeTimer_Tick(object sender, EventArgs e)
        {
            MoveSnake();          
        }

        private void CreateBasicSnake()
        {
            this.SnakeBody.Add
                (new SnakeFragment(gamePlatform.MiddleRow, gamePlatform.MiddleColum, gamePlatform.Matrix, this));
            for (int i = 1; i < 5; i++)
            {
                this.SnakeBody.Add
                    (new SnakeFragment(gamePlatform.MiddleRow, gamePlatform.MiddleColum - i, gamePlatform.Matrix, this));
            }
        } 
        private void MoveSnake()
        {
            Field directionField = ReturnDirectionField();
            CheckField(directionField);
        }        
        private Field ReturnDirectionField()
        {
            switch (this.Direction)
            {
                case Directions.Left:
                    return gamePlatform.Matrix[headFragment.Row, headFragment.Col-1];
                    break;
                case Directions.Right:
                    return gamePlatform.Matrix[headFragment.Row, headFragment.Col+1];
                    break;
                case Directions.Up:
                    return gamePlatform.Matrix[headFragment.Row-1, headFragment.Col];
                    break;
                case Directions.Down:
                    return gamePlatform.Matrix[headFragment.Row+1, headFragment.Col];
                    break;
                default:
                    throw new ApplicationException("Something with the snake control gone wrong!");
                    break;
            }
        }
        private void CheckField(Field directionField)
        {
            if (directionField is EmptyField)
            {
                this.OnlyMove();
            }
            if (directionField is SnakeField)
            {
                this.SnakeOverlap();
            }
            if (directionField is FoodField)
            {
                this.IncreaseSnake();
            }
            if (directionField is WallField)
            {
                this.WallHit();
            }
            if (directionField is BorderField)
            {
                this.TeleportAcrossField();
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

        public SnakeFragment(int row, int col,Field[,] currentMatrix,Snake currentSnake)
        {
            this.Row = row;
            this.Col = col;
            currentSnake.HeadFragment = currentSnake.SnakeBody[currentSnake.SnakeBody.Count - 1];
            PutIntoMatrix(this.Row, this.Col, currentMatrix);
        }

        private void PutIntoMatrix(int row, int col, Field[,] currentMatrix)
        {
            currentMatrix[row, col] = new SnakeField();
        }

        
    }
}
