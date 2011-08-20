using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace SnakeInterfaces
{
    interface IUserControls<T>
    {
        T ChangeDirectionToLeft();
        T ChangeDirectionToRight();
        T ChangeDirectionToUp();
        T ChangeDirectionToDown();
        void Start(Timer timer, bool running);
        void Stop(Timer timer, bool running);
    }
}
