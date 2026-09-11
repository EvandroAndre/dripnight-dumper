using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIBaseChatController : UIBaseController, IUIModelDataChangeObserver, IEasyList
{
	public enum ClanChatTemplate
	{
		NormalChat
	}

	private ChatChannelInfo _003CcurShowChannel_003Ek__BackingField;

	protected UIModelChat m_Model;

	protected List<MessageInfo> m_MessageList;

	protected int lastItemIndex;

	protected int firstItemIndex;

	protected const int ITEM_COUNT_PERPAGE = 10;

	protected EChatInterfaceType m_InterfaceType;

	protected GameObject ContentNode;

	protected UIScrollView MessageList;

	protected GameObject EmptyNode;

	protected UIChatBottomLeftController m_ChatBottomLeftController;

	protected Transform BottomLeftTrans;

	protected UITable2 MessageListTable2;

	protected UIBaseChatItemController m_ChatMessageItemController;

	protected int ScrollViewWidth;

	protected UITable2.Margin MessageMargin;

	private uint m_DelayCallBuildMessageList;

	private HashSet<ulong> m_UGCMapExposureLogSet;

	private bool m_RebuildMessageListTable2;

	public ChatChannelInfo curShowChannel
	{
		get
		{
			return _003CcurShowChannel_003Ek__BackingField;
		}
		protected set
		{
			_003CcurShowChannel_003Ek__BackingField = value;
		}
	}

	public EChatInterfaceType InterfaceType => EChatInterfaceType.Normal;

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected virtual ChatChannelInfo GetCurShowChannel()
	{
		return null;
	}

	protected virtual void AfterInit()
	{
	}

	public virtual void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	protected virtual void OnChatDataChanged(uint propID, object[] param)
	{
	}

	public virtual uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	protected virtual uint GetChatInterestedPropID()
	{
		return 0u;
	}

	public virtual void RefreshContentNode()
	{
	}

	public virtual void AfterSendSuccess()
	{
	}

	public List<MessageInfo> GetMessageInfosBeforeCertainInfo(MessageInfo info, int length)
	{
		return null;
	}

	protected virtual void InitView()
	{
	}

	protected void RebuildMessageList()
	{
	}

	protected void UpdateNewMessageList()
	{
	}

	protected void RefreshMessageList()
	{
	}

	protected void ShowFastMessageFistTime(bool resetFirstShow = false)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public bool IsAtBottom()
	{
		return false;
	}

	private bool IsAtTop()
	{
		return false;
	}

	public void ScrollToBottom()
	{
	}

	public virtual void GetMessageList()
	{
	}

	protected void OnStopMoving()
	{
	}

	private void SetMessageList(bool recover)
	{
	}

	protected void InitChatTemplate()
	{
	}

	protected void RebuildMessageListTable2(int fromIndex, int toIndex, bool isRebuild)
	{
	}

	private Vector2 GetItemSize(MessageInfo info)
	{
		return default(Vector2);
	}

	public void CheckUGCMapExposure()
	{
	}

	public void CheckUGCMapExposureByIndex(int index, bool force = false)
	{
	}

	private void _003COnUIOpen_003Eb__25_0()
	{
	}

	private UITable2.IUITable2Item _003CInitChatTemplate_003Eb__50_0()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
