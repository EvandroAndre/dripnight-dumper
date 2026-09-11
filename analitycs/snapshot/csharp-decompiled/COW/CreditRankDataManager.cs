using System.Collections.Generic;
using GCommon;

namespace COW;

public class CreditRankDataManager : SingletonModule<CreditRankDataManager>
{
	private sealed class _003C_003Ec__DisplayClass3_0
	{
		public uint score;

		internal bool _003CGetData_003Eb__0(CreditRankData value)
		{
			return false;
		}
	}

	private List<CreditRankData> m_DataList;

	protected override void OnCleanup()
	{
	}

	protected override void OnInit()
	{
	}

	public CreditRankData GetData(uint score)
	{
		return null;
	}

	public List<string> GetCreditRankRuleData()
	{
		return null;
	}
}
