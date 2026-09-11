using GCommon;

namespace COW;

public class UIHudHGGatherController : UIBaseController
{
	private UIHudHGGatherView m_View;

	public bool showweapon;

	private bool showbuff;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnDestroy()
	{
	}

	private void Update()
	{
	}

	public void ChangeShowBuff(bool show)
	{
	}

	private void CheckShowWeapon()
	{
	}

	private void ShowBar(bool show)
	{
	}

	public void OnGatherEnergyChange(bool showEffect, uint curEnergy, uint maxEnergy)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}
}
