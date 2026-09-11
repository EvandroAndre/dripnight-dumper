namespace proto;

public class RestoreArchivedDataReq
{
	public ulong account_id;

	public string lock_region;

	public uint[] batch_ids;

	public string noti_region;
}
