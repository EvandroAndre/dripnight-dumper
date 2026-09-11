namespace proto;

public class WorkshopDataStorageContent
{
	public string key;

	public uint key_size;

	public byte[] value;

	public uint value_size;

	public long update_time;

	public string account_id;

	public string index_id;

	public byte[] old_value;

	public long old_update_time;
}
