using System.Collections.Generic;
using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIRulePopmenuWithPickerSettingController : UIBaseController, IUIRuleBindVar
{
	private UIRulePopmenuWithPickerSettingV2View m_View;

	private SceneEditAgent m_Agent;

	public CPopMenuData Data;

	public UIModeEditGeneralComponentHelper GeneralHelper;

	private UIPopMenuSmallControler m_PopMenu;

	private List<PopMenuData> m_PopMenuList;

	private string m_CurrentSelection;

	private SceneEditAgent Agent => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetViewData(CPopMenuData data, float width, UIModeEditGeneralComponentHelper parentGeneralHelper)
	{
	}

	private void GeneratePopList()
	{
	}

	private void SelectItemCallback(object data)
	{
	}

	private void SetValue(int newValue)
	{
	}

	private int GetValueAsIndex()
	{
		return 0;
	}

	private int CheckAndFixIndex(int index)
	{
		return 0;
	}

	public int GetModeVariableID()
	{
		return 0;
	}

	public UIWidget GetBindWidget()
	{
		return null;
	}

	protected void OnValueChanged()
	{
	}

	protected void OnItemsChanged()
	{
	}

	public void OnClickPickButton()
	{
	}

	public void OnGetEntityChange(SceneEditObjectBase editObj)
	{
	}

	private bool _003CGetValueAsIndex_003Eb__16_0(CPopMenuData.PopMenuItem item)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
