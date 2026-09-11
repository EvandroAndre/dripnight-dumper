using GCommon;

namespace COW;

public class UIBigEvent_Template_RulePopupWndBaseController : UIPopupWindowController, IBigEventTemplateIdentifier
{
	protected UIButton BtnClose;

	protected UILabel LabelTitle;

	protected UINetworkTexture TextureBg;

	protected UISprite SpriteBtnClose;

	protected UILabel LabelDesc;

	protected UINetworkTexture TextureBtnClose;

	protected UIModelBigEventTemplate m_UIModelBigEventTemplate;

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

	protected override void OnUIInit()
	{
	}

	protected override void OnSetNavigationController()
	{
	}

	public void RefreshView(uint useType, EBigEventTemplateRulePopupWndType rulePopupWndType)
	{
	}

	private void OnClickBtnClose()
	{
	}

	public virtual EBigEventTemplateType GetTemplateType()
	{
		return EBigEventTemplateType.None;
	}

	public void OnTemplateUIInit()
	{
	}

	private void _003CRefreshView_003Eb__9_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnSetNavigationController()
	{
	}
}
