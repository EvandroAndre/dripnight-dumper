using System.Collections.Generic;
using proto;

namespace COW;

public interface IHippoCrisisEquipmentBackpackData
{
	uint BackpackUsagecapacity { get; }

	uint BackpackTotalcapacity { get; }

	uint BackpackRemainingcapacity { get; }

	uint SafeBoxTotalcapacity { get; }

	uint SafeBoxRemainingcapacity { get; }

	uint AllEquipmentValue { get; }

	IHippoCrisisBackPackItemUIData MainWeapon1 { get; }

	IHippoCrisisBackPackItemUIData MainWeapon2 { get; }

	IHippoCrisisBackPackItemUIData SecondaryWeapon { get; }

	IHippoCrisisBackPackItemUIData MeleeWeapon { get; }

	IHippoCrisisBackPackItemUIData BodyArmor { get; }

	IHippoCrisisBackPackItemUIData Helmet { get; }

	IHippoCrisisBackPackItemUIData SkillChip { get; }

	IHippoCrisisBackPackItemUIData Backpack { get; }

	List<IHippoCrisisBackPackItemUIData> BackpackItems { get; }

	List<IHippoCrisisBackPackItemUIData> SafeBoxItems { get; }

	bool RepairItem(List<IHippoCrisisBackPackItemUIData> items);

	bool AddItem(IHippoCrisisBackPackItemUIData item, EHippoInventory.EquipType targetEquipType, EHippoCrisisEquipmentSlot targetSlot);

	bool ExchangeItem(IHippoCrisisBackPackItemUIData fromItem, IHippoCrisisBackPackItemUIData toItem, EHippoInventory.EquipType fromEquipType, EHippoInventory.EquipType toEquipType, EHippoCrisisEquipmentSlot fromItemSlot = EHippoCrisisEquipmentSlot.None, EHippoCrisisEquipmentSlot toItemSlot = EHippoCrisisEquipmentSlot.None);

	bool MoveItem(IHippoCrisisBackPackItemUIData item, EHippoInventory.EquipType fromEquipType, EHippoCrisisEquipmentSlot fromSlot, EHippoInventory.EquipType toEquipType, EHippoCrisisEquipmentSlot toSlot);

	bool DropItem(IHippoCrisisBackPackItemUIData item, uint dropNum, EHippoInventory.EquipType fromEquipType, EHippoCrisisEquipmentSlot fromInventorySlot = EHippoCrisisEquipmentSlot.None);

	bool SplitItem(IHippoCrisisBackPackItemUIData item, uint splitNum, EHippoInventory.EquipType fromEquipType, EHippoInventory.EquipType targetEquipType);
}
