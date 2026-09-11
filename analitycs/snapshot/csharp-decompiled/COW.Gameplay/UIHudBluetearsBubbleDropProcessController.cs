using System.Collections.Generic;
using System.Text;
using GCommon;

namespace COW.Gameplay;

public class UIHudBluetearsBubbleDropProcessController : UIBaseController, IGameMissionTopEventUI
{
	public class DropProcessTimeRange
	{
		public float Start;

		public float End;

		public DropProcessTimeRange(float start, float end)
		{
		}
	}

	private UIHudBluetearsBubbleDropProcessView m_View;

	private List<DropProcessTimeRange> m_DropTimeRanges;

	private List<UIHudBluetearsBubbleDropProcessIcon> m_IconLst;

	private List<int> m_DropTimes;

	private float m_DropWaitTime;

	private StringBuilder m_Timer;

	private int m_CurLeftTime;

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

	private void InitIconLst()
	{
	}

	private void OnSyncDropProcess()
	{
	}

	private void UpdateUIView()
	{
	}

	private void UpdateTimeProcess(float curServerTime)
	{
	}

	private void UpdateTimeLabel(int timeLeft)
	{
	}

	private float CalProgress(float curServerTime)
	{
		return 0f;
	}

	private void Update()
	{
	}

	private void UpdateByInterval(float deltaTime)
	{
	}

	void IGameMissionTopEventUI.InitDataOnOpenFromGameMissionUI(object data)
	{
	}

	float IGameMissionTopEventUI.NeedHeight()
	{
		return 0f;
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
