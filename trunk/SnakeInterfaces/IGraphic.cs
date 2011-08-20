using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;

namespace SnakeInterfaces
{
     public interface IGraphic
    {
        void DisplayMatrix(Form formToDisplay);
        void DisplayField();
    }
}
