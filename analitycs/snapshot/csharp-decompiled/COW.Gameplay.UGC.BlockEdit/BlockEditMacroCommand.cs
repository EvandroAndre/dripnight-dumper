using GCommon.CommandPattern;

namespace COW.Gameplay.UGC.BlockEdit;

public class BlockEditMacroCommand : MacroCommand, IBlockEditCommand
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
