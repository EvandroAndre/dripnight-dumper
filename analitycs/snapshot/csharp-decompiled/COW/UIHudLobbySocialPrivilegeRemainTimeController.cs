using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIHudLobbySocialPrivilegeRemainTimeController : UIBaseController
{
	private UIHudLobbySocialPrivilegeRemainTimeView m_View;

	private ulong m_CurrentEndUnix;

	private uint m_CurrentDataId;

	public const uint VISIBILITY_STATE_EVENT = 1073741824u;

	public const string LocKeyRemainTime1 = "T_54_ZP_NINTH_SYS_EXPIRED1";

	public const string LocKeyRemainTime2 = "T_54_ZP_NINTH_SYS_EXPIRED2";

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void OnUIReInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnSetVisible(object[] data)
	{
	}

	private NAELPAAELNO GetPrivilegeItem(uint dataid)
	{
		return null;
	}

	private void SetVisible(bool visible)
	{
	}

	private void _003COnSetVisible_003Eb__10_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIReInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
