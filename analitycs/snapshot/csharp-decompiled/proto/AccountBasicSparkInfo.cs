using ProtoBuf;

namespace proto;

public class AccountBasicSparkInfo : IMessage
{
	public bool claimed;

	public SparkInfo user_spark_info;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
