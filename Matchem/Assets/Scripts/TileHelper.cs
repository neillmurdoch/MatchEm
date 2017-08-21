//using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts
{
    public static class TileHelper
    {
        

        public static List<string> Symbols { get; set; }
        public static List<Color> Colours { get; set; }

        public static void InitialiseTileHelper(int seed)
        {
            Random.InitState(seed);

            Symbols = new List<string>() { "Triangle", "Circle", "Square", "Star", "Hoop", "Trapezium" };
            Colours = new List<Color>() { Color.red, Color.green, Color.blue, Color.cyan, Color.magenta, Color.yellow };
        }

        public static void SetRandomSequence(int seed)
        {
            // Pass in the seed value to initialise the random sequence.
            Random.InitState(seed);
        }
                
        // Return a single random symbol from the symbols list.
        public static string GetSymbol(List<string> set = null)
        {
            string symbol;

            if (set == null)
            {
                symbol = Symbols[Random.Range(0, Symbols.Count)];
            }
            else
            {
                symbol = set[Random.Range(0, set.Count)];
            }

            return symbol;
        }

        // Return n random symbols from the symbols list.
        public static List<string> GetSymbolSet(int maxCount = -1)
        {
            List<string> set = new List<string>();

            if (maxCount <= 0 || maxCount > Symbols.Count)
            {
                set = Symbols;
            }
            else
            {
                //set = Symbols.OrderBy(a => System.Guid.NewGuid()).Take(maxCount).ToList();
                set = Symbols.Take(maxCount).ToList();
            }

            return set;
        }

        // Return a single random colour from the colours list.
        public static Color GetColour(List<Color> set = null)
        {
            Color colour;

            if (set == null)
            {
                colour = Colours[Random.Range(0, Colours.Count - 1)];
            }
            else
            {
                colour = set[Random.Range(0, set.Count - 1)];
            }

            return colour;
        }

        // Return n random colours from the colours list.
        public static List<Color> GetColourSet(int maxCount = -1)
        {
            List<Color> set = new List<Color>();

            if (maxCount <= 0 || maxCount > Colours.Count)
            {
                set = Colours;
            }
            else
            {
                //set = Colours.OrderBy(a => System.Guid.NewGuid()).Take(maxCount).ToList();
                set = Colours.Take(maxCount).ToList();
            }

            return set;
        }

        // Return a side with a randomly selected symbol and colour. Optionally pass in a sub set of the master lists.
        public static TileSide GetSide(List<string> symbols = null, List<Color> colours = null)
        {
            string symbol;
            Color colour;
            TileSide side;

            if (symbols == null)
            {
                symbol = Symbols[Random.Range(0, Symbols.Count)];
            }
            else
            {
                symbol = symbols[Random.Range(0, symbols.Count)];
            }

            if(colours == null)
            {
                colour = Colours[Random.Range(0, Colours.Count - 1)];
            }
            else
            {
                colour = colours[Random.Range(0, colours.Count - 1)];
            }

            side = new TileSide(symbol, colour);

            return side;
        }

    }
}
