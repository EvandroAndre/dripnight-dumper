using System.Collections.Generic;

namespace tcp;

public class WeaponPowerUpdateNtf
{
	public ulong account_id;

	public uint match_mode;

	public List<WeaponPowerUpdateInfo> info_list;
}
