using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public abstract class UIPreviewBaseController : UIBaseController, IPreviewController
{
	private sealed class _003C_003Ec__DisplayClass32_0
	{
		public UIPreviewBaseController _003C_003E4__this;

		public Vector3 avatar1Pos;

		public Vector3 avatar2Pos;

		internal void _003CCreateDoublePreviewAvatar_003Eb__0()
		{
		}
	}

	protected FrontendPreviewType m_PreviewUIType;

	protected FrontEndPreviewConfigData m_FrontEndPreviewData;

	protected UIWidget m_FrontEndPreviewBorder;

	protected FrontEndPreviewComponent m_FrontEndPreviewComponent;

	public bool IsDelayPreviewFinished()
	{
		return false;
	}

	protected abstract UIWidget GetFrontEndPreviewBorder();

	protected abstract FrontendPreviewType GetPreviewUIType();

	public virtual bool IsAutoCalculatePreviewPanelSize()
	{
		return false;
	}

	protected virtual FrontEndPreviewComponent GetFrontEndPreviewComponent()
	{
		return null;
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected virtual FrontEndPreviewConfigData GetFrontEndPreviewData()
	{
		return null;
	}

	protected virtual void OpenPreview()
	{
	}

	protected virtual void ChangePreviewUIType(FrontendPreviewType type)
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

	public virtual void ShowPreviewByID(uint itemID, BaseItemInfo itemInfo, EInventory.AwardType awardType = EInventory.AwardType.AwardType_ITEM, bool isShowDesc = true, bool isShowOwned = true, FullScreenAnimParams animdata = null, bool showBundleScrollView = true, bool playAnimation = true, bool showBundleTitle = true, bool needResetAvatarDiretion = false, bool needResetUI = true, bool needRecordeParam = true, uint bundleIDIamIn = 0u, bool playLoopIdleSound = false, bool playPetLoopIdleSound = false, bool isHideIPTag = false, bool skipWeaponAnim = false, bool needRefreshUI = true, ECollectionLevel level = ECollectionLevel.Lv3, Action show3DItemCallback = null, bool isHideBundleTips = false, bool needAddLobbyCloth = false, bool needWeaponAutoChange = false, bool isShowTailorUpgradeLevel = true, uint clothesSetID = 0u)
	{
	}

	public void RefreshPreviewUIOnly(uint id, BaseItemInfo itemInfo, EInventory.AwardType award_type = EInventory.AwardType.AwardType_ITEM, bool isShowDescription = true, bool isShowOwned = true, bool showBundleScrollView = true, bool showBundleTitle = true, bool needResetUI = true, bool isHideIPTag = false, bool RefreshPreviewUIOnly = false, ECollectionLevel level = ECollectionLevel.Lv3)
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

	public UIMaleAvatar GetCreateAvatar()
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

	public bool IsPreviewOpen()
	{
		return false;
	}

	public void ClearCache(bool clearall = false, bool clearPreviewAvatar = true, bool clearPreviewCacheAvatar = false, bool clearDesc = false)
	{
	}

	public void CreateDoublePreviewAvatar(PlayDoubleAvatarAnimParams param, Vector3 avatar1Pos, Vector3 avatar2Pos, bool needCheckClothEffectUnlock)
	{
	}

	public virtual bool StopRefreshCurPreview()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
