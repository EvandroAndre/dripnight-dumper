using GCommon;

namespace COW;

internal class UIRuleSlidableNumericSettingController : UIBaseController, IUIRuleBindVar
{
	protected UIRuleSlidableNumericSettingView m_View;

	public CRangeData Data;

	public UIModeEditGeneralComponentHelper GeneralHelper;

	private bool m_IsSliderChangedInternally;

	protected string unitText;

	public int ValueChangeCount;

	private void Update()
	{
	}

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

	protected virtual void OnEnable()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public virtual void SetViewData(CRangeData data, float width, UIModeEditGeneralComponentHelper parentGeneralHelper)
	{
	}

	private void OnPlusBtnClick()
	{
	}

	private void OnSubBtnClick()
	{
	}

	protected virtual void OnSliderChanged()
	{
	}

	private void UpdateValueText()
	{
	}

	protected void SetFloatValue(float newValue)
	{
	}

	protected void SetIntValue(int newValue)
	{
	}

	protected virtual void OnValueChanged()
	{
	}

	public int GetModeVariableID()
	{
		return 0;
	}

	public virtual UIWidget GetBindWidget()
	{
		return null;
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
