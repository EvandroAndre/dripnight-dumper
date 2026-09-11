using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using message;

namespace COW;

public class UIHudSceneEditTimelineSubTrackMgrPanelController : UIPopupWindowController
{
	public class SubTrackInfo
	{
		public MHHOHPCLMFB trackType;

		public string trackName;

		public long PropID;

		public string trackValue;

		public List<SubTrackInfo> childTracks;
	}

	private UIHudSceneEditTimelineSubTrackMgrPanelView m_View;

	private List<UIHudSceneEditTimelineSubTrackItemController> m_SubTrackProps;

	private List<SubTrackInfo> m_subTrackInfos;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	protected override void OnUIDestory()
	{
	}

	public void SetDepth(int depth)
	{
	}

	public void SetViewData(MHHOHPCLMFB trackType, SceneEditObjectBase editObject)
	{
	}

	private void OnClickCloseHandler()
	{
	}

	public void RefreshSubTrack()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_Show()
	{
	}

	public void _003C_003EiFixBaseProxy_Hide()
	{
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
