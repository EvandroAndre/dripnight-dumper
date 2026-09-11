using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class LightmapAreaInfoNoRef
{
	public int[] areaID;

	public List<string> rendererID;

	public List<Texture2D> lightmaps;

	public List<Texture2D> shadowmasks;

	public List<LightmapInfo> lightmapInfo;

	public void Clear()
	{
	}
}
