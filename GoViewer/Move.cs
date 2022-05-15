using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoViewer
{
    /// <summary>

    /// </summary>
    public struct Move
    {
        /// <summary>
        /// </summary>
        public int row;
        /// <summary>
        /// </summary>
        public int col;
        /// <summary>
        /// </summary>
        public bool black;
        
        /// <summary>
        /// </summary>
        /// <param name="i">Cột i</param>
        /// <param name="j">Cột J</param>
        /// <param name="black">đen và trắng</param>
        public Move(int i, int j, bool black)
        {
            this.row = i;
            this.col = j;
            this.black = black;
        }
    }
}
