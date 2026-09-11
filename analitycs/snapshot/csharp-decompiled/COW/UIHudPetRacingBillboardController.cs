using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UIHudPetRacingBillboardController : UIBaseController
{
	private UIHudPetRacingBillboardView m_View;

	private UITimeLabelHelper m_PrepareCountDownLabel;

	private UITimeLabelHelper m_NewRoundContDownLabel;

	private List<UIHudPetRacerView> racerList;

	private Dictionary<int, uint> racerIDs;

	private int votedIndex;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void OnPhaseChange(object[] data)
	{
	}

	private void Update()
	{
	}

	private void OnAddPetRacer(object[] data)
	{
	}

	private void OnPetVoted(object[] data)
	{
	}

	private void OnEnterVoteTrigger(object[] data)
	{
	}

	private void OnRacingResult(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
