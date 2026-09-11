using GCommon;
using UnityEngine;

namespace COW;

public class UIHudClanWarMiniBoardItemView : UIBaseView
{
	public GameObject IsSelf;

	public UISprite RankIcon;

	public UILabel RankLabel;

	public UILabel GuildName;

	public UILabel Score;

	public GameObject NormalBG;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
