namespace GCommon;

public class MutliRegionResDownloadContext : ResUpdateDownloadContext
{
	protected string DownloadRegion;

	public MutliRegionResDownloadContext(ResUpdateDownloadEngine owned_engine, ResDownloadType type, int maxLoaderCountSimultaneously, string lockRegion)
		: base(null, ResDownloadType.None, 0)
	{
	}

	protected override void onVersionChecked()
	{
	}

	protected override void InitLoginDownloadFileinfo()
	{
	}
}
