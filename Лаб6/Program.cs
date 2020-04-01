using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаб6
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// <remark>
        /// Приложение "Калькулятор"
        /// Данное приложение позволяет выполнять простые арифметические операции (+ - * /).
        /// Вводить цифры и знаки арифметических операций можно как с клавиатуры, так и по нажатию соответствующих кнопок на клавиатуре. 
        /// Также можно пользоваться кнопкой .(точка) как на клавиатуре, так и кнопкой в приложении.
        /// Для полученя результата используется кнопка =(равно) как на клавиатуре, так и в приложении.
        /// Для удаления всей информации используется клавиша backspace или кнопка CE в приложении.
        /// </remark>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
