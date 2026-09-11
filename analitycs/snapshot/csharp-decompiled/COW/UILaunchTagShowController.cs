using GCommon;
using UnityEngine;

namespace COW;

public class UILaunchTagShowController : UIBaseController
{
	private GameObject m_ShowObj;

	private UILaunchTagShowHelper m_Helper;

	private UILaunchTagFrameView m_View;

	private bool m_IsCommonLaunchTag;

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

	public void SetPanelDepth(int depth)
	{
	}

	public void SetLabel(uint serialNumber, bool setSplitted)
	{
	}

	private void SetSplittedNumbers(uint serialNumber)
	{
	}

	public void PlayAnim_DefaultVer()
	{
	}

	public void PlayAnim_ShortVer()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
