using System.Collections.Generic;
using UnityEngine;

namespace DecalAtlas;

public static class DecalUtility
{
	public static int maxDecalsInCell;

	private static int _arraySize;

	private static byte[,] _array2D;

	private static byte _fillInNum;

	public static readonly Dictionary<int, GranularityDatum> DefaultGranularityData;

	public static readonly Dictionary<int, string> GranumlaritySuffix;

	private static void SetSize(int size)
	{
	}

	public static void Init(int size)
	{
	}

	private static void CalculateLineCells(Vector2 p0, Vector2 p1, int step)
	{
	}

	public static byte[,] CalculateCellVisiblity(List<Vector2> points, Vector2Int Offset, int gridSize, int xSize, int zSize)
	{
		return null;
	}

	private static void FillInside(int xSize, int zSize)
	{
	}
}
