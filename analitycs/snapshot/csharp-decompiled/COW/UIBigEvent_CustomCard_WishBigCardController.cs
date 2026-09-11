using GCommon;
using UnityEngine;

namespace COW;

public class UIBigEvent_CustomCard_WishBigCardController : UIEasyListItemController, IBigEventTemplateIdentifier
{
	private UIBigEvent_CustomCard_WishBigCardView m_View;

	private UIModelBigEvent_CustomCard.CardWishData m_Data;

	private CustomCard_CardData m_CardData;

	private uint m_OldCardId;

	private UIModelBigEventTemplate m_UIModelBigEventTemplate;

	private UIModelBigEvent_CustomCard m_UIModelCustomCard;

	private GameObject m_EffectGo;

	private EBigEventTemplateUseType _003CTemplateUseType_003Ek__BackingField;

	public float Width => 0f;

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

	public Transform GetProfileInfoTrans()
	{
		return null;
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

	private void OnClickReceiveBtn()
	{
	}

	private void OnClickCardBtn()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	private void PlayAddWishEffect()
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
}
