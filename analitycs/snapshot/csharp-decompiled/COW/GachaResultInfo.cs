using System.Collections.Generic;
using proto;

namespace COW;

public class GachaResultInfo
{
	private sealed class _003C_003Ec__DisplayClass15_0
	{
		public CSLotteryRes gachaResult;
	}

	private sealed class _003C_003Ec__DisplayClass15_1
	{
		public uint id;

		internal bool _003CProcessGachaResultInfo1_003Eb__0(GachaShowItem x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass15_2
	{
		public int i;

		public _003C_003Ec__DisplayClass15_0 CS_0024_003C_003E8__locals1;

		internal bool _003CProcessGachaResultInfo1_003Eb__1(GachaShowItem x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass15_3
	{
		public int i;

		public _003C_003Ec__DisplayClass15_0 CS_0024_003C_003E8__locals2;

		internal bool _003CProcessGachaResultInfo1_003Eb__2(GachaShowItem x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass17_0
	{
		public GachaDoubleWheelInfo dwInfo;

		internal bool _003CIsGachaRewardRemoved_003Eb__0(GachaShowItem x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass18_0
	{
		public uint id;

		internal bool _003CIsComplimentary_003Eb__0(GachaShowItem x)
		{
			return false;
		}
	}

	public uint gachaId;

	public bool hasBundleOpened;

	public UIModelGacha.GachaDrawType gachaType;

	public List<ExchangedAward> lotteries;

	public List<ItemTagInfo> launchTagInfos;

	public List<uint> showitemids;

	public List<ExchangedAward> lotteriesExcludeBundleOpened;

	public List<ExchangedAward> lotteriesBundleOpened;

	public List<ExchangedAward_Gacha> lotteriesBeforeOpenBundle;

	public List<ExchangedAward_Gacha> lotteriesAfterOpenBundle;

	public bool hasSuperGrandPrize;

	public bool isFirstSuperGrandPrize;

	public uint grandPrizeCount;

	public Dictionary<uint, uint> removedPrizeIdToDrawCount;

	public Dictionary<uint, float> removedPrizeIdToLuckyPoints;

	public void ProcessGachaResultInfo1(uint chestID, UIModelGacha.GachaDrawType drawType, CSLotteryRes gachaResult)
	{
	}

	public void ProcessGachaResultInfo2()
	{
	}

	private bool IsGachaRewardRemoved(uint chestID, uint id)
	{
		return false;
	}

	private bool IsComplimentary(uint chestID, uint id)
	{
		return false;
	}

	private int CompareAwardList(ExchangedAward a, ExchangedAward b)
	{
		return 0;
	}

	private int CompareAwardList(ExchangedAward_Gacha a, ExchangedAward_Gacha b)
	{
		return 0;
	}
}
