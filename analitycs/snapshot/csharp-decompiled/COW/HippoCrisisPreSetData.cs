using GCommon;
using proto;

namespace COW;

public class HippoCrisisPreSetData : CSVBaseData
{
	public uint ID;

	public uint itemID;

	public uint Account;

	public uint Recommend;

	public bool Owned;

	public uint OwnedNum;

	public ulong UniqueId;

	public uint StoreId;

	public EHippoInventory.EquipType DstEquipType;

	public EHippoCrisisEquipmentSlot DstSlot;

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
