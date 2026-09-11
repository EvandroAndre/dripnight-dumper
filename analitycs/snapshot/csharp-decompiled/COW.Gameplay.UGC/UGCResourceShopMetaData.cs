using message;

namespace COW.Gameplay.UGC;

public class UGCResourceShopMetaData
{
	private UGCRSP_ResourceData m_RawData;

	public ulong ResourceId;

	public EShopStatus Status;

	public string UUID;

	public int Version;

	public string Url;

	public string ResourceCode;

	public int UpdateTime;

	public int Public;

	public int Recreation;

	public ulong BuyCount;

	public uint Cost;

	private string m_LocalUrl;

	private string m_UUIDWithVersion;

	public string ResourceName;

	public string ResourceDesc;

	public string CoverUrl;

	public EShopResourceType ResourceType;

	public int MainCategory;

	public int SubCategory;

	public bool IsOwned;

	public ulong AccountId;

	public string CreatorRegion;

	public int EditorType;

	public ulong LikeCount;

	public string BuildInPackageId;

	public UGCRSP_ResourceData RawData
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool IsRefValid => false;

	public string LocalUrl => null;

	public string UUIDWithVersion => null;

	public bool IsDownload => false;

	public MBFMAHGABDN ToPackageRefInfo()
	{
		return null;
	}
}
