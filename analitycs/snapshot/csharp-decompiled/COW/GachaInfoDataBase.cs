using System.Collections.Generic;
using proto;

namespace COW;

public class GachaInfoDataBase
{
	private sealed class _003C_003Ec__DisplayClass82_0
	{
		public string url;

		public GachaInfoDataBase _003C_003E4__this;

		internal void _003CProcessGachaRule_003Eb__0()
		{
		}
	}

	private uint _003CGachaID_003Ek__BackingField;

	private ulong _003CNextFreeDrawTime_003Ek__BackingField;

	private GachaInfo _003CGachaInfo_003Ek__BackingField;

	private GachaDesc _003CGachaDesc_003Ek__BackingField;

	private ClientChestType _003CChestType_003Ek__BackingField;

	private List<uint> _003CAvatarList_003Ek__BackingField;

	private Dictionary<uint, List<GachaShowItem>> _003CRewardsPoolListDic_003Ek__BackingField;

	private Dictionary<uint, bool> _003CPrizePreOwnedDic_003Ek__BackingField;

	private HashSet<uint> _003CRemovedRewardsSet_003Ek__BackingField;

	private GachaShowItem _003CSuperGrandPrize_003Ek__BackingField;

	private GachaRuleInfo _003CGachaRule_003Ek__BackingField;

	private uint _003CSuperGrandPrizeItemId_003Ek__BackingField;

	private uint _003CSuperGrandPrizeItemNum_003Ek__BackingField;

	private uint _003CSuperGrandPrizeItemDuration_003Ek__BackingField;

	private int _003CFirstSuperGrandPrizeDrawCount_003Ek__BackingField;

	private uint _003CExpectedSuperGrandPrizeDrawCount_003Ek__BackingField;

	private bool _003CGotFirstSuperGrandPrizeByExchange_003Ek__BackingField;

	public uint GachaID
	{
		get
		{
			return _003CGachaID_003Ek__BackingField;
		}
		protected set
		{
			_003CGachaID_003Ek__BackingField = value;
		}
	}

	public ulong NextFreeDrawTime
	{
		get
		{
			return _003CNextFreeDrawTime_003Ek__BackingField;
		}
		protected set
		{
			_003CNextFreeDrawTime_003Ek__BackingField = value;
		}
	}

	public GachaInfo GachaInfo
	{
		get
		{
			return _003CGachaInfo_003Ek__BackingField;
		}
		protected set
		{
			_003CGachaInfo_003Ek__BackingField = value;
		}
	}

	public GachaDesc GachaDesc
	{
		get
		{
			return _003CGachaDesc_003Ek__BackingField;
		}
		protected set
		{
			_003CGachaDesc_003Ek__BackingField = value;
		}
	}

	public ClientChestType ChestType
	{
		get
		{
			return _003CChestType_003Ek__BackingField;
		}
		protected set
		{
			_003CChestType_003Ek__BackingField = value;
		}
	}

	public List<uint> AvatarList
	{
		get
		{
			return _003CAvatarList_003Ek__BackingField;
		}
		protected set
		{
			_003CAvatarList_003Ek__BackingField = value;
		}
	}

	public Dictionary<uint, List<GachaShowItem>> RewardsPoolListDic
	{
		get
		{
			return _003CRewardsPoolListDic_003Ek__BackingField;
		}
		protected set
		{
			_003CRewardsPoolListDic_003Ek__BackingField = value;
		}
	}

	public Dictionary<uint, bool> PrizePreOwnedDic
	{
		get
		{
			return _003CPrizePreOwnedDic_003Ek__BackingField;
		}
		protected set
		{
			_003CPrizePreOwnedDic_003Ek__BackingField = value;
		}
	}

	public HashSet<uint> RemovedRewardsSet
	{
		get
		{
			return _003CRemovedRewardsSet_003Ek__BackingField;
		}
		protected set
		{
			_003CRemovedRewardsSet_003Ek__BackingField = value;
		}
	}

	public GachaShowItem SuperGrandPrize
	{
		get
		{
			return _003CSuperGrandPrize_003Ek__BackingField;
		}
		protected set
		{
			_003CSuperGrandPrize_003Ek__BackingField = value;
		}
	}

	public GachaRuleInfo GachaRule
	{
		get
		{
			return _003CGachaRule_003Ek__BackingField;
		}
		protected set
		{
			_003CGachaRule_003Ek__BackingField = value;
		}
	}

	public uint SuperGrandPrizeItemId
	{
		get
		{
			return _003CSuperGrandPrizeItemId_003Ek__BackingField;
		}
		protected set
		{
			_003CSuperGrandPrizeItemId_003Ek__BackingField = value;
		}
	}

	public uint SuperGrandPrizeItemNum
	{
		get
		{
			return _003CSuperGrandPrizeItemNum_003Ek__BackingField;
		}
		protected set
		{
			_003CSuperGrandPrizeItemNum_003Ek__BackingField = value;
		}
	}

	public uint SuperGrandPrizeItemDuration
	{
		get
		{
			return _003CSuperGrandPrizeItemDuration_003Ek__BackingField;
		}
		protected set
		{
			_003CSuperGrandPrizeItemDuration_003Ek__BackingField = value;
		}
	}

	public int FirstSuperGrandPrizeDrawCount
	{
		get
		{
			return _003CFirstSuperGrandPrizeDrawCount_003Ek__BackingField;
		}
		protected set
		{
			_003CFirstSuperGrandPrizeDrawCount_003Ek__BackingField = value;
		}
	}

	public uint ExpectedSuperGrandPrizeDrawCount
	{
		get
		{
			return _003CExpectedSuperGrandPrizeDrawCount_003Ek__BackingField;
		}
		protected set
		{
			_003CExpectedSuperGrandPrizeDrawCount_003Ek__BackingField = value;
		}
	}

	public bool GotFirstSuperGrandPrizeByExchange
	{
		get
		{
			return _003CGotFirstSuperGrandPrizeByExchange_003Ek__BackingField;
		}
		set
		{
			_003CGotFirstSuperGrandPrizeByExchange_003Ek__BackingField = value;
		}
	}

	public float LuckyPercent => 0f;

	public bool HasFreeDraw => false;

	public void ProcessInfoData(GachaInfo gachaInfo)
	{
	}

	protected virtual void OnUpdateInfoData()
	{
	}

	public virtual void UpdateByGachaResult(CSLotteryRes gachaResult, UIModelGacha.GachaDrawType drawType = UIModelGacha.GachaDrawType.TYPE_NONE)
	{
	}

	private void UpdateSuperGrandPrizeDrawInfo()
	{
	}

	public void GotSuperGrandPrizeByExchange()
	{
	}

	protected void UpdateRewardsRemoveState(uint[] rewardIds)
	{
	}

	public void InitLuckySpinState(uint chestId, uint subChestId)
	{
	}

	protected void UpdateLuckySpinState(bool isluckySpin)
	{
	}

	protected void ComposeExtraDesc(GachaDesc desc)
	{
	}

	protected void ComposeShowReward(GachaDesc desc)
	{
	}

	protected void ProcessGachaRule(GachaDesc desc)
	{
	}

	public void InitFreeDraw(GachaFreeDrawInfo freeDraw)
	{
	}

	public void ResetGachaFreeDraw()
	{
	}

	protected void UpdateFreeDrawByGachaInfo()
	{
	}

	public bool UpdateFreeDrawByGachaResult(ulong nextFreeTime)
	{
		return false;
	}

	public void ClearDescData()
	{
	}
}
