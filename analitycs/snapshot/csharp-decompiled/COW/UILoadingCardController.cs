using GCommon;

namespace COW;

public class UILoadingCardController : UIBaseController, IUIModelDataChangeObserver
{
	private UILoadingPlayerInfoController m_BattleCardCtrl;

	private UIModelProfile m_ModelProfile;

	private UIModelLadderMatch m_ModelLadderMatch;

	private UIModelCSLadderMatch m_ModelCsLadderMatch;

	private UIModelCredit m_ModelCredit;

	public UILoadingPlayerInfoController BattleCardCtrl => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void InitViewAndRefreshLoadingCardUI(uint cardId = 0u, bool refreshUI = true, bool changeScale = true, LoadingCardShowPage showPage = LoadingCardShowPage.FrontEndPreview, int maxDepth = 0)
	{
	}

	public void ChangeBattleCardUIState()
	{
	}

	public bool GetBattleCardUIState()
	{
		return false;
	}

	protected override void OnUIDestory()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
