using COW;
using UnityEngine.Networking;

namespace GCommon;

public class LocUpdateDownloadContext : ResUpdateDownloadContext
{
	public static readonly uint LOC_RESUPDATE_TAG;

	public EventLogger.EventTypetOptionalBundleDelete NeedLogOptionalBundleDelete;

	private string m_CurrentLoc;

	private string m_LocConfigJson;

	public override bool SupportBackgroundDownload => false;

	public LocUpdateDownloadContext(ResUpdateDownloadEngine owned_engine, ResDownloadType type, int maxLoaderCountSimultaneously)
		: base(null, ResDownloadType.None, 0)
	{
	}

	public bool CleanLastLanguageLocFile()
	{
		return false;
	}

	public bool CheckCurLocFile(LocLang lang, LocLang font_lang, string config_path, bool use_assets)
	{
		return false;
	}

	public bool CheckCurLocFilesAreReady(LocLang lang, LocLang font_lang, string config_path, bool use_assets)
	{
		return false;
	}

	public override float GetFileDownloadProcess()
	{
		return 0f;
	}

	private void _003CCheckCurLocFile_003Eb__8_0(UnityWebRequest www, ResWithTempFileLoader loader)
	{
	}

	private void _003CCheckCurLocFile_003Eb__8_1(string hashCode, ResUnzipFileLoader unzip_loader)
	{
	}
}
