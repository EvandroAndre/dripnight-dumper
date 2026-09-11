using proto;

namespace COW;

public struct HippoCrisisDragSourceInfo
{
	public IHippoCrisisBackPackItemUIData dragData;

	public EHippoInventory.EquipType fromEquipType;

	public EHippoCrisisEquipmentSlot fromSlot;

	public bool fromIsAttachmentInSlot;

	public int totalCapacity;

	public int usageCapacity;

	public HippoCrisisStoreItemData storeData;

	public bool isPurchaseEquipImmediately;
}
