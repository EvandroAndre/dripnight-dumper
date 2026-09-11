using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay.UGCRuntime;
using COW.Gameplay.UGC;
using GCommon;

namespace COW;

internal class UIUGCCommonInGameScene : UIInGameScene
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__19_1;

		internal void _003COnShowDownloadPopup_003Eb__19_1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass19_0
	{
		public UIUGCCommonInGameScene _003C_003E4__this;

		public UGCSimpleDownloadTask ugcDownloadTask;

		public UIModelOptionalDownload modelOptionalDwonload;

		public List<ResourceID> target_id;

		public bool downloadAllResOfGameMode;

		public object[] data;

		public Action _003C_003E9__6;

		public EventDelegate.Callback _003C_003E9__7;

		internal void _003COnShowDownloadPopup_003Eb__2()
		{
		}

		internal void _003COnShowDownloadPopup_003Eb__3()
		{
		}

		internal void _003COnShowDownloadPopup_003Eb__6()
		{
		}

		internal void _003COnShowDownloadPopup_003Eb__7()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass19_1
	{
		public ResDownloadType resType;

		public UISecondConfirmContoller confirmWnd;

		public UIModelMapOpeningInfo modelMap;

		public _003C_003Ec__DisplayClass19_0 CS_0024_003C_003E8__locals1;

		public Action _003C_003E9__5;

		internal void _003COnShowDownloadPopup_003Eb__0()
		{
		}

		internal void _003COnShowDownloadPopup_003Eb__4()
		{
		}

		internal void _003COnShowDownloadPopup_003Eb__5()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass26_0
	{
		public UIUGCCommonInGameScene _003C_003E4__this;

		public ulong user_id;

		internal void _003CShowInviteFriendInfoByUGC_003Eb__0()
		{
		}
	}

	private sealed class _003COpenCommonHud_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIUGCCommonInGameScene _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003COpenCommonHud_003Ed__9(int _003C_003E1__state)
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

	private UIUGCBridgingGameScene m_UGCBridgingGameScene;

	private uint m_HideCSShopDelayCallID;

	private IUGCModuleArchTypeMgr m_ArchTypeMgr;

	private UIHudUGCPremiumCenterController m_UIPremiumCenter;

	private UIUGCHudInternalPurchaseController m_UIInternalPurchase;

	public UIHudUGCDebuggerController UGCDebugHudUI;

	public override UIUGCBridgingGameScene GetUIUGCScene()
	{
		return null;
	}

	protected override Type GetMatchResultType()
	{
		return null;
	}

	protected override IEnumerator OpenCommonHud()
	{
		return null;
	}

	protected override bool IsObserverEnabled()
	{
		return false;
	}

	public override void RegisterGameEventHandler()
	{
	}

	public override void Destory()
	{
	}

	public IUIHUDBaseController FindInternalHudByType(Type type)
	{
		return null;
	}

	private void OnStartNewPhase(object[] param)
	{
	}

	private void OnStartNewRound(object[] data)
	{
	}

	private void OnShowShopBuyRes(object[] data)
	{
	}

	private void OnUGCPremiumCenterState(object[] data)
	{
	}

	private void OnUGCCommerceIAPState(bool state)
	{
	}

	private void OnShowDownloadPopup(object[] data)
	{
	}

	private void DispatchOptionalDownloadPopupEvent(EventID eventID, UGCSimpleDownloadTask ugcDownloadTask)
	{
	}

	private void StartUGCDownloadTaskInGame(UGCSimpleDownloadTask ugcDownloadTask)
	{
	}

	private void OnMatchEndShowResult(object[] data)
	{
	}

	protected override bool IsNeedSafeZoneInfoController()
	{
		return false;
	}

	protected override bool IsNeedDirectionRuler()
	{
		return false;
	}

	public void ClearAllCustomHud()
	{
	}

	public void ShowInviteFriendInfoByUGC(ulong user_id)
	{
	}

	private void ShowInviteFriendMessage(ulong user_id)
	{
	}

	private void OnAddFriendAcceptInvite(UIHUDUGC_CommonChooseBoxController ctrl)
	{
	}

	private void OnAddFriendDisAgreeInvite(UIHUDUGC_CommonChooseBoxController ctrl)
	{
	}

	private void OnAddFriendToggleChange(UIHUDUGC_CommonChooseBoxController ctrl)
	{
	}

	protected override void OnGameVoiceHudCreated()
	{
	}

	private IEnumerator _003C_003En__0()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_RegisterGameEventHandler()
	{
	}

	public IEnumerator _003C_003EiFixBaseProxy_OpenCommonHud()
	{
		return null;
	}

	public UIUGCBridgingGameScene _003C_003EiFixBaseProxy_GetUIUGCScene()
	{
		return null;
	}

	public Type _003C_003EiFixBaseProxy_GetMatchResultType()
	{
		return null;
	}

	public bool _003C_003EiFixBaseProxy_IsObserverEnabled()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_Destory()
	{
	}

	public bool _003C_003EiFixBaseProxy_IsNeedSafeZoneInfoController()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_IsNeedDirectionRuler()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnGameVoiceHudCreated()
	{
	}
}
