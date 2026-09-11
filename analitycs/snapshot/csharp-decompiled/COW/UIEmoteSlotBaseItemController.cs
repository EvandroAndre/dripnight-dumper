using GCommon;
using UnityEngine;

namespace COW;

public class UIEmoteSlotBaseItemController : UIBaseController
{
	protected int m_Index;

	protected uint m_SlotIndex;

	protected uint m_EmoteID;

	protected EmoteBaseInfo m_EmoteInfo;

	protected UIEmoteSlotItemView m_View;

	protected UILobbyOnlySlotItemView m_ViewLobbyOnly;

	protected UINewVaultOnlySlotItemView m_ViewNewVaultOnly;

	private uint m_DelayCallId;

	protected bool IsBpSlot => false;

	protected bool IsNormalSlot => false;

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public virtual void SetData(uint eid, int indexID, uint slotID)
	{
	}

	private void SetDefaultUI()
	{
	}

	private void SetSlotRotation()
	{
	}

	protected void SetEmoteSprite()
	{
	}

	protected void SetBpIcon()
	{
	}

	protected void SetBpLockIconState()
	{
	}

	protected void SetRotation(int index, Transform slotTransform, float rotateValue)
	{
	}

	private void SetNewVaultReplaceButtonRotation(int index, float rotateValue)
	{
	}

	private void SetNewVaultReplaceButtonRotation(UIButton button, int index, float rotateValue)
	{
	}

	public void UnlockBPSlotVFX()
	{
	}

	protected virtual void UnlockMask()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
