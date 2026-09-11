using System;
using System.Collections.Generic;
using UnityEngine;
using proto;

namespace COW;

public interface IPreviewController
{
	void TempHidePreview(bool keepUIContent = false, bool keep3DContent = false);

	void RecoverPreview(bool needShowCurrentPreview = true);

	void ShowPreviewByID(uint itemID, BaseItemInfo itemInfo, EInventory.AwardType awardType = EInventory.AwardType.AwardType_ITEM, bool isShowDesc = true, bool isShowOwned = true, FullScreenAnimParams animdata = null, bool showBundleScrollView = true, bool playAnimation = true, bool showBundleTitle = true, bool needResetAvatarDiretion = false, bool needResetUI = true, bool needRecordeParam = true, uint bundleIDIamIn = 0u, bool playLoopIdleSound = false, bool playPetLoopIdleSound = false, bool isHideIPTag = false, bool skipWeaponAnim = false, bool needRefreshUI = true, ECollectionLevel level = ECollectionLevel.Lv3, Action show3DItemCallback = null, bool isHideBundleTips = false, bool needAddLobbyCloth = false, bool needWeaponAutoChange = true, bool isShowTailorUpgradeLevel = true, uint clothesSetID = 0u);

	void ShowAvatar(uint avatarID, List<uint> clothList, uint weaponID = 0u, bool needShowAnim = true, bool needOptionalDownload = false, bool clearUI = true, List<uint> checkOptionalIds = null, bool needCheckClothEffectUnlock = true, uint clothEffectItemID = 0u, HashSet<uint> unlockClothEffectItemIds = null, bool isForceShowDefaultSkin = false, bool needRefreshUI = true, bool needAddLobbyCloth = false, bool needKeepHairWhenSameAvatarId = false, uint selectedClothID = 0u, PreviewBackpackParams backpackParams = null, uint? skinColor = null, ulong accountID = 0uL);

	void RefreshPreviewDesc(uint itemID);

	bool IsPreviewOpen();

	UIMaleAvatar GetCreateAvatar();

	void ClearCache(bool clearall = false, bool clearPreviewAvatar = true, bool clearPreviewCacheAvatar = false, bool clearDesc = false);

	void CreateDoublePreviewAvatar(PlayDoubleAvatarAnimParams param, Vector3 avatar1Pos, Vector3 avatar2Pos, bool needCheckClothEffectUnlock);

	bool IsAutoCalculatePreviewPanelSize();

	UIFrontEndPreviewCommonController GetFrontEndPreviewCommonController();

	UIFrontEndPreviewController GetFrontEndPreviewUIController();

	bool IsDelayPreviewFinished();

	void RefreshPreviewUIOnly(uint id, BaseItemInfo itemInfo, EInventory.AwardType award_type = EInventory.AwardType.AwardType_ITEM, bool isShowDescription = true, bool isShowOwned = true, bool showBundleScrollView = true, bool showBundleTitle = true, bool needResetUI = true, bool isHideIPTag = false, bool isShowDownloadUI = false, ECollectionLevel level = ECollectionLevel.Lv3);

	bool StopRefreshCurPreview();
}
