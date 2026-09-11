using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIQuickMessagePreviewController : UIBaseController, IEasyList
{
	public enum EPreviewType
	{
		None,
		DetailTip,
		Reward,
		Preview
	}

	private UIQuickMessagePreviewView m_View;

	public EPreviewType m_PreviewType;

	public string DetailTipDescription;

	private const float SCROLLVIEW_SCALE = 3.4f;

	private VoicePackagePreviewInfo m_VoicePackagePreviewData;

	private ResourceID m_ItemIconRes;

	private UIQuickMessagePreviewItemController m_CurrentPlayingItem;

	private UIQuickMessageDetailTipItemController m_CurrentPlayingDetailTipItem;

	private UIQuickMessageRewardItemController m_CurrentPlayingRewardItem;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetVoicDescInfo(VoicePackagePreviewInfo voicePackagePreviewData)
	{
	}

	public void SetItemIconRes(ResourceID itemIconRes)
	{
	}

	public void RefreshUI(List<uint> itemIds, EPreviewType type, string detailTipDescription = "")
	{
	}

	public void SetPreviewScale(Vector3 scale)
	{
	}

	private void AdjustPreviewScrollviewPosition(int itemCount)
	{
	}

	private void RefreshRewardItemView(uint customizationItemId)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public void NotifyVoicePlayStart(UIQuickMessagePreviewItemController newPlayingItem)
	{
	}

	public void NotifyVoicePlayStop(UIQuickMessagePreviewItemController stoppedItem)
	{
	}

	public void NotifyVoicePlayStart(UIQuickMessageDetailTipItemController newPlayingItem)
	{
	}

	public void NotifyVoicePlayStop(UIQuickMessageDetailTipItemController stoppedItem)
	{
	}

	public void NotifyVoicePlayStart(UIQuickMessageRewardItemController newPlayingItem)
	{
	}

	public void NotifyVoicePlayStop(UIQuickMessageRewardItemController stoppedItem)
	{
	}

	public void AddPreviewPanelDepth(int delta)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
