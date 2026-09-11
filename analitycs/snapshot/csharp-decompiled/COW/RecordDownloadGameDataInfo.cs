namespace COW;

public class RecordDownloadGameDataInfo
{
	private sealed class _003C_003Ec__DisplayClass15_0
	{
		public string workshopCode;

		internal bool _003CStartDownload_003Eb__0(string x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass16_0
	{
		public string workshopCode;

		internal bool _003CFinishDownload_003Eb__0(string x)
		{
			return false;
		}
	}

	private readonly string[] m_WorkshopCodes;

	private int _003CResult_003Ek__BackingField;

	private uint _003CDownloadTime_003Ek__BackingField;

	private ulong[] m_StartDownloadTimes;

	private int[] m_DownloadSizes;

	private ulong[] m_FinishDownloadTimes;

	public int Result
	{
		get
		{
			return _003CResult_003Ek__BackingField;
		}
		private set
		{
			_003CResult_003Ek__BackingField = value;
		}
	}

	public uint DownloadTime
	{
		get
		{
			return _003CDownloadTime_003Ek__BackingField;
		}
		private set
		{
			_003CDownloadTime_003Ek__BackingField = value;
		}
	}

	public RecordDownloadGameDataInfo(string[] workshopCodes)
	{
	}

	public bool IsSame(string[] workshopCodes)
	{
		return false;
	}

	public void Reset()
	{
	}

	public void StartDownload(string workshopCode)
	{
	}

	public void FinishDownload(string workshopCode, byte[] dataBytes)
	{
	}
}
