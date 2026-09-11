using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UITakePhotoController : UIBaseController, ITakePhotoSettingObserver
{
	private sealed class _003CDelayRefreshAnchors_003Ed__72 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UITakePhotoController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDelayRefreshAnchors_003Ed__72(int _003C_003E1__state)
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

	private UIAnchor[] m_UIAnchors;

	private Coroutine m_RefreshAnchorsCoroutine;

	private uint m_PreBackpakItemId;

	private UIHudPetAnimLobbyController m_PetAnimController;

	private UITakePhotoEmoteListPanelController m_UITakePhotoEmoteListPanelController;

	public int BackpakCollectionId;

	public WeaponSkinData weaponSkinData;

	private UIAvatarWindowController m_AvatarWnd;

	public bool? ShowTeammate;

	public bool? ShowPlayerName;

	public bool? ShowBackpack;

	public bool? ShowWeapon;

	public bool? ShowPet;

	private UITakePhotoSettingController m_SettingWnd;

	private UITakePhotoView m_View;

	private UIHudCameraOperationBtnOutInGameController m_CameraOperationCtrl;

	private UIBaseNavigationController m_NavCtrl;

	private UIModelTakePhoto m_modelTakePhoto;

	private UIModelCollectionCustom m_ModelCollectionCustom;

	private UIMaleAvatar m_Avatar;

	private UITipsNormalController m_TipsCtrl;

	private UITakePhotoFilterController m_FilterCtrl;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public UIHudCameraOperationBtnOutInGameController GetCameraOpCtrl()
	{
		return null;
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	public void ResetAvatar(UIMaleAvatar avatar)
	{
	}

	public void SetAvatar(UIMaleAvatar avatar)
	{
	}

	private void OnVideoBtnEnd(int secs)
	{
	}

	private void OnVideoStart(object[] objects)
	{
	}

	private void OnTakePhotoBtnClick(object[] objects)
	{
	}

	private EventLogger.EEventTypeTakePhotoSource GetLogSource()
	{
		return EventLogger.EEventTypeTakePhotoSource.None;
	}

	private void OnGroupBtnClick()
	{
	}

	private void OnEmoteBtnClick()
	{
	}

	private void OnFilterBtnClick()
	{
	}

	private void ShowFilterWnd()
	{
	}

	private void OnCloseBtn()
	{
	}

	protected override void OnUIClose()
	{
	}

	private void OnPortraitCloseupBtnClick()
	{
	}

	public override void BeforeScreenshot()
	{
	}

	public override void AfterScreenshot()
	{
	}

	private void OnSettingBtnClick()
	{
	}

	public void HideSettingIsOpen()
	{
	}

	public void OnPlayerNameSettingBtn()
	{
	}

	public void OnTeammateSettingBtn()
	{
	}

	public void OnPetSettingBtn()
	{
	}

	public void OnWeaponSettingBtn()
	{
	}

	public void OnBackpakSettingBtn()
	{
	}

	private void RefreshBackpak(bool show, bool force = false)
	{
	}

	private void RefreshWeapon(bool show, bool force = false)
	{
	}

	public void SetAvatarWnd(UIAvatarWindowController avatarWindowController)
	{
	}

	protected override void OnDestroy()
	{
	}

	public void RefreshCameraOpCtrl()
	{
	}

	public void OnLobbyShow()
	{
	}

	public void OnLobbyHide()
	{
	}

	public void ClearFilter()
	{
	}

	public void RecoverFilter()
	{
	}

	public Vector3 GetQuitBtnPos()
	{
		return default(Vector3);
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

	public void SetVisibleEmotePanel(bool show)
	{
	}

	public void RefreshBackgroundTabRedDot()
	{
	}

	private void OnPetShowActionClick(object[] data)
	{
	}

	private void OnPetHideActionPanel()
	{
	}

	public void OnLocalAvatarPlayInviterDuoEmotion(EmoteData emoteData)
	{
	}

	public void OnUpdateAvatarByDownLoadAvatarAsset(bool beforeplayemote)
	{
	}

	public void HideFilterIsOpen()
	{
	}

	private void ShowFilterGuide()
	{
	}

	private void OnScreenResizeRefreshAnchors()
	{
	}

	private IEnumerator DelayRefreshAnchors()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	public void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}
}
