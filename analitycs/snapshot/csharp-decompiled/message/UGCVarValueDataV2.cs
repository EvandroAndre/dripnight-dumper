using System.Collections.Generic;
using ProtoBuf;

namespace message;

public class UGCVarValueDataV2
{
	private DiscriminatedUnion32Object __pbn__Value;

	public List<UGCVarValueDataV2> ListValue;

	public IJHPDKODECM MapValue;

	public long Int64Value;

	public bool IsList
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public DOMDODOIOBI FuncValue
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool BoolValue
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public int IntValue
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public float FloatValue
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public string StringValue
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public KCEOCGOLEAD Vector3Value
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string EntityRefValue
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public LGDCLLICIIC QuaternionValue
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public BHHFHBEKKFJ Vector2Value
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string LocStringValue
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool IsMap
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsFuncPoint
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsInt64
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool ShouldSerializeIsList()
	{
		return false;
	}

	public void ResetIsList()
	{
	}

	public bool ShouldSerializeFuncValue()
	{
		return false;
	}

	public void ResetFuncValue()
	{
	}

	public bool ShouldSerializeBoolValue()
	{
		return false;
	}

	public void ResetBoolValue()
	{
	}

	public bool ShouldSerializeIntValue()
	{
		return false;
	}

	public void ResetIntValue()
	{
	}

	public bool ShouldSerializeFloatValue()
	{
		return false;
	}

	public void ResetFloatValue()
	{
	}

	public bool ShouldSerializeStringValue()
	{
		return false;
	}

	public void ResetStringValue()
	{
	}

	public bool ShouldSerializeVector3Value()
	{
		return false;
	}

	public void ResetVector3Value()
	{
	}

	public bool ShouldSerializeEntityRefValue()
	{
		return false;
	}

	public void ResetEntityRefValue()
	{
	}

	public bool ShouldSerializeQuaternionValue()
	{
		return false;
	}

	public void ResetQuaternionValue()
	{
	}

	public bool ShouldSerializeVector2Value()
	{
		return false;
	}

	public void ResetVector2Value()
	{
	}

	public bool ShouldSerializeLocStringValue()
	{
		return false;
	}

	public void ResetLocStringValue()
	{
	}

	public bool ShouldSerializeIsMap()
	{
		return false;
	}

	public void ResetIsMap()
	{
	}

	public bool ShouldSerializeIsFuncPoint()
	{
		return false;
	}

	public void ResetIsFuncPoint()
	{
	}

	public bool ShouldSerializeIsInt64()
	{
		return false;
	}

	public void ResetIsInt64()
	{
	}
}
