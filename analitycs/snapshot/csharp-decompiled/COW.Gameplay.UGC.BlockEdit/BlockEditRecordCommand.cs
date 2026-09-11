using GCommon.CommandPattern;

namespace COW.Gameplay.UGC.BlockEdit;

public abstract class BlockEditRecordCommand : RecordCommand, IBlockEditCommand
{
	private GraphData _003CGraph_003Ek__BackingField;

	public GraphData Graph
	{
		get
		{
			return _003CGraph_003Ek__BackingField;
		}
		set
		{
			_003CGraph_003Ek__BackingField = value;
		}
	}
}
