using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

internal class UIModelStoreBox : UIBaseModel
{
	private class StoreBundleData
	{
		private List<BundleShowData> m_UniqueBundleShowData;

		private Dictionary<uint, List<BundleShowData>> m_StoreBundleDic;

		private Dictionary<uint, List<BundleShowData>> m_ServerBundleDic;

		private readonly Dictionary<uint, Dictionary<uint, BundleUpdateLocalDesc>> m_ServerBundleUpdateLocalDic;

		public void LoadFromServerData()
		{
		}

		public void UnloadData()
		{
		}

		private BundleShowData FindData(BundleShowData data)
		{
			return null;
		}

		public void AddLocalBundle(uint dataID, BundleShowData data)
		{
		}

		public void AddLocalBundleChecked(uint bundleID, List<BundleShowData> bundleShowDatas)
		{
		}

		public void AddServerBundle(BundleShow bundle_show)
		{
		}

		public void AddServerBundleUpdateLocal(List<BundleUpdateLocalDesc> bundleUpdateLocalDescs)
		{
		}

		public void ReplaceBundleServer(List<BundleShow> bundleShows)
		{
		}

		private void ReplaceBundleClient(uint bundleID, BundleShowData bundleShowData)
		{
		}

		private void UpdateBundleShowData(BundleShowData bundleShowData, BundleUpdateLocalDesc bundleUpdateLocalDesc)
		{
		}

		public Dictionary<uint, List<BundleShowData>> GetStoreBundleDic()
		{
			return null;
		}

		public Dictionary<uint, List<BundleShowData>> GetServerBundleDic()
		{
			return null;
		}
	}

	private class StoreOptionalBundleData
	{
		private SortedDictionary<uint, List<OptionalBundleShowData>> m_StoreOptionalBundleDic;

		private Dictionary<uint, List<OptionalBundleShowData>> m_ServerOptionalBundleDic;

		public void LoadFromServerData()
		{
		}

		public void UnloadData()
		{
		}

		public void AddLocalOptionalBundle(uint dataID, OptionalBundleShowData data)
		{
		}

		public void AddServerOptionalBundle(OptionalBundleShow bundle_show)
		{
		}

		public SortedDictionary<uint, List<OptionalBundleShowData>> GetStoreOptionalBundleDic()
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass27_0
	{
		public UIModelStoreBox _003C_003E4__this;

		public CSGetTreasureBoxByIDsReq req;

		internal void _003CCSGetTreasureBoxByIds_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass35_0
	{
		public UIModelStoreBox _003C_003E4__this;

		public CSGetBundleByIDsReq req;

		internal void _003CGetBundleByIds_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	public const uint PropID_GotTreasureBoxRes = 2u;

	public const uint PropID_GotBundleRes = 4u;

	public const uint PropID_GotTreasureBoxByIdsRes = 8u;

	public const uint PropID_GotBundleByIdsRes = 16u;

	private StoreBundleData m_StoreBundleData;

	private StoreOptionalBundleData m_StoreOptionalBundleData;

	private List<uint> m_StoreBundleCachedIds;

	private bool m_IsBundleRequest;

	private List<uint> m_StoreTreasureBoxCachedIds;

	private bool m_IsTreasureBoxRequest;

	private Dictionary<uint, List<TreasureBoxShowData>> m_UniqueTreasureBoxData;

	private Dictionary<uint, List<TreasureBoxShowData>> m_StoreTreasureBoxDict;

	private Dictionary<uint, List<BundleShowData>> StoreBundleDict => null;

	public SortedDictionary<uint, List<OptionalBundleShowData>> StoreOptionalBundleDict => null;

	private Dictionary<uint, List<TreasureBoxShowData>> StoreTreasureBoxDict
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool TryGetValue(uint bundleID, out List<BundleShowData> bundleShowDatas)
	{
		bundleShowDatas = null;
		return false;
	}

	public bool ContainsKey(uint bundleID)
	{
		return false;
	}

	public bool TryGetStoreTreasureBoxValue(uint id, out List<TreasureBoxShowData> listData)
	{
		listData = null;
		return false;
	}

	public bool ContainsStoreTreasureBox(uint id)
	{
		return false;
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	public void AddTreasureBoxToCacheAndRequestInfo(uint id)
	{
	}

	public void CSGetTreasureBoxByIds()
	{
	}

	private TreasureBoxShowData FindData(TreasureBoxShowData data)
	{
		return null;
	}

	private TreasureBoxShowData FindData(CrateTreasureGroupDesc data)
	{
		return null;
	}

	public void AddUniqueTreasureBoxData(TreasureBoxShowData data)
	{
	}

	public void AddLocalTreasureBoxData(List<TreasureBoxDataBoxData> lstBox, List<TreasureBoxShowData> lstItem)
	{
	}

	public void ProcessTreasureBox(CSGetTreasureBoxRes treasureBoxRes, bool notify = true)
	{
	}

	public void AddBundleToCacheAndRequestInfo(uint id)
	{
	}

	public void AddBundleToCacheWithoutRequest(uint id)
	{
	}

	public void GetBundleByIds()
	{
	}

	public void ProcessBundleUpdateLocal(CSGetBundleRes bundleRes)
	{
	}

	public void ProcessBundle(CSGetBundleRes bundleRes, bool notify = true)
	{
	}

	public void ProcessOptionalBundle(CSGetOptionalBundleRes optionalBundleRes)
	{
	}

	public void ProcessLocalBundle(List<CSVBaseData> bundleData)
	{
	}

	public void ProcessLocalOptionalBundle(List<OptionalBundleData> optionalbundleData)
	{
	}

	public void UnloadBundleData()
	{
	}

	public void ReloadBundleData()
	{
	}

	public List<BundleShowData> GetBundleShowDatas(uint bundleId, bool includeTailorAdvance = false)
	{
		return null;
	}
}
