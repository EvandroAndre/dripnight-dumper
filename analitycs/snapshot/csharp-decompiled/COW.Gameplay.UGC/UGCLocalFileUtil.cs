using System.Collections.Generic;
using GCommon;
using message;

namespace COW.Gameplay.UGC;

public static class UGCLocalFileUtil
{
	private const string STORE_ROOT = "{0}/Store";

	private const string CREATED_ROOT = "{0}/Created";

	private const string CREATED_OBJECT_TEMPLATE_ROOT = "{0}/Created/ObjectTemplate";

	private const string CREATED_HUD_TEMPLATE_ROOT = "{0}/Created/HudTemplate";

	private const string CREATED_BLOCK_TEMPLATE_ROOT = "{0}/Created/BlockTemplate";

	private static bool s_StoreMigrated;

	private static bool s_CreatedMigrated;

	private const string TEMPLATE_DATA = "{0}/TemplateData.bytes";

	private const string TEMPLATE_JSON = "{0}/TemplateData.json";

	private const string TEMPLATE_COVER = "{0}/Cover.bytes";

	private const string TEMPLATE_COVER_PNG = "{0}/Cover.png";

	private const string TEMPLATE_REVIEW = "{0}/Review.bytes";

	private const string TEMPLATE_REVIEW_PNG = "{0}/Review_{1}.png";

	private const string PROJECT_CLASSIC_FILENAME = "{0}/ProjectData_classic_slot_{1}.bytes";

	private const string PROJECT_CLASSIC_JSON_FILENAME = "{0}/ProjectData_classic_slot_{1}.json";

	private const string PROJECT_CLASSIC_META_FILENAME = "{0}/ProjectData_classic_slot_{1}.meta";

	private const string PROJECT_CLASSIC_META_JSON_FILENAME = "{0}/ProjectData_classic_slot_{1}.meta.json";

	private const string RUNTIME_CLASSIC_FILENAME = "{0}/UserLevelData_classic_{1}.bytes";

	private const string RUNTIME_CLASSIC_DEBUG_JSON_FILENAME = "{0}/UserLevelData_classic_{1}.json";

	private const string USER_BLOCK_FILENAME = "{0}/UserBlockData.bytes";

	private const string PROJECT_FILENAME = "{0}/ProjectData_slot_{1}.bytes";

	private const string PROJECT_JSON_FILENAME = "{0}/ProjectData_slot_{1}.json";

	private const string PROJECT_META_FILENAME = "{0}/ProjectData_slot_{1}.meta";

	private const string PROJECT_META_JSON_FILENAME = "{0}/ProjectData_slot_{1}.meta.json";

	private const string RUNTIME_FILENAME = "{0}/UserLevelData_{1}.bytes";

	private const string RUNTIME_DEBUG_JSON_FILENAME = "{0}/UserLevelData_{1}.json";

	private const string PROJECT_EDIT_RECORD_FILENAME = "{0}/ProjectEditRecord_slot_{1}.meta";

	private const string PROJECT_EDIT_RECORD_JSON_FILENAME = "{0}/ProjectEditRecord_slot_{1}.meta.json";

	private const string OLD_WORKSHOP_BIN_FILENAME = "{0}/workshop.bin";

	private const string OLD_WORKSHOP_INFO_FILENAME = "{0}/workshop_info.json";

	private const string OLD_JSON_FILENAME = "{0}/workshop_1.json";

	private const string PROJECT_SCREEN_SHOT_PNG_FILENAME_DEBUG = "{0}/SceneReview_{1}_{2}.png";

	private const string PROJECT_SCREEN_SHOT_PNG_FILENAME = "{0}/SceneReview_{1}.bytes";

	private const string PROJECT_CLASSIC_SCREEN_SHOT_PNG_FILENAME = "{0}/SceneReview_classic_{1}.bytes";

	private const int PROJECT_SCREEN_SHOT_MAX = 5;

	private const uint TEMP_SLOT_ID = 999u;

	private static Dictionary<uint, int> m_EditRecordDataVersion;

	public const uint ClassicSlotIdentifier = 10000u;

	public static string GetJsonFileNameAfterMoving()
	{
		return null;
	}

	public static bool DeleteJsonFileInAccountFolder()
	{
		return false;
	}

	public static KKMFBJGIEBD GetMetaDataBySlot(uint slotID)
	{
		return null;
	}

