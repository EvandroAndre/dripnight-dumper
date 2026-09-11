using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public abstract class UIPreviewNavigationController : UINavigationController, IPreviewController
{
	private sealed class _003C_003Ec__DisplayClass34_0
	{
		public UIPreviewNavigationController _003C_003E4__this;

		public uint itemID;

		public BaseItemInfo itemInfo;

		public EInventory.AwardType awardType;

		public bool isShowDesc;

		public bool isShowOwned;

		public FullScreenAnimParams animdata;

		public bool showBundleScrollView;

		public bool playAnimation;

		public bool showBundleTitle;

		public bool needResetAvatarDiretion;

		public bool needResetUI;

		public bool needRecordeParam;

		public uint bundleIDIamIn;

		public bool playLoopIdleSound;

		public bool playPetLoopIdleSound;

		public bool isHideIPTag;

		public bool skipWeaponAnim;

		public bool needRefreshUI;

		public ECollectionLevel level;

		public Action show3DItemCallback;

		public bool isHideBundleTips;

		public bool needAddLobbyCloth;

		public bool needWeaponAutoChange;

		public bool isShowTailorUpgradeLevel;

		public uint clothesSetID;

		internal void _003CShowPreviewByID_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass35_0
	{
		public UIPreviewNavigationController _003C_003E4__this;

		public uint id;

		public BaseItemInfo itemInfo;

		public EInventory.AwardType award_type;

		public bool isShowDescription;

		public bool isShowOwned;

		public bool showBundleScrollView;

		public bool showBundleTitle;

		public bool needResetUI;

		public bool isHideIPTag;

		public bool isShowDownloadUI;

		public ECollectionLevel level;

		internal void _003CRefreshPreviewUIOnly_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass36_0
	{
		public UIPreviewNavigationController _003C_003E4__this;

		public uint avatarID;

		public List<uint> clothList;

		public bool needShowAnim;

		public uint weaponID;

		public bool needOptionalDownload;

		public bool clearUI;

		public List<uint> checkOptionalIds;

		public bool needCheckClothEffectUnlock;

		public uint clothEffectItemID;

		public HashSet<uint> unlockClothEffectItemIds;

		public bool isForceShowDefaultSkin;

		public bool needRefreshUI;

		public bool needAddLobbyCloth;

		public bool needKeepHairWhenSameAvatarId;

		public uint selectedClothID;

		public PreviewBackpackParams backpackParams;

		public uint? skinColor;

		public ulong accountID;

		internal void _003CShowAvatar_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass43_0
	{
		public UIPreviewNavigationController _003C_003E4__this;

		public Vector3 avatar1Pos;

		public Vector3 avatar2Pos;

		internal void _003CCreateDoublePreviewAvatar_003Eb__0()
		{
		}
	}

	protected bool m_FirstEnterFlag;

	protected bool m_IsHideByPreviewPop;

	protected FrontendPreviewType m_PreviewUIType;

	protected FrontEndPreviewConfigData m_FrontEndPreviewData;

	protected UIWidget m_FrontEndPreviewBorder;

	protected FrontEndPreviewComponent m_FrontEndPreviewComponent;

	private uint m_DelayPreview;

	public bool IsDelayPreviewFinished()
	{
		return false;
	}

	protected abstract UIWidget GetFrontEndPreviewBorder();

	protected abstract FrontendPreviewType GetPreviewUIType();

	protected override void OnUIInit()
	{
	}

	public virtual bool IsAutoCalculatePreviewPanelSize()
	{
		return false;
	}

	protected virtual bool NeedRecoverPreviewOnNavigationShowed()
	{
		return false;
	}

	protected virtual FrontEndPreviewConfigData GetFrontEndPreviewData()
	{
		return null;
	}

	protected virtual FrontEndPreviewComponent GetFrontEndPreviewComponent()
	{
		return null;
	}

	public virtual UIFrontEndPreviewCommonController GetFrontEndPreviewCommonController()
	{
		return null;
	}

	public virtual UIFrontEndPreviewController GetFrontEndPreviewUIController()
	{
		return null;
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	protected bool IsCorveredByPreviewPopWindow()
	{
		return false;
	}

	protected bool IsCorveredByTokenTowerRewardPopWindow()
	{
		return false;
	}

	protected bool IsCoveredByScreenShotPopWindow()
	{
		return false;
	}

	public override void OnNavigationClosed()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected virtual void OpenPreview()
	{
	}

	protected virtual void ChangePreviewUIType(FrontendPreviewType type)
	{
	}

	public void ForceRefreshPreview()
	{
	}

	protected virtual void OnChangePreviewUIType()
	{
	}

	protected virtual void ClosePreview()
	{
	}

	public void TempHidePreview(bool keepUIContent = false, bool keep3DContent = false)
	{
	}

	protected virtual void OnTempHidePreview()
	{
	}

	public void RecoverPreview(bool needShowCurrentPreview = true)
	{
	}

	protected virtual void OnRecoverPreview()
	{
	}

	protected virtual bool DelayPreview()
	{
		return false;
	}

	protected virtual float DelayPreviewTime()
	{
		return 0f;
	}

	public virtual void ShowPreviewByID(uint itemID, BaseItemInfo itemInfo, EInventory.AwardType awardType = EInventory.AwardType.AwardType_ITEM, bool isShowDesc = true, bool isShowOwned = true, FullScreenAnimParams animdata = null, bool showBundleScrollView = true, bool playAnimation = true, bool showBundleTitle = true, bool needResetAvatarDiretion = false, bool needResetUI = true, bool needRecordeParam = true, uint bundleIDIamIn = 0u, bool playLoopIdleSound = false, bool playPetLoopIdleSound = false, bool isHideIPTag = false, bool skipWeaponAnim = false, bool needRefreshUI = true, ECollectionLevel level = ECollectionLevel.Lv3, Action show3DItemCallback = null, bool isHideBundleTips = false, bool needAddLobbyCloth = false, bool needWeaponAutoChange = false, bool isShowTailorUpgradeLevel = true, uint clothesSetID = 0u)
	{
	}

	public void RefreshPreviewUIOnly(uint id, BaseItemInfo itemInfo, EInventory.AwardType award_type = EInventory.AwardType.AwardType_ITEM, bool isShowDescription = true, bool isShowOwned = true, bool showBundleScrollView = true, bool showBundleTitle = true, bool needResetUI = true, bool isHideIPTag = false, bool isShowDownloadUI = false, ECollectionLevel level = ECollectionLevel.Lv3)
	{
	}

	public virtual void ShowAvatar(uint avatarID, List<uint> clothList, uint weaponID = 0u, bool needShowAnim = true, bool needOptionalDownload = false, bool clearUI = true, List<uint> checkOptionalIds = null, bool needCheckClothEffectUnlock = true, uint clothEffectItemID = 0u, HashSet<uint> unlockClothEffectItemIds = null, bool isForceShowDefaultSkin = false, bool needRefreshUI = true, bool needAddLobbyCloth = false, bool needKeepHairWhenSameAvatarId = false, uint selectedClothID = 0u, PreviewBackpackParams backpackParams = null, uint? skinColor = null, ulong accountID = 0uL)
	{
	}

	public virtual void RefreshPreviewDesc(uint itemID)
	{
	}

	protected virtual void SetPreviewBorder(UIWidget previewBorder)
	{
	}

	protected virtual void SetAvatarParams(Vector3 scale, Vector3 pos, FrontEndPreviewComponent.AvatarType type, Vector4 boostparams, Vector4 boostparamsbelow, bool playPose = true, bool needStopEffect = true, Vector3 roation = default(Vector3), bool createCacheAvatarNeedPlaySpecialAnim = true)
	{
	}

	public bool IsPreviewOpen()
	{
		return false;
	}

	public UIMaleAvatar GetCreateAvatar()
	{
		return null;
	}

	public void ClearCache(bool clearall = false, bool clearPreviewAvatar = true, bool clearPreviewCacheAvatar = false, bool clearDesc = false)
	{
	}

	public void CreateDoublePreviewAvatar(PlayDoubleAvatarAnimParams param, Vector3 avatar1Pos, Vector3 avatar2Pos, bool needCheckClothEffectUnlock)
	{
	}

	protected virtual void SetBgByCameraType(object[] param)
	{
	}

	protected override void OnPopupWindowListChange()
	{
	}

	protected virtual bool RecoverPreviewNeedSkipAnim()
	{
		return false;
	}

	protected virtual bool RecoverPreviewNeedSkipKillNotify()
	{
		return false;
	}

	public virtual bool StopRefreshCurPreview()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	public void _003C_003EiFixBaseProxy_OnPopupWindowListChange()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
