using System;
using System.Collections.Generic;
using COW.GamePlay;
using UnityEngine;

namespace DecalAtlas;

[Serializable]
public class GranularityDatum
{
	public int Granularity;

	public float[] DistanceByQuality;

	public float GridSize;

	public bool Enabled;

	public bool[] CellExistances;

	[NonSerialized]
	public int[] CellsNeedUpdate;

	[NonSerialized]
	public List<Vector2Int> VisibleCells;

	[NonSerialized]
	public byte[][] CellVisibleCorners;

	[NonSerialized]
	public Vector2Int CellsXZ;

	[NonSerialized]
	public Vector2 CameraLeft;

	[NonSerialized]
	public Vector2 CameraRight;

	public GranularityDatum(int granularity, float size, float[] distanceByQuality)
	{
	}

	public static int DistanceIndexForQuality(MNMBLBKENMK quality)
	{
		return 0;
	}

	public void Load(Rect terrainRect)
	{
	}
}