	public static ALHOCINMDFH GetProjectDataBySlot(uint slotID)
	{
		return null;
	}

	public static bool GetProjectAndRuntimeDataBytesBySlot(uint slotID, out byte[] project, out byte[] runtime)
	{
		project = null;
		runtime = null;
		return false;
	}

	public static bool SaveProjectMetaDataBySlotID(uint slotID, KKMFBJGIEBD metaData)
	{
		return false;
	}

	public static bool TrySaveMetaAndBytesBySlotId(KKMFBJGIEBD meta, byte[] projectBytes, byte[] runtimeBytes = null, uint slotID = 0u)
	{
		return false;
	}

	public static bool SaveBytesBySlotId(byte[] projectBytes, byte[] runtimeBytes, uint slotID)
	{
		return false;
	}

	public static bool CopySlotLocalSaveFromSrcToDest(uint srcSlotId, uint destSlotId)
	{
		return false;
	}

	public static void RemoveSlotLocalSaveBySlotId(uint slotID)
	{
	}

	public static bool SaveTemplate(KCJDEKIJAKH data, byte[] cover = null, List<byte[]> reviews = null)
	{
		return false;
	}

	public static bool DeleteLocalDirectory(string path)
	{
		return false;
	}

	public static bool DeleteLocalFile(string path)
	{
		return false;
	}

	public static bool LoadTemplateData(string filePath, out KCJDEKIJAKH template)
	{
		template = null;
		return false;
	}

	public static bool LoadCreatedTemplateCover(string path, out byte[] cover)
	{
		cover = null;
		return false;
	}

	public static bool LoadCreatedTemplateReview(string path, out List<byte[]> reviews)
	{
		reviews = null;
		return false;
	}

	public static bool SaveProjectData(uint slotID, byte[] projectDataBytes)
	{
		return false;
	}

	public static bool SaveProjectDataInJson(uint slotID, string projectDataText, string subData = null)
	{
		return false;
	}

	public static bool SaveUserBlockData(byte[] userBlockDataBytes)
	{
		return false;
	}

	public static bool LoadProjectDataByVFS(uint slotID, string prjFilePathInVFS, ref UGCVFSFile vfsFile, out byte[] projectDataBytes, out string prjFileUUID)
	{
		projectDataBytes = null;
		prjFileUUID = null;
		return false;
	}

	public static bool SaveProjectDataToVFS(uint slotID, string prjFilePathInVFS, ref string LoadedPrjFileUUID, ref UGCVFSFile vfsFile, byte[] projectDataBytes)
	{
		return false;
	}

	public static bool LoadProjectData(uint slotID, out byte[] projectDataBytes)
	{
		projectDataBytes = null;
		return false;
	}

	public static bool LoadProjectData(ResourceID resID, out byte[] projectDataBytes)
	{
		projectDataBytes = null;
		return false;
	}

	public static bool TryDecodeProjectMapModeTemplate(byte[] projectDataBytes, out uint mapId, out uint modeId, out uint templateId)
	{
		mapId = default(uint);
		modeId = default(uint);
		templateId = default(uint);
		return false;
	}

	public static bool LoadProjectData(uint gameMode, uint template, uint mapId, uint areaId, out byte[] projectDataBytes)
	{
		projectDataBytes = null;
		return false;
	}

	public static string GetUGCGamePlatformDataResName(uint gameMode, uint template, uint mapId, uint areaId)
	{
		return null;
	}

	public static ulong GenerateProjectDataTemplateID(uint mapId, uint template = 0u, uint gameMode = 0u, uint area = 0u)
	{
		return 0uL;
	}

	public static bool LoadRuntimeData(uint slotID, out byte[] runtimeDataBytes)
	{
		runtimeDataBytes = null;
		return false;
	}

	public static bool LoadUserBlockData(out byte[] userBlockDataBytes)
	{
		userBlockDataBytes = null;
		return false;
	}

	public static string GetUserBlockDataPath()
	{
		return null;
	}

	public static bool HasUserBlockData()
	{
		return false;
	}

	public static bool SaveProjectMetaDataInBytes(uint slotID, byte[] projectMetaDataBytes)
	{
		return false;
	}

	public static bool SaveProjectMetaDataInJson(uint slotID, string projectMetaDataText)
	{
		return false;
	}

