using System.Collections.Generic;
using GCommon;

namespace COW;

public class MaxLobbyLogoDataManager : SingletonModule<MaxLobbyLogoDataManager>
{
	private Dictionary<uint, MaxLobbyLogoData> m_Data;

	protected override void OnInit()
	{
	}

	public void LoadWithRegion()
	{
	}

	protected override void OnCleanup()
	{
	}

	public MaxLobbyLogoData GetMaxLobbyLogoData(uint clothesID)
	{
		return null;
	}
}
