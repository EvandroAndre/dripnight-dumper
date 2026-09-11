using System;
using COW.Gameplay.UGC;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIUGCMapItemController : UIBaseController, IUIModelDataChangeObserver, UITable2.IUITable2Item
{
	private sealed class _003C_003Ec__DisplayClass33_0
	{
		public UGCMapLabelConfig mapLabelConfig;

		internal void _003CRefreshKolMap_003Eb__0()
		{
		}
	}

	private UIUGCMapItemView m_View;

	private UIModelSceneEdit m_Model;

	private UIModelMapOpeningInfo m_MapModel;

	private SceneEditSlotInfo m_Info;

	private Action m_OnClickAction;

	private bool m_NeedCheckDuoVersion;

	private UINavigationUtil.UINavigationFrom m_From;

	private string m_FromInfo;

	protected int m_Table2ItemIndex;

	private UIUGCHotIndicatorController m_HotIndicatorCtrl;

	private EditorConnectionMode m_OfflineMode;

	public SceneEditSlotInfo Info => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OpenWorkshopDetail()
	{
	}

	private void ShowLockedTip()
	{
	}

	private void OnBtnClick()
	{
	}

	private void RefreshDuoVersion(object[] data)
	{
	}

	public object SetTable2ItemData(int index, object data, object viewState)
	{
		return null;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void RefreshLastPlayTxt(SceneEditSlotInfo info)
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

	private void RefreshLabelHeatCount(ulong count)
	{
	}

	private void RefreshCDNMap(SceneEditSlotInfo slotInfo)
	{
	}

	private void RefreshCDNMapIcon(string url)
	{
	}

	private void RefreshCDNMapIcon(SceneEditSlotInfo info)
	{
	}

	private void RedepthMiniMapPanel()
	{
	}

	private void ReSizeMapSize()
	{
	}

	private void RefreshKolPanelDepth(int depth)
	{
	}

	private void RefreshKolMap(uint[] idArray)
	{
	}

	private void RefreshSubscribeState(SceneEditSlotInfo slotInfo)
	{
	}

	private void RefreshLockCon()
	{
	}

	private void RefreshSelect(SceneEditSlotInfo info)
	{
	}

	private void RefreshOfflineTag(SceneEditSlotInfo info)
	{
	}

	public void SetPosition(Vector2 position)
	{
	}

	public void SetTable2Visible(bool visible)
	{
	}

	public void SetOfflineMode(EditorConnectionMode offlineMode)
	{
	}

	public void SetOfflineData(SceneEditSlotInfo info, UINavigationUtil.UINavigationFrom from, string fromInfo)
	{
	}

	public void SetFromInfo(string fromInfo)
	{
	}

	private void RefreshLocalMap(SceneEditSlotInfo info)
	{
	}

	public void RefreshOfflineTip(bool show)
	{
	}

	private void _003CRefreshCDNMapIcon_003Eb__28_0()
	{
	}

	private void _003CRefreshCDNMapIcon_003Eb__29_0()
	{
	}

	private void _003CRefreshCDNMapIcon_003Eb__29_1()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
