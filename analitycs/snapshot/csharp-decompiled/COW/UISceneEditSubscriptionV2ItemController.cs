using System.Collections.Generic;
using GCommon;

namespace COW;

public class UISceneEditSubscriptionV2ItemController : UIEasyListItemController, IUIModelDataChangeObserver
{
	private UISceneEditSubscriptionV2ItemView m_View;

	private UIModelSceneEdit m_ModelSceneEdit;

	protected SceneEditSlotInfo m_SlotInfo;

	private List<UIWorkshopModeTagController> m_Tags;

	private UIUGCHotIndicatorController m_IndicatorController;

	private UIUGCLikeIndicatorController m_LikeIndicatorController;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected virtual void OnBtnClick()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	public void SetUIData(UISceneEditSubscriptionV2Item info, EMAP_Type type, UISceneEditUGCCenterController.ETabIndex index)
	{
	}

	private void SetShowEmpty()
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

	private void _003CRefreshCDNMapIcon_003Eb__13_0()
	{
	}

	private void _003CRefreshCDNMapIcon_003Eb__15_0()
	{
	}

	private void _003CRefreshCDNMapIcon_003Eb__15_1()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
