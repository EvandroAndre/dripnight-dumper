using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIProfileWeaponNodeController : UIBaseController, IUIModelDataChangeObserver, IEasyList
{
	private const uint WEAPON_TYPE_ALL = 0u;

	private UIModelWeaponProficiency m_ModelWeaponProficiency;

	private UIModelProfile m_ModelProfile;

	private UIProfileWeaponNodeView m_View;

	private UIPopMenuSmallControler m_WeaponTypeMenu;

	private UIPopMenuSmallControler m_SeasonMenu;

	private ulong m_AccountID;

	private ulong m_StartShowTime;

	private int m_ShowTime;

	private const string PAGE_NAME = "ProfileWeaponNode";

	private bool m_FistInProfileWeaponNode;

	private uint[] m_CurrentFilter;

	private List<PopMenuData> m_ListWeponTypeFilterData;

	private List<PopMenuData> m_ListSeasonFilterData;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void InitPopMenu()
	{
	}

	public void InitUI()
	{
	}

	public void PlayItemAnim()
	{
	}

	private void RefreshSeasonBtnState(bool isBR)
	{
	}

	private void OnBrRankToggleBtnnClick()
	{
	}

	private void OnCsRankToggleBtnnClick()
	{
	}

	private void ResetCurrentFilter()
	{
	}

	private void OnWeaponTypeFilterSelected(uint weaponType)
	{
	}

	private void OnSeasonFilterSelected(uint season)
	{
	}

	private void OnMatchModeFilterSelected(uint matchMode)
	{
	}

	private void RefreshViewWithFilter()
	{
	}

	private void RefreshMenuView()
	{
	}

	private void SetWeaponTypeFilterPopMenuDataList()
	{
	}

	private void SetSeasonFilterPopMenuDataList()
	{
	}

	private void SetWeaponTypeFilterPopMenu()
	{
	}

	private void SetSeasonFilterPopMenuData()
	{
	}

	private void JumpToBRRank()
	{
	}

	private void JumpToCSRank()
	{
	}

	private bool CheckIsSolo()
	{
		return false;
	}

	public void SetAccountID(ulong accountID)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private bool _003CRefreshMenuView_003Eb__29_0(PopMenuData x)
	{
		return false;
	}

	private bool _003CRefreshMenuView_003Eb__29_1(PopMenuData x)
	{
		return false;
	}

	private void _003CSetWeaponTypeFilterPopMenuDataList_003Eb__30_0(object obj)
	{
	}

	private void _003CSetWeaponTypeFilterPopMenuDataList_003Eb__30_1(object obj)
	{
	}

	private void _003CSetSeasonFilterPopMenuDataList_003Eb__31_0(object obj)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
