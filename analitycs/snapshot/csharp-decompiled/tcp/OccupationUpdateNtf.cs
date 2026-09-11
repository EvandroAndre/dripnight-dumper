using System.Collections.Generic;

namespace tcp;

public class OccupationUpdateNtf
{
	public ulong account_id;

	public uint match_mode;

	public uint game_mode;

	public List<OccupationUpdateInfo> scores;

	public List<OccupationUpdateInfo> proficients;

	public bool proficient_red_point;

	public byte[] occupation_info;
}
