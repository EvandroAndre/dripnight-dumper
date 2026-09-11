using GCommon;
using UnityEngine;
using proto;

namespace COW;

internal class UILobbyV2GameAssistantCDNItemController : UILobbyV2GameAssistNormalItemController
{
	private UILobbyV2GameAssistantCDNItemView m_View;

	private UIModelGameAssistantIntroduction m_ModelGameAssistantIntroduction;

	private GameAssistSystemRuleInfo m_RuleInfo;

	private GameAssistantStatusData m_StatusData;

	private HelperMessageDesc m_ConfigData;

	private const string DEFAULT_JUMP_KEY = "T_42_MF_HELPER_JUMP";

	private Vector3 m_OriginContainerPos;

	private int m_OriginBoxHeight;

	public new static ResourceID GetResourceID()
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

	public void SetViewData()
	{
	}

	public override void SetTable2Visible(bool visible)
	{
	}

	protected override void SetRead()
	{
	}

	private void OnWebGopos1Click()
	{
	}

	private void OnTipGotoClick()
	{
	}

	private void OnWebGopos2Click()
	{
	}

	private void OnWebGopos3Click()
	{
	}

	private void RefreshView()
	{
	}

	private void RefreshPosAndHeight(int index)
	{
	}

	protected override void SetViewData(object data, int index)
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

	public void _003C_003EiFixBaseProxy_SetTable2Visible(bool P0)
	{
	}

	public void _003C_003EiFixBaseProxy_SetRead()
	{
	}

	public void _003C_003EiFixBaseProxy_SetViewData(object P0, int P1)
	{
	}
}
