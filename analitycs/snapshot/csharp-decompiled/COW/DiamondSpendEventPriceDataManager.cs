using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class DiamondSpendEventPriceDataManager : SingletonModule<DiamondSpendEventPriceDataManager>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<DiamondSpendEventPriceData> _003C_003E9__3_1;

		internal bool _003CGetDiamondSpendEventPriceDataByRegion_003Eb__3_1(DiamondSpendEventPriceData x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass3_0
	{
		public string region;

		internal bool _003CGetDiamondSpendEventPriceDataByRegion_003Eb__0(DiamondSpendEventPriceData x)
		{
			return false;
		}
	}

	private List<DiamondSpendEventPriceData> m_DataList;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public DiamondSpendEventPriceData GetDiamondSpendEventPriceDataByRegion(string region)
	{
		return null;
	}
}
