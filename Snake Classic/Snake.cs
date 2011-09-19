using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;



namespace SnakeClassLib
{
    public enum Directions
    {
        Left,Right,Up,Down
    }
    

    public class GameOverEventArgs : EventArgs
    {
        private int snakeSize;

        public int SnakeSize
        {
            get { return snakeSize; }
            set { snakeSize = value; }
        }

        public GameOverEventArgs(List<SnakeFragment> snakeBody)
        {
            this.snakeSize = snakeBody.Count;
        }
    }

    public class SnakeRunningEventArgs : EventArgs
    {
        private string status;

        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        public SnakeRunningEventArgs(string status)
        {
            this.status = status;
        }
    }

    public class Snake
    {      

        Directions direction;
        bool running;
        int changedDirectionCount;       
        List<SnakeFragment> snakeBody;
        GameMatrix gamePlatform;
        Timer snakeTimer;    
        SnakeFragment headFragment;


        public delegate void GameOverEventHandler(object sender, GameOverEventArgs e);
        public event GameOverEventHandler GameOver;

        public delegate void SnakeRunningChangeEventHandler(object sender, SnakeRunningEventArgs e);
        public event SnakeRunningChangeEventHandler RunChange;

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
        public int ChangedDirectionCount
        {
            get { return changedDirectionCount; }
            set { changedDirectionCount = value; }
        }

        public Snake(GameMatrix gamePlatform,int timeInterval)
        {
            Direction = Directions.Left;
            changedDirectionCount=0;
            this.gamePlatform = gamePlatform;
            this.snakeBody = new List<SnakeFragment>();           
            this.snakeTimer = new Timer();
            this.snakeTimer.Enabled = false;
            this.snakeTimer.Interval = timeInterval;
            this.snakeTimer.Tick += new EventHandler(snakeTimer_Tick);
        }

        void snakeTimer_Tick(object sender, EventArgs e)
        {
            MoveSnake();          
        }

        public void CreateBasicSnake()
        {
            
            this.SnakeBody.Add
                (new SnakeFragment(gamePlatform.MiddleRow, gamePlatform.MiddleColum, gamePlatform.Matrix, this,Directions.Left));
            for (int i = 1; i < 5; i++)
            {
                this.SnakeBody.Add
                    (new SnakeFragment(gamePlatform.MiddleRow, gamePlatform.MiddleColum - i, gamePlatform.Matrix, this,this.snakeBody[snakeBody.Count-1].DrawDirection));
            }
            this.SetHeadFragment();
        }
        public void SetHeadFragment()
        {
            this.HeadFragment = this.SnakeBody[this.SnakeBody.Count - 1];
        }

        public void StartOrStopSnakeTimer()
        {
            if (this.SnakeTimer.Enabled)
            {
                this.SnakeTimer.Stop();
                SnakeRunningEventArgs e = new SnakeRunningEventArgs("Stopped");
                this.RunChange(this, e);
            }
            else
            {
                this.SnakeTimer.Start();
                SnakeRunningEventArgs e = new SnakeRunningEventArgs("Running");
                this.RunChange(this, e);
            }
        }    

