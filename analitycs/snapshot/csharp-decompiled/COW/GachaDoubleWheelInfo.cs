using System;
using System.Collections.Generic;
using proto;

namespace COW;

public class GachaDoubleWheelInfo : GachaPackageInfoData
{
	private sealed class _003C_003Ec__DisplayClass17_0
	{
		public GachaShowItem prize;

		internal bool _003Cget_OwnedPrizeCount_003Eb__0(uint x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass21_0
	{
		public uint id;

		internal bool _003COnUpdateInfoData_003Eb__0(GachaShowItem item)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass21_1
	{
		public uint id;

		internal bool _003COnUpdateInfoData_003Eb__1(GachaShowItem item)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass22_0
	{
		public CSLotteryRes gachaResult;

		internal bool _003CUpdateByGachaResult_003Eb__0(GachaShowItem x)
		{
			return false;
		}

		internal bool _003CUpdateByGachaResult_003Eb__1(GachaShowItem x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass22_1
	{
		public uint id;

		internal bool _003CUpdateByGachaResult_003Eb__2(GachaShowItem x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass22_2
	{
		public uint lastRound;

		public Predicate<ClientDoubleWheelPrice> _003C_003E9__3;

		internal bool _003CUpdateByGachaResult_003Eb__3(ClientDoubleWheelPrice x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass22_3
	{
		public uint id;

		internal bool _003CUpdateByGachaResult_003Eb__4(GachaShowItem item)
		{
			return false;
		}

		internal bool _003CUpdateByGachaResult_003Eb__5(GachaShowItem item)
		{
			return false;
		}
	}

	public uint TotalRound;

	public uint CurrentRound;

	public List<GachaShowItem> CurrentRoundCommonRewards;

	public List<GachaShowItem> GrandPrizes;

	public List<uint> CurrentRoundRemovedRewards;

	public List<uint> RemovedGrandPrizes;

	public GachaShowItem Key;

	public uint LuckySpinCount;

	public uint NewRemovedCommonReward;

	public uint NewRemovedGrandPrize;

	public uint GrandPrizeSequence;

	public uint ComplimentarySpins;

	public List<GachaShowItem> ComplimentaryRewards;

	public uint CurrencyRefund;

	public List<uint> CarouselModelList;

	public uint OwnedPrizeCount => 0u;

	public bool IsFinished => false;

	public void ClearCache()
	{
	}

	protected override void OnProcessDescData(GachaDesc gachaRes)
	{
	}

	protected override void OnUpdateInfoData()
	{
	}

	public override void UpdateByGachaResult(CSLotteryRes gachaResult, UIModelGacha.GachaDrawType drawType = UIModelGacha.GachaDrawType.TYPE_NONE)
	{
	}

	private void RefreshCurrentRoundCommonRewards()
	{
	}

	public uint LimitPurchaseCurCnt()
	{
		return 0u;
	}

	public uint LimitPurchaseCnt()
	{
		return 0u;
	}

	public uint GetOriginalOneBuyPrice()
	{
		return 0u;
	}

	public uint GetLimitOneBuyPrice()
	{
		return 0u;
	}

	public uint GetMultiSpinsCount()
	{
		return 0u;
	}

	public uint GetOriginalMultiBuyPrice()
	{
		return 0u;
	}

	public uint GetLimitMultiBuyPrice()
	{
		return 0u;
	}

	private bool _003CLimitPurchaseCurCnt_003Eb__24_0(ClientDoubleWheelPrice x)
	{
		return false;
	}

	private bool _003CLimitPurchaseCnt_003Eb__25_0(ClientDoubleWheelPrice x)
	{
		return false;
	}

	private bool _003CGetOriginalOneBuyPrice_003Eb__26_0(ClientDoubleWheelPrice x)
	{
		return false;
	}

	private bool _003CGetLimitOneBuyPrice_003Eb__27_0(ClientDoubleWheelPrice x)
	{
		return false;
	}

	private bool _003CGetOriginalMultiBuyPrice_003Eb__29_0(ClientDoubleWheelPrice x)
	{
		return false;
	}

	private bool _003CGetLimitMultiBuyPrice_003Eb__30_0(ClientDoubleWheelPrice x)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnProcessDescData(GachaDesc P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUpdateInfoData()
	{
	}

	public void _003C_003EiFixBaseProxy_UpdateByGachaResult(CSLotteryRes P0, UIModelGacha.GachaDrawType P1)
	{
	}
}
