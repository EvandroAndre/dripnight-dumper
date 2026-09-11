using message;
using proto;

namespace COW;

public class RecommendPlanItem : BasicLoadoutPlanItem
{
	public string Region;

	public uint[] TagsID;

	public string Desc;

	public bool IsV2;

	public uint Role;

	public uint LikeCount;

	public ulong RecommenderAccountID;

	public string RecommenderNickname;

	public LoadoutScheme.RecommendTag RecommendTag;

	public uint SchemeId;

	public bool HasLiked;

	public ERecommenderType RecommenderType;

	public NIKKALKPIBO GameMode;

	public BadgeInfo KOLBadgeInfo;

	public uint HeadPic;

	public ExternalIconInfo ExternalIconInfo;

	public uint AvatarFrame;

	public uint KolRole;

	public static implicit operator RecommendPlanItem(PlayerPlanItem playerPlan)
	{
		return null;
	}
}
