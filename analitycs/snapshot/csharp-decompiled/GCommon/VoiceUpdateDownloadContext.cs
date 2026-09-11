using System;
using COW;

namespace GCommon;

public class VoiceUpdateDownloadContext : ResUpdateDownloadContext
{
	public static readonly uint VOICE_RESUPDATE_TAG;

	public EventLogger.EventTypetOptionalBundleDelete NeedLogOptionalBundleDelete;

	public VoiceUpdateDownloadContext(ResUpdateDownloadEngine owned_engine, ResDownloadType type, int maxLoaderCountSimultaneously)
		: base(null, ResDownloadType.None, 0)
	{
	}

	public override void StartGetLocalVersion(Action<ResDownloadType> on_version_check_finished = null)
	{
	}

	public override void DeleteAllFile()
	{
	}

	public override void StartVersionCheck()
	{
	}

	protected override void onRemoteVersionInfoLoaded(bool result)
	{
	}

	public override ResVersionInfo.FileInfo GetLocalFileInfo(string path, bool exceptLoginFile = false, bool isForDeleteCase = false)
	{
		return null;
	}

	public ResVersionInfo.FileInfo GetNoFiltLocalFileInfo(string path, bool exceptLoginFile = false)
	{
		return null;
	}

	public bool CleanupOtherLanguageVoiceFiles()
	{
		return false;
	}

	private bool ShouldDeleteVoiceFilesByTime()
	{
		return false;
	}

	public bool DeleteOtherLanguageVoiceFiles()
	{
		return false;
	}

	private void onLocalFileInfoLoaded_Pass(bool result)
	{
	}

	protected override void onRemoteFileInfoLoaded(bool result)
	{
	}
}
