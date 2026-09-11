using GCommon;

namespace COW;

public class SoundIDDataManager : SingletonModule<SoundIDDataManager>
{
	private CSVAsyncDataMap<uint, SoundIDData> m_SoundSettings;

	protected override void OnCleanup()
	{
	}

	protected override void OnInit()
	{
	}

	public SoundIDData FindSoundIDDataByResourceID(ResourceID sound)
	{
		return null;
	}
}
