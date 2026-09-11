using GCommon;

namespace COW;

public class UIPetSkillItemController : UIBaseController, IUIModelDataChangeObserver
{
	private UIpetSkillItemView m_View;

	private PetSkillConfigInfo skill_info;

	private CSSharedItemData inventoryItem;

	private const string PET_SELECT_SKILL_TAG = "PET_SKILL_SELECT_TAG";

	private int m_MinLevel;

	private int m_CurLevel;

	private int m_MaxLevel;

	private bool m_IsUnlock;

	private const string PET_SKILL_GUIDE = "PET_SKILL_GUIDE_{0}_{1}";

	private UICommonGuideController m_PetSkillGuide;

	protected override ResourceID GetResID()
	{
		return default(ResourceID);
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

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void SetEmptySkillInfo()
	{
	}

	public void RefreshViewData(PetSkillConfigInfo skillInfo)
	{
	}

	public void RefreshData()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void CheckItemTipsState()
	{
	}

	public void ShowItemNoTips(bool isUnlock)
	{
	}

	public ResourceID _003C_003EiFixBaseProxy_GetResID()
	{
		return default(ResourceID);
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
