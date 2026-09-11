using System.Collections.Generic;
using ProtoBuf;

namespace tcp;

public class EighthBApplyDecorationInfo : IMessage
{
	public List<EighthBApplyDecoration> eighthb_apply_decorations;

	public bool is_apply_group_leader;

	public string ai_train;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
