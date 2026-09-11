using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudInventoryEquipSlotItemController : UIInventoryItemControllerBase
{
	private UIHudInventoryEquipSlotItemView m_View;

	private GameObject m_EmptyBG;

	private UIHudInventoryAttachmentSlotItemController m_Attachment;

	private DJLDPFMKPIH m_HelightSlot;

	private GameObject m_BreathVFX;

	private VisualInstanceHolder m_BreathVFXHolder;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public static bool KillCamDontDestroy()
	{
		return false;
	}

	public override bool KillCamRecyleDontDestroy()
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	public override void OnUIReInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void SetDrapDropType(OOOMOIADBFJ type, GameObject emptyBG)
	{
	}

	public void SetUIData(UIItem item)
	{
	}

	public void RefreshMinDurabilityLockState()
	{
	}

	public void RefreshMinDurabilityLockLevelSprite()
	{
	}

	public void RefreshAttachmentState()
	{
	}

	protected override bool HandleReleaseEvent(UIInventoryItemDragDropContainer container)
	{
		return false;
	}

	public override void OnDrapStart()
	{
	}

	private void OnApplicationFocus(bool hasFocus)
	{
	}

	private void OnInventoryOpen(object[] data)
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

	public void OnBtnSlotClick()
	{
	}

	public bool IsAttachmentValid(DFBPGIINGFN data)
	{
		return false;
	}

	public void ShowVFXAttachment(DFBPGIINGFN data)
	{
	}

	public void StopVFXAttachment()
	{
	}

	public void EnableBtnSlot()
	{
	}

	public void DisableBtnSlot()
	{
	}

	public string GetAttachmentDesc()
	{
		return null;
	}

	public bool _003C_003EiFixBaseProxy_KillCamRecyleDontDestroy()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIReInit()
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
