using GCommon;

namespace COW;

internal class UILobbyV2GameAssistTipsItemController : UILobbyV2GameAssistNormalItemController
{
	public enum ETipsState
	{
		None,
		EvoPass,
		Membership,
		UGCPremium
	}

	private ETipsState m_TipState;

	private UILobbyV2GameAssistTipsItemView m_View;

	private AssistTipsInfo m_Info;

	private UIModelGameAssistantIntroduction m_ModelGameAssistantIntroduction;

	private UIModelEvoPass m_ModelEvoPass;

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

	private void OnarrowClick()
	{
	}

	protected override void SetRead()
	{
	}

	private string GetTipsTypeLog()
	{
		return null;
	}

	private void InitState()
	{
	}

	protected override void SetViewData(object data, int index)
	{
	}

	private void RefreshCountDownView()
	{
	}

	private void RefreshIconView()
	{
	}

	private void RefreshView()
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

	public void _003C_003EiFixBaseProxy_SetRead()
	{
	}

	public void _003C_003EiFixBaseProxy_SetViewData(object P0, int P1)
	{
	}
}
