using GCommon;

namespace COW;

internal class UIHudSwitchWeaponSkinController : UIHudButtonBaseController
{
	private UIHudSwitchWeaponSkinView m_View;

	private bool m_PlaySwitchEffect;

	private bool m_CanCombine;

	private VisualInstanceHolder instanceHolder;

	private bool m_CanSwitch;

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

	protected override void OnUIDestory()
	{
	}

	protected void OnWeaponSkinSwitched(object[] data)
	{
	}

	protected void OnWeaponSkinChanged(object[] data)
	{
	}

	private void OnBtnSwitchClick()
	{
	}

	private void OnCanSwitchChanged(object[] param)
	{
	}

	private void OnSightingStateChanged(object[] data)
	{
	}

	private void OnCanCombineChanged(object[] param)
	{
	}

	private bool CheckNeedHideWhenCanCombine()
	{
		return false;
	}

	protected override string GetMappingName()
	{
		return null;
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
