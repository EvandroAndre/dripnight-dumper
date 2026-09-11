using System.Collections.Generic;
using message;

namespace COW;

public static class BRMatchReviewPositionSampleUtil
{
	private const int SAMPLE_TO_WORLD_INT_SCALE = 10;

	public static int ToWorldIntX(LFLECLCELPH pos)
	{
		return 0;
	}

	public static int ToWorldIntZ(LFLECLCELPH pos)
	{
		return 0;
	}

	public static bool IsFromFake(LFLECLCELPH pos)
	{
		return false;
	}

	public static byte ToShortPlayerID(uint playerID)
	{
		return 0;
	}

	public static uint ToFullPlayerID(LFLECLCELPH pos, Dictionary<byte, uint> shortToFullPlayerId)
	{
		return 0u;
	}

	public static Dictionary<byte, uint> BuildShortToFullPlayerIDMap(EIENIBNLACM matchData)
	{
		return null;
	}

	public static Dictionary<byte, uint> BuildShortToFullPlayerIDMap(List<JODHCHIKNEP> teams)
	{
		return null;
	}
}
