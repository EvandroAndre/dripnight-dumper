using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIWeaponSkinLobbyMainController : UINavigationController, IEasyList, IUIModelDataChangeObserver
{
	public enum PreviewType
	{
		Weapon
	}

	public enum PropertyType
	{
		None,
		Pve,
		Pvp
	}

	public enum SwitchType
	{
		Gun,
		Person
	}

	public enum GridListType
	{
		First,
		Second,
		Third
	}

	public enum EBgType
	{
		ResID,
		Url
	}

	public enum LabelType
	{
		Lobby,
		SpecialSound,
		Pve,
		SickleZoom,
		SightReskin
	}

	private enum SoundType
	{
		None,
		PreviewKillSound,
		PreviewSpecialOrNormalSound,
		PreviewSwitchGunSound,
		PreviewInAndOutClipSound
	}

	public enum ECollectionMultiSelectEquipBtnState
	{
		none,
		Equip,
		Unequip,
		EquipedRemainOne
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__133_0;

		public static Comparison<uint> _003C_003E9__166_0;

		public static Comparison<uint> _003C_003E9__183_0;

		public static Comparison<uint> _003C_003E9__266_0;

		public static Comparison<uint> _003C_003E9__294_0;

		public static Predicate<PUint32KeyVal> _003C_003E9__297_0;

		internal void _003CSetHotFixTextShow_003Eb__133_0()
		{
		}

		internal int _003CRefreshToTarget_003Eb__166_0(uint a, uint b)
		{
			return 0;
		}

		internal int _003CGetFirstTabItemSelectIndex_003Eb__183_0(uint a, uint b)
		{
			return 0;
		}

		internal int _003CPrepareFirstGridData_003Eb__266_0(uint a, uint b)
		{
			return 0;
		}

		internal int _003CRefreshToTargetWeaponLabel_003Eb__294_0(uint a, uint b)
		{
			return 0;
		}

		internal bool _003CRefreshChangeWeaponSkinAppearanceBtn_003Eb__297_0(PUint32KeyVal x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass133_0
	{
		public UIWeaponSkinLobbyMainController _003C_003E4__this;

		public CSSharedItemData item_data;

		public List<ResourceID> res_list;

		internal void _003CSetHotFixTextShow_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass201_0
	{
		public UIWeaponSkinLobbyMainController _003C_003E4__this;

		public UIMaleAvatar targetAvatar;

		public WeaponSkinData lData;

		public AFOLPMOCBOG cData;

		internal void _003CSetWeaponSkinToAvatar_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass244_0
	{
		public WeaponSkinData weaponSkinData;

		internal void _003CPlayPreviewInAndOutClipWeaponSound_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass247_0
	{
		public UIWeaponSkinLobbyMainController _003C_003E4__this;

		public WeaponSkinData lData;

		internal void _003CShowKillNotifyAndPlayKillSound_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass248_0
	{
		public uint newSkinId;

		public UIWeaponSkinLobbyMainController _003C_003E4__this;

		internal void _003COnEquipAsPveSkinBtnClick_003Eb__0()
		{
		}
	}

	private sealed class _003CInitDelay_003Ed__182 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIWeaponSkinLobbyMainController _003C_003E4__this;

		private UIWeaponSkinMenuFirstItemController _003Cctrl_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CInitDelay_003Ed__182(int _003C_003E1__state)
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

	private sealed class _003CResetWeapon_003Ed__148 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIWeaponSkinLobbyMainController _003C_003E4__this;

		private Quaternion _003Clerproate_003E5__2;

		private float _003Ctime_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CResetWeapon_003Ed__148(int _003C_003E1__state)
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

	private PropertyType m_PropertyType;

	private CollectionDataManager.ECollectionWeaponType m_WeaponTypeInternal;

	private uint m_WeaponIdInternal;

	private uint m_WeaponIdForKillNotificaton;

	private uint m_WeaponSkinIdInternal;

	private uint m_DelayCallShow;

	private bool m_IsFirstShowed;

	private bool m_IsSightReskinEnabled;

	private WeaponSkinBaseInfo m_WeaponSkinDataInternal;

	private PreviewType m_PreviewType;

	private BoxCollider m_WeaponSkinBtnBoxCollider;

	private Vector3 m_ToggleButtonCenterPos;

	private Vector3 m_WeaponDetailPos1;

	private Vector3 m_WeaponDetailPos2;

	private uint m_TargetWeaponSkinId;

	private const string m_Parenta = "FirstGrid";

	private const string m_Parentb = "SecondGrid";

	private const string m_Parentc = "ThirdGrid";

	private const string m_AutoPlayWeaponSkinAnimOnceEveryday = "AutoPlayWeaponSkinAnimOnceEveryday{0}-{1}";

	private UIModelCollection m_ModelCollection;

	private UIModelRandomCollection m_ModelRandomCollection;

	private UIModelInventory m_ModelInventory;

	private UIModelEvoPass m_ModelEvoPass;

	private UIModelWeaponSkinCustom m_ModelWeaponSkinCustom;

	private UIModelWishList m_ModelWishList;

	private UIModelUser m_ModelUser;

	private UIModelGoPos m_ModelGoPos;

	private UIWeaponSkinLobbyMainView m_View;

	private UIWeaponKillNotificationItemController m_KillNotification;

	private UIWeaponSkillItemController m_skillItem;

	private uint m_WeaponScoreOpen;

	private GameObject m_ItemCameraGo;

	private Camera m_ItemCamera;

	private GameObject m_MixCameraGo;

	private Camera m_MixCamera;

	private GameObject m_ShareCamera;

	private ResourceID m_CurrentWeaponResourceId;

	private GameObject m_PreviewWeaponObj;

	private UIItemInputHandler m_ItemInputHandler;

	private const float m_RotateRate = 0.5f;

	private GameObject m_PreviewShareWeaponObj;

	private uint m_LastClickWpID;

	private bool m_HasClickedFirstType;

	private Vector3 m_PreviewSavePos;

	private Vector3 m_PreviewAvatarSavePos;

	private Quaternion m_PreviewSaveRotation;

	private Vector3 m_PreviewSaveScale;

	private UIFrontEndPreviewWeaponZoomInController m_ZoomInController;

	private UIFrontEndPreviewWeaponProgressBarController m_WeaponProgressBarController;

	private UIWishListBtnController m_WishListBtnController;

	private UIWeaponSkinNewbieRecommendEntryController m_WeaponSkinNewbieEntry;

	private UIMaleAvatar m_PreviewAvatar;

	private SwitchType m_Swithtype;

	private bool m_HasInit;

	private bool m_HasRefreshMainSkin;

	private ItemStateInWishList m_WishListNodeState;

	private uint m_SkinIdToRefresh;

	private bool m_SelectDefault;

	private Quaternion m_StopPos;

	private bool m_NeedRefreshAllWhenNavigationShow;

	public Dictionary<uint, bool> m_DictCollctionTypeToTips;

	public Dictionary<uint, bool> m_DictWeaponIdToTips;

	public Dictionary<uint, bool> m_DictWeaponSkinIdToTips;

	private UIWeaponSkinLobbyMainShareController m_ShareCtrl;

	private UINewDownloadInfoController m_DownloadCtrl;

	private UIEvoGunKillCountController m_EvoGunKillCountCtrl;

	private string m_ItemDescration;

	private UIModelWeaponSkinUpgrader m_ModelWeaponSkinUpgrader;

	private List<UIPrivilegeItemIconController> m_PrivilegeItemIconControllers;

	private UIHudInventoryTagController m_PrivilegeWeaponTagController;

	private GameObject m_WeaponAudio;

	private uint m_DelayHideLabelId;

	private uint m_DelayHidePveSkinLabelId;

	private float m_DelayHideLabelTime;

	private bool m_IsItemABReady;

	private const float PREVIEW_AVATAR_SHARE_OFFSET_X = 0.35f;

	private const float PREVIEW_WEAPON_SHARE_OFFSET_X = -0.16f;

	private const float EVO_KILL_COUNT_OFFSET_X = 32f;

	private const float SHAREBTN_OFFSET_Y = 12f;

	private const uint WEAPON_PROPERTY_CHANGE_BUTTON_GOPOS_ID = 9071u;

	private UIChangeWeaponSkinStatsController m_ChangeWeaponSkinAppearanceCtrl;

	private const int CUSTOM_BG_WIDTH = 1750;

	private const int CUSTOM_BG_HEIGHT = 1070;

	private EBgType m_CurBgType;

	private uint m_LastWeaponSkinIdForBg;

	private UIFrontEndPreviewWeaponPropertyPanelBaseController m_weaponPropertyCtrl;

	private bool m_DataReady;

	private bool m_NeedRefreshCurSecondTab;

	private bool m_NeedRefreshCurThirdTab;

	private int m_GuideStep;

	private int m_GuideNewBieStep;

	private uint m_ClipSoundDelayCall;

	private UIWeaponDetailPopController m_WeaponDetailPopCtrl;

	private uint m_DelayShowKillNotify;

	private UIHUDFeedbackItemBaseController m_KillNotifyCtrl;

	private SoundType m_SoundType;

	private ResourceID m_PreviewFireMultiSound;

	private CameraChangeHelper m_CameraChangeHelper;

	private WeaponSkinBaseInfo m_CacheLastChooseShowWeaponSkinData;

	private EWeaponSkinAppearance m_CacheSelectApperance;

	private uint m_CacheSelectID;

	private bool m_IsWeaponAnimShowing;

	private uint m_LastSelectAppearanceSkinId;

	public static readonly List<Type> InterestedModels;

	private const string SHOW_MULTI_GUIDE_KEY = "SHOW_MULTI_GUIDE_KEY";

	private CollectionDataManager.ECollectionWeaponType m_WeaponType
	{
		get
		{
			return CollectionDataManager.ECollectionWeaponType.fist;
		}
		set
		{
		}
	}

	private uint m_WeaponId
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	private uint m_WeaponSkinId
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	private WeaponSkinBaseInfo m_WeaponSkinData
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public CollectionDataManager.ECollectionWeaponType GetWeaponType()
	{
		return CollectionDataManager.ECollectionWeaponType.fist;
	}

	public uint GetWeaponId()
	{
		return 0u;
	}

	private void RefreshLobbyWeaponTips()
	{
	}

	public void RefreshDictTips()
	{
	}

	private bool TryClearTipsDictBySecondWeaponType(uint wpId)
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	public static void BeforeInit()
	{
	}

	private void OnDownloadBtnClick()
	{
	}

	public void SetHotFixTextShow(bool show)
	{
	}

	public void SetFinalShotHotFixTextShow(bool show)
	{
	}

	public override void BeforeScreenshot()
	{
	}

	public override void AfterScreenshot()
	{
	}

	private void OnLevelUpClick()
	{
	}

	private void OnPokedexBtnClick()
	{
	}

	private void SetWishListNodeActive(bool v)
	{
	}

	private void CreateSharePreviewModel()
	{
	}

	private void OnShareClick()
	{
	}

	protected void Ondraging(GameObject go, Vector2 delta)
	{
	}

	private void OndragStart(GameObject gameObject)
	{
	}

	private void OndragEnd(GameObject gameObject)
	{
	}

	private void OnBtnSwitchClick()
	{
	}

	public void SetSwithBtnVisble(bool need_show, SwitchType type = SwitchType.Gun)
	{
	}

	private void SwithChange(SwitchType type)
	{
	}

	private IEnumerator ResetWeapon()
	{
		return null;
	}

	private void OnWeaponSkillClick()
	{
	}

	private void SetPreviewWeaponItemInputEnable(bool isEnabled)
	{
	}

	private void OnBtnZoomClick()
	{
	}

	private void OnShowIconBtnClick()
	{
	}

	private void SetPreviewObjVisible(object[] data)
	{
	}

	public void ShowIPTag()
	{
	}

	private void ShowNotReachRankItemUseLevelTips(uint itemID)
	{
	}

	private void OnEquipBtnClick()
	{
	}

	private void RequestChooseCacheShowWeaponSkin()
	{
	}

	private void ClearLobbyShowChooseCacheAfterToggleOff()
	{
	}

	private void OnShownBtnClick()
	{
	}

	private void OnBtnNotificationClick()
	{
	}

	private void SetEquipPveSkinStatus()
	{
	}

	protected void SetEquipBtnStatus(bool isIgoreMultiSelect = false)
	{
	}

	protected void SetShowBtnStatus(bool canBeShowed, bool isShowed)
	{
	}

	public void SetNotificationBtnVisble(bool need_show)
	{
	}

	private void RrefreshToDefault()
	{
	}

	private void RefreshToTarget(CollectionDataManager.ECollectionWeaponType targetWeaponType, uint targetWeaponId, uint targetWeaponSkinId, WeaponSkinBaseInfo targetWeaponSkinData)
	{
	}

	private void RefreshToTargetSkinId(uint targetSkinId, bool selectDefault = false)
	{
	}

	private int CalAllWeaponSkins()
	{
		return 0;
	}

	private void ForeceRefreshWeaponData()
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	public override void OnNavigationClosed()
	{
	}

	private void InitAllModelResource()
	{
	}

	private void ReSetItemCamera()
	{
	}

	private void ClearAllModelResource()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnRefreshEventTrigger(object[] data)
	{
	}

	private void OnWeaponSkinTimelineRefresh(object[] data)
	{
	}

	private void OnWeaponSkinNeedRefresh(object[] data)
	{
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	private void OnGridListItemSelected(object[] data)
	{
	}

	private IEnumerator InitDelay()
	{
		return null;
	}

	private int GetFirstTabItemSelectIndex(uint weaponID, bool selectDefault)
	{
		return 0;
	}

	private int GetSecondTabItemSelectIndex(uint weaponID)
	{
		return 0;
	}

	private int GetThirdTabItemSelectIndex(uint weaponSkinId, bool selectDefault)
	{
		return 0;
	}

	private int GetEquipWeaponIndex(uint weaponId)
	{
		return 0;
	}

	private void RefreshSecondGridAndSelectDefaultItem(CollectionDataManager.ECollectionWeaponType curWeaponType, bool needSelectDefaultItem)
	{
	}

	private void RefreshThirdGridAndSelectDefaultItem(uint curWeaponID, bool needSelectDefaultItem)
	{
	}

	public WeaponSkinBaseInfo GetThirdItemSkinIDByIndex(int index)
	{
		return null;
	}

	public uint GetFirstMultiSelectWeaponSkinID(uint weaponId)
	{
		return 0u;
	}

	private void SetDefaultFinalShotState()
	{
	}

	private void RefreshFinalShotState()
	{
	}

	private void RefreshWeaponDetailBtnShow()
	{
	}

	private void RefreshPreview(uint curWeaponSkinId, WeaponSkinBaseInfo curData, bool forcePlayAnim = false)
	{
	}

	private void RefreshWeaponChangeProperty(uint curWeaponId)
	{
	}

	private void RrefreshPreviewWeapon(uint curWeaponSkinId, bool needRefreshNotification = true, bool needRefreshWeaponUI = true, bool forcePlayAnim = false)
	{
	}

	private UIMaleAvatar CreateAvatar(List<uint> idlist, Vector3 scale, Vector3 pos, bool playSpecial, bool changanim = true, int doubleAnimid = 0, string resSpecial = "", string resIdle = "", bool uselight = true)
	{
		return null;
	}

	private void CreatePreviewAvatarOnly(List<uint> idlist)
	{
	}

	private void CreatePreviewAvatarWithWeapon(List<uint> idlist, uint weaponid, bool forcePlayAnim = false)
	{
	}

	private bool ShouldPlayWeaponAnim(uint weaponSkinId, ResourceID modelId, bool forcePlayAnim)
	{
		return false;
	}

	private void SetWeaponSkinToAvatar(UIMaleAvatar targetAvatar, uint weaponSkinId, bool forcePlayAnim = false)
	{
	}

	private void FistAnimCallBack(UIMaleAvatar targetavatar, WeaponSkinData lData, AFOLPMOCBOG cData)
	{
	}

	private bool CheckIsDualWield(uint weaponid)
	{
		return false;
	}

	private void AutoModifyPreviewModelAccordingToResolution(ref GameObject go, bool useY = false, float scaley = 0.5f, bool isAvatar = false)
	{
	}

	private void AutoShift3DPreview(ref GameObject go, float scalex, float scaley, bool useY)
	{
	}

	private void AutoGen3DPreviewCollider(GameObject go, bool isAvatar = false)
	{
	}

	private bool CheckInvaildCollider(Renderer render)
	{
		return false;
	}

	private void ClearAllUI()
	{
	}

	private void Refresh3dWeapon(ResourceID model_id, bool isOriginCustomWeapon = false, bool forcePlayAnim = false)
	{
	}

	private void TryAddClanNameToClanPrivilge(GameObject go, ResourceID model_id)
	{
	}

	private void TryAddPrimeSpriteToPrimePrivilege(GameObject go)
	{
	}

	private void SavePreviewWeaponTransform()
	{
	}

	private void ResetPreviewWeaponTransform()
	{
	}

	private void SavePreviewAvatarLocalPosition()
	{
	}

	private void ResetPreviewAvatarLocalPosition()
	{
	}

	private void UpdateLevelUpVfx()
	{
	}

	private void refrehItemInfo(uint itemid)
	{
	}

	private void RefreshNewbieRecommendBtnLabel()
	{
	}

	private void RefreshWeaponName()
	{
	}

	private void SetQualityColor(uint quality)
	{
	}

	private Color GetQualityColor(uint quality)
	{
		return default(Color);
	}

	private uint RefreshWeaponUI(uint weaponid, ref ResourceID resID, bool needrefresh = true, bool forcePlayAnim = false)
	{
		return 0u;
	}

	private void RefreshLevelObj(uint weaponSkinID)
	{
	}

	private void RefreshPrivilegeIconGrid(uint weaponid)
	{
	}

	private bool RefreshWeaponTagInPrivilegeTable()
	{
		return false;
	}

	private void OnPrivilegeGridClick(int index)
	{
	}

	private void RefreshZoomInBtnSprite()
	{
	}

	private bool SetEvoGunKillCountView(WeaponSkinData lData)
	{
		return false;
	}

	private void RefreshSwitchSoundBtn(WeaponSkinData lData)
	{
	}

	private void RefreshSightReskinState(WeaponSkinData lData)
	{
	}

	private void StopGunSound()
	{
	}

	private void ResetPreviewFireMultiSound()
	{
	}

	private void RefreshSoundAndShowLobbyAndPveLabel(LabelType labelType, bool isSpecialSound = false, bool isSightReskinEnabled = false)
	{
	}

	private void OnSwitchSoundBtnClick()
	{
	}

	private void OnSwitchSightBtnClick()
	{
	}

	private void PlaySound(SoundType soundType = SoundType.None)
	{
	}

	private void OnSwitchSickleZoomBtnClick()
	{
	}

	private void RefreshSickleZoomBtn(uint weaponTypeId)
	{
	}

	private void RepositionPreviewBtnGroup()
	{
	}

	private void RepositionChooseBtnGroupAndSyncLabels()
	{
	}

	private void SyncLabelPositionToButton(UILabel label, GameObject button)
	{
	}

	private void PlayPreivewSpecialOrNormalSound(bool force = false)
	{
	}

	private void PlayPreivewChangeWeaponSound(bool force = false)
	{
	}

	private void PlayPreviewInAndOutClipWeaponSound(bool force = false)
	{
	}

	private bool IsWeaponAnimShowing(uint skinId, ResourceID resID, bool forcePlayAnim)
	{
		return false;
	}

	private void TryShowKillNotifyAndPlayKillSound(bool needRefresh, uint skinId, ResourceID resID, bool forcePlayAnim)
	{
	}

	private void ShowKillNotifyAndPlayKillSound(uint skinId)
	{
	}

	private void OnEquipAsPveSkinBtnClick()
	{
	}

	private void ShowInAbWeapon(uint weaponid, uint wid)
	{
	}

	private void ShowPropertyContainer(bool isVisible, PropertyType pType)
	{
	}

	public bool SetWeaponPvpPropertyScoreVisble(bool isVisble)
	{
		return false;
	}

	public void RefreshWeaponPropertyScore(uint itemid)
	{
	}

	public void RefreshWeaponSkill(uint itemid)
	{
	}

	public void SetWeaponSkinUpgradeInfoIconVisble(bool need_show)
	{
	}

	public void SetWeaponSkinUpgradeInfoIconVisble(uint weaponskinID)
	{
	}

	private void OnPvpToggleClick()
	{
	}

	private void OnPveToggleClick()
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	private void RefreshEquipBtn(bool isIgoreMultiSelect = false)
	{
	}

	private void RefreshShowBtn()
	{
	}

	private void RefreshFinalShotEquipBtn()
	{
	}

	private uint GetRealProfileShowWeaponSkinId()
	{
		return 0u;
	}

	private uint GetCurrentShowingWeaponSkinId()
	{
		return 0u;
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private List<PopMenuData> PrepareFirstGridData()
	{
		return null;
	}

	private List<PopMenuData> PrepareSecondGridListData(List<uint> allWeaponIdOfThisType)
	{
		return null;
	}

	private List<WeaponSkinBaseInfo> PrepareThirdGridListData(uint curWeaponID)
	{
		return null;
	}

	private List<WeaponSkinBaseInfo> ReArrangeList(List<WeaponSkinBaseInfo> list)
	{
		return null;
	}

	private int WeaponSkinBaseInfoCompare(WeaponSkinBaseInfo x, WeaponSkinBaseInfo y)
	{
		return 0;
	}

	private List<WeaponSkinBaseInfo> GetWeaponSkinsSortedByRare(uint curWeaponID)
	{
		return null;
	}

	private int WeaponSkinBaseInfoComparExceptNew(WeaponSkinBaseInfo x, WeaponSkinBaseInfo y)
	{
		return 0;
	}

	private bool CheckWeaponTypeAndWeaponID()
	{
		return false;
	}

	private void RefreshMultiSelectBtn(bool isIgoreMultiSelect = false)
	{
	}

	private void RefreshMultiSelectEquipBtn()
	{
	}

	private void OnClickMultiTipsBtn()
	{
	}

	private void OnClickMultiSelectUnequipBtn()
	{
	}

	private void OnClickMultiSelectEquipBtn()
	{
	}

	private void OnClickRandomCheckBoxBtn()
	{
	}

	private void OnChangeWeaponStatIconBtnClick()
	{
	}

	private void OnPveSkinIconBtnClick()
	{
	}

	private void OnButtonPropertyChangeClick()
	{
	}

	private void OnCustomTimeLimitClick()
	{
	}

	private void OnCustomBtnClick()
	{
	}

	private void OnReplayBtnClick()
	{
	}

	private void OnSkipAnimMaskBtnClick()
	{
	}

	private void OnIpTagBtnClick()
	{
	}

	private void AutoPopNewbieRecommendWnd()
	{
	}

	private bool IsShowNewbieRecommendWnd()
	{
		return false;
	}

	private void OnRecommendWeaponTypeClick(uint weaponType)
	{
	}

	private void OnRecommendWeaponClick(uint weaponId)
	{
	}

	private void RefreshToTargetWeaponLabel(uint weaponType)
	{
	}

	private void RefreshToTargetWeapon(uint weaponId)
	{
	}

	private void ChangeWeaponSkinProperty(uint weaponSkinId, WeaponSkinBaseInfo weaponSkinInfo = null, uint preSkinId = 0u)
	{
	}

	private uint RefreshChangeWeaponSkinAppearanceBtn(uint skinId, ref ResourceID resID, bool forcePlayAnim = false)
	{
		return 0u;
	}

	private void OnChangeWeaponAppearanceFirstBtnClick()
	{
	}

	private void OnChangeWeaponAppearanceSecondBtnClick()
	{
	}

	private void OnChangeWeaponAppearanceThirdBtnClick()
	{
	}

	private void OnWeaponDetailBtnClick()
	{
	}

	private void RefreshBgDuringWeaponAnim(bool show)
	{
	}

	private void RefreshUIBgByWeaponSkinId(uint skinId, bool forceRefresh = false)
	{
	}

	public override void SetBG(string url, int width = 0, int height = 0, bool isFliphHorizontally = false, bool needResetLocalScale = true, uint endTime = uint.MaxValue)
	{
	}

	public override void SetBG(ResourceID bgRes, int width = 0, int height = 0, bool isFliphHorizontally = false, bool needResetLocalScale = true)
	{
	}

	private void CheckWeaponSkinCustomGuide()
	{
	}

	private void ShowCustomSkinGuide()
	{
	}

	private void CheckWeaponSkinAndDetailPopGuide()
	{
	}

	private void CheckWeaponSkinRandomGuide()
	{
	}

	private void TryShowRandomMultiSelectGuide()
	{
	}

	private void ShowRandomMultiSelectGuide()
	{
	}

	protected override void OnPopupWindowListChange()
	{
	}

	private void _003COnShareClick_003Eb__141_0()
	{
	}

	private void _003CRefreshSoundAndShowLobbyAndPveLabel_003Eb__233_0()
	{
	}

	private void _003CCheckWeaponSkinCustomGuide_003Eb__306_0()
	{
	}

	private void _003CCheckWeaponSkinRandomGuide_003Eb__309_0()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public new void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	public new void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}

	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_SetBG(string P0, int P1, int P2, bool P3, bool P4, uint P5)
	{
	}

	public void _003C_003EiFixBaseProxy_SetBG(ResourceID P0, int P1, int P2, bool P3, bool P4)
	{
	}

	public void _003C_003EiFixBaseProxy_OnPopupWindowListChange()
	{
	}
}
