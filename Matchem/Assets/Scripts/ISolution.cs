using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    interface ISolution
    {
        /// <summary>
        /// The seed value used to generate the solution. Allows for repeatable/shareable solutions.
        /// </summary>
        int Seed { get; set; }
        
        /// <summary>
        /// The completed solution of tiles.
        /// </summary>
        List<ITile> Tiles { get; set; }

        /// <summary>
        /// The symbol set used by the solution.
        /// </summary>
        List<string> Symbols { get; set; }

        /// <summary>
        /// The colour set used by the solution.
        /// </summary>
        List<Color> Colours { get; set; }
        
        /// <summary>
        /// The dimension of the solution.
        /// </summary>
        int Size { get; }

        /// <summary>
        /// The number of sides on the tile shape.
        /// </summary>
        int TileDifficulity { get; }

        /// <summary>
        /// How many different symbols are used in the solution.
        /// </summary>
        int SymbolDifficulty { get; }

        /// <summary>
        /// How many different colours are used in the solution.
        /// </summary>
        int ColourDifficulty { get; }

        void GenerateSolution(int seed, int size, int symbolDifficulty, int colourDifficulty);
        ITile GetTileAt(int x, int y);
    }
}
