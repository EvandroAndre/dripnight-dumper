using GCommon;

namespace COW;

public class UIChampionshipOtherFormController : UINavigationController
{
	public class NavArgs
	{
		public uint cpType;

		public uint teamID;

		public bool self;

		public uint scaleType;
	}

	private enum EPage
	{
		Team
	}

	private enum ETeamSubPage
	{
		Info,
		Record
	}

	private uint m_ChampionshipType;

	private uint m_TeamID;

	private UIChampionshipOtherFormView m_View;

	private UIChampionshipTeamProfileOtherController m_TeamCtrl;

	private UIStandardDrawerTabController m_DrawerTabCtrl;

	private UIModelChampionship m_ModelChampionship;

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

	public void CreateTab()
	{
	}

	public void CreateTeamPage()
	{
	}

	private void OnBtnTeamPageClick()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}
}
