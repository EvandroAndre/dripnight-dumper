using System;
using UnityEngine;

namespace COW.GamePlay;

[Serializable]
public class ActSkillPhaseConfig
{
	public JJCCDCBPAED PhaseType;

	public bool m_IsFinishingPhase;

	public float m_MoveSpeedScale;

	public float m_PhaseDuration;

	public string m_AnimName;

	public string m_CustomParams;

	public bool m_IsSetAutoNextPhaseManually;

	public int m_AutoNextPhaseIndex;

	public bool m_IsSupportCombo;

	public int m_ComboNextPhaseIndex;

	public float m_ComboTriggerStartTime;

	public float m_comboTriggerEndTime;

	public bool IsUseSkillAutoMove;

	public float AutoMoveMAXSpeed;

	public AnimationCurve AutoMoveSpeedCurve;

	public float AutoMoveMAXSpeedY;

	public AnimationCurve AutoMoveSpeedYCurve;
}
