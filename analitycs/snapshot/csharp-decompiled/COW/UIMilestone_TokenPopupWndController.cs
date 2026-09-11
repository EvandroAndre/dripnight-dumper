using GCommon;
using UnityEngine;

namespace COW;

public class UIMilestone_TokenPopupWndController : UIPopupWindowController, IEasyList, IBigEventTemplateIdentifier
{
	private UIMilestone_TokenPopupWndView m_View;

	private UIModelBigEvent_Milestone m_UIModelMilestone;

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

	public void SetToken(uint tokenId)
	{
	}

	private void OnCloseBtnClick()
	{
	}

	private void RefreshCloseBtnShowState()
	{
	}

	private void OnClickTokenLinkCallback(object[] data)
	{
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
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
}
