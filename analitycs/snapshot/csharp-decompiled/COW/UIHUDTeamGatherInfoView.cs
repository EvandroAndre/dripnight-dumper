using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDTeamGatherInfoView : UIBaseView
{
	public GameObject RequesterRoot;

	public GameObject TeammateRoot;

	public GameObject AcceptInfoRoot;

	public GameObject TeleportRoot;

	public UISprite Progress;

	public TeamGatherTeammateStateView teammate1;

	public TeamGatherTeammateStateView teammate2;

	public TeamGatherTeammateStateView teammate3;

	public UISprite Indicator;

	public UILabel WaitTeleportTimer;

	public UISprite RequesterIcon;

	public UILabel RequesterTeamIdx;

	public UIButton AcceptBtn;

	public UIButton RejectBtn;

	public UITable TableContainer;

	public GameObject InterruptRoot;

	public GameObject RequesterContainer;

	public UITable TeammateTopTable;

	public UISprite airdropType;

	public UISprite treasureType;

	public UISprite revivePointType;

	public UISprite energyDeviceType;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
