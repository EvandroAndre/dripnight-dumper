using proto;

namespace COW;

public class ProfileCustomSocialMediaData
{
	public GalleryShow.SocialMediaType MediaType;

	public uint Platform;

	public string PlatformUID;

	public string Name;

	public string Icon;

	public string WebURL;

	public string IOSURL;

	public string AndroidURL;

	public bool IsKOL;

	public bool DisableSet;

	public bool IsLinked;

	public string GetPlatformURL()
	{
		return null;
	}
}
