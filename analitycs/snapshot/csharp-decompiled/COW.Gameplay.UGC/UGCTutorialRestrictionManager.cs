using System.Collections.Generic;

namespace COW.Gameplay.UGC;

public class UGCTutorialRestrictionManager
{
	private static readonly Dictionary<string, UGCTutorialRestrictionType> s_NameToEnum;

	private HashSet<UGCTutorialRestrictionType> m_HideRestrictions;

	private HashSet<UGCTutorialRestrictionType> m_DisableRestrictions;

	private bool m_IsActive;

	public bool IsActive => false;

	static UGCTutorialRestrictionManager()
	{
	}

	public void Init()
	{
	}

	public void Dispose()
	{
	}

	public void ApplyRestrictions(UGCTutorialRestrictionData data)
	{
	}

	public void ClearRestrictions()
	{
	}

	public bool IsHidden(UGCTutorialRestrictionType type)
	{
		return false;
	}

	public bool IsDisabled(UGCTutorialRestrictionType type)
	{
		return false;
	}

	public static bool TryParseRestrictionType(string name, out UGCTutorialRestrictionType result)
	{
		result = default(UGCTutorialRestrictionType);
		return false;
	}

	private static void ParseRestrictionList(List<string> source, HashSet<UGCTutorialRestrictionType> dest)
	{
	}

	private void NotifyRestrictionChanged()
	{
	}
}
