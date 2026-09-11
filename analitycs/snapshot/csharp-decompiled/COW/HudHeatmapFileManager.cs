using System;
using System.Collections.Generic;
using System.IO;
using GCommon;

namespace COW;

public class HudHeatmapFileManager : SingletonModule<HudHeatmapFileManager>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<FileInfo> _003C_003E9__22_0;

		internal int _003CCleanupExcessFiles_003Eb__22_0(FileInfo a, FileInfo b)
		{
			return 0;
		}
	}

	private const string HEATMAP_ROOT_DIR = "HeatMap";

	private const string FILE_PREFIX = "hud_click_";

	private const string FILE_EXTENSION = ".bin";

	private const string HASH_SALT = "FF_HudHeatmap_Salt_2026";

	private const int DEFAULT_MAX_MATCH_FILES_PER_PRESET = 5;

	private bool m_HasSavedThisMatch;

	private const float READ_CACHE_DURATION = 10f;

	private List<HudClickRecordFile> m_CachedReadResult;

	private float m_CachedReadTime;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public override bool NeedResetCleanup()
	{
		return false;
	}

	private static string GetHeatmapRootDirectory()
	{
		return null;
	}

	private static string GetAccountHeatmapDirectory(ulong accountId)
	{
		return null;
	}

	private static string GetCurrentAccountDirectory()
	{
		return null;
	}

	public void CheckAndCreateDirectory()
	{
	}

	public void SaveClickRecords()
	{
	}

	public void ResetSaveFlag()
	{
	}

	public List<HudClickRecordFile> ReadClickRecords()
	{
		return null;
	}

	private HudClickRecordFile ReadSingleFile(string filePath)
	{
		return null;
	}

	public int GetMatchCountForPreset(int presetIndex, int minClickCount)
	{
		return 0;
	}

	public long GetLatestFileTimeForPreset(int presetIndex)
	{
		return 0L;
	}

	private void CleanupExcessFiles()
	{
	}

	private uint GetMaxMatchFilesPerPresetFromConfig()
	{
		return 0u;
	}

	private static int ParsePresetIndexFromFileName(string fileName)
	{
		return 0;
	}

	public void CheckAndDeleteOutOfDateFiles(int maxAgeDays)
	{
	}

	public void ClearAllFiles()
	{
	}

	private static string ComputeSignature(int recordCount, int screenWidth, int screenHeight, uint matchMode, uint gameMode, long time, ulong accountId, int hudPresetIndex)
	{
		return null;
	}

	public bool _003C_003EiFixBaseProxy_NeedResetCleanup()
	{
		return false;
	}
}
