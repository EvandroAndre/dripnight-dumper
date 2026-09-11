using System;
using System.Collections.Generic;
using message;

namespace COW.GamePlay;

[Serializable]
public class SkillAnim
{
	public DCEDLLLOGBO m_SkillType;

	public List<PhaseAnim> m_PhaseAnims;
}
