using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIMilestone_MissionPopupSpecItemController : UIEasyListItemController, IBigEventTemplateIdentifier
{
	private UIMilestone_MissionPopupSpecItemView m_View;

	private UIModelBigEvent_Milestone m_UIModelMilestone;

	private MilestoneMissionData m_MissionData;

	private List<UIMilestone_MissionPopupSpecSubItemController> subItems;

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

	private UIMilestone_MissionPopupSpecSubItemController GetSubItemController(int index)
	{
		return null;
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	public EBigEventTemplateType GetTemplateType()
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
