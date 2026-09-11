using GCommon;
using UnityEngine;

namespace COW;

public class UIHudLobbyLWQueueStateView : UIBaseView
{
	public UILabel TxtStatus;

	public UILabel TxtQueueNumber;

	public UIButton BtnLeave;

	public GameObject QueueState;

	public GameObject DefenderState;

	public UITable StateDescTable;

	public GameObject ImgLeaveIconContainer;

	public GameObject ImgStatusBg;

	public GameObject ImgStatusBgNoBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
