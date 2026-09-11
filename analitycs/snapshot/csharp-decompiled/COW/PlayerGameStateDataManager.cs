using System.Collections.Generic;
using GCommon;

namespace COW;

internal class PlayerGameStateDataManager : SingletonModule<PlayerGameStateDataManager>
{
	private Dictionary<uint, PlayerGameStateData> m_Data;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public PlayerGameStateData GetPlayerGameStateData(uint id)
	{
		return null;
	}
}
