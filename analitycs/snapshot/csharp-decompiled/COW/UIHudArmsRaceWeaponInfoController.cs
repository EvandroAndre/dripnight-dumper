using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIHudArmsRaceWeaponInfoController : UIHudWeaponInfoController
{
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public override bool RecyleDontDestroy()
	{
		return false;
	}

	protected override bool CheckSilderWeapon(NAELPAAELNO item)
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public new bool _003C_003EiFixBaseProxy_RecyleDontDestroy()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_CheckSilderWeapon(NAELPAAELNO P0)
	{
		return false;
	}
}
