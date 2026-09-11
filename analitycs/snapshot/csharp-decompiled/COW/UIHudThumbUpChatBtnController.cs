using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;
using message;

namespace COW;

public class UIHudThumbUpChatBtnController : UIBaseController, IUIModelDataChangeObserver
{
	private enum EClickLikeType
	{
		None,
		AliveAndSameTeam,
		DeadObserver,
		FriendObserve,
		UGCAlive
	}

	public enum EThumbUpType
	{
		None,
		FirstBlood,
		TripleKill,
		QuadraKill,
		MatchEndShowObserve,
		RoundEndMvp,
		WaitingPhase,
		HeadShotInTime,
		FinishHuntKillMission,
		AntiKillAfterBeHunt,
		KillPlayerByCar,
		VbadgeWaitingPhase
	}

	private sealed class _003C_003Ec__DisplayClass42_0
	{
		public UIHudThumbUpChatBtnController _003C_003E4__this;

		public int thumbUpExistingTime;

		internal void _003COnShowThumbUpBtnInWaitingPhase_003Eb__0()
		{
		}
	}

	private sealed class _003CMatchEndLikeBtnTick_003Ed__76 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudThumbUpChatBtnController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CMatchEndLikeBtnTick_003Ed__76(int _003C_003E1__state)
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

	private sealed class _003CRoundEndMvpBtnTick_003Ed__79 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudThumbUpChatBtnController _003C_003E4__this;

		public float duration;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRoundEndMvpBtnTick_003Ed__79(int _003C_003E1__state)
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

	private sealed class _003CWaitingPhaseBtnTick_003Ed__80 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudThumbUpChatBtnController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CWaitingPhaseBtnTick_003Ed__80(int _003C_003E1__state)
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

	private UIHudThumbUpChatBtnView m_View;

	private uint m_ContinuousLikeNotClickLog;

	private uint m_QuickChatBtnDelayHide;

	private Coroutine m_MatchEndLikeBtnCo;

	private uint m_ShowRoundEndMvpBtnDelayCall;

	private uint m_HideWaitingPhaseThumbUpBtnDelayCall;

	private uint m_ShowWaitingPhaseThumbUpBtnDelayCall;

	private EThumbUpType m_ThumbUpType;

	private EThumbUpType m_ContinuousLikeReason;

	private BHGGAEEHJCO m_ContinuousLikePlayerID;

	private Player m_ThumbUpTarget;

	private BHGGAEEHJCO m_MVPPlayerID;

	private bool m_AlreadyShowThumbUp;

	private int m_ClickLikeKillThumbTimer;

	private float m_MatchEndLikeBtnTickTime;

	private SpectateHighligntLike m_ThumbUpSpectateData;

	private Action m_CsRoundEndShowMVPBtnFunc;

	private FHCKGNCNMCA m_CsRoundEndMsg;

	private float m_CsRoundEndMvpBtnTickTime;

	private Coroutine m_CsRoundEndMvpBtnCo;

	private float m_WaitingPhaseBtnLeftTime;

	private float m_WaitingPhaseBtnTickTime;

	private Coroutine m_WaitingPhaseBtnCo;

	private Vector3 m_LikeKillQuickChatPos;

	private uint m_CurKillPlayerID;

	private const int VBADGE_LIKE_MAX_COUNT = 10;

	private int m_VBadgeLikeCount;

	private UIHudQuickChatV2ComboController ComboCtrl => null;

	private float DurationForEatingChicken => 0f;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
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

	private void OnObserverTargetChanged(object[] data)
	{
	}

	private bool CheckIsLocalObserver()
	{
		return false;
	}

	private bool CheckCanShow()
	{
		return false;
	}

	private void OnLocalPlayerRevive(object[] data)
	{
	}

	private void OnShowThumbUpBtnInWaitingPhase(object[] data)
	{
	}

	private void ConstructClickLikeLog()
	{
	}

	private void SendClickLikeLog(ulong getLikeAccountId, bool isFriend, int triggerType, int triggerReason, int likeCnt)
	{
	}

	private void OnClickThumbUpBtn()
	{
	}

	private void ShowWaitingPhaseThumbUpBtn(float leftTime)
	{
	}

	private bool CheckIsObserverLikeType(EThumbUpType likeType)
	{
		return false;
	}

	private void CacheObserverLikeMsg(BHGGAEEHJCO playerID, EThumbUpType likeType)
	{
	}

	private void OnHandlObserverLikeMsg(object[] data)
	{
	}

	private void OnMatchEndShowObserveThumbUpBtnShow(object[] data)
	{
	}

	private void OnCabinWaitingEnd()
	{
	}

	private void OnShowVBadgeCabinThumbUpBtn(bool isShow)
	{
	}

	private void OnVBadgeBroadcastBannerHide()
	{
	}

	private void OnKillCamEntryShow()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param1)
	{
	}

	private void ShowBtn()
	{
	}

	private void OnRoundResultShow(object[] data)
	{
	}

	private void ShowRoundMvpWhenBattleBoardExist(float duaration)
	{
	}

	private void CsRoundEndShowMVPBtn()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnUIHudThumbUpChatBtnClick()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void LikeKillBtnSetUp()
	{
	}

	private void QuickChatBtnSetUp()
	{
	}

	private void QuickChatBtnClickedView()
	{
	}

	private void OnQuickChatBtnTweenFinished()
	{
	}

	private void OnMatchEndLikeBtnScaleTweenFinished()
	{
	}

	private void QuickChatBtnHide()
	{
	}

	public override void Hide()
	{
	}

	private void NotifyComboShow()
	{
	}

	private void NotifyComboHide()
	{
	}

	private void MatchEndLikeBtnSetUp()
	{
	}

	private IEnumerator MatchEndLikeBtnTick()
	{
		return null;
	}

	private void MatchEndLikeBtnClickedView()
	{
	}

	private void RoundEndMvpBtnSetup()
	{
	}

	private IEnumerator RoundEndMvpBtnTick(float duration = 0f)
	{
		return null;
	}

	private IEnumerator WaitingPhaseBtnTick()
	{
		return null;
	}

	private void VbadgeWaitingPhaseSetUp()
	{
	}

	private void WaitingPhaseSetUp()
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

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_Hide()
	{
	}
}
