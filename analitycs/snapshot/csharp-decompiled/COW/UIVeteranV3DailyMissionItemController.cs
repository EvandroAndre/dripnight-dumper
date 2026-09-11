using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIVeteranV3DailyMissionItemController : UIBaseController
{
	private UIVeteranV3DailyMissionItemView m_View;

	private UIModelVeteran m_ModelVeteran;

	private ClientVeteranTaskDesc m_Desc;

	private int m_Index;

	private readonly List<UIStandardItemMiniController> m_ItemList;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void SetupDefaultStateOnInit()
	{
	}

	private void LoadStaticContent()
	{
	}

	private void RefreshDynamicContent()
	{
	}

	private void RefreshOperateUI()
	{
	}

	private void RefreshView()
	{
	}

	private void OnGotoBtnClick()
	{
	}

	private void OnClaimBtnClick()
	{
	}

	public void SetViewData(ClientVeteranTaskDesc data, int index)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
