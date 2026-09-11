namespace proto;

public class ELive
{
	public enum FollowerType
	{
		FollowerType_NONE,
		FollowerType_YES,
		FollowerType_NO
	}

	public enum VideoType
	{
		VideoType_NONE = 0,
		VideoType_HOTEST = 1,
		VideoType_LIVE_NOW = 2,
		VideoType_EXPLORE = 3,
		VideoType_TUTORIAL = 4,
		VideoType_ALL = 100,
		VideoType_NEWEST = 101,
		VideoType_POPULAR = 102,
		VideoType_OTHER = 103
	}
}
