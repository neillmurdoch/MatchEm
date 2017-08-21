using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts
{
    //class TriangleSolution : ISolution
    //{
    //    public List<ITile> Tiles { get; set; }

    //    public int Seed
    //    {
    //        get
    //        {
    //            throw new NotImplementedException();
    //        }

    //        set
    //        {
    //            throw new NotImplementedException();
    //        }
    //    }

    //    public List<string> Symbols { get; set; }
    //    public List<int> Colours { get; set; }

    //    public int Size => throw new NotImplementedException();

    //    public int symbolDifficulty => throw new NotImplementedException();

    //    public int colourDifficulty => throw new NotImplementedException();

    //    List<ITile> ISolution.Tiles { get; set; }

    //    List<Color> ISolution.Colours
    //    {
    //        get
    //        {
    //            throw new NotImplementedException();
    //        }

    //        set
    //        {
    //            throw new NotImplementedException();
    //        }
    //    }

    //    public void GenerateSolution(int seed, int size)
    //    {
    //        // For a triangle board, we start at the top and work across in rows. The number of rows will be the boardDimension and each row will
    //        // increase the number of tiles by 2.

    //        for (int row = 0; row < size; row++)
    //        {
    //            // Each succeeding row will have two more tiles than the previous one.
    //            int cols = (row * 2) + 1;

    //            for (int col = 0; col < cols; col++)
    //            {



    //            }

    //        }


    //        throw new NotImplementedException();
    //    }

    //    public void GenerateSolution(int seed, int size, int symbolDifficulty, int colourDifficulty)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public ITile GetTileAt(int x, int y)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    ITile ISolution.GetTileAt(int x, int y)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}
