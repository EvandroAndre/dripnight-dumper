using System.Collections.Generic;
using GCommon;
using message;

namespace COW;

public class CSShopItemData : CSVBaseData, IGetId
{
	public uint iID;

	public uint originalPrice;

	public uint price;

	public uint filter;

	public uint limitation;

	public uint TeamLimitation;

	public uint stack;

	public List<uint> hideCheckItemList;

	public uint quickBuy;

	public byte maxLevel;

	public bool onlyShow;

	public bool bonus;

	public uint faction;

	public uint resetTime;

	public uint maxCount;

	public byte TechPointLimit;

	public uint requiredBattleStyle;

	public uint requiredBattleStyleAbility;

	public uint BooyahBountyLimit;

	public byte RefreshSlot;

	public uint MaxReinforceCount;

	public DKGCKAAGBIG ReplaceReason;

	public bool isSurpriseItem;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public uint GetId()
	{
		return 0u;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}
}
