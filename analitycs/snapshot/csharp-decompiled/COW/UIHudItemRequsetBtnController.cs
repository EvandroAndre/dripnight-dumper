using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;
using message;

namespace COW;

internal class UIHudItemRequsetBtnController : UIBaseController
{
	private enum BtnState
	{
		Normal,
		Cancel,
		CancelActive
	}

	private sealed class _003CTryOneClickCoroutine_003Ed__60 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudItemRequsetBtnController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CTryOneClickCoroutine_003Ed__60(int _003C_003E1__state)
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

	public const uint VISIBILITY_STATE_IIV1v1 = 1073741824u;

	public const uint VISIBILITY_STATE_GB_GPGulag = 536870912u;

	private UIHudItemMarkBtnView m_View;

	private LevelContainerBase m_CurrentTriggerContainer;

	private FHMPPFHPBND m_CurrentLTriggerContainer;

	private bool m_BtnClickCanUse;

	private float m_currentCD;

	private uint m_DelayCall;

	private Camera m_Camera;

	private LineRenderer m_render;

	private UIWidget m_BtnMarkWidget;

	private bool m_GlobalTouchEnd;

	private bool m_IsPressed;

	private Vector3 m_positionDragEnd;

	private float m_pressDealy;

	private float m_longPressDealy;

	private bool m_isPingEnemy;

	private bool m_waitOneClick;

	private Coroutine m_OneClickCoroutine;

	private UIHudPinMarkReceiver m_currPinMarkReceiver;

	private bool m_showGuide;

	private float m_switchPingEnemyTime;

	private Color m_PingNormalColor;

	private Color m_PingEnemyColor;

	private float m_MarkCD;

	private Vector3[] m_posList;

	private OPICPDCLKAG m_lastMarkTipObjType;

	private string m_lastMarkTipObjTypeName;

	private BtnState m_BtnState;

	private bool m_IsAutoEnemyMarkState;

	private Vector3 m_AutoEnemyMarkPos;

	private EILKGGIDJEH m_AutoEnemyMarkState;

	private float m_ExitAutoEnemyMarkStateTimeStamp;

	private bool m_PrevPingEnemy;

	private Camera GetCamera()
	{
		return null;
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override bool RecyleDontDestroy()
	{
		return false;
	}

	public static bool DontDestroy()
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	private void InitIsNewUI()
	{
	}

	public override void OnUIReInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void RefreshTeammateEighthIcon(uint PlayerID, uint iconType)
	{
	}

	private void RefreshEightInLandState()
	{
	}

	private void UpdateAxisTouchingThroughArea()
	{
	}

	private void OnEnterMarkItemCDTime(object[] param)
	{
	}

	private void OnRefreshMarkItemCD()
	{
	}

	private void OnAutoEnemyMarkEnterCD()
	{
	}

	private uint GetTraceFlagWithCurrentGame()
	{
		return 0u;
	}

	private void Update()
	{
	}

	private void OnRouletteGlobalTouchEnd(object[] data)
	{
	}

	private void UpdateRolette()
	{
	}

	private bool isHoverSelf()
	{
		return false;
	}

	private void UpdateDragIconState(BtnState state)
	{
	}

	private void OnDragEnd(Vector3 ScreenPos)
	{
	}

	private void StopDrag()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void OnDoubleClick(GameObject go)
	{
	}

	private void OnOneClick(GameObject go)
	{
	}

	private IEnumerator TryOneClickCoroutine()
	{
		return null;
	}

	private void CheckForGuideClick()
	{
	}

	private void CheckForGuidePress()
	{
	}

	private void TryRequestMarkItem(Vector3 startPos)
	{
	}

	private UIHudPinMarkReceiver GetPinMarkReceiver(Vector3 startPos)
	{
		return null;
	}

	private void TryRequestMarkItem()
	{
	}

	private void DoMark(BaseLevelObject baseLevelObject, Vector3 markPositon)
	{
	}

	private void DoMark(OGIJAGDFGAM lBaseLevelObject, Vector3 markPositon)
	{
	}

	private void SetPingEnemy(bool value, bool manual)
	{
	}

	private void TryShowItemGridWindow(LevelContainerBase container)
	{
	}

	private void TryShowItemGridWindow(FHMPPFHPBND lcontainer)
	{
	}

	private void RequestMarkItem(EMEFBBBEPDG itemMarkType, uint itemMarkId, uint levelObjectId, Vector3 position, bool isLocalOnlyVisible = false)
	{
	}

	private void OnEnterPickupArea(GEvent param)
	{
	}

	private void OnEnterLPickupArea(GEvent param)
	{
	}

	private void OnExitPickupArea(object[] param)
	{
	}

	private void OnExitLPickupArea(object[] param)
	{
	}

	private void OnPlayerBeHit(object[] data)
	{
	}

	private void OnLocalPlayerHitOthers(GEvent data)
	{
	}

	private void OnHitEnemyByServer(object[] data)
	{
	}

	private void OnCSShopHide(object[] data)
	{
	}

	private void OnEnterGameLanding(object[] data)
	{
	}

	private void StartGuide()
	{
	}

	private void StopGuide()
	{
	}

	private void OnOpenParachute(object[] data)
	{
	}

	private void OnPlayerStatsKnockDownChange(object[] param)
	{
	}

	private void ShowPopupMessage()
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

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
