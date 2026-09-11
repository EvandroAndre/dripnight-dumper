using proto;

namespace COW;

public struct HippoCrisisDragOperationResult
{
	public EDragOperationResultType resultType;

	public CSHippoInventoryModifyEquipReq.ModifyInfo.Type operationType;

	public IHippoCrisisBackPackItemUIData exchangeData;

	public EHippoInventory.EquipType targetEquipType;

	public EHippoCrisisEquipmentSlot targetSlot;

	public int attachmentTargeSlot;

	public EDragReleaseResponseAreaType targetAreaType;

	public ulong targetSlotItemUniqueId;

	public int DragDropPartNum;
}
