using COW.Gameplay.UGC.BlockEdit;

namespace COW;

public class BEEnumData
{
	public string LabelKey;

	public TypeInfo ValueType;

	public string StringValue;

	public long IntValue;

	public bool BoolValue;

	public bool IsHidden;

	public bool IsObsolete;

	public bool IsEqual(ValueData valueData)
	{
		return false;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_Equals(object P0)
	{
		return false;
	}
}
