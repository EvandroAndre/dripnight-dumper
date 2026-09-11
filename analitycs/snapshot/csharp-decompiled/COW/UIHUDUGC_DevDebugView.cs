using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDUGC_DevDebugView : UIBaseView
{
	public UIButton BtnClose;

	public UIInput TxtGSIP;

	public UIInput TxtGSPort;

	public UIInput TxtTeamID;

	public UIInput TxtClientCount;

	public UIInput TxtLastMatchID;

	public UIInput TxtTargetMatchID;

	public UIInput TxtModeID;

	public UIInput TxtMapID;

	public UIInput TxtMapURL;

	public UIButton BtnNewMatch;

	public UIButton BtnJoinMatch;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
