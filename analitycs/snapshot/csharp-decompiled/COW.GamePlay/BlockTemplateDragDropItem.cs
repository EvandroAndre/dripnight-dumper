using COW.Gameplay.UGC.BlockEdit;

namespace COW.GamePlay;

public class BlockTemplateDragDropItem : UIDragDropItem
{
	public BlockTemplateData Data;

	protected BE_DragDropManager EKDOMLLCLCA;

	protected override void Start()
	{
	}

	public override bool StartDragging()
	{
		return false;
	}

	public virtual bool EnableCreateBlock(BlockData POANKHIAKCN)
	{
		return false;
	}

	public void CreateBlockObj()
	{
	}

	public void _003C_003EiFixBaseProxy_Start()
	{
	}

	public bool _003C_003EiFixBaseProxy_StartDragging()
	{
		return false;
	}
}
