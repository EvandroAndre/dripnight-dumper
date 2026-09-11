using ProtoBuf;

namespace proto;

public class CSRankingTaskInfo : IMessage
{
	public CSRankingTaskCdtDesc task_desc;

	public ERankingTask.State state;

	public uint data;

	public long expire_at;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
