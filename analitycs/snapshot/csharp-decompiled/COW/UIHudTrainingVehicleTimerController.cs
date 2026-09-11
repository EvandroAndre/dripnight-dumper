using COW.GamePlay;
using GCommon;

namespace COW;

public class UIHudTrainingVehicleTimerController : UIBaseController
{
	private HKGAJCJCMPE m_CurrentGame;

	private UIHudTrainingVehicleTimerView m_View;

	private float m_Timer;

	private int minute;

	private int sec;

	private int miSec;

	private int history;

	private bool play;

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

	private void ClearLastData()
	{
	}

	private void UpdateResult()
	{
	}

	private void SendRankResult(uint result)
	{
	}

	public void StartGame(bool b)
	{
	}

	private void OnMiniGameClose(object[] data)
	{
	}

	private void OnGoThroughtStartPoint(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
