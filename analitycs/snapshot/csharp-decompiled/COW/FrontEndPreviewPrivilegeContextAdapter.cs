using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class FrontEndPreviewPrivilegeContextAdapter : IWeaponSkinFeaturePreviewContext
{
	private FrontEndPreviewComponent m_PreviewComponent;

	private bool m_ABDownloaded;

	private bool m_IsForceSkipModelAnim;

	private bool m_IsInPopUpWnd;

	private GameObject m_PreviewWeaponObj;

	private Transform m_KillNotifyContainer;

	private object m_KillNotifyCtrl;

	private object m_AnnouncementCtrl;

	private Transform m_AnnouncementContainer;

	private WeaponSkinFeaturePreviewHandler m_CachedHandler;

	private UIBaseController m_ParentController;

	public bool ABDownloaded
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsForceSkipModelAnim
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsInPopUpWnd
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool UseSpecialSightReskin => false;

	public FrontEndPreviewComponent FrontEndPreviewComponent => null;

	public FrontEndPreviewPrivilegeContextAdapter(FrontEndPreviewComponent previewComponent, UIBaseController parentController)
	{
	}

	public WeaponSkinFeaturePreviewHandler GetOrCreateHandler()
	{
		return null;
	}

	public void ClearHandler(bool clearReference = true)
	{
	}

	public UIMaleAvatar GetCreateAvatar()
	{
		return null;
	}

	public void SetCurrentAvatar(UIMaleAvatar avatar)
	{
	}

	public void SetAvatarPos()
	{
	}

	public void ShowAvatar(uint avatarID, List<uint> clothList, uint weaponID = 0u, bool needShowAnim = true, List<uint> checkOptionalIds = null)
	{
	}

	public void RefreshPreviewByPreviewComponents(uint curWeaponSkinID, bool needShowWeapon = true)
	{
	}

	public void Refresh3dPreviewObj(ResourceID model_id, FrontEndPreviewComponent.CollectionPreviewType previewType = FrontEndPreviewComponent.CollectionPreviewType.Invalid, bool skipAnim = false, Vector3? objPosition = null)
	{
	}

	public void RefreshChangeWeaponPreviewObj(ResourceID modelIDA, ResourceID modelIDB)
	{
	}

	public void RefreshChangeWeaponPreviewObj(ResourceID modelIDA, ResourceID modelIDB, ResourceID modelIDC)
	{
	}

	public FrontEndPreviewComponent.CollectionPreviewType GetFeaturePreviewType(WeaponSkinFeature weaponSkinFeature, uint weaponSkinID)
	{
		return FrontEndPreviewComponent.CollectionPreviewType.BackPack;
	}

	public void SetEventTriggerState(bool isEnable)
	{
	}

	public void StopAllCoroutines()
	{
	}

	public void PlayEmoteAnimation(uint weaponSkinID, bool CheckLowestDisplay)
	{
	}

	public void PlayTitle(uint weaponSkinID)
	{
	}

	public void SetKillNotifyContainer()
	{
	}

	public object GetKillNotifyCtrl()
	{
		return null;
	}

	public void SetKillNotifyCtrl(object ctrl)
	{
	}

	public void SetAnnouncementContainer()
	{
	}

	public object GetAnnouncementCtrl()
	{
		return null;
	}

	public void SetAnnouncementCtrl(object ctrl)
	{
	}

	public void OnMagnifierStateChanged(WeaponSkinFeature feature)
	{
	}

	public void OnMagnifierStateDefault()
	{
	}

	public GameObject GetPreviewWeaponObj()
	{
		return null;
	}

	public void SetPreviewWeaponObj(GameObject obj)
	{
	}

	public bool ShouldClearCache()
	{
		return false;
	}

	public int GetMaxPanelDepth()
	{
		return 0;
	}

	public uint GetSelectedScopeAttachmentId()
	{
		return 0u;
	}

	public void RefreshSightReskinView(uint weaponSkinId, uint scopeAttachmentId, bool useSpecialSightReskin)
	{
	}

	public void HideSightReskinView()
	{
	}
}
