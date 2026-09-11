using System.Collections.Generic;
using GCommon;
using message;

namespace COW;

internal class UIRoomParamsMultiChooseItemController : UIBaseController
{
	private UIRoomParamsMultiChooseItemView m_View;

	private GDOLMKJCODJ m_Data;

	private Dictionary<string, string> m_LocDict;

	public GDOLMKJCODJ Data => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(GDOLMKJCODJ data, bool isChecked, Dictionary<string, string> dict)
	{
	}

	public bool IsChoose()
	{
		return false;
	}

	public void RefreshLocKey()
	{
	}

	private void OnCheckBtnClick()
	{
	}

	public string GetRoomParamsLoc(string key, string defaultText = "")
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
