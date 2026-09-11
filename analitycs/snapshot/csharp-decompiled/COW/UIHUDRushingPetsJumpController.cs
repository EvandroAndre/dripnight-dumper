using GCommon;

namespace COW;

internal class UIHUDRushingPetsJumpController : UIHudButtonBaseController
{
	private UIHudRushingPetsJumpView m_View;

	private bool m_Isfalling;

	private const string m_JumpIconName = "FF_UI_RushingPets_Jump";

	private const string m_JumpIconFallingName = "FF_UI_RushingPets_Jump01";

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override string GetMappingName()
	{
		return null;
	}

	protected override void OnUIInit()
	{
	}

	private void Update()
	{
	}

	private void SetHightlight(bool flag)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
