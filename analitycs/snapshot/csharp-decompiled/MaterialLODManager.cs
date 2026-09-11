using System;
using System.Collections.Generic;
using UnityEngine;

public class MaterialLODManager : MonoSingleton<MaterialLODManager>
{
	[Serializable]
	public class TextureLODInfoManager
	{
		public string m_matName;

		public List<string> m_texNameList;

		public List<string> m_texPathList;
	}

	public class MaterialLODInfoManager
	{
		public Material m_material;

		public int m_refCount;
	}

	public List<TextureLODInfoManager> m_TextureLODList;

	private Dictionary<string, TextureLODInfoManager> m_textureLODDict;

	private Dictionary<string, int> m_loadedMatDict;

	private Dictionary<string, MaterialLODInfoManager> m_materialLOD;

	private string m_materialLODResPath;

	private void Start()
	{
	}

	public void ApplyMaterial(Renderer render, List<int> matIDList, List<string> matNameList)
	{
	}

	private Material CreateMaterial(string matName)
	{
		return null;
	}

	public void ApplyTexture(List<Material> matList)
	{
	}

	public void UnloadMaterial(string matName)
	{
	}

	public void UnloadTexture(List<Material> matList)
	{
	}
}
