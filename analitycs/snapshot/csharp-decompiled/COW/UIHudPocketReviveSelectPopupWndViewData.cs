namespace COW;

public class UIHudPocketReviveSelectPopupWndViewData
{
	public readonly bool SingleSelection;

	public readonly uint LevelObjectID;

	public readonly int MaxReviveTargets;

	public readonly UIHudPocketReviveSelectCandidateItemViewData[] Candidates;

	public UIHudPocketReviveSelectPopupWndViewData(bool singleSelection, uint levelObjectID, int maxReviveTargets, UIHudPocketReviveSelectCandidateItemViewData[] candidates)
	{
	}
}
