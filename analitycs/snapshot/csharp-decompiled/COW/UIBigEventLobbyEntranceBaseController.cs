using GCommon;
using proto;

namespace COW;

public class UIBigEventLobbyEntranceBaseController : UIBaseController, IUIModelDataChangeObserver
{
	protected UIBigEventLobbyEntranceBaseView m_View;

	protected ELimitedEvent.EventID m_EventId;

	protected EActivity.SubType m_ActivitySubType;

	private uint m_TipTypeValue;

	protected UITipsNormalController m_TipV2Ctrl;

	protected UICountDownController m_CountDownCtrl;

	protected UIModelBigEvent m_ModelBigEvent;

	protected UIModelLobbyEventBubble m_UIModelLobbyEventBubble;

	protected uint m_WaitOpenTime;

	protected uint m_EntranceCloseTime;

	protected EBigEventIntroTiming m_IntroTimingState;

	protected uint m_OverHintHideKey;

	private UINewDownloadInfoController m_DownloadCtrl;

	private float m_NextCheckTime;

	private UIModelOptionalDownload m_ModelDownload;

	protected uint m_LobbyOpenAniamtionKey;

	public UIBigEventLobbyEntranceBaseView BaseView
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public virtual ELimitedEvent.EventID GetBigEventId()
	{
		return ELimitedEvent.EventID.EventID_NONE;
	}

	public virtual EActivity.SubType GetActivitySubType()
	{
		return EActivity.SubType.SubType_NONE;
	}

	protected virtual UIModelBigEvent.EBigEventEntranceID GetEntranceId()
	{
		return UIModelBigEvent.EBigEventEntranceID.Main;
	}

	public virtual uint GetTipTypeValue()
	{
		return 0u;
	}

	public virtual bool IsNoWarmUp()
	{
		return false;
	}

	public virtual string GetClickSoundId()
	{
		return null;
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public virtual void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public virtual uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	protected virtual UIBigEventLobbyEntranceBaseView GetUIBigEventLobbyEntranceView()
	{
		return null;
	}

	public virtual EV2NavigationPageType GetPageType()
	{
		return EV2NavigationPageType.None;
	}

	public virtual bool NeedShowShowBigEventIntro()
	{
		return false;
	}

	protected virtual bool ShowBigEventIntroIfNeed(EBigEventIntroTiming timing)
	{
		return false;
	}

	protected virtual bool ShowBigEventIntroOverHintIfNeed(ELimitedEvent.EventState eventState)
	{
		return false;
	}

	protected virtual void GotoNavigation()
	{
	}

	public virtual void OnBtnEntranceClick()
	{
	}

	protected virtual void LogClick()
	{
	}

	public uint GetNoWarmUpEntranceOpenTime()
	{
		return 0u;
	}

	public uint GetEntranceCloseTime()
	{
		return 0u;
	}

	protected virtual void SetBigEventCountDown(ELimitedEvent.EventState eventState)
	{
	}

	public virtual ELimitedEvent.EventState RefreshBigEventEntranceState()
	{
		return ELimitedEvent.EventState.EventState_NONE;
	}

	public virtual void OnEnterWarmUpState()
	{
	}

	public virtual void OnEnterProcessState()
	{
	}

	public virtual void OnEnterSettleState()
	{
	}

	public virtual bool IsShowRedPointTip()
	{
		return false;
	}

	private void FixedUpdate()
	{
	}

	private void RefreshDownloadState()
	{
	}

	private void OnDownloadStateChangeCallback()
	{
	}

	protected void SetDownloadContainerVisable(bool isShow)
	{
	}

	public virtual void ResetBubble()
	{
	}

	public virtual void ResetCountdownBubbleContainer(bool isShow)
	{
	}

	protected virtual bool ShowV2GiftIcon()
	{
		return false;
	}

	protected virtual bool ShowV2RedPoint()
	{
		return false;
	}

	private void RefreshV2RedPoint()
	{
	}

	protected virtual uint GetForcedRedPointTimes()
	{
		return 0u;
	}

	protected bool ShowForcedRedPoint()
	{
		return false;
	}

	public float PlayLobbyOpenAmimation()
	{
		return 0f;
	}

	protected virtual void PlayLobbyOpenSound()
	{
	}

	protected virtual void OnLobbyOpenAnimationFinished()
	{
	}

	private void _003CShowBigEventIntroOverHintIfNeed_003Eb__34_0()
	{
	}

	private void _003COnBtnEntranceClick_003Eb__36_0()
	{
	}

	private void _003CSetBigEventCountDown_003Eb__40_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
