namespace GCommon;

public class ResUpdaterProgressMonitor
{
	private long m_TotalSizeInByte;

	private long m_TotalLoadedSizeInByte;

	private long m_TotalLoadingSizeInByte;

	public long TotalSizeInByte => 0L;

	public long TotalLoadedSizeInByte => 0L;

	public void Clear()
	{
	}

	public void AddLoaderInfo(long fileSize)
	{
	}

	public void OnLoadInProgress(long loadedSize)
	{
	}

	public void OnLoadFinished(long loadedSize)
	{
	}
}
