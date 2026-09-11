using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIPresetAgentBubbleController : UIBaseController
{
	private sealed class _003C_003Ec__DisplayClass23_0
	{
		public UIPresetAgentBubbleController _003C_003E4__this;

		public PresetAgentDetail detailData;

		public uint recommendId;

		public uint avatarId;

		public List<uint> fastChatIds;

		internal void _003CRefreshReFastChatData_003Eb__0(bool success, uint id, AudioClip clip)
		{
		}
	}

	private UIPresetAgentBubbleView m_View;

	private uint m_FreezeDelayCall;

	private uint m_RecommendId;

	private bool m_IsTypeWriter;

	private const int LABEL_MARGIN = 24;

	private const int LABEL_MARGIN_OFFSET = 16;

	private const int MESSAGE_HEIGHT = 51;

	private const int MESSAGE_WIDTH = 266;

	private const string LOADING_BUBBLE_TEXT = "......";

	private bool m_IsLoop;

	private string m_OriginalText;

	private uint m_TypeWriterDelayCall;

	private float m_LoopDelay;

	private EPresetAgentScene m_Scene;

	private List<uint> m_FastChatIds;

	private uint m_AvatarId;

	private List<UIPresetAgentBubbleMessageItemController> m_FastMessageItemControllers;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void Update()
	{
	}

	public void SetViewData(string text, EPresetAgentScene scene, uint recommendId, uint avatarId, List<uint> fastChatIds, float freezeTime = 0f, bool loop = false, float loopDelay = 0.5f)
	{
	}

	public void RefreshReFastChatData(uint recommendId, uint fastMessageId, uint avatarId, List<uint> fastChatIds, EPresetAgentScene scene)
	{
	}

	public void PlayAudioFile(string url, uint id, Action<bool, uint, AudioClip> onDownloadCallback, AudioType audioType)
	{
	}

	public void ShowAgentBubbleLoading(EPresetAgentScene scene)
	{
	}

	public void SetDepth(int depth)
	{
	}

	private void InitView()
	{
	}

	private void CheckShowRecommend()
	{
	}

	private void RefreshBubbleArrow(EPresetAgentScene scene)
	{
	}

	private void UpdateBubbleView(bool isShowRecommend, bool isShowFastMessage)
	{
	}

	private void RefreshFastMessage()
	{
	}

	private void ClearFreezeDelayCall()
	{
	}

	private void StartNextLoop()
	{
	}

	private void ClearTypeWriterDelayCall()
	{
	}

	private void OnGotoRecommendClick()
	{
	}

	private void FastChatAudioCDNDownloadCallback(bool success, uint id, AudioClip clip, PresetAgentDetail data, uint recommendId, uint avatarId, List<uint> fastChatIds)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
