using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using COW.GamePlay;
using GCommon;
using UnityEngine;
using message;
using proto;

namespace COW.Gameplay.UGC;

internal class UGCEditorManager
{
	private struct ExportPendingCallback
	{
		public Action<bool> LegacyCb;

		public Action<EExportFailReason> ReasonCb;
	}

	[StructLayout(LayoutKind.Auto)]
	private struct _003C_003Ec__DisplayClass106_0
	{
		public EExportFailReason failReason;
	}

	private sealed class _003COnExportAllDataCoroutine_003Ed__106 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public uint slotID;

		public UGCEditorManager _003C_003E4__this;

		public Action<EExportFailReason> exportCallback;

		private _003C_003Ec__DisplayClass106_0 _003C_003E8__1;

		private UIModelSceneEdit _003CuiModel_003E5__2;

		private UIModelUGCModeEdit _003CmodeEdit_003E5__3;

		private ModeVariables _003Callvars_003E5__4;

		private EditorMiscData _003CmiscData_003E5__5;

		private byte[] _003ChudProject_003E5__6;

		private CLMPMGMIDGD _003CmodeSettingRuntimeData_003E5__7;

		private bool _003Csucc_003E5__8;

		private byte[] _003CprojectDataBytes_003E5__9;

		private ALHOCINMDFH _003CprojectData_003E5__10;

		private byte[] _003CruntimeDataBytes_003E5__11;

		private JOEANMPIFAB _003CruntimeData_003E5__12;

		private UIModelUGCHudEdit _003ChudEdit_003E5__13;

		private GNHAFLDPNJI _003CresInfoForLocalTest_003E5__14;

		private PDNPIMFAGEN _003CdownloadDescForLocalTest_003E5__15;

		private byte[] _003CprojectMetaDataBytes_003E5__16;

		private CNDCGBPDHEB.AAJDBLADNEM _003CeditorError_003E5__17;

		private UGCMapScreenShot _003CscreenShot_003E5__18;

		private List<Transform> _003Ctransforms_003E5__19;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003COnExportAllDataCoroutine_003Ed__106(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
		}

