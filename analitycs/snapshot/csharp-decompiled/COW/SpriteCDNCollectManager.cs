using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class SpriteCDNCollectManager : SingletonModule<SpriteCDNCollectManager>
{
	private sealed class _003C_003Ec__DisplayClass31_0
	{
		public UnityEngine.Object obj;

		public SpriteCDNCollectManager _003C_003E4__this;

		public AtlasIconCDNResource res;

		public Action<bool> onTextureLoadCallBack;

		internal void _003CRegisterAndLoadAtlasBaseRes_003Eb__0(bool success)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass36_0
	{
		public SpriteCDNCollectManager _003C_003E4__this;

		public UILabel label;

		public Action<bool, string, bool> onTextureLoadCallBack;

		internal void _003CRegisterAndLoadAtlasLabel_003Eb__0(bool success)
		{
		}
	}

	private ObjectPool<AtlasIconCDNResource> m_AtlasCDNResourcePool;

	private Dictionary<int, AtlasIconCDNResource> m_AtlasGoInDict;

	private bool m_OpenCDNSprite;

	private bool m_HaveLoadedBannerOrHeadPicInfo;

	private Dictionary<string, string> m_IconModifyUrlDict;

	private CSVAsyncDataMap<uint, IconCDNMapData> m_Ob47IconCDNMapDataDict;

	private CSVAsyncDataMap<uint, PreLoadIconCDNData> m_Ob47PreloadCDNMapDataDict;

	private Shader m_AlphaSplit;

	private Shader m_NoAlpha;

	private Dictionary<ResourceID, string> m_IconCDNResToIconNameDict;

	public static string CDNIconAddr;

	private GameObject m_SpriteCDNParentObj;

	protected ObjectPool<AtlasIconCDNResource> AtlasCDNResourcePool => null;

	public Dictionary<string, string> IconModifyUrlDict => null;

	public Dictionary<ResourceID, string> IconResToNameDict => null;

	public Shader AlphaSplit => null;

	public Shader NoAlpha => null;

	public GameObject SpriteCDNParentObj => null;

	public Transform SpriteCDNParentObjTrans => null;

	public static string PlatformIdentifier => null;

	protected override void OnCleanup()
	{
	}

	public void ClearSpriteCDNOBJCache()
	{
	}

	protected override void OnInit()
	{
	}

	public void LoadIconCDNMapData()
	{
	}

	public string GetModifySpriteName(ResourceID spriteResource)
	{
		return null;
	}

	public void RegisterAndLoadAtlasBaseRes(UnityEngine.Object obj, ResourceID resourceID, Action<bool> onTextureLoadCallBack = null)
	{
	}

	public void RegisterAndLoadAtlasSpriteRes(UISprite sprite, ResourceID spriteResource, Action<bool> onTextureLoadCallBack = null)
	{
	}

	public void UnRegisterAtlasRegisterInfo(int spriteInsID)
	{
	}

	private void OnSpriteAtlasLoadSuccess(UISprite sprite, AtlasIconCDNResource atlasInfoRes)
	{
	}

	private void OnLabelAtlasLoadSuccess(UILabel label, AtlasIconCDNResource atlasInfoRes)
	{
	}

	public void RegisterAndLoadAtlasLabel(UILabel label, ResourceID iconResourceID, Action<bool, string, bool> onTextureLoadCallBack = null)
	{
	}

	private void LoadIconNotInCDNUse()
	{
	}

	public void RegisterIconResIconName(ResourceID resID, string iconName)
	{
	}

	public List<uint> GetAllPreloadCDNIconItemID()
	{
		return null;
	}

	public bool PreLoadIconCDN(List<uint> needPreloadItemID)
	{
		return false;
	}

	public bool PreLoadIconCDNInCSV()
	{
		return false;
	}

	public static string GetCDNDownloadTextureName(string spriteName)
	{
		return null;
	}

	public static string GetCDNDownloadTextureAlphaName(string spriteName)
	{
		return null;
	}

	public static string GetCDNDownloadTextureUrl(string spriteName)
	{
		return null;
	}

	public static string GetPngCDNDownloadTextureUrl(string spriteName)
	{
		return null;
	}

	public static string GetCDNDownloadTextureAlphaUrl(string spriteName)
	{
		return null;
	}
}
