using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class ChampionshipChannelDataManager : SingletonModule<ChampionshipChannelDataManager>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<ChampionshipChannelData> _003C_003E9__5_0;

		internal bool _003COnInit_003Eb__5_0(ChampionshipChannelData e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass6_0
	{
		public int channelID;

		internal bool _003CGetChannelDataByID_003Eb__0(ChampionshipChannelData e)
		{
			return false;
		}
	}

	private ChampionshipChannelData m_DefaultChannel;

	private List<ChampionshipChannelData> m_ChannelList;

	public ChampionshipChannelData DefaultChannel => null;

	protected override void OnCleanup()
	{
	}

	protected override void OnInit()
	{
	}

	public ChampionshipChannelData GetChannelDataByID(int channelID)
	{
		return null;
	}

	public List<ChampionshipChannelData> GetChannelList()
	{
		return null;
	}
}
