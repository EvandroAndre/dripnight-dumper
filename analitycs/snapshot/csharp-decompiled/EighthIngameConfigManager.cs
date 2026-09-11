using COW;
using GCommon;

public class EighthIngameConfigManager : SingletonModule<EighthIngameConfigManager>
{
	private CSVAsyncDataMap<uint, EighthInfiniteEffectData> m_dictIdToEighthInfiniteEffectData;

	protected override void OnCleanup()
	{
	}

	protected override void OnInit()
	{
	}

	public EighthInfiniteEffectData GetEighthInfiniteEffectDataByID(uint id)
	{
		return null;
	}

	public string GetEightInfinteEffectCSDescStringByID(uint id)
	{
		return null;
	}
}
