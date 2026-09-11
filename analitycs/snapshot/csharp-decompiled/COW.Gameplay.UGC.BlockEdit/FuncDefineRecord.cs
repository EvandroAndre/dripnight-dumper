using System.Collections.Generic;

namespace COW.Gameplay.UGC.BlockEdit;

public class FuncDefineRecord
{
	public FuncDefineData DefineData;

	public readonly List<BlockRecord> Callers;

	public void Reset()
	{
	}

	public void CollectCallers(FuncDefineData defineData)
	{
	}
}
