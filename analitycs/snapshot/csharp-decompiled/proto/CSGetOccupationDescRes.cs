using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSGetOccupationDescRes : IMessage
{
	public OccupationSettingDesc settings;

	public List<OccupationDesc> occupations;

	public List<OccupationProficiencyLevelDesc> proficiency_levels;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
