using GCommon;

namespace COW;

public class HippoCrisisItemData : CSVBaseData, IGetId
{
	public uint id;

	public uint Weight;

	public uint SellPrice;

	public int[] CanEquipSlots;

	public bool CanInSafeBox;

	public uint VirtualParamVal;

	public uint PurchasePlusCnt;

	public uint BuyPrice;

	public string ItemApplicationShowKay;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public uint GetId()
	{
		return 0u;
	}

	public override uint GetUIntKey()
	{
		return 0u;
	}

	public override int GetIntKey()
	{
		return 0;
	}

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public uint _003C_003EiFixBaseProxy_GetUIntKey()
	{
		return 0u;
	}

	public int _003C_003EiFixBaseProxy_GetIntKey()
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
