using GCommon;
using UnityEngine;

namespace COW;

public class UIHudControlLeaderboardView : UIBaseView
{
	public UILabel LeftTitle_1;

	public UILabel LeftTitle_2;

	public UILabel LeftTitle_3;

	public UIGrid ItemListGridMyTeam;

	public Transform ItemListGridMyTeamTF;

	public UISprite MyFactionIcon;

	public UILabel MyFactionName;

	public UILabel RightTitle_1;

	public UILabel RightTitle_2;

	public UILabel RightTitle_3;

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
