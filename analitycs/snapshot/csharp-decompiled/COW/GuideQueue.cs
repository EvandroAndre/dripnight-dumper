using System.Collections.Generic;

namespace COW;

public class GuideQueue
{
	private sealed class _003C_003Ec__DisplayClass19_0
	{
		public GuideQueue _003C_003E4__this;

		public uint currentGuideQueueID;

		internal void _003CDelayExecuteGuidePeek_003Eb__0()
		{
		}
	}

	private const float DELAY_INTERVAL = 0.1f;

	private uint m_GuideQueueID;

	private uint m_DelayExecuteGuidePeek;

	private bool m_IsRunning;

	private UICommonGuideController m_CurrentOpenedGuideController;

	private readonly int m_GuideControllerDepth;

	private readonly bool m_IsSavedOnFinish;

	private readonly bool m_IsDebugLogOpen;

	private readonly IGuideQueueContainer m_Container;

	private readonly LinkedList<UICommonGuideData> m_GuideDataSteps;

	private readonly Queue<UICommonGuideData> m_GuideDataQueue;

	public static GuideQueue New(IGuideQueueContainer container, int depth, bool isSavedOnFinish = false, bool isDebugLogOpen = false)
	{
		return null;
	}

	private GuideQueue(IGuideQueueContainer container, int guideCtrlDepth, bool isSavedOnFinish, bool isDebugLogOpen)
	{
	}

	private void Log(string message, LogColor logColor)
	{
	}

	private void LogGuideStep(string stepKey, bool stepAvailable, UIWidget targetWidget, UIButton finishButton)
	{
	}

	private void UpdateGuideQueueID()
	{
	}

	private void StopInternal()
	{
	}

	private void ClearStepsInternal()
	{
	}

	private void SetGuideMaskActive(bool active)
	{
	}

	private void DelayExecuteGuidePeek()
	{
	}

	private void SkipStepAndExecuteNext()
	{
	}

	private void FinishStepAndExecuteNext(uint guideQueueID)
	{
	}

	private void StartDelayExecuteGuidePeek()
	{
	}

	private void Prepare()
	{
	}

	private void Exit()
	{
	}

	public void ClearSteps()
	{
	}

	public bool IsRunning()
	{
		return false;
	}

	public void AddStep(UICommonGuideData guideData)
	{
	}

	public bool Run()
	{
		return false;
	}

	public void Stop()
	{
	}
}
