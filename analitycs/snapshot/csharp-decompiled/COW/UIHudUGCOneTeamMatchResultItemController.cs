using GCommon;
using proto;

namespace COW;

public class UIHudUGCOneTeamMatchResultItemController : UIHudMatchResultItemBaseController
{
	private UIHudUGCSingleFightMatchResultItemView m_View;

	private ulong _003CAccountID_003Ek__BackingField;

	public ulong AccountID
	{
		get
		{
			return _003CAccountID_003Ek__BackingField;
		}
		private set
		{
			_003CAccountID_003Ek__BackingField = value;
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	protected override void OnSetPlayerData(UGCPlayerStats playerStats, bool single)
	{
	}

	private void UpdatePlayerInnerUI(UGCPlayerStats playerStats)
	{
	}

	private void ShowBannerVFX(bool show)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_SetViewData(object P0, int P1)
	{
	}

	public void _003C_003EiFixBaseProxy_OnSetPlayerData(UGCPlayerStats P0, bool P1)
	{
	}
}
