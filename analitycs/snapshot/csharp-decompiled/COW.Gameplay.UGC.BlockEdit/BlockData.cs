using System;
using System.Collections.Generic;
using message;

namespace COW.Gameplay.UGC.BlockEdit;

public class BlockData
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<ValueData, int> _003C_003E9__33_0;

		internal int _003CToExportProtoData_003Eb__33_0(ValueData item)
		{
			return 0;
		}
	}

	public float positionX;

	public float positionY;

	public string id;

	public string blockName;

	public List<BodyData> bodies;

	public List<ValueData> values;

	public BlockDefine BlockDefine;

	public BlockEditContext Context;

	public IBlockDataContainer Parent;

	public GraphData Graph;

	public bool Enabled;

	public object UserRef;

	private string mBlockDescKey;

	public TypeInfo ReturnType;

	public Action OnTypeUpdated;

	public Action OnAvailableUpdated;

	public int ChildrenBlockCount;

	public bool WasAvailable;

	public bool IsAvailable;

	public CNDCGBPDHEB.IJGKGIFOLGH ErrorCode;

	public string typeName => null;

	public bool IsInGraph => false;

	public string BlockDescKey => null;

	public UGCBlockConfigData ConfigData => null;

	public bool GetEnabledInHierarchy()
	{
		return false;
	}

	public BlockData(BlockEditContext context)
	{
	}

	public bool Deserialize<T>(IBlockDeserializer<T> deserializer, T serializedData) where T : class
	{
		return false;
	}

	private void TryRedirectTemplateEntityGetterValue()
	{
	}

	public bool Serialize<T>(IBlockSerializer<T> serializer, T serializedData) where T : class
	{
		return false;
	}

	public DOMDODOIOBI ToExportProtoData()
	{
		return null;
	}

	public BlockData Clone(IBlockDataContainer parent, GraphData graphData)
	{
		return null;
	}

	public BlockData CloneForCopy(GraphData targetGraph, bool redirectRefs)
	{
		return null;
	}

	public BlockData CloneWithoutClearLocalVarCache(IBlockDataContainer parent, GraphData graphData)
	{
		return null;
	}

	internal BlockData InternalClone(IBlockDataContainer parent, GraphData graphData)
	{
		return null;
	}

	public void RegisterLocalVar(GraphData graphData)
	{
	}

	public void UnregisterLocalVar(GraphData graphData)
	{
	}

	public bool InitByDefine()
	{
		return false;
	}

	public bool UpdateSelf<T>(UpdateType updateType, T param)
	{
		return false;
	}

	public void UpdateRecursively<T>(UpdateType updateType, T param)
	{
	}

	public void UpdateSelfAndParent<T>(UpdateType updateType, T param)
	{
	}

	public bool StopUpdateBodiesIf<T>(UpdateType updateType, T param)
	{
		return false;
	}

	public bool StopUpdateValuesIf<T>(UpdateType updateType, T param)
	{
		return false;
	}

	private bool ShouldSkipEnumObsoleteCheck(string enumType)
	{
		return false;
	}

	public void UpdateCount()
	{
	}

	private void UpdateForValuesChanged()
	{
	}

	public void CheckCollectSceneEntityRef(EditorMiscData miscData)
	{
	}

	public void CheckBlockDataWithCollectCondition(CollectBlockWithConditionContext context)
	{
	}

	public bool CheckLegality()
	{
		return false;
	}

	public bool CheckLocalVarInDefineRange(string defineId, bool isParent, bool avoidCheckingBrother = false)
	{
		return false;
	}

	private bool IsLoopAPIWithVarDefine(string typeString)
	{
		return false;
	}

	public int GetSectionSplicingCount()
	{
		return 0;
	}

	public BlockData GetRootParent()
	{
		return null;
	}

	public void AddField(ValueData target, int index, int bodyIndex)
	{
	}

	public void RemoveField(int index, int bodyIndex)
	{
	}

	private bool _003CUpdateForValuesChanged_003Eb__48_0(UGCHudWidgetIndexInfo item)
	{
		return false;
	}
}
