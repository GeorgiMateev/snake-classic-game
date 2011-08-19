using System;
using System.Collections.Generic;
using System.Text;

namespace Snake_Classic
{
    public enum Directions
    {
        Left,Right,Up,Down
    }

    class Snake
    {
        Directions direction;
        Queue<SnakeFragment> snakeBody;

        public Directions Direction
        {
            get { return direction; }
            set { direction = value; }
        }

        public Snake()
        {
            Direction = Directions.Left;
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

        public SnakeFragment(int row, int col)
        {
            this.Row = row;
            this.Col = col;
            PutIntoMatrix(this.Row, this.Col);
        }

        
    }
}
