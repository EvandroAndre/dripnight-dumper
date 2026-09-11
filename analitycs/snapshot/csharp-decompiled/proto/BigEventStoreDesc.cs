namespace proto;

public class BigEventStoreDesc
{
	public uint store_id;

	public ELimitedEvent.EventID event_id;

	public ELimitedEvent.StoreType store_type;

	public string start_time;

	public string end_time;

	public uint start_timestamp;

	public uint end_timestamp;

	public uint condition;

	public string cdn_url;
}
