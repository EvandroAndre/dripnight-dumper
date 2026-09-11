using GCommon;

namespace COW;

public class UIHighlightRecordPopupBoxController : UIPopupWindowController
{
	private UIHighlightRecordPopupBoxView m_View;

	private ulong m_MatchId;

	private EReplayPlayChannel m_Channel;

	private EnterReplayMode m_EnterMode;

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

	private void ClickOn()
	{
	}

	private void ClickOff()
	{
	}

	public void SetView(ulong matchid = 0uL)
	{
	}

	internal void SetReplayContext(EReplayPlayChannel channel, EnterReplayMode enterMode)
	{
	}

	private void _003CClickOn_003Eb__7_0(bool permission)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
