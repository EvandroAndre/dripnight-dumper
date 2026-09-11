using GCommon;
using UnityEngine;

namespace COW;

public class UIBigEvent_PersonalProgress_MissionItemView : UIBaseView
{
	public UILabel LabelDescription;

	public GameObject LabelReceived;

	public UIButton BtnReceive;

	public GameObject GoAwarded;

	public UINetworkTexture TextureBg;

	public UILabel LabelProcess;

	public UIGrid GridAwards;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
