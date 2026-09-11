using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHDStandLobbyManager : MonoBehaviour, IUIModelDataChangeObserver
{
	public enum HDLobbyState
	{
		Lobby = 0,
		Yard = 1,
		WeaponRack = 2,
		VehicleDisplay = 3,
		IceDisplay = 4,
		SkyboardDisplay = 5,
		Others = 999
	}

	public enum HDDefaultItemType
	{
		Item = 1,
		Skin
	}

	private sealed class _003CLobbyEnter_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHDStandLobbyManager _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CLobbyEnter_003Ed__34(int _003C_003E1__state)
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

	private GameObject _root;

	private UIHDWeaponRack m_WeaponRack;

	private UIHDCarDisplay m_CarDisplay;

	private UIHDIceWallDisplay m_IceWallDisplay;

	private UIHDSkyboardDisplay m_SkyBoardDisplay;

	private Transform m_FloorVFXRoot;

	private Transform m_BehindSkyRoot;

	private Transform m_FloorLaceVFXRoot;

	private Transform m_LobbyLEDScreenVFXRoot;

	private bool m_LobbyShow;

	private bool m_FirstEnter;

	private Vector3 m_deltaPosition;

	private Vector3 m_avatarLocalPosition;

	private Animator m_CameraAnimator;

	private bool m_IsCameraMoving;

	public static bool IsStartToCloseUI;

	public static HDLobbyState CurrentState;

	private float m_ShadowDistance;

	public const float LOBBYSHADOWDISTANCE = 5f;

	public const float LOBBY_DISPLAY_ITEM_SHADOW_DISTANCE = 7f;

	private ResourceID m_currentFloorVFx;

	private UIModelGroup m_ModelGroup;

	private GameObject m_HindSkyObj;

	private GameObject m_FloorLaceVFXObj;

	private GameObject m_LobbyLEDScreenVFXObj;

	private Renderer FloorRender;

	private const string FLOOR_MATERIAL_NAME = "UIFX_HD_LOBBY_Logo (Instance)";

	private bool m_HideForGroupAnim;

	private ulong m_GroupBgAccountId;

	private void Awake()
	{
	}

	private void ReplaceFloorLogo()
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnLobbyEnter(object[] data)
	{
	}

	private IEnumerator LobbyEnter()
	{
		return null;
	}

	private void OnLobbyControllerVisibleChanged(object[] data)
	{
	}

	private void OnLobbyVisibleChangedForGroupAnim(object[] data)
	{
	}

	private void OnLobbyVisibleChanged(object[] data)
	{
	}

	private void OnLobbyYardVisibilityChanged(object[] data)
	{
	}

	private void OnWeaponRackUIOpen(object[] data)
	{
	}

	private void OnWeaponRackUINavigationShow(object[] data)
	{
	}

	private void OnVehicleDisplayUIOpen(object[] data)
	{
	}

	private void OnIceDisplayUIOpen(object[] data)
	{
	}

	private void OnSkyboardDisplayUIOpen(object[] data)
	{
	}

	private void OnLobbyItemClose(object[] data)
	{
	}

	private void OnVehicleDisplayUINavigationShow(object[] data)
	{
	}

	private void OnIceDisplayUINavigationShow(object[] data)
	{
	}

	private void OnSkyboardDisplayUINavigationShow(object[] data)
	{
	}

	private void OnMallEnter(object[] data)
	{
	}

	private void OnCameraMoveEnd(object[] data)
	{
	}

	private void OnBeginToLeaveWeaponUI(object[] data)
	{
	}

	private void OnBeginToLeaveCarPlatUI(object[] data)
	{
	}

	private void OnBeginToLeaveIcePlatUI(object[] data)
	{
	}

	private void OnBeginToLeaveSkyboardPlatUI(object[] data)
	{
	}

	private void ResetToLobbyState()
	{
	}

	public bool IsCameraAnimatorEnabled()
	{
		return false;
	}

	private void MoveIdleEnterGroup(object[] data)
	{
	}

	private void ResetLobbyIdle(object[] data)
	{
	}

	private void OnEnterCaptainLobby(object[] data)
	{
	}

	private void OnLeaveCaptainLobby(object[] data)
	{
	}

	public ResourceID GetHDLobbyFloorRes()
	{
		return default(ResourceID);
	}

	public ResourceID GetHDLobbyHindSkyRes()
	{
		return default(ResourceID);
	}

	private void OnMaxLobbyResUpdate()
	{
	}

	private Vector3 ParseVector3String(string str, Vector3 defaultValue)
	{
		return default(Vector3);
	}

	private void SetLobbySkin()
	{
	}

	private void SetLobbyScreenVFX()
	{
	}

	private void SetLobbyFloorLaceVFX()
	{
	}

	private void SetLineColor()
	{
	}

	private void OnClothesChange(object[] data)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDownloadSucc(ResultTextureInfo resultInfo)
	{
	}

	public void OnDownloadFailed(CDNDownloadFailedInfo info)
	{
	}

	private void _003CReplaceFloorLogo_003Eb__30_0(ResultTextureInfo resultInfo)
	{
	}
}
