using System.Collections.Generic;
using GCommon;

namespace COW;

public class NewPlayerMissionDataManager : SingletonModule<NewPlayerMissionDataManager>
{
	private const int NEW_PLAYER_EVENT_DAYS = 7;

	private List<NewPlayerSevenDaysData> missionTable;

	private List<NewPlayerSevenDaysAwardData> awardTable;

	private Dictionary<uint, uint[]> achievementId2SubMissionsDict;

	protected override void OnCleanup()
	{
	}

	protected override void OnInit()
	{
	}

	public uint[] GetSubMissionsById(uint id)
	{
		return null;
	}

	public NewPlayerSevenDaysAwardData GetMissionTodayById(uint id)
	{
		return null;
	}

	public NewPlayerSevenDaysData GetMissionById(uint id)
	{
		return null;
	}
}
