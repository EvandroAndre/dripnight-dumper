using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIHudReinforcedAnviTeammatePrimarySlotController : UIBaseController
{
	private UIHudReinforcedAnviTeammatePrimarySlotView m_View;

	private BHGGAEEHJCO m_PlayerID;

	private int m_TeamIndex;

	private UIHudReinforcedAnviWeaponInfoController m_WeaponSlot1;

	private UIHudReinforcedAnviWeaponInfoController m_WeaponSlot2;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void BindPlayerInfo(BHGGAEEHJCO playerID, int teamIndex, string nickName)
	{
	}

	public int GetTeamIndex()
	{
		return 0;
	}

	private void InitPlayerPrimarySlotInfo()
	{
	}

	public void ForceRefreshUI()
	{
	}

	private void OnWeaponChanged(uint playerID)
	{
	}

	private void OnWeaponAttachmentChanged(uint playerID)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
