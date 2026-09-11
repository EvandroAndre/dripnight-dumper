using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIModelMysteryMall : UIBaseModel
{
	public enum ELuckyDrawFrom
	{
		DEFAULT,
		ENTRANCE,
		BUYBUTTON,
		ADVERTISE,
		PAYMENTDIAMONDEVENT
	}

	public class DiscountShow
	{
		public Color topColor;

		public Color bottomColor;

		public Color tabColor;

		public Color vfxColor;

		public DiscountShow(uint topColor, uint bottomColor, uint tabColor, uint vfxColor)
		{
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<MysteryShopExpressionDesc> _003C_003E9__58_0;

		internal int _003CGetCurMallDescList_003Eb__58_0(MysteryShopExpressionDesc desc1, MysteryShopExpressionDesc desc2)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass59_0
	{
		public uint shopId;

		internal bool _003CGetMysteryMallDescById_003Eb__0(MysteryShopExpressionDesc value)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass64_0
	{
		public uint shopId;

		internal bool _003CSetMysteryMallDescById_003Eb__0(MysteryShopExpressionDesc value)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass83_0
	{
		public UIModelMysteryMall _003C_003E4__this;

		public bool isLobbyEnter;

		internal void _003CRequestGetAllMysteryMallInfo_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass84_0
	{
		public UIModelMysteryMall _003C_003E4__this;

		public uint shopId;

		internal void _003CRequestGetMysteryMallInfo_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass86_0
	{
		public UIModelMysteryMall _003C_003E4__this;

		public MysteryPoolStoreItem storeDesc;

		public uint cnt;

		internal void _003CRequestPurchaseMysteryItem_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass87_0
	{
		public UIModelMysteryMall _003C_003E4__this;

		public uint shopId;

		internal void _003CRequestMysteryMallLuckyDraw_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass88_0
	{
		public UIModelMysteryMall _003C_003E4__this;

		public uint poolNeedRequestCount;
	}

	private sealed class _003C_003Ec__DisplayClass88_1
	{
		public uint shopID;

		public _003C_003Ec__DisplayClass88_0 CS_0024_003C_003E8__locals1;
	}

	private sealed class _003C_003Ec__DisplayClass88_2
	{
		public uint poolID;

		public _003C_003Ec__DisplayClass88_1 CS_0024_003C_003E8__locals2;

		internal void _003CRequestGetAllMysteryPoolInfo_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass89_0
	{
		public UIModelMysteryMall _003C_003E4__this;

		public uint poolId;

		public uint shopID;

		internal void _003CRequestGetMysteryPool_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	public const int PropID_RefreshMysteryPoolSwitch = 2;

	public const int PropID_GetMysteryLuckyDraw = 4;

	public const int PropID_GetMysteryPoolInfo = 8;

	public const int PropID_RefreshMysteryMall = 16;

	public const int PropID_RefreshMysteryMallInfo = 32;

	public const int PropID_GetMysteryShopProbability = 64;

	private Dictionary<uint, uint> m_LastPoolIdDict;

	private ELuckyDrawFrom m_LuckyDrawFrom;

	private const int MAX_MALL_COUNT = 3;

	private List<MysteryShopExpressionDesc> m_MysteryMallDescList;

	private bool m_MysteryMallDescListSorted;

	private Dictionary<uint, CSGetMysteryShopInfoRes> m_MysteryMallInfoDict;

	private MysteryShopExpressionDesc m_MysteryMallDesc;

	private CSGetMysteryShopInfoRes m_MysteryMallInfo;

	private bool m_HasGetAllInfo;

	private bool m_IsRequestingMysteryShopProbability;

	private Dictionary<uint, bool> m_IsRequestingMysteryMallLuckyDrawDict;

	private bool m_IsReuqestingMysteryShopInfoList;

	private Dictionary<uint, CSGetMysteryPoolInfoRes> m_MysteryPoolInfoDict;

	private Dictionary<uint, ClientMysteryShopSwitchDesc> m_MysetryPoolDescDict;

	private const string m_NewTipsKey = "MysteryMallLobbyNewTips";

	private const uint EP_ITEM_ID = 803000000u;

	private Dictionary<uint, DiscountShow> m_DiscoutShowDict;

	private Dictionary<uint, uint> m_ItemIDToMysteryMallIdDict;

	private Dictionary<uint, MysteryPoolStoreItem> m_ItemIDToStoreDescDict;

	private bool m_IsLobbyEntranceShowed;

	private bool m_IsLobbySpecialEntranceShowed;

	private bool m_IsReuqestingAllMysteryMallItemStatus;

	private bool m_IsRequestingAllMysteryPoolInfo;

	private uint m_GotResPoolCount;

	public ELuckyDrawFrom LuckyDrawFrom
	{
		get
		{
			return ELuckyDrawFrom.DEFAULT;
		}
		set
		{
		}
	}

	public bool HasGetAllInfo
	{
		get
		{
			return false;
		}
		private set
		{
		}
	}

	public bool IsLobbyEntranceShowed
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsLobbySpecialEntranceShowed
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsEntranceShowed => false;

	public override uint GetModelType()
	{
		return 0u;
	}

	public uint GetLastSelectPoolIdByShopId(uint shopId)
	{
		return 0u;
	}

	public void SetLastSelectPoolIdByShopId(uint shopId, uint poolId)
	{
	}

	public override void Init()
	{
	}

	public DiscountShow GetDiscountShow()
	{
		return null;
	}

	public uint GetMyLuckyNum()
	{
		return 0u;
	}

	public uint GetMyLuckyNum(uint shopID)
	{
		return 0u;
	}

	public uint GetMyMaxLuckyNum()
	{
		return 0u;
	}

	public MysteryShopExpressionDesc GetMysteryMallDesc()
	{
		return null;
	}

	public void SetMysteryMallDesc(MysteryShopExpressionDesc desc)
	{
	}

	private bool IsThisMallBetweenStartEndTime(MysteryShopExpressionDesc desc)
	{
		return false;
	}

	public bool HasMysteryMall()
	{
		return false;
	}

	public List<MysteryShopExpressionDesc> GetCurMallDescList(bool sortData = false)
	{
		return null;
	}

	public MysteryShopExpressionDesc GetMysteryMallDescById(uint shopId)
	{
		return null;
	}

	public bool HasCurrentMysteryMall()
	{
		return false;
	}

	public CSGetMysteryShopInfoRes GetMysteryMallInfo()
	{
		return null;
	}

	public CSGetMysteryShopInfoRes GetMysteryShopInfoResById(uint shopId)
	{
		return null;
	}

	public bool IsSupperRewardAndSwitchPool(uint itemId)
	{
		return false;
	}

	public void SetMysteryMallDescById(uint shopId)
	{
	}

	public void SaveCurrentPhaseShopIdList()
	{
	}

	public void GetOpenTimestamp(out long startTime, out long endTime)
	{
		startTime = default(long);
		endTime = default(long);
	}

	public ulong GetTheLatestStartTimestamp()
	{
		return 0uL;
	}

	public MysteryShopExpressionDesc GetMallDescByPriority()
	{
		return null;
	}

	public void SetMysteryMallDescList(CSGetMysteryExpressionRes res)
	{
	}

	public CSGetMysteryPoolInfoRes GetMysteryPoolInfoById(uint poolId)
	{
		return null;
	}

	public ClientMysteryShopSwitchDesc GetMysteryPoolDescById(uint poolId)
	{
		return null;
	}

	public uint GetAnotherPoolId(uint curPoolId)
	{
		return 0u;
	}

	public override void Login(object[] data)
	{
	}

	public override void Logout(object[] data)
	{
	}

	public void SortPoolItemNormalListById(uint poolId)
	{
	}

	public bool CheckIsShowOwnTitle(uint itemId)
	{
		return false;
	}

	public bool CheckIsItemInMysteryMall(uint itemId)
	{
		return false;
	}

	public bool CheckIsItemTimeEqual(uint itemId, uint deltaTime)
	{
		return false;
	}

	public bool CheckIsItemPurchasable(uint itemId)
	{
		return false;
	}

	public int GetItemDiscountPrice(uint itemId)
	{
		return 0;
	}

	public uint GetItemMysteryMallId(uint itemId)
	{
		return 0u;
	}

	public void RequestAllMysteryMallItemStatus(HttpManager.Priority priority = HttpManager.Priority.Normal)
	{
	}

	public void RequestGetAllMysteryMallInfo(bool isLobbyEnter = false, LoadingType loadingType = LoadingType.CircleLoading, HttpManager.Priority priority = HttpManager.Priority.Normal)
	{
	}

	public void RequestGetMysteryMallInfo(uint shopId, bool silence = false, HttpManager.Priority priority = HttpManager.Priority.Normal)
	{
	}

	public void RequestPurchaseAnotherPool(HttpManager.Priority priority = HttpManager.Priority.Normal)
	{
	}

	public void RequestPurchaseMysteryItem(MysteryPoolStoreItem storeDesc, uint cnt)
	{
	}

	public void RequestMysteryMallLuckyDraw(HttpManager.Priority priority = HttpManager.Priority.Normal)
	{
	}

	private void RequestGetAllMysteryPoolInfo(HttpManager.Priority priority = HttpManager.Priority.Normal)
	{
	}

	public void RequestGetMysteryPool(uint poolId, HttpManager.Priority priority = HttpManager.Priority.Normal)
	{
	}

	private void OnGetMysteryPoolInfo(CSGetMysteryPoolInfoRes poolInfo, uint poolID, uint shopID)
	{
	}

	public void RequestGetMysteryShopProbability(HttpManager.Priority priority = HttpManager.Priority.Normal)
	{
	}

	private int _003CSortPoolItemNormalListById_003Eb__75_0(MysteryPoolStoreItem x, MysteryPoolStoreItem y)
	{
		return 0;
	}

	private void _003CRequestPurchaseAnotherPool_003Eb__85_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestGetMysteryShopProbability_003Eb__91_0(HttpErrorCode errorCode, object obj)
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
