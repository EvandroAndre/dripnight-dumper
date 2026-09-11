using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

internal class IPTagConfigDataManager : SingletonModule<IPTagConfigDataManager>
{
	private Dictionary<uint, IPTagConfigData> m_IPTagConfigDict;

	protected override void OnInit()
	{
	}

	public void ProcessServerIPTagConfigData(CSGetIPTagConfigRes res)
	{
	}

	protected override void OnCleanup()
	{
	}

	public override bool NeedResetCleanup()
	{
		return false;
	}

	public IPTagConfigData GetIPTagConfigData(uint id)
	{
		return null;
	}

	public bool _003C_003EiFixBaseProxy_NeedResetCleanup()
	{
		return false;
	}
}
