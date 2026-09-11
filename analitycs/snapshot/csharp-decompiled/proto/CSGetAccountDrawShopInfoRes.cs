using System.Collections.Generic;

namespace proto;

public class CSGetAccountDrawShopInfoRes
{
	public List<PBAccountDrawShopWheelInfo> wheel_infos;

	public List<PBAccountDrawShopTowerInfo> tower_infos;

	public List<LimitedPoolInfo> limited_pool_infos;
}
