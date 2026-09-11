using System;
using System.Collections.Generic;
using COW.GamePlay;
using UnityEngine;

public class MaterialLOD : MonoBehaviour
{
	[Serializable]
	public class TextureLODInfo
	{
		public List<Material> m_matList;
	}

	[Serializable]
	public class MaterialLODInfo
	{
		public Renderer m_renderer;

		public List<int> m_matIDList;

		public List<string> m_matNameList;
	}

	public List<MaterialLODInfo> m_materialLODInfoList;

	public List<TextureLODInfo> m_textureLODInfoList;

	private MNMBLBKENMK m_quality;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}
}
