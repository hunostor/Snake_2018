using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Snake201806.Model
{
    /// <summary>
    /// A játékmenet logikáját tartalmazza
    /// </summary>
    class Arena
    {
        private MainWindow View;

        /// <summary>
        /// Constructor function, create class
        /// </summary>
        /// <param name="view"></param>
        public Arena(MainWindow view)
        {
            this.View = view;

            View.GamePlayTextBlock.Visibility = System.Windows.Visibility.Visible;
        }

        internal void KeyDown(KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Left:
                    View.GamePlayTextBlock.Visibility = System.Windows.Visibility.Hidden;
                    View.NumberOfMealsTextBlock.Visibility = System.Windows.Visibility.Visible;
                    Console.WriteLine(e.Key);
                    break;
                case Key.Up:
                    break;
                case Key.Right:
                    break;
                case Key.Down:
                    break;
            }
        }
    }
}
