namespace proto;

public class ClanActivenessRecord
{
	public ulong account_id;

	public uint activeness;

	public EClan.ActivenessSourceType source;

	public long create_at;
}
