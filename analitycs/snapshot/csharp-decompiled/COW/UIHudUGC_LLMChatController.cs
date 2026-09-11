using System.Collections.Generic;
using COW.GamePlay.UGCRuntime;
using COW.Gameplay.UGC;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudUGC_LLMChatController : UIHUDUGC_InternalHudController
{
	private UGCLLMChatHudRepItem m_ViewData;

	private UGCEntityDataStore _repDataMgr;

	private UIHudUGC_LLMChatView mView;

	private UIHUDLLMChatWindowController windowCtrl;

	private List<LLMMessageInfo> mLLMMessageInfoList;

	private int currentLocalMessageIndex;

	private bool isWindowShow;

	private bool m_IsGenerating;

	private int m_CurrentLocalMessageIndex;

	private EAIChatWindowPivot m_ChatWindowPivot;

	private UnityHttpRequest m_HttpRequest;

	private UGCPersonaModule module;

	private string personaID;

	private bool shouldReplySystemMsg;

	public List<LLMMessageInfo> LLMMessageInfoList => null;

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

	public bool IsWindowShow => false;

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

	public override void SetEntityID(string entityID)
	{
	}

	public override void DestroyEntity()
	{
	}

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

	public IAIChatDraggableItem GetCurrentShowingItemNoDragging()
	{
		return null;
	}

	public void HideChatWindow()
	{
	}

	private void ShowChatWindow(bool isInit)
	{
	}

	private void RefreshChatWindowPosition()
	{
	}

	private void InitMessageData()
	{
	}

	public void SendAIChatReq(string content)
	{
	}

	private void OnAIChatResponseUpdate(LLMStreamResponseBase info)
	{
	}

	private void OnAIChatResponseFinish(LLMStreamResponseBase info)
	{
	}

	private void UpdateAIMessageContent(string content)
	{
	}

	public void AddMessageToList(string content, bool isSelf, bool isLoading)
	{
	}

	private void ChangeOffset(Vector2 offset)
	{
	}

	private void ChangePersonaNickName(string nickName)
	{
	}

	private void ChangePersonaHeadIcon(string spriteID)
	{
	}

	private void ChangeUserNickName(string nickName)
	{
	}

	private void ChangeUserHeadIcon(string spriteID)
	{
	}

	private void ChangePersonaID(string id)
	{
	}

	private void ChangeShouldSystemReply(bool value)
	{
	}

	public void ShowOrHideChatWindow(bool value)
	{
	}

	public void _003C_003EiFixBaseProxy_SetEntityID(string P0)
	{
	}

	public void _003C_003EiFixBaseProxy_DestroyEntity()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
