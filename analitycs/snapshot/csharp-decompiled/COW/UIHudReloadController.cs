using System;
using GCommon;

namespace COW;

internal class UIHudReloadController : UIHudButtonBaseController
{
	private UIHudReloadView m_View;

	private UIHudWeaponAttributeTipsController m_TipCtrl;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override bool RecyleDontDestroy()
	{
		return false;
	}

	public static bool DontDestroy()
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	public override void OnUIReInit()
	{
	}

	public void RegisterPinMark(Action pinMark)
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override string GetMappingName()
	{
		return null;
	}

	public void ShowWarningTip(bool show)
	{
	}

	private void OnReloadTutorialShow(object[] data)
	{
	}

	private void ShowWeaponAttributeTips(bool show)
	{
	}

	public void Update()
	{
	}

	private void OnFootballGunGuideShow(object[] data)
	{
	}

	public bool _003C_003EiFixBaseProxy_RecyleDontDestroy()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIReInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
