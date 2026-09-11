using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIWorkshopGenreWndController : UIPopupWindowController
{
	public enum EUIType
	{
		Genre
	}

	private UIWorkshopGenreWndView m_View;

	private UIModelSceneEdit m_Model;

	public Action<WorkshopGenreID> OnGenreIDChanged;

	private SceneEditSlotInfo m_SlotInfo;

	private List<WorkshopGenreID> m_DataList;

	private int m_SelectedIndex;

	public int SelectedIndex => 0;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override string CustomTitle()
	{
		return null;
	}

	protected override void OnUIInit()
	{
	}

	private void InitView()
	{
	}

	public void RefreshViewData(SceneEditSlotInfo slotInfo)
	{
	}

	private void RefreshBtn(bool selected)
	{
	}

	private WorkshopGenreID GetSelectedData()
	{
		return null;
	}

	private void OnConfirmBtnClick()
	{
	}

	public void OnItemSelected(int index)
	{
	}

	private UITable2.IUITable2Item _003CInitView_003Eb__12_0()
	{
		return null;
	}

	private bool _003CRefreshViewData_003Eb__13_0(WorkshopGenreID e)
	{
		return false;
	}

	public string _003C_003EiFixBaseProxy_CustomTitle()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
