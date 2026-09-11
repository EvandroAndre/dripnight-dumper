using GCommon;
using UnityEngine;

namespace COW;

internal class UIBooyahPassPrivilegeRewardItemMiniController : UIEasyListItemController, UITable2.IUITable2Item
{
	private UIBooyahPassPrivilegeRewardItemMiniView m_View;

	private UIStandardItemMiniController m_MiniCtrl;

	private BaseItemInfo m_Info;

	private new int m_Index;

	private UIModelBooyahPass m_ModelBooyahPass;

	private Vector3 m_OriginPos;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public object SetTable2ItemData(int index, object data, object viewState)
	{
		return null;
	}

	public void SetPosition(Vector2 position)
	{
	}

	public void SetTable2Visible(bool visible)
	{
	}

	private void RefreshCommonReward()
	{
	}

	private void RefreshPrivilegeReward()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	private void ShowPrivilegeRewardTips()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
