using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts
{
    interface IBoardLayout
    {
        void GenerateBoardLayout(TileShape tileShape, int size);
    }
}
