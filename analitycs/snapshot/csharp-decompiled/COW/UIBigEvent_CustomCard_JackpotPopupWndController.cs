using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIBigEvent_CustomCard_JackpotPopupWndController : UIPopupWindowController, IEasyList, IUIModelDataChangeObserver, IBigEventTemplateIdentifier
{
	private UIBigEvent_CustomCard_JackpotPopupWndView m_View;

	private UIModelBigEvent_CustomCard m_UIModelCustomCard;

	private UIModelBigEventTemplate m_UIModelBigEventTemplate;

	private List<BaseItemInfo> normalRewards;

	private List<CustomCard_CardData> cardRewards;

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

	protected override void OnUIDestory()
	{
	}

	private void InitCND()
	{
	}

	private void OnClickCloseBtn()
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
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

	public void _003C_003EiFixBaseProxy_OnSetNavigationController()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
