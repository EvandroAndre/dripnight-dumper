using GCommon;
using UnityEngine;

namespace COW;

public class UIHudChatBtnController : UIBaseController
{
	private enum BubbleMode
	{
		None,
		LeaderboardTitle,
		ChatBubbleFist
	}

	public const uint VISIBILITY_STATE_IIV1v1 = 1073741824u;

	public const uint VISIBILITY_STATE_GB_GPGulag = 536870912u;

	public static float MaxDragDis;

	private static float MaxDragDisSquare;

	private static float QuickDragDis;

	private static float QuickDragDisSquare;

	private const string WeaponPoewerIconStar = "UI_WeaponPower_BG_Star";

	private const string ChatBubbleFist_IconSprite = "FF_UI_ingame_hud_Emoji_Fist";

	private const int MuteFlag_CD = 1;

	private const int MuteFlag_UGC = 2;

	private int m_MuteFlags;

	private UIHudChatBtnView m_View;

	private UIWidget m_Widget;

	private uint m_UpdateCDCallID;

	private float m_EndCDTime;

	private bool m_IsPressed;

	private bool m_PressedForMenu;

	private bool m_PressedForRoulette;

	private bool m_CanShowMessageTips;

	private float m_PressTime;

	private Vector3 m_ChatBtnOriginalPos;

	private Vector3 m_ChatBtnStartPos;

	private Vector3 m_ChatBtnPressPos;

	private Vector3 m_CurDirection;

	private Camera m_Camera;

	private bool m_RouletteSwitch;

	private bool m_GlobalTouchEnd;

	private float m_CurQuickChatCD;

	private bool m_InitLeaderboardIcon;

	private BubbleMode m_CurBubbleMode;

	private uint m_BubbleAutoHideCallID;

	private bool m_LeaderboardVisualCached;

	private string m_CachedLeaderboardIconName;

	private string m_CachedLeaderboardStarName;

	private bool m_LocalGiveMeFiveStickerPending;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void InitIsNewUI()
	{
	}

	protected override void OnDestroy()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	public UIWidget GetMaskContainer()
	{
		return null;
	}

	private void OnMessageVisibleChange(object[] data)
	{
	}

	private void OnNewMessageReceived(object[] data)
	{
	}

	private void ShowTutorialQuickChat(object[] data)
	{
	}

	private void InitLeaderboardTitleIcon()
	{
	}

	private void ShowLeaderboardTitleIcon()
	{
	}

	private void OnRecvShowChatBubble(object[] args)
	{
	}

	private void OnLocalGiveMeFiveStickerSent()
	{
	}

	private void OnRecvGiveMeFiveStickerResult(object[] args)
	{
	}

	private bool IsLocalGiveMeFiveStickerResult(object[] args)
	{
		return false;
	}

	private void ApplyChatBubbleVisual()
	{
	}

	private void ApplyLeaderboardVisual()
	{
	}

	private void CacheLeaderboardVisualIfNeeded()
	{
	}

	private void ScheduleAutoHide()
	{
	}

	private void HideBubble()
	{
	}

	private void OnLeaderboardTitleIconClick()
	{
	}

	private void OnTrySendQuickChat(object[] data)
	{
	}

	private void OnItemMarkEnterCD(object[] param)
	{
	}

	private void OnQuickChatStartCD()
	{
	}

	private void OnTextChatStartCD()
	{
	}

	private void QuickChatStartCD()
	{
	}

	private void UpdateCDTime()
	{
	}

	private void ResetCDTime()
	{
	}

	private void EnableChatBtn(bool enable, int muteFlag)
	{
	}

	private void OnChatClick()
	{
	}

	private void ResetChatBtn()
	{
	}

	private void UpdateAxisTouchingThroughArea(object[] data)
	{
	}

	private void OnWeightChanged()
	{
	}

	private void OnRouletteGlobalTouchEnd(object[] data)
	{
	}

	private void OnPlayerDead(object[] data)
	{
	}

	private void OnSwitchObserver(object[] param)
	{
	}

	private void ResetChatCtrl()
	{
	}

	private void Update()
	{
	}

	public void OnUGCMute(bool mute)
	{
	}

	private void RefreshRedTipsView()
	{
	}

	private void RefreshRedTipsView(object[] args)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
