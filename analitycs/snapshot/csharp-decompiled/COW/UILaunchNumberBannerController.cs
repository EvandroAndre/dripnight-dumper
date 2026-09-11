using GCommon;
using UnityEngine;

namespace COW;

public class UILaunchNumberBannerController : UIBaseController
{
	private UILaunchTagFrameView m_View;

	private GameObject m_Obj;

	private bool m_IsCommonLaunchTag;

	private UILaunchTagNumberBannerHelper m_Helper;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void LoadResByTagID(uint tagID)
	{
	}

	public void SetLabel(uint serialNumber)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
