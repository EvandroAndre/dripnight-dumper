using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using COW.GamePlay;
using GCommon;
using UMA;
using UnityEngine;
using proto;

namespace COW;

public class UIHudReplayCtrlController : UIBaseController
{
	public enum HighlightCDNAdSubType
	{
		None,
		FF_Ui_Replay_Highlight,
		FF_Ui_Replay_Mvp_Bg_left01,
		FF_Ui_Replay_Mvp_Bg_left02,
		FF_Ui_Replay_Mvp_Bg_new01,
		FF_Ui_Replay_Mvp_Bg_right01,
		FF_Ui_Replay_Mvp_Bg_right02,
		FF_Ui_Replay_Mvp_end_Bg01,
		FF_Ui_Replay_Mvp_end_Bg02,
		FF_Ui_Replay_Mvp_end_Bg03
	}

	private class ReplayEventTagIcon
	{
		private GameObject go;

		private UIButton button;

		private BoxCollider boxCollider;

		private UISprite icon;

		private float ftime;

		private bool mbTimeEvent;

		public ReplayEventTagIcon(GameObject sprite, Transform parent, string spriteName, Vector3 localPosition, float time, bool result)
		{
		}

		private void OnClick()
		{
		}

		public void Clear()
		{
		}

		public void SetButtonEnabled(bool enabled)
		{
		}

		public float GetTime()
		{
			return 0f;
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__52_0;

		public static Action _003C_003E9__53_0;

		public static UIUtils.OnSavedScreenshot _003C_003E9__68_0;

		internal void _003COnExitClick_003Eb__52_0()
		{
		}

		internal void _003COnResetClick_003Eb__53_0()
		{
		}

		internal void _003CReloadWithPic_003Eb__68_0(bool saved, Texture2D screenshot)
		{
		}
	}

	private sealed class _003COnRenderFinished_003Ed__93 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudReplayCtrlController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003COnRenderFinished_003Ed__93(int _003C_003E1__state)
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

	private sealed class _003CReloadWithPic_003Ed__68 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float timeRatio;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CReloadWithPic_003Ed__68(int _003C_003E1__state)
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

	private sealed class _003CRerenderAvatar_003Ed__91 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudReplayCtrlController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRerenderAvatar_003Ed__91(int _003C_003E1__state)
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

	private UIHudReplayCtrlView m_View;

	private MobileReplayManager m_ReplayMgr;

	private StringBuilder m_StrBuilder;

	private TimeSpan m_TimeSpan;

	private string m_TotalTime;

	private uint m_TickCount;

	private readonly List<uint> REPLAY_EVENT_LIST;

	private List<ReplayEventTagIcon> tagIcons;

	private const string UIReplaySafeZoneIcon = "FF_UI_Replay_Round";

	private const string UIReplayRoundIcon = "FF_UI_Replay_Round";

	private const string UIReplayKillIcon = "UI_Replay_KillShots";

	private const string UIReplayKillIconIndia = "UI_Replay_KillShots_India";

	private const string UIReplayDeathIcon = "UI_Replay_DeathShot";

	private bool m_NeedUpdateProgress;

	private Vector3 m_TopLeftPos;

	private Vector3 m_TopRightPos;

	private bool m_IsScreenPressed;

	private bool m_Show;

	private uint m_DelayCallID;

	private uint m_HighlightVFXDelayCall;

	private bool m_HighlightOver;

	private uint m_DelayHighlightCallId;

	private UIHudHighLightNewSettingCtrlController settingCtrl;

	private const string Level0Spped = "1 x";

	private const string Level1Spped = "2 x";

	private const string Level2Spped = "4 x";

	private const string Level3Spped = "8 x";

	private float m_AcculatedTime;

	private int m_CountDownLabelTime;

	private float m_ConstCountDownLabelTime;

	private bool m_CanCountDown;

	private RenderTexture m_PlayerAvatarRenderTexture;

	private UIMatchResultShare3D m_Share3D;

	private AvatarManager m_AvatarManager;

	private bool m_originalShadowEnabled;

	private bool m_IsLocalPlayerAvatarReady;

	private bool m_GetHighlightEvent;

	private bool[] m_CDNLoadSuccess;

	private Coroutine m_LoadCDNSuccessCoroutine;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void WarmingAnim()
	{
	}

	protected override void OnUIOpen()
	{
	}

