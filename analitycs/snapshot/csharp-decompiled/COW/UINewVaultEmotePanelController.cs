using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UINewVaultEmotePanelController : UIBaseController, IUIModelDataChangeObserver
{
	private UINewVaultEmotePanelView m_View;

	private UINewVaultController m_NewVaultController;

	private List<UINewVaultEmoteSlotItemController> m_EmoteSlotItemCtrl;

	private List<Transform> m_NormalEmoteSlotTransform;

	private List<Transform> m_BPEmoteSlotTransform;

	private uint m_DelayCallIdLockAnim;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void SetTransformList()
	{
	}

	private void ProcessEmoteSlotCtrl()
	{
	}

	private void ProcessBPEmoteSlotCtrl()
	{
	}

	private bool IsRightSideSlot(Transform slotTransform)
	{
		return false;
	}

	public void RefreshBpLockIcon()
	{
	}

	public void InitItemView(uint slotIndex, int index, Action<int, bool> act, Action<Vector3, ResourceID> startDrag, Action endDrag, Action<Vector3> dragMove, Func<GameObject> getDragDropCloneObject)
	{
	}

	public void SetLeftRightPos(Vector3 leftPos)
	{
	}

	public UINewVaultEmoteSlotItemController GetSlotItemViewByIndex(int index)
	{
		return null;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void _003CRefreshBpLockIcon_003Eb__13_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
