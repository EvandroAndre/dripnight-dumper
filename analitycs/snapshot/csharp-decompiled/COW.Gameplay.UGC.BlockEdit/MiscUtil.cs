using System.Collections.Generic;
using message;
using proto;

namespace COW.Gameplay.UGC.BlockEdit;

public static class MiscUtil
{
	public static Dictionary<int, int> BlockCountByTypeCache;

	public static void AddCustomString(EditorMiscData miscData, GraphData graph, string ID, string content, EWorkshop.WordFilterType type)
	{
	}

	public static void AddErrorEntry(EditorMiscData miscData, BlockData blockData, CNDCGBPDHEB.IJGKGIFOLGH errorCode, List<string> extraParams = null)
	{
	}

	public static void AddErrorEntry(EditorMiscData miscData, GraphData graph, CNDCGBPDHEB.IJGKGIFOLGH errorCode, string blockID = "", List<string> extraParams = null)
	{
	}

	public static void AddErrorEntry(EditorMiscData miscData, CNDCGBPDHEB.IJGKGIFOLGH errorCode, List<string> extraParams = null)
	{
	}

	public static void AddTypeMismatchErrorEntry(EditorMiscData miscData, BlockData blockData)
	{
	}

	public static void CollectLogRequestInfo(BlockEditContext context, EventLogger.EventTypeUGCCustomModeMapContent source, bool outDebugLog = false)
	{
	}
}
