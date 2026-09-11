using GCommon;
using UnityEngine;

namespace COW;

public class UIOTPBindView : UIBaseView
{
	public Transform MainContainer;

	public UIButton CloseBtn;

	public Transform UIOTPBind;

	public GameObject Dot1ReachedSprite;

	public GameObject Dot2ReachedSprite;

	public GameObject Dot3ReachedSprite;

	public UILabel Title;

	public GameObject BindSuccessSprite;

	public GameObject GuideSprite;

	public GameObject SuccessTitle;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
