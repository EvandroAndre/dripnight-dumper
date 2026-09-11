using System;
using System.Collections.Generic;
using GCommon.CommandPattern;
using message;

namespace COW.Gameplay.UGC.BlockEdit;

public class GraphData : IBlockDataContainer
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<ValueData> _003C_003E9__64_0;

		internal void _003CClearBlockAvailable_003Eb__64_0(ValueData v)
		{
		}
	}

	[Serializable]
	private sealed class _003C_003Ec__34<T> where T : class
	{
		public static readonly _003C_003Ec__34<T> _003C_003E9;

		public static Comparison<GraphVarDefineData> _003C_003E9__34_0;

		internal int _003CDeserializeGraphCoreContent_003Eb__34_0(GraphVarDefineData x, GraphVarDefineData y)
		{
			return 0;
		}
	}

	public string id;

	private bool mIsDeleted;

	private string m_EntityID;

	private TypeInfo m_EntityType;

	public CanvasData Canvas;

	public List<BlockData> RootBlockDataList;

	public Dictionary<string, GraphVarDefineData> GraphVarDefines;

	public List<GraphVarDefineData> GraphVarDefinesList;

	private BlockEditContext _003CContext_003Ek__BackingField;

	private CommandFactory CommandFactory;

	public BlockEditCommandManager CommandManager;

	public Dictionary<string, LocalVarDefineData> LocalVarDefines;

	public Dictionary<string, BlockData> AllBlockDatas;

	public Dictionary<string, FuncDefineData> FuncDefines;

	public bool CheckLegalityPassed;

	public int Declare;

	public string LastEditTime;

	public string BlockTemplateName;

	public string BlockTemplateDescription;

	public bool IsDeleted
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public string EntityID
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string EntityType
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

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

	internal GraphData(BlockEditContext context)
	{
	}

	public bool Deserialize<T>(IBlockDeserializer<T> deserializer, T serializedData, Action<GraphData> mockingFunc = null) where T : class
	{
		return false;
	}

	public bool DeserializeBlockTemplate<T>(IBlockDeserializer<T> deserializer, T serializedData) where T : class
	{
		return false;
	}

	public bool DeserializeGraphCoreContent<T>(IBlockDeserializer<T> deserializer, T serializedData) where T : class
	{
		return false;
	}

	public bool Serialize<T>(IBlockSerializer<T> serializer, T serializedData) where T : class
	{
		return false;
	}

	public bool SerializeGraphCoreContent<T>(IBlockSerializer<T> serializer, T serializedData) where T : class
	{
		return false;
	}

	public GKGNPJEOEGP ToExportProtoData(BlockEditContext context)
	{
		return null;
	}

	public GraphData Clone(string entityId, bool forUserBlock = false, bool forEntityClone = false)
	{
		return null;
	}

	public void CloneCoreContent(GraphData result, bool forEntityClone = false)
	{
	}

	public bool RegisterLocalVar(LocalVarDefineData varDefineData)
	{
		return false;
	}

	public bool UnregisterLocalVar(string varId)
	{
		return false;
	}

	public void RegisterLocalVar(VarRecord varRecord)
	{
	}

	public void UnregisterLocalVar(VarRecord varRecord)
	{
	}

	public bool AddGraphVar(GraphVarRecord record)
	{
		return false;
	}

	public void RemoveGraphVar(GraphVarRecord record)
	{
	}

	public bool RegisterFunc(FuncDefineData funcDefineData)
	{
		return false;
	}

	public bool UnregisterFunc(string funcId)
	{
		return false;
	}

	public FuncDefineData CreateFunc(string funcName, TypeInfo returnType, List<string> paramNames, List<string> paramTypes, out BlockData definerData)
	{
		definerData = null;
		return null;
	}

	public T CreateCommand<T>() where T : Command, IBlockEditCommand, new()
	{
		return null;
	}

	public void ReleaseCommand<T>(T command) where T : Command, IBlockEditCommand
	{
	}

	public BlockData GetOwner()
	{
		return null;
	}

	public int GetChildIndex(BlockData blockData)
	{
		return 0;
	}

	public bool AddBlockData(BlockData blockData, int index, bool doRegistering = true)
	{
		return false;
	}

	public bool RemoveBlockData(BlockData blockData, bool doUnregistering = true)
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

	public void RefreshGraphVarDefinesIndex()
	{
	}

	public void UpdateRecursively<T>(UpdateType updateType, T param)
	{
	}

	public void UpdateExportableRecursively<T>(UpdateType updateType, T param)
	{
	}

	public void CollectCustomString(EditorMiscData miscData)
	{
	}

	public void CollectAllRefSceneEntity(EditorMiscData miscData)
	{
	}

	public bool CheckLegality()
	{
		return false;
	}

	public bool IsLegalEvent(BlockData blockData, List<string> eventList)
	{
		return false;
	}

	public void ClearBlockAvailable()
	{
	}

	public void UpdateAfterImportBlockTemplateBuilt()
	{
	}

	public void Clear()
	{
	}

	public bool IsEmpty()
	{
		return false;
	}
}
