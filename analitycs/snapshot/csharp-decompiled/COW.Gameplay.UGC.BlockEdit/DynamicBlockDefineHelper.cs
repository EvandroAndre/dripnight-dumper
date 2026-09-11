using LitJson;

namespace COW.Gameplay.UGC.BlockEdit;

public abstract class DynamicBlockDefineHelper
{
	public JsonData OriginalBlockDefine;

	public abstract bool InitAdditionalFromSerializedData<T>(BlockDefine blockDefine, IBlockDeserializer<T> blockDeserializer, T serializedData) where T : class;

	public abstract bool InitAdditionalFromBlockData(BlockDefine blockDefine, BlockData blockData);

	public abstract void AddField(BlockDefine blockDefine, int bodyIndex, int index, SerializeBlockFieldDefine targetFieldDefine);

	public abstract SerializeBlockFieldDefine RemoveField(BlockDefine blockDefine, int bodyIndex, int index);

	public BlockDefine GenerateBlockDefineInstance(BlockEditContext context, string typeName)
	{
		return null;
	}
}
