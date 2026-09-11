using GCommon;

namespace COW;

internal class UIHUDLWMultiTeamScoreBoardController : UIHUDMultiTeamScoreBoardController<UIHUDMultiTeamScoreBoardTeamItemController>
{
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override void RegisterUIEvent()
	{
	}

	private void OnCSNewPhaseStarted(object[] param)
	{
	}

	private void OnToggleRoundInfo(object[] parap)
	{
	}

	public void _003C_003EiFixBaseProxy_RegisterUIEvent()
	{
	}
}
