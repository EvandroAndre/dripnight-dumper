using System.Collections.Generic;
using System.Text;
using GCommon;
using UnityEngine;
using message;

namespace COW;

public class UIInGameChatController : UIBaseController, IUIModelDataChangeObserver
{
	private UIInGameChatView m_View;

	protected UIModelInGameChat m_Model;

	private UIChatBaseContainerController m_ContainerCtrl;

	private List<ClientInGameChatMessage> m_MessageList;

	private bool m_RebuildMessageListTable2;

	private GameObject ContentNode;

	private UIScrollView MessageList;

	private GameObject EmptyNode;

	private UITable2 MessageListTable2;

	protected int ScrollViewWidth;

	protected int lastItemIndex;

	protected int firstItemIndex;

	protected const int ITEM_COUNT_PERPAGE = 10;

	protected UIInGameChatMessageItemController m_ChatMessageItemController;

	protected UITable2.Margin MessageMargin;

	private uint m_DelayCallBuildMessageList;

	private uint m_DelayCallCheckMicrophoneValid;

	private UIInGameChatVoiceToTextController m_VoiceToTextController;

	private UIModelAntiAddiction m_ModelAntiAddiction;

	private uint m_SendMessageCDCallID;

	private StringBuilder m_SendMessageCDText;

	private HDJKFKCKJGJ m_CurMsgType;

	private static readonly int[] m_MicPermissions;

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

	protected override void OnUIDestroy()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	protected override void OnUIClose()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] objs)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void UpdateMessageList(bool rebuild)
	{
	}

	private void RefreshAntiAddictionBRView()
	{
	}

	public void RefreshContentNode()
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

	private void OnEnterBtnClick()
	{
	}

	private void RefreshDefaultInputValue()
	{
	}

	private void ResetDefaultInputValue()
	{
	}

	private void OnVoiceToTextBtnClick()
	{
	}

	private void OpenVoiceToTextUI()
	{
	}

	private void OnInputChanged()
	{
	}

	private void OnNewMessageBtnClick()
	{
	}

	private void OnVoiceToTextPanelVisibleChange(object[] data)
	{
	}

	private void OnVoiceToTextRecognizedText(string text)
	{
	}

	private UIChatBaseContainerController GetOrCreateContainerCtrl()
	{
		return null;
	}

	private void InitChatTemplate()
	{
	}

	public void RefreshContentNodeBaseView()
	{
	}

	public virtual void GetMessageList()
	{
	}

	private void RefreshDefaultContent()
	{
	}

	private Vector2 GetItemSize(ClientInGameChatMessage info)
	{
		return default(Vector2);
	}

	private void ScrollToBottom()
	{
	}

	private void OnScrollToBottomBtnClick()
	{
	}

	private void OnStopMoving()
	{
	}

	private bool IsAtBottom()
	{
		return false;
	}

	private bool IsAtTop()
	{
		return false;
	}

	private void LateUpdate()
	{
	}

	private void SetNewMessageBtnVisible(bool visible)
	{
	}

	private void _003COnUIOpen_003Eb__25_0()
	{
	}

	private void _003COnVoiceToTextBtnClick_003Eb__40_0(Dictionary<int, bool> results)
	{
	}

	private void _003COnVoiceToTextBtnClick_003Eb__40_1()
	{
	}

	private void _003COpenVoiceToTextUI_003Eb__41_0()
	{
	}

	private UITable2.IUITable2Item _003CInitChatTemplate_003Eb__47_0()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
