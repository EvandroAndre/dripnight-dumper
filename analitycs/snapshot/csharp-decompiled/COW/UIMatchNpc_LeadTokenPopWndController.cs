using GCommon;
using UnityEngine;

namespace COW;

public class UIMatchNpc_LeadTokenPopWndController : UIPopupWindowController, IEasyList, IBigEventTemplateIdentifier
{
	private UIMatchNpc_LeadTokenPopWndView m_View;

	private UIModelBigEventTemplate m_ModelTemplate;

	private UIModelBigEvent_MatchNPC m_ModelMatchNpc;

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

	private void InitAccessWay()
	{
	}

	private void OnCloseBtnClick()
	{
	}

	private void RefreshCloseBtnShowState()
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
