using GCommon;
using UnityEngine;

namespace COW;

public class UIHudLeaderboardItemView : UIBaseView
{
	public AutoChangeComp AutoChangeComp;

	public GameObject BGDefault;

	public GameObject BGLocal;

	public UILabel LabelName;

	public UILabel LabelClan;

	public UILabel LabelKill;

	public UILabel LabelDead;

	public UILabel LabelAssist;

	public UILabel LabelTotalDamage;

	public UISprite RankSprite;

	public GameObject PrivilegeIcon;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
