using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake_Classic
{
    interface IUserControls
    {
        Directions ChangeDirectionToLeft();
        Directions ChangeDirectionToRight();
        Directions ChangeDirectionToUp();
        Directions ChangeDirectionToDown();
    }
}
