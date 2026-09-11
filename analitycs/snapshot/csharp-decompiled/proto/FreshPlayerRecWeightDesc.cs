namespace proto;

public class FreshPlayerRecWeightDesc
{
	public enum TagType
	{
		TagType_None,
		TagType_Language,
		TagType_GameModePrefer,
		TagType_SocialWillingnessPrefer,
		TagType_TeamUp,
		TagType_CloseRank
	}

	public TagType tag;

	public string tag_sub_type;

	public uint weight;
}
