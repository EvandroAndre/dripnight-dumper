using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UIMapDownloadSelectController : UIPopupWindowController
{
	private UIMapDownloadSelectView m_View;

	public Action<int> DownloadAction;

	private List<UIMapDownloadSelectItemController> m_ItemCtrlList;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetUIData(List<MapModeData> mapDataList)
	{
	}

	private void OnBtnCancelClick()
	{
	}

	private void OnBtnComfirmClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
