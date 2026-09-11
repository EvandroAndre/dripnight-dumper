using System.Collections.Generic;

namespace tcp;

public class WeaponExpUpdateNtf
{
	public ulong account_id;

	public List<WeaponExpUpdateInfo> info_list;

	public bool has_unclaimed;
}
