using GCommon;

namespace COW;

public class RecommendRoomDataManager : SingletonModule<RecommendRoomDataManager>
{
	private RecommendRoomData m_RecommendRoomData;

	private RecommendRoomData RecommendRoomData => null;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public bool IsHotRoomType(uint roomType)
	{
		return false;
	}

	public bool IsNewRoomType(uint roomType)
	{
		return false;
	}

	public bool IsHotGameMode(uint gameMode)
	{
		return false;
	}

	public bool IsHotRoomSetting(UIModelCustomRoom.ECustomRoomGameSetting roomGameSetting)
	{
		return false;
	}

	public bool IsNewRoomSetting(UIModelCustomRoom.ECustomRoomGameSetting roomGameSetting)
	{
		return false;
	}

	public bool IsPrivilegeRoomSetting(UIModelCustomRoom.ECustomRoomGameSetting roomGameSetting)
	{
		return false;
	}

	public bool NeedShowTag(UIModelCustomRoom.ECustomRoomGameSetting roomGameSetting)
	{
		return false;
	}

	public bool IsNewGameMode(uint gameMode)
	{
		return false;
	}

	public bool IsNewPreset(uint presetId)
	{
		return false;
	}

	public bool IsHotPreset(uint presetId)
	{
		return false;
	}
}
