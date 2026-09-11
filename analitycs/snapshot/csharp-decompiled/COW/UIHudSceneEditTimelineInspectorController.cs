using System.Collections.Generic;
using COW.GamePlay;
using COW.GamePlay.UGCRuntime;
using GCommon;

namespace COW;

public class UIHudSceneEditTimelineInspectorController : UIPopupWindowController
{
	private class NavigateInfo
	{
		public NPDBPIJFAHH Config;

		public List<ItemEditAttributeUIData_V2> Datas;

		public bool IsValid()
		{
			return false;
		}
	}

	private UIHudSceneEditTimelineInspectorView m_View;

	private SceneEditObjectBase mModifyObject;

	private NavigateInfo m_CurNavigateInfo;

	private Dictionary<string, UIBaseController> m_AttributeItemUI;

	private Dictionary<long, IUISceneEditItemAttributeRefreshView> m_PropIDMappingView;

	private List<UIBaseController> m_AttributeItemUIList;

	private UISceneEditItemAttributeEditMode m_EditMode;

	private Stack<NavigateInfo> m_AttributeConfigStack;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	private void OnRefreshAttributeUI(object[] data)
	{
	}

	private void OnRefreshSingleAttributeUI(object[] data)
	{
	}

	private void OnAttributeContainerReposition()
	{
	}

	private void OnAttributeItemReposition()
	{
	}

	public void RefreshItemInfo(NPDBPIJFAHH attributeConfig, List<ItemEditAttributeUIData_V2> uiDatas, SceneEditObjectBase objectBase)
	{
	}

	public void RefreshSingleUIByConfig(ItemEditAttributeUIData_V2 uiData)
	{
	}

	private void NavigateToSubMenu(NPDBPIJFAHH attributeConfig, List<ItemEditAttributeUIData_V2> uiDatas)
	{
	}

	private void NavigateBackToParentMenu()
	{
	}

	public void CreateAttributeItemUI(ItemEditAttributeUIData_V2 uiData, int siblingIndex = -1)
	{
	}

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	private void OnCloseButtonClick()
	{
	}

	public void OnSyncUGCEntityProperty(long propertyIndex, UGCSimpleValue newValue)
	{
	}

	public void SetInspectorEditMode(UISceneEditItemAttributeEditMode mode)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_Show()
	{
	}

	public void _003C_003EiFixBaseProxy_Hide()
	{
	}
}
