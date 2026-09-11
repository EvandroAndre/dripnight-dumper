using GCommon;
using UnityEngine;

namespace COW;

public class UICupMatchFactionView : UIBaseView
{
	public Animator Animator;

	public UILabel MyTeamName;

	public UILabel MyTeamDesc;

	public UISprite MyTeamIcon;

	public UILabel OppoTeamName;

	public UILabel OppoTeamDesc;

	public UISprite OppoTeamIcon;

	public UIButton MaskBtn;

	public UILabel Next;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
