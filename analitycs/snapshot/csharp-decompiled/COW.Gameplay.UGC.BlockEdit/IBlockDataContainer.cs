namespace COW.Gameplay.UGC.BlockEdit;

public interface IBlockDataContainer
{
	BlockData GetOwner();

	int GetChildIndex(BlockData blockData);

	bool AddBlockData(BlockData blockData, int index, bool doRegistering);

	bool RemoveBlockData(BlockData blockData, bool doUnregistering);

	bool AddBlockData(BlockRecord record);

	bool RemoveBlockData(BlockRecord record);
}
