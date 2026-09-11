using GCommon;
using proto;

namespace COW;

public class UIChampionshipGameStatsController : UINavigationController, IUIModelDataChangeObserver
{
	public class NavArgs
	{
		public ulong teamID;

		public TeamInfo teamInfo;

		public uint championshipType;
	}

	private UIChampionshipGameStatsView m_View;

	protected UIModelChampionship m_ModelChampionship;

	protected ChampionshipOpenInfoDesc m_ChampionshipOpenInfo;

	private UIChampionshipTeamOverviewController m_TeamOverviewUI;

	private ulong m_TeamID;

	private TeamInfo m_TeamInfo;

	private uint m_ChampionshipType;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	public override void OnNavigationClosed()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void RequestData()
	{
	}

	private void UpdateTeamInfo()
	{
	}

	private void UpdateSeasonInfo()
	{
	}

	private void UpdateStatsInfo(CSTeamChampionshipSeasonStatsRes res)
	{
	}

	private string SecFormat(uint _sec)
	{
		return null;
	}

	private string uniFormat(uint n)
	{
		return null;
	}

	private void OnViewMatchHistoryBtnClick()
	{
	}

	protected void OnShareBtnClick()
	{
	}

	public override void BeforeScreenshot()
	{
	}

	public override void AfterScreenshot()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public new void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	public new void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}
}
