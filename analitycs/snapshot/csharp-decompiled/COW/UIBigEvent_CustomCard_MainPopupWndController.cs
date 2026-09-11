using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIBigEvent_CustomCard_MainPopupWndController : UIPopupWindowController, IUIModelDataChangeObserver, IBigEventTemplateIdentifier
{
	private UIBigEvent_CustomCard_MainPopupWndView m_View;

	private UIModelBigEvent_CustomCard m_UIModelCustomCard;

	private UIModelBigEventTemplate m_UIModelBigEventTemplate;

	private List<ICustomCardTabData> m_listTabDatas;

	private List<UIBigEvent_CustomCardTabController> m_listTabCtrls;

	private UIBaseController m_CurrentSubCtrl;

	private EBigEventTemplateUseType m_TemplateUseType;

	private int m_selected_index;

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

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void InitCND()
	{
	}

	private void InitTab()
	{
	}

	private void OnClickCloseBtn()
	{
	}

	private void OnSelectTabCallback(int index)
	{
	}

	public void SetTab(int tabIndex)
	{
	}

	private void ResetTab()
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

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
