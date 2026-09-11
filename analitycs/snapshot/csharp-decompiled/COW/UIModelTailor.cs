using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using proto;
using tcp;

namespace COW;

public class UIModelTailor : UIBaseModel
{
	public class NotifyArgs
	{
		public bool success;

		public uint tailorID;

		public RewardWndCfg cfg;
	}

	public class UpdateInfoNotifyArgs
	{
		public bool success;

		public List<uint> updateTailorList;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003E9__65_1;

		internal CommonRewardItemInfo _003CRequestTailorUnlockBuy_003Eb__65_1(BaseItemInfo item)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass58_0
	{
		public uint unlockID;

		internal bool _003CGetTailorItemUnlockInfo_003Eb__0(TailorUnlockInfo.UnlockItem i)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass59_0
	{
		public uint unlockID;

		internal bool _003CGetTailorItemUnlockDesc_003Eb__0(TailorUnlockDesc i)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass64_0
	{
		public UIModelTailor _003C_003E4__this;

		public UpdateInfoNotifyArgs args;

		internal void _003CRequestTailorUnlockInfo_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass65_0
	{
		public uint tailorID;

		public UIModelTailor _003C_003E4__this;

		internal void _003CRequestTailorUnlockBuy_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass66_0
	{
		public UIModelTailor _003C_003E4__this;

		public bool isAuto;

		internal void _003CRequsetExchangeTailorUnlockToken_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass71_0
	{
		public uint unlockIndex;

		internal bool _003CGetTailorUnlockItem_003Eb__0(TailorUnlockInfo.UnlockItem i)
		{
			return false;
		}
	}

	private Dictionary<uint, TailorSettingDesc> m_TailorSettingDescDict;

	private Dictionary<uint, List<TailorUnlockDesc>> m_TailorUnlockDescDict;

	private Dictionary<uint, TailorUnlockInfo> m_TailorUnlockInfoDict;

	private Dictionary<uint, uint> m_LegendIdToTailorId;

	private List<uint> m_ChangedTailorList;

	private List<uint> m_InRequestTailorList;

	private Dictionary<uint, int> m_TailorTipsCntDict;

	private Dictionary<uint, bool> m_NewTailorDict;

	private Dictionary<uint, List<uint>> m_TailorNewItemDict;

	private Dictionary<uint, List<uint>> m_TailorNewItemDictForEffect;

	private Dictionary<uint, uint> m_TokenItemIDToTailorIDDict;

	private HashSet<uint> m_PrivilegeEffectItems;

	private Dictionary<uint, ClothTriggerEffectPreviewData> m_DictClothTriggerEffectPreviewCfg;

	private List<uint> m_RemainExchangeTailorIdList;

	private Dictionary<uint, BaseItemInfo> m_RemainExchangeTailorIdToItemInfoDict;

	private Dictionary<byte, TailorItemInfo> _003CPreviewClothesDict_003Ek__BackingField;

	public const uint PropID_TailorUnlockDescUpdate = 2u;

	public const uint PropID_TailorUnlockInfoUpdate = 4u;

	public const uint PropID_TailorUnlockBuyResponse = 8u;

	public const uint PropID_TailorChanged = 16u;

	public const uint PropID_ExchangeTailorToken = 32u;

	private const uint IPTailorID = 16u;

	private const string TAILORENTRANCEREDPOINTFORMAT = "TailorEntranceRedPoint{0}{1}";

	private const string TAILORSHOWNEWTIPS = "TailorShowNewTips{0}";

	private List<string> m_ShowedTailorList;

	private bool m_InitedShowedTailorList;

	private bool m_HasShowedNewTailorTips;

	private bool m_InitedTailorDesc;

	private bool m_HasRequestDesc;

	public Dictionary<byte, TailorItemInfo> PreviewClothesDict
	{
		get
		{
			return _003CPreviewClothesDict_003Ek__BackingField;
		}
		set
		{
			_003CPreviewClothesDict_003Ek__BackingField = value;
		}
	}

	public Dictionary<uint, BaseItemInfo> RemainExchangeTailorIdToItemInfoDict => null;

	public List<uint> RemainExchangeTailorList => null;

	public override void Init()
	{
	}

	public override void Logout(object[] data)
	{
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	public bool IsHaloHasUnLock(uint clothID)
	{
		return false;
	}

	public bool IsPermanentEffectUnlock(uint clothID)
	{
		return false;
	}

	public HashSet<uint> GetCurrentUnlockEffectItemIDs(IEnumerable<uint> clothList = null)
	{
		return null;
	}

	public HashSet<uint> GetLegendClothSetList()
	{
		return null;
	}

	public uint GetTailorIdByLegendId(uint legendId)
	{
		return 0u;
	}

	private void AddToCurrentUnlockEffectItemIDList(HashSet<uint> hashSet, uint itemID)
	{
	}

	public bool IsEffectItemIDUnlock(uint itemID)
	{
		return false;
	}

	public bool IsEventTriggerHasUnlockInGame(uint itemID, BHGGAEEHJCO playerID)
	{
		return false;
	}

	public bool IsPermanentEffectHasUnlockInGame(uint clothID, BHGGAEEHJCO playerID)
	{
		return false;
	}

	public bool IsPermanentEffectHasUnlockInGame(uint clothID, BaseProfileInfo profile)
	{
		return false;
	}

	public ETailorState GetTailorState(uint tailorID)
	{
		return ETailorState.Lock;
	}

	public bool TailorHasUnlock(uint tailorID)
	{
		return false;
	}

	public bool TailorIsLimited(uint tailorID)
	{
		return false;
	}

	public bool TailorIsLimitedByTime(TailorUnlockDesc item)
	{
		return false;
	}

	public bool TailorIsCountDownShow(TailorUnlockDesc item)
	{
		return false;
	}

	public uint TailorUnlockItemCount(uint tailorID, UnLockType unLockType = UnLockType.None)
	{
		return 0u;
	}

	public uint TailorAllItemCount(uint tailorID, UnLockType unLockType = UnLockType.None)
	{
		return 0u;
	}

	public bool TailorUnlockAllItem(uint tailorID)
	{
		return false;
	}

	public TailorUnlockInfo.UnlockItem GetTailorItemUnlockInfo(uint tailorID, uint unlockID)
	{
		return null;
	}

	public TailorUnlockDesc GetTailorItemUnlockDesc(uint tailorID, uint unlockID)
	{
		return null;
	}

	public ETailorClothUnlockType GetTailorClothUnLockType(uint tailorID)
	{
		return ETailorClothUnlockType.Bundle;
	}

	public TailorUnlockDesc GetTailorUnlockDescByItemID(uint itemID)
	{
		return null;
	}

	public void RequestTailorUnlockDesc(uint httpOption = 0u, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public void RequestTailorUnlockInfo()
	{
	}

	public void RequestTailorUnlockBuy(uint tailorID, uint unlockID, uint tokenCount, uint universalAmount = 0u, bool isGems = false)
	{
	}

	public void RequsetExchangeTailorUnlockToken(List<uint> tailorTokenId, bool isAuto = false)
	{
	}

	public TailorSettingDesc GetTailorSettingDesc(uint tailorID)
	{
		return null;
	}

	public List<TailorSettingDesc> GetTailorSetting(ETailorTabType filter)
	{
		return null;
	}

	public List<TailorUnlockDesc> GetTailorUnlockDesc(uint tailorID)
	{
		return null;
	}

	public TailorUnlockInfo GetTailorUnlockInfo(uint tailorID)
	{
		return null;
	}

	public TailorUnlockInfo.UnlockItem GetTailorUnlockItem(uint tailorID, uint unlockIndex)
	{
		return null;
	}

	public TailorUnlockDesc GetTailorBaseSetUnlockDesc(uint tailorID)
	{
		return null;
	}

	public void ProcessPrivillegeEffectItems(List<PrivilegeConfigDesc> descList)
	{
	}

	public ClothTriggerEffectPreviewData GetClothTriggerEffectPreviewDataById(uint eventID)
	{
		return null;
	}

	public bool DoesClothOrBundleCanPreviewEventClothEffect(uint itemId)
	{
		return false;
	}

	public void UpdateChangedTailorID(List<uint> tailorIDs, List<InventoryTailorChangeNtf.ChangeUnlockInfo> unlocks)
	{
	}

	public void UpdateTailorItemTips(List<InventoryTailorChangeNtf.ChangeUnlockInfo> unlocks)
	{
	}

	public bool IsTailorChanged(uint tailorID)
	{
		return false;
	}

	public bool IsEquipedCloth(uint clothID)
	{
		return false;
	}

	public List<uint> GetAllPreviewCloth()
	{
		return null;
	}

	public bool IsNewTailor(uint tailorID)
	{
		return false;
	}

	public void SetTailorNewState(uint tailorID, bool isNew)
	{
	}

	public void AddTailorTipsCnt(uint tailorID, int num)
	{
	}

	public void ClearTailorTipsCnt(uint tailorID)
	{
	}

	public int GetTailorTipsCnt(uint tailorID)
	{
		return 0;
	}

	public int GetAllTailorTipsCnt()
	{
		return 0;
	}

	public void AddLobbyLabTipsCnt(int num)
	{
	}

	public void AddLabTailorEntranceTipsCnt(int num)
	{
	}

	public void ClearAllLabTailorEntranceTips()
	{
	}

	public void SetNewTailorTipsShowed()
	{
	}

	public void ClearAllNewItems(uint tailorID)
	{
	}

	public bool IsNewItem(uint tailorID, uint unlockID)
	{
		return false;
	}

	public void ClearAllNewEffectDictItems(uint tailorID)
	{
	}

	public bool IsNewEffectDictItem(uint tailorID, uint unlockID)
	{
		return false;
	}

	public bool HasNewEffectItem(uint tailorID)
	{
		return false;
	}

	public uint GetTailorIDByTokenItemID(uint tokenItemID)
	{
		return 0u;
	}

	public bool IsTailorToken(uint tokenItemID)
	{
		return false;
	}

	public void RefreshRemainTokenForAllTailor()
	{
	}

	public void AutoExchangeRemainToken(uint tailorID)
	{
	}

	public bool IsIPTagOpen()
	{
		return false;
	}

	public ETailorTabType GetTailorTabByTailorID(uint tailorID)
	{
		return ETailorTabType.NONE;
	}

	private ETailorTabType GetTailorTabBySetting(TailorSettingDesc desc)
	{
		return ETailorTabType.NONE;
	}

	private void _003CRequestTailorUnlockDesc_003Eb__63_0(HttpErrorCode errorCode, object res)
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
