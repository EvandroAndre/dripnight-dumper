using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIClanEditController : UINavigationController, IUIModelDataChangeObserver, ITipsDelegate
{
	public enum FuntionType
	{
		Create,
		Edit,
		Inspect
	}

	public enum TokenType
	{
		Gold = 1,
		Diamond
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static EventDelegate.Callback _003C_003E9__87_0;

		public static EventDelegate.Callback _003C_003E9__87_1;

		internal void _003CPrepareTopBarTokens_003Eb__87_0()
		{
		}

		internal void _003CPrepareTopBarTokens_003Eb__87_1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass54_0
	{
		public UIClanEditController _003C_003E4__this;

		public AccountInfoBasic info;

		public EventLogger.BriefBoxClickData clickData;

		internal void _003COnRequestAccountInfoFinish_003Eb__0()
		{
		}
	}

	private UIClanEditView m_View;

	private EClan.EntryType m_CurApprovalType;

	private FuntionType m_FunctionType;

	private UIModelClan m_ModelClan;

	private UIModelClanWarV2 m_ModelClanWarV2;

	private UIModelClanWarChampionship m_ModelClanWarChampionship;

	private PopMenuData m_DefaultMenuData;

	protected List<PopMenuData> m_DataList;

	private UIPopMenuSmallControler m_SelectLevelPopMenuSmallCtrl;

	private UIPopMenuSmallControler m_SelectBRRankPopMenuSmallCtrl;

	private UIPopMenuSmallControler m_SelectCSRankPopMenuSmallCtrl;

	private uint m_AreaID;

	private uint m_LimitLevel;

	private int m_LimitRank;

	private int m_LimitCSRank;

	private bool m_UseCustomBadge;

	private uint m_BadgeId;

	private string m_BadgetCDN;

	private uint m_FrameId;

	private ulong m_RequestAccountId;

	private List<uint> m_TagIdList;

	private TokenType m_CurrentTokenType;

	private const int CREATE_CLAN_NAME_LOWER_LIMIT = 3;

	private const int SLOGAN_MAX_LENGTH = 20;

	private const int ANNOUNCEMENT_MAX_LENGTH = 80;

	private const int POPMENUWIDTH = 263;

	private const string m_DefaultText = "TXT_SETTING_AIDER_ALLON";

	private const string GUIDE_SHOW_KEY = "ClanEditGuide";

	private const string CLAN_EDIT_REGION_KEY = "CLAN_EDIT_REGION_KEY_{0}";

	private const string CLAN_EIDT_BADGE_KEY = "CLAN_EIDT_BADGE_KEY_{0}";

	private const string CLAN_EDIT_TAG_KEY = "CLAN_EDIT_TAG_KEY_{0}";

	private List<UIClanTagItemController> m_TagCtrlList;

	private UICountDownController m_CDController;

	private UIBaseProfileInfoController m_ProfileInfoController;

	private UITipsNormalController m_RegionTipsCtrl;

	private UITipsNormalController m_BadgeTipsCtrl;

	private UITipsNormalController m_TagTipsCtrl;

	private UIClanEditTopBarGloryController m_GloryCtrl;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	protected override void OnUIClose()
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	private void InitEvent()
	{
	}

	public void SetFunctionType(FuntionType type)
	{
	}

	private void InitView()
	{
	}

	private void UpdateView()
	{
	}

	private void UpdateClanIcon()
	{
	}

	private void UpdateLeaderInfo(ulong accountId)
	{
	}

	private void OnRequestAccountInfoFinish(object[] data)
	{
	}

	public void UpdateRank(int rank)
	{
	}

	public void UpdateCSRank(int rank)
	{
	}

	private void UpdateApprovalView(bool isApprove)
	{
	}

	private void RefreshPriceBtnState(uint coinCost, uint gemCost)
	{
	}

	private void RefreshGlory()
	{
	}

	private void RefreshTitleRedPoint()
	{
	}

	private void GenerateLevelMenuData()
	{
	}

	private void OnLevelSelected(object obj)
	{
	}

	private void GenerateBRRankMenuData()
	{
	}

	private void OnBRRankSelected(object obj)
	{
	}

	private void GenerateCSRankMenuData()
	{
	}

	private void OnCSRankSelected(object obj)
	{
	}

	private void OnEditNameClick()
	{
	}

	private void OnAutoToggleClick()
	{
	}

	private void OnApproveToggleClick()
	{
	}

	private void OnCoinBtnClick()
	{
	}

	private void OnGemBtnClick()
	{
	}

	private void OnBtnConfirmClick()
	{
	}

	private bool CheckClanInfoValid()
	{
		return false;
	}

	private void OnSettingSave()
	{
	}

	private bool HasTagsChanged(List<uint> tags)
	{
		return false;
	}

	private void OnClickClanWarHistoryBtn()
	{
	}

	private void OnClanLogoEdit()
	{
	}

	private void ResetBadgeId(object[] data)
	{
	}

	private void OnClanRegionEdit()
	{
	}

	private void SelectRegion(object[] data)
	{
	}

	private void SetDefaultAreaId()
	{
	}

	private void InitTags()
	{
	}

	private void OnClanTagEditBtnClick()
	{
	}

	public void RefreshTags(object[] data)
	{
	}

	private void OnClanPromotionBtnClick()
	{
	}

	private void RefreshPromotion()
	{
	}

	private void PrepareTopBarTokens()
	{
	}

	protected override void OnHelpButtonClick(object[] param)
	{
	}

	public void OnTipsDataChange(ETipsType type, int num)
	{
	}

	private void UpdateRedDot()
	{
	}

	private void UpdateRegionRedDot()
	{
	}

	private void UpdateBadgeRedDot()
	{
	}

	private void UpdateTagRedDot()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public void _003C_003EiFixBaseProxy_OnHelpButtonClick(object[] P0)
	{
	}
}
