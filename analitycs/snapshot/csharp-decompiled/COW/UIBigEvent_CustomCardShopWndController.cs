using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIBigEvent_CustomCardShopWndController : UIBaseController, IUIModelDataChangeObserver, IEasyList, IBigEventTemplateIdentifier
{
	private UIBigEvent_CustomCardShopWndView m_View;

	private UIModelBigEvent_CustomCard m_UIModelCustomCard;

	private uint m_CurrentSelectedCardId;

	private List<CustomCard_CardData> cards;

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

	private void InitTokenOwnedShowState()
	{
	}

	private void RefershTokenInfo()
	{
	}

	private void RefershCardList()
	{
	}

	private int GetRealSelectedCardIndex()
	{
		return 0;
	}

	private int ShopCardCompareTo(CustomCard_CardData left, CustomCard_CardData right)
	{
		return 0;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	private void OnShopPruchageCallback(object[] data)
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
