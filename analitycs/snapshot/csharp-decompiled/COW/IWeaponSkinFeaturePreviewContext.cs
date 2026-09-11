using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public interface IWeaponSkinFeaturePreviewContext
{
	bool ABDownloaded { get; }

	bool IsForceSkipModelAnim { get; }

	bool IsInPopUpWnd { get; }

	bool UseSpecialSightReskin { get; }

	FrontEndPreviewComponent FrontEndPreviewComponent { get; }

	UIMaleAvatar GetCreateAvatar();

	void SetCurrentAvatar(UIMaleAvatar avatar);

	void SetAvatarPos();

	void ShowAvatar(uint avatarID, List<uint> clothList, uint weaponID = 0u, bool needShowAnim = true, List<uint> checkOptionalIds = null);

	void RefreshPreviewByPreviewComponents(uint curWeaponSkinID, bool needShowWeapon = true);

	void Refresh3dPreviewObj(ResourceID model_id, FrontEndPreviewComponent.CollectionPreviewType previewType = FrontEndPreviewComponent.CollectionPreviewType.Invalid, bool skipAnim = false, Vector3? objPosition = null);

	void RefreshChangeWeaponPreviewObj(ResourceID modelIDA, ResourceID modelIDB);

	void RefreshChangeWeaponPreviewObj(ResourceID modelIDA, ResourceID modelIDB, ResourceID modelIDC);

	FrontEndPreviewComponent.CollectionPreviewType GetFeaturePreviewType(WeaponSkinFeature weaponSkinFeature, uint weaponSkinID);

	void SetEventTriggerState(bool isEnable);

	void StopAllCoroutines();

	void PlayEmoteAnimation(uint weaponSkinID, bool CheckLowestDisplay);

	void PlayTitle(uint weaponSkinID);

	void SetKillNotifyContainer();

	object GetKillNotifyCtrl();

	void SetKillNotifyCtrl(object ctrl);

	void SetAnnouncementContainer();

	object GetAnnouncementCtrl();

	void SetAnnouncementCtrl(object ctrl);

	void OnMagnifierStateChanged(WeaponSkinFeature feature);

	void OnMagnifierStateDefault();

	GameObject GetPreviewWeaponObj();

	void SetPreviewWeaponObj(GameObject obj);

	bool ShouldClearCache();

	int GetMaxPanelDepth();

	uint GetSelectedScopeAttachmentId();

	void RefreshSightReskinView(uint weaponSkinId, uint scopeAttachmentId, bool useSpecialSightReskin);

	void HideSightReskinView();
}
