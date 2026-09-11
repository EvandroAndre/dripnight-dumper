namespace COW.Gameplay.UGC.BlockEdit;

public abstract class FieldExtendableBlockDefineHelper : DynamicBlockDefineHelper
{
	public override bool InitAdditionalFromSerializedData<T>(BlockDefine blockDefine, IBlockDeserializer<T> blockDeserializer, T serializedData)
	{
		return false;
	}

	public override bool InitAdditionalFromBlockData(BlockDefine blockDefine, BlockData blockData)
	{
		return false;
	}

	protected virtual bool BuildFieldDefines(BlockDefine blockDefine, int valueCount)
	{
		return false;
	}

	public abstract SerializeBlockFieldDefine CreateDynamicFieldDefine(BlockDefine blockDefine, int serializedFieldIndex);

	public abstract bool GetFieldIndexFromSerializedFieldIndex(int serializedFieldIndex, out int fieldIndex);

	public override void AddField(BlockDefine blockDefine, int bodyIndex, int index, SerializeBlockFieldDefine targetFieldDefine)
	{
	}

	public override SerializeBlockFieldDefine RemoveField(BlockDefine blockDefine, int bodyIndex, int index)
	{
		return null;
	}
}
