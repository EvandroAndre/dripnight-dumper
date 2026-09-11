using System.Collections.Generic;
using GCommon;

namespace COW;

internal class RequestCoolDownManager : SingletonModule<RequestCoolDownManager>
{
	private Dictionary<string, Timer> m_CoolDownTimerDictionary;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public bool CheckIsNeedRequest(string requestType, float CoolDownSecounds = 1f)
	{
		return false;
	}

	public void UpdateExpiredTime(string requestType, float CoolDownSecounds = 1f)
	{
	}

	public void ResetExpiredTime(string requestType)
	{
	}
}
