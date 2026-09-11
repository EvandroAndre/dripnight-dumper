using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;
using message;

namespace COW;

public class UIHudTokenController : UIBaseController
{
	private enum ReviveIconState
	{
		None,
		SoloRevive,
		AutoRevive,
		ZoneRevive,
		Finished
	}

	private enum EReviveType
	{
		SoloRevive,
		DiwaliBuff
	}

	private enum EReviveCardState
	{
		None,
		CountLimited,
		TimeLimited,
		TimeLimitCountdown
	}

	private sealed class _003CCoPlayPlayEffect_003Ed__56 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudTokenController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoPlayPlayEffect_003Ed__56(int _003C_003E1__state)
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

	private sealed class _003CUpdateBuySelfReviveState_003Ed__71 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudTokenController _003C_003E4__this;

		public FHLHFAJMBOD game;

		private bool _003CshowPopTip_003E5__2;

		private WaitForSeconds _003CwaitFixedDeltaTime_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CUpdateBuySelfReviveState_003Ed__71(int _003C_003E1__state)
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

	private const int REVIVE_CARD_ID = 5001;

	private const int ADVANCE_REVIVE_CARD_ID = 5003;

	private UIHudTokenView m_View;

	private IEnumerator m_PlayEffectCor;

	private bool m_IsPlayEff;

	private int m_TokenNum;

	private int m_SoloReviveNeedTokenNum;

	private UIModelCustomRoom m_ModelCustomRoom;

	private bool m_buyReviveStart;

	private int m_ReviveTimes;

	private float m_LandedTime;

	private bool m_FirstLanded;

	private uint m_BubbleDelayCallID;

	private uint m_DelayHideCommonCoinsGot;

	private bool m_SensorBeaconHostShowed;

	private ReviveIconState m_ReviveState;

	private float m_ReviveBuffEndTime;

	private float m_ReviveBuffDuration;

	private bool m_CanReviveInGhostCircle;

	private bool m_IsReviveStateInited;

	private bool m_IsSoloReviveMatchEnabled;

	private bool m_IsSoloReviveMatchActualEnabled;

	private bool m_PreSoloReviveMatchEnabled;

	private bool m_IsCustomRoomAutoReviveEnabled;

	private bool m_IsSoloRevivePointEnabled;

	private bool m_IsSoloRevivePointActualEnabled;

	private bool m_PreSoloRevivePointEnabled;

	private bool m_IsReviveCardUpdate;

	private EReviveCardState m_ReviveCardState;

	private UIHudTokenRevivalCardTipController m_ReviveCardTipController;

	private UIHudTokenCustomReviveController m_CustomReviveCtrl;

	private EReviveType m_LastReviveType;

	private UIClickMask m_RevivalTipsMask;

	private BitArrayBoolean m_RevivalEffectVisibility;

	private const uint REVIVALEFFECT_AUTOREVIVE = 1u;

	private const uint REVIVALEFFECT_SOLOREVIVE = 2u;

	private BitArrayBoolean m_ReviveBtnVisibilityStatus;

	private const uint REVIVEBTN_VISIBILITY_CUSTOMROOMAUTOREVIVE = 1u;

	private const uint REVIVEBTN_VISIBILITY_SOLOREVIVE = 2u;

	private const uint REVIVEBTN_VISIBILITY_SOLOREVIVEPOINT = 4u;

	private const uint REVIVEBTN_VISIBILITY_BUFFREVIVE = 8u;

	private const uint REVIVEBTN_VISIBILITY_GHOST = 16u;

	private MutableString m_LeftSecStr;

	private int m_lastLeftSec;

	private bool m_ShowedWaring;

	private bool m_ShowDiwaliReviveTips;

	private UIHudTokenInReviveZoneController m_InReviveZoneController;

	private bool m_isShowZoneReviveIcon;

	private ulong m_ZoneIndex;

	private int m_RemainCnt;

	private uint m_FullScreenVfxId;

	private uint m_DelayHideFullScreenVfx;

	private bool m_FirstEnter;

	private bool m_ZoneChangeToEenter;

	private Player.IGJPHDANPJD m_lastObsetverState;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void OnEnable()
	{
	}

	private void InitReviveSettings()
	{
	}

	private void InitRevivalState()
	{
	}

	private void RefreshReviveCardState()
	{
	}

	private void SetReviveCardVisible(bool isShow)
	{
	}

	private void InitLables()
	{
	}

	private void OnTokenChanged(int data)
	{
	}

