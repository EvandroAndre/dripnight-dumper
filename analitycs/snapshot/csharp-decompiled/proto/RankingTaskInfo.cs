using ProtoBuf;

namespace proto;

public class RankingTaskInfo : IMessage
{
	public RankingTaskCdtDesc task_desc;

	public ERankingTask.State state;

	public uint data;

	public long expire_at;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
