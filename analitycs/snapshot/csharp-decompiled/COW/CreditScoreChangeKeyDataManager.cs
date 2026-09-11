using System.Collections.Generic;
using GCommon;

namespace COW;

public class CreditScoreChangeKeyDataManager : SingletonModule<CreditScoreChangeKeyDataManager>
{
	private sealed class _003C_003Ec__DisplayClass4_0
	{
		public uint reasonId;

		internal bool _003CGetData_003Eb__0(CreditScoreChangeKeyData value)
		{
			return false;
		}
	}

	private List<CreditScoreChangeKeyData> m_DataList;

	public const string DEFAULT_CHANGE_KEY = "T_39_L_CREDIT_REPORTREASONNOTFOUND";

	protected override void OnCleanup()
	{
	}

	protected override void OnInit()
	{
	}

	private CreditScoreChangeKeyData GetData(uint reasonId)
	{
		return null;
	}

	public string GetReasonLocKey(uint reasonId)
	{
		return null;
	}
}
