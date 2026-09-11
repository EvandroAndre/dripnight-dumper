using GCommon;
using message;

namespace COW;

internal class UIHudHGMiniMapInZoneStateController : UIBaseController, IMiniMapInZoneStateUI
{
	private UIHudHGMiniMapInZoneStateView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void UpdateShowData(COCKBAEBNLG zoneType)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
