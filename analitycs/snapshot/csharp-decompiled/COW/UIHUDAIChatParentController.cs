using System.Collections.Generic;
using COW.Gameplay.UGC;
using GCommon;
using message;
using proto;

namespace COW;

public class UIHUDAIChatParentController : UIBaseController
{
	private UIHUDAIChatParentView m_View;

	private UIModelAIChat m_ModelAIChat;

	private UIHUDAIChatEntranceController m_EntranceCtrl;

	private UIHUDAIChatBubbleController m_BubbleCtrl;

	private UIHUDAIChatWindowController m_WindowCtrl;

	private bool m_IsBubbleShow;

	private bool m_IsWindowShow;

	private bool m_IsWaitingVoice2Text;

	private bool m_IsGenerating;

	private bool m_IsCurrentPrompt;

	private UIClickMask m_ClickMask;

	private uint m_AutoCloseBubbleDelayCall;

	private float m_AutoCloseBubbleTime;

	private const int CHAT_BUBBLE_UP_OFFSET = 20;

	private const int CHAT_BUBBLE_DOWN_OFFSET = 10;

	private const int CHAT_BUBBLE_LEFT_OFFSET = 4;

	private const int CHAT_BUBBLE_RIGHT_OFFSET = 2;

	private const string AI_CHAT_ENTRANCE_POS_KEY = "AICHATENTRANCEPOSKEY_{0}_{1}_{2}";

	private List<AIMessageInfo> m_AIMessageInfoList;

	private int m_CurrentLocalMessageIndex;

	private float m_EntranceLeftAnchor;

	private float m_EntranceRightAnchor;

	private EAIChatBubblePivot m_ChatBubblePivot;

	private EAIChatWindowPivot m_ChatWindowPivot;

	private uint m_SceneId;

	private UnityHttpRequest m_HttpRequest;

	private AIFAQData m_AIFAQData;

	private List<string> m_AIAssistKnowledgeDomainList;

	private string roomID;

	private uint m_KnowledgeDomainId;

	private uint m_VoiceInputCnt;

	private uint m_TextInputCnt;

	private int m_CurrentAIChatDepth;

	private bool m_NeedAgentStatusRequest;

	private string m_PendingChatContent;

	private bool m_PendingChatIsAudio;

	private bool m_PendingChatIsPrompt;

	public List<AIMessageInfo> AIMessageInfoList => null;

	public int CurrentLocalMessageIndex
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool IsGenerating
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public uint SceneID => 0u;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void SetViewData(uint sceneId, bool showEntranceTitle, uint knowledgeDomainId)
	{
	}

	public void InitView()
	{
	}

	public void OnChatEntranceClick()
	{
	}

	public IAIChatDraggableItem GetCurrentShowingItemNoDragging()
	{
		return null;
	}

	public void RefreshWindowClickMask()
	{
	}

	public void SaveEntrancePosition()
	{
	}

	public void HideChatWindow()
	{
	}

	public void RefreshEntranceTowardsWithDragging()
	{
	}

	public void ShowChatWindow()
	{
	}

	public void RefreshEntranceTowards()
	{
	}

	public void SetAIChatDepth(int depth)
	{
	}

	public void OnAIChatChangeDepth(object[] data)
	{
	}

	public void OpenTweenTips(string tips)
	{
	}

	private void ShowEntrance(bool showEntranceTitle)
	{
	}

	private void ShowChatBubble(string text, float freezeTime = 0f)
	{
	}

	private void HideChatBubble()
	{
	}

	private void CheckChatBubblePivot()
	{
	}

	private void CheckChatWindowPivot()
	{
	}

	private void RefreshChatBubblePosition()
	{
	}

	private void RefreshChatWindowPosition()
	{
	}

	private void InitEntranceAnchor()
	{
	}

	private void RefreshAutoCloseBubbleDelayCall()
	{
	}

	private void LoadEntrancePosition()
	{
	}

	private void InitMessageData()
	{
	}

	private void ShowAIChatEntranceClickGuide()
	{
	}

	private void OnAIChatEntranceDragGuide()
	{
	}

	private void OnModeSettingVarCtrlJump(object[] data)
	{
	}

	private void SendPromptData()
	{
	}

	private void InitTopTip()
	{
	}

	private void RefreshChatWindowButton(bool canChat)
	{
	}

	public void SendAgentStatusReq()
	{
	}

	private void OnAgentStatusResponseFinish(DOEOGBNPNAJ errorCode, ELLGAABJFFP warningCode, byte[] response)
	{
	}

	public void SendAIChatReq(string content, bool isAudio, bool isPrompt = false, bool instant = false)
	{
	}

	private void CheckRemoveFastChat()
	{
	}

	public void SendLikeOrDislike(bool isLike, string msgID)
	{
	}

	private void OnAIChatResponseUpdate(AIAssistantResponse info)
	{
	}

	private void OnAIChatResponseFinish(AIAssistantResponse info)
	{
	}

	private void RefreshChatMessage()
	{
	}

	private void TryDisplayFastChat()
	{
	}

	public void UpdateAIMessageContent(string content, string messageId, string toolName, List<ToolCallArg> args = null)
	{
	}

	public void AddMessageToList(string content, bool isSelf, bool isLoading, bool isTopTip = false)
	{
	}

	public void AddFastChatMessageToList(List<AIAssistantSuggestedQuestionsTableDesc> fastChatData)
	{
	}

	public void HttpCancel()
	{
	}

	private void _003CRefreshWindowClickMask_003Eb__54_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
