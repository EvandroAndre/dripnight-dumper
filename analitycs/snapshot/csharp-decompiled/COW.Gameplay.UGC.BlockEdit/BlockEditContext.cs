using System.Collections.Generic;
using LitJson;
using message;

namespace COW.Gameplay.UGC.BlockEdit;

public class BlockEditContext
{
	public readonly BlockDefineDictionary BlockDefine;

	public readonly BlockEditLibraries BlockLibraries;

	public readonly BlockEditGraphs BlockGraphs;

	public GraphData CurrentBuildGraphData;

	public GraphData CurrentExportGraphData;

	public EditorMiscData CurrentExportMiscData;

	public GraphData CurrentEditGraphData;

	public List<string> CurrentEditOwnedEventNameList;

	public string CopyBlockId;

	public string CopyBlockOwnerGraphId;

	public readonly List<EventLogger.EventTypeWorkshopSceneEdit.ExportBlockInfo> UserExportDataLogExportInfo;

	public readonly List<EventLogger.EventTypeWorkshopSceneEdit.ImportBlockInfo> UserExportDataLogImportInfo;

	public GraphData BlockTemplateGraphData;

	public Dictionary<uint, UGCBlockConfigData> RawBlockConfigData;

	private Dictionary<string, UGCBlockConfigData> m_OfflineBlockConfigData;

	public readonly List<GKGNPJEOEGP> CurrentExportGraphProtoDatas;

	public GKGNPJEOEGP CurrentExportGraphProtoData;

	public Dictionary<string, string> TemplateGraphMapping;

	private bool mCSVLoaded;

	private Dictionary<string, UGCBlockConfigData> OfflineBlockConfigData => null;

	public bool Serialize<T>(IBlockSerializer<T> serializer, T serializedData, List<GraphData> graphs = null) where T : class
	{
		return false;
	}

	public bool SerializeBlockTemplate<T>(IBlockSerializer<T> serializer, T serializedData) where T : class
	{
		return false;
	}

	public bool ToJsonData(JsonWriter writer, List<GraphData> graphs = null)
	{
		return false;
	}

	public bool ToBlockTemplateJsonData(JsonWriter writer)
	{
		return false;
	}

	public void ClearUserExportBlockInfo()
	{
	}

	public void GetUserExportBlockInfo(List<EventLogger.EventTypeWorkshopSceneEdit.ExportBlockInfo> exportBlockInfos, List<EventLogger.EventTypeWorkshopSceneEdit.ImportBlockInfo> importBlockInfos)
	{
	}

	public void AddUserExportBlockInfo()
	{
	}

	public EventLogger.EventTypeWorkshopSceneEdit.ImportBlockInfo AddUserImportBlockInfo()
	{
		return null;
	}

	public UGCBlockConfigData GetConfigData(string typeName)
	{
		return null;
	}

	public List<string> UpdateCurrentEditGraphOwnedEventList()
	{
		return null;
	}
}
