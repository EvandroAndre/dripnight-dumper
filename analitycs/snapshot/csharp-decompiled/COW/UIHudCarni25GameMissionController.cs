using COW.GamePlay;
using GCommon;
using message;

namespace COW;

internal class UIHudCarni25GameMissionController : UIBaseController, IGameMissionTopEventUI
{
	private UIHudCarni25GameMissionView m_View;

	private UITimeLabelHelper m_TimeLabelHelper;

	private float m_ActivityProgress;

	private float m_EventProgress;

	private uint m_ActivityState;

	private float m_UpdateIntervalElapsedTime;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	public void SetViewData()
	{
	}

	public float NeedHeight()
	{
		return 0f;
	}

	private void OnCarniModuleReady()
	{
	}

	public void InitDataOnOpenFromGameMissionUI(object data)
	{
	}

	private void UpdateLayoutContentAfterTimelineSetup(JDLFKCCAJAB activityInfo)
	{
	}

	private void RefreshAllChildAnchors(UIWidget parent)
	{
	}

	private void UpdateUIView()
	{
	}

	private void SetActivityState(int gameTimeMilliSec, JDLFKCCAJAB activityTimeInfo)
	{
	}

	private bool IsInActivity(LMINGHIIBJJ state)
	{
		return false;
	}

	private float CalActivityProgress(int gameTimeMilliSec, JDLFKCCAJAB activityInfo)
	{
		return 0f;
	}

	private void SetActivityProgress(float value)
	{
	}

	private void SetEventProgress(float value)
	{
	}

	private float CallEventProgress(int gameTimeMilliSec, JDLFKCCAJAB activityInfo)
	{
		return 0f;
	}

	private void Update()
	{
	}

	private void UpdateByInterval(float deltaTime)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
