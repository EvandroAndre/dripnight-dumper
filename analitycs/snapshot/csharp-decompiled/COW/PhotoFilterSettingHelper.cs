using proto;

namespace COW;

public static class PhotoFilterSettingHelper
{
	public static EPhotoSettingType GetType(PhotoFilterSettingDesc d)
	{
		return EPhotoSettingType.Invalid;
	}

	public static string GetFxResource(PhotoFilterSettingDesc d)
	{
		return null;
	}

	public static bool IsVerticalFxResource(PhotoFilterSettingDesc d)
	{
		return false;
	}

	public static bool IsLobby2DFxResource(PhotoFilterSettingDesc d)
	{
		return false;
	}
}
