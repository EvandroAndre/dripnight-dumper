using GCommon;
using proto;

namespace COW;

public class UIHUDUGC_MultiTeamMatchResultPlayerItemController : UIHudMatchResultItemBaseController
{
	private UIHUDUGC_MultiTeamResultPlayerItemView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void Awake()
	{
	}

	protected override void OnDestroy()
	{
	}

	protected override void OnSetPlayerData(UGCPlayerStats playerStats, bool single)
	{
	}

	public void SetPlayerScore(int index, string value)
	{
	}

	public override void ShowAddFriendButton(bool show)
	{
	}

	public override void ShowReportButton(bool show)
	{
	}

	public override void ShowLikeContainer(bool show)
	{
	}

	private void UpdatePlayerData(UGCPlayerStats playerStats)
	{
	}

	private void onUIShowPlayerBannerVFX(object[] data)
	{
	}

	private void ShowBannerVFX(bool show)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_Awake()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnSetPlayerData(UGCPlayerStats P0, bool P1)
	{
	}

	public void _003C_003EiFixBaseProxy_ShowAddFriendButton(bool P0)
	{
	}

	public void _003C_003EiFixBaseProxy_ShowReportButton(bool P0)
	{
	}

	public void _003C_003EiFixBaseProxy_ShowLikeContainer(bool P0)
	{
	}
}
