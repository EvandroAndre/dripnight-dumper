using GCommon;
using UnityEngine;

namespace COW;

public class UIBigEvent_GlobalProgress_TokenPopWndController : UIPopupWindowController, IEasyList, IBigEventTemplateIdentifier
{
	private UIBigEvent_GlobalProgress_TokenPopWndView m_View;

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

	private void _003CRefreshCloseBtnShowState_003Eb__7_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnSetNavigationController()
	{
	}
}
