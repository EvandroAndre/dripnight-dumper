using System.Collections.Generic;
using UnityEngine;

public class PVECopywriting : ScriptableObject
{
	public List<RoundTargetInfo> RoundTargetContent;

	public List<SubtitleInfo> BossRandomSubtitle;

	public List<SubtitleInfo> PlayerDeadSubtitle;

	public List<SubtitleInfo> TeamDeadSubtitle;

	public List<SkillSubtitleInfo> BossSkillTalkContent;

	public List<RuleInfo> GameRuleInfo;
}
