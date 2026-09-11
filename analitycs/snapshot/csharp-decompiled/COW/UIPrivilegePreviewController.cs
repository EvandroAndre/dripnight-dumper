using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIPrivilegePreviewController : UIPreviewBaseController, IUIModelDataChangeObserver, IWeaponSkinFeaturePreviewContext, IClothTriggerEffectPreviewContext
{
	public enum SwitchType
	{
		Gun,
		Person
	}

	private sealed class _003C_003Ec__DisplayClass121_0
	{
		public UIPrivilegePreviewController _003C_003E4__this;

		public List<ResourceID> needDownloadResID;

		internal void _003CRefreshObjModelDownloader_003Eb__0()
		{
		}
	}

	private sealed class _003CResetWeaponInternal_003Ed__90 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIPrivilegePreviewController _003C_003E4__this;

		private Quaternion _003Clerproate_003E5__2;

		private Quaternion _003CendAngle_003E5__3;

		private Vector3 _003CstartLocalPosition_003E5__4;

		private Vector3 _003CstartLocalScale_003E5__5;

		private Vector3 _003CendLocalPosition_003E5__6;

		private Vector3 _003CendLocalScale_003E5__7;

		private float _003Ctime_003E5__8;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CResetWeaponInternal_003Ed__90(int _003C_003E1__state)
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

	protected UINewDownloadInfoController m_ObjModelDownloader;

	protected UIModelWeaponSkinUpgrader m_ModelWeaponSkinUpgrader;

	protected GameObject m_PreviewWeaponObj;

	protected UIPrivilegePreviewView m_View;

	protected Camera m_ItemCamera;

	protected Camera m_PopUpWndCamera;

	private GameObject m_ItemCameraGo;

	private GameObject m_PopUpWndCameraGo;

	protected UIMaleAvatar m_Avatar;

	private uint m_WeaponSkinID;

	private UIWeaponKillNotificationItemController m_AnnouncementObj;

	private UIPrivilegePreviewContext m_UIChangePreviewContext;

	protected Vector3 m_WeaponRotation;

	protected Vector3 m_WeaponLocalScale;

	protected Vector3 m_WeaponPosition;

	protected Vector3 m_AvatarPosition;

	protected Vector3 m_AvatarRotation;

	protected Vector3 m_AvatarScale;

	private Vector3 ITEM_CAMERA_POSITION;

	private Vector3 PREVIEW_ITEM_LOCALPOSITION;

	private Vector3 CLOTHEFFECT_NOAVATAR_LOCALPOSITION;

	private const float PREVIEW_ITEM_POSX = -5f;

	private const float PREVIROTATE_RATE = 0.5f;

	private float m_RotateTime;

	private float m_ItemCameraDepth;

	private float m_OriMixCameraDepth;

	private Coroutine m_RotateWeaponCoroutine;

	private Coroutine m_RotateAvatarCoroutine;

	private uint m_ClothOrBundleId;

	private bool m_IsFemaleAvatar;

	private bool m_IsInPopUpWnd;

	private bool m_IsForceSkipModelAnim;

	private bool m_AvatarMixCameraGoActiveState;

	private UIHUDFeedbackItemBaseController m_KillNotifyCtrl;

	private int m_Weapon2DSoundLoop;

	public bool m_EnableRotate;

	private List<GameObject> m_BackEffects;

	private WeaponSkinData m_SkinDataForBackEffect;

	public GameObject m_FireSoundAudioSource;

	private WeaponSkinFeaturePreviewHandler m_CachedHandler;

	protected uint m_SightReskinSelectedScopeId;

	protected bool m_UseSpecialSightReskin;

	private UISightReskinCommonController m_SightReskinCommonCtrl;

	private const float MixCameraOriginalFOV = 26f;

	private const float MixCameraNB2HackFOV = 30f;

	protected Transform m_KillNotifyContainer;

	protected bool m_ShowPreviewWithAvatar;

	protected CameraChangeHelper m_CameraChangeHelper;

	protected bool m_InitFinalShotBooyahUI;

	protected uint m_BooyahAudioTicket;

	protected virtual bool UseEvoGunSightReskinPreviewScale => false;

	bool IWeaponSkinFeaturePreviewContext.ABDownloaded => false;

	bool IWeaponSkinFeaturePreviewContext.IsForceSkipModelAnim => false;

	bool IWeaponSkinFeaturePreviewContext.IsInPopUpWnd => false;

	bool IWeaponSkinFeaturePreviewContext.UseSpecialSightReskin => false;

	FrontEndPreviewComponent IWeaponSkinFeaturePreviewContext.FrontEndPreviewComponent => null;

	FrontEndPreviewComponent IClothTriggerEffectPreviewContext.FrontEndPreviewComponent => null;

	uint IClothTriggerEffectPreviewContext.ClothOrBundleId
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	uint IClothTriggerEffectPreviewContext.ClothesSetID => 0u;

	bool IClothTriggerEffectPreviewContext.IsFemaleAvatar
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected virtual void RegisterModels()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	protected virtual void PlayFireSound()
	{
	}

	private void ClearBackEffects()
	{
	}

	private void OnRefreshEventTrigger(object[] data)
	{
	}

	public void SetControllerInPopUpWnd(bool inPopUpWnd = true)
	{
	}

	public void SetForceSkipModelAnim(bool force)
	{
	}

	public SwitchType SwitchGunPersonPreview(SwitchType switchType)
	{
		return SwitchType.Gun;
	}

	public void SwtichEffectAvatarPreview(bool isAvatarPreview)
	{
	}

	public void RefreshPreview(uint skinID, int weaponSkinFeature, bool refreshNow = true, EPrivilegePreviewType privilegePreviewType = EPrivilegePreviewType.WeaponSkinFeature)
	{
	}

	public void SetSightReskinScopeId(uint scopeId)
	{
	}

	public void SetUseSpecialSightReskin(bool useSpecialSightReskin)
	{
	}

	public void RefreshPreviewByCurrentState()
	{
	}

	public void SetItemCameraActiveState(bool active)
	{
	}

	public void SetItemCameraDepth(float depth)
	{
	}

	public void SetPreviewObjActiveState(bool active)
	{
	}

	protected void ResetWeapon()
	{
	}

	private void LateUpdate()
	{
	}

	private void SetCamera()
	{
	}

	private void SetPopUpWndCamera()
	{
	}

	protected virtual void SetAvatarPos()
	{
	}

	protected void ResetWeaponTransform()
	{
	}

	private void RefreshPreviewByPreviewComponents(uint curWeaponSkinID, bool needShowWeapon = true)
	{
	}

	private void ShowWeaponFeatureView(uint weaponSkinID, int weaponSkinFeature)
	{
	}

	private void ShowFlightFeatureView(uint flightID)
	{
	}

	private void ShowClothFeatureView(uint clothID, int clothEffectTriggerID)
	{
	}

	private void ShowFinalShotFeatureView(uint finalShotID, int finalShotFeatureID)
	{
	}

	private ResourceID GetWithoutAvatarClothEffectRes(uint clothID, int clothEffectTriggerID)
	{
		return default(ResourceID);
	}

	private bool HasWithoutAvatarClothEffectRes(uint clothID, int clothEffectTriggerID)
	{
		return false;
	}

	protected void PlayEmoteAnimation(uint weaponSkinID, bool CheckLowestDisplay)
	{
	}

	protected void PlayTitle(uint weaponSkinID)
	{
	}

	public void SetEventTriggerState(bool isEnable)
	{
	}

	protected void Ondraging(GameObject go, Vector2 delta)
	{
	}

	protected void OndragStart(GameObject gameObject)
	{
	}

	protected void OndragEnd(GameObject gameObject)
	{
	}

	private IEnumerator ResetWeaponInternal()
	{
		return null;
	}

	protected virtual void OnRefreshFeatureView(uint weaponSkinID, WeaponSkinFeature weaponSkinFeature)
	{
	}

	protected virtual void OnRefreshFlightFeatureView(uint flightID)
	{
	}

	protected virtual void OnRefreshFinalShotFeatureView(uint finalShotID, EFinalShotFeature finalShotFeature)
	{
	}

	protected virtual void OnRefreshFeatureViewOld(uint weaponSkinID, WeaponSkinFeature weaponSkinFeature)
	{
	}

	protected virtual void SetKillNotifyContainer()
	{
	}

	protected virtual void OnRefreshFeatureViewByRes(ResourceID model_id)
	{
	}

	private void SetBackEffect(UIStatedAvatar s)
	{
	}

	public void SetAllCameraState(bool state)
	{
	}

	public void SetMagnifierState(bool isBoost)
	{
	}

	public void InitCameraMove(bool isBelow = false)
	{
	}

	private bool IsDualWeild(WeaponSkinData data)
	{
		return false;
	}

	private void ChangeLayer(Transform trans, string targetLayer)
	{
	}

	protected virtual FrontEndPreviewComponent.CollectionPreviewType GetFeaturePreviewType(WeaponSkinFeature weaponSkinFeature, uint weaponSkinID)
	{
		return FrontEndPreviewComponent.CollectionPreviewType.BackPack;
	}

	protected void Refresh3dPreviewObj(ResourceID model_id, FrontEndPreviewComponent.CollectionPreviewType privilegePreviewType = FrontEndPreviewComponent.CollectionPreviewType.Invalid, bool skipAnim = false, Vector3? objPosition = null)
	{
	}

	protected void ReSetItemCamera()
	{
	}

	protected void ProcessWeaponObject(Quaternion rotation, Vector3 position, Vector3 localScale, uint weaponSkinID, bool skipAnim = false)
	{
	}

	protected void RefreshChangeWeaponPreviewObj(ResourceID modelIDA, ResourceID modelIDB)
	{
	}

	private void SkipWeaponAnimation(GameObject resobj)
	{
	}

	protected void RefreshChangeWeaponPreviewObj(ResourceID modelIDA, ResourceID modelIDB, ResourceID modelIDC)
	{
	}

	private void AutoModifyPreviewModelAccordingToResolution(ref GameObject go, bool useY = false, float scaley = 0.5f, bool isAvatar = false)
	{
	}

	private void AutoGen3DPreviewCollider(GameObject go, bool isAvatar = false)
	{
	}

	protected bool CheckInvaildCollider(Renderer render)
	{
		return false;
	}

	private void AutoShift3DPreview(ref GameObject go, float scalex, float scaley, bool useY)
	{
	}

	private bool HasWeaponWithFullAnim(uint weaponSkinID)
	{
		return false;
	}

	public void SetClothPrivilegePreviewData(uint id, bool isFemale)
	{
	}

	public void PrepareAvatarToPreviewEventTriggerEffect(uint clothesSetID = 0u)
	{
	}

	public void PreviewNB2HackTransformer()
	{
	}

	public void PreviewEventTriggerEffect(ClothTriggerEffectPreviewData data)
	{
	}

	private void PreviewEventTriggerEffectOld(ClothTriggerEffectPreviewData data)
	{
	}

	private void RefreshMultipleEventTriggerEffect(ClothTriggerEffectPreviewData data, List<uint> clothList)
	{
	}

	public void RefreshObjModelDownloader(EPrivilegePreviewType priviewType)
	{
	}

	public override bool StopRefreshCurPreview()
	{
		return false;
	}

	public virtual bool IsLoopKillNotify()
	{
		return false;
	}

	public virtual void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public virtual uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	protected virtual void RefreshABDownloadInfo()
	{
	}

	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	protected override FrontendPreviewType GetPreviewUIType()
	{
		return FrontendPreviewType.Lobby;
	}

	UIMaleAvatar IWeaponSkinFeaturePreviewContext.GetCreateAvatar()
	{
		return null;
	}

	void IWeaponSkinFeaturePreviewContext.SetCurrentAvatar(UIMaleAvatar avatar)
	{
	}

	void IWeaponSkinFeaturePreviewContext.SetAvatarPos()
	{
	}

	void IWeaponSkinFeaturePreviewContext.ShowAvatar(uint avatarID, List<uint> clothList, uint weaponID, bool needShowAnim, List<uint> checkOptionalIds)
	{
	}

	void IWeaponSkinFeaturePreviewContext.RefreshPreviewByPreviewComponents(uint curWeaponSkinID, bool needShowWeapon)
	{
	}

	void IWeaponSkinFeaturePreviewContext.Refresh3dPreviewObj(ResourceID model_id, FrontEndPreviewComponent.CollectionPreviewType privilegePreviewType, bool skipAnim, Vector3? objPosition)
	{
	}

	void IWeaponSkinFeaturePreviewContext.RefreshChangeWeaponPreviewObj(ResourceID modelIDA, ResourceID modelIDB)
	{
	}

	void IWeaponSkinFeaturePreviewContext.RefreshChangeWeaponPreviewObj(ResourceID modelIDA, ResourceID modelIDB, ResourceID modelIDC)
	{
	}

	FrontEndPreviewComponent.CollectionPreviewType IWeaponSkinFeaturePreviewContext.GetFeaturePreviewType(WeaponSkinFeature weaponSkinFeature, uint weaponSkinID)
	{
		return FrontEndPreviewComponent.CollectionPreviewType.BackPack;
	}

	void IWeaponSkinFeaturePreviewContext.SetEventTriggerState(bool isEnable)
	{
	}

	void IWeaponSkinFeaturePreviewContext.StopAllCoroutines()
	{
	}

	void IWeaponSkinFeaturePreviewContext.PlayEmoteAnimation(uint weaponSkinID, bool CheckLowestDisplay)
	{
	}

	void IWeaponSkinFeaturePreviewContext.PlayTitle(uint weaponSkinID)
	{
	}

	void IWeaponSkinFeaturePreviewContext.SetKillNotifyContainer()
	{
	}

	object IWeaponSkinFeaturePreviewContext.GetKillNotifyCtrl()
	{
		return null;
	}

	void IWeaponSkinFeaturePreviewContext.SetKillNotifyCtrl(object ctrl)
	{
	}

	void IWeaponSkinFeaturePreviewContext.SetAnnouncementContainer()
	{
	}

	object IWeaponSkinFeaturePreviewContext.GetAnnouncementCtrl()
	{
		return null;
	}

	void IWeaponSkinFeaturePreviewContext.SetAnnouncementCtrl(object ctrl)
	{
	}

	void IWeaponSkinFeaturePreviewContext.OnMagnifierStateChanged(WeaponSkinFeature feature)
	{
	}

	void IWeaponSkinFeaturePreviewContext.OnMagnifierStateDefault()
	{
	}

	GameObject IWeaponSkinFeaturePreviewContext.GetPreviewWeaponObj()
	{
		return null;
	}

	void IWeaponSkinFeaturePreviewContext.SetPreviewWeaponObj(GameObject obj)
	{
	}

	bool IWeaponSkinFeaturePreviewContext.ShouldClearCache()
	{
		return false;
	}

	int IWeaponSkinFeaturePreviewContext.GetMaxPanelDepth()
	{
		return 0;
	}

	uint IWeaponSkinFeaturePreviewContext.GetSelectedScopeAttachmentId()
	{
		return 0u;
	}

	void IWeaponSkinFeaturePreviewContext.RefreshSightReskinView(uint weaponSkinId, uint scopeAttachmentId, bool useSpecialSightReskin)
	{
	}

	void IWeaponSkinFeaturePreviewContext.HideSightReskinView()
	{
	}

	void IClothTriggerEffectPreviewContext.SwtichEffectAvatarPreview(bool isAvatarPreview)
	{
	}

	void IClothTriggerEffectPreviewContext.RefreshPreview(uint clothID, int clothEffectTriggerID, bool refreshNow, EPrivilegePreviewType privilegePreviewType)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public bool _003C_003EiFixBaseProxy_StopRefreshCurPreview()
	{
		return false;
	}
}
