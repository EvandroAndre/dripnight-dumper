namespace COW.Gameplay.UGC.BlockEdit;

public class LogicalOperationBlockDefineHelper : FieldExtendableBlockDefineHelper
{
	public override SerializeBlockFieldDefine CreateDynamicFieldDefine(BlockDefine blockDefine, int serializedFieldIndex)
	{
		return null;
	}

	public override bool GetFieldIndexFromSerializedFieldIndex(int serializedFieldIndex, out int fieldIndex)
	{
		fieldIndex = default(int);
		return false;
	}
}
