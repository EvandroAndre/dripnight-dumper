using GCommon;

namespace COW;

public class LUPCDNDataManager : SingletonModule<LUPCDNDataManager>
{
	private CSVAsyncDataMap<uint, LUPCDNData> m_Dict;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public override bool NeedResetCleanup()
	{
		return false;
	}

	public string GetLUPCDNUrlByType(uint type)
	{
		return null;
	}

	public bool _003C_003EiFixBaseProxy_NeedResetCleanup()
	{
		return false;
	}
}
