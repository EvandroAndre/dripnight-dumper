using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class RankingTaskCdtDesc : IMessage
{
	public uint task_id;

	public string key;

	public uint match_mode;

	public uint game_mode;

	public ERankingTask.PreConditionType pre_cdt_type1;

	public uint pre_cdt_value1;

	public ERankingTask.PreConditionType pre_cdt_type2;

	public uint pre_cdt_value2;

	public ERankingTask.PreConditionType pre_cdt_type3;

	public uint pre_cdt_value3;

	public ERankingTask.ConditionType cdt_type;

	public uint cdt_value;

	public AwardDesc award;

	public uint award_point_num;

	public bool no_rp_drop;

	public ERankingTask.Type task_type;

	public string notify_key;

	public List<AwardDesc> awards;

	public List<AwardDesc> show_awards;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
