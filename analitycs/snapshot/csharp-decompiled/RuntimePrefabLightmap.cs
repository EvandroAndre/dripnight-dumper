using System.Collections.Generic;
using UnityEngine;

public class RuntimePrefabLightmap : MonoBehaviour
{
	public string prefabID;

	public List<Renderer> renderers;

	public List<Texture2D> lightmaps;

	public List<LightmapInfo> lightmapInfo;

	private bool m_loadedLightmap;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public void LoadLightmap()
	{
	}

	public void Clear()
	{
	}
}
