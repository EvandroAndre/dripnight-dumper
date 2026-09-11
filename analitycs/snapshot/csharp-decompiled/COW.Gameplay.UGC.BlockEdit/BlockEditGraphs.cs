using System;
using System.Collections.Generic;
using message;

namespace COW.Gameplay.UGC.BlockEdit;

public class BlockEditGraphs
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<GraphData> _003C_003E9__25_0;

		public static Predicate<GraphData> _003C_003E9__25_1;

		public static Predicate<GraphData> _003C_003E9__25_2;

		public static Predicate<GraphData> _003C_003E9__25_3;

		public static Predicate<GraphData> _003C_003E9__25_4;

		public static Predicate<GraphData> _003C_003E9__25_5;

		internal bool _003CFindGlobalGraph_003Eb__25_0(GraphData e)
		{
			return false;
		}

		internal bool _003CFindGlobalGraph_003Eb__25_1(GraphData e)
		{
			return false;
		}

		internal bool _003CFindGlobalGraph_003Eb__25_2(GraphData e)
		{
			return false;
		}

		internal bool _003CFindGlobalGraph_003Eb__25_3(GraphData e)
		{
			return false;
		}

		internal bool _003CFindGlobalGraph_003Eb__25_4(GraphData e)
		{
			return false;
		}

		internal bool _003CFindGlobalGraph_003Eb__25_5(GraphData e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public string graphId;

		internal bool _003CRemoveGraph_003Eb__0(GraphData graphData)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass26_0
	{
		public string id;

		internal bool _003CFindGraphVar_003Eb__0(GraphData item)
		{
			return false;
		}
	}

	private BlockEditContext _003CContext_003Ek__BackingField;

	public List<GraphData> Graphs;

	public Dictionary<string, GraphData> GraphDictionary;

	public BlockEditContext Context
	{
		get
		{
			return _003CContext_003Ek__BackingField;
		}
		private set
		{
			_003CContext_003Ek__BackingField = value;
		}
	}

	public BlockEditGraphs(BlockEditContext context)
	{
	}

	public void Clear()
	{
	}

	public bool Deserialize<T>(IBlockDeserializer<T> deserializer, T serializedData, Action<GraphData> mockingFunc = null) where T : class
	{
		return false;
	}

	public bool Serialize<T>(IBlockSerializer<T> serializer, T serializedData, List<GraphData> graphs = null) where T : class
	{
		return false;
	}

	public bool CheckAndSerializeGraph<T>(IBlockSerializer<T> serializer, T serializedData, GraphData graph) where T : class
	{
		return false;
	}

	public void ToExportProtoData(List<GKGNPJEOEGP> protoSource)
	{
	}

	public bool IsGraphIdExist(string id)
	{
		return false;
	}

	public void AddGraph(GraphData graph)
	{
	}

	public void RemoveGraph(string graphId)
	{
	}

	public void UpdateRecursively<T>(UpdateType updateType, T param)
	{
	}

	public void UpdateExportableRecursively<T>(UpdateType updateType, T param, List<GraphData> graphs = null)
	{
	}

	public void CollectCustomString(EditorMiscData miscData)
	{
	}

	public bool CheckLegality()
	{
		return false;
	}

	public void CollectAllRefSceneEntity(EditorMiscData miscData, List<GraphData> graphs = null)
	{
	}

	public int GetTotalBlockCount(List<GraphData> graphs = null)
	{
		return 0;
	}

	public int GetClientGraphCount()
	{
		return 0;
	}

	public int GetGSGraphCount()
	{
		return 0;
	}

	public int GetClientBlockCount()
	{
		return 0;
	}

	public void UpdateAfterBuilt()
	{
	}

	public GraphData FindGlobalGraph(int declare = 0)
	{
		return null;
	}

	public GraphVarDefineData FindGraphVar(string id)
	{
		return null;
	}

	public GraphVarDefineData FindGraphVar(string graphId, string varId)
	{
		return null;
	}

	public GraphVarDefineData FindAvailableGraphVar(string currentGraphId, string varId)
	{
		return null;
	}

	public FuncDefineData FindFunc(string graphId, string funcId)
	{
		return null;
	}

	public FuncDefineData FindAvailableFunc(string currentGraphId, string funcId)
	{
		return null;
	}
}
