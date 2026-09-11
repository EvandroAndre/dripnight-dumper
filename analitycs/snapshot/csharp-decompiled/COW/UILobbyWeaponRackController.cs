using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UILobbyWeaponRackController : UINavigationController, IEasyList
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<uint> _003C_003E9__22_0;

		public static Comparison<WeaponItemData> _003C_003E9__23_0;

		internal int _003CProcessCollectionData_003Eb__22_0(uint a, uint b)
		{
			return 0;
		}

		internal int _003CRefreshWeaponList_003Eb__23_0(WeaponItemData a, WeaponItemData b)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass34_0
	{
		public string key;

		public UILobbyWeaponRackController _003C_003E4__this;

		internal void _003COnCameraMoveEnd_003Eb__0()
		{
		}
	}

	private const string UILobbyWeaponRackNewGuideKey = "UILOBBYWEAPONRACKNEWGUIDEKEY";

	private UILobbyWeaponRackView m_View;

	private UIModelWeaponRack m_ModelRack;

	private UIPopMenuSmallControler m_PopMenuGun;

	private UIPopMenuSmallControler m_PopMenuRare;

	private uint m_CurrentSelectWeaponID;

	private CollectionDataManager.ECollectionWeaponType m_CurrentFilterWeaponType;

	private UIModelCollection m_ModelCollection;

	private List<PopMenuData> m_WeaponTypeFilterPopMenuList;

	private List<PopMenuData> m_WeaponRareFilterPopMenuList;

	private List<WeaponItemData> m_CurrentListBeforeQuality;

	private Dictionary<uint, List<WeaponSkinBaseInfo>> WeaponSkinBaseInfoDic;

	private Dictionary<uint, List<uint>> m_WeaponDataList;

	private List<uint> m_WeaponTypeList;

	private const string DEFAULTWEAPONTYPE = "T_15_Q_LIVE_ALL";

	private Dictionary<uint, string> m_DictWeaponType2Text;

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

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	public override void OnNavigationClosed()
	{
	}

	protected override void OnHelpButtonClick(object[] param)
	{
	}

	private void ProcessCollectionData()
	{
	}

	private void RefreshWeaponList(List<WeaponSkinBaseInfo> weaponList)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	private void GenerateWeaponTypeFilterData()
	{
	}

	private void OnWeaponTypeFilterItemClick(object data)
	{
	}

	private void GenerateQualityPopData()
	{
	}

	private void OnQualityItemClick(object data)
	{
	}

	private void RefreshAllWeapons()
	{
	}

	private void OnDragStart(object[] data)
	{
	}

	private void OnClickCloseButton()
	{
	}

	private void OnGotoShopButtonClick()
	{
	}

	private void OnCameraMoveEnd(object[] data)
	{
	}

	private void _003COnCameraMoveEnd_003Eb__34_1()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	public void _003C_003EiFixBaseProxy_OnHelpButtonClick(object[] P0)
	{
	}
}
