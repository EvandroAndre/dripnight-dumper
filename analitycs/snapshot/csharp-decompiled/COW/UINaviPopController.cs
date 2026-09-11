using GCommon;
using UnityEngine;

namespace COW;

internal class UINaviPopController : UINavigationController
{
	protected bool m_NaviMaskState;

	protected GameObject m_NaviMask;

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected virtual void OnClickClose()
	{
	}

	public override bool OverwriteBackButtonLogic()
	{
		return false;
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public bool _003C_003EiFixBaseProxy_OverwriteBackButtonLogic()
	{
		return false;
	}
}