        private void MoveSnake()
        {
            Field directionField = ReturnDirectionField();
            CheckField(directionField);
        }        
        private Field ReturnDirectionField()
        {
            try
            {
                switch (this.Direction)
                {

                    case Directions.Left:
                        return gamePlatform.Matrix[headFragment.Row, headFragment.Col - 1];
                        break;
                    case Directions.Right:
                        return gamePlatform.Matrix[headFragment.Row, headFragment.Col + 1];
                        break;
                    case Directions.Up:
                        return gamePlatform.Matrix[headFragment.Row - 1, headFragment.Col];
                        break;
                    case Directions.Down:
                        return gamePlatform.Matrix[headFragment.Row + 1, headFragment.Col];
                        break;
                    default:
                        throw new ApplicationException("Something with the snake control gone wrong!");
                        break;
                }
            }
            catch (IndexOutOfRangeException)
            {
                return TeleportAcrossPlatform();
            }
        }
        private void CheckField(Field directionField)
        {
                      
            if (directionField is EmptyField)
            {
                this.OnlyMove(directionField);
            }
            if (directionField is FoodField)
            {
                this.IncreaseSnake(directionField);
                this.gamePlatform.GenerateFoodField();
            }            
            if (directionField is SnakeField)
            {
                if (IsPreviousField(directionField))
                {
                    this.NormalizeDirection();
                }
                else
                {
                    this.SnakeOverlap();
                }
            }            
            if (directionField is WallField)
            {
                this.WallHit();
            }            
        }               
        private Field TeleportAcrossPlatform()
        {
            switch (this.Direction)
            {
                case Directions.Left:
                    return gamePlatform.Matrix[headFragment.Row, gamePlatform.Matrix.GetLength(1)-1];
                    break;
                case Directions.Right:
                    return gamePlatform.Matrix[headFragment.Row, 0];
                    break;
                case Directions.Up:
                    return gamePlatform.Matrix[gamePlatform.Matrix.GetLength(0)-1, headFragment.Col];
                    break;
                case Directions.Down:
                    return gamePlatform.Matrix[0, headFragment.Col];
                    break;
                default:
                    throw new ApplicationException("When crossing platform something gone wrong");
                    break;
            }
        }              

        private bool IsPreviousField(Field directionField)
        {
            return (directionField.Row == snakeBody[snakeBody.Count - 2].Row && directionField.Col == snakeBody[snakeBody.Count - 2].Col);            
        }
        private void NormalizeDirection()
        {
            switch (this.Direction)
            {
                case Directions.Left:
                    this.Direction = Directions.Right;
                    break;
                case Directions.Right:
                    this.Direction = Directions.Left;
                    break;
                case Directions.Up:
                    this.Direction = Directions.Down;
                    break;
                case Directions.Down:
                    this.Direction = Directions.Up;
                    break;
                default: throw new ApplicationException("Something with the snake movement gone wrong");
                    break;
            }
        }

        private void OnlyMove(Field directionField)
        {
            this.snakeBody.Add
                (new SnakeFragment(directionField.Row,directionField.Col,gamePlatform.Matrix,this,this.Direction));
            this.SetHeadFragment();
            EmptyUsedField();
            this.snakeBody.RemoveAt(0);           
        }        
        private void IncreaseSnake(Field directionField)
        {
            this.snakeBody.Add
                (new SnakeFragment(directionField.Row, directionField.Col, gamePlatform.Matrix, this,this.Direction));
            this.SetHeadFragment();
        }
        private void EmptyUsedField()
        {
            gamePlatform.Matrix[this.snakeBody[0].Row, this.snakeBody[0].Col] = 
                new EmptyField(this.snakeBody[0].Row, this.snakeBody[0].Col,this.snakeBody[1].DrawDirection);
        }
        private void SnakeOverlap()
        {
            this.CallGameOver();
        }
        private void WallHit()
        {
            this.CallGameOver();
        }
        public void CallGameOver()
        {
            GameOverEventArgs e = new GameOverEventArgs(this.snakeBody);
            if (this.GameOver!=null)
            {
                this.GameOver(this, e);
                
            }
        }
    }

    public class SnakeFragment
    {
        int row;
        int col;
        Directions drawDirection;

        public Directions DrawDirection
        {
            get { return drawDirection; }
            set { drawDirection = value; }
        }

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
        
        public SnakeFragment(int row, int col,Field[,] currentMatrix,Snake currentSnake,Directions drawDirection)
        {
            this.Row = row;
            this.Col = col;
            this.drawDirection = drawDirection;
            PutIntoMatrix(this.Row, this.Col, currentMatrix,drawDirection);
        }        

        private void PutIntoMatrix(int row, int col, Field[,] currentMatrix,Directions drawDirection)
        {
            currentMatrix[row, col] = new SnakeField(row,col,drawDirection);
        }

        
    }
}
