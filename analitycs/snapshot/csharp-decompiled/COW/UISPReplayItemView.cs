using GCommon;
using UnityEngine;

namespace COW;

internal class UISPReplayItemView : UIBaseView
{
	public UILabel Date;

	public UILabel MatchID;

	public UILabel RoomInfo;

	public UILabel Players;

	public UILabel ModeName;

	public GameObject Sole;

	public GameObject Duo;

	public GameObject Quad;

	public UILabel Time;

	public UIButton PlayBtn;

	public UIButton DelBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
