using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIKolHudSensivityWndController : UIBaseController
{
	private UIKolHudSensitivityTipWndView m_View;

	private List<string> m_SettingNameList;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnBackButtonClick()
	{
	}

	public void SetPanelDepth(int depth)
	{
	}

	public void RefreshSettingItem(float[] sensitivity_settings)
	{
	}

	public void SetHudData(KolHudDetail itemData)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
