using GCommon;

namespace COW;

internal class UILobbyV2GameAssistAntiHackItemController : UILobbyV2GameAssistNormalItemController
{
	private const string BR_COMPENSATION_ICON_RES_NAME = "FF_icon_RankTips";

	private const string CS_COMPENSATION_ICON_RES_NAME = "UI_ProtectionPoints_Star";

	private UILobbyV2GameAssistAntiHackItemView m_View;

	private AssistAntiHackInfo m_FeedbackInfo;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void SetViewData(object data, int index)
	{
	}

	private void RefreshView()
	{
	}

	protected override void SetRead()
	{
	}

	private void OnGotoBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_SetViewData(object P0, int P1)
	{
	}

	public void _003C_003EiFixBaseProxy_SetRead()
	{
	}
}
