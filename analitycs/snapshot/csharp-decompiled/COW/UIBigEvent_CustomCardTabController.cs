using GCommon;

namespace COW;

public class UIBigEvent_CustomCardTabController : UIBaseController, IBigEventTemplateIdentifier
{
	private UIBigEvent_CustomCardTabView m_View;

	private ICustomCardTabData m_Data;

	private UIModelBigEvent_CustomCard m_UIModelCustomCard;

	private UIModelBigEventTemplate m_UIModelBigEventTemplate;

	private EBigEventTemplateUseType _003CTemplateUseType_003Ek__BackingField;

	public EBigEventTemplateUseType TemplateUseType
	{
		get
		{
			return _003CTemplateUseType_003Ek__BackingField;
		}
		private set
		{
			_003CTemplateUseType_003Ek__BackingField = value;
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpenAsChild()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void BindTab()
	{
	}

	private void OnSelectedTab(UIToggleButton button)
	{
	}

	private void OnRedStateCallback(bool result)
	{
	}

	public void SetData(ICustomCardTabData data)
	{
	}

	public virtual EBigEventTemplateType GetTemplateType()
	{
		return EBigEventTemplateType.None;
	}

	public void OnTemplateUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpenAsChild()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
