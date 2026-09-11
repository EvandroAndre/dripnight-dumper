using GCommon;

namespace COW;

public class UILadderMatchNextRankInfoItemController : UIBaseController
{
	private UILadderMatchNextRankInfoItemView m_View;

	private UIBRRankIconController m_BRRankIconController;

	private UICSRankIconController m_CSRankIconController;

	private UIHippoCrisisRankIconController m_HippoCrisisRankIconController;

	private UIModelLadderMatch m_ModelLadderBR;

	private UIModelCSLadderMatch m_ModelLadderCS;

	private int m_ZeroPeakRankPos;

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

	public void SetViewData(uint rank, uint rankMasterLevel, ENextRankInfoType labelType, bool isCurRank)
	{
	}

	private void SetStarRankInfoState(bool isStarInfo)
	{
	}

	private void SetCSRankIcon(uint rank, uint rankMasterLevel)
	{
	}

	private void SetBRRankIcon(uint rank, uint rankMasterLevel)
	{
	}

	private void SetHCRankIcon(uint rank)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
