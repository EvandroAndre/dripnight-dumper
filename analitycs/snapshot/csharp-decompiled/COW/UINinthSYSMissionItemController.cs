using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UINinthSYSMissionItemController : UIBaseController, UITable2.IUITable2Item
{
	private UINinthSYSMissionItemView m_View;

	private List<UINinthSYSStandardItemMiniController> m_ListRewardItemCtrl;

	private UIModelNinthSYS.NinthSYSMissionData m_MissionData;

	protected int MAXTASKNUM;

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

	private void RefreshView()
	{
	}

	private void RefreshAward()
	{
	}

	private void OnClickBtnReceive()
	{
	}

	private void OnClickGotoBtn()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
