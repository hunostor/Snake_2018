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
        internal void KeyDown(KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Left:
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
