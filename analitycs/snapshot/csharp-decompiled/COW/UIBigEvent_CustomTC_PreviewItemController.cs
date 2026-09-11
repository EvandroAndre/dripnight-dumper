using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIBigEvent_CustomTC_PreviewItemController : UIEasyListItemController, IBigEventTemplateIdentifier
{
	private UIBigEvent_CustomTC_PreviewItemView m_View;

	private UIModelBigEventTemplate m_UIModelBigEventTemplate;

	private UIModelBigEvent_CustomTC m_UIModelCustomTC;

	private List<UIStandardItemMiniController> m_RewardItemCtrlList;

	private CustomTCPieceInfo m_PieceInfo;

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

	public override void SetViewData(object data, int data_index)
	{
	}

	public virtual EBigEventTemplateType GetTemplateType()
	{
		return EBigEventTemplateType.None;
	}

	protected override void OnUIOpenAsChild()
	{
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
}
