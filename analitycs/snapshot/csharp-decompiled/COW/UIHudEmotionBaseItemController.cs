using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudEmotionBaseItemController : UIBaseController
{
	private sealed class _003C_003Ec__DisplayClass17_0
	{
		public UIHudEmotionBaseItemController _003C_003E4__this;

		public uint playEmotionID;

		public bool isFollowDanceAnim;

		internal void _003CPlayMoveEmoteInFollowQueue_003Eb__0(bool _)
		{
		}
	}

	private UIHudEmotionItem m_View;

	private uint m_EmotionID;

	private int m_SlotID;

	private bool m_IsLocked;

	private UINewDownloadInfoController m_DownloaderCtrl;

	private const string FOLLOW_EMOTE_PAID_LEADER_TIPS = "T_54_SY_FOLLOWEMOTE_FALSE";

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	private void InitUI()
	{
	}

	public void InitInfo(uint emotionID, int slotID)
	{
	}

	public void RefreshDownloadState()
	{
	}

	private void CloseDownloader()
	{
	}

	private void SetDownloadState(bool needDownload)
	{
	}

	private void SetSlotRotation()
	{
	}

	protected void SetRotation(int index, Transform slotTransform, float rotateValue)
	{
	}

	private void OnBtnEmotionClick()
	{
	}

	private bool HandleFollowEmotePassengerClick(Player localPlayer, EmoteData emotionData)
	{
		return false;
	}

	private void PlayMoveEmoteInFollowQueue(Player localPlayer, uint playEmotionID, bool isFollowDanceAnim)
	{
	}

	private void PlayMoveEmoteInFollowQueueInternal(Player localPlayer, uint playEmotionID, bool isFollowDanceAnim)
	{
	}

	private void OnBtnEmotionClickInternal()
	{
	}

	private bool TryShowSocialLobbyDownloadPopup()
	{
		return false;
	}

	private List<ResourceID> GetNeedDownloadRes()
	{
		return null;
	}

	private void OpenOrRefreshDownloader(List<ResourceID> needDownloadRes)
	{
	}

	private void RefreshDownloadIconSprite(bool showDownloadIcon)
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void _003COnBtnEmotionClick_003Eb__15_0(bool _)
	{
	}

	private void _003COpenOrRefreshDownloader_003Eb__22_0()
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
