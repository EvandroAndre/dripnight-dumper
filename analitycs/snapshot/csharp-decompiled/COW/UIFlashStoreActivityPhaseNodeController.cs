using GCommon;

namespace COW;

public class UIFlashStoreActivityPhaseNodeController : UIBaseController
{
	public delegate void OnPhaseNodeSelect(uint activityGroupID);

	private const int OVERDUE_GROUP_ID = 0;

	private const int PROCEEDING_GROUP_ID = 1;

	private const int LOCKED_GROUP_ID = 2;

	private const float SELECTED_OFFSET_X = 15f;

	private const float NOT_SELECTED_OFFSET_X = 0f;

	private const int SELECTED_FONT_SIZE = 30;

	private const int NOT_SELECTED_FONT_SIZE = 20;

	private const string DATETIME_DISPLAY_FORMAT = "MM.dd";

	private const string OVERDUE_TIPS_KEY = "T_35_LC_FLASHSTORE_TIMEEXPIRED";

	private const string LOCKED_TIPS_KEY = "T_35_LC_FLASHSTORE_TIMELIMITED";

	private const string FLASH_GEM_SPRITE_NAME = "FF_UI_FlashStore_PurpleDiamond";

	private uint m_FlashStoreActivityID;

	private uint m_ActivityGroupID;

	private OnPhaseNodeSelect m_OnPhaseNodeSelect;

	private UIFlashStoreActivityPhaseNodeView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void AddEventDelegate()
	{
	}

	private void OnActionBtnClick()
	{
	}

	private void SetupDefaultState()
	{
	}

	private void SetActiveGroup(int group)
	{
	}

	private void RefreshDynamicContent()
	{
	}

	public void SetViewData(uint flashStoreActivityID, uint activityGroupID, OnPhaseNodeSelect onPhaseNodeSelect)
	{
	}

	public uint GetActivityGroupID()
	{
		return 0u;
	}

	public void SelectPhaseNode(bool select)
	{
	}

	public UIWidget GetWidgetForGuide()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
