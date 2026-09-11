using System.Collections;
using System.Collections.Generic;

namespace COW.Gameplay.UGC.BlockEdit;

public class BlockEditLibraries
{
	public BlockEditContext Context;

	public readonly Dictionary<string, LibraryData> LibraryDict;

	public readonly Dictionary<string, BlockData> BlockDataDictionary;

	public BlockEditLibraries(BlockEditContext context)
	{
	}

	public bool Deserialize<T>(IBlockDeserializer<T> deserializer, IList serializedDataList) where T : class
	{
		return false;
	}
}
