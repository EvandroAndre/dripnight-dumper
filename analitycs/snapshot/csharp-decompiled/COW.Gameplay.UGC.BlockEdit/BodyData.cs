using System;
using System.Collections.Generic;
using message;

namespace COW.Gameplay.UGC.BlockEdit;

public class BodyData : IBlockDataContainer
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<ValueData, int> _003C_003E9__11_0;

		internal int _003CToExportProtoData_003Eb__11_0(ValueData item)
		{
			return 0;
		}
	}

	public List<BlockData> actions;

	public List<ValueData> values;

	public BlockEditContext Context;

	public ProcessBlockBodyDefine BodyDefine;

	public BlockData Owner;

	public GraphData Graph;

	public object UserRef;

	public BodyData(BlockEditContext context)
	{
	}

	public bool InitByDefine()
	{
		return false;
	}

	public virtual bool Deserialize<T>(IBlockDeserializer<T> deserializer, T serializedData) where T : class
	{
		return false;
	}

	public virtual bool Serialize<T>(IBlockSerializer<T> serializer, T serializedData) where T : class
	{
		return false;
	}

	public DOMDODOIOBI ToExportProtoData()
	{
		return null;
	}

	internal BodyData Clone(BlockData owner, ProcessBlockBodyDefine bodyDefine, GraphData graphData)
	{
		return null;
	}

	public void RegisterLocalVar(GraphData graphData)
	{
	}

	public void UnregisterLocalVar(GraphData graphData)
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

	public bool UpdateSelf<T>(UpdateType updateType, T param)
	{
		return false;
	}

	public void UpdateRecursively<T>(UpdateType updateType, T param)
	{
	}
}
