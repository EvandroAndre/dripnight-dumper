using GCommon;

namespace COW;

public class UIHudCrosshairsOBController : UIBaseController
{
	private UIHudCrosshairsOBView m_View;

	private uint m_BreakAnimDelayID;

	private uint m_BreakSoundDelayID;

	private const float BreakAnimTime = 1.5f;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override bool RecyleDontDestroy()
	{
		return false;
	}

	public static bool DontDestroy()
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	public override void OnUIReInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void OnPersonaBreak(GEvent evt)
	{
	}

	private void PlayerArmorBreak(uint armorInvType)
	{
	}

	private void PlayShieldBreak()
	{
	}

	private void _003CPlayerArmorBreak_003Eb__11_0()
	{
	}

	private void _003CPlayerArmorBreak_003Eb__11_1()
	{
	}

	private void _003CPlayerArmorBreak_003Eb__11_2()
	{
	}

	private void _003CPlayShieldBreak_003Eb__12_0()
	{
	}

	private void _003CPlayShieldBreak_003Eb__12_1()
	{
	}

	public bool _003C_003EiFixBaseProxy_RecyleDontDestroy()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIReInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
