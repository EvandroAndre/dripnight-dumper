using System.Collections.Generic;

namespace proto;

public class PlayerCallbackInfo
{
	public ulong account_id;

	public ulong inviter_id;

	public bool is_callback;

	public List<CallbackTaskInfo> task_infos;
}
