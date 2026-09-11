using System;
using System.Collections.Generic;

namespace COW.Gameplay.UGC.BlockEdit;

public class LibraryData
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<BlockData> _003C_003E9__11_0;

		internal int _003CSort_003Eb__11_0(BlockData a, BlockData b)
		{
			return 0;
		}
	}

	private string _003CBlockCategory_003Ek__BackingField;

	private string _003CBlockSubType_003Ek__BackingField;

	public readonly List<BlockData> BlockDataList;

	public string BlockCategory
	{
		get
		{
			return _003CBlockCategory_003Ek__BackingField;
		}
		private set
		{
			_003CBlockCategory_003Ek__BackingField = value;
		}
	}

	public string BlockSubType
	{
		get
		{
			return _003CBlockSubType_003Ek__BackingField;
		}
		private set
		{
			_003CBlockSubType_003Ek__BackingField = value;
		}
	}

	public LibraryData(string blockCategory, string blockSubType)
	{
	}

	public void AddItem(BlockData blockData)
	{
	}

	public void Sort()
	{
	}
}
