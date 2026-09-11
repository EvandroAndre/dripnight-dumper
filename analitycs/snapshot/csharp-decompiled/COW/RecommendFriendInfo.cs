using proto;
using tcp;

namespace COW;

public class RecommendFriendInfo
{
	public ulong AccountID;

	public string Nickname;

	public int Rank;

	public int RankPoint;

	public int PeakRankPos;

	public proto.ESocial.Gender Gender;

	public EFriendRecommendType Type;

	public uint HeadPic;

	public string ExternalIcon;

	public proto.EAccount.ExternalIconStatus ExternalIconStatus;

	public proto.EAccount.ExternalIconShowType ExternalIconShowType;

	public AccountMatchVeteranData AccountMatchVeteranData;

	public uint VeteranTag;

	public uint PlayerProficiencyType;

	public string LockRegion;

	public tcp.BadgeInfo BadgeInfo;

	public uint Role;

	public tcp.PrimePrivilegeDetail PrimeInfo;

	public uint CSPeakTournamentPoints;

	public uint AvatarFrameID;

	public bool ShowCSPeakTournamentRank;

	public string ReasonLocKey;

	public int ReasonCount;
}
