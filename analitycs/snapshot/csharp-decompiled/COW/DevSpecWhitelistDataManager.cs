using System;
using GCommon;

namespace COW;

public class DevSpecWhitelistDataManager : SingletonModule<DevSpecWhitelistDataManager>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<DevSpecWhitelistData> _003C_003E9__3_0;

		internal int _003COnInit_003Eb__3_0(DevSpecWhitelistData a, DevSpecWhitelistData b)
		{
			return 0;
		}
	}

	private DevSpecWhitelistData m_matchingDevSpecWhitelistData;

	public DevSpecWhitelistData MatchingDevSpecWhitelistData => null;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}
}
