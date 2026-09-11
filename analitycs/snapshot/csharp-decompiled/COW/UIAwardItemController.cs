using GCommon;

namespace COW;

public class UIAwardItemController : UIBaseController
{
	private enum EquipmentState
	{
		EQUIPMENTSTATE_NONE,
		EQUIPMENTSTATE_CHECK,
		EQUIPMENTSTATE_UNCHECK,
		EQUIPMENTSTATE_EQUIPPED
	}

	private UIAwardItemView m_View;

	private BaseItemInfo m_Info;

	private int m_AwardKey;

	private EquipmentState m_EquipmentState;

	public BaseItemInfo ItemInfo
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int AwardKey => 0;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(BaseItemInfo info)
	{
	}

	public void SetToggleVisible(bool v)
	{
	}

	public void SetAwardCheckState()
	{
	}

	public void SetAwardUnCheckState()
	{
	}

	public void SetAwardEquippedState()
	{
	}

	public bool IsAlreadyEquipped()
	{
		return false;
	}

	public CSSharedItemDataManager.ItemType GetAwardType()
	{
		return CSSharedItemDataManager.ItemType.ITEMTYPENONE;
	}

	public int GetAwardSubType()
	{
		return 0;
	}

	public static int GenAwardKey(BaseItemInfo info)
	{
		return 0;
	}

	private void SetToggleValue(bool v)
	{
	}

	private void OnToggleSelected()
	{
	}

	private void RefreshUI()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
