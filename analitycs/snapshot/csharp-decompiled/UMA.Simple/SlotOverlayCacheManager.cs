using System;
using System.Collections.Generic;
using COW.GamePlay;
using TsiU;
using UnityEngine;

namespace UMA.Simple;

public class SlotOverlayCacheManager : TSingleton<SlotOverlayCacheManager>
{
	private const ulong AnonymousUserID = 0uL;

	public const bool UnloadSlotOverlays = true;

	public static bool UnloadSlotMeshAssets;

	public static bool UnloadOverlayTextures;

	public static bool ClearSlotMeshAssets;

	public const bool PreloadBotAssets = true;

	public static bool PreloadBotAssetsInRootCache;

	public const bool UnloadBotAssets = true;

	public static bool FixSlotOverlayCacheBotId;

	private bool m_IsWaitingCabin;

	private bool m_ScenePreloading;

	private bool m_PreloadingTeammateOnly;

	private bool m_PreloadingClothes;

	private bool _003CLoadNoCache_003Ek__BackingField;

	private bool _003CUnloadAssets_003Ek__BackingField;

	private bool _003CDisableRefs_003Ek__BackingField;

	private bool m_HasCaches;

	private SlotOverlayAssetCacheWithRefsDic m_RootCache;

	private SlotOverlayAssetCacheWithRefsDic m_WaitingCache;

	private Dictionary<ulong, SlotOverlayAssetCacheWithRefsChild> m_PlayerCaches;

	private Dictionary<uint, SlotOverlayAssetCacheWithRefsChild> m_BotCaches;

	private HashSet<SlotOverlayAssetCache> m_AnonymousCaches;

	private uint m_UnloadDelayCall;

	protected List<SlotDataAsset> m_UnloadingSlots;

	protected List<OverlayDataAsset> m_UnloadingOverlays;

	private static List<int> s_SharedRecipeList;

	public bool LoadNoCache
	{
		get
		{
			return _003CLoadNoCache_003Ek__BackingField;
		}
		private set
		{
			_003CLoadNoCache_003Ek__BackingField = value;
		}
	}

	public bool UnloadAssets
	{
		get
		{
			return _003CUnloadAssets_003Ek__BackingField;
		}
		private set
		{
			_003CUnloadAssets_003Ek__BackingField = value;
		}
	}

	public bool DisableRefs
	{
		get
		{
			return _003CDisableRefs_003Ek__BackingField;
		}
		private set
		{
			_003CDisableRefs_003Ek__BackingField = value;
		}
	}

	public void SetLobbyOptions()
	{
	}

	public void SetGameOptions(bool isWaitingCabin, bool needPreload3p, bool preloadTeammateOnly, bool needRelease)
	{
	}

	private void SetUnloadAssetsOnCacheDestroy(bool unload)
	{
	}

	private void SetNeedPreloadAssets(bool preload3p, bool teammateOnly)
	{
	}

	private void SetLoadNoCache(bool noCache)
	{
	}

	private void UpdateDisableRefCount()
	{
	}

	private void SyncChildDisableRefCount(SlotOverlayAssetCacheWithRefsChild child)
	{
	}

	private void EnsureRootCache()
	{
	}

	private void EnsureWaitingCache()
	{
	}

	public SlotOverlayAssetCacheWithRefs GetRootCache()
	{
		return null;
	}

	public SlotOverlayAssetCacheWithRefs GetPlayerCache(ulong uid, BHGGAEEHJCO pid, bool showClothesInBattle, bool isTeammate)
	{
		return null;
	}

	public SlotOverlayAssetCache CreateAnonymousCache(bool noCache = false)
	{
		return null;
	}

	public void PreloadClothes(ulong userID, BHGGAEEHJCO pid, bool useHighQualityAvatar, uint avatarId, List<uint> clothList, bool async)
	{
	}

	public void PreloadBaseClothes()
	{
	}

	public void PreloadBaseClothes(string raceName)
	{
	}

	public bool PreloadClothes(int hash)
	{
		return false;
	}

	public void ClearCaches(bool removeChildren = true)
	{
	}

	public void ReleaseCache(SlotOverlayAssetCache cache)
	{
	}

	private bool RemoveCache(SlotOverlayAssetCacheWithRefsChild cache)
	{
		return false;
	}

	private void UpdateHasCaches()
	{
	}

	private void UnloadCache(SlotOverlayAssetCacheWithRefsChild cache)
	{
	}

	private void ClearUnloadingLists()
	{
	}

	private bool HasUnloadingAssets()
	{
		return false;
	}

	private void StartOrStopUnloading()
	{
	}

	private void StartOrStopUnloading(bool start, bool clearOnStop = true)
	{
	}

	private void TryUpdateUnloading()
	{
	}

	private bool DoUpdateUnloading()
	{
		return false;
	}

	private bool CheckAndUnload<T>(bool isSlot, List<T> list, Action<T> unloadFunc) where T : UnityEngine.Object
	{
		return false;
	}

	private void UnloadSlot(SlotDataAsset slot)
	{
	}

	private void UnloadOverlay(OverlayDataAsset overlay)
	{
	}

	private void UnloadAsset(UnityEngine.Object asset)
	{
	}
}
