using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;
using message;
using proto;

namespace COW;

public class UIInGameBattleBoardController : UIBaseController
{
	private sealed class _003C_003Ec__DisplayClass37_0
	{
		public int subType;

		internal bool _003CSetCDNView_003Eb__0(AdvertDesc e)
		{
			return false;
		}
	}

	private sealed class _003COnRenderFinished_003Ed__47 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIInGameBattleBoardController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003COnRenderFinished_003Ed__47(int _003C_003E1__state)
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

	private sealed class _003COnRenderRightFinished_003Ed__48 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIInGameBattleBoardController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003COnRenderRightFinished_003Ed__48(int _003C_003E1__state)
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

	private sealed class _003CRerenderAvatar_003Ed__52 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIInGameBattleBoardController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRerenderAvatar_003Ed__52(int _003C_003E1__state)
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

	private sealed class _003CRerenderRightAvatar_003Ed__54 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIInGameBattleBoardController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRerenderRightAvatar_003Ed__54(int _003C_003E1__state)
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

	private sealed class _003CUpdatePlayerAvatar_003Ed__55 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIInGameBattleBoardController _003C_003E4__this;

		public BLLDAKAPAJK mVPBoardData;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CUpdatePlayerAvatar_003Ed__55(int _003C_003E1__state)
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

	private sealed class _003CUpdateRightPlayerAvatar_003Ed__56 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIInGameBattleBoardController _003C_003E4__this;

		public BLLDAKAPAJK mVPBoardData;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CUpdateRightPlayerAvatar_003Ed__56(int _003C_003E1__state)
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

	private UIInGameBattleBoardView m_View;

	private BHGGAEEHJCO m_PlayerID;

	private CIJPLNEAIIH m_LastPhase;

	private InGameBattleBoardManager.BoardShowType m_CurrentBoardType;

	private BIDLODNPDCB m_CurrentTeamBoardData;

	private const int MAX_SINGLE_PLAYER_DATA_COUNT = 4;

	private const int MAX_COMPARE_PLAYER_DATA_COUNT = 3;

	private GameObject[] m_SinglePlayerContainers;

	private UILabel[] m_SinglePlayerLabels;

	private UILabel[] m_SinglePlayerCntLabels;

	private GameObject[] m_ComparePlayerContainers;

	private UILabel[] m_ComparePlayerLabels;

	private UILabel[] m_ComparePlayerLeftLabels;

	private UILabel[] m_ComparePlayerRightLabels;

	private RenderTexture m_BattleBoardRT;

	private Texture2D m_BattleBoardMvp;

	private Texture2D m_BattleBoardRightMvp;

	private Camera m_AvatarCamera;

	private AvatarManager m_AvatarManager;

	private AvatarManager m_AvatarRightManager;

	private bool m_IsRendering;

	private bool m_IsRightRendering;

	private bool m_ShowAvatar;

	private IEnumerator m_BuildCoroutine;

	private IEnumerator m_BuildRightCoroutine;

	private BLLDAKAPAJK m_RightMVPData;

	private uint m_HideDelayCall;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void InitUIContainers()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void ChangePos()
	{
	}

	private void OnNewPhaseStarted(object[] data)
	{
	}

	public void BindPlayerAndBoardData(BHGGAEEHJCO player_id)
	{
	}

	public void ClearData()
	{
	}

	private void ShowBattleBoard()
	{
	}

	private void UpdateBattleBoardInfo()
	{
	}

	private void SetCDNView(int subType)
	{
	}

	private string GetMVPContentValue(BLLDAKAPAJK mvpData, int contentType)
	{
		return null;
	}

	private string GetMVPContentTypeName(int contentType)
	{
		return null;
	}

	private void ShowSelfMvpBoard()
	{
	}

	private void ShowCompareMvpBoard()
	{
	}

	private void InitAvatarDisplay()
	{
	}

	private void InitBattleBoardRenderTexture(int width, int height)
	{
	}

	private void InitBattleBoardRightRenderTexture(int width, int height)
	{
	}

	private void OnBattleBoardRerender()
	{
	}

	private void OnBattleBoardRerenderRight()
	{
	}

	private IEnumerator OnRenderFinished()
	{
		return null;
	}

	private IEnumerator OnRenderRightFinished()
	{
		return null;
	}

	private void RefreshAvatar(BLLDAKAPAJK mVPBoardData)
	{
	}

	private void RefreshRightAvatar(BLLDAKAPAJK mVPBoardData)
	{
	}

	private void RerenderAfterUMAChanged()
	{
	}

	private IEnumerator RerenderAvatar()
	{
		return null;
	}

	private void RerenderAfterRightUMAChanged()
	{
	}

	private IEnumerator RerenderRightAvatar()
	{
		return null;
	}

	private IEnumerator UpdatePlayerAvatar(BLLDAKAPAJK mVPBoardData)
	{
		return null;
	}

	private IEnumerator UpdateRightPlayerAvatar(BLLDAKAPAJK mVPBoardData)
	{
		return null;
	}

	public void PlayAnim(bool isIn)
	{
	}

	private void _003CPlayAnim_003Eb__57_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
