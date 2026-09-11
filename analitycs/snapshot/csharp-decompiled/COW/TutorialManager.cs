using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class TutorialManager : SingletonModule<TutorialManager>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<NewPlayerInGameGuideData, uint> _003C_003E9__22_0;

		internal uint _003CLoadCSV_003Eb__22_0(NewPlayerInGameGuideData value)
		{
			return 0u;
		}
	}

	private sealed class _003C_003Ec__DisplayClass27_0
	{
		public TutorialManager _003C_003E4__this;

		public float interval;

		internal void _003CPlayTwoLineRepeatedShrink_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass35_0
	{
		public TutorialManager _003C_003E4__this;

		public Action OnStop;

		internal void _003CShowTutorial_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass52_0
	{
		public TutorialManager _003C_003E4__this;

		public uint eventTypeId;

		internal void _003CShowParallelTutorial_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass58_0
	{
		public TutorialManager _003C_003E4__this;

		public TutorialEventEnum eventType;

		public float interval;

		internal void _003CPlayParallelTwoLineRepeatedShrink_003Eb__0()
		{
		}
	}

	private const string TutorialKey = "TutorialStep";

	private List<ulong> m_TutorialStepFlag;

	private List<ulong> m_TutorialStepFlag_ThisLauncher;

	private Dictionary<uint, List<TutorialSetting>> m_TutSettingsByBotAgentPromot;

	private int stepFlagCount;

	private CSVAsyncDataMap<uint, NewPlayerInGameGuideData> m_CSVDic;

	private Dictionary<int, TutorialSetting> m_TutSettings;

	private UITutorialIndicatorController m_TutController;

	public TutorialVariant variant;

	private static bool isNewbiePlayer;

	private TutorialEventEnum m_CurTutorial;

	private uint delayCallId;

	private uint delayCallIdScale;

	private Action m_OnStop;

	private Queue<UITutorialIndicatorController> m_ParallelControllerPool;

	private Dictionary<uint, UITutorialIndicatorController> m_ParallelActiveControllers;

	private HashSet<uint> m_ParallelActiveTutorials;

	private Dictionary<uint, uint> m_ParallelDelayCallIds;

	private Dictionary<uint, uint> m_ParallelDelayCallScaleIds;

	private Dictionary<uint, Action> m_ParallelOnStopCallbacks;

	private Dictionary<uint, List<TutorialSetting>> TutSettingsByBotAgentPromot => null;

	private Dictionary<int, TutorialSetting> TutSettings => null;

	public TutorialEventEnum CurrentTutorialType()
	{
		return TutorialEventEnum.None;
	}

	public void ClearTutorialType()
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	private void LoadCSV()
	{
	}

	private void InitTutorialSettings()
	{
	}

	private bool GetBackendFlag(uint eventTypeId)
	{
		return false;
	}

	public void Stop(TutorialEventEnum type = TutorialEventEnum.TutorialEventMax, bool noNeedCheckNextTuto = false, TutorialCloseType closeType = TutorialCloseType.None)
	{
	}

	private void StopLast()
	{
	}

	private void PlayTwoLineRepeatedShrink(float interval)
	{
	}

	private bool CheckAndShowNextTuto(TutorialEventEnum type)
	{
		return false;
	}

	public static void SetReinstallEffective()
	{
	}

	public bool IsFinished(TutorialEventEnum eventType)
	{
		return false;
	}

	public bool IsNew(TutorialEventEnum eventType)
	{
		return false;
	}

	public void SetTutorialFinish(TutorialEventEnum eventType)
	{
	}

	public void SetTutorialNotFinish(TutorialEventEnum eventType)
	{
	}

	public void ResetAllTutorial()
	{
	}

	public bool ShowTutorial(TutorialEventEnum eventType, UIButton bindBtn = null, UIWidget bindWidget = null, bool alwaysShow = false, bool isForceClickComplete = false, bool isMaskAll = false, TutorialWidgetVariable widgetVariable = null, AdjacentEdge targetEdge = AdjacentEdge.None, Vector3 hintOffsetPos = default(Vector3), bool stopOnPressWithUIEventTrigger = true, bool hideCharacterWithNoBindWidget = true, ArrowCustomSettings arrowCustomSettings = null, Action OnStop = null, bool forceFinished = true)
	{
		return false;
	}

	public void SetTutorialParams(TutorialEventEnum eventType, string param)
	{
	}

	public void RefreshTutorialPosition(Transform showTrans)
	{
	}

	public void RefreshTutorialWholePosition(Transform showTrans)
	{
	}

	public void SetCurrentTutorialPanelDepth(int depth)
	{
	}

	public bool CanShowTutorial(TutorialEventEnum eventType)
	{
		return false;
	}

	public void StopClimb()
	{
	}

	public float GetDuration(TutorialEventEnum eventType)
	{
		return 0f;
	}

	public void SetTutorialHandLocalTrans(Vector3 pos, Vector3 scale)
	{
	}

	public string GetHintText(TutorialEventEnum eventType)
	{
		return null;
	}

	public void RefreshNewBieInGameGuideFinishedByBotAgentPromot(uint botAgentPromotECAId)
	{
	}

	public bool ShowParallelTutorial(TutorialEventEnum eventType, UIButton bindBtn = null, UIWidget bindWidget = null, bool alwaysShow = false, bool isForceClickComplete = false, bool isMaskAll = false, TutorialWidgetVariable widgetVariable = null, AdjacentEdge targetEdge = AdjacentEdge.None, Vector3 hintOffsetPos = default(Vector3), bool stopOnPressWithUIEventTrigger = true, bool hideCharacterWithNoBindWidget = true, ArrowCustomSettings arrowCustomSettings = null, Action OnStop = null, bool forceFinished = true)
	{
		return false;
	}

	private void StopParallelTutorial(uint eventType)
	{
	}

	public void StopParallelTutorial(TutorialEventEnum eventType)
	{
	}

	public void StopAllParallelTutorials()
	{
	}

	private UITutorialIndicatorController GetParallelControllerFromPool()
	{
		return null;
	}

	private void ReturnParallelControllerToPool(UITutorialIndicatorController controller)
	{
	}

	private void PlayParallelTwoLineRepeatedShrink(TutorialEventEnum eventType, float interval)
	{
	}

	private void ClearParallelControllerPool()
	{
	}
}
