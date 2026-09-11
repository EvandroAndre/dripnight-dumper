using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDUGC_AddScoreVFXView : UIBaseView
{
	public GameObject cloneItem;

	public Transform VfxStartPos;

	public GameObject grid;

	public Transform VfxEndPos;

	public Transform vfxContainer;

	public TweenPositionArc vfxTweenPosArc;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
