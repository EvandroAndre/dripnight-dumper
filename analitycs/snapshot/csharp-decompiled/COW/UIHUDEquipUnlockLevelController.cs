using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIHUDEquipUnlockLevelController : UIPopupWindowController, IUIModelDataChangeObserver
{
	private UIHUDEquipUnlockLevelView m_View;

	private List<UIHudBanknoteShopLevelListController> m_LevelList;

	private int m_OneLevelSetCount;

	private UITimeLabelHelper m_EndTime;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void SetUpData()
	{
	}

	public void InitOneLevel(int levelIndex)
	{
	}

	public void ShowWindow(float showTime)
	{
	}

	public void UpdateUnLockInfo()
	{
	}

	public void RefreshSelectedItem()
	{
	}

	public void OnConfirm()
	{
	}

	public void SendSelectInfoToServer()
	{
	}

	private void Update()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