		void IEnumerator.Reset()
		{
		}
	}

	private readonly HNDHJGJILHC m_OwnerGame;

	private byte[] _003CCachedProjectMetaDataBytes_003Ek__BackingField;

	private string _003CCachedProjectMetaDataJsonString_003Ek__BackingField;

	private byte[] _003CCachedProjectDataBytes_003Ek__BackingField;

	private byte[] _003CCachedRuntimeDataBytes_003Ek__BackingField;

	private string _003CCachedRuntimeDebugDataJsonString_003Ek__BackingField;

	private string _003CCachedRuntimeDebugResourceDataJsonString_003Ek__BackingField;

	private List<byte[]> _003CCachedScreenShotDataBytes_003Ek__BackingField;

	public UGCVFSFile VFS;

	public string LoadedPrjFileUUID;

	public static string PrjFilePathInVFS;

	private EditorMiscData _003CCachedMiscData_003Ek__BackingField;

	private readonly EditorEntityData m_EditorEntityData;

	private readonly UGCLogicEntityBridgingMgr m_UGCLogicEntityBridgingMgr;

	private IUGCEditor<List<GKGNPJEOEGP>> m_graphEditor;

	private IUGCEditor<OHCGHBFNOFA> m_workflowEditor;

	private IUGCEditor<List<FJOPMIJBFEI>> m_entityEditor;

	private IUGCEditor<FICHBIFMBOF> m_hudEditor;

	private IUGCEditor<LPAHANBIOKC> m_mapEditor;

	private IUGCEditor<CLMPMGMIDGD> m_modeSettingEditor;

	private IUGCEditor<MPGMIACDBGN> m_plotEditor;

	private IUGCEditor<FANIMAEKKDN> m_ShopEditor;

	private IUGCEditor<PEDPONDINCG> m_CustomEventEditor;

	private UIModelUGCTimelineEditData m_TimelineEditData;

	private bool m_HasLoadedCreatorTraceSource;

	private bool m_HasLoadedCreatorTrace;

	private UGCGameDataCreatorTrace m_LoadedCreatorTrace;

	private FFEAJEKGIIF _003CSceneBuilder_003Ek__BackingField;

	private UGCMiniMapMgr _003CMiniMapMgr_003Ek__BackingField;

	private UGCResourceEditor _003CResourceEditor_003Ek__BackingField;

	private bool m_HasSomethingToSave;

	private bool _003CHasCreatedAllEntityFromData_003Ek__BackingField;

	private int m_PublicVersion;

	private bool m_FromTemplate;

	private Queue<ExportPendingCallback> m_ExportAsyncCallbackQueue;

	public byte[] CachedProjectMetaDataBytes
	{
		get
		{
			return _003CCachedProjectMetaDataBytes_003Ek__BackingField;
		}
		private set
		{
			_003CCachedProjectMetaDataBytes_003Ek__BackingField = value;
		}
	}

	private string CachedProjectMetaDataJsonString
	{
		get
		{
			return _003CCachedProjectMetaDataJsonString_003Ek__BackingField;
		}
		set
		{
			_003CCachedProjectMetaDataJsonString_003Ek__BackingField = value;
		}
	}

	public byte[] CachedProjectDataBytes
	{
		get
		{
			return _003CCachedProjectDataBytes_003Ek__BackingField;
		}
		private set
		{
			_003CCachedProjectDataBytes_003Ek__BackingField = value;
		}
	}

	public byte[] CachedRuntimeDataBytes
	{
		get
		{
			return _003CCachedRuntimeDataBytes_003Ek__BackingField;
		}
		private set
		{
			_003CCachedRuntimeDataBytes_003Ek__BackingField = value;
		}
	}

	private string CachedRuntimeDebugDataJsonString
	{
		get
		{
			return _003CCachedRuntimeDebugDataJsonString_003Ek__BackingField;
		}
		set
		{
			_003CCachedRuntimeDebugDataJsonString_003Ek__BackingField = value;
		}
	}

	private string CachedRuntimeDebugResourceDataJsonString
	{
		get
		{
			return _003CCachedRuntimeDebugResourceDataJsonString_003Ek__BackingField;
		}
		set
		{
			_003CCachedRuntimeDebugResourceDataJsonString_003Ek__BackingField = value;
		}
	}

	public List<byte[]> CachedScreenShotDataBytes
	{
		get
		{
			return _003CCachedScreenShotDataBytes_003Ek__BackingField;
		}
		private set
		{
			_003CCachedScreenShotDataBytes_003Ek__BackingField = value;
		}
	}

	public EditorMiscData CachedMiscData
	{
		get
		{
			return _003CCachedMiscData_003Ek__BackingField;
		}
		private set
		{
			_003CCachedMiscData_003Ek__BackingField = value;
		}
	}

	public EditorEntityData EditorEntityData => null;

	public UGCLogicEntityBridgingMgr UGCLogicEntityBridgingMgr => null;

	public FFEAJEKGIIF SceneBuilder
	{
		get
		{
			return _003CSceneBuilder_003Ek__BackingField;
		}
		private set
		{
			_003CSceneBuilder_003Ek__BackingField = value;
		}
	}

	public UGCMiniMapMgr MiniMapMgr
	{
		get
		{
			return _003CMiniMapMgr_003Ek__BackingField;
		}
		private set
		{
			_003CMiniMapMgr_003Ek__BackingField = value;
		}
	}

	public LHFNKEDKCBK ShopEditor => null;

	public UGCResourceEditor ResourceEditor
	{
		get
		{
			return _003CResourceEditor_003Ek__BackingField;
		}
		private set
		{
			_003CResourceEditor_003Ek__BackingField = value;
		}
	}

	public bool HasSomethingToSave
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool HasCreatedAllEntityFromData
	{
		get
		{
			return _003CHasCreatedAllEntityFromData_003Ek__BackingField;
		}
		set
		{
			_003CHasCreatedAllEntityFromData_003Ek__BackingField = value;
		}
	}

	public int PublicVersion
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool FromTemplate
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private void CacheLoadedCreatorTrace(byte[] runtimeBytes)
	{
	}

	private void ClearLoadedCreatorTrace()
	{
	}

	private void ApplyCreatorTrace(JOEANMPIFAB runtimeData, uint slotID)
	{
	}

	public UIModelUGCTimelineEditData GetTimelineEditData()
	{
		return null;
	}

	public UGCEditorManager(HNDHJGJILHC ownerGame, IUGCEditor<List<GKGNPJEOEGP>> graphEditor, IUGCEditor<OHCGHBFNOFA> workflowEditor, IUGCEditor<List<FJOPMIJBFEI>> entityEditor, IUGCEditor<FICHBIFMBOF> hudEditor, IUGCEditor<LPAHANBIOKC> mapEditor, IUGCEditor<CLMPMGMIDGD> modeSettingEditor, IUGCEditor<MPGMIACDBGN> plotEditor, IUGCEditor<FANIMAEKKDN> shopEditor, IUGCEditor<PEDPONDINCG> customEventEditor)
	{
	}

	public bool LoadEditors(byte[] projectDataBytes, bool fromTemplate = false, byte[] runtimeDataBytes = null, bool useRuntimeDataTrace = false)
	{
		return false;
	}

	public bool ReloadEditors()
	{
		return false;
	}

	public bool LoadEditorsWithoutProjectData()
	{
		return false;
	}

	public bool UnloadEditors()
	{
		return false;
	}

	public bool LoadProjectDataFromLocal(uint slotID, EWorkshop.SlotType slotType)
	{
		return false;
	}

	public bool LoadProjectDataFromTemplate(uint gameMode, uint template, uint mapId, uint areId)
	{
		return false;
	}

	public bool LoadProjectDataFromTemplateResource(ResourceID templateResourceId)
	{
		return false;
	}

	public bool LoadProjectDataFromConfig()
	{
		return false;
	}

	public void ClearWidgetLogicEntityData()
	{
	}

	public bool ExportAllData()
	{
		return false;
	}

	public void ExportAllDataAsync(uint slotID, Action<bool> exportCallback)
	{
	}

	public void ExportAllDataAsync(uint slotID, Action<EExportFailReason> exportCallback)
	{
	}

	private void EnqueueAndStart(uint slotID, ExportPendingCallback pending)
	{
	}

	private void ExecuteAllAsyncCallbacksInQueue(EExportFailReason reason)
	{
	}

	private IEnumerator OnExportAllDataCoroutine(uint slotID, Action<EExportFailReason> exportCallback)
	{
		return null;
	}

	public bool ExportWorkflowEditor(out byte[] projectDataBytes, out OHCGHBFNOFA runtimeData, ref EditorMiscData miscData)
	{
		projectDataBytes = null;
		runtimeData = null;
		return false;
	}

	private List<Transform> CollectAllSceneEditObjectsExcludeChildren()
	{
		return null;
	}

	public void CacheEditorErrors()
	{
	}

	public bool SaveAllDataToLocal(uint slotID, bool saveScreenShot = false)
	{
		return false;
	}

	public static bool IsEditorOnlyPropID(int propID)
	{
		return false;
	}

	private static bool CheckHasAutoSaveAttributes()
	{
		return false;
	}

	private void _003CEnqueueAndStart_003Eb__104_0(EExportFailReason reason)
	{
	}

	internal static void _003COnExportAllDataCoroutine_003Eg__MarkFail_007C106_0(EExportFailReason reason, ref _003C_003Ec__DisplayClass106_0 P_1)
	{
	}
}
