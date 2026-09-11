using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIPortraitCloseupController : UITakePhotoGroupBaseController, IEasyList, IUIModelDataChangeObserver, ITakePhotoSettingObserver
{
	private sealed class _003CDelayRefreshAnchors_003Ed__79 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIPortraitCloseupController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDelayRefreshAnchors_003Ed__79(int _003C_003E1__state)
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

	private bool IsFirstNavigationShow;

	private UIHudPetAnimLobbyController m_PetAnimController;

	private UIModelTakePhoto m_ModelTakePhoto;

	private UITakePhotoSettingController m_SettingWnd;

	public bool ShowBackpack;

	public bool ShowWeapon;

	public bool ShowPet;

	private Vector3 Vertical3DCameraLocalPos;

	private Vector3 Vertical3DCameraDefaultWorldPos;

	private bool Vertical3DCameraDefaultWorldPosIsCalc;

	private GameObject Vertical3DCameraGo;

	private uint GroupPhotoTemplateId;

	private UITakePhotoGroupTemplateVerticalController m_PhotoTemplateCtrl;

	private UIEmoteShowPanelController m_EmotePanelController;

	private UIPortraitCloseupView m_View;

	private UIAnchor[] m_UIAnchors;

	private Coroutine m_RefreshAnchorsCoroutine;

	private bool m_IsZoomIn;

	private bool m_IsMoving;

	private AvatarCameraMoveComp m_AvatarMoveComp;

	private Vector3 m_ProfilePageCamPos;

	private float m_ProfilePageBGSize;

	private float m_ZoomInBgSize;

	private float m_ZoomOutBgSize;

	private Vector3 m_ZoomInCamPos;

	private Vector3 m_ZoomOutCamPos;

	private const string ZOOMINICON = "UI_Icon_zoomin";

	private const string ZOOMOUTICON = "UI_Icon_zoomout";

	private const float MOVE_DURATION = 0.8f;

	private bool IsGroupState;

	private UIHudCameraOperationBtnOutInGameController m_CameraOpCtrl;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void InitView()
	{
	}

	public bool GetIsGroupState()
	{
		return false;
	}

	protected override void OnUIOpen()
	{
	}

	public override List<string> GetNeedShowUI3dObjectNames()
	{
		return null;
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	public override void OnNavigationClosed()
	{
	}

	public void SetNeedPlayEnterTeamAnim()
	{
	}

	private void OnFilterBtnClick()
	{
	}

	protected override void ShowFilterWnd()
	{
	}

	public override void HideFilterIsOpen()
	{
	}

	private void OnSettingBtnClick()
	{
	}

	private void OnExitBtnClick()
	{
	}

	public override void BeforeScreenshot()
	{
	}

	public override void AfterScreenshot()
	{
	}

	private GameObject GetBgObj()
	{
		return null;
	}

	private GameObject GetCamObj()
	{
		return null;
	}

	private void OnShowAvatarEmotePanel(object[] data)
	{
	}

	private void OnGroupBtnClick()
	{
	}

	private void RefreshState()
	{
	}

	protected override void OnUIClose()
	{
	}

	public void OnFirstRefreshTemplateList()
	{
	}

	protected override void OnDestroy()
	{
	}

	public override void OnSelectTemplate(GroupPhotoTemplateData templateData)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	protected override string GetExpandFriendAnim(bool isIn)
	{
		return null;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	protected override void OnTakePhotoBtnClick(object[] objects)
	{
	}

	public bool IsTakePhotoState()
	{
		return false;
	}

	public void OnPetSettingBtn()
	{
	}

	public void OnPlayerNameSettingBtn()
	{
	}

	public void OnTeammateSettingBtn()
	{
	}

	public void OnWeaponSettingBtn()
	{
	}

	public void OnBackpakSettingBtn()
	{
	}

	public void HideSettingIsOpen()
	{
	}

	public bool IsShowTeammate()
	{
		return false;
	}

	public bool IsShowPlayerName()
	{
		return false;
	}

	public bool IsShowBackpack()
	{
		return false;
	}

	public bool IsShowWeapon()
	{
		return false;
	}

	public bool IsShowPet()
	{
		return false;
	}

	public Camera GetVerticalCamera()
	{
		return null;
	}

	public float GetVerticalCameraDefaultX()
	{
		return 0f;
	}

	private void OnPetShowActionClick(object[] data)
	{
	}

	private void OnPetHideActionPanel()
	{
	}

	private void OnScreenResizeRefreshAnchors()
	{
	}

	private IEnumerator DelayRefreshAnchors()
	{
		return null;
	}

	private void _003COnUIInit_003Eb__32_0()
	{
	}

	private void _003COnUIInit_003Eb__32_1()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public List<string> _003C_003EiFixBaseProxy_GetNeedShowUI3dObjectNames()
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	public void _003C_003EiFixBaseProxy_ShowFilterWnd()
	{
	}

	public void _003C_003EiFixBaseProxy_HideFilterIsOpen()
	{
	}

	public new void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	public new void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnSelectTemplate(GroupPhotoTemplateData P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnTakePhotoBtnClick(object[] P0)
	{
	}
}
