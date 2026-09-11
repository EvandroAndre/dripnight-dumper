using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIPresetAgentController : UIBaseController
{
	private enum AgentState
	{
		Normal,
		Cancel,
		CancelActive
	}

	private sealed class _003C_003Ec__DisplayClass18_0
	{
		public UIPresetAgentController _003C_003E4__this;

		public PresetAgentPrompt data;

		internal void _003CShowAgentDefaultQuestion_003Eb__0(bool success, uint id, AudioClip clip)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass60_0
	{
		public UIPresetAgentController _003C_003E4__this;

		public PresetAgentPrompt data;

		internal void _003CPlayRecommendation_003Eb__0(bool success, uint id, AudioClip clip)
		{
		}
	}

	private UIPresetAgentView m_View;

	private EPresetAgentScene m_Scene;

	private UIPresetAgentBubbleController m_BubbleCtrl;

	private UIPresetAgentFastMessagePanelController m_WindowCtrl;

	private bool m_IsBubbleShow;

	private bool m_IsWindowShow;

	private UIClickMask m_ClickMask;

	private Camera m_Camera;

	private LineRenderer m_Render;

	private Vector3[] m_PosList;

	private AgentState m_AgentState;

	private bool m_CanDrag;

	private float m_CurDragCD;

	private float m_TotalDragCD;

	private bool m_IsPressed;

	private bool m_GlobalTouchEnd;

	private Vector3 m_PositionDragEnd;

	private EPresetDragInteractableItemType m_CurHoverItemType;

	private bool m_IsHoverScrollRegion;

	private object m_CurHoverItemData;

	private PresetAgentPinMarkReceiver m_CurHoverItemPinMarkReceiver;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void Update()
	{
	}

	public void SetViewData(EPresetAgentScene scene)
	{
	}

	public void ShowAgentDefaultQuestion(uint defaultQuestionId)
	{
	}

	public void OnPresetAgentChangeDepth(int depth)
	{
	}

	public void RefreshBubbleDragCD()
	{
	}

	private void InitEvent()
	{
	}

	private void InitLineRender()
	{
	}

	private void OnButtonClick()
	{
	}

	private void ResetView()
	{
	}

	private void ShowAgentBubble(string text, uint recommendId, uint avatarId, List<uint> fastChatIds, float freezeTime = 0f, bool loop = false)
	{
	}

	public void HideAgentBubble()
	{
	}

	private void ShowAgentWindow()
	{
	}

	private void HideAgentWindow()
	{
	}

	private void RefreshWindowClickMask()
	{
	}

	private void OnDragStart(GameObject go)
	{
	}

	private void OnDragEnd(GameObject go)
	{
	}

	private void StopDrag()
	{
	}

	private void UpdateDrag()
	{
	}

	private void UpdateScrollRegion()
	{
	}

	private bool IsHoverSelf()
	{
		return false;
	}

	private void GetHoverItemTypeAndData(out EPresetDragInteractableItemType hoverItemType, out object hoverItemData, bool excludeScrollRegions = false)
	{
		hoverItemType = default(EPresetDragInteractableItemType);
		hoverItemData = null;
	}

	private void TryRequestMarkItem(Vector3 screenPos)
	{
	}

	private bool CheckTouchValid()
	{
		return false;
	}

	private void UpdateAgentIconState(AgentState state)
	{
	}

	private PresetAgentPinMarkReceiver GetReceiverAtPosition(Vector3 screenPos, PresetAgentPinMarkReceiver excludeReceiver = null, bool nonScrollOnly = false)
	{
		return null;
	}

	private PresetAgentPinMarkReceiver GetPresetAgentPinMarkReceiver(Vector3 screenPos)
	{
		return null;
	}

	private PresetAgentPinMarkReceiver GetNextHighestPriorityNonScrollReceiver(Vector3 screenPos, PresetAgentPinMarkReceiver excludeReceiver = null)
	{
		return null;
	}

	private void OnPinMark(object[] data)
	{
	}

	private void OnFastMessageClick(object[] data)
	{
	}

	private PresetAgentPrompt GetPlayerRecommendation(uint subType, bool isLowLevel, bool forceRandom = false)
	{
		return null;
	}

	private uint GetRandomRecType()
	{
		return 0u;
	}

	private OccupationInfo GetHighestOccupationFromSeasons(OccupationDetailInfo brInfo, OccupationDetailInfo csInfo)
	{
		return null;
	}

	private bool IsPinMarkValid(EPresetDragInteractableItemType itemType)
	{
		return false;
	}

	private void ProcessPinMarkData(EPresetDragInteractableItemType itemType, uint avatarId)
	{
	}

	private void PlayRecommendation(PresetAgentPrompt data)
	{
	}

	private void PlayAudioFile(string url, uint id, Action<bool, uint, AudioClip> onDownloadCallback, AudioType audioType)
	{
	}

	private void ShowAgentBubbleLoading(EPresetAgentScene scene)
	{
	}

	private void TryCreateAgentBubble()
	{
	}

	private void AudioCDNDownloadCallback(bool success, uint id, AudioClip clip, PresetAgentPrompt data)
	{
	}

	private void _003CRefreshWindowClickMask_003Eb__29_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
