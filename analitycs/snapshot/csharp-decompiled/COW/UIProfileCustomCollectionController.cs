using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIProfileCustomCollectionController : UIBaseController, IEasyList, IUIModelDataChangeObserver
{
	public enum VaultItemType
	{
		All,
		Set,
		Bundle,
		Hair,
		Face,
		HeadAdditive,
		Chest,
		Legs,
		Feet,
		Flight,
		Emote,
		SuperEmote,
		Pet,
		LoadingCard
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<uint> _003C_003E9__89_0;

		internal int _003CGenerateWeaponTypeFilterData_003Eb__89_0(uint a, uint b)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass76_0
	{
		public UIProfileCustomCollectionController _003C_003E4__this;

		public ProfileCustomDragTemplate dragTemplate;

		internal UITable2.IUITable2Item _003CInitItemTemplate_003Eb__0()
		{
			return null;
		}

		internal UITable2.IUITable2Item _003CInitItemTemplate_003Eb__1()
		{
			return null;
		}

		internal UITable2.IUITable2Item _003CInitItemTemplate_003Eb__2()
		{
			return null;
		}

		internal UITable2.IUITable2Item _003CInitItemTemplate_003Eb__3()
		{
			return null;
		}

		internal UITable2.IUITable2Item _003CInitItemTemplate_003Eb__4()
		{
			return null;
		}

		internal UITable2.IUITable2Item _003CInitItemTemplate_003Eb__5()
		{
			return null;
		}

		internal UITable2.IUITable2Item _003CInitItemTemplate_003Eb__6()
		{
			return null;
		}

		internal UITable2.IUITable2Item _003CInitItemTemplate_003Eb__7()
		{
			return null;
		}

		internal UITable2.IUITable2Item _003CInitItemTemplate_003Eb__8()
		{
			return null;
		}

		internal UITable2.IUITable2Item _003CInitItemTemplate_003Eb__9()
		{
			return null;
		}

		internal UITable2.IUITable2Item _003CInitItemTemplate_003Eb__10()
		{
			return null;
		}

		internal UITable2.IUITable2Item _003CInitItemTemplate_003Eb__11()
		{
			return null;
		}

		internal UITable2.IUITable2Item _003CInitItemTemplate_003Eb__12()
		{
			return null;
		}

		internal UITable2.IUITable2Item _003CInitItemTemplate_003Eb__13()
		{
			return null;
		}

		internal UITable2.IUITable2Item _003CInitItemTemplate_003Eb__14()
		{
			return null;
		}

		internal UITable2.IUITable2Item _003CInitItemTemplate_003Eb__15()
		{
			return null;
		}

		internal UITable2.IUITable2Item _003CInitItemTemplate_003Eb__16()
		{
			return null;
		}

		internal UITable2.IUITable2Item _003CInitItemTemplate_003Eb__17()
		{
			return null;
		}

		internal UITable2.IUITable2Item _003CInitItemTemplate_003Eb__18()
		{
			return null;
		}
	}

	private UIProfileCustomCollectionView m_View;

	private List<ProfileCustomCollectionTabData> m_TabDataList;

	private Bounds m_CancelAreaBounds;

	private ProfileCustomTab m_CurrentTab;

	private UIModelProfileCustom m_ModelProfileCustom;

	private UIModelCollection m_ModelCollection;

	private UIModelInventory m_ModelInventory;

	private UIModelNewVault m_ModelNewVault;

	private UIModelWeaponSkinPokedex m_ModelWeaponSkinPokedex;

	private UIModelAchievement m_ModelAchievement;

	private UIModelProfile m_ModelProfile;

	private UIModelUser m_ModelUser;

	private UIModelBooyahPass m_ModelBP;

	private UIModelWeaponProficiency m_ModelWeaponProficiency;

	private UIModelLadderMatch m_ModelLadderMatch;

	private UIModelCSPeakTournamentLadderMatch m_ModelCSPeakTournamentLadderMatch;

	private UIModelRelationShip m_ModelRelationShip;

	private UIModelClanWarV2 m_ModelClanWarV2;

	private UIModelLeaderBoardTitle m_ModelLeaderBoardTitle;

	private UIModelClan m_ModelClan;

	private UIModelPet m_ModelPet;

	private UIModelRole m_ModelRole;

	private List<WeaponSkinBaseInfo> m_WeaponSkinItemList;

	private List<uint> m_CompletedAchievement;

	private List<AchievementProfileItemData> m_AchievementProfileItemList;

	private List<TitleInfo> m_SortedTitleList;

	private UIPopMenuSmallControler m_WeaponTypeFilterPopMenu;

	private CollectionDataManager.ECollectionWeaponType m_CurrentFilterWeaponType;

	private List<uint> m_SortedItemList;

	private VaultItemType m_CurrentFilterVaultType;

	private Dictionary<uint, List<uint>> m_DicVaultTypeToItemIds;

	private HashSet<uint> m_BundleClothesSetItemIds;

	public Dictionary<uint, string> m_DictVaultItemTypeToName;

	private uint m_CurrentFilterWeaponProficiencyType;

	private UIPopMenuSmallControler m_WeaponProficiencyPopMenu;

	private UIPopMenuSmallControler m_VaultTypeFilterPopMenu;

	private List<BasicEPInfo> m_AllEpList;

	private List<uint> m_BattleCardTypeList;

	private List<uint> m_BattleCardCSTypeList;

	private List<uint> m_BattleCardCSPeakTypeList;

	private List<RankingPlayerTitleInfo> m_RankBRList;

	private List<RankingPlayerTitleInfo> m_RankCSList;

	private List<WeaponPowerPlayerTitleInfo> m_WeaponPowerBRList;

	private List<WeaponPowerPlayerTitleInfo> m_WeaponPowerCSList;

	private List<GuildWarPlayerTitleInfo> m_ClanWarList;

	private List<CSPeakPlayerTitleInfo> m_PeakCSList;

	private List<PrivilegeIconConfig> m_PrivilegeBadgeList;

	private Vector4 ORIGINAL_SCROLLVIEW_BASECLIP;

	private Vector3 ORIGINAL_SCROLLVIEW_POSITION;

	private const uint POPMENU_HEIGHT = 54u;

	public static float ShowScale;

	public static float ShowScaleWeapon;

	private uint m_DelayCallShowBattleCardGuide;

	private bool m_IsClanInfoGet;

	private bool m_IsClanWarInfoGet;

	private bool m_IsClanHonorRegionGet;

	private bool m_IsClanHonorGlobalGet;

	private bool m_IsClanHonorWarTitleGet;

	private bool m_HasRefreshClanTab;

	private bool m_IsAchievementInfoGet;

	private bool m_IsSeasonStatsInfoGet;

	private bool m_IsCSPeakSeasonStatsInfoGet;

	private GameObject m_CommonLoading;

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

	protected override void OnUIOpenAsChild()
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	private void InitLeftTab()
	{
	}

	private void SelectTab(ProfileCustomTab tab)
	{
	}

	private void OnTabClick(ProfileCustomTab tab)
	{
	}

	private void CheckShowEmptyContainer()
	{
	}

	private void CheckShowClanGotoContainer()
	{
	}

	private void ClearAllPopMenuUI()
	{
	}

	private void RefreshCollectionUI(ProfileCustomTab tab)
	{
	}

	private void InitItemTemplate()
	{
	}

	private void RefreshVaultPopMenu()
	{
	}

	private void GenerateVaultTypeFilterData()
	{
	}

	private void OnVaultTypeClicked(object data)
	{
	}

	private void GetSortedItemList()
	{
	}

	private void RefreshVaultItem()
	{
	}

	private void AddVaultTypeItem(VaultItemType itemVaultType, uint item)
	{
	}

	private void FilterSortedItemList()
	{
	}

	private ProfileCustomModuleData CreateVaultModule(uint item)
	{
		return null;
	}

	private ProfileCustomModuleData CreateLoadingCardModule(uint item)
	{
		return null;
	}

	private void AddVaultItemToTable()
	{
	}

	private int CompareByQualityAndId(uint a, uint b)
	{
		return 0;
	}

	private void RefreshWeaponSkinPopMenu()
	{
	}

	private void GenerateWeaponTypeFilterData()
	{
	}

	private void ConductFilterByWeaponType(object data)
	{
	}

	private void GetSortedWeaponSkinItemList()
	{
	}

	private void RefreshWeaponSkinItem()
	{
	}

	private void AddItemsToPokedexTable(List<WeaponSkinBaseInfo> list)
	{
	}

	private void RequestAchievementInfo()
	{
	}

	public void RefreshAchievementTab()
	{
	}

	public void RefreshAchievementItem()
	{
	}

	private void RefreshAchievementPointItem()
	{
	}

	private int CompareByQualityAndId(WeaponSkinBaseInfo a, WeaponSkinBaseInfo b)
	{
		return 0;
	}

	private void RefreshTitleItem()
	{
	}

	private void RequestLeaderBoardItem()
	{
	}

	private void RefreshLeaderBoardItem()
	{
	}

	private void RefreshWeaponProficiencyPopMenu()
	{
	}

	private void GenerateWeaponProficiencyTypeFilterData()
	{
	}

	private void OnWeaponProficiencyPopMenuSelected(object obj)
	{
	}

	private void RefreshWeaponProficiencyItem()
	{
	}

	private int ComparePickItem(uint weaponIdX, uint weaponIdY)
	{
		return 0;
	}

	private void RefreshInformationTab()
	{
	}

	private void RefreshInformationItem()
	{
	}

	private void RefreshBigEventCollectionItem()
	{
	}

	private ProfileCustomModuleData CreateMyBPModule()
	{
		return null;
	}

	private void RefreshBPItem()
	{
	}

	private void GetMyBattleCardData(out BattleStatsInfo statsInfo, out BattleStatsInfo statsInfoCS, out BattleStatsInfo statsInfoCSPeak)
	{
		statsInfo = null;
		statsInfoCS = null;
		statsInfoCSPeak = null;
	}

	private void RefreshBattleCardItem()
	{
	}

	private void RefreshPrivilegeItem()
	{
	}

	private ProfileCustomModuleData CreateMySignatureModule()
	{
		return null;
	}

	private void RefreshPersonalSingatureItem()
	{
	}

	private void RefreshCloseFriendItem()
	{
	}

	private void ShowBattleCardGuide()
	{
	}

	public void RefreshSocialMediaItem()
	{
	}

	private void ReorderSocialMediaItems()
	{
	}

	private void RefreshClanItem()
	{
	}

	private void RefreshClanInfoItem()
	{
	}

	private void RefreshClanLeaderBoardItem()
	{
	}

	private void RefreshClanGloryItem()
	{
	}

	private void HideInvalidClanWarTitle()
	{
	}

	private void RefreshClanTab()
	{
	}

	private void OnClanHonorLeaderBoardUpdate(object[] data)
	{
	}

	private void OnClanGotoButtonClick()
	{
	}

	public void ShowCancelDragArea(bool show)
	{
	}

	public void RefreshCancelAreaBounds(Transform relativeTrans)
	{
	}

	public bool InCancelArea(Bounds b)
	{
		return false;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void ShowLoading(bool show)
	{
	}

	public bool AutoFillData_Left(ref List<ProfileCustomModuleData> dataList)
	{
		return false;
	}

	public bool AutoFillData_Right(ref List<ProfileCustomModuleData> dataList)
	{
		return false;
	}

	private List<uint> RandomGetTopQualityItems(int count)
	{
		return null;
	}

	private List<WeaponSkinBaseInfo> RandomGetTopQualityWeaponSkins(int count)
	{
		return null;
	}

	private bool AutoFill_VaultModulePosition(ProfileCustomModuleData module, int index)
	{
		return false;
	}

	private bool AutoFill_WeaponSkinModulePosition(ProfileCustomModuleData module, int index)
	{
		return false;
	}

	private void DoShuffle(List<uint> list)
	{
	}

	private void DoShuffle(List<WeaponSkinBaseInfo> list)
	{
	}

	private int _003CRefreshWeaponProficiencyItem_003Eb__105_0(uint x, uint y)
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpenAsChild()
	{
	}
}
