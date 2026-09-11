using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class PatchOptionalResManager : SingletonModule<PatchOptionalResManager>
{
	private sealed class _003C_003Ec__DisplayClass31_0
	{
		public uint OptionalReDefId;

		internal bool _003CGetPatchOptionaShowData_003Eb__0(PatchOptionalCategoryManagerData a)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass32_0
	{
		public uint tag;

		public PatchOptionalCategoryManagerData show_data;

		internal bool _003CIsRecommengTag_003Eb__0(PatchOptionalCategoryManagerData item)
		{
			return false;
		}

		internal bool _003CIsRecommengTag_003Eb__1(PatchOptionalTypeManagerData item)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass33_0
	{
		public uint typeId;

		internal bool _003CGetTypeData_003Eb__0(PatchOptionalTypeManagerData a)
		{
			return false;
		}
	}

	private List<PatchOptionalCategoryManagerData> m_CategoryManagerDataList;

	private List<PatchOptionalTypeManagerData> m_TypeManagerDataList;

	private Dictionary<uint, PatchOptionalResManagerData> m_ResManagaerDict;

	private List<PatchOptionalOldResourceData> m_OldFileResource;

	private List<PatchOptionalResDefData> m_RedefDataList;

	private List<PatchOptionalResDefHotData> m_ReDefDeleteHotDataList;

	private Dictionary<uint, List<uint>> m_ResTypeOptionalRedefIdDict;

	private List<uint> m_SortedRecommendHotSortShowIdList;

	private List<uint> m_SortedAllShowTagOptionalRedefIdWithoutRecommend;

	private List<uint> m_SortedAllShowTagOptionalRedefIdWithRecommend;

	private OptionalDownloadClientType clientType;

	private static Dictionary<uint, uint> DownloadQualityMap;

	private const string DELTED_KEYTAG = "_DeletedTag";

	public const string MAP_DOWNLOAD_KEY = "MAPDOWNLOAD_{0}";

	protected override void OnCleanup()
	{
	}

	protected override void OnInit()
	{
	}

	private void LoadPatchOptionalOldResourceCSV()
	{
	}

	private void LoadPatchOptionalTypeManagerCSV()
	{
	}

	private void LoadPatchOptionalResManagerCSV()
	{
	}

	private void LoadPatchOptionalResDefHotDataCSV()
	{
	}

	private void LoadPatchOptionalResDefCSV()
	{
	}

	private void LoadPatchOptioanlCategoryManagerCSV()
	{
	}

	private void ProcessOptionalRedefIdData()
	{
	}

	public List<PatchOptionalResDefData> GetPatchOptionalResDefDatas()
	{
		return null;
	}

	private void InitShowOptionalRedefIdList()
	{
	}

	public List<uint> GetShowOptionalReDefId(bool needHotSort = false)
	{
		return null;
	}

	private void InitRecommendOptionalRedefIdList()
	{
	}

	public List<uint> GetRecommendOptionalRedefIdList()
	{
		return null;
	}

	public int HotSort(uint x, uint y)
	{
		return 0;
	}

	public bool CheckThisPackHaveBeRelativedDeleted(uint optionalRedefID)
	{
		return false;
	}

	public List<uint> GetNeedDeleteResOptionalReDefIdList()
	{
		return null;
	}

	public PatchOptionalCategoryManagerData GetPatchOptionaShowData(uint OptionalReDefId)
	{
		return null;
	}

	public bool IsRecommengTag(uint tag)
	{
		return false;
	}

	public PatchOptionalTypeManagerData GetTypeData(uint typeId)
	{
		return null;
	}

	public PatchOptionalResManagerData GetResManagerData(uint OptionalReDefId)
	{
		return null;
	}

	public bool GetDownloadState(uint tagId)
	{
		return false;
	}

	public List<uint> GetNeedAutoDownloadResOptionalReDefIdList(List<uint> tagIdList)
	{
		return null;
	}

	public void UpdateLocalMapDownloadInfo(uint optionalReDefID, bool isDownloaded)
	{
	}

	public void ProcessPatchOptionalResManagerData(List<PatchOptionalResManagerUpdateDesc> PatchOptionalResManagerDataUpdateList)
	{
	}

	public List<uint> GetSortedTypeIdList()
	{
		return null;
	}

	public List<string> GetOldResourceFileAbName()
	{
		return null;
	}

	public List<uint> GetResDownloadTypeOptionalRedefIdList(uint resdownloadType)
	{
		return null;
	}
}
