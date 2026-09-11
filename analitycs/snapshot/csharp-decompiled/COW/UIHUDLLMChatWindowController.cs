using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDLLMChatWindowController : UIBaseController, IAIChatDraggableItem
{
	private UIHUDLLMChatWindowView m_View;

	private UIModelAIChat m_ModelAIChat;

	private UIHUDLLMChatContainerController m_ContainerCtrl;

	private List<LLMMessageInfo> m_MessageList;

	private bool m_RebuildMessageListTable2;

	private UIHudUGC_LLMChatController parentCtrl;

	private UnityHttpRequest request;

	private GameObject ContentNode;

	private UIScrollView MessageList;

	private GameObject EmptyNode;

	private UITable2 MessageListTable2;

	protected int lastItemIndex;

	protected int firstItemIndex;

	protected const int ITEM_COUNT_PERPAGE = 10;

	protected UIHUDLLMChatMessageItemController m_TempMessageItem;

	protected int ScrollViewWidth;

	protected UITable2.Margin MessageMargin;

	private int BannerOffset;

	private bool m_IsGenerating;

	public UIAtlas PersonaAtlas;

	public string PersonaSpriteName;

	public UIAtlas UserAtlas;

	public string UserSpriteName;

	private double LastSearchTime;

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

	private Vector2 GetItemSize(LLMMessageInfo info)
	{
		return default(Vector2);
	}

	private void ScrollToBottom()
	{
	}

	private void OnStopMoving()
	{
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

	public bool CheckSearchDuringCD()
	{
		return false;
	}

	private void OnEnterBtnClick()
	{
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

	private void AfterSendSuccess()
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

	public void ChangePersonaNickName(string name)
	{
	}

	public void ChangePersonaHeadIcon(string spriteID)
	{
	}

	public void ChangeUserHeadIcon(string spriteID)
	{
	}

	public void ChangePersonaSprite(string spriteID)
	{
	}

	public void ChangeUserSprite(string spriteID)
	{
	}

	public void ChangeOffset(Vector2 offset)
	{
	}

	private UITable2.IUITable2Item _003CInitChatTemplate_003Eb__43_0()
	{
		return null;
	}

	private void _003CChangePersonaSprite_003Eb__66_0(UIAtlas atlas, string spriteName)
	{
	}

	private void _003CChangeUserSprite_003Eb__67_0(UIAtlas atlas, string spriteName)
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
