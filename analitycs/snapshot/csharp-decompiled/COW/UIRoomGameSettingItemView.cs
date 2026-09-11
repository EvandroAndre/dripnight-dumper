using GCommon;
using UnityEngine;

namespace COW;

public class UIRoomGameSettingItemView : UIBaseView
{
	public UILabel Text;

	public UILabel Title;

	public GameObject PredictToolEnable;

	public GameObject PredictToolDisable;

	public GameObject TrapEnable;

	public GameObject TrapDisable;

	public Transform RoomPresetPos;

	public Transform RightContainer;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
