using System.Collections.Generic;

namespace proto;

public class CSGetPayBundleWindowDescRes
{
	public List<PayBundleWindowDesc> pay_bundle_windows;

	public uint next_refresh_time;

	public List<LevelUpPassDesc> level_up_pass;
}
