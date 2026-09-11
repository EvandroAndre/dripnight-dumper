using GCommon;
using UnityEngine;

namespace COW;

public class UIHudMetropolisChatController : UIBaseController, IEasyList
{
	public enum ETab
	{
		World,
		Faction
	}

	private UIHudMetropolisChatView m_View;

	public ETab m_Tab;

	private UIModelMetropolis m_ModelMetropolis;

	private TouchScreenKeyboard m_CurKeyBoard;

	private string m_CachedText;

	private float m_SendCD;

	private string CHAT_MESSAGE_TXT;

	private string WORLD_CHANNEL_TITLE;

	private string POLICE_CHANNEL_TITLE;

	private string CRIMINAL_CHANNEL_TITLE;

	private string m_FactionTitle;

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

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	private void Update()
	{
	}

	private void OnLocalPlayerFactionChange(object[] data)
	{
	}

	private void OnChatUpdate()
	{
	}

	private void OnClickCloseBtn()
	{
	}

	private void UpdateKeyBoard()
	{
	}

	private void OnChatBtnClick()
	{
	}

	private void OnSendBtnClick()
	{
	}

	private void OnBubbleClick()
	{
	}

	private void OnMuteClick()
	{
	}

	private void OnUnMuteClick()
	{
	}

	private void OnClickWorldTab()
	{
	}

	private void OnClickFactionTab()
	{
	}

	private void OnStartDragMessage()
	{
	}

	private void OnStopDragMessage()
	{
	}

	private string Validate(string val)
	{
		return null;
	}

	private EMetropolisChatChannel GetCurrentChannel()
	{
		return EMetropolisChatChannel.None;
	}

	private void RefreshFactionTab()
	{
	}

	private void RefreshMuteInfo()
	{
	}

	public void RefreshMessageList()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
