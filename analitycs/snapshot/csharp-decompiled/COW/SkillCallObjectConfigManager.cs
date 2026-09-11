using GCommon;

namespace COW;

public class SkillCallObjectConfigManager : SingletonModule<SkillCallObjectConfigManager>
{
	private CSVAsyncDataMap<uint, SkillCallObject> m_SkillCallObjectDataDict;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public SkillCallObject GetSkillCallObjectData(uint objectID)
	{
		return null;
	}
}
