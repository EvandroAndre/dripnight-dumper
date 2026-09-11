namespace proto;

public class CSUploadWorkshopReq
{
	public string workshop_name;

	public ulong performance_cost;

	public byte[] workshop_settings;

	public uint slot_id;

	public ulong resource_statistics;

	public string workshop_desc;

	public uint game_mode;

	public byte[] mode_settings;

	public uint group_mode;

	public uint[] tags;

	public byte[] object_attribute_settings;

	public uint team_count;

	public byte[] mini_map_settings;

	public byte[] mini_map_object_settings;
}
