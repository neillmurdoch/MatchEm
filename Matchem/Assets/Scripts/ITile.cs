using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts
{
    public enum TileShape
    {
        Triangle,
        Square,
        //Pentagon,
        Hexagon
    };

    public class TileSide
    {
        private string _symbol;
        public string Symbol
        {
            get
            {
                return _symbol;
            }
        }
        private Color _colour;
        public Color Colour
        {
            get
            {
                return _colour;
            }
        }

        public TileSide(string symbol, Color colour)
        {
            _symbol = symbol;
            _colour = colour;
        }
    }

    interface ITile
    {
        // A list of sides that make up the object:
        //  Triangle    - right     > bottom        > left
        //  Square      - top       > right         > bottom        > left
        //  Pentagon    - top right > bottom right  > bottom        > bottom left   > top left
        //  Hexagon     - top       > top right     > bottom right  > bottom        > bottom left   > top left
        
        List<TileSide> Sides { get; set; }
        int x { get; set; }
        int y { get; set; }
    }
}
