using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;
using message;

namespace COW;

internal class UIHudTeammatesInfoController : UIBaseController, IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<MatchTeam.KMGBNNHDOHF> _003C_003E9__36_0;

		public static Comparison<UIHudTeammateItem> _003C_003E9__82_0;

		public static Comparison<UIHudTeammateItem> _003C_003E9__83_0;

		public static Predicate<UIHudTeammateItem> _003C_003E9__83_1;

		public static Comparison<MatchTeam.KMGBNNHDOHF> _003C_003E9__100_0;

		internal int _003CRefreshTeammates_003Eb__36_0(MatchTeam.KMGBNNHDOHF a, MatchTeam.KMGBNNHDOHF b)
		{
			return 0;
		}

		internal int _003CRepositon_003Eb__82_0(UIHudTeammateItem a, UIHudTeammateItem b)
		{
			return 0;
		}

		internal int _003CFitReposition_003Eb__83_0(UIHudTeammateItem a, UIHudTeammateItem b)
		{
			return 0;
		}

		internal bool _003CFitReposition_003Eb__83_1(UIHudTeammateItem e)
		{
			return false;
		}

		internal int _003COnChangeTeam_003Eb__100_0(MatchTeam.KMGBNNHDOHF a, MatchTeam.KMGBNNHDOHF b)
		{
			return 0;
		}
	}

	private sealed class _003CRefreshTeammatesDelayEnumerator_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudTeammatesInfoController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRefreshTeammatesDelayEnumerator_003Ed__33(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private UIHudTeammatesInfoView m_View;

	private Dictionary<BHGGAEEHJCO, UIHudTeammateItem> m_Teammates;

	private Dictionary<ulong, BHGGAEEHJCO> m_UserIdToPlayerId;

	private UIModelMatch m_MatchModel;

	private List<UIHudTeammateItem> m_ListTeammateItem;

	private Dictionary<int, Transform> m_DicPageGrid;

	private UICenterOnChild m_wrapCenter;

	private bool m_RemoveOnQuit;

	private int m_totalTeammatePage;

	private Dictionary<BHGGAEEHJCO, KMGBNNHDOHF> m_TeammateSycInfo;

	private int ITEM_PER_PAGE;

	private int ITEM_HEIGHT;

	private IEnumerator m_ObserverTeammateSwitchEnuerator;

	private object[] m_ObserverTeammateSwitchTmpData;

	private float m_ScoreBoardOnPressedTime;

	private float m_GetTeamSlotTime;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	private bool NeedWrapPages()
	{
		return false;
	}

	private bool AutoFitResposition()
	{
		return false;
	}

	public override bool RecyleDontDestroy()
	{
		return false;
	}

	public static bool DontDestroy()
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	public override void OnUIReInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private bool IsViewTeammateItem(UIHudTeammateItem item)
	{
		return false;
	}

	private void ResetViewTeammateItem(UIHudTeammateItem item)
	{
	}

	private void ResetViewTeammateItems()
	{
	}

	private UIHudTeammateItem GetTeammateItemTemplate()
	{
		return null;
	}

	private UIHudTeammateItem CreateTeammateItem()
	{
		return null;
	}

	private void CreateTeammateItemsIfNeed(int needCount)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void RefreshTeammatesOnObserverSwitch(object[] param)
	{
	}

	private void CloseTeammateSwitchCoroutine()
	{
	}

	private IEnumerator RefreshTeammatesDelayEnumerator()
	{
		return null;
	}

	private void AvoidSameUIDWhenTeammateAdd(Player p)
	{
	}

	private void RefreshTeammatesAceShow(MatchModelKillData data)
	{
	}

	private void RefreshTeammates(object[] param)
	{
	}

	private void RefreshIIVFloatingLand()
	{
	}

	private void RefreshEighthIcon()
	{
	}

	private void OnUGCFactionChange(object[] data)
	{
	}

	private void Update()
	{
	}

	private void RequestTeamSlotInfo()
	{
	}

	private void GetCenterItem(GameObject centerGo)
	{
	}

	public UIWidget GetTutorialWidget()
	{
		return null;
	}

	public UIWidget GetScoreBoardBtnTutorialWidget()
	{
		return null;
	}

	public void OnClickScoreBoardBtn(GameObject go, bool value)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void OnPlayerHPChanged(GEvent data)
	{
	}

	private void OnPlayerSpChange(GEvent data)
	{
	}

	private void OnUsingRevivePointStateChanged(uint data, uint oldValue)
	{
	}

	private void OnLevelChanged(object[] data)
	{
	}

	private void OnRescueByTeammate(object[] data)
	{
	}

	private void OnTeammateChangeToFootBall(object[] data)
	{
	}

	private void OnPlayerKnockDownStateChanged(object[] data)
	{
	}

	private void OnPlayerMaxHPChanged(object[] data)
	{
	}

	private void OnRemoveMapMark(object[] data)
	{
	}

	private void OnUpdateMapMark(object[] data)
	{
	}

	public void OnUpdateBeReaper(uint playerId)
	{
	}

	private void RefreshIIVFloatingLandIcon(uint PlayerID, uint joinTime)
	{
	}

	private void RefreshTeammateEighthIcon(uint PlayerID, uint iconType)
	{
	}

	private void OnPlayerOnOrOutIsland(object[] data)
	{
	}

	private void OnPlayerUnderWaterChanged(object[] data)
	{
	}

	private void RefreshTeammateStropIcon(object[] data)
	{
	}

	private void RefreshTeammateSlideIcon(object[] data)
	{
	}

	private void RefreshIIVSkillIcon(object[] data)
	{
	}

	private void OnPlayerGetOnVehicle(object[] data)
	{
	}

	private void OnPlayerGetOffVehicle(object[] data)
	{
	}

	private void OnTeammateKnockDown(object[] data)
	{
	}

	private void OnTeammateRevive(object[] data)
	{
	}

	private void OnTeammatePhyxStateChanged(object[] data)
	{
	}

	private void OnTeammateQuit(object[] data)
	{
	}

	private void OnRefreshQuitTeamMateUI(object[] data)
	{
	}

	private void OnRefreshQuitReviveTeamMateUI(object[] data)
	{
	}

	public bool IsTeammateDisconnect(BHGGAEEHJCO pId)
	{
		return false;
	}

	private void OnTeamateVadStateChange(object[] data)
	{
	}

	private void OnMicrophoneChanged(object[] data)
	{
	}

	private void OnOwnPlayerChange(object[] data)
	{
	}

	private void OnTeammateMuteChange(object[] data)
	{
	}

	private void OnTeamateStateChange(object[] data)
	{
	}

	private void OnTeamInfoGet(object[] data)
	{
	}

	private void Repositon()
	{
	}

	private void FitReposition()
	{
	}

	protected override void RefreshVisibility(bool move = false)
	{
	}

	private void OnTeamParachuteModeChange(object[] param)
	{
	}

	private void OnTeamGatherPointStateChane(object[] param)
	{
	}

	private void OnTrainingZoneChanged(object[] param)
	{
	}

	private void OnPlayerTrainingZoneChange(uint param0, uint param1)
	{
	}

	private void OnPlayerTokenChanged(object[] param)
	{
	}

	private void On3PInventoryChange(object[] data)
	{
	}

	private void OnNewPhaseStarted(object[] data)
	{
	}

	private void OnADS1v1Countdown(object[] data)
	{
	}

	private void OnADS1v1Selected(object[] data)
	{
	}

	private void OnADSPlayerWin(object[] param)
	{
	}

	private void OnLocalPlayerOnHandWeaponChange(object[] data)
	{
	}

	private void OnPlayerBeKing(object[] data)
	{
	}

	private void OnRefreshSFRoleplayRole(uint playerId)
	{
	}

	private void OnRefreshInGulag(uint playerId)
	{
	}

	public bool PlayReviveBoxHighlightUIFX(BHGGAEEHJCO playerID, ResourceID resID)
	{
		return false;
	}

	private void OnChangeTeam(object[] data)
	{
	}

	private GameObject GetActualCenteredObject(UICenterOnChild centerOnChild)
	{
		return null;
	}

	private void OnLandingFightProtectionInfoChanged(GEvent evt)
	{
	}

	private void OnPlayerBeRescuredDataChanged(object[] data)
	{
	}

	private void OnPlayerUsingRescureZoneDataChanged(object[] data)
	{
	}

	private void OnPlayerPacemakerStatusChange(uint playerID)
	{
	}

	private void _003COnUIReInit_003Eb__20_0()
	{
	}

	private void _003COnADSPlayerWin_003Eb__94_0()
	{
	}

	public bool _003C_003EiFixBaseProxy_RecyleDontDestroy()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIReInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshVisibility(bool P0)
	{
	}
}
