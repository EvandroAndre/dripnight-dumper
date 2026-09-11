using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIBooyahPassRewardPreviewController : UIPreviewNavigationController, IUIModelDataChangeObserver, IEasyList
{
	private const string NAVIGATION_TITLE = "RewardPreviewNavigation";

	private UIBooyahPassRewardPreviewView m_View;

	private UIModelBooyahPass m_ModelBooyahPass;

	private bool m_HasInitData;

	private List<UIBooyahPassPreviewBaseItemController> m_FPPreviewBaseItemCtrlList;

	private List<UIBooyahPassPreviewBaseItemController> m_PPPreviewBaseItemCtrlList;

	private List<BooyahPassBaseItemData> m_FPBaseItemDataList;

	private List<BooyahPassBaseItemData> m_PPBaseItemDataList;

	private int m_BpDiscountSpriteWidth;

	private int m_SaleBgWidth;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	protected override FrontendPreviewType GetPreviewUIType()
	{
		return FrontendPreviewType.Lobby;
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void ShowBigReward()
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	protected override void OnHelpButtonClick(object[] param)
	{
	}

	private void OnUnlockBtnClick()
	{
	}

	private void OnPreviewItem(object[] data)
	{
	}

	private void RefreshView()
	{
	}

	private void RefreshBtnView()
	{
	}

	private void InitPreviewItemDataList()
	{
	}

	private void OnDowloadFinished(ResultTextureInfo textureInfo)
	{
	}

	private void RefreshItemView()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public void _003C_003EiFixBaseProxy_OnHelpButtonClick(object[] P0)
	{
	}
}
