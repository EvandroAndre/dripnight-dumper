using System.Collections.Generic;

namespace proto;

public class WorkshopSheetBasicInfo
{
	public string sheet_name;

	public long create_time;

	public long delete_time;

	public uint sheet_type;

	public List<WorkshopMultiColumnHeader> multi_column_header;

	public long clear_start_time;

	public uint clear_interval_hours;

	public long last_clear_time;

	public string replace_sheet_name;

	public uint clear_interval_unit;

	public bool disable_auto_clear;

	public int timezone_offset;

	public bool timezone_set_by_player;
}
