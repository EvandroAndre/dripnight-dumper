namespace proto;

public class EHippoInventory
{
	public enum EquipType
	{
		EquipTypeWarehouse,
		EquipTypeSlot,
		EquipTypeBag,
		EquipTypeSafeBox,
		EquipTypeMax
	}

	public enum VirtualParamType
	{
		VirtualParamTypeNone,
		VirtualParamTypeRebirth
	}

	public enum TransReason
	{
		TransReasonNone,
		TransReasonCheckInGS,
		TransReasonPurchases,
		TransReasonSell,
		TransReasonWarehouseUpgrade,
		TransReasonRepair,
		TransReasonEquipMove,
		TransReasonAttachmentEquip,
		TransReasonAttachmentUnEquip,
		TransReasonAttachmentMove,
		TransReasonGiveReward,
		TransReasonMailGiveReward,
		TransReasonCheckGiveReward,
		TransReasonMatchLeave,
		TransReasonAdmin,
		TransReasonMatchSuccess,
		TransReasonQueryEquip
	}
}
