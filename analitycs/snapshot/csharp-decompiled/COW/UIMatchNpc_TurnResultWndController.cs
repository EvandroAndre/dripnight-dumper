using GCommon;

namespace COW;

public class UIMatchNpc_TurnResultWndController : UIPopupWindowController, IBigEventTemplateIdentifier
{
	private UIMatchNpc_TurnResultWndView m_View;

	private UIModelBigEvent_MatchNPC m_ModelMatchNpc;

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

	protected override void OnSetNavigationController()
	{
	}

	private void InitShowResult()
	{
	}

	private void InitCloseBtnShowState()
	{
	}

	private void OnOkBtnClick()
	{
	}

	private void OnInfoIconClick()
	{
	}

	public override bool IgnoreEsc()
	{
		return false;
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

	public void _003C_003EiFixBaseProxy_OnSetNavigationController()
	{
	}

	public bool _003C_003EiFixBaseProxy_IgnoreEsc()
	{
		return false;
	}
}
