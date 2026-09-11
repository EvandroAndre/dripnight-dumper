using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class UISceneEditTemplateMapItemController : UIEasyListItemController, IUIModelDataChangeObserver
{
	private UISceneEditTemplateMapItemView m_View;

	private UIModelSceneEdit m_ModelSceneEdit;

	private SceneEditSlotInfo m_SlotInfo;

	private EMAP_Type m_EMapType;

	private EUGCScene m_EScene;

	private UISceneEditUGCCenterController.ETabIndex m_ETabIndex;

	private List<UIWorkshopModeTagController> m_Tags;

	private UIUGCHotIndicatorController m_IndicatorController;

	private UIUGCLikeIndicatorController m_LikeIndicatorController;

	public Action<SceneEditSlotInfo> OnClickMap;

	public string ShareCode => null;

	public string LongShareCode => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnBtnClick()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	public void SetUIData(UISceneEditTemplateMapInfo info, EMAP_Type type, UISceneEditUGCCenterController.ETabIndex index)
	{
	}

	private void RefreshSpecialState(SceneEditSlotInfo info, bool isNormal = false)
	{
	}

	private void RefreshCDNMapIcon(string url)
	{
	}

	private void ReSizeMapSize()
	{
	}

	private void RefreshCDNMapIcon(SceneEditSlotInfo info)
	{
	}

	private bool NeedSkipTag(string tagKey)
	{
		return false;
	}

	private void RefreshTags(uint[] tagsInfo, uint[] limitTagsInfo)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void _003CRefreshCDNMapIcon_003Eb__20_0()
	{
	}

	private void _003CRefreshCDNMapIcon_003Eb__22_0()
	{
	}

	private void _003CRefreshCDNMapIcon_003Eb__22_1()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
