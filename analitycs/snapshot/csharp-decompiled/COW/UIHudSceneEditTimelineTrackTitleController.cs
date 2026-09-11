using System.Collections.Generic;
using COW.Gameplay.UGC;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudSceneEditTimelineTrackTitleController : UIBaseController
{
	private UIHudSceneEditTimelineTrackTitleView m_View;

	private bool m_IsExpand;

	private List<UIHudSceneEditTimelineTrackTitleController> m_ChildrenCtrls;

	private UGCTimelineEditorTrackBaseWarp m_CurrTrack;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	private void OnRefreshWarningIconHandler(object[] data)
	{
	}

	protected override void OnUIDestory()
	{
	}

	public override void Hide()
	{
	}

	public void SetTrackData(UGCTimelineEditorTrackBaseWarp currTrack)
	{
	}

	private void OnClickChangeNameHandler()
	{
	}

	private void OnClickWarningTipHandler()
	{
	}

	private void OnClickArrowHandler()
	{
	}

	private Quaternion GetArrowRotation()
	{
		return default(Quaternion);
	}

	public void SetSelectTrack(UGCTimelineEditorTrackBaseWarp trackWarp)
	{
	}

	public void RefreshSubTrack()
	{
	}

	public void SetExpandSubTrack(bool expand)
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

	public void _003C_003EiFixBaseProxy_Hide()
	{
	}
}
