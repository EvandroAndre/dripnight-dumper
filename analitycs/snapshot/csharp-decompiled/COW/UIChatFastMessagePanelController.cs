using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIChatFastMessagePanelController : UIBaseController, IEasyList
{
	private UIChatFastMessagePanelView m_View;

	private List<AroundGameQuickChatData> m_CurrentDataList;

	private ChatChannelInfo m_Data;

	public ChatChannelInfo ChatChannelInfo => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnMaskButtonClick()
	{
	}

	private void RefreshViewData()
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public void SetData(ChatChannelInfo info)
	{
	}

	public void UpdatePanelDepth(int depth)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
