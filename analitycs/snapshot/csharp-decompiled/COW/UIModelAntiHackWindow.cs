using GCommon;
using proto;

namespace COW;

public class UIModelAntiHackWindow : UIBaseModel
{
	private string m_AntiHackCenterUrl;

	private string m_BanListUrl;

	public override uint GetModelType()
	{
		return 0u;
	}

	public string GetAntiHackCenterUrl()
	{
		return null;
	}

	public string GetBanListUrl()
	{
		return null;
	}

	public bool NeedShowIconInLobby()
	{
		return false;
	}

	public void ProcessAntiHackCenterDesc(CSAntiHackCenterDescRes desc)
	{
	}
}
