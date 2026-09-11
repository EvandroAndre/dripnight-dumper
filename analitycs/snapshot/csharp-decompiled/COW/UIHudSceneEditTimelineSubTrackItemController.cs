using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudSceneEditTimelineSubTrackItemController : UIBaseController
{
	private UIHudSceneEditTimelineSubTrackItemView m_View;

	private UIHudSceneEditTimelineSubTrackMgrPanelController.SubTrackInfo m_subTrackInfo;

	private List<UIHudSceneEditTimelineSubTrackItemController> m_ChildTrackProps;

	private bool m_IsExpand;

	private Vector3 m_defaultPos;

	private int m_defaultFrameWidth;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void SetViewData(UIHudSceneEditTimelineSubTrackMgrPanelController.SubTrackInfo subTrackInfo)
	{
	}

	public void SetShowStyle(bool expand)
	{
	}

	private void OnClickAddSubTrackHandler()
	{
	}

	private void OnClickRemoveSubTrackHandler()
	{
	}

	private void OnArrowClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
