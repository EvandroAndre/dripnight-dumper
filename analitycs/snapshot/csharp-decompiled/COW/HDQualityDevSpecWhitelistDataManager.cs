using System;
using GCommon;

namespace COW;

public class HDQualityDevSpecWhitelistDataManager : SingletonModule<HDQualityDevSpecWhitelistDataManager>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<HDQualityDevSpecWhitelistData> _003C_003E9__3_0;

		internal int _003COnInit_003Eb__3_0(HDQualityDevSpecWhitelistData a, HDQualityDevSpecWhitelistData b)
		{
			return 0;
		}
	}

	private HDQualityDevSpecWhitelistData m_matchingDevSpecWhitelistData;

	public HDQualityDevSpecWhitelistData MatchingDevSpecWhitelistData => null;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}
}
