using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SnakeClassicGUI
{
    public static class StartGUI
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static SnakeMainForm snakeMainForm;
        [STAThread]        
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            snakeMainForm = new SnakeMainForm();
            Application.Run(snakeMainForm);
        }
    }
}
