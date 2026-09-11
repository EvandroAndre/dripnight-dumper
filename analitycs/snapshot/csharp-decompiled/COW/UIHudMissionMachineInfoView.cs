using GCommon;
using UnityEngine;

namespace COW;

public class UIHudMissionMachineInfoView : UIBaseView
{
	public UISprite Background;

	public UITable ContentTable;

	public UISprite Icon;

	public UILabel Title;

	public UILabel Description;

	public UILabel RewardNumber;

	public Transform EndPadding;

	public UILabel Time;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
