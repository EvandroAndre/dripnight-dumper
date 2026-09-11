using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIUGCDebuggerDataBaseItemController : UIEasyListItemController
{
	private UIUGCDebuggerDataBaseItemView m_View;

	private UIPopMenuSmallControlerForScrollPanel m_BoolMenu;

	private List<PopMenuData> m_BoolMenuDataList;

	private const string TRUE_KEY = "T_34_M_WS_TRUE";

	private const string FALSE_KEY = "T_34_M_WS_FALSE";

	private LocalSheetItemData m_SheetData;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	public void SetWidth(int width)
	{
	}

	private void OnStandardValueUIInputSubmit()
	{
	}

	private void OnVector2InputXSubmit()
	{
	}

	private void OnVector2InputYSubmit()
	{
	}

	private void OnVector3InputXSubmit()
	{
	}

	private void OnVector3InputYSubmit()
	{
	}

	private void OnVector3InputZSubmit()
	{
	}

	private void OnBoolValueClick()
	{
	}

	private void RefreshBoolMenu()
	{
	}

	private void GenerateBoolMenuData()
	{
	}

	private void OnBoolMenuSelected(object data)
	{
	}

	private string SerializeLocalSheetValueToJson(LocalSheetValue value)
	{
		return null;
	}

	private void OnMoreBtnClick()
	{
	}

	private void ShowJsonPopupWindow(string jsonContent)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
