using proto;
using tcp;

namespace COW;

public class ActivityClientInfo
{
	public uint id;

	public uint data;

	public proto.EActivity.State state;

	public uint[] multi_states;

	public proto.EActivity.State GetMultiState(int index)
	{
		return proto.EActivity.State.State_RECEIVED;
	}

	public static implicit operator ActivityClientInfo(ActivityInfo activity)
	{
		return null;
	}

	public static implicit operator ActivityClientInfo(tcp.ActivityUpdateInfo activityUpdate)
	{
		return null;
	}
}
