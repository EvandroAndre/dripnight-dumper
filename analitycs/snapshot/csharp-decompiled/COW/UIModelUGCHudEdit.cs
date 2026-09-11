using System;
using System.Collections.Generic;
using COW.GamePlay;
using COW.Gameplay.UGC;
using COW.Gameplay.UGC.BlockEdit;
using COW.UGCHudEdit;
using GCommon;
using GCommon.CommandPattern;
using UnityEngine;
using message;

namespace COW;

public class UIModelUGCHudEdit : UIBaseModel, IUGCEditor<FICHBIFMBOF>, IUGCRunner<FICHBIFMBOF>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<NLNAMPBAGDC> _003C_003E9__49_0;

		internal int _003CGetUGCHudPrefabIndexInfoList_003Eb__49_0(NLNAMPBAGDC a, NLNAMPBAGDC b)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass100_0
	{
		public string id;

		internal bool _003CUpdateRecursively_003Eb__0(CIDCPADMFNA e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass101_0
	{
		public string id;

		internal bool _003CExport_003Eb__0(CIDCPADMFNA e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass122_0
	{
		public uint widgetID;

		public bool has;

		internal bool _003CHasWidgetForEditor_003Eb__0(DFJIKKPHPIL child)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass53_0
	{
		public List<UGCHudEventBlockInfo> list;

		internal bool _003CGetHudEventBlockInfos_003Eb__0(DFJIKKPHPIL child)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass85_0
	{
		public uint Id;

		internal bool _003CFindPrefabData_003Eb__0(OCGHOAIKOGG x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass86_0
	{
		public string spriteName;

		internal bool _003CGetIconResData_003Eb__0(BPPAFJODCOE x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass87_0
	{
		public uint Id;

		internal bool _003CFindPrefabDataIndex_003Eb__0(OCGHOAIKOGG x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass89_0
	{
		public uint Id;

		internal bool _003CFindPrefabDataForEditor_003Eb__0(NLNAMPBAGDC x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass90_0
	{
		public uint Id;

		internal bool _003CFindPrefabDataForEditorIndex_003Eb__0(NLNAMPBAGDC x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass95_0
	{
		public EventLogger.EventTypeUGCCustomModeMapContent.HudInfo hudInfo;

		internal bool _003CExtractEventTypeUGCCustomModeMapContent_003Eb__0(DFJIKKPHPIL child)
		{
			return false;
		}
	}

	private CommandManager m_CommandManager;

	private CommandFactory m_CommandFactory;

	private UGCHudPrefabDataProcessor m_PrefabDataProcessor;

	private UniqueIDGenerator m_IDGenerator;

	private UniqueIDGenerator m_HudIdGenerator;

	private GameObjectRecycleBin m_HudWidgetRecycleBin;

	private FICHBIFMBOF m_PrefabDatas;

	private NDIPIDAAHPD m_PrefabDatasForEditor;

	private EditorEntityData m_EntityData;

	private UGCHudWidget m_CurrentHudWidget;

	private DragWidgetSelectorCommand m_DragSelectorCommand;

	private AdjustHudWidgetSelectorSizeCommand m_AdjustSelectorSizeCommand;

	private AdjustHudWidgetSelectorAngleCommand m_AdjustSelectorAngleCommand;

	public Action<UGCHudWidget> onCurrentHudWidgetChanged;

	public Action<UGCHudWidget> onAddHudWidget;

	public Action<UGCHudWidget> onRemoveHudWidget;

	public Action<UGCHudWidget> onCloneHudWidget;

	private List<BPPAFJODCOE> m_HudIconResDataList;

	private bool m_IsEditor;

	private int UNDO_LIMIT;

	private uint m_CurrentEditHudID;

	private uint m_MaxCurrentHudWigetID;

	private int m_CurrentUGCMode;

	private List<JNBAKKBJNJD> m_PrefabData;

	public bool HudEditEnabled => false;

	public CommandManager CommandManager => null;

	public CommandFactory CommandFactory => null;

	public UGCHudPrefabDataProcessor PrefabProcessor => null;

	public GameObjectRecycleBin RecycleBin => null;

	public UGCHudWidget CurrentHudWidget
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public uint CurrentEditHudID
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public uint MaxCurrentHudWidgetID => 0u;

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Init()
	{
	}

	protected override void OnCleanup()
	{
	}

	public override void ClearCache()
	{
	}

	public uint GetUniqueID()
	{
		return 0u;
	}

	public uint GetHudUniqueID()
	{
		return 0u;
	}

	public void SetHudWidgetRecycleBin(Transform binRoot)
	{
	}

	public List<UGCHudPrefabIndexInfo> GetUGCHudPrefabIndexInfoList()
	{
		return null;
	}

	public List<UGCHudWidgetIndexInfo> GetUGCHudWidgetIndexInfoList(uint hudID)
	{
		return null;
	}

	private void AddUGCHudWidgetIndexInfo(List<DFJIKKPHPIL> children, List<UGCHudWidgetIndexInfo> destList, bool recursive)
	{
	}

	public List<UGCHudEventBlockInfo> GetHudEventBlockInfos(string hudId)
	{
		return null;
	}

	public List<UGCHudEventBlockInfo> GetHudEventBlockInfos(uint hudID)
	{
		return null;
	}

	public List<NLNAMPBAGDC> GetCurrentHudPrefabDataListForEditor()
	{
		return null;
	}

	public void AddHudPrefabData(NLNAMPBAGDC prefabData)
	{
	}

	public void RemoveHudPrefabData(uint hudId)
	{
	}

	private void RemoveLogicEntityDataForEditor(uint hudId)
	{
	}

	private void RemoveRecursively(DFJIKKPHPIL prefabData, uint hudId)
	{
	}

	public bool CanUndo()
	{
		return false;
	}

	public bool CanRedo()
	{
		return false;
	}

	public void Undo()
	{
	}

	public void Redo()
	{
	}

	public void CloneHudWidget(UGCHudWidget widget, Vector2 offset)
	{
	}

	private void SetDuplicateName(UGCHudWidget widget)
	{
	}

	public UGCHudWidget CreateHudWidget(UGCHudWidgetType hudType, Transform parent)
	{
		return null;
	}

	public void DeleteHudWidget(UGCHudWidget widget)
	{
	}

	public void SetCurrentHudWidget(UGCHudWidget widget, bool force = false)
	{
	}

	public void DragSelectorStart(UIUGCHudWidgetSelectorController selector)
	{
	}

	public void DragSelectorEnd()
	{
	}

	public void StartAdjustSelectorSize(UIUGCHudWidgetSelectorController selector, UIWidget.Pivot pivotType)
	{
	}

	public void EndAdjustSelectorSize(UIWidget.Pivot pivotType)
	{
	}

	public void StartAdjustSelectorAngle(UIUGCHudWidgetSelectorController selector)
	{
	}

	public void EndAdjustSelectorAngle()
	{
	}

	public void SetHudWidgetLocalAngleZ(UGCHudWidget widget, float localAngleZ)
	{
	}

	public void SetHudWidgetName(UGCHudWidget widget, string name)
	{
	}

	public void SetHudWidgetSize(UGCHudWidget widget, int width, int height)
	{
	}

	public void SetHudWidgetAnchorPosition(UGCHudWidget widget, float anchorPositionX, float anchorPositionY)
	{
	}

	private Command GetSelectHudWidgetCommand(UGCHudWidget widget)
	{
		return null;
	}

	private DragWidgetSelectorCommand GetDragSelectorCommand(UIUGCHudWidgetSelectorController selector)
	{
		return null;
	}

	private AdjustHudWidgetSelectorSizeCommand GetAdjustSelectorSizeCommand(UIUGCHudWidgetSelectorController selector, UIWidget.Pivot pivotType)
	{
		return null;
	}

	public void SaveHudPrefab(UGCHudPrefabRoot prefabRoot)
	{
	}

	public GameObject RebuildPrefab(uint Id, Transform root, bool isEditor = true)
	{
		return null;
	}

	public GameObject RebuildPrefab(NLNAMPBAGDC prefabData, Transform root)
	{
		return null;
	}

	public GameObject RebuildPrefab(OCGHOAIKOGG prefabData, Transform root)
	{
		return null;
	}

	public OCGHOAIKOGG FindPrefabData(uint Id)
	{
		return null;
	}

	public BPPAFJODCOE GetIconResData(string spriteName)
	{
		return null;
	}

	private int FindPrefabDataIndex(uint Id)
	{
		return 0;
	}

	private bool RemovePrefabData(uint Id)
	{
		return false;
	}

	public NLNAMPBAGDC FindPrefabDataForEditor(uint Id)
	{
		return null;
	}

	private int FindPrefabDataForEditorIndex(uint Id)
	{
		return 0;
	}

	private bool RemovePrefabDataForEditor(uint Id)
	{
		return false;
	}

	private void ForeachWidget(List<DFJIKKPHPIL> children, Func<DFJIKKPHPIL, bool> process, bool recursive = true)
	{
	}

	private void OnCurrentHudWidgetChanged(UGCHudWidget cur)
	{
	}

	private void OnCurrentEditHudChanged()
	{
	}

	public bool ExtractEventTypeUGCCustomModeMapContent(byte[] projectDataBytes, EditorEntityData editorEntityData, EventLogger.EventTypeUGCCustomModeMapContent output)
	{
		return false;
	}

	private void UGCHudGameObjectDataForEditorAdapter(List<DFJIKKPHPIL> children)
	{
	}

	private bool LoadProjectOB36ToOB37(byte[] projectDataBytes, EditorEntityData editorEntityData)
	{
		return false;
	}

	public bool LoadProject(byte[] projectDataBytes, MFDKDILMLFP version, EditorEntityData editorEntityData = null)
	{
		return false;
	}

	public bool UnloadProject()
	{
		return false;
	}

	private void UpdateRecursively(DFJIKKPHPIL data, ref EditorMiscData miscData, int hudID, List<CIDCPADMFNA> uiHierarchy)
	{
	}

	public bool Export(out byte[] projectDataBytes, out FICHBIFMBOF runtimeData, ref EditorMiscData miscData)
	{
		projectDataBytes = null;
		runtimeData = null;
		return false;
	}

	private void GenerateHudLogicEntityData(NLNAMPBAGDC prefabData)
	{
	}

	private void GenerateWidgetLogicEntityData(int hudID, DFJIKKPHPIL prefabData)
	{
	}

	private void GenerateWidgetData(ALGADJPAAGL prefabData, List<IPIFNFDIIKK> data, MGGLBAIOFFM widgetData)
	{
	}

	private void GenerateEmptyWidgetData(int hudID, ALGADJPAAGL prefabData)
	{
	}

	private void GenerateLabelData(int hudID, ALGADJPAAGL prefabData)
	{
	}

	private void GenerateImageData(int hudID, ALGADJPAAGL prefabData)
	{
	}

	private void GenerateButtonData(int hudID, ALGADJPAAGL prefabData)
	{
	}

	public bool CheckLegality(ref EditorMiscData miscData)
	{
		return false;
	}

	private int CalPrefabAllChildrenCnt(NLNAMPBAGDC prefab)
	{
		return 0;
	}

	public int GetTotalHudCount()
	{
		return 0;
	}

	public int GetTotalWidgetsCount()
	{
		return 0;
	}

	public bool LoadRuntimeData(FICHBIFMBOF runtimeData)
	{
		return false;
	}

	public bool UnloadRuntimeData()
	{
		return false;
	}

	public List<string> GetAllGraphId(string entityId, bool createIfMissing = true)
	{
		return null;
	}

	public string GetGraphId(string entityId, bool createIfMissing = true)
	{
		return null;
	}

	public bool BindGraph(string entityId, string graphId, out GraphData graphData)
	{
		graphData = null;
		return false;
	}

	public INAMDLOFOHF GetEntityData(string entityId, bool createIfMissing = true)
	{
		return null;
	}

	public BlockData FindHudEventBlock(uint hudId, uint widgetId)
	{
		return null;
	}

	public bool IsHudPrefabsForEditorReady()
	{
		return false;
	}

	public bool HasHudPrefabForEditor(uint hudID)
	{
		return false;
	}

	public bool HasWidgetForEditor(uint hudID, uint widgetID)
	{
		return false;
	}

	public List<JNBAKKBJNJD> GetPrefabData()
	{
		return null;
	}

	public bool SaveHudTemplate(NLNAMPBAGDC hudPrefabData, byte[] cover, string templateName, string templateId)
	{
		return false;
	}

	public bool LoadHudTemplate(KCJDEKIJAKH templateData, out NLNAMPBAGDC hudPrefabData)
	{
		hudPrefabData = null;
		return false;
	}

	private void _003CSetHudWidgetRecycleBin_003Eb__48_0(GameObject go)
	{
	}

	private void _003CSetHudWidgetRecycleBin_003Eb__48_1(GameObject go)
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	public void _003C_003EiFixBaseProxy_OnCleanup()
	{
	}

	public void _003C_003EiFixBaseProxy_ClearCache()
	{
	}
}
