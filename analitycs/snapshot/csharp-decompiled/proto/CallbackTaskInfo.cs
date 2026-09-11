namespace proto;

public class CallbackTaskInfo
{
	public uint task_id;

	public uint cdt_value;

	public EFriend.CallbackTaskState state;

	private int type;

	public int Type => 0;

	public void SetType(int cdtType)
	{
	}
}
