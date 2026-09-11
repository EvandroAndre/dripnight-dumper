using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIHudSceneEditOfflineModeMainController : UIPopupWindowController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__8_0;

		public static Func<KeyValuePair<string, SceneEditSlotInfo>, bool> _003C_003E9__13_0;

		internal void _003COnCloseButtonClick_003Eb__8_0()
		{
		}

		internal bool _003CInitOfflineModes_003Eb__13_0(KeyValuePair<string, SceneEditSlotInfo> x)
		{
			return false;
		}
	}

	private UIHudSceneEditOfflineModeMainView m_View;

	private SceneEditSlotInfo m_TrainingGroundInfo;

	private List<UIUGCMapItemController> m_OfflineModes;

	private UINavigationUtil.UINavigationFrom m_From;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	public void SetFrom(UINavigationUtil.UINavigationFrom from)
	{
	}

	private void OnCloseButtonClick()
	{
	}

	private void OnMoreButtonClick()
	{
	}

	private void OnHelpButtonClick()
	{
	}

	private void OnTrainingGroundButtonClick()
	{
	}

	private void OnGroupChangeNtf(object[] data)
	{
	}

	private void InitOfflineModes()
	{
	}

	private void InitTrainingGroundMode(SceneEditSlotInfo slotInfo)
	{
	}

	private void RefreshMapNameTxt(string name)
	{
	}

	private void RefreshMapModeTxt(SceneEditSlotInfo info)
	{
	}

	private void RefreshLikeLabel(ulong likeCount, ulong dislikeCount, float likeRate)
	{
	}

	private void RefreshLabelSubscribeCount(SceneEditSlotInfo info)
	{
	}

	private void RefreshCDNMapIcon(string url)
	{
	}

	private void ReSizeMapSize()
	{
	}

	private void RedepthMiniMapPanel()
	{
	}

	public void CreataAge18UI()
	{
	}

	private void _003CRefreshCDNMapIcon_003Eb__19_0()
	{
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
