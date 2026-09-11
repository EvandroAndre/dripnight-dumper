using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIVirtualBrandController : UINavigationController, IUIModelDataChangeObserver, IEasyList
{
	private BitArrayBoolean m_bIsDataReady;

	private UIVirtualBrandView m_view;

	private UIModelVirtualBrand m_model;

	private List<UIVirtualBrandItemController> m_gridItems;

	private const uint IS_DATA_READY_DESC = 1u;

	private const uint IS_DATA_READY_INFO = 2u;

	private const int GRID_OR_EASYLIST_COUNT_LIMIT = 4;

	public const string HELP_RULE_STRING = "T_36_DY_VB_RULES";

	public const string TITLE_NAME = "T_36_DY_VIRTUALBRAND";

	protected override void OnUIInit()
	{
	}

	protected override void OnHelpButtonClick(object[] param)
	{
	}

	private void RefreshEasyList()
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	public override EFrontendBGMType GetBGMType()
	{
		return EFrontendBGMType.NONE;
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
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

	public void _003C_003EiFixBaseProxy_OnHelpButtonClick(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public EFrontendBGMType _003C_003EiFixBaseProxy_GetBGMType()
	{
		return EFrontendBGMType.NONE;
	}
}
