using System.Collections.Generic;

namespace proto;

public class WorkshopDataStorage
{
	public string sheet_name;

	public List<WorkshopDataStorageContent> contents;

	public uint sheet_type;

	public List<WorkshopMultiColumnHeader> multi_column_header;

	public long clear_start_time;

	public uint clear_interval_hours;

	public uint clear_interval_unit;

	public bool disable_auto_clear;

	public int timezone_offset;

	public bool timezone_set_by_player;

	public EWorkshop.DataStorageSheetErrorType sheet_error;
}
