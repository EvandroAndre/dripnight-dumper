using System.Collections.Generic;

namespace UMA.Simple;

public class SlotOverlayAssetCacheData
{
	public Dictionary<int, SlotDataAsset> m_SlotCache;

	public Dictionary<int, OverlayDataAsset> m_OverlayCache;

	public Dictionary<uint, AsyncLoadReq> m_LoadingReqs;

	public AsyncLoadReqPool m_ReqPool;
}
