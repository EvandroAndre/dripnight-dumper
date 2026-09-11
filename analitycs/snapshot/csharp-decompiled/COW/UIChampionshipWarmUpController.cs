using GCommon;
using proto;

namespace COW;

public class UIChampionshipWarmUpController : UINavigationController
{
	private UIChampionshipWarmUpView m_View;

	private UIModelChampionship m_ModelChampionship;

	private ChampionshipSettingDesc m_ChampionshipSettingInfo;

	private MapOpeningInfo m_MapInfo;

	private ChampionshipOpenInfoDesc m_ChampionshipOpenInfo;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void SetView()
	{
	}

	protected void RefreshCupIcon()
	{
	}

	protected void OnBtnRuleClick()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
