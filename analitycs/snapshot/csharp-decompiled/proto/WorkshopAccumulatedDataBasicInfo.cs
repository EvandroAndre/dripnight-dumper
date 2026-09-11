using System.Collections.Generic;

namespace proto;

public class WorkshopAccumulatedDataBasicInfo
{
	public string acc_data_sheet_name;

	public List<string> acc_data_keys;

	public long create_time;

	public long clear_start_time;

	public uint clear_interval_hours;

	public long last_clear_time;

	public uint clear_interval_unit;

	public bool disable_auto_clear;

	public int timezone_offset;

	public bool timezone_set_by_player;
}
