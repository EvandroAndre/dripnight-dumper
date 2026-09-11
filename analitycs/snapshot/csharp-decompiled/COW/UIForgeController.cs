using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIForgeController : UIPreviewNavigationController, IUIModelDataChangeObserver, IEasyList
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<uint> _003C_003E9__41_0;

		internal int _003CInitToggles_003Eb__41_0(uint a, uint b)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass46_0
	{
		public uint itemId;

		internal bool _003CNavigationToItem_003Eb__0(ChestSpecialExchangeDesc item)
		{
			return false;
		}
	}

	private UIForgeView m_View;

	private UINavigationData m_LastNavigationData;

	private uint m_NavToggleType;

	private uint m_NavItemId;

	private Dictionary<uint, UIToggleButton> m_ToggleDict;

	private List<ChestSpecialExchangeDesc> m_CurrentDataList;

	private uint m_CurrentTab;

	private bool m_ForgeDataInitialized;

	private bool m_NavigationDataInitialized;

	private bool m_IsSelectedFirstToggleOnInit;

	private List<UISprite> m_NotEnoughMaterial;

	private uint m_SelectedId;

	private uint m_SelectedItemId;

	private bool m_HaveEnoughMaterial;

	private const uint MATERIAL_LABEL_RED = 4281150975u;

	private const uint EXCHANGE_LABEL_GREY = 2139062271u;

	private bool m_ItemCanExchange;

	private UIRoot m_UIRoot;

	private UIModelGacha m_ModelGacha;

	private UIModelInventory m_ModelInventory;

	private UIModelMall m_ModelMall;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void InitMaterialDict()
	{
	}

	private void OnExchangeBtnClick()
	{
	}

	private void OnMaterial1BtnClick(object[] data)
	{
	}

	private void OnMaterial2BtnClick(object[] data)
	{
	}

	private void ShowMaterialDesc(Vector3 pos, int index)
	{
	}

	private void OnItemSelected(object[] data)
	{
	}

	private void RefreshItemView(uint id)
	{
	}

	private void OnRefreshForgeItem(object[] data)
	{
	}

	private void RefreshMaterialView(ChestSpecialExchangeDesc desc)
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	private void InitNavigationData(UINavigationData navigationData)
	{
	}

	protected override void OnSendShowTimeEvent(ref string eventLogKey, ref EventLogger.EventPageDetentionTime eventLog)
	{
	}

	protected override void OnUIDestory()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void HighlightCurrent()
	{
	}

	protected override bool NeedWaitDataReady()
	{
		return false;
	}

	private void RefreshView()
	{
	}

	private void InitToggles()
	{
	}

	private void OnTabToggleSelected()
	{
	}

	private void RefreshViewData(List<ChestSpecialExchangeDesc> dataList, bool needSort = true)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	private void NavigationToItem(uint tabType, uint itemId)
	{
	}

	private int SortItem(ChestSpecialExchangeDesc x, ChestSpecialExchangeDesc y)
	{
		return 0;
	}

	private bool CheckItemCanPurchase(uint limited_purchase_times, uint purchase_times)
	{
		return false;
	}

	public override EFrontendBGMType GetBGMType()
	{
		return EFrontendBGMType.NONE;
	}

	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	protected override FrontendPreviewType GetPreviewUIType()
	{
		return FrontendPreviewType.Lobby;
	}

	private bool _003CHighlightCurrent_003Eb__38_0(ChestSpecialExchangeDesc item)
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public void _003C_003EiFixBaseProxy_OnSendShowTimeEvent(ref string P0, ref EventLogger.EventPageDetentionTime P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public bool _003C_003EiFixBaseProxy_NeedWaitDataReady()
	{
		return false;
	}

	public EFrontendBGMType _003C_003EiFixBaseProxy_GetBGMType()
	{
		return EFrontendBGMType.NONE;
	}
}
