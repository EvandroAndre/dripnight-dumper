using GCommon;
using UnityEngine;

namespace COW;

public class UIFFWSFlameBigMapInfoView : UIBaseView
{
	public UISprite Icon;

	public UILabel Title;

	public UILabel TeamKillLabel;

	public Transform TitleRoot;

	public UITable ContentTable;

	public UIBigmapFFWSFlagTeammateView TeammateShow;

	public GameObject defaultIcon;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
