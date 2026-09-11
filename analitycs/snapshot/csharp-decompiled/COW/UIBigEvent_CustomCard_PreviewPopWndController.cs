using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIBigEvent_CustomCard_PreviewPopWndController : UIPopupWindowController, IBigEventTemplateIdentifier
{
	private UIBigEvent_CustomCard_PreviewPopWndView m_View;

	private List<UIStandardItemMiniController> m_rewardCtrlList;

	private UIModelBigEventTemplate m_ModelBigEventTemplate;

	private UIModelBigEvent_CustomCard m_UIModelCustomCard;

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

	protected override void OnSetNavigationController()
	{
	}

	private void OnCloseBtnClick()
	{
	}

	private void InitCDN()
	{
	}

	public void SetData(List<BaseItemInfo> show_rewardList, string strTitle, Color titleColor, string strContent, Color contentColor, bool isReceived)
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

	public void _003C_003EiFixBaseProxy_OnSetNavigationController()
	{
	}
}
