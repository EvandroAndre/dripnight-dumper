using proto;

namespace COW;

public class UGCCustomModeTemplateRuleData
{
	public int ModeIndex;

	public int FallbackIndex;

	public bool Enabled;

	public bool MultiTeamEnabled;

	public bool EnabledGraph;

	public bool EnabledHUD;

	public static implicit operator UGCCustomModeTemplateRuleData(WorkshopCustomModeTemplateRuleDesc desc)
	{
		return null;
	}
}
