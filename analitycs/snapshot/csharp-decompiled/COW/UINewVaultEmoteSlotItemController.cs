using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UINewVaultEmoteSlotItemController : UIEmoteSlotBaseItemController
{
	private bool m_isChoose;

	private bool m_isReplaceClick;

	private Action<int, bool> m_actOnClick;

	private Action<Vector3, ResourceID> m_actOnStartDrag;

	private Action m_actOnEndDrag;

	private Action<Vector3> m_actOnDragMove;

	private bool m_IsRightSideSlot;

	private Color32 m_selectcolor;

	private Color32 m_disselectcolor;

	private const string DEFAULT_EMOTE_ICON = "Icon_Emote_Default";

	protected override void OnUIInit()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public void SetRightSideSlot(bool isRightSideSlot)
	{
	}

	public override void SetData(uint eid, int indexID, uint slotID)
	{
	}

	public void Init(uint slotIndex, int index, Action<int, bool> act, Action<Vector3, ResourceID> startDrag, Action endDrag, Action<Vector3> dragMove, Func<GameObject> getDragDropCloneObject)
	{
	}

	private void PlayUnlockVFX()
	{
	}

	private void SetDefaultIconRotate()
	{
	}

	public void RefreshBooyahState()
	{
	}

	public void Refresh()
	{
	}

	private void OnSlotClick()
	{
	}

	public uint GetEmoteId()
	{
		return 0u;
	}

	public int GetIndexInArray()
	{
		return 0;
	}

	public uint GetIndexInBag()
	{
		return 0u;
	}

	public void SetSelect(bool isSelect)
	{
	}

	public void OnDragDropStart()
	{
	}

	public void OnDragDropRelease(List<ChoosedEmote> emote_changes, bool isLocked = false, uint emoteID = 0u)
	{
	}

	public void OnDragOverSlot()
	{
	}

	public void OnDragMove(Vector3 pos)
	{
	}

	protected override void UnlockMask()
	{
	}

	private void OnReplaceEmoteBtnClick()
	{
	}

	public bool ConsumeReplaceClickFlag()
	{
		return false;
	}

	public void RefreshReplaceAndAvailableState(bool isSelect, bool hasSelectedEmote = true, uint selectedEmoteID = 0u)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_SetData(uint P0, int P1, uint P2)
	{
	}

	public void _003C_003EiFixBaseProxy_UnlockMask()
	{
	}
}
