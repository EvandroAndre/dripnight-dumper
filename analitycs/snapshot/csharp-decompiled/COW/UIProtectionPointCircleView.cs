using GCommon;
using UnityEngine;

namespace COW;

public class UIProtectionPointCircleView : UIBaseView
{
	public UISprite ShieldIcon;

	public UILabel ProtectPointNum;

	public UICircleWithBreakPointSprite ProtectPointBg;

	public Transform BGTransform;

	public UICircleWithBreakPointSprite ProtectPointBefFg;

	public Transform PointBefTransform;

	public UICircleWithBreakPointSprite ProtectPointNowFg;

	public Transform PointNowTransform;

	public GameObject Container;

	public UILabel ProtectPointChange;

	public GameObject ProtectPointNumMatchResult;

	public UILabel CurrentPoints;

	public UILabel TotalPoints;

	public GameObject ProtectedVFX;

	public UICircleWithBreakPointSprite ProtectPointFullFg;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
