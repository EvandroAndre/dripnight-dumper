using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIHudInventoryAttachmentGoldSlotItemController : UIHudInventoryAttachmentSlotItemController
{
	private bool m_IsWeaponUpgrade;

	private bool m_IsQualityMark;

	private bool m_IsAwaken;

	private uint m_AwakenWeaponUid;

	private bool m_IsCanAwaken;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	public override void OnDrapStart()
	{
	}

	public override bool OnDrapRelease(UIInventoryItemDragDropContainer container)
	{
		return false;
	}

	private void OnItemClick(object[] data)
	{
	}

	public void UpdateProgress(float progress)
	{
	}

	public void SetMaxProgress()
	{
	}

	public void SetAwakenState(bool isAwaken, uint weaponUid)
	{
	}

	public void SetCanAwakenState(bool isCanAwaken)
	{
	}

	public void SetGoldQualityMark(AGACNOCEEFP weaponData)
	{
	}

	public void SetUpdateContainer(PMPPONCKDBA info)
	{
	}

	private void ResetState()
	{
	}

	public override void SetUIData(UIItem item)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnDrapStart()
	{
	}

	public new bool _003C_003EiFixBaseProxy_OnDrapRelease(UIInventoryItemDragDropContainer P0)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_SetUIData(UIItem P0)
	{
	}
}
