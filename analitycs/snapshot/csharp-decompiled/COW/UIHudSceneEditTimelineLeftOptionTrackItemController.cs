using System;
using COW.GamePlay;
using GCommon;

namespace COW;

public class UIHudSceneEditTimelineLeftOptionTrackItemController : UIBaseController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<SceneEditObjectBase> _003C_003E9__5_0;

		public static Action<SceneEditObjectBase> _003C_003E9__5_1;

		internal void _003COnClickBtnTrackHandler_003Eb__5_0(SceneEditObjectBase editObj)
		{
		}

		internal void _003COnClickBtnTrackHandler_003Eb__5_1(SceneEditObjectBase editObj)
		{
		}
	}

	private UIHudSceneEditTimelineLeftOptionTrackItemView m_View;

	private UGCTimelineEditTracksConfig m_trackConfig;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(UGCTimelineEditTracksConfig trackConfig)
	{
	}

	private void OnClickBtnTrackHandler()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
