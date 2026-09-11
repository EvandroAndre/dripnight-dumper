using GCommon;
using UnityEngine;

namespace COW;

public class UILobbyV2TeamInfoItemView : UIBaseView
{
	public UIGrid AvatarGrid;

	public Transform PetPos;

	public UISprite LoadoutIcon;

	public UILabel Name;

	public UIGrid IconGrid;

	public UIButton LoadoutDetail;

	public UIColor Line;

	public UISprite Rank;

	public UISprite LoadoutV2;

	public GameObject Bg_Normal;

	public GameObject Bg_RankLimit;

	public UITable Table;

	public Animation main;

	public GameObject Loadout;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
