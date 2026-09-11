using GCommon;

namespace COW;

public class UICrossMatchModeRankInfoController : UIBaseController
{
	private UICrossMatchModeRankInfoView m_View;

	private UIModelLadderMatch m_ModelLadderBR;

	private UIModelCSLadderMatch m_ModelLadderCS;

	private UIBRRankIconController m_BRCrossModeIconCtrl;

	private UICSRankIconController m_CSCrossModeIconCtrl;

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

	public void SetCSView(uint csRank, uint rankStage)
	{
	}

	public void SetBRView(uint brRank, uint rankStage)
	{
	}

	private void ShowRankIcon(bool isBR)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
