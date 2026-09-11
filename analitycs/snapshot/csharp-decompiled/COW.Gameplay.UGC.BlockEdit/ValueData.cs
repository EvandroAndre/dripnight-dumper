using UnityEngine;
using message;

namespace COW.Gameplay.UGC.BlockEdit;

public class ValueData : IBlockDataContainer
{
	public EditorValueType EditorValueType;

	public TypeInfo ActualType;

	public TypeInfo FormalType;

	private bool boolValue;

	private long intValue;

	private float floatValue;

	private string stringValue;

	private Vector3 vector3Value;

	public BlockData value;

	public LocalVarDefineData localVarDefineValue;

	public FuncDefineData funcDefineValue;

	public HudEventDefineData HudEventDefineData;

	public UserCustomEventRefValue userCustomEventRefValue;

	public DispatchUserCustomEventRefValue dispatchUserCustomEventRefValue;

	public FuncRefValue funcRefValue;

	public ArrayValue arrayValue;

	public BlockEditContext Context;

	public BlockData Owner;

	public SerializeBlockFieldDefine FieldDefine;

	public int FieldIndex;

	public GraphData Graph;

	public object UserRef;

	public bool IsAvailable;

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

	public long IntValue
	{
		get
		{
			return 0L;
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

	public Vector3 Vector3Value
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	private void UpdateOwnerForValueChange()
	{
	}

	public ValueData(BlockEditContext context)
	{
	}

	public bool Deserialize<T>(IBlockDeserializer<T> deserializer, T serializedData, BlockData owner) where T : class
	{
		return false;
	}

	public bool Deserialize<T>(IBlockDeserializer<T> deserializer, T serializedData) where T : class
	{
		return false;
	}

	public bool Serialize<T>(IBlockSerializer<T> serializer, T serializedData) where T : class
	{
		return false;
	}

	internal ValueData Clone(BlockData owner, SerializeBlockFieldDefine fieldDefine, GraphData graphData)
	{
		return null;
	}

	public UGCVarValueDataV2 ToExportProtoData()
	{
		return null;
	}

	public bool ToExportProtoData(UGCVarValueDataV2 result)
	{
		return false;
	}

	public BlockData GetOwner()
	{
		return null;
	}

	public int GetChildIndex(BlockData blockData)
	{
		return 0;
	}

	public bool AddBlockData(BlockData blockData, int index, bool doRegistering = false)
	{
		return false;
	}

	public bool RemoveBlockData(BlockData blockData, bool doUnregistering = false)
	{
		return false;
	}

	public bool AddBlockData(BlockRecord record)
	{
		return false;
	}

	public bool RemoveBlockData(BlockRecord record)
	{
		return false;
	}

	public void UpdateSelf<T>(UpdateType updateType, T param)
	{
	}

	public void UpdateSelfAndParent<T>(UpdateType updateType, T param)
	{
	}

	public void UpdateRecursively<T>(UpdateType updateType, T param)
	{
	}

	public bool CheckSlotLegality()
	{
		return false;
	}

	private void CheckLegality()
	{
	}
}
