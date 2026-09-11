using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

internal class UICreateRoomSettingCSAdController : UIBaseController, IEasyList
{
	public enum CSRoomSettingType
	{
		None,
		Store,
		Eco,
		Map
	}

	private enum TabType
	{
		ALL,
		RIFLE,
		SNIPER,
		PISTOL,
		SUBMACHINE,
		SHOTGUN,
		MELEE,
		THROWING,
		SPECIAL
	}

	private sealed class _003C_003Ec__DisplayClass43_0
	{
		public UICreateRoomSettingCSAdController _003C_003E4__this;

		public RoomCreateCSShopData shopData;

		internal void _003CInitShopControllers_003Eb__0(int val)
		{
		}

		internal void _003CInitShopControllers_003Eb__1(bool val)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass49_0
	{
		public UICreateRoomSettingCSAdController _003C_003E4__this;

		public int index;

		internal void _003CInitRoundController_003Eb__0(int val)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass50_0
	{
		public UICreateRoomSettingCSAdController _003C_003E4__this;

		public RoomCreateCSEcoData data;

		internal void _003CInitEcoController_003Eb__0(int val)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass54_0
	{
		public UICreateRoomSettingCSAdController _003C_003E4__this;

		public UICreateRoomController parent;

		public uint mapConfigId;
	}

	private sealed class _003C_003Ec__DisplayClass54_1
	{
		public uint mapId;

		public _003C_003Ec__DisplayClass54_0 CS_0024_003C_003E8__locals1;

		internal void _003CGenerateMapListDropList_003Eb__0(object obj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass57_0
	{
		public uint poiId;

		internal bool _003CRefreshMapPickItem_003Eb__0(ADCSMapData d)
		{
			return false;
		}
	}

	private sealed class _003CTableReposition_003Ed__69 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UICreateRoomSettingCSAdController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CTableReposition_003Ed__69(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	protected UICreateRoomSettingCSAdView m_View;

	protected RoomCreateRuleDataManager m_DataManager;

	protected UIModelCustomRoom m_CustomRoomModel;

	protected UIRoomDropListTemplateController m_RoundDropCtrl;

	protected UIRoomDropListTemplateController m_MapRoundDropCtrl;

	protected UIRoomDropListTemplateController m_MapListDropCtrl;

	private uint m_WeaponTypeTab;

	protected int m_RoundCnt;

	private int m_CSShopMaxCost;

	private int m_CSShopCostInterval;

	public bool IsFirstTimeOpenADCS;

	public bool IsFirstTimeOpenADCSMap;

	private string m_ItemName;

	private CSRoomSettingType m_CurrentSettingType;

	private const string GUIDE_KEY = "KEY_CUSTOMROOM_ADCS_TOGGLE";

	private UIRoomDropListTemplateController m_WeaponDropCtrl;

	private List<UIRoomCheckSliderTemplateController> m_CachedWeaponControllers;

	private List<UIRoomCheckSliderTemplateController> m_CachedItemControllers;

	protected List<UIRoomCheckSliderTemplateController> m_CachedRoundControllers;

	protected List<UIRoomCheckSliderTemplateController> m_CachedEcoControllers;

	protected const float CREATE_ROOM_SETTING_CSAD_POPMENU_OFFSET = 191f;

	protected uint m_CurrentCacheMapConfigID;

	protected int m_CurrentSelectedMapPickIndex;

	protected List<UICSMapPickItemController> m_CachedMapPickItemControllers;

	protected bool m_InitMapSettingsData;

	private Color m_CheckBtnDisableColor;

	private Color m_CheckBtnEnableColor;

	private Dictionary<uint, string> TAB_TYPE_NAME;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void InitDefaultSettings()
	{
	}

	private void OnToggleADCSClick()
	{
	}

	private void ToggleADCSClick(bool init = false)
	{
	}

	public void ResetOpen(CSRoomSettingType type)
	{
	}

	public CSRoomSettingType GetCurrentSettingType()
	{
		return CSRoomSettingType.None;
	}

	private void OnBtnTipsClick()
	{
	}

	private void OnMaskClick()
	{
	}

	public void SetIsCSMode(bool isCS, uint roomType)
	{
	}

	private void InitStoreSettings()
	{
	}

	private List<PopMenuData> GenerateWeaponDropList()
	{
		return null;
	}

	private void RefreshWeaponGrid(uint typeTab)
	{
	}

	private void InitShopControllers(UIRoomCheckSliderTemplateController ctrl, RoomCreateCSShopData shopData)
	{
	}

	protected virtual void InitEcoSettings()
	{
	}

	protected virtual List<PopMenuData> GenerateRoundDropList()
	{
		return null;
	}

	private void TrySyncCSMapInNormalSetting()
	{
	}

	private void TrySyncCSRoundInNormalSetting()
	{
	}

	public void RefreshRoundGrid(int round)
	{
	}

	protected void InitRoundController(UIRoomCheckSliderTemplateController ctrl, int index)
	{
	}

	protected void InitEcoController(UIRoomCheckSliderTemplateController ctrl, RoomCreateCSEcoData data)
	{
	}

	protected virtual void InitMapSettingsUI()
	{
	}

	protected virtual void InitMapSettingsData()
	{
	}

	protected virtual List<PopMenuData> GenerateRoundListInMapDropList()
	{
		return null;
	}

	protected virtual List<PopMenuData> GenerateMapListDropList()
	{
		return null;
	}

	private void InitMapItemList(uint mapId)
	{
	}

	private void InitMapPickItemList(uint mapId, int roundCount, bool mapsChanged = false)
	{
	}

	private void RefreshMapPickItem(List<ADCSMapData> datas, int index)
	{
	}

	public void OnMapPickItemSelect(int index, uint poiId)
	{
	}

	public int GetCurrentSelectedMapPickIndex()
	{
		return 0;
	}

	public void OnMapItemSelect(ADCSMapData data)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	private void OnToggleSettingClick()
	{
	}

	public void RefreshCheckBtn()
	{
	}

	public void ResetADCSToggle()
	{
	}

	private void RefreshSelectedShopItemCnt()
	{
	}

	private void RefreshWeaponToggle()
	{
	}

	public void RepositionAllSettings(bool delayTableReposition = false)
	{
	}

	private IEnumerator TableReposition()
	{
		return null;
	}

	private void _003CGenerateWeaponDropList_003Eb__41_0(object obj)
	{
	}

	private void _003CGenerateRoundDropList_003Eb__45_0(object obj)
	{
	}

	private void _003CGenerateRoundListInMapDropList_003Eb__53_0(object obj)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
