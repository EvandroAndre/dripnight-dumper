namespace proto;

public class CSLeaderboardReq
{
	public int main_type;

	public int sub_type;

	public ulong main_key;

	public ulong sub_key;

	public uint page_index;

	public uint page_size;

	public bool get_self;

	public string region;

	public string lock_region;
}
