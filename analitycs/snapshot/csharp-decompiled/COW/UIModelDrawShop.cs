using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIModelDrawShop : UIBaseModel
{
	public struct CardPoolQualitySkinData(uint quality, string brSpriteName)
	{
		public uint Quality = 0u;

		public string BRSpriteName = null;
	}

	public enum EDrawShopType
	{
		None,
		TokenWheel,
		TokenTower,
		LimitedPool
	}

	public enum EDrawShopCachedContentType
	{
		None,
		TokenWheel,
		TokenTower,
		LimitedPool,
		TokenTower_ELS_TT53,
		TokenWheel_CDNChangeSkin
	}

	public enum EDrawShopWheelCustomType : uint
	{
		Common = 0u,
		BRNinth = 1u,
		BRBloodmoon26 = 2u,
		Invalid = uint.MaxValue
	}

	public enum EDrawShopDiscountType
	{
		None,
		Discount,
		LimitedDiscount,
		DailyDiscount
	}

	public enum EDrawShopItemType
	{
		Item = 1,
		Coins,
		Gems
	}

	public enum EDrawShopCoinType
	{
		DefaultGems,
		Coins,
		Gems
	}

	public enum EDrawShopShowType
	{
		Normal,
		FullScreen,
		CDNImage
	}

	public enum EDrawShopEntranceType
	{
		None,
		LobbyEntrance
	}

	public enum EDrawShopTokenTowerType
	{
		Normal,
		ELS_TT53
	}

	public enum ERareType
	{
		Normal,
		Rare,
		SuperRare
	}

	public enum EDrawShopDrawType
	{
		None,
		Single,
		Multi
	}

	public enum EDrawShopBuyBtnState
	{
		Normal,
		Free,
		LimitDiscountFree,
		DailyDiscountFree,
		CouponOnlyA,
		CouponOnlyB,
		LimitDiscount,
		DailyDiscount,
		MixedCouponA,
		MixedCouponB,
		RegularDiscount,
		Insufficient,
		Disabled
	}

	public struct UnlimitedDiscountResult
	{
		public EDrawShopDiscountType DiscountType;

		public DrawShopWheelDiscountDesc ActiveDiscountDesc;

		public uint UsedCount;

		public uint DiscountPrice;

		public uint OriginalPrice;

		public uint DiscountPercent;

		public uint LimitNum;

		public bool IsValid;
	}

	public struct UnlimitedMixedPurchaseResult
	{
		public uint CouponDrawCount;

		public uint CouponCost;

		public uint CurrencyCost;

		public uint CouponItemId;

		public int ExchangeIndex;

		public bool IsValid;
	}

	public class DrawShopPurchaseParams
	{
		public uint SinglePurchaseItemIndex;

		public EDrawShop.PurChaseType PurchaseType;

		public uint GemsCost;

		public uint CoinsCost;

		public EDrawShopCoinType CoinType;

		public List<ExchangeItemNum> ExchangeItems;

		public void SetCurrencyCost(EDrawShopCoinType coinType, uint cost)
		{
		}

		public void AddExchangeItem(uint itemId, uint num)
		{
		}

		public DrawShopPrice ToProtocolPrice()
		{
			return null;
		}
	}

	public class DrawShopUniversalData
	{
		public ulong PrimeStartTime;

		public ulong StartTime;

		public ulong EndTime;

		public uint[] ChestModelIds;

		public float CarouselTime;

		public uint[] ShowTypeList;

		public string CdnModelDrawing;

		public EDrawShopCoinType CoinType;

		public uint OncePrice;

		public uint TenPrice;

		public uint[] ExchangeItemIds;

		public uint ExchangeRatio;

		public uint[] ExchangeItemIds2;

		public uint ExchangeRatio2;

		public uint FreeType;

		public uint FreeCd;

		public uint ChestModelId => 0u;

		public uint ExchangeItemId => 0u;

		public uint ExchangeItemId2 => 0u;

		public bool IsActive()
		{
			return false;
		}

		public bool IsPrimeActive()
		{
			return false;
		}

		public bool IsInPrimeExclusivePeriod()
		{
			return false;
		}

		public ulong GetRemainingTime()
		{
			return 0uL;
		}

		public bool HasFreeSupport()
		{
			return false;
		}
	}

	public class DrawShopDiscountDesc
	{
		public uint ChestId;

		public EDrawShopDiscountType DiscountType;

		public ulong DiscountStartTime;

		public ulong DiscountEndTime;

		public List<uint> DiscountPriceOneList;

		public List<uint> DiscountPriceTenList;

		public uint LimitNumOne;

		public uint LimitNumTen;

		public bool IsActive()
		{
			return false;
		}

		public uint GetDiscountPrice(EDrawShopDrawType drawType, int usedCount)
		{
			return 0u;
		}
	}

	public class RepeatChangeItemInfo
	{
		public uint ItemId;

		public uint ItemNum;

		public uint ItemId2;

		public uint ItemNum2;

		public static readonly RepeatChangeItemInfo Empty;

		public bool HasRepeatChangeItem => false;

		public bool HasRepeatChangeItem2 => false;

		public RepeatChangeItemInfo()
		{
		}

		public RepeatChangeItemInfo(uint id, uint num, uint id2, uint num2)
		{
		}
	}

	public class DrawShopGoodsDesc
	{
		public uint ChestId;

		public uint Id;

		public EDrawShopItemType RewardItemType;

		public uint ItemId;

		public uint ItemNum;

		public uint ItemDuration;

		public ERareType RareType;

		public bool IsRemove;

		public uint DropLimit;

		public uint BaseProbability;

		public uint SecondLevelProbability;

		public uint ThirdLevelProbability;

		public uint FourthLevelProbability;

		public uint FifthLevelProbability;

		public EDrawShopItemType RepeatChangeItemType;

		public uint RepeatChangeItemId;

		public uint RepeatChangeItemNum;

		public EDrawShopItemType RepeatChangeItemType2;

		public uint RepeatChangeItemId2;

		public uint RepeatChangeItemNum2;

		public bool TokenFlag;

		public bool RareItem => false;

		public bool IsSuperRare => false;
	}

	public class DrawShopTokenRewardDesc
	{
		public uint ChestId;

		public uint CdtValue;

		public bool RareReward;

		public EDrawShopItemType AwardType1;

		public uint AwardId1;

		public uint AwardNum1;

		public uint AwardTime1;

		public EDrawShopItemType RepeatChangeItemType1;

		public uint RepeatChangeItemId1;

		public uint RepeatChangeItemNum1;
	}

	public class DrawShopExchangeDesc
	{
		public uint ChestId;

		public uint Id;

		public uint ItemId;

		public uint ItemNum;

		public uint ItemDuration;

		public uint SortId;

		public uint LimitedPurchaseTimes;

		public EDrawShopItemType ExchangeType1;

		public uint ExchangeItem1;

		public uint ExchangeNum1;

		public bool QuickShow;

		public bool IsBigIcon;
	}

	public class DrawShopChangeSkinDesc
	{
		public uint ChestId;

		public string TitleUIFX;

		public string LeftButtonUIFX;

		public string RightButtonUIFX;

		public Vector3 LeftDiscountPos;

		public Vector3 RightDiscountPos;

		public uint DiscountUIFXType;

		public string BackgroundUIFX;

		public string LobbyEntranceUIFX;

		public string CardBackUIFX;

		public string TableUIFX;

		public string BigRewardUIFX;

		public string BigRewardDropUIFX;

		public string PermRewardUIFX;
	}

	public class DrawShopInfoData
	{
		public uint ChestId;

		public uint DrawCount;

		public uint TokenProgress;

		public List<uint> ClaimedTokenRewardIds;

		public List<uint> ClaimedExchangeIds;

		public List<uint> RemovedGoodsIds;

		public ulong LastFreeTime;

		public uint LimitDiscountUsedCountOne;

		public uint LimitDiscountUsedCountMulti;

		public uint DailyDiscountUsedCountOne;

		public long DailyDiscountOneTime;

		public uint DailyDiscountUsedCountMulti;

		public long DailyDiscountMultiTime;

		public uint DiscountUsedCountOne;

		public uint DiscountUsedCountTen;

		public uint GuaranteeCount;
	}

	public class LimitedDrawShopInfoData
	{
		public uint ChestId;

		public uint DrawCount;

		public List<uint> RewardPoolItemIds;

		public List<uint> PendingBuyPoolItemIds;

		public List<uint> RemovedPoolItemIds;
	}

	public class DrawShopPoolShowData
	{
		public uint GoodsId;

		public uint ItemId;

		public uint ItemNum;

		public uint ItemDuration;

		public ERareType RareType;

		public bool IsObtained;

		public bool IsRemoved;

		public bool IsToken;

		public float DropRate;

		public bool IsRareItem => false;

		public bool IsSuperRare => false;
	}

	public class DrawShopTokenProgressShowData
	{
		public uint CdtValue;

		public uint AwardId;

		public uint AwardNum;

		public uint AwardDuration;

		public bool IsRareReward;

		public bool IsClaimed;

		public bool IsClaimable;
	}

	public class DrawShopExchangeShowData
	{
		public uint ExchangeId;

		public uint ItemId;

		public uint ItemNum;

		public uint ItemDuration;

		public uint ExchangeCostId;

		public uint ExchangeCostNum;

		public uint LimitedTimes;

		public uint PurchasedTimes;

		public bool IsBigIcon;

		public bool QuickShow;

		public bool CanExchange;
	}

	public abstract class DrawShopContentDataBase
	{
		private uint _003CDrawShopId_003Ek__BackingField;

		private EDrawShopType _003CShopType_003Ek__BackingField;

		private DrawShopCommonDesc _003CCommonDesc_003Ek__BackingField;

		private DrawShopUniversalData _003CUniversalData_003Ek__BackingField;

		public uint DrawShopId
		{
			get
			{
				return _003CDrawShopId_003Ek__BackingField;
			}
			protected set
			{
				_003CDrawShopId_003Ek__BackingField = value;
			}
		}

		public EDrawShopType ShopType
		{
			get
			{
				return _003CShopType_003Ek__BackingField;
			}
			protected set
			{
				_003CShopType_003Ek__BackingField = value;
			}
		}

		public DrawShopCommonDesc CommonDesc
		{
			get
			{
				return _003CCommonDesc_003Ek__BackingField;
			}
			protected set
			{
				_003CCommonDesc_003Ek__BackingField = value;
			}
		}

		public DrawShopUniversalData UniversalData
		{
			get
			{
				return _003CUniversalData_003Ek__BackingField;
			}
			protected set
			{
				_003CUniversalData_003Ek__BackingField = value;
			}
		}

		public bool IsLoaded => false;

		public abstract void ClearData();

		public virtual bool HasInfoData()
		{
			return false;
		}

		public abstract bool IsNeedShowRedDot();

		public virtual bool HasFreeChance()
		{
			return false;
		}

		public void SetCommonDesc(DrawShopCommonDesc commonDesc)
		{
		}

		public virtual bool HasActiveDiscount()
		{
			return false;
		}

		public virtual uint GetDiscountPrice(EDrawShopDrawType drawType, int usedCount)
		{
			return 0u;
		}

		public virtual bool IsDiscountAvailable(EDrawShopDrawType drawType, uint usedCount)
		{
			return false;
		}

		public virtual uint GetDiscountLimitNum(EDrawShopDrawType drawType)
		{
			return 0u;
		}

		public virtual EDrawShopDiscountType GetActiveDiscountType(EDrawShopDrawType drawType)
		{
			return EDrawShopDiscountType.None;
		}

		public virtual uint GetActiveDiscountUsedCount(EDrawShopDrawType drawType)
		{
			return 0u;
		}

		public virtual bool IsGoodsRemovable(uint goodsId)
		{
			return false;
		}

		public virtual bool IsItemNeedShowFinished(uint itemId)
		{
			return false;
		}

		public virtual bool IsGoodsNeedShowMax1(uint goodsId)
		{
			return false;
		}

		public virtual uint GetGoodsDuration(uint goodsId)
		{
			return 0u;
		}

		public virtual bool IsItemRare(uint itemId)
		{
			return false;
		}

		public virtual List<uint> GetRareItemIds()
		{
			return null;
		}
	}

	public class DrawShopWheelContentData : DrawShopContentDataBase
	{
		private DrawShopWheelTypeDesc _003CTypeDesc_003Ek__BackingField;

		private List<ClientDrawShopWheelGoodsDesc> _003CGoodsList_003Ek__BackingField;

		private List<DrawShopWheelDiscountDesc> _003CDiscountList_003Ek__BackingField;

		private DrawShopWheelChangeSkinDesc _003CChangeSkinDesc_003Ek__BackingField;

		private List<DrawShopWheelExchangeDesc> _003CExchangeList_003Ek__BackingField;

		private PBAccountDrawShopWheelInfo _003CInfoData_003Ek__BackingField;

		public DrawShopWheelTypeDesc TypeDesc
		{
			get
			{
				return _003CTypeDesc_003Ek__BackingField;
			}
			private set
			{
				_003CTypeDesc_003Ek__BackingField = value;
			}
		}

		public List<ClientDrawShopWheelGoodsDesc> GoodsList
		{
			get
			{
				return _003CGoodsList_003Ek__BackingField;
			}
			private set
			{
				_003CGoodsList_003Ek__BackingField = value;
			}
		}

		public List<DrawShopWheelDiscountDesc> DiscountList
		{
			get
			{
				return _003CDiscountList_003Ek__BackingField;
			}
			private set
			{
				_003CDiscountList_003Ek__BackingField = value;
			}
		}

		public DrawShopWheelChangeSkinDesc ChangeSkinDesc
		{
			get
			{
				return _003CChangeSkinDesc_003Ek__BackingField;
			}
			private set
			{
				_003CChangeSkinDesc_003Ek__BackingField = value;
			}
		}

		public List<DrawShopWheelExchangeDesc> ExchangeList
		{
			get
			{
				return _003CExchangeList_003Ek__BackingField;
			}
			private set
			{
				_003CExchangeList_003Ek__BackingField = value;
			}
		}

		public PBAccountDrawShopWheelInfo InfoData
		{
			get
			{
				return _003CInfoData_003Ek__BackingField;
			}
			private set
			{
				_003CInfoData_003Ek__BackingField = value;
			}
		}

		public void LoadFromProtocol(uint drawShopId, DrawShopWheelTypeDesc wheelTypeDesc, List<ClientDrawShopWheelGoodsDesc> goodsDescs, List<DrawShopWheelDiscountDesc> discountDescs, DrawShopWheelChangeSkinDesc changeSkinDesc, List<DrawShopWheelExchangeDesc> exchangeDescs)
		{
		}

		private void PopulateUniversalData(DrawShopWheelTypeDesc wheelTypeDesc, DrawShopWheelChangeSkinDesc skinDesc)
		{
		}

		public override bool HasInfoData()
		{
			return false;
		}

		public void SetInfoData(PBAccountDrawShopWheelInfo wheelInfo)
		{
		}

		public void UpdateExchangeInfo(DrawShopWheelExchangeInfo exchangeInfo)
		{
		}

		public override bool IsNeedShowRedDot()
		{
			return false;
		}

		public override bool HasFreeChance()
		{
			return false;
		}

		public bool HasFreeDiscount()
		{
			return false;
		}

		public bool isCanExchangeItem()
		{
			return false;
		}

		private bool IsExchangeItemFullyPurchased(DrawShopWheelExchangeDesc exchange)
		{
			return false;
		}

		public override void ClearData()
		{
		}

		public override bool HasActiveDiscount()
		{
			return false;
		}

		public override uint GetDiscountPrice(EDrawShopDrawType drawType, int usedCount)
		{
			return 0u;
		}

		public override bool IsDiscountAvailable(EDrawShopDrawType drawType, uint usedCount)
		{
			return false;
		}

		public override uint GetDiscountLimitNum(EDrawShopDrawType drawType)
		{
			return 0u;
		}

		public override EDrawShopDiscountType GetActiveDiscountType(EDrawShopDrawType drawType)
		{
			return EDrawShopDiscountType.None;
		}

		public override uint GetActiveDiscountUsedCount(EDrawShopDrawType drawType)
		{
			return 0u;
		}

		private DrawShopWheelDiscountDesc GetActiveDiscountDesc(EDrawShopDrawType drawType)
		{
			return null;
		}

		private uint GetDiscountUsedCountByType(EDrawShopDrawType drawType, EDrawShop.DiscountType discountType)
		{
			return 0u;
		}

		private uint GetDailyDiscountUsedCount(uint count, long lastTime)
		{
			return 0u;
		}

		public override bool IsGoodsRemovable(uint goodsId)
		{
			return false;
		}

		public override bool IsGoodsNeedShowMax1(uint goodsId)
		{
			return false;
		}

		public override uint GetGoodsDuration(uint goodsId)
		{
			return 0u;
		}

		public override bool IsItemRare(uint itemId)
		{
			return false;
		}

		public override List<uint> GetRareItemIds()
		{
			return null;
		}

		public bool _003C_003EiFixBaseProxy_HasInfoData()
		{
			return false;
		}

		public bool _003C_003EiFixBaseProxy_HasFreeChance()
		{
			return false;
		}

		public bool _003C_003EiFixBaseProxy_HasActiveDiscount()
		{
			return false;
		}

		public uint _003C_003EiFixBaseProxy_GetDiscountPrice(EDrawShopDrawType P0, int P1)
		{
			return 0u;
		}

		public bool _003C_003EiFixBaseProxy_IsDiscountAvailable(EDrawShopDrawType P0, uint P1)
		{
			return false;
		}

		public uint _003C_003EiFixBaseProxy_GetDiscountLimitNum(EDrawShopDrawType P0)
		{
			return 0u;
		}

		public EDrawShopDiscountType _003C_003EiFixBaseProxy_GetActiveDiscountType(EDrawShopDrawType P0)
		{
			return EDrawShopDiscountType.None;
		}

		public uint _003C_003EiFixBaseProxy_GetActiveDiscountUsedCount(EDrawShopDrawType P0)
		{
			return 0u;
		}

		public bool _003C_003EiFixBaseProxy_IsGoodsRemovable(uint P0)
		{
			return false;
		}

		public bool _003C_003EiFixBaseProxy_IsGoodsNeedShowMax1(uint P0)
		{
			return false;
		}

		public uint _003C_003EiFixBaseProxy_GetGoodsDuration(uint P0)
		{
			return 0u;
		}

		public bool _003C_003EiFixBaseProxy_IsItemRare(uint P0)
		{
			return false;
		}

		public List<uint> _003C_003EiFixBaseProxy_GetRareItemIds()
		{
			return null;
		}
	}

	public class DrawShopTowerContentData : DrawShopContentDataBase
	{
		private DrawShopTowerTypeDesc _003CTypeDesc_003Ek__BackingField;

		private List<ClientDrawShopTowerGoodsDesc> _003CGoodsList_003Ek__BackingField;

		private List<DrawShopTowerDiscountDesc> _003CDiscountList_003Ek__BackingField;

		private List<DrawShopTowerRewardDesc> _003CRewardDescList_003Ek__BackingField;

		private DrawShopTowerChangeSkinDesc _003CChangeSkinDesc_003Ek__BackingField;

		private PBAccountDrawShopTowerInfo _003CInfoData_003Ek__BackingField;

		public DrawShopTowerTypeDesc TypeDesc
		{
			get
			{
				return _003CTypeDesc_003Ek__BackingField;
			}
			private set
			{
				_003CTypeDesc_003Ek__BackingField = value;
			}
		}

		public List<ClientDrawShopTowerGoodsDesc> GoodsList
		{
			get
			{
				return _003CGoodsList_003Ek__BackingField;
			}
			private set
			{
				_003CGoodsList_003Ek__BackingField = value;
			}
		}

		public List<DrawShopTowerDiscountDesc> DiscountList
		{
			get
			{
				return _003CDiscountList_003Ek__BackingField;
			}
			private set
			{
				_003CDiscountList_003Ek__BackingField = value;
			}
		}

		public List<DrawShopTowerRewardDesc> RewardDescList
		{
			get
			{
				return _003CRewardDescList_003Ek__BackingField;
			}
			private set
			{
				_003CRewardDescList_003Ek__BackingField = value;
			}
		}

		public DrawShopTowerChangeSkinDesc ChangeSkinDesc
		{
			get
			{
				return _003CChangeSkinDesc_003Ek__BackingField;
			}
			private set
			{
				_003CChangeSkinDesc_003Ek__BackingField = value;
			}
		}

		public PBAccountDrawShopTowerInfo InfoData
		{
			get
			{
				return _003CInfoData_003Ek__BackingField;
			}
			private set
			{
				_003CInfoData_003Ek__BackingField = value;
			}
		}

		public void LoadFromProtocol(uint drawShopId, DrawShopTowerTypeDesc typeDesc, List<ClientDrawShopTowerGoodsDesc> goodsDescs, List<DrawShopTowerDiscountDesc> discountDescs, List<DrawShopTowerRewardDesc> rewardDescs, DrawShopTowerChangeSkinDesc changeSkinDesc)
		{
		}

		private void PopulateUniversalData(DrawShopTowerTypeDesc towerTypeDesc, DrawShopTowerChangeSkinDesc skinDesc)
		{
		}

		public void SetInfoData(PBAccountDrawShopTowerInfo towerInfo)
		{
		}

		public override bool HasInfoData()
		{
			return false;
		}

		public override void ClearData()
		{
		}

		public override bool IsNeedShowRedDot()
		{
			return false;
		}

		public bool HasFreeDiscount()
		{
			return false;
		}

		public bool HasClaimableTowerReward()
		{
			return false;
		}

		public override bool HasFreeChance()
		{
			return false;
		}

		public override bool IsItemRare(uint itemId)
		{
			return false;
		}

		public override List<uint> GetRareItemIds()
		{
			return null;
		}

		public override bool HasActiveDiscount()
		{
			return false;
		}

		public override uint GetDiscountPrice(EDrawShopDrawType drawType, int usedCount)
		{
			return 0u;
		}

		public override bool IsDiscountAvailable(EDrawShopDrawType drawType, uint usedCount)
		{
			return false;
		}

		public override uint GetDiscountLimitNum(EDrawShopDrawType drawType)
		{
			return 0u;
		}

		public override EDrawShopDiscountType GetActiveDiscountType(EDrawShopDrawType drawType)
		{
			return EDrawShopDiscountType.None;
		}

		public override uint GetActiveDiscountUsedCount(EDrawShopDrawType drawType)
		{
			return 0u;
		}

		public DrawShopTowerDiscountDesc GetActiveDiscountDesc(EDrawShopDrawType drawType)
		{
			return null;
		}

		private uint GetDiscountUsedCountByType(EDrawShopDrawType drawType, EDrawShop.DiscountType discountType)
		{
			return 0u;
		}

		private uint GetDailyDiscountUsedCount(uint count, long lastTime)
		{
			return 0u;
		}

		public override bool IsGoodsRemovable(uint goodsId)
		{
			return false;
		}

		public override bool IsGoodsNeedShowMax1(uint goodsId)
		{
			return false;
		}

		public override uint GetGoodsDuration(uint goodsId)
		{
			return 0u;
		}

		public bool _003C_003EiFixBaseProxy_HasInfoData()
		{
			return false;
		}

		public bool _003C_003EiFixBaseProxy_HasFreeChance()
		{
			return false;
		}

		public bool _003C_003EiFixBaseProxy_IsItemRare(uint P0)
		{
			return false;
		}

		public List<uint> _003C_003EiFixBaseProxy_GetRareItemIds()
		{
			return null;
		}

		public bool _003C_003EiFixBaseProxy_HasActiveDiscount()
		{
			return false;
		}

		public uint _003C_003EiFixBaseProxy_GetDiscountPrice(EDrawShopDrawType P0, int P1)
		{
			return 0u;
		}

		public bool _003C_003EiFixBaseProxy_IsDiscountAvailable(EDrawShopDrawType P0, uint P1)
		{
			return false;
		}

		public uint _003C_003EiFixBaseProxy_GetDiscountLimitNum(EDrawShopDrawType P0)
		{
			return 0u;
		}

		public EDrawShopDiscountType _003C_003EiFixBaseProxy_GetActiveDiscountType(EDrawShopDrawType P0)
		{
			return EDrawShopDiscountType.None;
		}

		public uint _003C_003EiFixBaseProxy_GetActiveDiscountUsedCount(EDrawShopDrawType P0)
		{
			return 0u;
		}

		public bool _003C_003EiFixBaseProxy_IsGoodsRemovable(uint P0)
		{
			return false;
		}

		public bool _003C_003EiFixBaseProxy_IsGoodsNeedShowMax1(uint P0)
		{
			return false;
		}

		public uint _003C_003EiFixBaseProxy_GetGoodsDuration(uint P0)
		{
			return 0u;
		}
	}

	public class DrawShopLimitedPoolContentData : DrawShopContentDataBase
	{
		private DrawShopLimitedPoolSettingDesc _003CSettingDesc_003Ek__BackingField;

		private Dictionary<uint, ClientDrawShopLimitedPoolGoodsDesc> _003CGoodsDict_003Ek__BackingField;

		private DrawShopLimitedPoolChangeSkinDesc _003CChangeSkinDesc_003Ek__BackingField;

		private LimitedDrawShopInfoData _003CInfoData_003Ek__BackingField;

		public DrawShopLimitedPoolSettingDesc SettingDesc
		{
			get
			{
				return _003CSettingDesc_003Ek__BackingField;
			}
			private set
			{
				_003CSettingDesc_003Ek__BackingField = value;
			}
		}

		public Dictionary<uint, ClientDrawShopLimitedPoolGoodsDesc> GoodsDict
		{
			get
			{
				return _003CGoodsDict_003Ek__BackingField;
			}
			private set
			{
				_003CGoodsDict_003Ek__BackingField = value;
			}
		}

		public DrawShopLimitedPoolChangeSkinDesc ChangeSkinDesc
		{
			get
			{
				return _003CChangeSkinDesc_003Ek__BackingField;
			}
			private set
			{
				_003CChangeSkinDesc_003Ek__BackingField = value;
			}
		}

		public LimitedDrawShopInfoData InfoData
		{
			get
			{
				return _003CInfoData_003Ek__BackingField;
			}
			private set
			{
				_003CInfoData_003Ek__BackingField = value;
			}
		}

		public void LoadFromProtocol(uint drawShopId, DrawShopLimitedPoolSettingDesc settingDesc, List<ClientDrawShopLimitedPoolGoodsDesc> goodsDescs, DrawShopLimitedPoolChangeSkinDesc changeSkinDesc)
		{
		}

		private void PopulateUniversalData(DrawShopLimitedPoolSettingDesc settingDesc, DrawShopLimitedPoolChangeSkinDesc skinDesc)
		{
		}

		public override bool HasInfoData()
		{
			return false;
		}

		public void SetInfoData(LimitedPoolInfo limitedPoolInfo)
		{
		}

		public override void ClearData()
		{
		}

		public override bool HasFreeChance()
		{
			return false;
		}

		public override bool IsNeedShowRedDot()
		{
			return false;
		}

		public override bool IsItemRare(uint itemId)
		{
			return false;
		}

		public override List<uint> GetRareItemIds()
		{
			return null;
		}

		public bool _003C_003EiFixBaseProxy_HasInfoData()
		{
			return false;
		}

		public bool _003C_003EiFixBaseProxy_HasFreeChance()
		{
			return false;
		}

		public bool _003C_003EiFixBaseProxy_IsItemRare(uint P0)
		{
			return false;
		}

		public List<uint> _003C_003EiFixBaseProxy_GetRareItemIds()
		{
			return null;
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<DrawShopContentDataBase> _003C_003E9__138_0;

		internal int _003CGetAllActiveContentData_003Eb__138_0(DrawShopContentDataBase a, DrawShopContentDataBase b)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass139_0
	{
		public bool hasPrimePrivilege;

		internal int _003CGetAllContentDataForDisplay_003Eb__0(DrawShopContentDataBase a, DrawShopContentDataBase b)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass228_0
	{
		public UIModelDrawShop _003C_003E4__this;

		public Action<bool> callback;

		internal void _003CRequestDrawShopDesc_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass231_0
	{
		public UIModelDrawShop _003C_003E4__this;

		public uint chestId;

		public EDrawShopDrawType drawType;

		public DrawShopPurchaseParams purchaseParams;

		public Action<bool> callback;

		internal void _003CProcessWheelDrawRequest_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass232_0
	{
		public UIModelDrawShop _003C_003E4__this;

		public uint chestId;

		public EDrawShopDrawType drawType;

		public DrawShopPurchaseParams purchaseParams;

		public Action<bool> callback;

		internal void _003CProcessTowerDrawRequest_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass234_0
	{
		public UIModelDrawShop _003C_003E4__this;

		public uint chestId;

		public EDrawShopDrawType drawType;

		public DrawShopPurchaseParams purchaseParams;

		internal void _003CShowDrawRewardPopupSimple_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass235_0
	{
		public UIModelDrawShop _003C_003E4__this;

		public uint chestId;

		public EDrawShopDrawType drawType;

		public DrawShopPurchaseParams purchaseParams;

		internal void _003CShowDrawRewardPopupWithBundleOpen_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass237_0
	{
		public UIModelDrawShop _003C_003E4__this;

		public uint drawShopId;

		internal void _003CRequestPurchaseLimitedPoolItem_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass240_0
	{
		public UIModelDrawShop _003C_003E4__this;

		public uint drawShopId;

		internal void _003CRequestLimitedPoolProbability_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass241_0
	{
		public UIModelDrawShop _003C_003E4__this;

		public uint drawShopId;

		internal void _003CRequestWheelProbability_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass242_0
	{
		public UIModelDrawShop _003C_003E4__this;

		public uint drawShopId;

		internal void _003CRequestTowerProbability_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass243_0
	{
		public UIModelDrawShop _003C_003E4__this;

		public uint shopId;

		public uint purchaseCnt;

		public Action<bool> callback;

		internal void _003CRequestPurchaseTowerToken_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass245_0
	{
		public UIModelDrawShop _003C_003E4__this;

		public uint shopId;

		public DrawShopPurchaseParams purchaseParams;

		internal void _003CShowTowerTokenPurchaseRewardPopup_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass246_0
	{
		public UIModelDrawShop _003C_003E4__this;

		public uint shopId;

		public uint cdtValue;

		internal void _003CRequestClaimTowerReward_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass248_0
	{
		public UIModelDrawShop _003C_003E4__this;

		public uint shopId;

		public uint cdtValue;

		internal void _003CShowTowerRewardPopup_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass250_0
	{
		public UIModelDrawShop _003C_003E4__this;

		public uint shopId;

		public uint exchangeId;

		public uint exchangeCnt;

		public Action<bool> callback;

		internal void _003CRequestExchange_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass253_0
	{
		public UIModelDrawShop _003C_003E4__this;

		public Action<bool> callback;

		internal void _003CRequestAccountDrawShopInfo_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public UIModelDrawShop _003C_003E4__this;

		public Action<bool> callback;

		public Action<bool> _003C_003E9__1;

		internal void _003CRequestInitialData_003Eb__0(bool descSuccess)
		{
		}

		internal void _003CRequestInitialData_003Eb__1(bool infoSuccess)
		{
		}
	}

	public const int QUALITY_LOW = 0;

	public const int QUALITY_MIDDLE = 1;

	public const int QUALITY_HIGH = 2;

	public const uint PropID_DrawShopDescUpdate = 2u;

	public const uint PropID_DrawShopInfoUpdate = 4u;

	public const uint PropID_DrawShopDrawSuccess = 8u;

	public const uint PropID_DrawShopDrawFailed = 16u;

	public const uint PropID_DrawShopRedDot = 32u;

	public const uint PropID_DrawShopTokenUpdate = 64u;

	public const uint PropID_DrawShopTabChange = 128u;

	public const uint PropID_DrawShopTokenRewardClaimed = 256u;

	public const uint PropID_DrawShopExchangeSuccess = 512u;

	public const uint PropID_DrawShopDiscountUpdate = 1024u;

	public const uint PropID_DrawShopRewardWndClosed = 2048u;

	public const uint PropID_DrawShopProbabilityUpdate = 4096u;

	public const uint PropID_DrawShopWheelProbabilityUpdate = 8192u;

	public const uint PropID_DrawShopTowerProbabilityUpdate = 16384u;

	public const int CDNType_MainBg = 60001;

	public const int CDNType_TabIcon = 60002;

	public const int CDNType_TitleBanner = 60003;

	public const int CDNType_RewardPreview = 60004;

	public const int CDNType_LobbyEntrance = 60005;

	public const string ANIM_MAIN_ENTER = "UIDrawShop_Main_Enter";

	public const string ANIM_MAIN_EXIT = "UIDrawShop_Main_Exit";

	public const string ANIM_DRAW_SINGLE = "UIDrawShop_Draw_Single";

	public const string ANIM_DRAW_MULTI = "UIDrawShop_Draw_Multi";

	public const string ANIM_REWARD_SHOW = "UIDrawShop_Reward_Show";

	public const string ANIM_TAB_SWITCH = "UIDrawShop_Tab_Switch";

	public const string ANIM_TOKEN_PROGRESS = "UIDrawShop_Token_Progress";

	public const string LOC_TITLE = "TXT_DRAWSHOP_TITLE";

	public const string LOC_DRAW_SINGLE = "TXT_DRAWSHOP_DRAW_SINGLE";

	public const string LOC_DRAW_MULTI = "TXT_DRAWSHOP_DRAW_MULTI";

	public const string LOC_FREE = "TXT_DRAWSHOP_FREE";

	public const string LOC_TOKEN_INSUFFICIENT = "TXT_DRAWSHOP_TOKEN_INSUFFICIENT";

	public const string LOC_REWARD_CLAIMED = "TXT_DRAWSHOP_REWARD_CLAIMED";

	public const string LOC_RULES_TITLE = "TXT_DRAWSHOP_RULES_TITLE";

	public const string LOC_GUARANTEE_DESC = "TXT_DRAWSHOP_GUARANTEE_DESC";

	public const string LOC_EXCHANGE_TITLE = "TXT_DRAWSHOP_EXCHANGE_TITLE";

	public const string LOC_TOKEN_PROGRESS_TITLE = "TXT_DRAWSHOP_TOKEN_PROGRESS_TITLE";

	public const uint MAX_TAB_COUNT = 6u;

	public const float DRAW_ANIM_DURATION = 2f;

	public const float REWARD_SHOW_DELAY = 0.5f;

	public const uint ENDING_SOON_THRESHOLD = 86400u;

	public const uint FREE_CD_DEFAULT = 86400u;

	public const bool ENABLE_LOCAL_CARD_POOL_VFX_FALLBACK = true;

	public const string LOCAL_BIG_PRIZE_UIFX = "UIFX_DRAWSHOPWHEEL_BIGPRIZE";

	public const string LOCAL_BIG_PRIZE_PRIMARY_UIFX = "UIFX_DRAWSHOP_CARDPOOLITEM_COMMON_BOOM";

	public const string LOCAL_BIG_PRIZE_SECONDARY_UIFX = "UIFX_DRAWSHOP_CARDPOOLITEM_COMMON_GLOW";

	public const string LOCAL_COMPLETION_UIFX = "UIFX_DRAWSHOP_CARDPOOLITEM_COMMON_DOWN";

	public const string LOCAL_SWEEP_LIGHT_UIFX = "UIFX_DRAWSHOPWHEEL_PRIZE_SAOGUANG";

	public const string LOCAL_SELECTED_UIFX = "UIFX_DRAWSHOPWHEEL_PRIZE_SELECT";

	public const string BR_SELECTED_SPRITE = "FF_UI_BR_select";

	public const string BR_OWNED_SPRITE = "FF_UI_BR_Owned";

	public static readonly string[] SELECTED_STATE_SKIN_SPRITE_LIST;

	public static readonly string[] OWNED_STATE_SKIN_SPRITE_LIST;

	public static readonly CardPoolQualitySkinData[] BR_QUALITY_SKIN_DATA_LIST;

	private const string PREFS_SHOWN_TUTORIAL = "DrawShop_ShownTutorial_{0}_{1}";

	private const string PREFS_LAST_SELECTED_TAB = "DrawShop_LastSelectedTab_{0}";

	public const string PREFS_DRAWSHOP_PRIME_TIPS_DAILY_SHOW_KEY = "DrawShopPrimeTipsDailyShowStamp_{0}_{1}";

	public const string PREFS_DRAWSHOP_UNLIMITED_FIRST_ENTRANCE_SHOWN = "DrawShop_UnlimitedFirstEntranceShown_{0}_{1}";

	public const string DRAWSHOP_UNLIMITED_EXCHANGE_DAILY_KEY = "DrawShop_Unlimited_Exchange_Daily_{0}_{1}";

	public const string PREFS_SHOW_ANIM_KEY = "ShowCGVideo_DrawShop_{0}_{1}";

	public const string PREFS_DRAWSHOP_UNLIMITED_NO_SHOW_ANIMATION = "DrawShop_Unlimited_NoShowAnimation_{0}";

	public const string CSV_KEY_DRAWSHOP_TYPE = "DrawShopType";

	public const string CSV_KEY_DRAWSHOP_DISCOUNT = "DrawShopDiscount";

	public const string CSV_KEY_DRAWSHOP_GOODS = "DrawShopGoods";

	public const string CSV_KEY_DRAWSHOP_TOKEN_REWARD = "DrawShopTokenReward";

	public const string CSV_KEY_DRAWSHOP_EXCHANGE = "DrawShopExchange";

	public const string CSV_KEY_DRAWSHOP_CHANGE_SKIN = "DrawShopChangeSkin";

	private Dictionary<uint, DrawShopContentDataBase> m_DrawShopContentDataDict;

	private HashSet<uint> m_RarePreOwnedSnapshot;

	private bool m_HasFreeChance;

	private bool m_HasClaimableReward;

	private Dictionary<uint, int> m_LimitedPoolSelectedDropItemIndex;

	private Dictionary<int, string> m_CDNUrlCache;

	private bool m_NoShowConfirmWnd;

	private bool m_NoShowLimitedConfirmWnd;

	private bool m_NoShowDrawAnimation;

	private string m_NoShowDrawAnimationPrefsKey;

	private bool m_IsDescFetched;

	private bool m_IsInfoFetched;

	private bool m_IsRequestingDraw;

	private bool m_IsRequestingAccountInfo;

	private double m_LastRequestTimestamp;

	private uint m_LastTowerTokenPurchaseCount;

	private Dictionary<uint, CSDrawShopGetLimitedPoolProbabilityRes> m_LimitedPoolProbabilityCache;

	private Dictionary<uint, CSDrawShopGetWheelProbabilityRes> m_WheelProbabilityCache;

	private Dictionary<uint, CSDrawShopGetTowerProbabilityRes> m_TowerProbabilityCache;

	private Dictionary<uint, uint> m_TowerProbabilityCacheTokenSnapshot;

	public bool NoShowConfirmWnd
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool NoShowLimitedConfirmWnd
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool NoShowDrawAnimation
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsDataReady => false;

	public bool IsRequestingDraw => false;

	public uint LastTowerTokenPurchaseCount => 0u;

	public override void Init()
	{
	}

	public override void Logout(object[] data)
	{
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	private void RegisterEvents()
	{
	}

	private void UnregisterEvents()
	{
	}

	private void OnInventoryChanged(uint propID, object[] data)
	{
	}

	private void OnDailyRefresh(object[] args)
	{
	}

	public void RequestInitialData(Action<bool> callback = null)
	{
	}

	public bool HasAvailableChest()
	{
		return false;
	}

	public bool HasRedDot()
	{
		return false;
	}

	public void ShowInsufficientMainCurrencyHint(uint drawShopId, uint requiredAmount, string message = "", string title = "", string okText = "")
	{
	}

	public bool HasFreeDiscount(uint chestId)
	{
		return false;
	}

	public void ClaimTowerReward(uint shopId, uint cdtValue)
	{
	}

	public bool GetLobbyEntranceData(out uint chestId, out ulong remainingTime, out bool hasFree)
	{
		chestId = default(uint);
		remainingTime = default(ulong);
		hasFree = default(bool);
		return false;
	}

	public bool ShouldShowLobbyEntrance()
	{
		return false;
	}

	public uint GetLobbyEntranceDrawShopId()
	{
		return 0u;
	}

	public UnlimitedDiscountResult CalcUnlimitedDiscountResult(uint chestId, EDrawShopDrawType drawType)
	{
		return default(UnlimitedDiscountResult);
	}

	public UnlimitedMixedPurchaseResult CalcUnlimitedMixedPurchaseResult(uint chestId, int exchangeIndex)
	{
		return default(UnlimitedMixedPurchaseResult);
	}

	public EDrawShopBuyBtnState CalcUnlimitedBuyBtnState(uint chestId, EDrawShopDrawType drawType)
	{
		return EDrawShopBuyBtnState.Normal;
	}

	public DrawShopPurchaseParams BuildUnlimitedPurchaseParams(uint chestId, EDrawShopDrawType drawType, uint selectedItemIndex = 0u)
	{
		return null;
	}

	public bool CheckUnlimitedCurrencyEnough(uint chestId, EDrawShopDrawType drawType)
	{
		return false;
	}

	public bool CheckUnlimitedCouponEnough(uint chestId, EDrawShopDrawType drawType)
	{
		return false;
	}

	private DrawShopWheelDiscountDesc GetUnlimitedActiveDiscountDesc(uint chestId, EDrawShopDrawType drawType)
	{
		return null;
	}

	private DrawShopWheelDiscountDesc GetUnlimitedTowerActiveDiscountDesc(uint chestId, EDrawShopDrawType drawType)
	{
		return null;
	}

	private uint GetUnlimitedDiscountUsedCount(uint chestId, EDrawShopDrawType drawType, EDrawShopDiscountType discountType)
	{
		return 0u;
	}

	private uint GetUnlimitedTowerDiscountUsedCount(uint chestId, EDrawShopDrawType drawType, EDrawShopDiscountType discountType)
	{
		return 0u;
	}

	private uint GetDailyDiscountUsedCount(uint count, long lastTime)
	{
		return 0u;
	}

	private EDrawShopDiscountType ConvertProtoDiscountType(EDrawShop.DiscountType protoType)
	{
		return EDrawShopDiscountType.None;
	}

	private bool IsStateFree(EDrawShopBuyBtnState state)
	{
		return false;
	}

	private bool IsStateCouponOnly(EDrawShopBuyBtnState state)
	{
		return false;
	}

	private bool IsStateMixed(EDrawShopBuyBtnState state)
	{
		return false;
	}

	public bool CheckRareItemsAvailable(uint chestId)
	{
		return false;
	}

	private bool CheckWheelRareItemsAvailable(DrawShopWheelContentData wheelData)
	{
		return false;
	}

	private bool IsWheelRareItemUnavailable(PBAccountDrawShopWheelInfo infoData, ClientDrawShopWheelGoodsDesc goods, UIModelGacha modelGacha)
	{
		return false;
	}

	private bool CheckTowerRareItemsAvailable(DrawShopTowerContentData towerData)
	{
		return false;
	}

	private bool IsTowerRareItemUnavailable(PBAccountDrawShopTowerInfo infoData, ClientDrawShopTowerGoodsDesc goods, UIModelGacha modelGacha)
	{
		return false;
	}

	public uint GetTowerTokenItemId(uint chestId)
	{
		return 0u;
	}

	public uint GetTowerTokenGoodsId(uint chestId)
	{
		return 0u;
	}

	public uint GetTokenInCardPool(uint chestId)
	{
		return 0u;
	}

	private void InitData()
	{
	}

	private void ClearAllData()
	{
	}

	public DrawShopContentDataBase GetContentData(uint drawShopId)
	{
		return null;
	}

	public DrawShopWheelContentData GetWheelContentData(uint drawShopId)
	{
		return null;
	}

	public DrawShopTowerContentData GetTowerContentData(uint drawShopId)
	{
		return null;
	}

	public DrawShopLimitedPoolContentData GetLimitedPoolContentData(uint drawShopId)
	{
		return null;
	}

	public void SetLimitedPoolSelectedDropItemIndex(uint drawShopId, int dropItemIndex)
	{
	}

	public int GetLimitedPoolSelectedDropItemIndex(uint drawShopId)
	{
		return 0;
	}

	public void ClearLimitedPoolSelectedDropItemIndex(uint drawShopId)
	{
	}

	public int GetContentDataCount()
	{
		return 0;
	}

	public List<DrawShopContentDataBase> GetAllActiveContentData()
	{
		return null;
	}

	public List<DrawShopContentDataBase> GetAllContentDataForDisplay(bool useCache = false, bool requireInfo = true)
	{
		return null;
	}

	public DrawShopUniversalData GetUniversalData(uint chestId)
	{
		return null;
	}

	public EDrawShopCoinType GetCoinType(uint chestId)
	{
		return EDrawShopCoinType.DefaultGems;
	}

	public EInventory.AwardType GetCurrencyAwardType(uint chestId)
	{
		return EInventory.AwardType.AwardType_NONE;
	}

	public uint GetUserCurrencyCount(uint chestId)
	{
		return 0u;
	}

	public DrawShopWheelTypeDesc GetUnlimitedWheelTypeDesc(uint chestId)
	{
		return null;
	}

	public int GetChestCount()
	{
		return 0;
	}

	public DrawShopContentDataBase GetContentDataByIndex(int index)
	{
		return null;
	}

	public DrawShopContentDataBase GetDefaultContentData()
	{
		return null;
	}

	public EDrawShopType GetChestType(uint chestId)
	{
		return EDrawShopType.None;
	}

	public bool IsNoShowDrawAnimationSupported(uint chestId)
	{
		return false;
	}

	public bool ShouldNoShowDrawAnimation(uint chestId)
	{
		return false;
	}

	private void EnsureNoShowDrawAnimationLoaded()
	{
	}

	private void LoadNoShowDrawAnimation()
	{
	}

	private string GetNoShowDrawAnimationPrefsKey()
	{
		return null;
	}

	public List<DrawShopWheelDiscountDesc> GetUnlimitedWheelDiscountDescList(uint chestId)
	{
		return null;
	}

	public bool HasActiveDiscount(uint chestId)
	{
		return false;
	}

	public uint GetDiscountPrice(uint chestId, EDrawShopDrawType drawType)
	{
		return 0u;
	}

	public bool IsDiscountAvailable(uint chestId, EDrawShopDrawType drawType)
	{
		return false;
	}

	public uint GetDiscountUsedCount(uint chestId, EDrawShopDrawType drawType)
	{
		return 0u;
	}

	public bool IsGoodsRemovable(uint chestId, uint goodsId)
	{
		return false;
	}

	public bool IsItemNeedShowMax1(uint chestId, uint goodsId)
	{
		return false;
	}

	public DrawShopLimitedPoolSettingDesc GetLimitedPoolSettingDesc(uint drawShopId)
	{
		return null;
	}

	public Dictionary<uint, ClientDrawShopLimitedPoolGoodsDesc> GetLimitedPoolGoodsDict(uint drawShopId)
	{
		return null;
	}

	public DrawShopLimitedPoolChangeSkinDesc GetLimitedPoolChangeSkinDesc(uint drawShopId)
	{
		return null;
	}

	public DrawShopWheelChangeSkinDesc GetUnlimitedWheelChangeSkinDesc(uint drawShopId)
	{
		return null;
	}

	public DrawShopTowerChangeSkinDesc GetTowerChangeSkinDesc(uint drawShopId)
	{
		return null;
	}

	public List<DrawShopWheelExchangeDesc> GetUnlimitedWheelExchangeDescList(uint drawShopId)
	{
		return null;
	}

	public List<uint> GetExchangeTokenIds(uint drawShopId)
	{
		return null;
	}

	public DrawShopTowerChangeSkinDesc GetUnlimitedTowerChangeSkinDesc(uint drawShopId)
	{
		return null;
	}

	public string GetTitleCDNUrl(string titleCdn, string language)
	{
		return null;
	}

	public string GetCDNUrl(string cdnUrl)
	{
		return null;
	}

	public PBAccountDrawShopWheelInfo GetWheelInfoData(uint chestId)
	{
		return null;
	}

	public PBAccountDrawShopTowerInfo GetTowerInfoData(uint chestId)
	{
		return null;
	}

	public uint GetDrawCount(uint chestId)
	{
		return 0u;
	}

	public uint GetGuaranteeCount(uint chestId)
	{
		return 0u;
	}

	public ulong GetLastFreeTime(uint chestId)
	{
		return 0uL;
	}

	public DrawShopInfoData GetChestInfo(uint chestId)
	{
		return null;
	}

	public bool HasFreeChance(uint chestId)
	{
		return false;
	}

	public bool HasAnyRedPoint(uint chestId)
	{
		return false;
	}

	public int GetRedDrawShopLobbyLeftEntrancePointCount()
	{
		return 0;
	}

	public int GetRedDrawShopLobbyRevenueEntrancePointCount()
	{
		return 0;
	}

	public ulong GetFreeCdRemaining(uint chestId)
	{
		return 0uL;
	}

	public uint GetActualPrice(uint chestId, EDrawShopDrawType drawType)
	{
		return 0u;
	}

	public uint GetOriginalPrice(uint chestId, EDrawShopDrawType drawType)
	{
		return 0u;
	}

	public uint GetTokenCount(uint chestId, int exchangeIndex = 1)
	{
		return 0u;
	}

	public List<KeyValuePair<uint, uint>> GetTokenItemList(uint chestId, int exchangeIndex = 1)
	{
		return null;
	}

	public ulong GetRemainingTime(uint chestId)
	{
		return 0uL;
	}

	public string GetRemainingTimeText(uint chestId)
	{
		return null;
	}

	public bool IsEndingSoon(uint chestId)
	{
		return false;
	}

	public bool IsItemOwned(uint itemId)
	{
		return false;
	}

	private bool IsGoodsOwnedForRemoveState(uint itemId)
	{
		return false;
	}

	public uint[] GetRemovedGoodsIds(uint chestId)
	{
		return null;
	}

	public bool IsItemNeedShowRemoved(uint chestId, uint goodsId)
	{
		return false;
	}

	public bool IsItemNeedShowFinished(uint chestId, uint itemId)
	{
		return false;
	}

	public bool IsItemNeedShowObtained(uint chestId, uint itemId)
	{
		return false;
	}

	public bool TryGetCardPoolGoodsDisplayState(uint chestId, uint goodsId, uint itemId, out bool needShowMax1, out bool needShowOwned)
	{
		needShowMax1 = default(bool);
		needShowOwned = default(bool);
		return false;
	}

	public bool TryGetDrawShopGoodsTagDisplayState(uint chestId, uint goodsId, out bool needShowFinished, out bool needShowObtained, out bool needShowMax1)
	{
		needShowFinished = default(bool);
		needShowObtained = default(bool);
		needShowMax1 = default(bool);
		return false;
	}

	private bool TryGetDrawShopGoodsStateData(DrawShopContentDataBase contentData, uint goodsId, out EInventory.AwardType rewardItemType, out uint itemId, out uint itemDuration, out bool isRemoveConfig)
	{
		rewardItemType = default(EInventory.AwardType);
		itemId = default(uint);
		itemDuration = default(uint);
		isRemoveConfig = default(bool);
		return false;
	}

	private bool IsGoodsInCurrentDrawShopPool(DrawShopContentDataBase contentData, uint goodsId)
	{
		return false;
	}

	private bool IsGoodsRemovedByDrawShopInfo(DrawShopContentDataBase contentData, uint goodsId)
	{
		return false;
	}

	private bool ContainsId(IEnumerable<uint> ids, uint targetId)
	{
		return false;
	}

	public int GetClaimableTokenRewardCount(uint chestId)
	{
		return 0;
	}

	public int GetExchangeableCount(uint chestId)
	{
		return 0;
	}

	public bool IsItemRareInDrawShop(uint drawShopId, uint itemId)
	{
		return false;
	}

	public bool IsItemRemovedInDrawShop(uint drawShopId, uint itemId)
	{
		return false;
	}

	public string GetTabCDNUrl(uint chestId, EDrawShopType type)
	{
		return null;
	}

	public string GetTabBackgroundCDNUrl(uint chestId, EDrawShopType type)
	{
		return null;
	}

	private void ProcessCommonDescRes(List<DrawShopCommonDesc> commonDescs)
	{
	}

	private void ProcessLimitedPoolDescRes(CSGetDrawShopDescRes res)
	{
	}

	private void ProcessUnlimitedWheelDescRes(CSGetDrawShopDescRes res)
	{
	}

	private void ProcessUnlimitedTowerDescRes(CSGetDrawShopDescRes res)
	{
	}

	public void ProcessDrawShopDescRes(CSGetDrawShopDescRes res)
	{
	}

	public void RequestDrawShopDesc(bool showLoading = true, Action<bool> callback = null, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public void RequestDraw(uint chestId, EDrawShopDrawType drawType, uint selectedItemIndex = 0u, Action<bool> callback = null)
	{
	}

	public void RequestDrawWithParams(uint chestId, EDrawShopDrawType drawType, DrawShopPurchaseParams purchaseParams, Action<bool> callback = null)
	{
	}

	private void ProcessWheelDrawRequest(uint chestId, EDrawShopDrawType drawType, DrawShopPurchaseParams purchaseParams, Action<bool> callback)
	{
	}

	private void ProcessTowerDrawRequest(uint chestId, EDrawShopDrawType drawType, DrawShopPurchaseParams purchaseParams, Action<bool> callback)
	{
	}

	private void ShowDrawRewardPopup(List<ExchangedAward> exchangedAwards, List<ItemTagInfo> tagItems, uint chestId, EDrawShopDrawType drawType, DrawShopPurchaseParams purchaseParams)
	{
	}

	private void ShowDrawRewardPopupSimple(List<ExchangedAward> exchangedAwards, List<ItemTagInfo> tagItems, uint chestId, EDrawShopDrawType drawType, DrawShopPurchaseParams purchaseParams)
	{
	}

	private void ShowDrawRewardPopupWithBundleOpen(List<ExchangedAward> exchangedAwards, List<ItemTagInfo> tagItems, uint chestId, EDrawShopDrawType drawType, DrawShopPurchaseParams purchaseParams)
	{
	}

	private void OnRewardPopupClosed(uint chestId, EDrawShopDrawType drawType, DrawShopPurchaseParams purchaseParams)
	{
	}

	public void RequestPurchaseLimitedPoolItem(uint drawShopId, uint selectedPoolItemId, uint operationType)
	{
	}

	public DrawShopLimitedPoolPrice CalculateLimitedPoolPrice(uint drawShopId, int turn = 0)
	{
		return null;
	}

	private void ProcessLimitedPoolPurchaseResponse(uint drawShopId, CSDrawShopPurchaseLimitedPoolItemRes response)
	{
	}

	public void RequestLimitedPoolProbability(uint drawShopId, int probabilityType)
	{
	}

	public void RequestWheelProbability(uint drawShopId, int probabilityType)
	{
	}

	public void RequestTowerProbability(uint drawShopId, bool showAllProbability = false, int probabilityType = 2)
	{
	}

	public void RequestPurchaseTowerToken(uint shopId, uint purchaseCnt, uint costCurrency, Action<bool> callback = null)
	{
	}

	private void ProcessPurchaseTowerTokenResult(uint shopId, uint purchaseCnt, CSDrawShopPurchaseTowerTokenRes res)
	{
	}

	private void ShowTowerTokenPurchaseRewardPopup(uint shopId, uint purchaseCnt)
	{
	}

	public void RequestClaimTowerReward(uint shopId, uint cdtValue)
	{
	}

	private void ProcessClaimTowerRewardResult(uint shopId, uint cdtValue, CSClaimDrawShopTowerRewardRes res)
	{
	}

	private void ShowTowerRewardPopup(uint shopId, uint cdtValue, List<ItemTagInfo> tagItems)
	{
	}

	private void OnTowerRewardPopupClosed(uint shopId, uint cdtValue)
	{
	}

	public void RequestExchange(uint shopId, uint exchangeId, uint exchangeCnt, DrawShopPurchaseParams purchaseParams, Action<bool> callback = null)
	{
	}

	private void ProcessExchangeResult(uint shopId, CSDrawShopWheelExchangeRes exchangeRes)
	{
	}

	private void ShowExchangeRewardPopup(uint shopId, uint exchangeId, uint exchangeCnt, List<ItemTagInfo> tagItems)
	{
	}

	public void RequestAccountDrawShopInfo(HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main, bool showLoading = false, LoadingType loadingType = LoadingType.CircleLoading, HttpManager.Priority priority = HttpManager.Priority.Normal, bool sendImmediately = false, bool needRefreshNowGachaView = false, Action<bool> callback = null)
	{
	}

	private void ProcessAccountDrawShopInfoRes(CSGetAccountDrawShopInfoRes res)
	{
	}

	private void FillLaunchTagFromTagItems(CommonRewardItemInfo rewardInfo, List<ItemTagInfo> tagItems)
	{
	}

	private void SnapshotRarePreOwned(uint chestId)
	{
	}

	public bool IsRarePreOwned(uint itemId)
	{
		return false;
	}

	private bool CheckAnyWeaponBecamePermanent(List<CommonRewardItemInfo> rewardInfoList)
	{
		return false;
	}

	public void RequestRedDotInfo(Action<bool> callback = null)
	{
	}

	private void RefreshRedDotState()
	{
	}

	private static EDrawShopCoinType NormalizeCoinType(uint coinType)
	{
		return EDrawShopCoinType.DefaultGems;
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
