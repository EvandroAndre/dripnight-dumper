using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudSpeedupAreaController : UIHudButtonBaseController
{
	private const string ICON_SPEEDUP = "UI_icon_speedup";

	private string ICON_SPEEUPCHOOSE;

	private const string ICON_SKYDASHING = "UI_icon_AutoSliding";

	private const string ICON_SKYDASHINGCHOOSE = "UI_icon_AutoSliding_choose";

	private const string ICON_Skateboarding = "UI_icon_AutoSliding";

	private const string ICON_FLIGHT_SKYDASHING = "UI_icon_Mounts_Accelerate";

	private const string ICON_FLIGHT_SKYDASHINGCHOOSE = "UI_icon_Mounts_Accelerate_Choose";

	private const string FOLLOW_EMOTE_STAND_TIPS = "TXT_OB11_JRW_EMOTE_WAITINGLAND_TIP01";

	private string m_IconUse;

	private UIHudSpeedupAreaView m_View;

	private bool m_IsHighlight;

	private bool m_bIsPullingBolt;

	private bool m_ShowingInAirBtnSprite;

	private uint m_ClickSkyDashingBtnCount;

	private UIEventTrigger m_Trigger;

	private BoxCollider m_Collider;

	private float m_CdTime;

	private float m_LeftTime;

	private bool m_UseNewRunning;

	private float m_CurrentAlpha;

	public const uint VISIBILITY_STATE_CARRY = 268435456u;

	private const int FOLLOW_EMOTE_PASSENGER_TICK_INTERVAL = 2;

	private BHGGAEEHJCO m_PassengerTargetPlayerID;

	private bool m_IsFollowHide;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public GameObject GetCollider()
	{
		return null;
	}

	public void SetAlpha(float alpha)
	{
	}

	public void UpdateAreaState()
	{
	}

	protected override void OnUIInit()
	{
	}

	private void OpenFollowEmoteCancelHud()
	{
	}

	private void CloseFollowEmoteCancelHud()
	{
	}

	private bool IsFollowEmoteMode()
	{
		return false;
	}

	private bool CanShowFollowEmoteButtons(Player player)
	{
		return false;
	}

	private bool CanShowFollowEmoteContainer()
	{
		return false;
	}

	private bool IsInFollowEmoteState(Player player)
	{
		return false;
	}

	private bool IsFollowEmoteButtonBlocked(Player player, bool allowDancePoolCancel = false)
	{
		return false;
	}

	private bool RefreshFollowEmoteButtonsVisibility(Player localPlayer = null)
	{
		return false;
	}

	private void InitFollowEmoteButtons()
	{
	}

	private void OnFollowMessageResponse()
	{
	}

	private void TickFollowEmotePassengerCandidate()
	{
	}

	private Player GetLobbySocialAreaFollowPassengerTarget(Player localPlayer)
	{
		return null;
	}

	private void SetFollowEmotePassengerTarget(BHGGAEEHJCO pid)
	{
	}

	private bool CanFollowEmotePassengerTarget(Player target)
	{
		return false;
	}

	private bool IsFollowEmotePassengerTargetBlocked(Player target)
	{
		return false;
	}

	private bool IsPlayerInFollowEmoteViewDistance(Player target)
	{
		return false;
	}

	protected override void OnUIDestory()
	{
	}

	private void InitIsNewUI()
	{
	}

	private void OnLobbySocialHudStateChanged(bool visible)
	{
	}

	private void OnUseNewRunningChange(object[] data)
	{
	}

	private void OnChargeStateChange(bool data)
	{
	}

	private void OnChangeCancelVisible(object[] data)
	{
	}

	private void OnGB_GPKickBallBtnPressed(bool pressed)
	{
	}

	private void OnCarryStateChanged()
	{
	}

	private void OnSightingStateChanged(object[] data)
	{
	}

	private void OnPullBoldUnderSightingChanged(object[] data)
	{
	}

	private void Update()
	{
	}

	protected override string GetMappingName()
	{
		return null;
	}

	private void SetHightlight(bool highlight, Player localPlayer)
	{
	}

	private void OnTutorialRunFaster(object[] data)
	{
	}

	private void OnTutorialSliding(object[] data)
	{
	}

	private void HideSlidingTutorial()
	{
	}

	private void OnLocalPlayerStateChange(GEvent data)
	{
	}

	private void OnLocalPlayerAdd(object[] data)
	{
	}

	private void OnLocalSpectatorAdd(object[] data)
	{
	}

	private bool IsInAir(Player.IGJPHDANPJD state)
	{
		return false;
	}

	public void UpdateStateByLateCreated()
	{
	}

	private void UpdateState(Player localPlayer = null)
	{
	}

	private bool UpdateShowing(Player.IGJPHDANPJD state)
	{
		return false;
	}

	private void UpdateIconSprite(Player.IGJPHDANPJD state, bool inAir, bool haveFlight)
	{
	}

	private void UpdateIconSprite(string sprite, bool useHighlightColor = false)
	{
	}

	private void OnLockUpdate(object[] data)
	{
	}

	private bool UpdateLock(Player.AALGCBFJHJM newValue, Player.IGJPHDANPJD state)
	{
		return false;
	}

	private void ShowSkateboardDashTutorial()
	{
	}

	private void OnLocalPlayerSkateboardDashCd(object[] param)
	{
	}

	private void ShowCdBar(float cd, float remain)
	{
	}

	private void OnClick()
	{
	}

	private void OnFollowEmoteDriverBtnClick()
	{
	}

	private void OnFollowEmotePassengerBtnClick()
	{
	}

	private void UpdateClickSkyDashingBtnCount()
	{
	}

	private void OnLocalPlayerTeamParachuteModeChange(object[] param)
	{
	}

	private void OnCabinWaitingEnd()
	{
	}

	protected override void OnBtnDown()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnBtnDown()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
