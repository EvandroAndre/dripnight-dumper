using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudHippoCrisisEquipmentContainerController : UIBaseController, IUIHippoCrisisDragResponseController, IUIModelDataChangeObserver
{
	private UIHudHippoCrisisEquipmentContainerView m_View;

	private UIHudHippoCrisisEquipmentController m_HudHippoCrisisEquipmentController;

	public UIHudHippoCrisisBackpackBoxController m_HudHippoCrisisBackpackBoxController;

	private UIHippoCrisisItemBriefBoxController m_ItemBriefBoxController;

	private UIModelHippoCrisis m_ModelHippoCrisis;

	private IHippoCrisisEquipmentBackpackData m_Data;

	private List<GameObject> AllLines;

	private bool IsOpenFromPrestart;

	private bool IsOpeningBack;

	private bool IsOpening;

	private Dictionary<int, UIWidget> SlotWidgetDic;

	private IHippoCrisisBackPackItemUIData m_CurrentDragingItemData;

	private float TotalPartScrollLen;

	private int CurPartScrollCnt;

	private int ScrollBarTotalHeight;

	private int m_NextGuideStep;

	private bool IsOverDropLeft;

	private int OneGroupAmout;

	private int GroupNum;

	private bool ReturnNextDragMove;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void StartGuideByEvent()
	{
	}

	public void StartGuide(bool init = false)
	{
	}

	private void OnDragEnd()
	{
	}

	private void OnDragOver(object[] param)
	{
	}

	private void OnDragOver_DropLeft()
	{
	}

	public void OnDragDropMove(Vector2 delta)
	{
	}

	private void UpdatePartScrollBar()
	{
	}

	private void OnDragOut(object[] param)
	{
	}

	private void OnDragStart(object[] param)
	{
	}

	private void OnInventoryOpen(object[] param)
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void InternalHide()
	{
	}

	private void OpenUI()
	{
	}

	public void SetOpenFromPrestart()
	{
	}

	private UIWidget TryGetWidgetBySlot(EHippoCrisisDragWidgetType slot)
	{
		return null;
	}

	private void RefreshUI_Event(int refreshType)
	{
	}

	public void RefreshUI(int refreshType, bool isResetBackpack = false)
	{
	}

	private void RefreshBg()
	{
	}

	HippoCrisisDragOperationResult IUIHippoCrisisDragResponseController.HippoCrisisDragResponseCB(HippoCrisisDragSourceInfo hippoCrisisDragSourceInfo, EDragReleaseResponseAreaType areaType)
	{
		return default(HippoCrisisDragOperationResult);
	}

	public void SetEquipmentGuideMaskState(bool show)
	{
	}

	public void SetSafeBoxGuideMaskState(bool show)
	{
	}

	private void ShowItemBriefBox(object[] param)
	{
	}

	public Transform GetBriefBoxRootTransform()
	{
		return null;
	}

	public void ShowBackpack()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void _003CStartGuide_003Eb__19_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
