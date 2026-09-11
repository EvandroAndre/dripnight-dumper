using GCommon;

namespace COW;

public class UIClanWarChampionshipRoundWarmController : UIPopupWindowController
{
	private UIClanWarChampionshipRoundWarmView m_View;

	private UIModelGroup m_ModelGroup;

	private UIModelClanWarChampionship m_ModelClanWarChampionship;

	private UIModelCDNAd m_ModelCdn;

	private ulong m_CurrentTimeStamp;

	private ulong m_EndTimeStamp;

	private uint m_DelayCall;

	private const string GO_TO_TOURNAMENT_MODE_PARAMS = "V2_Team_4_Match_15_Map_99_Game_1";

	private bool m_IsReady;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData()
	{
	}

	private void CountDown()
	{
	}

	private void OnJumpBtnClick()
	{
	}

	private void OnFunctionalBtnClick()
	{
	}

	private void OnCloseBtnClick()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
