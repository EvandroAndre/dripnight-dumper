using System.Collections.Generic;

namespace COW.GamePlay.UGCRuntime;

public class UGCFFPlatformModule : IUGCModule
{
	private UGCRuntime m_ugcRuntime;

	private bool m_ShowSocialChooseBox;

	public void Init(object[] args)
	{
	}

	public void LoadParameters(Dictionary<object, object> parameters)
	{
	}

	public void Destroy()
	{
	}

	public UGCFFPlatformModule Create(UGCRuntime ugcRuntime)
	{
		return null;
	}

	public bool IsShowSocialChooseBox(ulong user_id)
	{
		return false;
	}
}
