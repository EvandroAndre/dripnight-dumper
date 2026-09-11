using System.Collections.Generic;
using COW.GamePlay;

internal class FragmentAttackableComponent : AttackableEntity
{
	private uint m_FragmentUID;

	private byte m_BindTeamID;

	protected override int GetMaxRepDataCount()
	{
		return 0;
	}

	internal void Init(uint fragmentUID, byte bindTeamID)
	{
	}

	public void Clear()
	{
	}

	public byte GetBindTeamID()
	{
		return 0;
	}

	public override void TakeDamage(GLLLEDKLLDA damageInfo, LOAEBBHPMEK damagerWeaponDynamicInfo = null, List<float> checkParams = null, uint vehicleDataID = 0u)
	{
	}
}
