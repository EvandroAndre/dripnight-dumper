using System.Collections.Generic;
using TsiU;
using UnityEngine;

namespace COW.Graphics;

public class MipmapStreamingTextureCenter : TSingleton<MipmapStreamingTextureCenter>
{
	public delegate void OnTextureLoaded(string path, Texture2D tex);

	private class ResourceRequestWrapper
	{
		public ResourceRequest m_ResourceRequest;

		public string m_TexPath;

		public int m_SceneIt;

		public OnTextureLoaded m_OnTexLoaded;
	}

	private const int MAX_ACTIVE_COUNT = 1;

	private int m_CurSceneIt;

	private Dictionary<string, Texture2D> m_Path2Texture2D;

	private List<ResourceRequestWrapper> m_ActiveRequests;

	private LinkedList<ResourceRequestWrapper> m_PendingRequest;

	private float m_MaxMegaByte;

	private float m_MinMegaByte;

	public void LoadTextureAsync(string resPath, OnTextureLoaded onTexLoaded)
	{
	}

	public void UnloadTexture(string texPath, Texture2D tex, bool remove = true)
	{
	}

	public void Process()
	{
	}

	public void OnSceneDestroy()
	{
	}

	public void RegisterTexture(string texPath, Texture2D tex)
	{
	}

	private int RefreshMemory()
	{
		return 0;
	}

	private void InnerUnloadTexAsset(Texture2D tex)
	{
	}

	private ResourceRequest InnerLoadTexAsset(string path)
	{
		return null;
	}
}
