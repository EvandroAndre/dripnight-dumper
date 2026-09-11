using System;
using System.Collections.Generic;
using GCommon;

namespace COW.Gameplay.UGC;

public class UGCTutorialGuideManager
{
	private sealed class _003C_003Ec__DisplayClass28_0
	{
		public UGCTutorialGuide_Dialogue dialogueGuide;

		public UGCTutorialGuideManager _003C_003E4__this;

		internal void _003CExecuteNextBlockingGuide_003Eb__1()
		{
		}
	}

	private const string DEFAULT_SPEAKER_LOC_KEY = "TXT_CHARACTER_RUNNER_NAME";

	private UIHudUGCTutorialDialogueController m_DialogueController;

	private List<UGCTutorialDialogueData> m_CurrentDialogues;

	private int m_CurrentDialogueIndex;

	private Action m_OnAllDialoguesComplete;

	private bool m_IsPlayingDialogues;

	private List<UGCTutorialGuideBase> m_BlockingGuides;

	private int m_BlockingGuideIndex;

	private Action m_OnAllBlockingGuidesComplete;

	private List<UGCTutorialGuideBase> m_ActiveGuides;

	private UGCTutorialMaskData m_CurrentMaskData;

	private UIHudUGCTutorialMaskController m_MaskController;

	private UIHudUGCTutorialTaskHintController m_TaskHintController;

	private Action m_OnDialogueSequenceStart;

	private Action m_OnDialogueSequenceEnd;

	public bool IsPlayingDialogues => false;

	public bool HasActiveGuides => false;

	public event Action OnDialogueSequenceStart
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action OnDialogueSequenceEnd
	{
		add
		{
		}
		remove
		{
		}
	}

	public void Init()
	{
	}

	public void Dispose()
	{
	}

	public void ExecuteGuides(List<UGCTutorialDialogueData> dialogues, List<UGCTutorialGuideData> guides, UGCTutorialMaskData mask, Action onAllBlockingComplete)
	{
	}

	private void PrepareGuides(List<UGCTutorialGuideData> guidesData)
	{
	}

	private void OnLegacyDialoguesComplete()
	{
	}

	private void ExecuteNextBlockingGuide()
	{
	}

	private void OnAllBlockingGuidesFinished()
	{
	}

	public void ShowActiveGuides()
	{
	}

	public void ReshowActiveGuides()
	{
	}

	public void HideAllActiveGuides()
	{
	}

	private void DisposeBlockingGuides()
	{
	}

	private void ShowActiveMask()
	{
	}

	private void HideActiveMask()
	{
	}

	private void LiftCommonGuideAboveActiveMask(UGCTutorialGuideBase guide)
	{
	}

	public void PlayDialogueSequence(List<UGCTutorialDialogueData> dialogues, Action onComplete)
	{
	}

	public void HideDialogue()
	{
	}

	private void EnsureDialogueController()
	{
	}

	private void CloseDialogueController()
	{
	}

	private void EnsureTaskHintController()
	{
	}

	private void CloseTaskHintController()
	{
	}

	private UIBaseController OpenTutorialUI(Type controllerType)
	{
		return null;
	}

	private void ShowCurrentDialogue()
	{
	}

	private void OnSingleDialogueComplete()
	{
	}

	private void OnAllDialoguesFinished()
	{
	}

	private void _003CExecuteNextBlockingGuide_003Eb__28_0()
	{
	}
}
