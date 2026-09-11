using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudMovingJoystickController : UIBaseController
{
	private UIHudMovingJoystickView m_View;

	private Vector3 m_DefaultPos;

	private float m_BGRangeRadius;

	private UICamera m_UICamera;

	private Camera m_Camera;

	private float dist;

	private bool m_NeedFastRun;

	private bool m_IsTouchUp;

	private Vector3 m_Position;

	private Vector3 m_Rotation;

	private float m_MaxJoyLength;

	private float multiscale;

	private bool m_IsInSpeedUp;

	private bool m_HasTriggeredJoystickTouchEvent;

	private bool m_IsFixedMode;

	private Vector3 m_FixedJoystickCenterScreenPos;

	private bool m_FixedJoystickCenterInitialized;

	private UIWidget m_JoystickBGWidget;

	private const string SocialLobbyGuideGlowPrefsKey = "UIHudMovingJoystick_SocialLobbyGuideGlow_";

	private ulong m_SocialLobbyGuideGlowPrefsUserID;

	private string m_SocialLobbyGuideGlowPrefsCachedKey;

	private VisualInstanceHolder m_SocialLobbyGuideGlowHolder;

	private bool m_HasNinthTokenVFXFlyFinished;

	private string commonstr;

	private string upstr;

	private string skyDashCommonStr;

	private string skyDashStr;

	private string horseDashStr;

	private bool m_UseNewRunning;

	public const float SCREEN_2TO1_OR_4TO3_RADIO = 1.4f;

	private bool m_IsFollowHide;

	private UIHudSlideMoveTutorialController m_SlideMoveTutCtrl;

	private uint m_DelayHideSlideMoveTicket;

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

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void SetLobbyMovingJoystickInputEnable(bool enable)
	{
	}

	private string GetSocialLobbyGuideGlowPrefsKey()
	{
		return null;
	}

	private void TryShowSocialLobbyGuideGlow()
	{
	}

	private void OnNinthTokenVFXFlyFinished()
	{
	}

	private void OnSocialLobbyJoystickTouched()
	{
	}

	private void ReleaseSocialLobbyGuideGlow()
	{
	}

	private void OnAddPlayer(GEvent data)
	{
	}

	private void OnUseNewRunningChange(object[] data)
	{
	}

	private void OnTutorialGuideShow(object[] data)
	{
	}

	private void OnShowGetOffSlideGuide()
	{
	}

	private void OnCloseGetOffSlideGuide()
	{
	}

	public void ResetDefaultPos(Vector3 v)
	{
	}

	public void RefreshMovingJoystickModeForLobbySocialArea()
	{
	}

	private void RefreshMovingJoystickMode(bool forceRefresh = false, bool useCurrentHudPos = false)
	{
	}

	private void ClearFixedJoystickInputData()
	{
	}

	private void RefreshFixedJoystickInputData(bool useCurrentHudPos = false)
	{
	}

	private void SyncFixedJoystickDirection(UserControlAxisData axisData)
	{
	}

	private Vector3 GetJoystickOriginScreenPos(UserControlAxisData axisData)
	{
		return default(Vector3);
	}

	protected override void OnUIActiveGroupSwitch(UInt128 activeGroup)
	{
	}

	private void SetCurControlModeHudConfig(bool isVehicle)
	{
	}

	private void RefreshVisibleWithControlMode(object[] data)
	{
	}

	private bool CheckInSpeedUpCoillder(UserControlAxisData axisData)
	{
		return false;
	}

	private float GetCanEnterSpeedUpScreenLength()
	{
		return 0f;
	}

	private float GetCanShowSpeedUpScreenLength()
	{
		return 0f;
	}

	private bool CheckPosCanEnterSpeedUp(Vector3 delta)
	{
		return false;
	}

	private bool CheckPosCanShowSpeedUp(Vector3 delta)
	{
		return false;
	}

	private bool CheckPosCanShowSpeedUpCenter(Vector3 delta)
	{
		return false;
	}

	private bool CheckPosCanShowSpeedUpSide(Vector3 delta)
	{
		return false;
	}

	private Vector3 CalLastPos()
	{
		return default(Vector3);
	}

	private bool CheckState()
	{
		return false;
	}

	private void Update()
	{
	}

	private void UpdateForRommSpectator(PHLHIEGPMMK ob)
	{
	}

	private void SetRunningTagView(string spriteName, bool useHighlightColor = false)
	{
	}

	private void StopLocalPlayerFastRunOnDestroyForSocialLobby()
	{
	}

	private void ClearDashByMovingJoyStickState(Player localPlayer)
	{
	}

	private void RequestJoyFastRun(bool flag)
	{
	}

	private void ActiveJoyStick(bool v)
	{
	}

	private void OnLocalPlayerTeamParachuteModeChange(object[] param)
	{
	}

	private void OnShowSlideMoveTut(bool isShow)
	{
	}

	private void OnCabinWaitingEnd()
	{
	}

	private void OnVerticalCameraModeChanged(bool isVertical)
	{
	}

	public void SetMainPhotoSpriteVisible(bool isVisible)
	{
	}

	public UIWidget GetJoystickGuideWidget()
	{
		return null;
	}

	private void _003COnShowSlideMoveTut_003Eb__79_0()
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

	public void _003C_003EiFixBaseProxy_OnUIActiveGroupSwitch(UInt128 P0)
	{
	}
}
