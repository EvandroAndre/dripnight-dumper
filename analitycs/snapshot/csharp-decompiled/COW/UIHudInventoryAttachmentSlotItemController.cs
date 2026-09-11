using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudInventoryAttachmentSlotItemController : UIInventoryItemControllerBase
{
	protected UIHudInventoryAttachmentSlotItemView m_View;

	protected GameObject m_EmptyBG;

	private BitArrayBoolean m_DragEnabled;

	public const uint DRAG_ENABLED_NORMAL = 1u;

	public const uint DRAG_ENABLED_ITEM = 2u;

	public const uint DRAG_ENABLED_REINFORCED = 4u;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIDestory()
	{
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	private void OnApplicationFocus(bool hasFocus)
	{
	}

	public void EnableDrageDrop(uint flag, bool enable)
	{
	}

	public virtual void SetDrapDropType(OOOMOIADBFJ type, GameObject emptyBG, UIInventoryItemDragDropContainer parentContainer)
	{
	}

	public void HideQuality()
	{
	}

	public virtual void SetUIData(UIItem item)
	{
	}

	private void OnSlotItemChanged(object[] data)
	{
	}

	protected override bool HandleReleaseEvent(UIInventoryItemDragDropContainer container)
	{
		return false;
	}

	public override void OnDrapStart()
	{
	}

	public override bool OnDrapRelease(UIInventoryItemDragDropContainer container)
	{
		return false;
	}

	public override UIToggle GetToggle()
	{
		return null;
	}

	public override GameObject GetHighlightGO()
	{
		return null;
	}

	public override void SetHighlightGoActive(bool paramActive)
	{
	}

	public override GameObject GetDragGO()
	{
		return null;
	}

	public override GameObject GetNonDragGO()
	{
		return null;
	}

	public override GameObject GetDragRedGo()
	{
		return null;
	}

	private HDAEFOANBGJ GetEquipSlotByContainerType(OOOMOIADBFJ containerType)
	{
		return HDAEFOANBGJ.PrimaryWeapon1;
	}

	public string GetAttachmentDesc()
	{
		return null;
	}

	public bool NeedShowHelight(GIANNEDDMLL attType)
	{
		return false;
	}

	public OOOMOIADBFJ GetContainerType()
	{
		return OOOMOIADBFJ.None;
	}

	public void ShowHelight(bool isHelight)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public bool _003C_003EiFixBaseProxy_HandleReleaseEvent(UIInventoryItemDragDropContainer P0)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnDrapStart()
	{
	}

	public bool _003C_003EiFixBaseProxy_OnDrapRelease(UIInventoryItemDragDropContainer P0)
	{
		return false;
	}
}
