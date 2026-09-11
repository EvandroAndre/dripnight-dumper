using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSGetNewPlayerSurveyEntranceDescRes : IMessage
{
	public List<NewPlayerSurveyEntranceDesc> np_survey_entrance_descs;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
