using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using GCommon;
using proto;

namespace COW;

internal class BundleDataManager : SingletonModule<BundleDataManager>
{
	[StructLayout(LayoutKind.Explicit)]
	private struct BytesToInt
	{
		[FieldOffset(0)]
		public byte[] bytes;

		[FieldOffset(0)]
		public uint[] datas;
	}

	private List<ResourceID> m_resourceIDList;

	private IntervalTree m_bundleTree;

	private uint[] m_packedOffsetAndCounts;

	private uint[] m_bundleData;

	public void MultiThreadInit()
	{
	}

	protected override void OnInit()
	{
	}

	private void LoadCSVData()
	{
	}

	public void LoadLocalBundleData()
	{
	}

	private bool LoadOptimizedBundleData()
	{
		return false;
	}

	private void GetBundleDataOffsetAndCnt(uint bundleID, out int offset, out byte count)
	{
		offset = default(int);
		count = default(byte);
	}

	public bool ContainsBundleData(uint bundleID)
	{
		return false;
	}

	public List<BundleShowData> GetBundleDataByID(uint bundleID)
	{
		return null;
	}

	private void LoadAndBuildIntervalTree(MemoryStream indexStream)
	{
	}

	private IntervalTree BuildIntervalTreeFromRanges(List<IntervalNode> ranges)
	{
		return null;
	}

	protected override void OnCleanup()
	{
	}
}
