using System.Collections.Generic;
using GCommon;

namespace COW;

public class SoundTipsDataManager : SingletonModule<SoundTipsDataManager>
{
	private Dictionary<int, SoundTipsData> m_SoundTipsDict;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public SoundTipsData FindAchievementDataByID(int id)
	{
		return null;
	}
}
