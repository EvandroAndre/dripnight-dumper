using GCommon;

namespace COW;

public class UIPetSkillSelcetItemController : UIEasyListItemController, IUIModelDataChangeObserver
{
	private UIpetSelectSkillItemView m_View;

	private PetSkillConfigInfo skill_info;

	private CSSharedItemData inventoryItem;

	private uint CurrentSelectedSkillID;

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

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void SelectCurrentSkill()
	{
	}

	private void SelectSkill()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	public void RefreshData()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void SetSelectedSkillView()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
