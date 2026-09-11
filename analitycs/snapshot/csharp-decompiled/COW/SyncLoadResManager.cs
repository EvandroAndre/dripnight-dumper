using GCommon;

namespace COW;

public class SyncLoadResManager : SingletonModule<SyncLoadResManager>
{
	private CSVAsyncDataUIntKeyMap<SyncLoadResData> m_DictData;

	protected override void OnCleanup()
	{
	}

	protected override void OnInit()
	{
	}

	public bool NeedSyncLoad(ResourceID resId)
	{
		return false;
	}
}
