namespace tcp;

public class GroupAcceptJoinNtf
{
	public ulong group_id;

	public GroupMemberInfo acceptor_info;

	public uint[] map_ids;

	public uint game_mode;

	public uint group_mode;

	public uint match_mode;

	public string secret_code;
}
