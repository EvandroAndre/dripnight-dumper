namespace COW;

public class NewRecruitReqInfo
{
	public uint MinRank;

	public uint MaxRank;

	public bool OpenMapBonus;

	public uint[] GroupTags;

	public uint SpecialModeEventId;

	public bool SendWorld;

	public bool SendGuild;

	public bool SendNewbie;

	public NewRecruitReqInfo(uint minRank, uint maxRank, bool openMapBonus, uint[] groupTags, uint specialModeEventId, bool sendWorld, bool sendGuild, bool sendNewbie = false)
	{
	}
}
