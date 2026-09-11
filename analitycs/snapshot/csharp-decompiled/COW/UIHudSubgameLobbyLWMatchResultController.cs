using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UMA;
using UnityEngine;

namespace COW;

public class UIHudSubgameLobbyLWMatchResultController : UIBaseController
{
	private sealed class _003C_003Ec__DisplayClass29_0
	{
		public UIHudSubgameLobbyLWMatchResultController _003C_003E4__this;

		public uint capturedVersion;

		internal void _003COnBGPrefabLoaded_003Eb__0(GameObject go)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass36_0
	{
		public bool isWinner;

		public UIHudSubgameLobbyLWMatchResultController _003C_003E4__this;

		public uint capturedVersion;

		public Transform parent;

		public EPPlayerInfo epInfo;

		public AvatarManager.JEGKOJDIKEL avatarData;

		public bool isOpponent;

		internal void _003CCreateResultAvatar_003Eb__0(AvatarManager avatar)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass37_0
	{
		public UIHudSubgameLobbyLWMatchResultController _003C_003E4__this;

		public AvatarManager avatar;

		internal void _003CUpdateResultAvatar_003Eb__0(UMAData umaData)
		{
		}
	}

	private sealed class _003CCountdownCoroutine_003Ed__49 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudSubgameLobbyLWMatchResultController _003C_003E4__this;

		private int _003Cremaining_003E5__2;

		private string _003Cstr_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCountdownCoroutine_003Ed__49(int _003C_003E1__state)
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

	private sealed class _003CLoopResultAnimation_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AvatarManager avatar;

		public UIHudSubgameLobbyLWMatchResultController _003C_003E4__this;

		private Animator _003Canim_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CLoopResultAnimation_003Ed__38(int _003C_003E1__state)
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

	private sealed class _003CUpdateResultAvatar_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudSubgameLobbyLWMatchResultController _003C_003E4__this;

		public AvatarManager avatar;

		private _003C_003Ec__DisplayClass37_0 _003C_003E8__1;

		public EPPlayerInfo epInfo;

		public bool isWinner;

		public AvatarManager.JEGKOJDIKEL avatarData;

		public bool isOpponent;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CUpdateResultAvatar_003Ed__37(int _003C_003E1__state)
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

	private UIHudReportNewController m_ReportWnd;

	private UIHudSubgameLobbyLWMatchResultView m_View;

	private AvatarManager m_WinnerAvatar;

	private AvatarManager m_LoserAvatar;

	private bool m_IsWin;

	private BHGGAEEHJCO m_OpponentPlayerID;

	private LobbyLWOpponentInfo m_OpponentInfo;

	private GameObject m_ShowBGRootGO;

	private Camera m_ResultBGCamera;

	private bool m_HudAndLobbyWasVisible;

	private Coroutine m_CountdownCoroutine;

	private bool m_AddFriendSent;

	private uint m_BGLoadTicket;

	private bool m_BGAsyncPending;

	private uint m_BGRequestVersion;

	private uint m_WinnerAvatarTicket;

	private uint m_LoserAvatarTicket;

	private uint m_WinnerAvatarVersion;

	private uint m_LoserAvatarVersion;

	private uint LocalStreak;

	private static readonly int OutLineWidthPropertyId;

	private bool m_InviteTipRegistered;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void RegisterInviteTip()
	{
	}

	private void UnregisterInviteTip()
	{
	}

	private void OnInviteTip(object[] data)
	{
	}

	public void ShowResult(bool isWin, BHGGAEEHJCO opponentPlayerID, LobbyLWOpponentInfo opponentInfo = null)
	{
	}

	private void CreateResultBG()
	{
	}

	private void OnBGPrefabLoaded(uint ticket, bool success, UnityEngine.Object obj)
	{
	}

	private void OnBGInstantiated(GameObject go, uint requestVersion)
	{
	}

	private void DestroyResultBG()
	{
	}

	private void HideHud()
	{
	}

	private void RestoreHud()
	{
	}

	private void SetupAvatarCamera()
	{
	}

	private void CreateAvatars()
	{
	}

	private void CreateResultAvatar(Transform parent, BHGGAEEHJCO playerID, bool isOpponent, bool isWinner)
	{
	}

	private IEnumerator UpdateResultAvatar(AvatarManager avatar, EPPlayerInfo epInfo, AvatarManager.JEGKOJDIKEL avatarData, bool isOpponent, bool isWinner)
	{
		return null;
	}

	private IEnumerator LoopResultAnimation(AvatarManager avatar)
	{
		return null;
	}

	private static void ClampResultAvatarToonOutline(AvatarManager avatar)
	{
	}

	private static bool IsResultAvatarToonOutlineMaterial(Material material)
	{
		return false;
	}

	private EPPlayerInfo BuildEPPlayerInfo(BHGGAEEHJCO playerID, AvatarManager.JEGKOJDIKEL avatarData)
	{
		return null;
	}

	private AvatarManager.JEGKOJDIKEL GetAvatarDataByPlayerID(BHGGAEEHJCO playerID)
	{
		return null;
	}

	private static void SetLayerRecursivelyAll(GameObject obj, int layer)
	{
	}

	private void PositionAddFriendAboveAvatar(AvatarManager avatar)
	{
	}

	private void PositionContainerAboveAvatar(GameObject container, AvatarManager avatar)
	{
	}

	private void DestroyAvatars()
	{
	}

	private void DisableAvatarCamera()
	{
	}

	private void StartCountdown()
	{
	}

	private IEnumerator CountdownCoroutine()
	{
		return null;
	}

	private void StopCountdown()
	{
	}

	private void RefreshStreakContainers()
	{
	}

	private void RefreshStreakLabels()
	{
	}

	private void RefreshAddFriendVisible()
	{
	}

	private bool TryGetOpponentSnapshot(out string nickName, out ulong userID, out string lockRegion)
	{
		nickName = null;
		userID = default(ulong);
		lockRegion = null;
		return false;
	}

	private void OnReportBtnClick()
	{
	}

	private void CloseReportPopup()
	{
	}

	private void OnReportConfirmed()
	{
	}

	private void OnClickAddFriend()
	{
	}

	private void OnClickBack()
	{
	}

	private void OnClickKeep()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}
}
