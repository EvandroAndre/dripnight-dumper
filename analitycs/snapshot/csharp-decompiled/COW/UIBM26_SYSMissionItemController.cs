using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIBM26_SYSMissionItemController : UIBaseController
{
	private UIBM26SysMissionItemView m_View;

	private List<UIBM26SYSStandardItemMiniController> m_ListRewardItemCtrl;

	private ClientActivityDesc m_ActivityDesc;

	private EActivity.State m_ActivityState;

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

	public void SetViewData(ClientActivityDesc desc, int data_index)
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
