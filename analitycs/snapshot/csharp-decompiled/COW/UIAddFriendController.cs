using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIAddFriendController : UIBaseController, IUIModelDataChangeObserver, IEasyList
{
	public enum EPlayerSocialType
	{
		Gender = 1,
		TimeActive = 4,
		ModePrefer = 5
	}

	private UIAddFriendView m_View;

	private bool m_HasSearch;

	private int m_scrollWidth;

	private UIModelQRCode m_ModelQRCode;

	private UIPopMenuSmallControler m_TimeActivePopMenuController;

	private UIPopMenuSmallControler m_ModePreferPopMenuController;

	private UIPopMenuSmallControler m_GenderPopMenuController;

	private UISelectLanguageController m_UISelectLanguageController;

	private List<PlayerSocialTagsData> m_GenderList;

	private List<PlayerSocialTagsData> m_TimeActiveList;

	private List<PlayerSocialTagsData> m_ModePreferList;

	private List<PopMenuData> m_LanguageDataList;

	private const int TOGGLE_GROUP_ID = 117;

	private string ADD_FRIEND_FILTER;

	private ESocial.Language m_SelectedLanguage;

	private ESocial.Gender m_SelectedGender;

	private ESocial.TimeActive m_SelectedTimeActive;

	private ESocial.ModePrefer m_SelectedModePrefer;

	private Vector4 m_ExpandRegion;

	private Vector3 m_ExpandPos;

	private Vector4 m_ShrinkRegion;

	private Vector3 m_ShrinkPos;

	private bool m_IsExpand;

	private UIFriendController.EFriendSearchType m_SearchType;

	private uint _003CRefreshState_003Ek__BackingField;

	public UIFriendController.EFriendSearchType SearchType => UIFriendController.EFriendSearchType.FuzzySearch;

	public uint RefreshState
	{
		get
		{
			return _003CRefreshState_003Ek__BackingField;
		}
		private set
		{
			_003CRefreshState_003Ek__BackingField = value;
		}
	}

	public EFriendTabType CurrentTabType => EFriendTabType.None;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnVisibilityChanged()
	{
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void InitPopMenus()
	{
	}

	public void SetViewData(int width)
	{
	}

	private void OnSearchBtnClick()
	{
	}

	private void OnInputSubmit()
	{
	}

	public bool IsDefaultSearch()
	{
		return false;
	}

	public bool IsLanguageDefault()
	{
		return false;
	}

	public bool IsModePreferDefault()
	{
		return false;
	}

	public bool isTimeActiveDefault()
	{
		return false;
	}

	private void OnRefreshBtnClick()
	{
	}

	public void OnRefreshSelectBtnClick()
	{
	}

	private void OnLanguageBtnClick()
	{
	}

	private void OnSearchInputChange()
	{
	}

	private void RefreshShrinkView()
	{
	}

	private void RefreshExpandView()
	{
	}

	private void RefreshTopView()
	{
	}

	private void OnExpandBtnOnClick()
	{
	}

	private void OnClearButtonClicked()
	{
	}

	private void OnQRCodeBtnClick()
	{
	}

	private void OnQRCodeScanBtnClick()
	{
	}

	private void OnSearchInputGetFocus()
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

	private void RefreshList(List<FriendAccountInfo> accountList, bool keep_page = false)
	{
	}

	private void InitLanguageList()
	{
	}

	private void GenerateGenderMenuData()
	{
	}

	private void GenerateTimeActiveMenuData()
	{
	}

	private void GenerateModePreferMenuData()
	{
	}

	private void OnGenderSelected(object obj)
	{
	}

	private void OnTimeActiveSelected(object obj)
	{
	}

	private void OnModeHobbySelected(object obj)
	{
	}

	private void OnLocLanguageSelect(object obj)
	{
	}

	private bool _003CInitPopMenus_003Eb__37_0(PlayerSocialTagsData x)
	{
		return false;
	}

	private bool _003CInitPopMenus_003Eb__37_1(PlayerSocialTagsData x)
	{
		return false;
	}

	private bool _003CInitPopMenus_003Eb__37_2(PlayerSocialTagsData x)
	{
		return false;
	}

	private bool _003COnRefreshSelectBtnClick_003Eb__46_0(PlayerSocialTagsData x)
	{
		return false;
	}

	private bool _003COnRefreshSelectBtnClick_003Eb__46_1(PlayerSocialTagsData x)
	{
		return false;
	}

	private bool _003COnRefreshSelectBtnClick_003Eb__46_2(PlayerSocialTagsData x)
	{
		return false;
	}

	private bool _003COnGenderSelected_003Eb__66_0(PlayerSocialTagsData x)
	{
		return false;
	}

	private bool _003COnTimeActiveSelected_003Eb__67_0(PlayerSocialTagsData x)
	{
		return false;
	}

	private bool _003COnModeHobbySelected_003Eb__68_0(PlayerSocialTagsData x)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
