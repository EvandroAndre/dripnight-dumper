using System.Collections.Generic;
using UnityEngine;

public class SceneLightmapFile : ScriptableObject
{
	public int versionID;

	public bool version2018;

	public List<LightmapAreaInfoNoRef> areaLightmaps;

	public static bool SameID(int[] lhs, int[] rhs, int offset = 0)
	{
		return false;
	}

	public LightmapAreaInfoNoRef GetAreaLightmap(int[] areaID, bool createIfNotExists = true)
	{
		return null;
	}
}
