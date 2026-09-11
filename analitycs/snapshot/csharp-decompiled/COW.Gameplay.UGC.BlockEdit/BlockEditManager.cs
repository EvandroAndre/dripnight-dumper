using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using GCommon;
using LitJson;
using UnityEngine;
using message;

namespace COW.Gameplay.UGC.BlockEdit;

public class BlockEditManager : SingletonModule<BlockEditManager>, IUGCEditor<List<GKGNPJEOEGP>>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<string, bool> _003C_003E9__44_0;

		public static Action<GraphData> _003C_003E9__57_0;

		public static Comparison<BlockTemplateData> _003C_003E9__63_0;

		public static Comparison<BlockTemplateData> _003C_003E9__65_0;

		internal bool _003CCOW_002EGameplay_002EUGC_002EIUGCEditor_003CSystem_002ECollections_002EGeneric_002EList_003Cmessage_002EUGCGraphDataV2_003E_003E_002EExport_003Eb__44_0(string key)
		{
			return false;
		}

		internal void _003CLoadGraphLocally_003Eb__57_0(GraphData graph)
		{
		}

		internal int _003CSortCustomBlockTemplate_003Eb__63_0(BlockTemplateData a, BlockTemplateData b)
		{
			return 0;
		}

		internal int _003CLoadLibraryBlockTemplateData_003Eb__65_0(BlockTemplateData x, BlockTemplateData y)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass22_0
	{
		public string bindEntityId;

		internal bool _003CSetGraphDeleteState_003Eb__0(GraphData e)
		{
			return false;
		}
	}

	public static BlockEditContext BlockDefineContext;

	public EditorEntityData EntityData;

	private EBlockEditProjectType CurrentSaveProjectType;

	private const int m_ScreenshotWidth = 264;

	private const int m_ScreenshotHeight = 172;

	private List<BlockTemplateData> m_CustomTemplateDataList;

	private List<BlockTemplateData> m_LibraryTemplateDataList;

	private bool m_IsCustomTemplateSortDirty;

	private static readonly Regex JsonFixer;

	public List<BlockTemplateData> CustomTemplateDataList => null;

	public List<BlockTemplateData> LibraryTemplateDataList => null;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public GraphData GetGraphData(string gId)
	{
		return null;
	}

	private bool LoadBlockDefine()
	{
		return false;
	}

	private bool LoadBlockLibrary()
	{
		return false;
	}

	public bool LoadBlockDefineAndLib()
	{
		return false;
	}

	public bool ImportUserBlockData()
	{
		return false;
	}

	public GraphData AddGraph(string entityID, int declare = 0)
	{
		return null;
	}

	public GraphData AddGraphForType(string logicEntityType, int declare = 0)
	{
		return null;
	}

	public bool CloneAndTryAddGraph(string newEntityID, string graphID, out GraphData newGraph)
	{
		newGraph = null;
		return false;
	}

	public void SetGraphDeleteState(string bindEntityId, bool b)
	{
	}

	public bool HasBinding(GraphData graphData)
	{
		return false;
	}

	public bool IsCopyContentExist()
	{
		return false;
	}

	public bool IsPopContentExist()
	{
		return false;
	}

	public bool ExportBlockData(BlockData blockData)
	{
		return false;
	}

	public bool ExportAllBlockData()
	{
		return false;
	}

	public bool SaveUserBlockData()
	{
		return false;
	}

	public GraphData CreateBlockTemplateGraphData(BlockData blockData)
	{
		return null;
	}

	public bool ExportBlockTemplateData(string templateId, string name, string desc, byte[] cover, GraphData graphData, out KCJDEKIJAKH templateData)
	{
		templateData = null;
		return false;
	}

	public void RemoveGraph(string graphID)
	{
	}

	public void ClearEmptyGraphs()
	{
	}

	public string GetEntityIDFromGraphID(string graphID, bool bTemplate = false)
	{
		return null;
	}

	public INAMDLOFOHF GetEntityDataFromGraphID(string graphID)
	{
		return null;
	}

	public GraphData GetLastEditGraph(INAMDLOFOHF entity)
	{
		return null;
	}

	public TypeInfo GetEntityTypeFromGraphID(string graphID, bool bTemplate = false)
	{
		return default(TypeInfo);
	}

	public bool ExtractEventTypeUGCCustomModeMapContent(byte[] projectDataBytes, MFDKDILMLFP version, EditorEntityData editorEntityData, EventLogger.EventTypeUGCCustomModeMapContent output)
	{
		return false;
	}

	public bool LoadTemplate(byte[] graphDataBytes, List<INAMDLOFOHF> entityData, Dictionary<string, string> entityMapping)
	{
		return false;
	}

	public bool LoadProject(byte[] projectDataBytes, MFDKDILMLFP version, EditorEntityData editorEntityData)
	{
		return false;
	}

	public bool ZipProjectData(byte[] rawData, out byte[] result)
	{
		result = null;
		return false;
	}

	public bool UnzipProjectData(byte[] zippedData, out byte[] result)
	{
		result = null;
		return false;
	}

	bool IUGCEditor<List<GKGNPJEOEGP>>.UnloadProject()
	{
		return false;
	}

	public bool ExportPartial(List<GraphData> graphs, out byte[] templateDataBytes)
	{
		templateDataBytes = null;
		return false;
	}

	bool IUGCEditor<List<GKGNPJEOEGP>>.Export(out byte[] projectDataBytes, out List<GKGNPJEOEGP> runtimeData, ref EditorMiscData miscData)
	{
		projectDataBytes = null;
		runtimeData = null;
		return false;
	}

	bool IUGCEditor<List<GKGNPJEOEGP>>.CheckLegality(ref EditorMiscData miscData)
	{
		return false;
	}

	private byte[] ToBytes<T>(T data)
	{
		return null;
	}

	private T ToObject<T>(byte[] bytes)
	{
		return default(T);
	}

	private byte[] JsonDataToBytes(Func<JsonWriter, List<GraphData>, bool> serializeFunc, List<GraphData> graphs = null)
	{
		return null;
	}

	private byte[] BlockTemplateJsonDataToBytes(Func<JsonWriter, bool> serializeFunc)
	{
		return null;
	}

	private JsonData BytesToJsonData(byte[] bytes)
	{
		return null;
	}

	private bool BuildGraphs(byte[] bytes)
	{
		return false;
	}

	private bool BuildGraphsFromSerMap(byte[] bytes)
	{
		return false;
	}

	private bool BuildBlockTemplateDataFromSerMap(byte[] bytes, out GraphData graphData)
	{
		graphData = null;
		return false;
	}

	private bool BuildBlockTemplateData(byte[] bytes, out GraphData graphData)
	{
		graphData = null;
		return false;
	}

	public void SaveGraphLocally(string filename)
	{
	}

	public void LoadGraphLocally()
	{
	}

	public BlockData FindDefBlock(BlockData refBlock)
	{
		return null;
	}

	private void LoadCustomBlockTemplate()
	{
	}

	public void RegisterCustomBlockTemplate(UGCAssetMetadata assetMeta)
	{
	}

	public void RemoveCustomBlockTemplate(string assetId)
	{
	}

	private bool TryGetCustomTemplateIndexById(string assetId, out int index)
	{
		index = default(int);
		return false;
	}

	public void SortCustomBlockTemplate()
	{
	}

	private bool TryBuildBlockTemplateGraphAndImage(byte[] graphBytes, byte[] imageBytes, out GraphData graphData, out Texture2D templateImage)
	{
		graphData = null;
		templateImage = null;
		return false;
	}

	private void LoadLibraryBlockTemplateData()
	{
	}
}
