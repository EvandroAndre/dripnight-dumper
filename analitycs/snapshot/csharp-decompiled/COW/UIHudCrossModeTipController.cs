using GCommon;
using message;

namespace COW;

public class UIHudCrossModeTipController : UIBaseController
{
	private UIHudCrossModeTipView m_View;

	private UIModelCSLadderMatch m_ModelLadderCS;

	private UIModelLadderMatch m_ModelLadderBR;

	private ELadderRankStages m_CurRankStage;

	private UIBRRankIconController m_BRRankIconController;

	private UICSRankIconController m_CSRankIconController;

	private float m_TimeShowCrossModeView;

	private uint m_ShowCrossModeViewDelayCall;

	public const string HEROIC_ANIM_CLIP = "UIFX_UIHudCrossModeTippHeroic_In";

	public const string MASTER_ANIM_CLIP = "UIFX_UIHudCrossModeTippMaster_In";

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void SetViewData(DLBMPCCFKKM matchMode, int depth, ELadderRankStages rankStage)
	{
	}

	public void PlayCrossModeAnim()
	{
	}

	private void CancelShowCrossModeViewDelayCall()
	{
	}

	private void _003CPlayCrossModeAnim_003Eb__14_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
