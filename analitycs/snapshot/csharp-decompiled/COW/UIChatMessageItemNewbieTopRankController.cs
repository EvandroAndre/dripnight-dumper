using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIChatMessageItemNewbieTopRankController : UIBaseController
{
	private const string TitleLocKey = "T_53_L_NEWSOCIAL_ROOKIECHANNEL_RANKTITLE";

	private const int BgHeightOnePlayer = 106;

	private const int BgHeightStep = 60;

	private const int MaxPlayerCount = 3;

	private UIChatMessageItemNewbieTopRankView m_View;

	private readonly List<UIChatMessageNewBieTopPlayerController> m_PlayerCtrls;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetUIData(MessageInfo info)
	{
	}

	private void EnsurePlayerControllers(int count)
	{
	}

	private void HideAllPlayers()
	{
	}

	private void RefreshBackgroundHeight(int playerCount)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
