using System;
using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptTests : MonoBehaviour {

	public int seed = 1;
	public int BoardSize = 4;
	public int SymbolDifficulty = 6;
	public int ColourDifficulty = 6;

	// Use this for initialization
	void Start () {

		TileHelper.InitialiseTileHelper(1); // DateTime.Now.Millisecond);

		//GetSingleSymbols(1000);
		//GetSingleColours(10000);

		//GetSymbolSet(4);
		//GetColourSet(3);

		GenerateSolution(seed, BoardSize, SymbolDifficulty, ColourDifficulty);

	}

	private void GenerateSolution(int seed, int size, int symbolDifficulty, int colourDifficulty)
	{
		ISolution solution = new SquareSolution();

		solution.GenerateSolution(seed, size, symbolDifficulty, colourDifficulty);

		solution.Symbols.ForEach(Debug.Log);

		Debug.LogFormat("Tile difficulty: {0}, Symbol difficulty {1}, Colour difficulty {2}", solution.TileDifficulity, solution.SymbolDifficulty, solution.ColourDifficulty);

		foreach (SquareTile tile in solution.Tiles)
		{
			foreach (TileSide side in tile.Sides)
			{
				//Debug.LogFormat("Tile {0}, {1}: {2} {3}", tile.x, tile.y, side.Colour, side.Symbol);
			}
		}

		// Generate a second solution and compare. We are using the same seed, so they should be identical.

		ISolution solution2 = new SquareSolution();

		solution2.GenerateSolution(seed, size, symbolDifficulty, colourDifficulty);

		solution.Symbols.ForEach(Debug.Log);

		Debug.LogFormat("Tile difficulty: {0}, Symbol difficulty {1}, Colour difficulty {2}", solution2.TileDifficulity, solution2.SymbolDifficulty, solution2.ColourDifficulty);


	}


	private void GetSingleSymbols(int count)
	{
		string symbol;

		for (int i = 0; i < count; i++)
		{
			symbol = TileHelper.GetSymbol();
			Debug.Log("Symbol: " + symbol);
		}
	}

	private void GetSymbolSet(int count)
	{
		List<string> symbolSet = TileHelper.GetSymbolSet(count);
		symbolSet.ForEach(Debug.Log);
	}

	private void GetSingleColours(int count)
	{
		Color colour;

		for (int i = 0; i < count; i++)
		{
			colour = TileHelper.GetColour();
			Debug.Log("Colour: " + colour.ToString());
		}
	}

	private void GetColourSet(int count)
	{
		List<Color> colourSet = TileHelper.GetColourSet(count);
		foreach (Color color in colourSet)
		{
			Debug.Log(color);
		}
		//colourSet.ForEach(Debug.Log);
	}

}
