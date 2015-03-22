using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HanYuMatch
{
     public  class Square
    {
         private static int width = 800;
         private static int height = 400;
         public static void PaintSquare(Panel panel,Graphics gra)
         {
             gra.DrawLine(new Pen(Color.Black, 1), new Point(12, 20), new Point(30, 30));
         }
    }
}
