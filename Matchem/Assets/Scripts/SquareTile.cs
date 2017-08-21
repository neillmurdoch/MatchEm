using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts
{
    class SquareTile : ITile
    {
        public enum SideEnum
        {
            Top = 0,
            Right = 1,
            Bottom = 2,
            Left = 3
        }

        public List<TileSide> Sides { get; set; }

        public int x { get; set; }
        public int y { get; set; }

        public SquareTile()
        {
            Sides = new List<TileSide>();

        }

        public static int GetSidesIndex(SideEnum side)
        {
            return (int)side;
        }

    }
}
