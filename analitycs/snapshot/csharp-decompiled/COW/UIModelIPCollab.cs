using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIModelIPCollab : UIBaseModel
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<CollabItemDesc, uint> _003C_003E9__44_0;

		public static Func<CollabItemDesc, uint> _003C_003E9__45_0;

		public static Func<CollabItemDesc, uint> _003C_003E9__46_0;

		public static Func<CollabItemDesc, uint> _003C_003E9__47_0;

		public static Comparison<IPCollabTabData> _003C_003E9__82_0;

		public static Comparison<CollabDesc> _003C_003E9__82_1;

		public static Comparison<CollabItemDesc> _003C_003E9__82_2;

		public static Comparison<CollabItemDesc> _003C_003E9__82_3;

		internal uint _003CGetIPCollabAvatarDataByIPCollabID_003Eb__44_0(CollabItemDesc item)
		{
			return 0u;
		}

		internal uint _003CGetIPCollabWeaponDataByIPCollabID_003Eb__45_0(CollabItemDesc item)
		{
			return 0u;
		}

		internal uint _003CGetIPCollabAnimationDataByIPCollabID_003Eb__46_0(CollabItemDesc item)
		{
			return 0u;
		}

		internal uint _003CGetIPCollabOtherDataByIPCollabID_003Eb__47_0(CollabItemDesc item)
		{
			return 0u;
		}

		internal int _003CSortIPCollabData_003Eb__82_0(IPCollabTabData a, IPCollabTabData b)
		{
			return 0;
		}

		internal int _003CSortIPCollabData_003Eb__82_1(CollabDesc a, CollabDesc b)
		{
			return 0;
		}

		internal int _003CSortIPCollabData_003Eb__82_2(CollabItemDesc a, CollabItemDesc b)
		{
			return 0;
		}

		internal int _003CSortIPCollabData_003Eb__82_3(CollabItemDesc a, CollabItemDesc b)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass91_0
	{
		public UIModelIPCollab _003C_003E4__this;

		public List<uint> itemIds;

		internal void _003CRequestIPCollabWishlist_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass92_0
	{
		public UIModelIPCollab _003C_003E4__this;

		public uint ipCollabID;

		internal void _003CRequestAddNonWishListItemsWish_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private bool m_InitedIPCollabDesc;

	private bool m_InitedIPCollabItemChannel;

	private bool m_InitedIPCollabLikeState;

	private bool m_IsSortDirty;

	private Dictionary<uint, CollabDesc> m_IPCollabDescDict;

	private Dictionary<uint, IPLikeState> m_IPLikeStateDict;

	private Dictionary<uint, List<CollabItemDesc>> m_IPCollabAvatarItemDescDict;

	private Dictionary<uint, List<CollabItemDesc>> m_IPCollabWeaponItemDescDict;

	private Dictionary<uint, List<CollabItemDesc>> m_IPCollabAnimationItemDescDict;

	private Dictionary<uint, List<CollabItemDesc>> m_IPCollabOtherItemDescDict;

	private Dictionary<uint, CollabItemDesc> m_IPCollabAllItemDescDict;

	private Dictionary<uint, CollabItemDesc> m_IPCollabBundleItemDescDict;

	private Dictionary<uint, List<CollabItemDesc>> m_ExtraBundleDict;

	private Dictionary<string, int> m_BundleChangeSetCache;

	private Dictionary<uint, bool> m_PosterChangeTipsSeenCache;

	private Dictionary<uint, bool> m_DetailChangeSetTipsSeenCache;

	private List<IPCollabTabData> m_IPCollabTabDataList;

	private Dictionary<uint, IPCollabTabData> m_IPCollabTabDataDict;

	private Dictionary<uint, IPCollabNewItemRedPotDesc> m_IPCollabNewItemRedPotDescDict;

	private HashSet<uint> m_IPCollabNewIPHashSet;

	public Dictionary<uint, List<Vector3>> m_IPCollabAvatarSweepPosDict;

	public static Dictionary<uint, List<Vector3>> m_IPCollabAvatarClickZoneDict;

	public static Dictionary<uint, Vector3> m_IPCollabFullScreenCameraPosDict;

	public const uint AvatarTipsHight = 0u;

	private UIModelInventory m_ModelInventory;

	private UIModelUser m_ModelUser;

	private UIModelStoreBox m_ModelStoreBox;

	public const uint PropID_IPCollabDescUpdate = 2u;

	public const uint PropID_IPCollabWishlistUpdate = 4u;

	public const uint PropID_IPCollabNewItemsUpdate = 8u;

	public const uint PropID_IPCollabRedPointUpdate = 16u;

	public const string IPCollabNewIPKey = "IPCollabNewIP_";

	public const string IPCollabChangeSetKey = "IPCollabChangeSet_IPID{0}_Index{1}_AccountID{2}";

	private const string POSTER_CHANGE_TIPS_KEY = "IPCollab_PosterChangeTips_{0}";

	private const string DETAIL_CHANGESET_TIPS_KEY = "IPCollab_DetailChangeSetTips_{0}";

	private bool m_HasRequestDesc;

	public bool IsSortDirty
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Init()
	{
	}

	protected override void OnCleanup()
	{
	}

	public override void Logout(object[] data)
	{
	}

	public List<IPCollabTabData> GetIPLeftTabSetting()
	{
		return null;
	}

	public void GetTabIndexAndSubIndexByIPID(int IPCollabID, ref int tabIndex, ref int subTabIndex)
	{
	}

	public List<uint> GetIPCollabDataByIPCollabIDAndType(uint IPCollabID, EIPCollabItemType itemType)
	{
		return null;
	}

	public List<CollabItemDesc> GetIPCollabAvatarDescList(uint IPCollabID)
	{
		return null;
	}

	public List<uint> GetIPCollabAvatarDataByIPCollabID(uint IPCollabID)
	{
		return null;
	}

	public List<uint> GetIPCollabWeaponDataByIPCollabID(uint IPCollabID)
	{
		return null;
	}

	public List<uint> GetIPCollabAnimationDataByIPCollabID(uint IPCollabID)
	{
		return null;
	}

	public List<uint> GetIPCollabOtherDataByIPCollabID(uint IPCollabID)
	{
		return null;
	}

	public List<string> GetIPCollabPoseByIPCollabID(int IPCollabID)
	{
		return null;
	}

	public CollabDesc GetIPCollabDescByIPCollabID(uint IPCollabID)
	{
		return null;
	}

	public string GetIPCustomBGByIPCollabID(uint IPCollabID)
	{
		return null;
	}

	public string GetIPCollabPosterByIPCollabID(uint IPCollabID)
	{
		return null;
	}

	public IPLikeState GetIPCollabLikeStateByIPCollabID(uint IPCollabID)
	{
		return null;
	}

	public List<Vector3> GetIPCollabAvatarSweepPosByIPCollabID(uint number)
	{
		return null;
	}

	public Vector3? GetIPCollabAvatarSweepPosByItemID(uint itemId)
	{
		return null;
	}

	public uint GetIPCollabAvatarSweepTypeByIPCollabID(uint itemId)
	{
		return 0u;
	}

	public List<Vector3> GetIPCollabAvatarClickZoneByIPCollabID(int number)
	{
		return null;
	}

	public Vector3 GetIPCollabFullScreenCameraPosByNumber(uint number)
	{
		return default(Vector3);
	}

	public bool CheckIsIpCollabItem(uint itemId)
	{
		return false;
	}

	public void OnInventoryNewItemsNtf(InventoryChangeMessage message)
	{
	}

	public IPCollabNewItemRedPotDesc GetIPCollabNewItemRedPotDesc(uint detailed_type)
	{
		return null;
	}

	public CollabItemDesc GetIPCollabItemDescByItemID(uint itemID)
	{
		return null;
	}

	public CollabItemDesc GetIPCollabAllItemDescByItemID(uint itemID)
	{
		return null;
	}

	public bool CheckIsIPCollabNewIP(uint IPCollabID)
	{
		return false;
	}

	public bool CheckIPItemIsAllOwnByItemType(uint IPCollabID, EIPCollabItemType type)
	{
		return false;
	}

	public void ClearIPCollabNewItemRedPotDesc(uint IPCollabID, EIPCollabItemType itemType)
	{
	}

	private void CheckCanRemoveNewItem(uint IPCollabID)
	{
	}

	public void ClearIPCollabNewIP(uint IPCollabID)
	{
	}

	public List<CollabItemDesc> GetExtraBundles(uint baseItemId)
	{
		return null;
	}

	public bool HasExtraBundles(uint baseItemId)
	{
		return false;
	}

	public CollabItemDesc GetCurrentDisplayBundle(uint ipCollabID, int avatarIndex, CollabItemDesc defaultDesc)
	{
		return null;
	}

	public CollabItemDesc CycleBundleSet(uint ipCollabID, int avatarIndex, CollabItemDesc defaultDesc)
	{
		return null;
	}

	private string GetBundleSetPrefsKey(uint ipCollabID, int avatarIndex)
	{
		return null;
	}

	public void LoadBundleChangeSetFromPrefs(uint ipCollabID)
	{
	}

	public void SaveAllBundleChangeSetToPrefs()
	{
	}

	public bool CheckNeedShowPosterChangeTips(uint ipCollabID)
	{
		return false;
	}

	public void MarkPosterChangeTipsSeen(uint ipCollabID)
	{
	}

	public bool CheckNeedShowDetailChangeSetTips(uint ipCollabID)
	{
		return false;
	}

	public void MarkDetailChangeSetTipsSeen(uint ipCollabID)
	{
	}

	public List<uint> GetIPCollabAvatarDataWithExtrasByIPCollabID(uint IPCollabID)
	{
		return null;
	}

	private void SortIPCollabData()
	{
	}

	public void SortIpCollabByNewItem()
	{
	}

	private void SortIPCollabItem(EIPCollabItemType itemType)
	{
	}

	private int SortIPCollabItemByOwnState(CollabItemDesc a, CollabItemDesc b)
	{
		return 0;
	}

	private void RefreshIPCollabRedPoint()
	{
	}

	private void RefreshIPCollabBundleItemDesc()
	{
	}

	private void SetIPCollabBundleItem(CollabItemDesc item)
	{
	}

	public void RequestIPCollabSetting(bool silence, LoadingType loadingType = LoadingType.CircleLoading, bool isLogin = false, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public void RequestIPCollabWishlist()
	{
	}

	public void RequestAddNonWishListItemsWish(uint ipCollabID, uint itemIds)
	{
	}

	public void RequestIPCollabItemChannel()
	{
	}

	private void _003CRequestIPCollabSetting_003Eb__90_0(HttpErrorCode errorCode, object res)
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	public void _003C_003EiFixBaseProxy_OnCleanup()
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
