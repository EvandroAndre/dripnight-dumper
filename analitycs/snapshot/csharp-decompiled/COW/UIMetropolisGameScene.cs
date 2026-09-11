using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIMetropolisGameScene : UIUGCCommonInGameScene
{
	private sealed class _003COpenCommonHud_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIMetropolisGameScene _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003COpenCommonHud_003Ed__23(int _003C_003E1__state)
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

	private UIHudMetropolisOptionController m_HudOption;

	private UIHudMetropolisChooseFactionController m_HudChooseFaction;

	private UIHudMetropolisVehicleStoreController m_HudVehicleStore;

	private UIHudMetropolisWeaponStoreController m_HudWeaponStore;

	private UIHudMetropolisLeaderBoardController m_HudRankingList;

	private UIHudMetropolisMessageController m_HudMessage;

	private UIHudMetropolisChatController m_HudChat;

	private UIHudMetropolisMissionController m_HudMission;

	private UIHudMetropolisNotificationController m_HudNotification;

	private UIHudMetropolisLotteryDrawController m_HudLotteryDraw;

	private UIHudMetropolisMapAreaController m_HudMapArea;

	private UIHudMetropolisGuideController m_HudGuide;

	private UIHudMetropolisMapMarkController m_HudMapMark;

	private UIHudMetropolisRemainingController m_HudRemaining;

	private UIHudMetropolisInGameShopController m_UIShop;

	private UIHudMetropolisMiniGameGymController m_UIMiniGameGym;

	private UIHudMetropolisTokenFlyController m_TokenAnimUI;

	private UIHudMetropolisCoinController m_CoinUI;

	private UIHudMetropolisAreaInfoController m_AreaInfoUI;

	private Dictionary<BHGGAEEHJCO, UIHudMetropolisHPController> m_HPControllers;

	private UIModelMetropolis m_ModelMetropolis;

	public override void RegisterGameEventHandler()
	{
	}

	protected override void OnDestory()
	{
	}

	protected override IEnumerator OpenCommonHud()
	{
		return null;
	}

	protected override void OnHudSettingChanged(object[] param)
	{
	}

	private void UpdateHudPosition()
	{
	}

	private Transform GetCtrlParentTrans(UIBaseController controller)
	{
		return null;
	}

	protected override bool IsNeedSafeZoneInfoController()
	{
		return false;
	}

	protected override bool IsNeedDirectionRuler()
	{
		return false;
	}

	protected override Type GetMatchResultType()
	{
		return null;
	}

	protected override void OnPlayerFactionChanged(object[] param)
	{
	}

	protected override void OnHandleLocalPlayerHitOther(BHGGAEEHJCO damager, BHGGAEEHJCO target)
	{
	}

	protected override bool ShowTeammateInfo()
	{
		return false;
	}

	protected override void OnPreOpenMatchResult()
	{
	}

	private void OnMetropolisAreaLocalPlayerEnter(object[] param)
	{
	}

	private void OnMetropolisAreaCountChange(object[] param)
	{
	}

	private void OnHandleFactionMessage(GEvent data)
	{
	}

	private void OnHandlePlayerMessage(GEvent data)
	{
	}

	private void OnLocalPlayerFactionChange(object[] data)
	{
	}

	private void OnShowCountDown(object[] data)
	{
	}

	private void OnShowChangeFaction(object[] data)
	{
	}

	private void OnShowRankingList(object[] data)
	{
	}

	private void OnShowMetropolisMission(object[] data)
	{
	}

	private void OnPlayerHpChanged(GEvent data)
	{
	}

	private void OnMetropolisTrackArea()
	{
	}

	private void OnMetropolisTrackPosition(object[] data)
	{
	}

	private void OnShowChat()
	{
	}

	protected void OnShowMetropolisShop(int shopType)
	{
	}

	protected void OnShowInGameShop(object[] data)
	{
	}

	private void OnEnableBigMap(GEvent eventData)
	{
	}

	private void OnDisableBigMap(object[] param)
	{
	}

	private void OnShowTokenFly(object[] param)
	{
	}

	private void OnMetropolisAreaStateChange(object[] param)
	{
	}

	private void OnMetropolisAreaStateEndTimeChange(object[] param)
	{
	}

	private void OnHandleSyncMiniGameGym(object[] data)
	{
	}

	private void TrackPosition(Vector3 pos)
	{
	}

	private void ShowTrackNoticeEffect()
	{
	}

	private void ShowMapAreaNoticeEffect(uint areaID)
	{
	}

	private UIHudMetropolisHPController GetHpCtrl(BHGGAEEHJCO playerID)
	{
		return null;
	}

	private void HideAllMetropolisNormalUI()
	{
	}

	private void HideMetropolisAreaUI()
	{
	}

	private IEnumerator _003C_003En__0()
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_RegisterGameEventHandler()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnDestory()
	{
	}

	public new IEnumerator _003C_003EiFixBaseProxy_OpenCommonHud()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnHudSettingChanged(object[] P0)
	{
	}

	public new bool _003C_003EiFixBaseProxy_IsNeedSafeZoneInfoController()
	{
		return false;
	}

	public new bool _003C_003EiFixBaseProxy_IsNeedDirectionRuler()
	{
		return false;
	}

	public new Type _003C_003EiFixBaseProxy_GetMatchResultType()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnPlayerFactionChanged(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnHandleLocalPlayerHitOther(BHGGAEEHJCO P0, BHGGAEEHJCO P1)
	{
	}

	public bool _003C_003EiFixBaseProxy_ShowTeammateInfo()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnPreOpenMatchResult()
	{
	}
}
