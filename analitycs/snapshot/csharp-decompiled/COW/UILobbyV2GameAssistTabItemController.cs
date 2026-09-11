using GCommon;
using UnityEngine;

namespace COW;

public class UILobbyV2GameAssistTabItemController : UIBaseController
{
	private UILobbyV2GameAssistTabItemView m_View;

	private ELobbyAssistWndTab m_TabType;

	private UIModelGameAssistantIntroduction m_ModelGameAssist;

	private ELobbyAssistWndState m_WndState;

	private ulong m_AccountId;

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

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetViewData(int tabType)
	{
	}

	public ELobbyAssistWndState GetWndState()
	{
		return ELobbyAssistWndState.Grey;
	}

	public ELobbyAssistWndTab GetTabType()
	{
		return ELobbyAssistWndTab.RewardTab;
	}

	private uint GetTabDataNum()
	{
		return 0u;
	}

	public void RefreshSocialTab(uint MsgNum)
	{
	}

	public void RefreshNormalTab()
	{
	}

	public void RefreshRuleTab(uint MsgNum)
	{
	}

	public void RefreshTabState()
	{
	}

	private void BtnTabClick()
	{
	}

	public void SetColorState(Color color)
	{
	}

	public void SetRedPointState(bool show)
	{
	}

	private void SetHighLightState(bool show)
	{
	}

	public void SetNormalState(bool show)
	{
	}

	public void SetGreyState(bool show)
	{
	}

	public void SetTabType()
	{
	}

	public void SetTabSprite()
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

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
