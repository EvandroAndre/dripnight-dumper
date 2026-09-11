using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIGameModeCSPeakTournamentInfoController : UIBaseController, IUIModelDataChangeObserver
{
	private UIGameModeCSPeakTournamentInfoView m_View;

	private UIModelCSPeakTournamentLadderMatch m_ModelCSPeakTournamentLadderMatch;

	private UICSPeakTournamentRankIconController m_CSPeakTournamentRankIconCtrl;

	private List<MapModeData> m_DataList;

	private UIModelMapOpeningInfo m_ModelMap;

	private MapModeData m_SelectedMapModeData;

	private UICSRankStarIconController m_CSRankStarIconCtrl;

	private bool m_IsCsPeakSeasonCountDown;

	private uint m_SeasonEndDelayCallId;

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

	private void CancelSeasonEndDelayCall()
	{
	}

	public void SetUIData(List<MapModeData> dataList)
	{
	}

	private void SetViewData()
	{
	}

	private void RefreshSeasonNotice()
	{
	}

	private void OnSeasonEndCountDownFinished()
	{
	}

	private void OnMapBtnClick()
	{
	}

	private void OnHelperBtnClick()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void _003CSetViewData_003Eb__14_2()
	{
	}

	private void _003CSetViewData_003Eb__14_0()
	{
	}

	private void _003CSetViewData_003Eb__14_1()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
