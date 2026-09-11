using System.Collections.Generic;
using GCommon;

namespace COW;

internal class PCClothConfigDataManager : SingletonModule<PCClothConfigDataManager>
{
	public List<uint> MaleClothList;

	public List<uint> FeMaleClothList;

	public List<uint> WeaponSkinsList;

	public uint DeadboxCollection;

	public uint ParachuteCollection;

	public uint SkyboardCollection;

	public uint FlightCollection;

	public uint BackPackCollection;

	public List<uint> VehicleSkinList;

	public const int GRENADE_WEAPON_ID = 601;

	public const int SMOKEGRENADE_WEAPON_ID = 603;

	protected override void OnCleanup()
	{
	}

	protected override void OnInit()
	{
	}
}
