using System.Collections.Generic;

namespace proto;

public class CSGetLoginHistoryRes
{
	public List<DeviceInfo> login_history;

	public bool has_unknown_device;

	public bool is_different_device;
}
