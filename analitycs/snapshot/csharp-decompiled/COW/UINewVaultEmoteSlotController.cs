using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UINewVaultEmoteSlotController : UIBaseController, IUIModelDataChangeObserver
{
	private int m_nIndex;

	private uint m_unSlotIndex;

	private uint m_unEmoteID;

	private bool m_isChoose;

	private UINewVaultEmoteSlotView m_View;

	private EmoteBaseInfo m_EmoteInfo;

	private UINewVaultEmoteDragDropItem m_DragDropItem;

	private Action<int, bool> m_actOnClick;

	private Action m_actOnStartDrag;

	private Action m_actOnEndDrag;

	private Color32 m_selectcolor;

	private Color32 m_disselectcolor;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void RefreshBooyahState()
	{
	}

	public void Init(uint slotIndex, int index, Action<int, bool> act, Action startDrag, Action endDrag)
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

	public void OnDragDropRelease(List<ChoosedEmote> emote_changes, bool needAction)
	{
	}

	public void OnDragOverSlot()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
