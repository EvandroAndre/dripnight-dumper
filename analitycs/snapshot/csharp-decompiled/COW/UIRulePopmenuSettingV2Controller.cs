using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UIRulePopmenuSettingV2Controller : UIBaseController, IUIRuleBindVar
{
	private UIRulePopmenuSettingV2View m_View;

	public CPopMenuData Data;

	public UIModeEditGeneralComponentHelper GeneralHelper;

	private UIPopMenuSmallControler m_PopMenu;

	private List<PopMenuData> m_PopMenuList;

	private string m_CurrentSelection;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	protected void OnEnable()
	{
	}

	public void SetViewData(CPopMenuData data, float width, UIModeEditGeneralComponentHelper parentGeneralHelper)
	{
	}

	private void GeneratePopList()
	{
	}

	protected virtual void SelectItemCallback(object data)
	{
	}

	private void SetValue(int newValue)
	{
	}

	private int GetValueAsIndex()
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

	private bool _003CGetValueAsIndex_003Eb__16_0(CPopMenuData.PopMenuItem item)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
