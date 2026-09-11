using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDAIChatWindowController : UIBaseController, IAIChatDraggableItem, SpeechRecognition.ISpeechRecognitionObserver
{
	private sealed class _003CWaitForBase64Data_003Ed__66 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ConvertAudioReturnParams convertResult;

		public UIHUDAIChatWindowController _003C_003E4__this;

		private float _003CelapsedTime_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CWaitForBase64Data_003Ed__66(int _003C_003E1__state)
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

	private UIHUDAIChatWindowView m_View;

	private UIModelAIChat m_ModelAIChat;

	private uint m_DelayCallBuildMessageList;

	private UIChatBaseContainerController m_ContainerCtrl;

	private List<AIMessageInfo> m_MessageList;

	private bool m_RebuildMessageListTable2;

	private UIHUDAIChatParentController m_ParentCtrl;

	private GameObject ContentNode;

	private UIScrollView MessageList;

	private GameObject EmptyNode;

	private UITable2 MessageListTable2;

	protected int lastItemIndex;

	protected int firstItemIndex;

	protected const int ITEM_COUNT_PERPAGE = 10;

	protected UIHUDAIChatMessageItemController m_TempMessageItem;

	protected int ScrollViewWidth;

	protected UITable2.Margin MessageMargin;

	private int BannerOffset;

	private bool m_IsRecording;

	private const int INPUT_BG_LENGTH_NO_MICROPHONE = 276;

	private const int INPUT_BG_LENGTH_WITH_MICROPHONE = 222;

	private const int INPUT_BG_LENGTH_WITH_MICROPHONE_V2 = 272;

	private const int INPUT_LABEL_LENGTH_NO_MICROPHONE = 258;

	private const int INPUT_LABEL_LENGTH_WITH_MICROPHONE = 204;

	private const int INPUT_LABEL_LENGTH_WITH_MICROPHONE_V2 = 224;

	private Color TIME_NOT_ENOUGH_COLOR;

	private Color TIME_NORMAL_COLOR;

	private Coroutine m_WaitForBase64DataCoroutine;

	private float m_CurrentRecordTimeLength;

	private uint m_RecordingDelayCall;

	private uint m_WaitGameVoicePauseDelayCall;

	private bool m_IsWaitingChannelPause;

	private bool m_IsRecordingToShort;

	private bool m_IsPermissionCheckFinish;

	private float RECORDING_TIME_LENGTH;

	private float VAILD_TIME_LENGTH;

	private Coroutine m_StartRecordingCor;

	private string m_CurInputString;

	private bool m_IsSpeechRecognitionFinal;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override void OnUIOpenAsChild()
	{
	}

	public void UpdateMessageList(bool rebuild)
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	public void SetContainerWidgetPosition(Vector3 location)
	{
	}

	public Vector2 GetContainerWidgetSize()
	{
		return default(Vector2);
	}

	public Transform GetContainerWidgetTransform()
	{
		return null;
	}

	public bool IsDragging()
	{
		return false;
	}

	public Vector2 GetBound()
	{
		return default(Vector2);
	}

	public void RefreshContentNode()
	{
	}

	public void RefreshContentNodeBaseView()
	{
	}

	public void RefreshLastMessage()
	{
	}

	public void RefreshTargetMessage(int messageIndex, int error)
	{
	}

	public void RebuildMessageList()
	{
	}

	public void UpdateNewMessageList()
	{
	}

	protected void RebuildMessageListTable2(int fromIndex, int toIndex, bool isRebuild)
	{
	}

	public UIWidget GetMaskWidget()
	{
		return null;
	}

	public void SetDepth(int depth)
	{
	}

	public void RefreshChatBottomBtn(bool canChat)
	{
	}

	private UIChatBaseContainerController GetOrCreateContainerCtrl()
	{
		return null;
	}

	private void InitChatTemplate()
	{
	}

	private void RefreshChatBottomLeft()
	{
	}

	public virtual void GetMessageList()
	{
	}

	private void RefreshDefaultContent()
	{
	}

	private Vector2 GetItemSize(AIMessageInfo info)
	{
		return default(Vector2);
	}

	private void ScrollToBottom()
	{
	}

	private void OnScrollToBottomBtnClick()
	{
	}

	private void OnHelpBtnClick()
	{
	}

	private void OnStopMoving()
	{
	}

	private bool NeedShowScrollBottomBtn()
	{
		return false;
	}

	private bool IsAtTop()
	{
		return false;
	}

	public bool IsAtBottom()
	{
		return false;
	}

	private void ResetDefaultInputValue()
	{
	}

	public void OnAIChatFastChatClick(object[] data)
	{
	}

	private void OnEnterBtnClick()
	{
	}

	private IEnumerator WaitForBase64Data(ConvertAudioReturnParams convertResult)
	{
		return null;
	}

	private void OnCloseBtnClick()
	{
	}

	private void OnInputContainerChange()
	{
	}

	private void RefreshSendDisableMask()
	{
	}

	private void OnGameVoiceChannelPaused(object[] data)
	{
	}

	public void AddLoadingMessageToList(bool isSelf)
	{
	}

	private void AddSendingMessageToList(string content)
	{
	}

	private void AddMessageToList(string content, bool isSelf, bool isLoading)
	{
	}

	private void OnMicrophoneBtnClick()
	{
	}

	private void ForceReturnToInputState()
	{
	}

	private void SendRecordingVoice(string base64Data)
	{
	}

	private void FinishRecording()
	{
	}

	private void CancelRecording()
	{
	}

	private void RefreshMicrophoneView()
	{
	}

	private void InitMicrophoneView()
	{
	}

	private void OnApplicationPauseEvent(object[] data)
	{
	}

	private void OnGameVoiceChannelPausedV1(object[] data)
	{
	}

	private void OnSpeechRecognitionV1BtnClick()
	{
	}

	private void OnMicrophoneV2BtnClick()
	{
	}

	private void RefreshChatBottomLeftV2()
	{
	}

	private void ForceReturnToInputStateV2()
	{
	}

	private void OnGameVoiceChannelPausedV2(object[] data)
	{
	}

	private void InitSpeechRecognition_Android()
	{
	}

	private void InitSpeechRecognitionV2()
	{
	}

	private void ContinueOnSpeechRecognition()
	{
	}

	private void InitSpeechRecognitionInputText()
	{
	}

	private void OnSpeechRecognitionV2BtnClick()
	{
	}

	private void OnInputContainerGetFocus()
	{
	}

	public void OnGetAvailableLanguages(string error, SpeechRecognition.LanguageStatus languageStatus)
	{
	}

	void SpeechRecognition.ISpeechRecognitionObserver.OnAuthorizationResponse(bool? result)
	{
	}

	void SpeechRecognition.ISpeechRecognitionObserver.OnRecordedAndRecognizedText(bool isFinal, string[] matches)
	{
	}

	void SpeechRecognition.ISpeechRecognitionObserver.OnReadyToRecordAndRecognize()
	{
	}

	void SpeechRecognition.ISpeechRecognitionObserver.OnDictationBreak()
	{
	}

	void SpeechRecognition.ISpeechRecognitionObserver.OnError(string error, bool shouldForceStop)
	{
	}

	private void _003COnUIOpen_003Eb__30_0()
	{
	}

	private void _003CRefreshChatBottomBtn_003Eb__49_0()
	{
	}

	private UITable2.IUITable2Item _003CInitChatTemplate_003Eb__51_0()
	{
		return null;
	}

	private void _003COnMicrophoneBtnClick_003Eb__83_0()
	{
	}

	private void _003COnMicrophoneBtnClick_003Eb__83_1()
	{
	}

	private void _003COnGameVoiceChannelPausedV1_003Eb__91_0()
	{
	}

	private void _003COnGameVoiceChannelPausedV1_003Eb__91_3()
	{
	}

	private void _003COnGameVoiceChannelPausedV1_003Eb__91_1()
	{
	}

	private void _003COnGameVoiceChannelPausedV1_003Eb__91_2()
	{
	}

	private void _003COnMicrophoneV2BtnClick_003Eb__95_0()
	{
	}

	private void _003COnMicrophoneV2BtnClick_003Eb__95_1()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpenAsChild()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
