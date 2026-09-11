using System.Collections.Generic;
using GCommon;

namespace COW;

public class AchievementsDataManager : SingletonModule<AchievementsDataManager>
{
	private Dictionary<int, AchievementData> m_AchievementsDict;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public AchievementData FindAchievementDataByID(int id)
	{
		return null;
	}

	public AchievementData GetTopPriorityAchievementData(uint[] achievementList)
	{
		return null;
	}
}
