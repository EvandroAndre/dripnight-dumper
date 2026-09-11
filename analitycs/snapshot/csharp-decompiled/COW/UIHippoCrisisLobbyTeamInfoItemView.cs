using GCommon;
using UnityEngine;

namespace COW;

public class UIHippoCrisisLobbyTeamInfoItemView : UIBaseView
{
	public UILabel PlayerName;

	public UIColor Line;

	public UISprite Rank;

	public UITable NameAndTable;

	public Animation main;

	public UILabel MoneyCntLabel;

	public UITable EquipTable;

	public UIGrid WeaponGrid;

	public UIGrid ArmorGrid;

	public UIGrid OtherGrid;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
