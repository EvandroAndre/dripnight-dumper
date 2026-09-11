using System;
using System.Collections.Generic;

namespace COW.Gameplay.UGC;

[Serializable]
public class UGCTutorialLevelData
{
	public string levelId;

	public int sortIndex;

	public string defaultTabIndex;

	public List<UGCTutorialTaskData> tasks;

	public int GetDefaultTabIndex()
	{
		return 0;
	}
}
