using COW.GamePlay;

namespace COW;

internal class FMetroWeaponData : FMetroItemData
{
	public FDAEPHMIEPC.DBENAPILEBC Type;

	public AGACNOCEEFP Data;

	public NPEIMKGFIJN Config;

	public bool IsPoliceCollect;

	public bool IsCriminalCollect;

	public bool IsCollect(int faction)
	{
		return false;
	}

	public void SetCollect(int faction, bool value)
	{
	}
}
