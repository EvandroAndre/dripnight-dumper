using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudHippoCrisisBackpackBoxController : UIBaseController, IUIHippoCrisisDragResponseController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__29_1;

		internal void _003CStartGuide_003Eb__29_1()
		{
		}
	}

	private UIModelHippoCrisis m_ModelHippoCrisis;

	private UIHudHippoCrisisBackpackBoxView m_View;

	private UIHudHippoCrisisBackpackTitleController m_BackpackTitle;

	private List<UIHudHippoCrisisBackpackItemController> m_BackpackItems;

	private List<UIHudHippoCrisisBackpackItemController> m_SafeItems;

	private UIHudHippoCrisisBackpackItemController m_TemplateItem;

	private IHippoCrisisEquipmentBackpackData m_Data;

	private UIHudHippoCrisisBackpackTitleController m_SafeBoxTopCtrl;

	private UIHudHippoCrisisBackpackTitleController m_SafeBoxBottomCtrl;

	private UIHudHippoCrisisBackpackTitleController m_SafeBoxInTableCtrl;

	private UIPopMenuSmallControler m_InventoryPopMenuCtrl;

	private int m_SafeBoxTitleIndex;

	private bool IsFirstBuild;

	private bool m_IsDecending;

	private KIDBEABFENA NextSafeBox;

	private const uint BackpackItemMinNum = 9u;

	private const uint SafeBoxItemMinNum = 6u;

	private Vector4 ItemMargin;

	private Vector4 TitleMargin;

	private HippoCrisisPopMenuSort m_CurrentPopMenuSort;

	private HCContainerState m_CurBackpackContainerState;

	private HCContainerState m_CurSafeBoxContainerState;

	private Dictionary<uint, string> m_PopMenuToKey;

	private Color DefaultProcessBarColor;

	private EDragReleaseResponseAreaType CurrentDraggingAreaType;

	private int m_NextGuideStep;

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

	private void StartGuide(bool init = false)
	{
	}

	public void SetBackPackItemEnable(bool enable)
	{
	}

	private void InitTable2()
	{
	}

	private void InitMarginData()
	{
	}

	private void InitExpandSafeBoxData()
	{
	}

	private void OnDragEnd()
	{
	}

	private void OnDragStart(object[] param)
	{
	}

	private void RefreshBackpackContainerState(IHippoCrisisBackPackItemUIData data)
	{
	}

	private void RefreshSafeContainerState(IHippoCrisisBackPackItemUIData data)
	{
	}

	private void RefreshProcessBar(UISprite bar, UISprite addBar, uint addWeight, uint usageWeight, uint totalWeight, bool isShowBar, bool isShowAddBar)
	{
	}

	public void SetData(IHippoCrisisEquipmentBackpackData data, bool isReset = false)
	{
	}

	private void RefreshFakeTitle()
	{
	}

	private void RefreshBackpak()
	{
	}

	private void RefreshSafeBox()
	{
	}

	private void RefreshUI(bool isReset = false)
	{
	}

	private void RefreshTitle()
	{
	}

	private void RefreshStoreBtn()
	{
	}

	private void LateUpdate()
	{
	}

	public UIWidget GetDragWidgetBySlot(EHippoCrisisDragWidgetType slot)
	{
		return null;
	}

	public HippoCrisisDragOperationResult HippoCrisisDragResponseCB(HippoCrisisDragSourceInfo dragSourceInfo, EDragReleaseResponseAreaType areaType)
	{
		return default(HippoCrisisDragOperationResult);
	}

	public void ScrollToBackPack()
	{
	}

	public void ScrollToSafeBox()
	{
	}

	private void OnExpandSafeBoxClick()
	{
	}

	private void OnStroeAllClick()
	{
	}

	private void InitSortPopMenu()
	{
	}

	private void GeneratePopMenuData()
	{
	}

	private void OnPopMenuSelect(object data)
	{
	}

	private void OnReverseBtnClick()
	{
	}

	public void OnDragOver(IHippoCrisisBackPackItemUIData dragingItemData, EDragReleaseResponseAreaType areaType)
	{
	}

	public void OnDragOut(IHippoCrisisBackPackItemUIData dragingItemData, EDragReleaseResponseAreaType areaType)
	{
	}

	public void RetractPopMenu()
	{
	}

	public void RefreshDropLeftView(bool isVisable, uint dropItemWeight = 0u)
	{
	}

	public void SetGuideMaskState(bool show)
	{
	}

	private void _003CStartGuide_003Eb__29_0()
	{
	}

	private UITable2.IUITable2Item _003CInitTable2_003Eb__31_0()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitTable2_003Eb__31_1()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitTable2_003Eb__31_2()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitTable2_003Eb__31_3()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitTable2_003Eb__31_4()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitTable2_003Eb__31_5()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
