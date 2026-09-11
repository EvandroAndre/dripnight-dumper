using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudBotAgentMarkBtnController : UIBaseController
{
	private enum BtnState
	{
		Normal,
		Cancel,
		CancelActive
	}

	private enum QuestionShowConditionType
	{
		Static,
		DynamicTeammateDead
	}

	private sealed class _003CCheckAndHideUI_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudBotAgentMarkBtnController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCheckAndHideUI_003Ed__41(int _003C_003E1__state)
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

	private sealed class _003CTryCalPanelBounds_003Ed__55 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudBotAgentMarkBtnController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CTryCalPanelBounds_003Ed__55(int _003C_003E1__state)
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

	private UIHudBotAgentMarkBtnView m_View;

	private List<BotAgentQuestionItem> m_AskTemplates;

	private List<BotAgentQuestionItem> m_StaticQuestions;

	private Dictionary<int, List<BotAgentQuestionItem>> m_ConditionalQuestionsMap;

	private static readonly Dictionary<string, int> ACTION_SHOW_CONDITIONS;

	private FIGMILCIMAG m_AIDragCondition_LevelObject;

	private bool m_QuestionsInited;

	private UIClickMask m_ClickMask;

	private UserControlHandler m_LocalPlayerUserControlHandler;

	private bool m_IsPressed;

	private bool m_CanDrag;

	private float m_CurDragCD;

	private float m_TotalDragCD;

	private UIWidget m_Widget;

	private bool m_IsSpectating;

	private Vector3 m_PositionDragEnd;

	private LineRenderer m_Render;

	private Camera m_Camera;

	private Vector3[] m_PosList;

	private BtnState m_BtnState;

	private bool m_GlobalTouchEnd;

	private BotAgentPinMarkReceiver m_currPinMarkReceiver;

	private const int LABEL_MARGIN = 24;

	private float m_StartTime;

	private Vector3 m_BubblePos;

	private Vector3 m_TopLeftCtrlPanelPos;

	private Vector3 m_BottomLeftCtrlPanelPos;

	private Vector3 m_TopRightCtrlPanelPos;

	private Vector3 m_BottomRightCtrlPanelPos;

	private Vector3 m_CurrentCtrlPanelPos;

	private int m_Quadrant;

	private bool m_HasCalPanelBounds;

	private float m_NextValidManualTriggerTime;

	private float m_TotalManualCD;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void OnUIReInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnLocalPlayerDead(object[] data)
	{
	}

	private void EnterSpectatorMode()
	{
	}

	private void ExitSpectatorMode()
	{
	}

	private void OnLocalPlayerRevive(object[] data)
	{
	}

	private void TryAddClickMask()
	{
	}

	private void TryRemoveClickMask()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void TryInitQuestions()
	{
	}

	private int GetQuestionConditionType(string actionType)
	{
		return 0;
	}

	private void OnShowText(object[] args)
	{
	}

	protected IEnumerator CheckAndHideUI()
	{
		return null;
	}

	private void OnSettingBotAgentChanged()
	{
	}

	private void OnSettingBotAgentCSChanged()
	{
	}

	private void OnOneClick(GameObject go)
	{
	}

	private void UpdateAxisTouchingThroughArea()
	{
	}

	private void UpdateUIPos()
	{
	}

	private void CalCtrlPanelAndBubblePos()
	{
	}

	private IEnumerator TryCalPanelBounds()
	{
		return null;
	}

	private void UpdateAxisTouchingThroughAreaByVisibility(bool visible)
	{
	}

	private void OnDragStart(GameObject go)
	{
	}

	private void OnDragEnd(GameObject go)
	{
	}

	private void OnCloseBtnClick()
	{
	}

	private void OnVolumeSliderChange()
	{
	}

	private void RefreshUI()
	{
	}

	private void OnRouletteGlobalTouchEnd(object[] data)
	{
	}

	private void Update()
	{
	}

	private void UpdateRolette()
	{
	}

	private bool IsHoverSelf()
	{
		return false;
	}

	private void StopDrag()
	{
	}

	private void UpdateDragIconState(BtnState state)
	{
	}

	private void SetModeNameLabel()
	{
	}

	private void TryRequestMarkItem(Vector3 screenPos)
	{
	}

	private UserControlHandler GetLocalPlayerUserControlHandler()
	{
		return null;
	}

	private BotAgentPinMarkReceiver GetBotAgentPinMarkReceiver(Vector3 screenPos)
	{
		return null;
	}

	private uint GetTraceFlagWithCurrentGame()
	{
		return 0u;
	}

	private FIGMILCIMAG GetAIDragCondition_LevelObject()
	{
		return null;
	}

	public void OnItemClicked(string actionType)
	{
	}

	private bool IsInCD()
	{
		return false;
	}

	private void UpdateConditionalQuestions()
	{
	}

	private bool GetConditionState(int conditionType)
	{
		return false;
	}

	private bool CheckHasRevivableTeammate()
	{
		return false;
	}

	public void OnTutorialTrigger()
	{
	}

	public void StopTutorial()
	{
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
