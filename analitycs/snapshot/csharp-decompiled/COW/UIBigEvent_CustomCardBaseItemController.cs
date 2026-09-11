using GCommon;

namespace COW;

public class UIBigEvent_CustomCardBaseItemController : UIEasyListItemController, IUIModelDataChangeObserver, IBigEventTemplateIdentifier
{
	protected UIBigEvent_CustomCardItemView m_View;

	protected UIModelBigEvent_CustomCard m_UIModelCustomCard;

	protected UIModelProfile m_UIModelProfile;

	private UIBaseProfileInfoController m_BaseProfile;

	protected uint m_Serial;

	protected uint m_CardId;

	protected ulong m_AccountId;

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

	protected override void OnUIOpenAsChild()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected CustomCard_CardData SetData(uint serial, uint card_id, ulong account_id)
	{
		return null;
	}

	protected virtual string GetCdnUrl(CustomCard_CardData card_data)
	{
		return null;
	}

	protected virtual void OnClickComfirmBtn()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	protected virtual void OnPlayerOnlineStateCallback(BaseProfileInfo account_info)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
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
