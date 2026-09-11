using System;
using System.Collections.Generic;
using GCommon;
using proto;
using tcp;

namespace COW;

public class UIModelGamePattern : UIBaseModel
{
	private sealed class _003C_003Ec__DisplayClass6_0
	{
		public uint gameModeID;

		public Predicate<MMRInfo> _003C_003E9__0;

		internal bool _003CHasMatchGamePattern_003Eb__0(MMRInfo x)
		{
			return false;
		}
	}

	private readonly Dictionary<uint, GamePatternConfigDesc> m_DicGamePatternToGamePatternConfigDesc;

	private readonly List<GamePatternConfigDesc> m_ListPatternReady;

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Logout(object[] data)
	{
	}

	public void ProcessGamePattern(List<GamePatternConfigDesc> gamePatternConfigs)
	{
	}

	public GamePatternConfigDesc GetGamePatternData(uint gamePatternID)
	{
		return null;
	}

	public bool HasMatchGamePattern(uint matchModeID, uint gameModeID, out uint gamePattern)
	{
		gamePattern = default(uint);
		return false;
	}

	public string GetGamePatternTitle(uint gamePattern)
	{
		return null;
	}

	private uint GetMatchGameModeKey(uint matchModeID, uint gameModeID)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
