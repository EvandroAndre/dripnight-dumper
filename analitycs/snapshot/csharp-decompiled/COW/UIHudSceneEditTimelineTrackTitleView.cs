using GCommon;
using UnityEngine;

namespace COW;

public class UIHudSceneEditTimelineTrackTitleView : UIBaseView
{
	public UISprite Back;

	public UISprite Arrow;

	public UIButton BtnArrow;

	public UIInput TrackName;

	public BoxCollider InputCollider;

	public UITable Table;

	public GameObject SelectedFrame;

	public UISprite SelectedFrameSprite;

	public UISprite Icon;

	public GameObject Warn;

	public UIButton BtnWarn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
