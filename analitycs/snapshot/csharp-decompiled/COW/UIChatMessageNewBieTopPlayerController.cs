using GCommon;
using UnityEngine;

namespace COW;

public class UIChatMessageNewBieTopPlayerController : UIBaseController
{
	private UIChatMessageNewBieTopPlayerView m_View;

	private FastNewbieTopRankPlayer m_CurrentData;

	private static readonly Color32 FirstRankUpIconColor;

	private static readonly Color32 NormalRankUpIconColor;

	private static readonly string[] RankBgSpriteNames;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetUIData(FastNewbieTopRankPlayer data, int rankIndex)
	{
	}

	private void UpdateRankStyle(int rankIndex)
	{
	}

	private void UpdateHeadPic(FastNewbieTopRankPlayer data)
	{
	}

	private void OnHeadBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
