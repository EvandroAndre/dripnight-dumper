using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UISceneEditSecondLevelAttributePopupMenu : UIBaseController, IUISceneEditSecondLevelAttributeItem
{
	private UIRulePopmenuSettingV2View m_View;

	public ItemEditAttributeUIDataPopMenu_V2 Data;

	private UIPopMenuSmallControler m_PopMenu;

	private List<PopMenuData> m_PopMenuList;

	private int m_CurrentSelectionIdx;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(ItemEditAttributeUIDataPopMenu_V2 data, float width, float height, float paddingY, int depth)
	{
	}

	private void GeneratePopList()
	{
	}

	protected virtual void SelectItemCallback(object data)
	{
	}

	private void SetValue(MutableValue newValue)
	{
	}

	private void OnClickTip()
	{
	}

	public int GetHeight()
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
