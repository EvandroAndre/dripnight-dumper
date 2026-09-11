namespace COW;

public enum EDragOperationResultType
{
	None,
	Success,
	SourceCapacityFull,
	TargetCapacityFull,
	ItemSlotWrong,
	CannotInBag,
	CannotInSafeBox,
	Split,
	PrepareOrMatchMaking,
	BackpackReplaceCapInsufficient,
	Purchase,
	DragDropPart
}
