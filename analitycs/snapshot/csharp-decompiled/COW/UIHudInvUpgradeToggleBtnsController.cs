using System;
using GCommon;

namespace COW;

internal class UIHudInvUpgradeToggleBtnsController : UIBaseController
{
	private const string TUTORIAL_UPGRADE_TAB_MAX_SHOW_COUNT = "TUTORIAL_UPGRADE_TAB_MAX_SHOW_COUNT";

	private UIHudInvUpgradeToggleBtnsView m_View;

	private Action m_LeftToggleCallback;

	private Action m_RightToggleCallback;

	private bool m_HasShowTutorial;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void CheckAndShowTutorial()
	{
	}

	private void OnLeftToggleClick()
	{
	}

	private void OnRightToggleClick()
	{
	}

	public void SelectToggle(bool weaponTab)
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetLeftToggleCallback(Action callback)
	{
	}

	public void SetRightToggleCallback(Action callback)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
