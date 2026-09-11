using GCommon;
using UnityEngine;

namespace COW;

public class UIHudHighlightPhotoDescView : UIBaseView
{
	public UISprite Icon;

	public UILabel Name;

	public UILabel MapAndModeLabel;

	public UILabel TimeLabel;

	public Transform right;

	public Transform left;

	public Transform bottom;

	public GameObject numContainer;

	public UILabel killCntLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
