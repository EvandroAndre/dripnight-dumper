using System;
using System.Collections.Generic;
using message;

namespace COW.Gameplay.UGC.BlockEdit;

public class FuncDefineData
{
	public string id;

	protected string funcName;

	public bool ReturnTypeExisted;

	protected TypeInfo returnType;

	public List<LocalVarDefineData> paramDefines;

	public string DefinerId;

	public BlockData CallerData;

	public Action OnChanged;

	public Action OnRemoved;

	public BlockEditContext Context;

	public GraphData Graph;

	public string FuncName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public TypeInfo ReturnType
	{
		get
		{
			return default(TypeInfo);
		}
		set
		{
		}
	}

	public BlockData DefinerData => null;

	public FuncDefineData(BlockEditContext context)
	{
	}

	public bool Deserialize<T>(IBlockDeserializer<T> deserializer, T serializedData, BlockData owner) where T : class
	{
		return false;
	}

	public bool Serialize<T>(IBlockSerializer<T> serializer, T serializedData) where T : class
	{
		return false;
	}

	public DOMDODOIOBI ToExportProtoData()
	{
		return null;
	}

	public bool CreateCaller(BlockData definerData)
	{
		return false;
	}

	public FuncDefineData Clone(BlockData definer, GraphData graph)
	{
		return null;
	}

	public void AddParamDefine(LocalVarDefineData paramDefine, int index)
	{
	}

	public bool RemoveParamDefine(int index)
	{
		return false;
	}
}
