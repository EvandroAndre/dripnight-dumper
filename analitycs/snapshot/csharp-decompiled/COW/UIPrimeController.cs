using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIPrimeController : UINavigationController, IUIModelDataChangeObserver
{
	public enum PrimeTab
	{
		None,
		MainPage,
		Privilege,
		LeaderBoard,
		Festival,
		DoublePointsActivity
	}

	private sealed class _003C_003Ec__DisplayClass27_0
	{
		public uint tab;

		internal bool _003CGotoSpecificTab_003Eb__0(StandardTabItemViewData item)
		{
			return false;
		}
	}

	private UIPrimeView m_View;

	private UIPrimeStandardTabController m_TabCtrl;

	private PrimeTab m_CurrentPrimeTab;

	private List<StandardTabItemViewData> m_MainTabDataList;

	private UIPrimeMainPageController m_PrimeMainPageController;

	private UIPrimePrivilegeController m_PrimePrivilegeController;

	private UIPrimeLeaderBoardController m_PrimeLeaderBoardController;

	private UIPrimeFestivalController m_PrimeFestivalController;

	private UIPrimeDoublePointsActivityController m_PrimeDoublePointsActivityController;

	private UIPrimeSettingPopUpController m_PrimeSettingCtrl;

	private UIModelPrime m_ModelPrime;

	private bool m_HasAddSettingBtn;

	private AutoPopup m_AutoPopup;

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

	private void Update()
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	private void AddSettingBtn()
	{
	}

	public void CreateTab()
	{
	}

	private void OnClickPrimeMainPage()
	{
	}

	private void OnClickPrimePrivilege()
	{
	}

	private void OnClickPrimeLeaderBoard()
	{
	}

	private void OnClickPrimeFestival()
	{
	}

	private void OnClickPrimeDoubleActivity()
	{
	}

	private void RefreshDisplayContent()
	{
	}

	public void GotoSpecificTab(uint tab = 0u, uint privilegeId = 0u, uint level = 0u, uint expand = 0u)
	{
	}

	public void BeforeLeaderBoardScreenshot()
	{
	}

	public void AfterLeaderBoardScreenshot()
	{
	}

	private void CheckAndUpdateCached()
	{
	}

	protected override void OnHelpButtonClick(object[] param)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void _003CAddSettingBtn_003Eb__19_0()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public void _003C_003EiFixBaseProxy_OnHelpButtonClick(object[] P0)
	{
	}
}
