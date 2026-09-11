using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIFrontEndPreviewController : UIBaseController, IEasyList, IUIModelDataChangeObserver
{
	public enum ProbabilityStyleType
	{
		None,
		Default,
		TopRight
	}

	public enum SwitchType
	{
		Gun,
		Person
	}

	public enum BackpackSwithType
	{
		Backpack,
		Person
	}

	public enum PropertyType
	{
		None,
		Pve,
		Pvp,
		VehicleSkin
	}

	public enum SkillTipsType
	{
		IconOnly,
		Detail
	}

	private sealed class _003C_003Ec__DisplayClass207_0
	{
		public Animation animation;

		public string clipName;

		internal bool _003CWaitForAnimationComplete_003Eb__0()
		{
			return false;
		}

		internal bool _003CWaitForAnimationComplete_003Eb__1()
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass227_0
	{
		public UIFrontEndPreviewController _003C_003E4__this;

		public WeaponSkinData lData;

		public bool needCombine;

		public bool showNotify;

		internal void _003CShowKillNotifyDelay_003Eb__0()
		{
		}
	}

	private sealed class _003CHideWishListBubbleAfterDelay_003Ed__208 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public UIFrontEndPreviewController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CHideWishListBubbleAfterDelay_003Ed__208(int _003C_003E1__state)
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

	private sealed class _003CShowKillNotifyDelay_003Ed__227 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIFrontEndPreviewController _003C_003E4__this;

		public WeaponSkinData lData;

		public bool needCombine;

		public bool showNotify;

		private _003C_003Ec__DisplayClass227_0 _003C_003E8__1;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CShowKillNotifyDelay_003Ed__227(int _003C_003E1__state)
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

	private sealed class _003CWaitForAnimationComplete_003Ed__207 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Animation animation;

		public string clipName;

		private _003C_003Ec__DisplayClass207_0 _003C_003E8__1;

		public Action onComplete;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CWaitForAnimationComplete_003Ed__207(int _003C_003E1__state)
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

	public const uint ITEMCLOTHFEMALEMIN = 203000578u;

	public const uint ITEMCLOTHFEMALEMAX = 203999999u;

	public const uint ITEMCLOTHMALEMIN = 211000343u;

	public const uint ITEMCLOTHMALEMAX = 211999999u;

	private const string DEFAULTWEBSHOWSPRITENAME = "UI_Icon_PreviewWebview";

	private Dictionary<uint, uint> m_PreviewTypeToClickType;

	private FrontEndPreviewComponent m_FrontEndPreviewComponent;

	private FrontEndPreviewUIConfigData m_FrontEndPreviewUIConfigData;

	private FrontEndPreviewConfigData m_FrontEndPreviewConfigData;

	private List<UIFrontEndPreviewUIComponentBaseController> m_UIFrontEndPreviewUIComponentBaseControllers;

	private UIFrontEndPreviewItemDescBaseController m_UIFrontEndPreviewItemDescBaseController;

	private UIFrontEndPreviewBundlePreviewBaseController m_UIFrontEndPreviewBundlePreviewBaseController;

	private UIFrontEndPreviewWeaponPropertyPanelBaseController m_UIFrontEndPreviewWeaponPropertyPanelBaseController;

	private UIFrontEndPreviewVehicleSkinScorePropertyPanelBaseController m_UIFrontEndPreviewVehicleSkinPropertyPanelBaseController;

	private UIFrontEndPreviewWeaponSkinUpgradeBaseController m_UIFrontEndPreviewWeaponSkinUpgradeBaseController;

	private UIFrontEndPreviewAvatarTransformLevelController m_UIFrontEndPreviewAvatarTransformBaseController;

	private UIFrontEndPreviewWeaponChangeSkinController m_UIFrontEndPreviewWeaponChangeSkinBaseController;

	private UIFrontEndPreviewBackpackLevelBaseController m_UIFrontEndPreviewBackpackLevelBaseController;

	private UIFrontEndPreviewHairStyleLevelBaseController m_UIFrontEndPreviewHairStyleLevelBaseController;

	private FrontEndPreviewDetailSkillInfoPanelBaseController m_UIFrontEndPreviewDetailSkillInfoPanelBaseController;

	private UIFrontEndPreviewWeaponProgressBarBaseController m_UIFrontEndPreviewWeaponProgressBarBaseController;

	private UIFrontEndPreviewTailorClothUpgradeBaseController m_UIFrontEndPreviewTailorClothUpgradeController;

	private UIFrontEndPreviewVirtualBrandLinkBaseController m_UIFrontEndPreviewVirtualBrandLinkController;

	private UIFrontEndPreviewEvoAccessBaseController m_UIFrontEndPreviewEvoAccessController;

	private UIFrontEndPreviewSpecialBundleLinkBaseController m_UIFrontEndPreviewSpecialBundleLinkController;

	private UIFrontEndPreviewOrangePlusWeaponBubbleBaseController m_UIFrontEndPreviewOrangePlusWeaponBubbleBaseController;

	private UIFrontEndPreviewPrivilegeEffectBaseController m_UIFrontEndPreviewPrivilegeEffectBaseController;

	private UIFrontEndPreviewAvatarProfileLinkBaseController m_UIFrontEndPreviewAvatarLinkController;

	private int? m_QuickMessageLinkPanelDepth;

	private UIFrontEndPreviewQuickMessageLinkBaseController m_UIFrontEndPreviewQuickMessageLinkController;

	private UIFrontEndPreviewSkillEffectsBaseController m_UIFrontEndPreviewSkillEffectsController;

	private UIFrontEndPreviewPrivilegeCarouselBaseController m_UIFrontEndPreviewPrivilegeCarouselController;

	private UIFrontEndPreviewLaunchTagBaseController m_UIFrontEndPreviewLaunchTagController;

	private UIFrontendpreviewCollectionCustomBaseController m_UIFrontEndPreviewCollectionCustomController;

	private UIFrontEndPreviewCollectionOnTrialBaseController m_UIFrontEndPreviewCollectionOnTrialController;

	private UIFrontEndPreviewBooyahPassPreviewBaseController m_UIFrontEndPreviewBooyahPassPreviewController;

	private UIModelPreviewWebShow m_ModelPreviewWebShow;

	private PropertyType m_PropertyType;

	private UIFrontEndPreviewView m_View;

	private UIClickMask m_ClickMask;

	private uint m_CurrentItemID;

	private uint m_ShowItemID;

	private FrontendPreviewType m_UiType;

	private string m_WishListSource;

	private int m_PanelWidth;

	private bool _003CIsShowOwned_003Ek__BackingField;

	private UIRoot m_UIRoot;

	private SwitchType m_Swithtype;

	private BackpackSwithType m_BackSwithType;

	private float _003CModelPosX_003Ek__BackingField;

	private float _003CModelPosY_003Ek__BackingField;

	private bool _003CMagnifierState_003Ek__BackingField;

	private bool _003CClothEffectShowState_003Ek__BackingField;

	private const float m_RotateRate = 0.5f;

	private Coroutine m_Cor;

	private UIWeaponKillNotificationItemController m_KillNotification;

	private GameObject m_HiddenVFX;

	private uint m_WeaponScoreOpen;

	private const uint AVATARNAMECOLOR = 4290380031u;

	private UIModelMall m_ModelMall;

	private UIModelVirtualBrand m_ModedlVirtualBrand;

	private UIModelWishList m_ModelWishList;

	private UIModelInventory m_ModelInventory;

	private UIModelHyperBook m_ModelHyperBook;

	private UIModelGoPos m_ModelGoPos;

	private UIModelEvoPass m_ModelEvoPass;

	private UIModelIPCollab m_ModelIPCollab;

	private UIModelCollectionCustom m_ModelCollectionCustom;

	private UIModelUser m_ModelUser;

	private bool m_SkillEffectIPCollabHandled;

	private bool m_TreasureBoxOpenState;

	private uint m_TreasureBoxID;

	private uint m_InGameBonusID;

	private bool m_CollectionBag;

	private bool m_RefreshBundleTab;

	private ItemStateInWishList m_WishListNodeState;

	private string m_CurrentItemName;

	private Dictionary<int, Transform> m_AnchorToParentDic;

	private uint m_DelayShowKillNotify;

	private UIHUDFeedbackItemBaseController m_KillNotifyCtrl;

	private Coroutine m_ShowKillNotifyDelayCor;

	private Vector3 m_OriginalIconGridPos;

	private Action m_ShareAction;

	private Coroutine m_WishListBubbleHideCoroutine;

	private UIFrontEndPreviewItemDescBaseController UIFrontEndPreviewItemDescBaseController => null;

	private UIFrontEndPreviewBundlePreviewBaseController UIFrontEndPreviewBundlePreviewBaseController => null;

	private UIFrontEndPreviewWeaponPropertyPanelBaseController UIFrontEndPreviewWeaponPropertyPanelBaseController => null;

	private UIFrontEndPreviewVehicleSkinScorePropertyPanelBaseController UIFrontEndPreviewVehicleSkinPropertyPanelBaseController => null;

	private UIFrontEndPreviewWeaponSkinUpgradeBaseController UIFrontEndPreviewWeaponSkinUpgradeBaseController => null;

	private UIFrontEndPreviewAvatarTransformLevelController UIFrontEndPreviewAvatarTransformBaseController => null;

	private UIFrontEndPreviewWeaponChangeSkinController UIFrontEndPreviewWeaponChangeSkinBaseController => null;

	private UIFrontEndPreviewBackpackLevelBaseController UIFrontEndPreviewBackpackLevelBaseController => null;

	private UIFrontEndPreviewHairStyleLevelBaseController UIFrontEndPreviewHairStyleLevelBaseController => null;

	private FrontEndPreviewDetailSkillInfoPanelBaseController UIFrontEndPreviewDetailSkillInfoPanelBaseController => null;

	private UIFrontEndPreviewWeaponProgressBarBaseController UIFrontEndPreviewWeaponProgressBarBaseController => null;

	private UIFrontEndPreviewTailorClothUpgradeBaseController UIFrontEndPreviewTailorClothUpgradeController => null;

	private UIFrontEndPreviewVirtualBrandLinkBaseController UIFrontEndPreviewVirtualBrandLinkController => null;

	private UIFrontEndPreviewEvoAccessBaseController UIFrontEndPreviewEvoAccessController => null;

	private UIFrontEndPreviewSpecialBundleLinkBaseController UIFrontEndPreviewSpecialBundleLinkController => null;

	private UIFrontEndPreviewOrangePlusWeaponBubbleBaseController UIFrontEndPreviewOrangePlusWeaponBubbleController => null;

	private UIFrontEndPreviewPrivilegeEffectBaseController UIFrontEndPreviewPrivilegeEffectBaseController => null;

	private UIFrontEndPreviewAvatarProfileLinkBaseController UIFrontEndPreviewAvatarLinkController => null;

	private UIFrontEndPreviewQuickMessageLinkBaseController UIFrontEndPreviewQuickMessageLinkController => null;

	private UIFrontEndPreviewSkillEffectsBaseController UIFrontendPreviewSkillEffectsController => null;

	private UIFrontEndPreviewPrivilegeCarouselBaseController UIFrontEndPreviewPrivilegeCarouselController => null;

	private UIFrontEndPreviewLaunchTagBaseController UIFrontEndPreviewLaunchTagController => null;

	private UIFrontendpreviewCollectionCustomBaseController UIFrontEndPreviewCollectionCustomController => null;

	private UIFrontEndPreviewCollectionOnTrialBaseController UIFrontEndPreviewCollectionOnTrialController => null;

	private UIFrontEndPreviewBooyahPassPreviewBaseController UIFrontEndPreviewBooyahPassPreviewController => null;

	public UIFrontEndPreviewView View => null;

	public uint CurrentItemID
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public uint ShowItemID
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public FrontendPreviewType FrontendPreviewType => FrontendPreviewType.Lobby;

	public bool IsShowOwned
	{
		get
		{
			return _003CIsShowOwned_003Ek__BackingField;
		}
		private set
		{
			_003CIsShowOwned_003Ek__BackingField = value;
		}
	}

	public BackpackSwithType BackSwithType => BackpackSwithType.Backpack;

	public float ModelPosX
	{
		get
		{
			return _003CModelPosX_003Ek__BackingField;
		}
		private set
		{
			_003CModelPosX_003Ek__BackingField = value;
		}
	}

	public float ModelPosY
	{
		get
		{
			return _003CModelPosY_003Ek__BackingField;
		}
		private set
		{
			_003CModelPosY_003Ek__BackingField = value;
		}
	}

	public bool MagnifierState
	{
		get
		{
			return _003CMagnifierState_003Ek__BackingField;
		}
		private set
		{
			_003CMagnifierState_003Ek__BackingField = value;
		}
	}

	public bool ClothEffectShowState
	{
		get
		{
			return _003CClothEffectShowState_003Ek__BackingField;
		}
		private set
		{
			_003CClothEffectShowState_003Ek__BackingField = value;
		}
	}

	private UIWeaponKillNotificationItemController KillNotification => null;

	private bool HasWeaponChangeSkinDataForCurrentItem()
	{
		return false;
	}

	public void SetQuickMessageLinkPanelDepth(int depth)
	{
	}

	public Transform GetKillNotifyContainer()
	{
		return null;
	}

	public Transform GetAnnouncementContainer()
	{
		return null;
	}

	public object GetAnnouncementCtrl()
	{
		return null;
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void InitView()
	{
	}

	public void SetShowUIContainerVisible(bool visible)
	{
	}

	public void SetUIType(FrontendPreviewType eFrontendUIType, FrontEndPreviewComponent frontEndPreviewComponent)
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void CloseItemDesc()
	{
	}

	private void OnTreasureBoxProbabilityClick()
	{
	}

	private void OnInGameBonusProbabilityClick()
	{
	}

	public void SetTreasureBoxID(uint id)
	{
	}

	public void SetInGameBonusID(uint itemId)
	{
	}

	public void ShowIPTag()
	{
	}

	public void ShowIPTag(uint id)
	{
	}

	public void HideEffectClothIcon()
	{
	}

	public void ShowEffectClothIcon()
	{
	}

	private void ShowTreasureBoxProbabilityTips(CSGetTreasureBoxPRRes probability)
	{
	}

	private void ShowInGameBonusProbabilityTips(CSGetInGameBonusPRRes probability)
	{
	}

	public void ClearCoroutineAndDelayCall()
	{
	}

	public void SetBackpackSwitchVisible(bool flag)
	{
	}

	public void ClearBackpck()
	{
	}

	private void OnupdateScrollview(object[] data)
	{
	}

	private void OnWeaponSkinTimelineRefresh(object[] data)
	{
	}

	public void OnHyperBookHiddenPageDescUpdate(object[] data)
	{
	}

	private void OnWeaponSkinAnimFinish(object[] data)
	{
	}

	public void SetWeaponSkinUpgradeLevel(bool isMaxLv)
	{
	}

	private void OnBtnZoomClick()
	{
	}

	private void OnPlayBtnClick()
	{
	}

	public void OnWishListNodeClick()
	{
	}

	public void SetWishListSource(string source)
	{
	}

	private string GetWishListSource()
	{
		return null;
	}

	private void OnGotoWishListBubbleClick()
	{
	}

	private void ShowWishListBubble()
	{
	}

	private void HideWishListBubbleUIFX()
	{
	}

	private void PlayUIFXAnimation(bool isShow, Action onComplete = null)
	{
	}

	private IEnumerator WaitForAnimationComplete(Animation animation, string clipName, Action onComplete)
	{
		return null;
	}

	private IEnumerator HideWishListBubbleAfterDelay(float delay)
	{
		return null;
	}

	private void StopWishListBubbleHideCoroutine()
	{
	}

	private void HideWishListBubbleImmediately()
	{
	}

	private void OnNewBieSimilarItemGotoBtnClick()
	{
	}

	private void OnChangeBattleCardUIStateBtnClick()
	{
	}

	public bool CheckAbReadyWhenClick()
	{
		return false;
	}

	private void OnBtnZoomWithCamera()
	{
	}

	private void OnBtnMagnifierClick()
	{
	}

	public void ExternalClickBtnMagnifier()
	{
	}

	private void OnClothEffectBtnClick()
	{
	}

	public void SetMagnifierState(bool zoom)
	{
	}

	public void ForceSetMagniferStateAndCameraMove(bool state)
	{
	}

	public void SetClothEffectShowState(bool show)
	{
	}

	public void ShowBackpackWithAvatar()
	{
	}

	private void OnbackpckBtnSwitchClick()
	{
	}

	private void OnBtnSwitchClick()
	{
	}

	public void RefreshNotificationState()
	{
	}

	public void TryShowShowKillNotifyAfterCgShow(bool needSkipKillNotify = false)
	{
	}

	public void ShowKillNotify(bool showNotify, bool needCombine = false, bool NeedSkipKillNotify = false)
	{
	}

	private IEnumerator ShowKillNotifyDelay(WeaponSkinData lData, bool showNotify, bool needCombine = false)
	{
		return null;
	}

	public void OnBtnNotificationClick()
	{
	}

	public void ClickDefaultAvatarTransform()
	{
	}

	public void ClickPreviewWeaponChangeSkin()
	{
	}

	public void ClickDefaultBackPack()
	{
	}

	public void ClickDefaultHairStyle(bool forceCreate = false)
	{
	}

	public void ClickDefaultEpicClothStyle()
	{
	}

	public bool ProcessHairStyleWhenOptionalDownloadNotify()
	{
		return false;
	}

	public void SetCommonPanel(UIWidget previewBorder)
	{
	}

	public void SetCollecionBag(bool flag)
	{
	}

	public void InitTreaboxOpenState()
	{
	}

	public void RefreshTreasureBox()
	{
	}

	public void SetTreasureBoxProbabilityState(bool show)
	{
	}

	public void SetSpecialData(string name, string desc, bool flag)
	{
	}

	public void RefreshAvatarTransformLevelUI()
	{
	}

	public void RefreshWeaponChangeSkinUI()
	{
	}

	public void RefreshBackPackLevelUI()
	{
	}

	public bool RefreshAvatarTransformLevel(int index)
	{
		return false;
	}

	public bool RefreshBackPackLevel(ECollectionLevel level)
	{
		return false;
	}

	public void CloseUIExceptMagn()
	{
	}

	public void SetRightIconGridHide()
	{
	}

	public void CloseAllUI()
	{
	}

	public void SetItemData(uint id)
	{
	}

	public void SetNewQuaityIcon(uint id)
	{
	}

	public void SetNewQuaitySpIcon(EInventory.AwardType type)
	{
	}

	public void SetNewQuaitySpIcon(ESpecialItemWithoutDataType type)
	{
	}

	public void RefreshBundlePreviewTab(List<BaseItemInfo> list, CSSharedItemDataManager.ItemType type, bool showbundleTitle, bool isOwned, bool showPreviewScrollView = true, bool isHideBundleTips = false, uint clothesSetID = 0u)
	{
	}

	public void SetRefreshBundleFlag(bool flag)
	{
	}

	public void RefreshCratePreviewTab(List<BaseItemInfo> list)
	{
	}

	public void ReRearrangePreviewTab()
	{
	}

	public void SetOriginal()
	{
	}

	public void ResetUI()
	{
	}

	private void OnPvpToggleClick()
	{
	}

	private void OnPveToggleClick()
	{
	}

	private void ShowPropertyContainer(bool isVisible, PropertyType pType)
	{
	}

	private void ShowPropertyLeftContainer(bool isVisible, PropertyType pType)
	{
	}

	public Vector2 GetItemDescWorldPos()
	{
		return default(Vector2);
	}

	public float GetBoostCameraPosX()
	{
		return 0f;
	}

	public void DisVisbleIconTableInfo()
	{
	}

	public void RefreshItemDesc(uint itemid)
	{
	}

	public void RefreshItemView()
	{
	}

	public void RefreshPrivilegeContainerForTailorUpgrade(uint previewItemID)
	{
	}

	public void SetItemDesc(string name, string description)
	{
	}

	public void DisplayWeaponPropertyScore(bool show)
	{
	}

	public void RefreshWeaponPropertyScore(uint itemid)
	{
	}

	public void HideIPTag()
	{
	}

	public void RefreshVirtualBrandBtn(uint itemID, bool show)
	{
	}

	public void RefreshEmotePrivilegeIcon(bool show)
	{
	}

	public void RefreshVehicleSkinPropertyScore(uint itemid)
	{
	}

	public void SetPropertyContainerVisible(bool isVisible)
	{
	}

	public bool SetWeaponPvpPropertyScoreVisble(bool isVisible)
	{
		return false;
	}

	public void SetWeaponSkinUpgradeLevelVisble(bool isVisible)
	{
	}

	public void SetLegendClothPrivilegeCarouselVisible(bool isVisible)
	{
	}

	public void SetTailorClothUpgradeLevelVisble(bool isVisble)
	{
	}

	public void SetTailorClothTagVisible(bool isVisble)
	{
	}

	public void SetTokenExchangeVisible(bool isVisble)
	{
	}

	public void SetHyperBookVisible(bool isVisble)
	{
	}

	public void SetSkillEffectsChangeBtnVisble(bool isVisble)
	{
	}

	public void SetBooyahPassPreviewVisible(bool isVisble)
	{
	}

	public void SetBooyahPassLinkVisible(bool isVisble)
	{
	}

	public void SetIPCollabVisible(bool isVisble)
	{
	}

	public void SetTailorUpgradeLevel(bool isRecommend)
	{
	}

	public void SetBackPackLevelVisble(bool isVisble)
	{
	}

	public void SetHairStyleLevelVisble(bool isVisble)
	{
	}

	public void SetEpicClothStyleIconVisble(bool isVisble)
	{
	}

	public void SetMagnifierBtnVisble(bool isVisble)
	{
	}

	public void SetClothEffectTriggerBtnVisble(bool isVisble)
	{
	}

	public void SetVerticalPreviewBtnVisble(bool isVisble, uint itemID, BackpackSwithType backpackSwithType)
	{
	}

	public void SetSkillVisble(bool isVisble)
	{
	}

	public void SetAlignmentVisble(bool show)
	{
	}

	public void SetLaunchTagVisble(bool show)
	{
	}

	public void RefreshLaunchTag(uint itemID)
	{
	}

	private void RefreshViewData<DataType>(List<DataType> dataList, bool needResort = true, uint clothesSetID = 0u)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public void SetSwithBtnVisble(bool need_show, SwitchType type = SwitchType.Gun)
	{
	}

	public void SetNotificationBtnVisble(bool need_show, bool needCombine = false)
	{
	}

	public void SetKillNotifyContainerVisble(bool show)
	{
	}

	public void HideWeaponAnnouncement()
	{
	}

	public void HideKillNotifyCtrl()
	{
	}

	public void SetShowIconVisble(bool need_show)
	{
	}

	public void SetWeaponSkinUpgradeInfoIconVisble(bool need_show)
	{
	}

	public void RefreshPrivilegeGridVisble(bool isVisable)
	{
	}

	public void ShowAvatarSkill(uint avatarID)
	{
	}

	public void ShowAvatarAlignment(uint avatarID)
	{
	}

	public void ShowPetSkill(uint petid)
	{
	}

	public void SetOptionalDownloadShow(bool show, DownloadInfoSpecific downloadInfo = null, bool isAvatar = false)
	{
	}

	public void OnRecoverPreview()
	{
	}

	public void RefreshWeaponProgressBar(BaseItemInfo itemInfo)
	{
	}

	private void SwitchChange(SwitchType type)
	{
	}

	public void SetWeaponProgressBarVisible(bool isVisible)
	{
	}

	public void SetBattleCardClearUIBtnVisible(bool isVisible)
	{
	}

	public void ResetBackpackSwitch()
	{
	}

	private void BackPackSwitchChange(BackpackSwithType type, bool show)
	{
	}

	public void SetTweenEnabled(bool enabled)
	{
	}

	public void SetWishListNodeVisible(bool isVisible)
	{
	}

	public void SetShareBtnVisible(bool isVisible, Action shareAction = null)
	{
	}

	public void OnShareBtnClick()
	{
	}

	private void RequestWishValue()
	{
	}

	public void RefreshWishListNodeByCurrentItem()
	{
	}

	private void SendWishListChangeToToBackend()
	{
	}

	public void SetZoomBtnVisible(bool showzoomspr, bool showplayspr = true, bool ForceOverwrite = false)
	{
	}

	public void SetPlayBtnVisible(bool isShow, bool isFlight = false)
	{
	}

	private void RefreshZoomBtnSpriteByCurrentItem()
	{
	}

	public void SetZoomWithCameraBtnVisible(bool isShow, string spriteName = "")
	{
	}

	public FrontEndPreviewUIConfigData GetUIConfigData()
	{
		return null;
	}

	public void ShowWebGuideBtn(uint id)
	{
	}

	private void OnWebGuideBtnClick()
	{
	}

	private void OnVerticalPreviewBtnClicked()
	{
	}

	public void SetPrivilegeEffectBtnVisible(bool visible)
	{
	}

	private uint GetTailorEffectivePrivilegeItemID(uint id)
	{
		return 0u;
	}

	public void RefreshPrivilegeEffectBtn(uint itemId)
	{
	}

	public void RefreshLegendClothPrivilegeCarousel(uint itemId, int itemType)
	{
	}

	public bool IsNeedVerticalPreviewBtn(uint itemId, BackpackSwithType backpackSwithType)
	{
		return false;
	}

	public void SetWebGuideBtnShow(bool show)
	{
	}

	public void SetAvatarSkillInfoPanelShow(bool show)
	{
	}

	public bool GetTailorUpgradeLevelRecommandSelectState()
	{
		return false;
	}

	public void RefreshVirtualBrandLink(uint id)
	{
	}

	public void RefreshEvoPass(uint id)
	{
	}

	public void RefreshSpecialBundleLink(uint id)
	{
	}

	public void RefreshCustomBtn(uint id)
	{
	}

	public void RefreshTrialBtn(uint id)
	{
	}

	public void SetBrandLinkClickCallback(Action func)
	{
	}

	private bool CheckVirtualBrandNeedMoveUp(uint id, uint checkCondition)
	{
		return false;
	}

	public void HideItemDesc()
	{
	}

	public void HideWeaponProperty()
	{
	}

	public void ShowItemDesc()
	{
	}

	public void ShowWeaponProperty()
	{
	}

	public void SetShowBackpackLevel()
	{
	}

	public void SetHideBackpackLevel()
	{
	}

	public uint GetBackpackSelectLevel()
	{
		return 0u;
	}

	public void SetVirtualBrandLinkVisible(bool visible)
	{
	}

	public void SetEvoPassVisible(bool visible)
	{
	}

	public void SetSpecialBundleLinkVisible(bool visible)
	{
	}

	public void SetQuickMessageLinkVisible(bool visible)
	{
	}

	public void RefreshQuickMessageLink(uint itemId)
	{
	}

	private void SetIconGridOriginalPos(Vector3 pos)
	{
	}

	public void RefreshUIWhenWeaponPropertyExpand(Vector3 pos)
	{
	}

	public bool CheckIsBackPackCtrlActive()
	{
		return false;
	}

	public bool CheckIsWeaponChangeCtrlActive()
	{
		return false;
	}

	public bool CheckIsAvatarTransformLevelCtrlActive()
	{
		return false;
	}

	public bool CheckIsSkillEffectCtrlActive()
	{
		return false;
	}

	public void OnBooyahPassPreviewSmallItemClick()
	{
	}

	public UIFrontEndPreviewItemDescBaseController GetPreviewItemDescBaseController()
	{
		return null;
	}

	public virtual bool IsCurrentUIPopWnd()
	{
		return false;
	}

	public UIFrontEndPreviewBundlePreviewBaseController GetBundlePreviewBaseController()
	{
		return null;
	}

	public UIFrontEndPreviewWeaponPropertyPanelBaseController GetWeaponPropertyPanelBaseController()
	{
		return null;
	}

	public UIFrontEndPreviewVehicleSkinScorePropertyPanelBaseController GetVehiclePropertyPanelBaseController()
	{
		return null;
	}

	public UIFrontEndPreviewWeaponSkinUpgradeBaseController GetWeaponSkinUpgradeBaseController()
	{
		return null;
	}

	public UIFrontEndPreviewBackpackLevelBaseController GetBackpackLevelBaseController()
	{
		return null;
	}

	public UIFrontEndPreviewHairStyleLevelBaseController GetHairStyleLevelBaseController()
	{
		return null;
	}

	public FrontEndPreviewDetailSkillInfoPanelBaseController GetDetailSkillInfoPanelBaseController()
	{
		return null;
	}

	public UIFrontEndPreviewWeaponProgressBarBaseController GetWeaponProgressBarBaseController()
	{
		return null;
	}

	public UIFrontEndPreviewTailorClothUpgradeBaseController GetTailorClothUpgradeBaseController()
	{
		return null;
	}

	public UIFrontEndPreviewPrivilegeCarouselBaseController GetPrivilegeCarouselController()
	{
		return null;
	}

	public UIFrontEndPreviewVirtualBrandLinkBaseController GetVirtualBrandLinkBaseController()
	{
		return null;
	}

	public UIFrontEndPreviewEvoAccessBaseController GetEvoAccessBaseController()
	{
		return null;
	}

	public UIFrontEndPreviewSpecialBundleLinkBaseController GetSpecialBundleLinkBaseController()
	{
		return null;
	}

	public UIFrontEndPreviewOrangePlusWeaponBubbleBaseController GetOrangePlusWeaponBubbleBaseController()
	{
		return null;
	}

	public UIFrontEndPreviewPrivilegeEffectBaseController GetPrivilegeEffectBaseController()
	{
		return null;
	}

	public UIFrontEndPreviewAvatarProfileLinkBaseController GetAvatarProfileLinkBaseController()
	{
		return null;
	}

	public UIFrontEndPreviewQuickMessageLinkBaseController GetQuickMessageLinkBaseController()
	{
		return null;
	}

	public UIFrontEndPreviewSkillEffectsBaseController GetSkillEffectsBaseController()
	{
		return null;
	}

	public UIFrontEndPreviewLaunchTagBaseController GetLaunchTagBaseController()
	{
		return null;
	}

	public UIFrontendpreviewCollectionCustomBaseController GetCollectionCustomBaseController()
	{
		return null;
	}

	public UIFrontEndPreviewCollectionOnTrialBaseController GetTrialBtnBaseController()
	{
		return null;
	}

	public UIFrontEndPreviewBooyahPassPreviewBaseController GetBooyahPassPreviewBaseController()
	{
		return null;
	}

	public void CreatHiddenPageVFX(uint itemID)
	{
	}

	public void CloseHiddenPageVfxItem()
	{
	}

	public void OnShowPreviewById(CSSharedItemData itemData, BaseItemInfo itemInfo, ECollectionLevel level, List<BaseItemInfo> previewUIList, List<uint> preview3DList, bool isSpecial, bool isShowDescription = true, bool isShowOwned = true, bool showBundleScrollView = true, bool showBundleTitle = true, bool needResetUI = true, bool isHideIPTag = false, bool isHideBundleTips = false, bool skipWeaponAnim = false, bool needSkipKillNotify = false, bool isShowTailorUpgradeLevel = true, uint clothesSetID = 0u)
	{
	}

	public override void Hide()
	{
	}

	public override void Show()
	{
	}

	private void SetCommonDescription(uint id)
	{
	}

	private void ProcessTailorBundleUI(uint id, List<uint> preview3DList, bool isShowTailorUpgradeLevel = true)
	{
	}

	public void Refresh2DPreviewUI(CSSharedItemData itemData)
	{
	}

	private void RefreshHyperBook(uint ItemId)
	{
	}

	private void RefreshIPCollab(uint ItemId)
	{
	}

	private void SetTokenChannelShow(UIModelBigEvent.TokenTipsData data)
	{
	}

	private void RefreshPetUI(CSSharedItemData itemData)
	{
	}

	public void RefreshBoostAvatarUI(uint id, BoostState state)
	{
	}

	private void CheckEvoGunID(uint id, ECollectionLevel level)
	{
	}

	private void RefreshWeaponUI(CSSharedItemData itemData, BaseItemInfo itemInfo, ECollectionLevel level, bool skipWeaponAnim = false, bool needSkipKillNotify = false)
	{
	}

	private void ShowClothStyle(CSSharedItemData itemData)
	{
	}

	private void RefreshJackpotUI(List<uint> preview3DList)
	{
	}

	public void OnShowAvatar(uint avatarID, List<uint> clothList, bool needClearUIData = false, bool needAddLobbyCloth = false, uint selectedClothID = 0u, uint clothEffectItemID = 0u)
	{
	}

	private void RefreshClothEffectUI(uint clothEffectItemID)
	{
	}

	public void OnShowVideo()
	{
	}

	public void OnClosePreview()
	{
	}

	public void ClearCahce(bool clearDesc = false, bool clearSpecialUI = true)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void HideAvatarRotateTouchArea()
	{
	}

	private void _003COnTreasureBoxProbabilityClick_003Eb__179_0()
	{
	}

	private void _003COnInGameBonusProbabilityClick_003Eb__180_0()
	{
	}

	private void _003CHideWishListBubbleUIFX_003Eb__205_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_Hide()
	{
	}

	public void _003C_003EiFixBaseProxy_Show()
	{
	}
}
