using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIEVOGunPrevieweController : UIPrivilegePreviewController, IUIModelDataChangeObserver
{
	public enum WeaponRotateType
	{
		None,
		NaviToDetail,
		DetailToNavi
	}

	private sealed class _003C_003Ec__DisplayClass49_0
	{
		public object[] param;

		public UIEVOGunPrevieweController _003C_003E4__this;

		public SkinOwnAndOpenInfo curSkinOwnAndOpenInfo;

		public UIEvoGunMainController p;

		internal void _003COnDataChanged_003Eb__0()
		{
		}
	}

	private sealed class _003CRotateWeaponByChangePage_003Ed__45 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIEVOGunPrevieweController _003C_003E4__this;

		public Action<bool> callBack;

		private Quaternion _003CstartAngle_003E5__2;

		private Quaternion _003CendAngle_003E5__3;

		private Vector3 _003CstartScale_003E5__4;

		private Vector3 _003CendScale_003E5__5;

		private Vector3 _003CstartLocalPosition_003E5__6;

		private Vector3 _003CendLocalPosition_003E5__7;

		private float _003Ctime_003E5__8;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRotateWeaponByChangePage_003Ed__45(int _003C_003E1__state)
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

	protected new UIEVOGunPreviewView m_View;

	private WeaponSkinFeature m_CurrentFeature;

	private WeaponSkinFeature m_LastFeature;

	private GameObject m_UpgradeEfx;

	private UIWeaponKillNotificationItemController m_AnnouncementObj;

	private SkinOwnAndOpenInfo m_SkinOwnAndOpenInfo;

	private UIEvoGunMainController m_MainController;

	private Coroutine m_RotateWeaponByChangePageCoroutine;

	private WeaponRotateType m_WeaponRotateType;

	private bool m_IsSpecialToggle;

	private bool? m_IsDuringFullAni;

	private bool m_OpenFullScreenPreview;

	private float PREVIEW_ITEM_POSX;

	private const float PREVIROTATE_RATE = 0.5f;

	private Vector3 DEFAULT_WEAPON_POSITION;

	private float ITEM_CAMERA_DEPTH;

	protected override bool UseEvoGunSightReskinPreviewScale => false;

	private UIEvoGunMainController MainPageController => null;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void RefreshPreview(int wpSKinFeature, bool isSpecialToggle = true)
	{
	}

	public void ShowViewByNavi()
	{
	}

	public void SetSkinAndOwnOpenInfo(SkinOwnAndOpenInfo info)
	{
	}

	public void SetItemCameraState(bool isShow)
	{
	}

	public void HidePreview()
	{
	}

	public void ShowFullScreenPreview()
	{
	}

	public void SetWeaponRotateType(UIEvoGunPageState fromPage, UIEvoGunPageState toPage)
	{
	}

	protected override void SetAvatarPos()
	{
	}

	private void ResetWeaponTransFromPageState()
	{
	}

	private void OnBtnPlayEmoteClick()
	{
	}

	private void SetDefaultUIState()
	{
	}

	private void ProcessDefaultWeaponObjectByPageChange(ref Vector3 lastWeaponPos, ref Quaternion lastWeaponRotation, ref Vector3 lastWeaponScale)
	{
	}

	private bool IsSameSkinIDByPageChange()
	{
		return false;
	}

	protected override void SetKillNotifyContainer()
	{
	}

	protected override void OnRefreshFeatureView(uint weaponSkinID, WeaponSkinFeature weaponSkinFeature)
	{
	}

	private void SetIsDuringFullAnim(bool show)
	{
	}

	private void OnRefreshEventTrigger(object[] data)
	{
	}

	private void SetPreviewObjVisible()
	{
	}

	protected override void PlayFireSound()
	{
	}

	public void ShowPreviewItem(bool showPreviewItem, bool showUpgradeEfx, bool forceSkipAnim = false)
	{
	}

	private IEnumerator RotateWeaponByChangePage(Action<bool> callBack)
	{
		return null;
	}

	private bool HasWeaponWithFullAnim(SkinOwnAndOpenInfo skinOwndAndOpenInfo)
	{
		return false;
	}

	private bool IsWeaponMode(WeaponSkinFeature skinFeature)
	{
		return false;
	}

	private bool NeedRotateWeaponByPageChange()
	{
		return false;
	}

	public override void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public override bool IsLoopKillNotify()
	{
		return false;
	}

	public override uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	protected override FrontendPreviewType GetPreviewUIType()
	{
		return FrontendPreviewType.Lobby;
	}

	public bool _003C_003EiFixBaseProxy_get_UseEvoGunSightReskinPreviewScale()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_SetAvatarPos()
	{
	}

	public void _003C_003EiFixBaseProxy_SetKillNotifyContainer()
	{
	}

	public void _003C_003EiFixBaseProxy_OnRefreshFeatureView(uint P0, WeaponSkinFeature P1)
	{
	}

	public void _003C_003EiFixBaseProxy_PlayFireSound()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDataChanged(UIBaseModel P0, uint P1, object[] P2)
	{
	}

	public bool _003C_003EiFixBaseProxy_IsLoopKillNotify()
	{
		return false;
	}

	public uint _003C_003EiFixBaseProxy_GetInterestedPropID(UIBaseModel P0)
	{
		return 0u;
	}

	public UIWidget _003C_003EiFixBaseProxy_GetFrontEndPreviewBorder()
	{
		return null;
	}

	public FrontendPreviewType _003C_003EiFixBaseProxy_GetPreviewUIType()
	{
		return FrontendPreviewType.Lobby;
	}
}
