using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class NationFlagDataManager : SingletonModule<NationFlagDataManager>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<NationFlagData> _003C_003E9__3_0;

		public static Comparison<NationFlagData> _003C_003E9__3_1;

		public static Predicate<NationFlagData> _003C_003E9__4_0;

		internal bool _003COnInit_003Eb__3_0(NationFlagData e)
		{
			return false;
		}

		internal int _003COnInit_003Eb__3_1(NationFlagData e, NationFlagData o)
		{
			return 0;
		}

		internal bool _003COpenedDatas_003Eb__4_0(NationFlagData e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass5_0
	{
		public string countryOrArea;

		internal bool _003CGet_003Eb__0(NationFlagData e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass6_0
	{
		public string countryOrArea;

		internal bool _003CGetWithDefault_003Eb__0(NationFlagData e)
		{
			return false;
		}
	}

	private List<NationFlagData> m_datas;

	public const string DEFAULT_FLAG = "A_DEFAULT";

	protected override void OnCleanup()
	{
	}

	protected override void OnInit()
	{
	}

	public List<NationFlagData> OpenedDatas()
	{
		return null;
	}

	public NationFlagData Get(string countryOrArea)
	{
		return null;
	}

	public NationFlagData GetWithDefault(string countryOrArea)
	{
		return null;
	}
}
