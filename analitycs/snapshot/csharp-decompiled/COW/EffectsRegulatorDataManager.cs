using GCommon;

namespace COW;

public class EffectsRegulatorDataManager : SingletonModule<EffectsRegulatorDataManager>
{
	private CSVAsyncDataMap<uint, EffectsRegulatorData> m_DicData;

	protected override void OnCleanup()
	{
	}

	protected override void OnInit()
	{
	}

	public EffectsRegulatorData GetEffectRegularData(ResourceID key)
	{
		return null;
	}
}
