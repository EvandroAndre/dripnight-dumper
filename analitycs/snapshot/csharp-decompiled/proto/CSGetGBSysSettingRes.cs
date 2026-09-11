using System.Collections.Generic;

namespace proto;

public class CSGetGBSysSettingRes
{
	public List<BigEventProgressAwardDesc> progress_awards;

	public BigEventProgressCycleAwardDesc cycle_award;

	public GBSysSettingDesc setting;

	public List<GBSysQTEDesc> qtes;

	public List<GBSysQTEWeightDesc> qte_weights;
}
