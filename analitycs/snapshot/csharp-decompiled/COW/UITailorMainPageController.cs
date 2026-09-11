using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UITailorMainPageController : UIPreviewNavigationController, IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<TailorUnlockDesc> _003C_003E9__46_0;

		public static Predicate<TailorItemInfo> _003C_003E9__62_0;

		internal int _003COnNavigationShowed_003Eb__46_0(TailorUnlockDesc x, TailorUnlockDesc y)
		{
			return 0;
		}

		internal bool _003CRefreshAvatar_003Eb__62_0(TailorItemInfo c)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass102_0
	{
		public uint itemID;

		internal bool _003CFindTailorItemInfoInTailorClothDict_003Eb__0(TailorItemInfo i)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass67_0
	{
		public uint tokenItemID;

		public uint generalTokenId;

		internal void _003CRefreshTopToken_003Eb__0()
		{
		}

		internal void _003CRefreshTopToken_003Eb__1()
		{
		}

		internal void _003CRefreshTopToken_003Eb__2()
		{
		}
	}

	private uint m_TailorID;

	private TailorSettingDesc m_TailorSettingDesc;

	private List<TailorUnlockDesc> m_TailorUnlockDesc;

	private ETailorState m_TailorState;

	private ETailorClothUnlockType m_TailorClothUnlockType;

	private List<TailorItemInfo> m_TailorBundleList;

	private List<TailorItemInfo> m_TailorCollectionItems;

	private List<TailorItemInfo> m_TailorSpecialEffectsItems;

	private Dictionary<byte, TailorClothInfo> m_TailorClothDict;

	private Dictionary<byte, UIGrid> m_TailorSingleClothGridDict;

	private Dictionary<byte, UIGrid> m_TailorBundleClothGridDict;

	private UIModelTailor m_ModelTailor;

	private UITailorMainPageView m_View;

	private TailorLockBar m_CollectionLockBar;

	private TailorLockBar m_SpecialEffectLockBar;

	private TailorLockBar m_ClothLockBarOutScrollView;

	private TailorLockBar m_CollectionBarOutScollView;

	private TailorLockBar m_SpecialEffectBarOutScorllView;

	private float m_PanelBottomPoint;

	private bool m_DisplayAll;

	private TailorItemInfo m_SelectItemInfo;

	private TailorUnlockDesc m_BaseSetUnlockDesc;

	private UIModelInventory m_ModelInventory;

	private List<UITailorItemController> m_TailorBundleItemList;

	private Dictionary<byte, List<UITailorItemController>> m_TailorSingleClothItemDict;

	private List<UITailorItemController> m_TailorCollectionItemList;

	private List<UITailorItemController> m_TailorSpecialEffectItemList;

	private UIModelMall m_ModelMall;

	private UINavigationData m_LastNavigationData;

	private Dictionary<byte, TailorSlot> m_TailorSlotObjDict;

	private UIEvoGunTokenChangeSecondConfirm m_TokenChangeSecondConfirmCtrl;

	private bool m_GenderMatch;

	private uint m_PreviewAvatarID;

	private Dictionary<byte, List<UITailorClothItemController>> m_TailorBundleClothItemList;

	private const string TOKENFORMAT = "{0}/{1}";

	private const string TOKENNOTENOUGHFORMAT = "[FF0000]{0}[-]/{1}";

	private bool m_UnlockPopupWindowFinish;

	private RewardWndCfg m_RewardWndCfg;

	private bool m_UnlockTcpNotify;

	private ETailorUnlockTokenType m_UnlockTokenState;

	private UICountDownController m_TailorCountCtrl;

	private UICountDownController m_NormalTailorCountCtrl;

	protected override void OnUIInit()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override FrontendPreviewType GetPreviewUIType()
	{
		return FrontendPreviewType.Lobby;
	}

	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	public override void OnNavigationClosed()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void InitDict()
	{
	}

	private void ClearData()
	{
	}

	private void ProcessData()
	{
	}

	private void ProcessSingleClothesData(TailorUnlockDesc desc)
	{
	}

	private void ProcessSetClothesData(TailorUnlockDesc desc)
	{
	}

	private void AddTailorClothItemInfoToList(uint ID, TailorUnlockDesc desc, bool isPlaceHolder, List<TailorItemInfo> list, TailorItemInfo.ETailorItemType itemType)
	{
	}

	private void RefreshView(bool refreshAvatar = true, bool refreshSlot = false, bool hideItemHighLightState = false, bool refreshStateUI = true)
	{
	}

	private void RefreshViewByNotify(bool refreshAvatar = false, bool refreshSlot = true)
	{
	}

	private void RefreshStateUI()
	{
	}

	private void RefreshItemList(bool hideItemHighLightState = false)
	{
	}

	private void RefreshTailorItemByCache(List<TailorItemInfo> dataList, List<UITailorItemController> itemList, UIGrid grid, bool hideItemHighLightState = false)
	{
	}

	private void RefreshClothesContainerActive(bool isBundle)
	{
	}

	private bool ClothObjCanShow(byte wardrobeType, bool isBundle)
	{
		return false;
	}

	private void RefreshAvatar()
	{
	}

	private void CopyBundleClothToPreviewDict(Dictionary<byte, TailorItemInfo> bundleClothDict)
	{
	}

	private void AddPreviewClothesInfo(byte type, TailorItemInfo info)
	{
	}

	private void RefreshSlot(List<byte> refreshSlotList = null)
	{
	}

	private bool LobbyAvatarGenderMatch(CSSharedAvatarData avatarData, TailorPreviewData previewData)
	{
		return false;
	}

	private void RefreshTopToken()
	{
	}

	private void RefreshTokenBoxEntrance()
	{
	}

	private void OnBtnExchangeRemainToken()
	{
	}

	protected override void OnHelpButtonClick(object[] param)
	{
	}

	private void OnLockBarClick(object[] data)
	{
	}

	private void DisplayBundleClothList(bool disPlayAll)
	{
	}

	private void RefreshBundleClothItem()
	{
	}

	private void OnTailorItemClick(object[] data)
	{
	}

	private void RefreshSlotsState()
	{
	}

	private void OnDisplayAllClick(object[] data)
	{
	}

	private void OnExchangeCurrencyBtnClick(object[] data)
	{
	}

	private void OnTailorLockClothSelect(object[] data)
	{
	}

	private void OnCommonRewardWndClose(object[] data)
	{
	}

	private void OnTailorTokenBoxOpen(object[] data)
	{
	}

	private void RefreshObtainInfo()
	{
	}

	private void RefreshUnlockInfo(bool needRefreshActive = true)
	{
	}

	private void RefreshConditionUnlockInfo()
	{
	}

	private void RefreshGemUnlockInfo(bool needRefreshActive = true)
	{
	}

	private void RefreshEquipBtn()
	{
	}

	private void HideAllStateUI()
	{
	}

	private void TryShowUnlockEffect()
	{
	}

	private void OnObtainBtnClick()
	{
	}

	private void OnToEquipBtnClick()
	{
	}

	private void OnUnlockBtnClick()
	{
	}

	private void OnGemUnlockBtnClick()
	{
	}

	private void ShowBundleUnlockWndWitchGems(TailorItemInfo tailorItemInfo, bool isBundleCloth = false)
	{
	}

	private void OnTokenBoxBtnClick()
	{
	}

	private void ShowBundleUnlockWnd(TailorItemInfo tailorItemInfo, bool isBundleCloth = false)
	{
	}

	private void OnConditionUnlockBtnClick()
	{
	}

	private void OnEquipBtnClick()
	{
	}

	private void OnCantEquipClick()
	{
	}

	private void RequestEquipPreviewCloth()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void Update()
	{
	}

	private TailorItemInfo FindTailorItemInfoInTailorClothDict(byte type, uint itemID)
	{
		return null;
	}

	private void _003CRefreshUnlockInfo_003Eb__82_0()
	{
	}

	private void _003CRefreshGemUnlockInfo_003Eb__84_0()
	{
	}

	private void _003CRequestEquipPreviewCloth_003Eb__98_0()
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

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnHelpButtonClick(object[] P0)
	{
	}
}
