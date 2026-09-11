using System;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

internal class UIBigEvent_GlobalProgress_ExchangeStoreController : UINaviPopController, IUIModelDataChangeObserver, IEasyList, IBigEventTemplateIdentifier
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<CustomEventStoreCommodityDesc> _003C_003E9__25_0;

		public static Comparison<CustomEventStoreCommodityDesc> _003C_003E9__25_1;

		internal int _003CSetStoreItemListView_003Eb__25_0(CustomEventStoreCommodityDesc a, CustomEventStoreCommodityDesc b)
		{
			return 0;
		}

		internal int _003CSetStoreItemListView_003Eb__25_1(CustomEventStoreCommodityDesc a, CustomEventStoreCommodityDesc b)
		{
			return 0;
		}
	}

	private UIBigEvent_GlobalProgress_ExchangeStoreView m_View;

	private UIModelBigEventTemplate m_ModelBigEventTemplate;

	private UIModelInventory m_ModelInventory;

	private UIModelActivity m_ModelActivity;

	private EStoreTab m_StoreTab;

	private Color m_StoreTabNotChoose;

	private Color m_StoreTabChosen;

	private bool m_ClassicStoreLock;

	private bool m_SpecialStoreLock;

	private int m_TokenNums;

	private UIBigEvent_GlobalProgress_TokenItemController m_TokenCtrl;

	private EBigEventTemplateUseType _003CTemplateUseType_003Ek__BackingField;

	public EBigEventTemplateUseType TemplateUseType
	{
		get
		{
			return _003CTemplateUseType_003Ek__BackingField;
		}
		private set
		{
			_003CTemplateUseType_003Ek__BackingField = value;
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	public override void OnNavigationClosed()
	{
	}

	private void OnClickRule()
	{
	}

	private void OnClickToggleClassic()
	{
	}

	private void OnClickToggleSpecial()
	{
	}

	private void OnRedTipsOnOffClick()
	{
	}

	private void SetDefaultView()
	{
	}

	private void InitView()
	{
	}

	private void SetUGCStyle()
	{
	}

	private void SetOpenTimeView()
	{
	}

	private void SetTokenIconView()
	{
	}

	private void SetCDNView()
	{
	}

	private void SetStoreItemListView(EStoreTab storeTab)
	{
	}

	private void SetTabView()
	{
	}

	private void SetExchangeHintView(EStoreTab storeTab)
	{
	}

	private void SetTabRedTipsView()
	{
	}

	public virtual EBigEventTemplateType GetTemplateType()
	{
		return EBigEventTemplateType.None;
	}

	public void OnTemplateUIInit()
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void _003CSetCDNView_003Eb__24_0()
	{
	}

	private void _003CSetCDNView_003Eb__24_1()
	{
	}

	private void _003CSetCDNView_003Eb__24_2()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}
}
