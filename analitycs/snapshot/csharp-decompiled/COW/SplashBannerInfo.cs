using proto;

namespace COW;

public class SplashBannerInfo
{
	public string region;

	public string language;

	public uint Id;

	public uint Type;

	public string Name;

	public uint SortId;

	public string ImageUrl;

	public string DynamicImageUrl;

	public uint GosPos;

	public string GosUrl;

	public bool UseEmbeddedBrowser;

	public string SubGoPos;

	public string VideoUrl;

	public string BGImgUrl;

	public EAnnouncement.Platform Platform;

	public bool Showed;

	public uint dynamicid;

	public float dynamicsize;

	public float dynamicscale;

	public ulong start_time;

	public ulong end_time;

	public uint WishListId;

	public uint popup_times;

	public uint TextColorType;

	public static implicit operator SplashBannerInfo(SplashBannerDesc data)
	{
		return null;
	}
}
