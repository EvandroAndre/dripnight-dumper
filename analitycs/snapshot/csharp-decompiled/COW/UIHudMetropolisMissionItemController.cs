using System.Collections.Generic;
using COW.GamePlay;
using GCommon;

namespace COW;

public class UIHudMetropolisMissionItemController : UIEasyListItemController
{
	private UIHudMetropolisMissionItemView m_View;

	private LIFOHNKCMKF m_Mission;

	private uint m_MissionAreaId;

	private ICEGOFFPFMB m_Game;

	private List<UIHudMetropolisCommonItemController> m_AwardItems;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	private void SetAwardItems()
	{
	}

	private void UpdateTrackUI()
	{
	}

	private void UpdateMissionUI()
	{
	}

	private void OnUpdateMission(uint missionId)
	{
	}

	private void OnBtnTrackClick()
	{
	}

	private void OnBtnFinishMission()
	{
	}

	private void OnMetropolisAreaTrack()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
