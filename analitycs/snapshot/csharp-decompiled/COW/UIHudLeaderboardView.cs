using GCommon;
using UnityEngine;

namespace COW;

public class UIHudLeaderboardView : UIBaseView
{
	public UIGrid ItemListGridMyTeam;

	public Transform ItemListGridMyTeamTF;

	public UISprite MyFactionIcon;

	public UILabel MyFactionName;

	public UIGrid ItemListGridEnemyTeam;

	public Transform ItemListGridEnemyTeamTF;

	public UISprite EnemyFactionIcon;

	public UILabel EnemyFactionName;

	public UIButton BtnClose;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
