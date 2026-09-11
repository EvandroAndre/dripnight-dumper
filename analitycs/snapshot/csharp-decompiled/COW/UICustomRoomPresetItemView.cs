using GCommon;
using UnityEngine;

namespace COW;

public class UICustomRoomPresetItemView : UIBaseView
{
	public UILabel GroupMode;

	public UILabel MaxMember;

	public UISprite WeatherSprite;

	public UILabel MapName;

	public UISprite Map;

	public GameObject Emulator;

	public GameObject AFK;

	public UILabel ModeName;

	public UITable Flags;

	public UILabel PresetName;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
