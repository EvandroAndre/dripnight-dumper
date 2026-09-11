using System.Collections.Generic;
using proto;
using tcp;

namespace COW;

public class CommonRewardItemInfo
{
	public enum RewardLevel
	{
		NONE,
		FIRST,
		SECOND,
		THIRD,
		FOURTH,
		FIFTH
	}

	private sealed class _003C_003Ec__DisplayClass37_0
	{
		public ExchangedAward awardItem;

		internal bool _003CGetRewardInfoWithLaunchTagData_003Eb__0(proto.ItemTagInfo x)
		{
			return false;
		}
	}

	public BaseItemInfo m_OriInfo;

	public BaseItemInfo m_EchInfo;

	public BaseItemInfo m_EchInfo2;

	public CSSharedItemData m_ItemData;

	public uint m_Order;

	public bool IsDropUpBuffed;

	public bool IsSpecialLegendToken;

	public uint m_GachaId;

	public uint m_GachaShowItemId;

	public bool IsGacha;

	public bool IsGachaRewardRemoved;

	public bool IsGachaGrandPrize;

	public GachaLuckyData m_GachaLuckyData;

	public uint m_PermanentBeforeValue;

	public uint m_PermanentAfterValue;

	public bool m_IsLevelUpSpecialReward;

	public int m_SortIndex;

	public bool m_IsComplimentary;

	public bool m_IsBonusIndicator;

	public bool m_IsCurrenyRefund;

	public bool m_IsHippoCrisisItem;

	public bool m_IsGachaExchange;

	public bool m_IsDrawShopExchange;

	public bool m_IsGachaAutoOpenBundle;

	public bool m_IsGachaBundleAutoOpened;

	public bool m_IsBeforeBundleOpen;

	public bool m_IsDrawShopLimitedAndNormalItem;

	public RewardLevel rewardLevel;

	public int SourceType => 0;

	public int TimeLimitDataType => 0;

	public CommonRewardItemInfo DeepCopy()
	{
		return null;
	}

	public static RewardLevel CalRewardLevelRange(uint level)
	{
		return RewardLevel.NONE;
	}

	public static implicit operator CommonRewardItemInfo(ExchangedAward awardItem)
	{
		return null;
	}

	public static implicit operator CommonRewardItemInfo(ExchangedAwardTCP awardItem)
	{
		return null;
	}

	public static CommonRewardItemInfo GetRewardInfoWithLaunchTagData(ExchangedAward awardItem, List<proto.ItemTagInfo> tagList)
	{
		return null;
	}

	public static implicit operator CommonRewardItemInfo(Item item)
	{
		return null;
	}

	public static implicit operator CommonRewardItemInfo(BaseItemInfo itemInfo)
	{
		return null;
	}

	public static implicit operator CommonRewardItemInfo(AwardItemInfo itemInfo)
	{
		return null;
	}

	public static implicit operator CommonRewardItemInfo(OptionalBundleShowData itemInfo)
	{
		return null;
	}

	public static implicit operator CommonRewardItemInfo(HippoCrisisOutGameItemUIData itemInfo)
	{
		return null;
	}

	public bool CanExchang()
	{
		return false;
	}
}
