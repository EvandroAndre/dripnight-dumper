using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class LightmapAreaInfo
{
	public int[] areaID;

	public List<Renderer> renderers;

	public List<Texture2D> lightmaps;

	public List<Texture2D> shadowmasks;

	public List<LightmapInfo> lightmapInfo;

	public void Clear()
	{
	}
}
