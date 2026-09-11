using GCommon;
using proto;

namespace COW;

public class UIRematchInvitePlayerItemController : UIBaseController
{
	private readonly string[] PlayerIndexSpriteNames;

	private UIRematchInvitePlayerItemView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetViewData(UIPostMatchTeamUpCountDownController.PlayerData playerPostData, bool needShowDivider, bool isMvp = false)
	{
	}

	private TeammateStats FindLastMatchStats(UIModelMatch modelMatch, ulong accountId)
	{
		return null;
	}

	private void ResetState()
	{
	}

	private void RefreshPlayerIndexSprite(int teamIndex)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
