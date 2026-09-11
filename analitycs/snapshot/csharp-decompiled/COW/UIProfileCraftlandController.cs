using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIProfileCraftlandController : UIBaseController, IUIModelDataChangeObserver
{
	private enum ESortType
	{
		ByUpdate,
		ByPlayCount,
		End
	}

	private sealed class _003C_003Ec__DisplayClass60_0
	{
		public UGCCreatorLabelConfig authorLabelConfig;

		internal void _003CRefreshKolContent_003Eb__0()
		{
		}
	}

	private UIProfileCraftlandView m_View;

	private UIPopMenuSmallControler m_SortPopMenu;

	private UIPopMenuSmallControler m_ModelPopMenu;

	private Dictionary<int, string> m_SortKeys;

	private List<PopMenuData> m_FilterModeData;

	private List<PopMenuData> m_SortPopMenuData;

	private List<UIUGCProfileCraftlandMapController> m_CachedMapItemList;

	private string m_filterByGameMode;

	private ESortType m_SortType;

	private ulong m_AccountId;

	private WorkshopAuthorInfo m_WorkshopAuthorInfo;

	private bool m_IsUserSelf;

	private ulong m_UserAccountId;

	private bool m_NeedRequestSlotInfo;

	public const int MAX_DESC_LINE = 3;

	public const int CONTENT_HEIGHT = 462;

	public const int CONTENT_Y = 136;

	private UIModelProfile m_Model;

	private UIModelUser m_ModelUser;

	private UIModelSceneEdit m_ModelSceneEdit;

	private UIModelCraftlandProfile m_ModelCraftlandProfile;

	private UIModelRole m_ModelRole;

	private UIModelProfileCustom m_ModelProfileCustom;

	private UIProfileCustomCollectionSocialMediaItemController m_SocialMediaItemCtrl;

	private UIUGCCreatorLevelIconController m_CreatorLevelIconCtrl;

	private List<string> m_PinModeMapShareCodeList;

	private List<string> m_PinModeMapShareCodeBackupList;

	private string m_CurrentBio;

	private string m_PendingBioSubmit;

	private uint PrivilegeRole;

	private Color COLOR_ADD;

	private Color COLOR_REDUCE;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void SetViewData(ulong accountId)
	{
	}

	private void RefreshLayout()
	{
	}

	private void OnShowCreatorLevelProfile()
	{
	}

	private void OnUnFollowBtnClick()
	{
	}

	private void OnFollowBtnClick()
	{
	}

	private void RefreshFollowButtons()
	{
	}

	private void OnVipIconBtnClick()
	{
	}

	private void OnPrivilegeBtnClick()
	{
	}

	private void OnInputFieldBioSubmit()
	{
	}

	private void OnBtnSettingClick()
	{
	}

	private void OnBtnSaveClick()
	{
	}

	private void OnBtnExitClick()
	{
	}

	private void RefreshPinMode(bool isPinMode)
	{
	}

	private void OnAllowDisclosureBtnClick()
	{
	}

	private void OnAllowDisclosureHelpBtnClicked()
	{
	}

	private EWorkshop.AuthorTag GetAuthorTag()
	{
		return EWorkshop.AuthorTag.AuthorTag_NONE;
	}

	private void SetAuthorInfo(WorkshopAuthorInfo authorInfo)
	{
	}

	private void RefreshCreatorStats(WorkshopAuthorInfo authorInfo)
	{
	}

	private WorkShopCreatorLevel GetDisplayWorkshopCreatorInfo(WorkshopAuthorInfo authorInfo)
	{
		return null;
	}

	private void RefreshStatsIncrement(ulong authorId)
	{
	}

	private string FormatDelta(int delta, UISprite bgScprite)
	{
		return null;
	}

	private void RefreshKolContent()
	{
	}

	private void InitSortPopMenuData()
	{
	}

	private string GetModeName(SceneEditSlotInfo info)
	{
		return null;
	}

	private void LogUGCNavigate(SceneEditSlotInfo slotInfo)
	{
	}

	public void SetCraftlandData(List<UISceneEditRecommendationItemInfo> data)
	{
	}

	private void OnToggleChangeCallback()
	{
	}

	private void SetSortPopMenuData()
	{
	}

	private void SetPopMenuData()
	{
	}

	private void OnSortFilterByType(object type)
	{
	}

	private void OnFilterByGameMode(object mode)
	{
	}

	private void RefreshView(string filter, ESortType sortType)
	{
	}

	private int OnSortByUpdateTime(UISceneEditRecommendationItemInfo a, UISceneEditRecommendationItemInfo b)
	{
		return 0;
	}

	private int OnSortByPlayCount(UISceneEditRecommendationItemInfo a, UISceneEditRecommendationItemInfo b)
	{
		return 0;
	}

	private int CompareByPinOrder(UISceneEditRecommendationItemInfo a, UISceneEditRecommendationItemInfo b)
	{
		return 0;
	}

	private void RefreshSocialMedia()
	{
	}

	private void CreateSocialMediaItem(ProfileCustomSocialMediaData data)
	{
	}

	private void OnSocialMediaBtnClick()
	{
	}

	private void SetDisplaySocialMediaType(GalleryShow.SocialMediaType type)
	{
	}

	private void OnEmptyButtonClick()
	{
	}

	public void RefreshUserName()
	{
	}

	private void OnRequestAccountInfoFinish(object[] data)
	{
	}

	private void OnWorkshopPersonalInfoUpdate()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_Show()
	{
	}

	public void _003C_003EiFixBaseProxy_Hide()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
