using System.Collections.Generic;

namespace COW.Gameplay.UGC.BlockEdit;

public class FuncParamRecord
{
	public FuncDefineData DefineData;

	public readonly VarRecord ParamDefineRecord;

	public int Index;

	public readonly List<BlockData> Callers;

	public readonly List<ValueData> ParamSlots;

	public readonly List<BlockRecord> DataBlocksInParamSlot;

	public void Reset()
	{
	}
}
