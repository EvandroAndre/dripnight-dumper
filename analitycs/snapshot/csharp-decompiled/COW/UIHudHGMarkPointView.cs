using GCommon;
using UnityEngine;

namespace COW;

public class UIHudHGMarkPointView : UIBaseView
{
	public UISprite MarkIconSprite;

	public GameObject ArrowLeft;

	public GameObject ArrowUp;

	public GameObject ArrowRight;

	public GameObject ArrowDown;

	public UILabel DistanceLabel;

	public Transform ShowRoot;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
