using GCommon;

namespace COW;

public class UILobbyV2GameAssistHighlightMomentItemController : UILobbyV2GameAssistNormalItemController
{
	private const string PostReviewOnlyIconName = "UI_Assistant_icon_Review";

	private UILobbyV2GameAssistHighlightMomentItemView m_View;

	private AssistHighlightMomentInfo m_Info;

	private ulong m_DisplayMatchId;

	private UIButton m_GotoPostReviewBtn;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override void SetViewData(object data, int index)
	{
	}

	private void RefreshActionState()
	{
	}

	private void SetMatchTime()
	{
	}

	private void SetHighlightIcon(ulong matchId)
	{
	}

	private void SetModeName(ulong matchId)
	{
	}

	private void SetHighlightLabel(ulong matchId)
	{
	}

	private void OnGotoBtnClick()
	{
	}

	private void OnGotoPostReviewBtnClick()
	{
	}

	private bool HasOpenedMatchReview()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_SetViewData(object P0, int P1)
	{
	}
}
