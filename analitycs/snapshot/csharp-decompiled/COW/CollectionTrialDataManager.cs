using GCommon;

namespace COW;

public class CollectionTrialDataManager : SingletonModule<CollectionTrialDataManager>
{
	private CSVAsyncDataMap<uint, CollectionTrialData> m_CollectionTrialIdToRegions;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public bool IsItemCanTrial(uint itemId)
	{
		return false;
	}

	public override bool NeedResetCleanup()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_NeedResetCleanup()
	{
		return false;
	}
}
