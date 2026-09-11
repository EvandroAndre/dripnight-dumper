using GCommon;

namespace COW;

public class UIBigEvent_CustomCard_WishSmallCardController : UIEasyListItemController, IBigEventTemplateIdentifier
{
	private UIBigEvent_CustomCard_WishSmallCardView m_View;

	private CustomCard_CardData m_CardData;

	private UIModelBigEventTemplate m_UIModelBigEventTemplate;

	private UIModelBigEvent_CustomCard m_UIModelCustomCard;

	private UICommonGuideController m_GuideController;

	private bool m_IsGuiding;

	private string m_strWishKey;

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

	protected override void OnUIDestory()
	{
	}

	protected override void OnUIOpenAsChild()
	{
	}

	public override void OnItemBtnClick2()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	public bool SetWishGuide(int depth)
	{
		return false;
	}

	private void OnGuideFinishCallback()
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

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpenAsChild()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnClick2()
	{
	}
}