	private void DelayShowSingleHighlight()
	{
	}

	private void SetCountDownView()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void InitGameEvent()
	{
	}

	private static string GetReplayKillIcon()
	{
		return null;
	}

	private void OnMinusSpeed()
	{
	}

	private void OnPlusSpeed()
	{
	}

	private void OnExitClick()
	{
	}

	private void OnResetClick()
	{
	}

	private CandidateReporteeData CreateCandidateReporteeData(MatchStats matchStats, string name, ulong accountId, BHGGAEEHJCO playerID, CandidateReporteeType type)
	{
		return null;
	}

	private TeammateStats FindReporteeStats(MatchStats matchStats, ulong accountId)
	{
		return null;
	}

	private TeammateStats FindReporteeStats(List<TeammateStats> stats, ulong accountId)
	{
		return null;
	}

	private void OnReportBtnClick()
	{
	}

	private static bool IsReporteeAlreadyReported(ulong matchId, ulong accountId)
	{
		return false;
	}

	private static bool HasAnyPotentialReportees(MatchStats stats)
	{
		return false;
	}

	private void OnToggleClick()
	{
	}

	private void OnHighLightSettingClick()
	{
	}

	private void SetHighlightUI()
	{
	}

	private void OnHighlightClick()
	{
	}

	private void OnOverlookCamBtnClick()
	{
	}

	private void OnNormalCamBtnClick()
	{
	}

	private void OnSliderChangedManually()
	{
	}

	private void StartReloadCor(float timeRatio)
	{
	}

	private IEnumerator ReloadWithPic(float timeRatio)
	{
		return null;
	}

	private MobileReplayEvent FindNearestEventByTime(float targetTime)
	{
		return null;
	}

	private void OnChange()
	{
	}

	private void StartHide()
	{
	}

	private void CancelHideDelayCall()
	{
	}

	private void OnPlaySpeedChanged(object[] data)
	{
	}

	private void OnStartHighlightVFX(object[] data)
	{
	}

	private void OnHighlightOverCallback(object[] args)
	{
	}

	private void OnHighlightEventClick(object[] args)
	{
	}

	private void OnReplayPressStateChanged(bool isPressed)
	{
	}

	public void StartRecord()
	{
	}

	private void OnStartRecordCallback(bool result, string message)
	{
	}

	private void OnVideoRecordStopCallback(object[] args)
	{
	}

	private void Update()
	{
	}

	private void UpdateRoundBtn()
	{
	}

	private void OnHudReplayStartHide(object[] args)
	{
	}

	private void LoadStartHighlightCDNAd()
	{
	}

	private void LoadInternalHighlightCDNAd()
	{
	}

	private void LoadCDNSuccessCallback(uint subType)
	{
	}

	public bool IsLocalPlayerAvatarReady()
	{
		return false;
	}

	private void InitPlayerAvatarTexture()
	{
	}

	private void StartRenderPlayerAvatar()
	{
	}

	private void RerenderAfterUMAChanged(UMAData data)
	{
	}

	protected IEnumerator RerenderAvatar()
	{
		return null;
	}

	private void OnPlayerAvatarRerender()
	{
	}

	private IEnumerator OnRenderFinished()
	{
		return null;
	}

	private void _003COnUIInit_003Eb__42_0()
	{
	}

	private void _003CDelayShowSingleHighlight_003Eb__45_0()
	{
	}

	private void _003CStartHide_003Eb__71_0()
	{
	}

	private void _003COnStartHighlightVFX_003Eb__74_0()
	{
	}

	private void _003CLoadStartHighlightCDNAd_003Eb__84_0()
	{
	}

	private void _003CLoadStartHighlightCDNAd_003Eb__84_1()
	{
	}

	private void _003CLoadStartHighlightCDNAd_003Eb__84_2()
	{
	}

	private void _003CLoadStartHighlightCDNAd_003Eb__84_3()
	{
	}

	private void _003CLoadStartHighlightCDNAd_003Eb__84_4()
	{
	}

	private void _003CLoadInternalHighlightCDNAd_003Eb__85_0()
	{
	}

	private void _003CLoadInternalHighlightCDNAd_003Eb__85_1()
	{
	}

	private void _003CLoadInternalHighlightCDNAd_003Eb__85_2()
	{
	}

	private void _003CLoadInternalHighlightCDNAd_003Eb__85_3()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
