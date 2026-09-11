using UnityEngine;
using proto;

namespace COW;

public class UIHippoCrisisInventoryDragDropItem : UIDragDropItem
{
	private EDragReleaseResponseAreaType m_DragAreaType;

	private EHippoInventory.EquipType m_SourceType;

	private IHippoCrisisBackPackItemUIData m_Data;

	protected UIModelHippoCrisis m_ModelHippoCrisis;

	private HippoCrisisStoreItemData m_StoreData;

	protected override void OnDragStart()
	{
	}

	public override bool StartDragging()
	{
		return false;
	}

	public void Init(EHippoInventory.EquipType sourceType, IHippoCrisisBackPackItemUIData data, EDragReleaseResponseAreaType areaType, HippoCrisisStoreItemData storeData = null)
	{
	}

	protected override void OnDragDropRelease(GameObject surface)
	{
	}

	public HippoCrisisDragSourceInfo GenerateDragSourceInfo()
	{
		return default(HippoCrisisDragSourceInfo);
	}

	public void _003C_003EiFixBaseProxy_OnDragStart()
	{
	}

	public bool _003C_003EiFixBaseProxy_StartDragging()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnDragDropRelease(GameObject P0)
	{
	}
}
