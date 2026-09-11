using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UIHudTrainCharacterDialogController : UIBaseController
{
	private CSVAsyncDataMap<uint, SocialNPCConfig> SocialNPCConfigAsyncData;

	private Dictionary<uint, List<string>> DialogDic;

	private UIHudTrainCharacterDialogView m_View;

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

	private void OnShowDialog(object[] data)
	{
	}

	private void OnClickClose()
	{
	}

	private bool IsValidData(string startTimeStr, string endTimeStr, string Region)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
