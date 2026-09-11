using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIClanLogoShowController : UIBaseController, IUIModelDataChangeObserver
{
	private UIClanLogoShowView m_View;

	private UIModelClan m_ModelClan;

	private UIModelInventory m_ModelInventory;

	private Dictionary<uint, UIBadgeItemController> m_BadgeItemDic;

	private List<UIBadgeItemController> m_BadgeItemList;

	private UIClanEditController.FuntionType m_MyFunctionType;

	private uint m_CurrentSelectBadgeID;

	private uint m_CurrentUsingBadgeID;

	private ClanIconType m_BadgeType;

	private List<ClanBadgeItemInfo> m_BadegeItemInfoList;

	public uint CurrentSelectBadgeID => 0u;

	protected override void OnUIInit()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	private void SetInactiveState()
	{
	}

	public void SetFunctionType(UIClanEditController.FuntionType type)
	{
	}

	public void SetViewData(ClanIconType type)
	{
	}

	private void InitBadgeItemGrid()
	{
	}

	public void UpdateIconFrame()
	{
	}

	private void UpdateBadgeInfo(ClanBadgeItemInfo badgeInfo, ClanIconType type)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public void RefreshBadgeInfo(object[] data)
	{
	}

	private void RefreshBadgeInfoWhenCreating(object[] data)
	{
	}

	private void OnRequestUpdateClanBadge()
	{
	}

	private void UpdateClanBadgeUsing(uint badgeId)
	{
	}

	private void OnUnlockClanBadge()
	{
	}

	private void RefreshBadgeItemGrid()
	{
	}

	private void ProcessBadgeInfo()
	{
	}

	private string GetDefaultClanFrame()
	{
		return null;
	}

	public void ResetGridSelect()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
