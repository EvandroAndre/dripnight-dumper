using System.Collections.Generic;

namespace proto;

public class CSChooseCollectionFinalShotsReq
{
	public ulong group_id;

	public ulong room_id;

	public List<WeaponFinalShotItem> final_shots;
}
