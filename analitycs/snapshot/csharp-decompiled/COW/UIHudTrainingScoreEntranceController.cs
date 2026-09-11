using GCommon;

namespace COW;

public class UIHudTrainingScoreEntranceController : UIBaseController
{
	private UIHudTrainingScoreEntranceView m_View;

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

	private void OnScoreButtonClick()
	{
	}

	public static bool DontDestroy()
	{
		return false;
	}

	public override bool RecyleDontDestroy()
	{
		return false;
	}

	public override void OnUIReInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public bool _003C_003EiFixBaseProxy_RecyleDontDestroy()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIReInit()
	{
	}
}
