using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIBigEvent_CustomTC_PreviewPopWndController : UIPopupWindowController, IBigEventTemplateIdentifier
{
	private UIBigEvent_CustomTC_PreviewPopWndView m_View;

	private List<UIStandardItemMiniController> m_rewardCtrlList;

	private UIModelBigEventTemplate m_ModelBigEventTemplate;

	private UIModelBigEvent_CustomTC m_UIModelCustomTC;

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

	public void SetData(List<BaseItemInfo> show_rewardList, bool isReceived, uint pieceId)
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
