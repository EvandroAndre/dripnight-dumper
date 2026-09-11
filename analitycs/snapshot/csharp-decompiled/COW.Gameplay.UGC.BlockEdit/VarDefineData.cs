using System;

namespace COW.Gameplay.UGC.BlockEdit;

public class VarDefineData
{
	public string id;

	protected string varName;

	protected TypeInfo m_VarTypeInfo;

	internal bool isVarNameModified;

	public ValueData defaultValue;

	public BlockData GetterData;

	public BlockData SetterData;

	public Action OnChanged;

	public Action OnRemoved;

	public BlockEditContext Context;

	public GraphData Graph;

	public object UserRef;

	public virtual string VarName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public TypeInfo VarTypeInfo
	{
		get
		{
			return default(TypeInfo);
		}
		set
		{
		}
	}

	public VarDefineData(BlockEditContext context)
	{
	}

	public virtual bool Deserialize<T>(IBlockDeserializer<T> deserializer, T serializedData) where T : class
	{
		return false;
	}

	public virtual bool Serialize<T>(IBlockSerializer<T> serializer, T serializedData) where T : class
	{
		return false;
	}

	public bool UpdateGetter(BlockData getterData)
	{
		return false;
	}

	public bool UpdateSetter(BlockData setterData)
	{
		return false;
	}
}
