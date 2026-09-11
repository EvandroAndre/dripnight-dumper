using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using message;

namespace COW;

internal class UIGameModeCSRankItemController : UIGameModeBaseItemController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static EventDelegate.Callback _003C_003E9__14_0;

		internal void _003COnUIInit_003Eb__14_0()
		{
		}
	}

	public static bool m_LockShow;

	private UIModelMapOpeningInfo m_ModelInfo;

	private UIModelCSLadderMatch m_ModelCSLadderMatch;

	private NIKKALKPIBO m_GameMode;

	private DLBMPCCFKKM m_MatchMode;

	private bool m_isGuest;

	private static string NewPlayerInCSRank;

	private static string NewPlayerInRank;

	private new UIModelUser m_ModelUser;

	private bool m_DataInit;

	private UIGameModeCSRankInfoController m_InfoCtrl;

	private GameObject m_HLEEffect;

	private uint m_HLEEffectTicket;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override ResourceID SelectEffectResID()
	{
		return default(ResourceID);
	}

	protected override void SetMapModeUI(MapModeData mapModeData)
	{
	}

	public override void SetPickHighLight(bool state)
	{
	}

	public override int GetDropdownLikePanelBaseDepth()
	{
		return 0;
	}

	protected override void OnPanelOverLiveEffectsDepthChange(int overLifeEffectPanelDepth)
	{
	}

	private void RefreshCSSpecialMatchCDN(MapModeData mapModeData)
	{
	}

	public int GetPanelOverLiveEffects()
	{
		return 0;
	}

	protected override ResourceID ClickEffectResID()
	{
		return default(ResourceID);
	}

	public void CheckLevelLock()
	{
	}

	public bool IsCSRankLockShow()
	{
		return false;
	}

	public bool IsBeBanMatch()
	{
		return false;
	}

	private void OnAsycLoadHLEEffectSuccess(uint ticket, bool success, UnityEngine.Object obj)
	{
	}

	public override void OnModeBtnClick()
	{
	}

	private int GetNewPlayerEffectShow()
	{
		return 0;
	}

	private void SetNewPlayerInRankShow(int state)
	{
	}

	protected override void SetItemUIData(List<MapModeData> dataList)
	{
	}

	protected override bool IsTopRightTakenByInfoCtrl()
	{
		return false;
	}

	protected override void OnGameModeVisiableChange(object[] data)
	{
	}

	protected override bool CheckDuoVersionState()
	{
		return false;
	}

	protected override bool CheckBanMatchState(ref long punishUntil)
	{
		return false;
	}

	public override void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public void RefreshWithDisplayStateOnVisible()
	{
	}

	public void RefreshSeasonSwitchNode()
	{
	}

	public bool CheckIsSeasonSwitchState()
	{
		return false;
	}

	protected override bool IsBeforeCurrentRankSeasonInfoStartTime()
	{
		return false;
	}

	private void RefreshSeasonSwitchView(bool isShow)
	{
	}

	private void _003CRefreshCSSpecialMatchCDN_003Eb__21_0()
	{
	}

	private void _003CRefreshCSSpecialMatchCDN_003Eb__21_1()
	{
	}

	private void _003CRefreshSeasonSwitchNode_003Eb__38_0()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public ResourceID _003C_003EiFixBaseProxy_SelectEffectResID()
	{
		return default(ResourceID);
	}

	public void _003C_003EiFixBaseProxy_SetMapModeUI(MapModeData P0)
	{
	}

	public void _003C_003EiFixBaseProxy_SetPickHighLight(bool P0)
	{
	}

	public int _003C_003EiFixBaseProxy_GetDropdownLikePanelBaseDepth()
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_OnPanelOverLiveEffectsDepthChange(int P0)
	{
	}

	public ResourceID _003C_003EiFixBaseProxy_ClickEffectResID()
	{
		return default(ResourceID);
	}

	public void _003C_003EiFixBaseProxy_OnModeBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_SetItemUIData(List<MapModeData> P0)
	{
	}

	public bool _003C_003EiFixBaseProxy_IsTopRightTakenByInfoCtrl()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnGameModeVisiableChange(object[] P0)
	{
	}

	public bool _003C_003EiFixBaseProxy_CheckDuoVersionState()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_CheckBanMatchState(ref long P0)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnDataChanged(UIBaseModel P0, uint P1, object[] P2)
	{
	}

	public bool _003C_003EiFixBaseProxy_IsBeforeCurrentRankSeasonInfoStartTime()
	{
		return false;
	}
}