	public static bool SaveRuntimeData(uint slotID, byte[] runtimeDataBytes)
	{
		return false;
	}

	public static bool SaveRuntimeDebugDataInJson(uint slotID, string runtimeDebugDataText, string subData = null)
	{
		return false;
	}

	public static bool LoadProjectEditRecordDataBytes(uint slotID, out byte[] dataBytes)
	{
		dataBytes = null;
		return false;
	}

	private static bool SaveProjectEditRecordDataInBytes(uint slotID, byte[] dataBytes)
	{
		return false;
	}

	private static bool SaveProjectEditRecordDataInJson(uint slotID, string dataJson)
	{
		return false;
	}

	public static bool SaveProjectEditRecordDataBySlotID(uint slotID, BGKJLDMJGIB data)
	{
		return false;
	}

	public static bool CopyProjectEditRecordData(uint srcSlotId, uint destSlotId)
	{
		return false;
	}

	public static void RemoveProjectEditRecordDataBySlotID(uint slotID)
	{
	}

	public static int GetProjectEditRecordDataVersion(uint slotId)
	{
		return 0;
	}

	private static void UpdateProjectEditRecordData(uint slotId)
	{
	}

	public static bool IsMapFileValid(uint slotId, int situationId = 1)
	{
		return false;
	}

	public static bool SaveProjectScreenShotDebug(uint slotID, byte[] screen_shot_bytes, int index)
	{
		return false;
	}

	public static bool SaveProjectScreenShot(uint slotID, List<byte[]> screen_shot_bytes)
	{
		return false;
	}

	public static bool GetProjectScreenShot(uint slotID, out List<byte[]> screen_shot_bytes)
	{
		screen_shot_bytes = null;
		return false;
	}

	public static bool GetLocalScreenShotSizes(uint slotID, out ulong[] sizes)
	{
		sizes = null;
		return false;
	}

	public static string GetLocalFilePathInAccountFolder()
	{
		return null;
	}

	public static string GetLocalFilePathInPublicFolder()
	{
		return null;
	}

	public static string GetLocalAccountPath(string format, string param)
	{
		return null;
	}

	public static string GetStoreRootPath()
	{
		return null;
	}

	private static void EnsureStoreMigrated()
	{
	}

	public static string GetCreatedRootPath()
	{
		return null;
	}

	private static void EnsureCreatedMigrated()
	{
	}

	private static void MigrateDirectory(string sourceDir, string targetDir)
	{
	}

	private static void NormalizeClassicStoreFileNames(string storeRoot)
	{
	}

	private static void NormalizeClassicObjectTemplateFiles(string objectTemplateRoot)
	{
	}

	private static void NormalizeClassicBlockTemplateFiles(string blockTemplateRoot)
	{
	}

	public static string GetCreatedResourceRootPath(LLOFDJACPEJ templateType)
	{
		return null;
	}

	public static string GetCreatedResourceItemPath(LLOFDJACPEJ templateType, string id)
	{
		return null;
	}

	private static string GetLocalFilePathBySlotType(string format, string classFormat, uint slotID, string subData = null)
	{
		return null;
	}

	private static string GetLocalProjectMetaFilePathBySlotType(uint slotID)
	{
		return null;
	}

	private static string GetLocalProjectMetaFileJsonPathBySlotType(uint slotID)
	{
		return null;
	}

	private static string GetLocalProjectFilePathBySlotType(uint slotID)
	{
		return null;
	}

	private static string GetLocalProjectFileJsonPathBySlotType(uint slotID, string subData = null)
	{
		return null;
	}

	public static string GetLocalRuntimeFilePathBySlotType(uint slotID)
	{
		return null;
	}

	private static string GetLocalRuntimeFileJsonPathBySlotType(uint slotID, string subData = null)
	{
		return null;
	}

	public static string GetLocalScreenShotFilePathBySlotType(uint slotID)
	{
		return null;
	}

	private static string GetOldLocalFilePath()
	{
		return null;
	}

	public static bool ReadBytesFromFile(string fullPath, out byte[] data)
	{
		data = null;
		return false;
	}

	public static bool WriteBytesToFile(string fullPath, byte[] data)
	{
		return false;
	}

	private static bool WriteTextToFile(string fullPath, string text)
	{
		return false;
	}

	public static string[] GetAllFilesInDirectory(string fullPath, string extension)
	{
		return null;
	}
}
