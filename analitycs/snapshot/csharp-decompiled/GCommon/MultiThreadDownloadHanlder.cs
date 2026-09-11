using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Networking;

namespace GCommon;

public class MultiThreadDownloadHanlder : DownloadHandlerScript
{
	private Action<byte[], uint, int> m_OnComplete;

	public uint DataIndex;

	public static Dictionary<int, MemoryStream> REUSED_MEM_MAP;

	public static MemoryStream REUSED_MEM;

	private MemoryStream reused_download_data;

	private MemoryStream download_data;

	private int download_size;

	private bool should_reused_mem;

	private bool m_ReuseUseMap;

	private long m_CellSize;

	public MultiThreadDownloadHanlder(Action<byte[], uint, int> complete_callback, int download_type, uint index, bool should_reusememorydata, long cell_size, bool useMap = true)
	{
	}

	private MemoryStream GetMemoryData()
	{
		return null;
	}

	private bool IsMemoryStreamValid()
	{
		return false;
	}

	private void ClearMemoryData()
	{
	}

	protected override byte[] GetData()
	{
		return null;
	}

	protected override bool ReceiveData(byte[] remote_data, int dataLength)
	{
		return false;
	}

	protected override void CompleteContent()
	{
	}
}