	private IEnumerator CoPlayPlayEffect()
	{
		return null;
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void OnRevivalBtnClick(GameObject go)
	{
	}

	private void RefreshReviveTipsPanel(bool isShow)
	{
	}

	private void DestroyRevivalTipsMask()
	{
	}

	private void OnReviveCardBtnClick(GameObject go)
	{
	}

	private void RefreshReviveCardRedBg(bool isShow)
	{
	}

	private void OnReviveCardRedBgTweenInFinish()
	{
	}

	private void OnReviveCardRedBgTweenOutFinish()
	{
	}

	private void SetRevivalEffectVisibility(uint flag, bool value)
	{
	}

	private int GetTotalRemainingRevives()
	{
		return 0;
	}

	private void RefreshAutoRevivalState(byte autoRevivalState)
	{
	}

	private void OnTokenAutoRevival(object[] data)
	{
	}

	private void OnPlayerAliveStateChange(uint data)
	{
	}

	private void UpdateBuySelfReviveCost(object[] data)
	{
	}

	private IEnumerator UpdateBuySelfReviveState(FHLHFAJMBOD game)
	{
		return null;
	}

	private void OnPlayerPhyxStateChanged(GEvent data)
	{
	}

	public Transform GetTokenNumTransform()
	{
		return null;
	}

	private void OnObserveSwitch(object[] data)
	{
	}

	private void RefreshObserverTokenNum(Player target)
	{
	}

	private void CloseReviveUI()
	{
	}

	private void OnPinMark()
	{
	}

	private void Update()
	{
	}

	private void OnPlayerReviveZoneChange(ulong data)
	{
	}

	private void OnReviveZoneRemainCount()
	{
	}

	private void OnReviveZoneCloseTime()
	{
	}

	private void RefreshReviveZoneUI()
	{
	}

	private void UpdateRemainCountTips()
	{
	}

	private void SetReviveSpriteIcon()
	{
	}

	private void InitReviveZoneInfo()
	{
	}

	private void ShowFirstEnterReviveZoneEffect()
	{
	}

	private void ShowReviveZoneInfo()
	{
	}

	private void HideScreenUIVfx()
	{
	}

	private void OnSoloReviveTimesChange(object[] data)
	{
	}

	private void OnTeamBoughtCountChanged(object[] data)
	{
	}

	private void OnIngameShopItemsReady()
	{
	}

	private void OnPlayerDead(object[] data)
	{
	}

	private void OnPlayerRevive(uint playerId)
	{
	}

	private void OnPlayerLanded(object[] data)
	{
	}

	private void RefreshReviveBtn()
	{
	}

	private void ShowSoloRevieTips(string key, object[] param)
	{
	}

	private void ShowZoneRevieTips(string key, object[] param)
	{
	}

	private void ShowReviveTips(string key, ResourceID resID, object[] param)
	{
	}

	private void OnFloatingLandStart(object[] data)
	{
	}

	private void OnReviveMissionStart(object[] data)
	{
	}

	private void OnObserverStatusChangeCallback(GEvent data)
	{
	}

	private void OnGetTokenToShow(object[] data)
	{
	}

	private void SetGetTokenVFXShow(PCBILGLDNHM type)
	{
	}

	private void OnGetTokenFromTokenMachine(int count, BHGGAEEHJCO playerID, uint indexBitArrayMask, bool showBubbleIcon = true)
	{
	}

	private void RefreshTokenDetailByIndexMask(uint indexBitArrayMask)
	{
	}

	private void OnKingGetToken(int count)
	{
	}

	private void OnGetTokenFromTreasureHunt(int count, BHGGAEEHJCO playerID)
	{
	}

	private void OnReviveBuffChanged(object[] data)
	{
	}

	private void OnGotGlooAirdropToken(uint num)
	{
	}

	private void OnGotGlooWorldModuleToken(uint num)
	{
	}

	private void HideBubble()
	{
	}

	public bool CheckLocalHaveReviveTimes()
	{
		return false;
	}

	private void OnPlayerReviveCountChanged()
	{
	}

	private void OnSoloRPReviveChanged(object[] data)
	{
	}

	private void OnCommonCoinsGot(int cnt, int reason)
	{
	}

	private void HideCommonCoinsGot()
	{
	}

	private void OnLandingFightProtectionInfoChanged(GEvent evt)
	{
	}

	private void HideCustomRevive()
	{
	}

	private void RefreshCustomReviveRootState(bool isShowCustome)
	{
	}

	private void RefreshReviveZoneRootState(bool isShowReviveZone)
	{
	}

	private void RefreshGhostCircleState(bool isShowRevive)
	{
	}

	private void RefreshGhostCircleReviveLastCount(int count)
	{
	}

	private void OnAddPlayer(object[] data)
	{
	}

	private void RefreshLandingFightProtectGroup()
	{
	}

	private void CheckAndUpdateReviveState()
	{
	}

	private void SetAndUpdateReviveBtnVisibilityStatus(uint flag, bool value)
	{
	}

	private void HideReviveBtn()
	{
	}

	private void UpdateReviveBtnVisibility()
	{
	}

	public void OnRemainingInfoRatingShow()
	{
	}

	private void _003COnEnable_003Eb__49_0(GameObject go, bool v)
	{
	}

	private void _003CRefreshReviveTipsPanel_003Eb__59_0()
	{
	}

	private void _003CRefreshReviveBtn_003Eb__107_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
