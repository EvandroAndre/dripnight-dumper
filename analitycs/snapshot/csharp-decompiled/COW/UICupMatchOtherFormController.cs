using GCommon;

namespace COW;

public class UICupMatchOtherFormController : UINavigationController
{
	public class NavArgs
	{
		public int cpKey;

		public uint teamID;

		public bool self;

		public uint scaleType;
	}

	private int m_CupMatchKey;

	private uint m_TeamID;

	private UICupMatchOtherFormView m_View;

	private UICupMatchTeamProfileOtherController m_TeamCtrl;

	private UIStandardDrawerTabController m_DrawerTabCtrl;

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
