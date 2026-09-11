using ProtoBuf;

namespace proto;

public class NewPlayerSurveyEntranceDesc : IMessage
{
	public uint survey_id;

	public string region;

	public string survey_link;

	public uint[] level_limit;

	public uint[] uid_num;

	public uint[] newbie_choice;

	public string language;

	public bool is_open;

	public uint rewards_show_type;

	public uint rewards_show_id;

	public uint rewards_show_num;

	public uint rewards_show_time;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
