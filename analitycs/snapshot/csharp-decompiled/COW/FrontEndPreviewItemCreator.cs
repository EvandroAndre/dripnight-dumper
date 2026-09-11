using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class FrontEndPreviewItemCreator : FrontEndPreviewBaseCreator
{
	private sealed class _003C_003Ec__DisplayClass72_0
	{
		public FrontEndPreviewItemCreator _003C_003E4__this;

		public ResourceID previewRes;

		public Transform tmpTrans;

		internal void _003CShowHyperBook_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass86_0
	{
		public FrontEndPreviewItemCreator _003C_003E4__this;

		public int readyFlag;

		public ResourceID model_id;

		public GameObject parentGo;

		public bool needSkipKillNotify;

		public bool activeCameraChangeHelper;

		public PreviewChangeWeaponSkinStatComponent previewChangeWeaponSkinStatComponent;

		internal void _003CInstant360DegreePreview3dModel_003Eb__0(uint ticket, bool succeeded, UnityEngine.Object obj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass91_0
	{
		public FrontEndPreviewItemCreator _003C_003E4__this;

		public uint readPetItemID;

		public uint petAnimItemID;

		internal void _003CShowPetAvatar_003Eb__0(uint tk, UIPetAvatar petAvatar)
		{
		}
	}

	private uint _003CCurrentItemID_003Ek__BackingField;

	protected UIFrontEndPreview2DItemController m_Preview2DItem;

	protected uint m_WeaponID;

	protected uint m_CollectionID;

	protected FrontEndPreviewComponent.CollectionPreviewType m_CollectionType;

	protected PlayDoubleWeaponParams m_CachedDoubleWeaponParams;

	protected List<GameObject> m_WeaponPreviewShowList;

	protected HashSet<uint> m_AsyncLoadTickets;

	protected FrontEndPreviewShow3DItemCallback m_Show3DItemCallback;

	private Quaternion _003CWeaponOriginQuatertion_003Ek__BackingField;

	protected ResourceRefCache m_3dModelRefCache;

	public const string WEAPON_SWITCH_SKIN_A = "WeaponA";

	public const string WEAPON_SWITCH_SKIN_B = "WeaponB";

	public const string WEAPON_SWITCH_SKIN_C = "WeaponC";

	protected UIFrontEndPreviewVideoPlayerController m_VideoPlayerController;

	protected GameObject m_PreviewCG;

	protected UIPetAvatar m_PetAvatar;

	protected List<UIMaleAvatar> m_MaleAvatars;

	private uint m_DelayCallHyperBookAnim;

	protected GameObject m_TouchArea;

	private float m_ItemCameraOriginalFov;

	private CameraChangeHelper m_CameraChangeHelper;

	private ResourceID m_PendingPrimeBoardRes;

	private GameObject m_PrimeBoardGo;

	private VehicleSkinData m_VehicleSkinData;

	private Action<GameObject> m_callbackOnPetCreated;

	private uint m_defaultPetID;

	private uint m_defaultPetSkin;

	public uint CurrentItemID
	{
		get
		{
			return _003CCurrentItemID_003Ek__BackingField;
		}
		private set
		{
			_003CCurrentItemID_003Ek__BackingField = value;
		}
	}

	public UIFrontEndPreview2DItemController Preview2DItemCtrl => null;

	public Quaternion WeaponOriginQuatertion
	{
		get
		{
			return _003CWeaponOriginQuatertion_003Ek__BackingField;
		}
		private set
		{
			_003CWeaponOriginQuatertion_003Ek__BackingField = value;
		}
	}

	public GameObject PreviewCG => null;

	public UIPetAvatar PetAvatar
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public override void Init(FrontEndPreviewComponent comp, UIBaseController parentCtrl, FrontEndPreviewContentCreator creator, GameObject groundShadow)
	{
	}

	public override void OnTempHidePreview()
	{
	}

	public override void OnClosePreview()
	{
	}

	protected override FrontEndPreviewComponent.Cameratype GetPreviewCameratype()
	{
		return FrontEndPreviewComponent.Cameratype.None;
	}

	public void ClearCache(bool closeCg = false)
	{
	}

	public void ClearResourceRefCache()
	{
	}

	public void CloseCG()
	{
	}

	private void ClearPetAvatar()
	{
	}

	private void ClearAvatars()
	{
	}

	public override void OnSwitchCamera(FrontEndPreviewComponent.Cameratype type)
	{
	}

	public override void CloseCamera()
	{
	}

	private void SetCommonItemCameratrans(Vector3 pos, Quaternion rotate)
	{
	}

	public void ReSetCamera()
	{
	}

	public void SetPetCreateCallback(Action<GameObject> c)
	{
	}

	public void ShowEmoteWithAninationOrVFX(uint id, CSSharedItemData itemData, ECollectionLevel level)
	{
	}

	public void ShowItemById(uint id, CSSharedItemData itemData, ECollectionLevel level = ECollectionLevel.Lv3, bool playPetLoopIdleSound = false, bool needAddLobbyCloth = false, bool needWeaponAutoChange = false, bool needSkipKillNotify = false)
	{
	}

	public void SetShow3DItemCallback(Action callBack)
	{
	}

	public void ClearShow3DItemCallback()
	{
	}

	private void SetTicketForShow3DItemCallback(uint ticket)
	{
	}

	private void TryInvokeShow3DItemCallback(uint ticket, bool succeed, object obj)
	{
	}

	public void CreatePreview3dModel(ResourceID resID, FrontEndPreviewComponent.CollectionPreviewType type, uint weaponID = 0u, bool forceSync = false, WeaponSkinData wData = null)
	{
	}

	private void LoadPreview3dModel(ResourceID resID, Action<uint, bool, UnityEngine.Object> callback, bool forceSync = false)
	{
	}

	private void CancelLoadPreview3dModel()
	{
	}

	private GameObject OnAsyncLoadPreview3dModelFinish(uint ticket, bool succeeded, UnityEngine.Object obj)
	{
		return null;
	}

	private void ProcessWeaponPrivilegePreview3DModel(uint ticket, bool succeeded, UnityEngine.Object obj)
	{
	}

	private void GetCameraTransByPreviewConfigIndex(int index, ref Vector3 position, ref Quaternion rotation, ref Vector3 scale)
	{
	}

	private void GetItemTransByPreviewConfigIndex(int index, ref Vector3 position, ref Quaternion rotation, ref Vector3 scale)
	{
	}

	private void ProcessNormalPreview3DModel(uint ticket, bool succeeded, UnityEngine.Object obj)
	{
	}

	private void SetPrimeBoardFacingCamera(GameObject primeBoardGo)
	{
	}

	private void ProcessSpecialModel(ref GameObject go)
	{
	}

	public void Show3DBackPackModel(uint id, ECollectionLevel level)
	{
	}

	private void Show3DLootBox(uint id)
	{
	}

	private void Show3DParachute(uint id)
	{
	}

	private void ShowHyperBook(uint id)
	{
	}

	private void Show3DSkyBoard(uint id)
	{
	}

	private void Show3DFlight(uint id)
	{
	}

	private void ShowMultiFlightPreviewAvatar()
	{
	}

	private void Show3DRedEnvelope(uint id)
	{
	}

	private void Show3DWeapon(uint id, ECollectionLevel level = ECollectionLevel.Lv3, bool needAutoChange = false, bool needSkipKillNotify = false)
	{
	}

	private void Show3DFinalShot(uint id, CSSharedItemData itemData, ECollectionLevel level = ECollectionLevel.Lv3)
	{
	}

	private void ShowWeaponSkinOnly(uint id, WeaponSkinData lData, bool needAutoChange = false, bool needSkipKillNotify = false)
	{
	}

	public void SkipModelAnim(bool needSkipKillNotify = false, bool showNotify = true)
	{
	}

	public void CreateDoubleWeapon(uint weapon1, uint weapon2, PlayDoubleWeaponParams param1, PlayDoubleWeaponParams param2)
	{
	}

	private void CreatePreviewWeaponListItem(uint weaponid, PlayDoubleWeaponParams param)
	{
	}

	private void ProcessWeaponListItem(uint ticket, bool succeeded, UnityEngine.Object obj)
	{
	}

	public void Create360DegreePreview3dModel(ResourceID model_id, FrontEndPreviewComponent.CollectionPreviewType type, uint weaponID, WeaponSkinData wData = null, bool needSkipKillNotify = false)
	{
	}

	public void CreateDuplicate360DegreePreview3dModels(BLAMIMLKPKG wsData, FrontEndPreviewComponent.CollectionPreviewType type, uint weaponId, WeaponSkinData wData = null)
	{
	}

	private void Instant360DegreePreview3dModel(ResourceID model_id, GameObject parentGo, bool needCheckOptionalDownload = true, PreviewChangeWeaponSkinStatComponent previewChangeWeaponSkinStatComponent = null, WeaponSkinData wData = null, bool activeCameraChangeHelper = true, int readyFlag = 0, bool needSkipKillNotify = false)
	{
	}

	private void TryAddClanNameToClanPrivilge(GameObject go, ResourceID model_id)
	{
	}

	private void TryAddPrimeSpriteToPrimePrivilege(GameObject go)
	{
	}

	public void Show3DVehicleSkin(uint id)
	{
	}

	private void ShowPet(CSSharedItemData itemData, bool playPetLoopIdleSound = false)
	{
	}

	private void ShowPetAvatar(uint id, uint readPetItemID, bool playPetLoopIdleSound = false, uint petAnimItemID = 0u)
	{
	}

	protected virtual void OnPetAvatarCreated(uint ticket, UIPetAvatar petAvatar, uint readPetItemID, uint petAnimItemID)
	{
	}

	public void SetTouchAreaEnable(bool enable)
	{
	}

	public void SetDefaultPetSkin(uint petID, uint skinID)
	{
	}

	public void Show2dIcon(uint id, bool needBoost = false)
	{
	}

	public void ShowCSPeakBundle2DIcon(List<uint> itemList, CSSharedItemData bundle)
	{
	}

	public void ShowSpecial2DIcon(BaseItemInfo itemInfo, bool needSetDepth = false)
	{
	}

	public void ShowSpecial2DIcon(AwardDesc awardItem)
	{
	}

	public void ShowPhotoGroupTemplatePreview(uint id)
	{
	}

	private void CreatePreview2dItem()
	{
	}

	public void ClearPreview2dItem()
	{
	}

	private void SetSpecial2dItemUIdata(BaseItemInfo data)
	{
	}

	private void SetSpecialCdnItemData(BaseItemInfo data, bool needSetDepth = true)
	{
	}

	private void Set2dItemUIdata(CSSharedItemData data)
	{
	}

	private void SetCSPeakBundleUIData(List<uint> itemList, CSSharedItemData bundle)
	{
	}

	private void Set2dItemScale(float num = 1f)
	{
	}

	public void SkipStoryCG()
	{
	}

	public void SkipSpecialAnim()
	{
	}

	public void SetPreviewCGRatotable(bool enable)
	{
	}

	public void CreatePreviewStoryCg(ResourceID cgid, uint uitype, bool isHas = false, bool showFuncBtn = true)
	{
	}

	public void CreatePreviewSkinAnim(uint uitype, ResourceID resid)
	{
	}

	public bool GetCurrentCgSkip()
	{
		return false;
	}

	public void SetCGVisible(bool flag)
	{
	}

	public bool HasCG()
	{
		return false;
	}

	public void SetCGLightVisible(bool visible)
	{
	}

	public void ReplayCg()
	{
	}

	public void RrefreshWeaponTimeLine()
	{
	}

	public float GetCurCGTimeStamp()
	{
		return 0f;
	}

	public void ShowVideo(PreviewVideoParams videoParasms)
	{
	}

	private void CreateVideoPlayerController()
	{
	}

	public void StopVideo()
	{
	}

	public bool IsVideoPlaying()
	{
		return false;
	}

	protected override void AutoShift3DPreview(ref GameObject go, float scalex, float scaley, bool useY, bool calcaulateCenterPriviewAnchorPoint = true, float offsetX = 0f)
	{
	}

	protected void AutoModifyPetModelAccordingToResolution(ref UIPetAvatar pet, bool calculateYPos = false, float scaley = 0.5f)
	{
	}

	public void AutoModifyModelOnPreviewBorderChange()
	{
	}

	private void SetMiamapBiasNear(GameObject go)
	{
	}

	private void ReadConfig(ref GameObject go, FrontEndPreviewComponent.CollectionPreviewType collectiontype)
	{
	}

	private void SetPreviwConfig(ref GameObject go, FrontEndPreviewConfig.PreviewOneConifg configone, FrontEndPreviewComponent.CollectionPreviewType collectiontype)
	{
	}

	private void SetItemCameraFullViewPort()
	{
	}

	private void SetItemCameraConfigViewPort()
	{
	}

	private void ResetCameraPanZoom()
	{
	}

	public void FocusItemCameraBg()
	{
	}

	public void _003C_003EiFixBaseProxy_Init(FrontEndPreviewComponent P0, UIBaseController P1, FrontEndPreviewContentCreator P2, GameObject P3)
	{
	}

	public void _003C_003EiFixBaseProxy_OnTempHidePreview()
	{
	}

	public void _003C_003EiFixBaseProxy_OnClosePreview()
	{
	}

	public FrontEndPreviewComponent.Cameratype _003C_003EiFixBaseProxy_GetPreviewCameratype()
	{
		return FrontEndPreviewComponent.Cameratype.None;
	}

	public void _003C_003EiFixBaseProxy_OnSwitchCamera(FrontEndPreviewComponent.Cameratype P0)
	{
	}

	public void _003C_003EiFixBaseProxy_CloseCamera()
	{
	}

	public void _003C_003EiFixBaseProxy_AutoShift3DPreview(ref GameObject P0, float P1, float P2, bool P3, bool P4, float P5)
	{
	}
}
