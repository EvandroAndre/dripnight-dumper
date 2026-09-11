using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class UISettingController : UIPopupWindowController, IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__46_0;

		public static Action _003C_003E9__64_0;

		public static Action _003C_003E9__64_1;

		internal void _003COnLogoutButtonClick_003Eb__46_0()
		{
		}

		internal void _003CSetControllerCursorEvent_003Eb__64_0()
		{
		}

		internal void _003CSetControllerCursorEvent_003Eb__64_1()
		{
		}
	}

	private sealed class _003CSettingDelayCoroutine_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UISettingController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CSettingDelayCoroutine_003Ed__39(int _003C_003E1__state)
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

	private UISettingView m_View;

	private List<UISettingTabButton> m_TabButtons;

	private bool isInGame;

	public bool m_WeaponPowerLeaderBoardPrivacyHide;

	public bool m_DisableFriendSpectate;

	public ulong m_StartShowTime;

	private UIModelLogin m_LoginModel;

	private UIModelSetting m_ModelSetting;

	private UIModelOTP m_ModelOTP;

	private EventLogger.EventAutoPickUpSettingChangeLog m_AutoPickUpLog;

	private UIInGameSettingController m_InGameCtrl;

	private UIDebugInfoController m_debuginfoController;

	private UIBasicSettingController m_BasicSettingController;

	private UISoundSettingController m_SoundSettingController;

	private UINotificationSettingController m_NotificationSettingController;

	private UIGraphicSettingController m_GraphicSettingController;

	private UIUGCSettingController m_UGCSettingController;

	private UIReplayKitSettingController m_ReplayKitSettingController;

	private UIFPPSettingController m_FPPSettingController;

	private SettingPageType m_PreSettingType;

	private UINewKeyActionSettingController m_KeyActionSettingController;

	private UISettingContentBase m_CurrentShowContent;

	private string m_SettingMD5;

	private bool m_RecommendBindOTP;

	private uint m_SettingDelayCallId;

	public string SettingMD5 => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public static bool DontDestroy()
	{
		return false;
	}

	public override bool RecyleDontDestroy()
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	public override void OnUIReInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	private void CancelSettingDelayCall()
	{
	}

	private void ResetSettingState()
	{
	}

	private void ResetRuntimeToggledViewState()
	{
	}

	private void ResetTabButtonSelection()
	{
	}

	public override void OnRecyle()
	{
	}

	private void DoSettingInit()
	{
	}

	private IEnumerator SettingDelayCoroutine()
	{
		return null;
	}

	private void InitNotifications()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnCloseSetting(object[] param)
	{
	}

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	private void OnCloseClick()
	{
	}

	private void OnQuitButtonClick()
	{
	}

	private void OnLogoutButtonClick()
	{
	}

	private void OnLogoutAllDeviceBtnClick()
	{
	}

	private void OnLogoutCurDeviceBtnClick()
	{
	}

	private bool IsNeedShowLogOutAllDevice()
	{
		return false;
	}

	protected override void OnUIClose()
	{
	}

	private void RunOnCloseSideEffects(bool fromRecyle)
	{
	}

	private UISettingContentBase GetContent(SettingPageType settingType)
	{
		return null;
	}

	private void OnTopTabClick(SettingPageType settingType)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public override bool NeedSetLobbyObjectVisibleState()
	{
		return false;
	}

	public void SetInGameShow(bool isIngame, int jumpIndex = -1, int jumpSubIndex = -1)
	{
	}

	private void SetShownSetting(SettingPageType typeIndex, int jumpSubIndex = -1)
	{
	}

	public void ShowNetworkSetting()
	{
	}

	public void ScrollToNetworkSetting()
	{
	}

	public void ShowGraphicSetting()
	{
	}

	public void SoundSettingScrollLastPos()
	{
	}

	public void ShowRecommendLowGraphic()
	{
	}

	protected override void SetControllerCursorEvent(Action OnShow, Action OnHideOrDestory)
	{
	}

	private void InitSoundSettingRedTips()
	{
	}

	private void RefreshSoundSettingRedTips()
	{
	}

	public override int MinGroupDepth()
	{
		return 0;
	}

	private void _003CDoSettingInit_003Eb__38_0()
	{
	}

	private void _003CDoSettingInit_003Eb__38_1()
	{
	}

	private void _003COnLogoutAllDeviceBtnClick_003Eb__47_0()
	{
	}

	public bool _003C_003EiFixBaseProxy_RecyleDontDestroy()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIReInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnRecyle()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public bool _003C_003EiFixBaseProxy_NeedSetLobbyObjectVisibleState()
	{
		return false;
	}

	public int _003C_003EiFixBaseProxy_MinGroupDepth()
	{
		return 0;
	}
}
