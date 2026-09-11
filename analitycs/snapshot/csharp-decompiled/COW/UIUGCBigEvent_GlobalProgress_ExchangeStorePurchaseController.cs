using GCommon;
using proto;

namespace COW;

public class UIUGCBigEvent_GlobalProgress_ExchangeStorePurchaseController : UIMallPurchaseBaseController, IBigEventTemplateIdentifier
{
	private CustomEventStoreCommodityDesc m_Data;

	private UIModelBigEventTemplate m_ModelBigEventTemplate;

	private EBigEventTemplateUseType _003CTemplateUseType_003Ek__BackingField;

	protected override int ItemCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

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

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnSetNavigationController()
	{
	}

	private void OnExchangeBtnClick()
	{
	}

	public virtual void RefreshData(CustomEventStoreCommodityDesc data)
	{
	}

	private void SetExchangeIcon(UISprite sprite)
	{
	}

	public virtual EBigEventTemplateType GetTemplateType()
	{
		return EBigEventTemplateType.None;
	}

	public void OnTemplateUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnSetNavigationController()
	{
	}

	public int _003C_003EiFixBaseProxy_get_ItemCount()
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_set_ItemCount(int P0)
	{
	}
}
