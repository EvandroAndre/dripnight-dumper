using System.Collections.Generic;
using GCommon;

namespace COW;

public class PayItemDisplayManager : SingletonModule<PayItemDisplayManager>
{
	private Dictionary<string, PayItemDisplay_iOS_Data> m_Dict;

	private List<CSVBaseData> m_DataList;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public PayItemDisplay_iOS_Data GetPayItemDisplayIOSDataByItemIdentifier(string itemIdentifier)
	{
		return null;
	}

	public List<CSVBaseData> GetPayItemDisplayIOSDataList()
	{
		return null;
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
