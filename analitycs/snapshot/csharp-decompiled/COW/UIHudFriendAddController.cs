using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudFriendAddController : UIBaseController
{
	private UIHudFriendaddView m_View;

	private UIBaseProfileInfoController m_Profile;

	private BHGGAEEHJCO m_PlayerId;

	private ulong m_BindAccountID;

	private string m_nickName;

	private bool m_IsFriend;

	private HashSet<ulong> m_ReportedID;

	private bool IsMute;

	private Vector3 m_VoicePos;

	private string m_LockRegion;

	private bool m_IsWishContainerOpen;

	private bool m_IsStickerContainerOpen;

	private UIHudCabinWaitingWishController m_HudCabinWaitingWishController;

	private UIHudCabinWaitingStickerController m_HudCabinWaitingStickerController;

	private float m_AutoHideTimeSec;

	private UIRightReigonClickMask m_ClickMask;

	private int m_CachedTime;

	private UIHudHighlightTargetPlayerController m_HighlightTargetPlayerController;

	private float m_TimerStart;

	private int m_LastTimerValue;

	private UIModelMatch m_ModelMatch;

	private EInGameFriendAddType m_InGameFriendAddType;

	private uint m_ID;

	public EInGameFriendAddType InGameFriendAddType => EInGameFriendAddType.Normal;

	private bool IsReportedSuccess => false;

	private bool UseLowProfileInfo => false;

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

	private void Update()
	{
	}

	private void UpdateTimer()
	{
	}

	public bool TimeCheck()
	{
		return false;
	}

	public void UpdateSecondTime()
	{
	}

	private void InitUiState()
	{
	}

	public void BindPlayer(BHGGAEEHJCO player_id, EInGameFriendAddType eInGameFriendAddType = EInGameFriendAddType.Normal, uint id = 0u)
	{
	}

	private void ResetAutoHide()
	{
	}

	private void onAddBtnClicked()
	{
	}

	private void onReportClicked()
	{
	}

	private void RefreshReport()
	{
	}

	private void onMuteClicked()
	{
	}

	private void onWishClicked()
	{
	}

	private void onStickerClicked()
	{
	}

	private void RefreshMute()
	{
	}

	protected virtual void OnReportCheatSent(object[] param)
	{
	}

	private void OnStickerChatHide(object[] data)
	{
	}

	private void OnCabinWaitingEnd()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void HideSticker()
	{
	}

	private void HideWishCon()
	{
	}

	private void OnMuteStateChange(object[] data)
	{
	}

	public void SetHighlightCtrl(UIHudHighlightTargetPlayerController ctrl)
	{
	}

	private void OnLikeBtnClick()
	{
	}

	private void RefreshLikeBtn()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
