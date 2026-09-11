using System.Collections.Generic;

namespace proto;

public class WorkshopUGCOpeningInfoDesc
{
	public uint difficulty;

	public string mode_name_key;

	public string map_name_key;

	public uint[] map_ids;

	public List<string> map_codes;

	public uint map_type;

	public bool available_map_choose;

	public string guide_tutorial;

	public long shelf_time;

	public long under_time;
}
