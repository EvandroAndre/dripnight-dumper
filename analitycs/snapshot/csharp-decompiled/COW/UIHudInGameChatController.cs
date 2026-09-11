using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudInGameChatController : UIBaseController, IUIModelDataChangeObserver
{
	private const int ITEM_COUNT_MAX = 50;

	private const float BULLETSCREENCD = 5f;

	private const float AutoShowBubbleSecond = 2f;

	private bool m_IsInCD;

	private uint m_CheckCDDelayCallID;

	private int m_CharacterLimit;

	private float m_CurerntCDTime;

	private TouchScreenKeyboard m_CurKeyBoard;

	private string m_CachedText;

	private UIModelInGameChat m_Model;

	private UIHudInGameChatView m_View;

	private List<ClientInGameChatMessage> m_MessageList;

	private List<ClientInGameChatMessage> m_AllMessageList;

	private List<UILabel> m_LabelList;

	private Queue<UILabel> m_LabelPool;

	private float lastItemPosY;

	private float firstItemPosY;

	private int lastItemIndex;

	private int firstItemIndex;

	private int m_NewMessageCount;

	private bool m_ShowState;

	private List<UILabel> m_ChatItemTemplates;

	private float m_TemplateXPos;

	private uint m_BulletScreenDelayCall;

	private uint testIndex;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void Update()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	protected void RebuildMessageList()
	{
	}

	protected void UpdateNewMessageList(bool isInternal = false)
	{
	}

	protected virtual UILabel GetAnInstance()
	{
		return null;
	}

	private void RefreshAllContent()
	{
	}

	private void WrapInitializeItem(int fromIndex, int toIndex)
	{
	}

	private void OnChatBtnClick()
	{
	}

	private void StartMsgCD()
	{
	}

	private void OnHideQuickViewBtnClick()
	{
	}

	private void OnSendBtnClick()
	{
	}

	private void OnBubbleClick()
	{
	}

	private void SetChatPanelVisible(bool show)
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

	private void ScrollToBottom()
	{
	}

	private void OnStopMoving()
	{
	}

	protected void GetMessageList()
	{
	}

	private string Validate(string val)
	{
		return null;
	}

	private void UpdateCD()
	{
	}

	private void UpdateKeyBoard()
	{
	}

	public virtual uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public virtual void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void _003CUpdateNewMessageList_003Eb__32_0()
	{
	}

	private void _003CStartMsgCD_003Eb__37_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
