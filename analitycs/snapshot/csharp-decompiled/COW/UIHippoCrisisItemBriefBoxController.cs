using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHippoCrisisItemBriefBoxController : UIPopupWindowController
{
	private UIHippoCrisisItemBriefBoxView m_View;

	private EHCPageType m_CurPageType;

	private EHCItemSourceType m_CurItemSource;

	private HippoCrisisOutGameItemUIData m_CurOutGameUIData;

	private IHippoCrisisBackPackItemUIData m_CurData;

	private HippoCrisisStoreItemData m_CurStoreData;

	private uint m_CurItemID;

	private uint m_TotalPrice;

	private uint m_TotalWeight;

	private PIJKGPDBNJC m_ItemType;

	private List<IHippoCrisisBackPackItemUIData> m_Attachments;

	private Vector2 m_BigBGSize;

	private Vector2 m_SmallBGSize;

	private float m_BigBGBtnContainerY;

	private float m_SmallBGBtnContainerY;

	private UIModelHippoCrisis m_ModelHippoCrisis;

	private HippoCrisisDragSourceInfo m_CurSourceInfo;

	private UIClickMask m_ClickMask;

	private List<uint> m_DisplayProperty;

	private List<uint> m_MainWeaponAttachmentList;

	private Dictionary<int, List<string>> EmptySlotsDescDic;

	private List<UIHippoCrisisItemBriefBoxInteractionBtnController> m_BtnCtrlList;

	private List<UIHippoCrisisWeaponPropertyItemController> m_WeaponPropertyItemCtrlList;

	private UIHippoCrisisInventoryItemSmallController m_ItemCtrl;

	private List<UIHippoCrisisInventoryItemSmallController> m_AttachmentItemCtrlList;

	private HENEHAGJCLI m_ItemData;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public override bool IgnoreEsc()
	{
		return false;
	}

	protected override void OnVisibilityChanged()
	{
	}

	public void SetViewData(HippoCrisisOutGameItemUIData item, EHCPageType pageType, EHCItemSourceType itemSourceType, HippoCrisisDragSourceInfo sourceInfo = default(HippoCrisisDragSourceInfo))
	{
	}

	public void SetViewData(IHippoCrisisBackPackItemUIData item, EHCPageType pageType, EHCItemSourceType itemSourceType, HippoCrisisDragSourceInfo sourceInfo = default(HippoCrisisDragSourceInfo))
	{
	}

	public void SetViewData(HippoCrisisStoreItemData item, EHCPageType pageType, EHCItemSourceType itemSourceType, HippoCrisisDragSourceInfo sourceInfo = default(HippoCrisisDragSourceInfo))
	{
	}

	private void SetScrollViewWidget()
	{
	}

	public void StartGuide(UIWidget widget, UIButton button)
	{
	}

	private bool CheckIsConsumable(PIJKGPDBNJC type)
	{
		return false;
	}

	private void ResetDragScrollView()
	{
	}

	public void AddClickMask()
	{
	}

	public void ClearClickMask()
	{
	}

	private void RefreshItemView()
	{
	}

	private bool CheckAndShowEmptySlotView(HippoCrisisDragSourceInfo sourceInfo)
	{
		return false;
	}

	private void RefreshItemDetailInfoView()
	{
	}

	private void RefeshAttachment()
	{
	}

	private void RefreshWeaponProperty(bool show)
	{
	}

	private bool CheckNeedShowWeaponProperty(FDAEPHMIEPC.DBENAPILEBC weaponType)
	{
		return false;
	}

	private void RefreshBottomBtnsView(bool isConsumables)
	{
	}

	private void RefreshBlackMarketPageBtnsView()
	{
	}

	private void RefreshInventoryPageBtnsView(bool isConsumables)
	{
	}

	private void RefreshPreStartPageBtnsView(bool isConsumables)
	{
	}

	private void RefreshMatchResultPageBtnsView()
	{
	}

	private void RefreshInGamePageBtnsView(bool isConsumables)
	{
	}

	private void RefreshBtnsView(List<HippoCrisisItemBriefBoxBtnData> dataList)
	{
	}

	public HippoCrisisStoreItemData GetCurStoreData()
	{
		return null;
	}

	public HippoCrisisOutGameItemUIData GetCurOutGameItemUIData()
	{
		return null;
	}

	public HippoCrisisDragSourceInfo GetCurSourceInfo()
	{
		return default(HippoCrisisDragSourceInfo);
	}

	public EHCPageType GetPageType()
	{
		return EHCPageType.Inventory;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public bool _003C_003EiFixBaseProxy_IgnoreEsc()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
