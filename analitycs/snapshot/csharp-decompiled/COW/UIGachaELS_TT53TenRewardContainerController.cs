using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIGachaELS_TT53TenRewardContainerController : UIBaseController, UITable2.IUITable2Item
{
	private UIGachaELS_TT53TenRewardContainerView m_View;

	private List<UIGachaELS_TT53RewardItemController> m_TenRewardItemCtrlList;

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

	public void SetViewData(List<CommonRewardItemInfo> rewardInfoList)
	{
	}

	public List<UIGachaELS_TT53RewardItemController> GetItemControllers()
	{
		return null;
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

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
