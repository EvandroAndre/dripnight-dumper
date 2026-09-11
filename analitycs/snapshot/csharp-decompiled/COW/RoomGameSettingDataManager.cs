using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class RoomGameSettingDataManager : SingletonModule<RoomGameSettingDataManager>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<RoomGameSettingData> _003C_003E9__2_0;

		internal bool _003COnInit_003Eb__2_0(RoomGameSettingData d)
		{
			return false;
		}
	}

	private Dictionary<uint, List<uint>> m_ModeSettings;

	private List<uint> m_CommonSettingList;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public List<uint> GetGameSettingListByGameMode(uint gameMode)
	{
		return null;
	}
}
