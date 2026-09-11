using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIModelRampage : UIBaseModel, IBigEventModel
{
	public const uint Prop_PlayerInfoUpdate = 2u;

	public const uint Prop_PurchaseSuccess = 4u;

	public const uint Prop_StoreItemsRefresh = 8u;

	public const uint Prop_GetEventStateInfoFinish = 16u;

	public const uint Prop_SelfPointsUpdate = 32u;

	public const uint Prop_SelfRankUpdate = 64u;

	private ELimitedEvent.EventState m_EventState;

	private List<LimitedEventStore> m_StoreList;

	private List<BigEventOpenInfoDesc> m_EventOpenInfosList;

	private RampageSettingDesc m_RampageSettingDesc;

	private List<RampagePoints> m_RampagePoints;

	private CSGetPlayerRampageInfoRes m_RampagePlayerInfo;

	private List<RampageRankDesc> m_RampageRankDesc;

	public Dictionary<uint, string> FactionNameDict;

	private uint m_EvenID;

	private string m_LobbyRankUpGuide;

	private string m_StoreRankUpGuide;

	private string m_LobbyStoreGuide;

	public override uint GetModelType()
	{
		return 0u;
	}

	public UIABigEventLobbyEnterWndControler GetBigEventLobbyEnterWnd()
	{
		return null;
	}

	public UIBigEventLobbyIconWndController GetBigEventLobbyIconWnd()
	{
		return null;
	}

	public bool IgnoreCheckOptionalDownload()
	{
		return false;
	}

	public bool CheckOpenedActivityView()
	{
		return false;
	}

	public bool CanGotoWhenBigEventClosed()
	{
		return false;
	}

	public bool CanIngoreDownloadRes(UIModelBigEvent.EBigEventEntranceID entranceId)
	{
		return false;
	}

	public void GotoBigEvent(string from, UIModelBigEvent.EBigEventEntranceID entranceId, ELimitedEvent.EventState activityState, string param, ulong subType3, object extra)
	{
	}

	public bool OptionalResNeedDownload()
	{
		return false;
	}

	public Type GetLobbyEntranceType()
	{
		return null;
	}

	public override void Logout(object[] data)
	{
	}

	public ELimitedEvent.RampageFaction GetSelfSideType()
	{
		return ELimitedEvent.RampageFaction.RampageFaction_NONE;
	}

	public bool SelfJoinedSide()
	{
		return false;
	}

	private void ProcessEventState()
	{
	}

	private void RefreshEventState()
	{
	}

	public ulong GetSelfPoints()
	{
		return 0uL;
	}

	public uint GetSelfRank()
	{
		return 0u;
	}

	public void RampagePointsUpdate(ulong points, uint rank)
	{
	}

	private void UpdateSelfPoints(ulong points)
	{
	}

	private void UpdateSelfRank(uint rank)
	{
	}

	private void RefreshRampageTipsNum()
	{
	}

	public void UpdateRampagePeakDayAward()
	{
	}

	public void SetLobbyRankUpGuide(uint rank)
	{
	}

	public void SetStoreRankUpGuide(uint rank)
	{
	}

	public void RefreshShopTipsNum(int num)
	{
	}

	public void RefreshSignInTipsNum(int num)
	{
	}

	public void RefreshPeakDayAwardTipsNum(int num)
	{
	}

	public void OnProcessEventOpenInfo()
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
