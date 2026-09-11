namespace proto;

public class HippoInventoryChangeInfo
{
	public enum Type
	{
		None,
		Item,
		DelItem,
		Money,
		SafeBoxLevel,
		WarehouseLevel,
		StorePurchase,
		BagWeight,
		SafeBoxWeight,
		WarehouseWeight,
		VirtualParam
	}

	public Type type;

	public EHippoInventory.EquipType item_equip_type;

	public HippoInventoryEquipItem item;

	public ulong del_item_inst_id;

	public int money_delta;

	public uint money;

	public uint safe_box_level;

	public uint warehouse_level;

	public uint store_id;

	public uint store_purchase_amount;

	public uint weight;

	public EHippoInventory.VirtualParamType virtual_param_type;

	public uint virtual_param_val;
}
