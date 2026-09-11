using System.Collections.Generic;
using System.IO;
using GCommon;
using proto;

namespace COW;

internal class TreasureBoxDataManager : SingletonModule<TreasureBoxDataManager>
{
	private UIModelStoreBox m_modelStoreBox;

	private IntervalTree m_TreasureBoxTree;

	private ushort[] m_BoxItemIndexArray;

	private uint[] m_BoxIdRangeArray;

	private byte[] m_TreasureBoxItemData;

	private int m_TreasureBoxItemDataByteSize;

	private List<ResourceID> m_resourceIDList;

	public void MultiThreadInit()
	{
	}

	protected override void OnInit()
	{
	}

	private void LoadCSVData()
	{
	}

	private bool LoadOptimizedTreasureBoxData()
	{
		return false;
	}

	private void LoadAndBuildIntervalTree(MemoryStream indexStream)
	{
	}

	private IntervalTree BuildIntervalTreeFromRanges(List<IntervalNode> ranges)
	{
		return null;
	}

	private void LoadTreasureBoxDataFromCSV()
	{
	}

	public List<TreasureBoxShowData> GetTreasureBoxDataById(uint id)
	{
		return null;
	}

	public bool HasTreasureBoxData(uint id)
	{
		return false;
	}

	private void GetTreasureBoxIndexRange(uint id, out ushort beginIdx, out ushort endIdx)
	{
		beginIdx = default(ushort);
		endIdx = default(ushort);
	}

	protected override void OnCleanup()
	{
	}
}
