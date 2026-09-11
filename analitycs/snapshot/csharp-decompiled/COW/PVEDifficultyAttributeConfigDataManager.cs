using System.Collections.Generic;
using GCommon;

namespace COW;

internal class PVEDifficultyAttributeConfigDataManager : SingletonModule<PVEDifficultyAttributeConfigDataManager>
{
	private readonly List<PVEDifficultyAttributeConfigData> m_Datas;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public PVEDifficultyAttributeConfigData GetBuff(uint groupId)
	{
		return null;
	}
}
