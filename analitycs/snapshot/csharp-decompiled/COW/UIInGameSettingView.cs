using GCommon;
using UnityEngine;

namespace COW;

public class UIInGameSettingView : UIBaseView
{
	public UIGrid Grid;

	public GameObject SettingContentShort;

	public UIToggleButtonGroup ToggleGroup;

	public UISprite ToggleBg;

	public UIPanel UIInGameSetting;

	public Transform CDNContent;

	public UINetworkTexture CDNTexture;

	public Transform ShortSetting;

	public Transform LongSetting;

	public UILabel DesLabel;

	public UIButton ResetBtn;

	public UILabel CDNLabel;

	public Transform SensiPopMenuTrans;

	public UIWidget CDNGuideTransform;

	public UIWidget ToggleGuideTransform;

	public UIButton Tips;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
