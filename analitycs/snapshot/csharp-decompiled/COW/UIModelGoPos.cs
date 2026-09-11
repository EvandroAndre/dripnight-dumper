using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIModelGoPos : UIBaseModel
{
	private sealed class _003C_003Ec__DisplayClass5_0
	{
		public ulong now;

		internal bool _003CFindGoPosByTime_003Eb__0(GoPos pos)
		{
			return false;
		}
	}

	private Dictionary<uint, List<GoPos>> m_GoPosData;

	public override uint GetModelType()
	{
		return 0u;
	}

	public void ProcessGoPosDate(CSGetGoPosRes res)
	{
	}

	public List<GoPos> GetGoPosDataList(uint id)
	{
		return null;
	}

	public GoPos GetGoPosData(uint id)
	{
		return null;
	}

	private Predicate<GoPos> FindGoPosByTime(ulong now)
	{
		return null;
	}

	private int SortGoPos(GoPos a, GoPos b)
	{
		return 0;
	}
}
