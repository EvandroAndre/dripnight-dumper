using System;
using System.Collections.Generic;
using UnityEngine;

namespace COW.Graphics;

public class MipmapStreamingObj : MonoBehaviour
{
	[Serializable]
	public class TextureInfo
	{
		public string m_Name;

		public List<string> m_ResPaths;

		[NonSerialized]
		public bool m_Loading;

		[NonSerialized]
		public int m_CurMipmapLvl;

		[NonSerialized]
		public Texture2D m_Texture;

		[NonSerialized]
		public string m_TexturePath;

		public int GetInnerLvl(int lvl)
		{
			return 0;
		}

		public bool HasPath(string path)
		{
			return false;
		}
	}

	public List<TextureInfo> m_TextureInfos;

	public Vector2 m_TextureScale;

	public Vector2 m_TextureOffset;

	private MeshRenderer m_MeshRenderer;

	private Material m_OriMaterial;

	private Material m_OriMaterialInst;

	private Material m_PreviewBlendMaterialInst;

	private MeshRenderer curMeshRenderer => null;

	public Material curMaterial
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	public void GenOriMatInst()
	{
	}

	public void GenPreviewBlendMatInst(Material matPreviewBlend)
	{
	}

	public void SetOriMatInst()
	{
	}

	public void SetMaterial(Material mat)
	{
	}

	public void SetPreviewBlendMatInst()
	{
	}

	public void DestroyMatInsts()
	{
	}

	public void DestroyOriTextures()
	{
	}

	public void SetCurMipmapLvl(int mipmapLvl)
	{
	}

	private void onTextureLoad(string path, Texture2D tex)
	{
	}

	public void Refresh(TextureInfo ti)
	{
	}

	private void OnDestroy()
	{
	}
}
