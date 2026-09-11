using System.Collections.Generic;
using message;

namespace COW.GamePlay.UGCRuntime;

public class UGCPremiumModule : IUGCModule
{
	private UGCRuntime m_UGCRuntime;

	private UIModelUGCPremium m_PremiumModel;

	private int m_Config_ExpireCheckInterval;

	private uint m_LastExpireCheckTimeMs;

	private bool m_IsVip;

	private object[] m_EventArgs;

	public UGCPremiumModule Create(UGCRuntime ugcRuntime)
	{
		return null;
	}

	public void Init(object[] args)
	{
	}

	public void LoadParameters(Dictionary<object, object> parameters)
	{
	}

	public void OnTickEventHandle()
	{
	}

	public void Destroy()
	{
	}

	public bool IsPremium(out ADFCFJBKADI status)
	{
		status = default(ADFCFJBKADI);
		return false;
	}

	public void OpenPremiumCenter(out ADFCFJBKADI status)
	{
		status = default(ADFCFJBKADI);
	}

	public long GetPremiumExpireDate(out ADFCFJBKADI status)
	{
		status = default(ADFCFJBKADI);
		return 0L;
	}
}
