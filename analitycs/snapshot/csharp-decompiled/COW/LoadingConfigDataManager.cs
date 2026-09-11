using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class LoadingConfigDataManager : SingletonModule<LoadingConfigDataManager>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<CSVBaseData, LoadingConfigData> _003C_003E9__2_0;

		internal LoadingConfigData _003COnInit_003Eb__2_0(CSVBaseData input)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass3_0
	{
		public uint currentLevel;

		internal bool _003CGetRandomLoadingCDNAndTipsByLoadingType_003Eb__0(LoadingConfigData data)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass3_1
	{
		public uint currentGameModeId;

		public uint currentMapId;

		public uint currentMatchModeId;

		public _003C_003Ec__DisplayClass3_0 CS_0024_003C_003E8__locals1;

		internal bool _003CGetRandomLoadingCDNAndTipsByLoadingType_003Eb__1(LoadingConfigData data)
		{
			return false;
		}
	}

	private Dictionary<uint, List<LoadingConfigData>> m_Data;

	protected override void OnCleanup()
	{
	}

	protected override void OnInit()
	{
	}

	public void GetRandomLoadingCDNAndTipsByLoadingType(uint loadingType, out string cdnUrl, out string tips)
	{
		cdnUrl = null;
		tips = null;
	}
}
