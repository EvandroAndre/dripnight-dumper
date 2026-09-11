using GCommon;
using UnityEngine;

namespace COW;

public class UIHudSceneEditItemTransformVector3View : UIBaseView
{
	public UIInputEnhance ValueInputX;

	public BoxCollider UIInputColliderX;

	public UILabel TitleLabel;

	public UIInputEnhance ValueInputY;

	public BoxCollider UIInputColliderY;

	public UIInputEnhance ValueInputZ;

	public BoxCollider UIInputColliderZ;

	public UISprite Bg;

	public UISprite XInput;

	public UISprite YInput;

	public UISprite ZInput;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
