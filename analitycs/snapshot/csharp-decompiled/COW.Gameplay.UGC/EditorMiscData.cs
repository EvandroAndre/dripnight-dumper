using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using message;
using proto;

namespace COW.Gameplay.UGC;

public class EditorMiscData
{
	private readonly List<CustomString> m_CustomStrings;

	private readonly List<CNDCGBPDHEB.JMOOIKALNBL> m_EditorErrors;

	private const int ERROR_ENTRY_INITIAL_CAPACITY = 100;

	private readonly UGCEditorErrorComparer m_EditorErrorComparor;

	private readonly CSVAsyncDataMap<int, CNDCGBPDHEB.AAJDBLADNEM> m_EditorErrorConfig;

	public UGCMergeMeshPreprocess AutoMergeMesh;

	public EAINEAFIMBD AutoStreamingGenerator;

	public UGCResourceEditor ResourceEditor;

	public List<string> RefSceneEntityIDList;

	public bool DisableAutoMergeMesh;

	private Dictionary<string, UGCWhiteListWordRegionControlData> m_UGCWhiteListWordRegionControlData;

	private List<string> m_WhiteListLanguages;

	public EditorMiscData(CSVAsyncDataMap<int, CNDCGBPDHEB.AAJDBLADNEM> config)
	{
	}

	public void AddCustomStringForInstance(EWorkshop.WordFilterType type, string str, string graphID = "", string ID = "")
	{
	}

	public List<CustomString> GetCustomStrings()
	{
		return null;
	}

	public void MergeFrom(EditorMiscData otherMiscData)
	{
	}

	public JODIOFLFODG ExportUserDataForCensorship()
	{
		return null;
	}

	private bool IsStringInWhitelist(string str)
	{
		return false;
	}

	public void AddErrorEntry(CNDCGBPDHEB.IJGKGIFOLGH errorCode, string entityType = "Object", string entityID = "", string graphID = "", string blockID = "", uint itemType = 0u, List<string> extraParams = null)
	{
	}

	public List<CNDCGBPDHEB.JMOOIKALNBL> GetErrorEntries()
	{
		return null;
	}

	public int HasErrorEntry(CNDCGBPDHEB.IJGKGIFOLGH errorCode, string entityType = "Object", string entityID = "", string graphID = "", string blockID = "", uint itemType = 0u)
	{
		return 0;
	}

	public CNDCGBPDHEB.AAJDBLADNEM GetFirstErrorData()
	{
		return null;
	}

	public void SortAllErrors()
	{
	}

	public Dictionary<uint, uint> ExportErrorSummary()
	{
		return null;
	}
}
