using System.Collections.Generic;
using UnityEngine;
using message;

namespace COW.GamePlay;

public class InspectorActSkillConfig : ScriptableObject
{
	public DMPADEOHJNJ m_SkillType;

	public bool m_IsComboInputSkill;

	public bool m_IsForceCastSkill;

	public float m_CoolDown;

	public bool m_IsLockPlayerMove;

	public bool m_IsLockPlayerJump;

	public bool IsLockAimRotationUpdate;

	public bool IsForwardFollowAimRot;

	public bool IsFowardFollowMoveDirection;

	public List<ActSkillPhaseConfig> m_PhaseConfig;
}
