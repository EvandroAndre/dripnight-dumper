using System.Collections.Generic;
using proto;

namespace COW;

public class WorkshopAuthorInfo
{
	public List<UISceneEditRecommendationItemInfo> MapList;

	public uint Create_Times;

	public ulong Liked_Times;

	public ulong Subscription_Times;

	public uint Account_Info_Exp;

	public CraftlandCreatorStats Creator_Stats;

	public ulong Author_ID;

	public uint Author_Tag;

	public uint[] Kol_Label_ID;

	public string Kol_Desc;

	public GalleryShow.SocialMediaType DisplaySocialMediaType;

	public GallerySocialMediaInfo MediaInfo;

	public ulong Pull_Time;

	public bool ShowTab()
	{
		return false;
	}
}
