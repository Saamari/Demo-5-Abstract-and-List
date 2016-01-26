using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_5_Training
{
    abstract class DrawingObject
    {
        public string Name { get; set; }
        /// <summary>
        
        /// </summary>
        public abstract void Draw();
    }
}
