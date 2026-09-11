using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIWeaponSkinUpgraderFeatureController : UIPopupWindowController
{
	private class ModelTransformerAttri
	{
		public Vector3 m_Pos;

		public Vector3 m_Rot;

		public Vector3 m_Scale;

		public ModelTransformerAttri(Vector3 pos, Vector3 rot, Vector3 scale)
		{
		}
	}

	private UIWeaponSkinUpgraderFeatureView m_View;

	private GameObject m_FeatureModel;

	private UIWeaponKillNotificationItemController m_AnnouncementCtrl;

	private UIHudStackedKillNotificationController m_KillNotifyCtrl;

	private Transform m_FeatureSubTrans;

	private UIMaleAvatar m_FeatureAvatar;

	private GameObject m_FeatureCamera;

	private Camera m_Camera;

	private CSSharedItemData m_Data;

	private bool m_IsWeaponSkinFeature;

	private WeaponSkinData m_WeaponSkinData;

	private WeaponSetData m_WeaponSetData;

	private WeaponSkinFeature m_WeaponSkinFeature;

	private const float m_RotateRate = 0.5f;

	private bool m_NeedRotate;

	private FrontEndPreviewComponent m_FrontEndPreviewComponent;

	private CameraChangeHelper m_ChangeCameraHelper;

	private UIScopeSelectController m_UIScopeSelectCtrl;

	private uint m_SelectedScopeId;

	private UISightReskinCommonController m_SightReskinCommonCtrl;

	private const bool kUseSpecialSightReskin = true;

	private static readonly Dictionary<int, ModelTransformerAttri> m_TransAttriDict;

	public Action m_CloseAction;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void OnPopupWindowListChange()
	{
	}

	public void ShowFeatureView(WeaponSkinData data, WeaponSkinFeature feature)
	{
	}

	private void CreateFeature()
	{
	}

	private void UpdateSkinMeshRender(bool flag)
	{
	}

	private void OnShowFeature()
	{
	}

	private void EnableUI(bool v)
	{
	}

	public void Set3DModelVisiable(bool b)
	{
	}

	private void CreateCamera()
	{
	}

	private void CreateFetureItem()
	{
	}

	public void DisplayWeaponPropertyScore()
	{
	}

	public void RefreshWeaponPropertyScore(bool isShow)
	{
	}

	private bool CheckItemABReady(uint itemID)
	{
		return false;
	}

	private void CreateRigidbody(ResourceID resID)
	{
	}

	private bool CreateAvatar(WeaponSkinData skinData, Vector3 avatarPos, Vector3 avatarRotate, Vector3 avatarScale, bool showDefaultAvatar = false)
	{
		return false;
	}

	private void PlayWithGun(WeaponSkinData skinData, bool isFemale)
	{
	}

	private void PlayReload(WeaponSkinData skinData, bool isfemale)
	{
	}

	private void PlayChangeWeaponAnim(WeaponSkinData skinData, bool isfemale)
	{
	}

	private void ShowSightReskinPreview()
	{
	}

	private void HideSightReskinPreview()
	{
	}

	private void OnScopeTypeSelected(uint scopeAttachmentId)
	{
	}

	private void RefreshSightReskinOverlay(uint weaponSkinId, uint scopeAttachmentId)
	{
	}

	private static List<uint> BuildScopeListForSightReskin(uint weaponSkinId)
	{
		return null;
	}

	private void Adjust3DModel(Dictionary<int, ModelTransformerAttri> transAttriDict)
	{
	}

	private void SetFeatureModelTransform(Vector3 pos, Vector3 rot, Vector3 scale)
	{
	}

	private void SetDoNeedRotate()
	{
	}

	private Transform GetSubTransfrom()
	{
		return null;
	}

	private void Rotate3DModel()
	{
	}

	private void Update()
	{
	}

	private void OnOKBtnClick()
	{
	}

	private void OnShareBtnClik()
	{
	}

	public override void BeforeScreenshot()
	{
	}

	public override void AfterScreenshot()
	{
	}

	public override void BeforeSharePreview()
	{
	}

	public override void AfterSharePreview()
	{
	}

	private void SetShareUIVisiable(bool isScreenShot)
	{
	}

	private void SetTouchEnable(bool b)
	{
	}

	private void UpdateViewInfo()
	{
	}

	public void ShowIPTag()
	{
	}

	private void ChangeLayer(Transform trans, string targetLayer)
	{
	}

	private void PlayPopWndSound()
	{
	}

	private void Destroy3DModel()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public override bool ClosedByEsc()
	{
		return false;
	}

	private void OnRefreshEventTrigger(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnPopupWindowListChange()
	{
	}

	public void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	public void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}

	public void _003C_003EiFixBaseProxy_BeforeSharePreview()
	{
	}

	public void _003C_003EiFixBaseProxy_AfterSharePreview()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public bool _003C_003EiFixBaseProxy_ClosedByEsc()
	{
		return false;
	}
}
