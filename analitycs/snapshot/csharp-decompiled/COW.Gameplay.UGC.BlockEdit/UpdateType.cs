namespace COW.Gameplay.UGC.BlockEdit;

public enum UpdateType
{
	None,
	Type,
	VarRefType,
	RefClone,
	RefCloneForEntityClone,
	CollectCustomString,
	RegisterToGraph,
	UnregisterFromGraph,
	CheckBlockLegality,
	GetCount,
	FuncRefType,
	FuncRefAddItem,
	FuncRefRemoveItem,
	FuncRefGraphRef,
	HudEventGraphRef,
	CollectVarRef,
	CollectLocalVarDefine,
	CollectFuncCaller,
	MapDefineId,
	CollectResRef,
	CollectSceneEntityRef,
	CollectBlockWithCondition
}
