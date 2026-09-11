using GCommon;
using UnityEngine;

namespace COW;

public class UIBRMatchReviewView : UIBaseView
{
	public UIButton BtnClose;

	public Transform MapPlaceholder;

	public UIButton BtnLegends;

	public UIPanel TimelineBarMount;

	public GameObject MainPanel;

	public UIPanel BattleLogArea;

	public UIPanel TeamMemberArea;

	public UIPanel TopInfoBar;

	public UILabel TeamNumber;

	public UILabel PlayerNumer;

	public Transform ShareCtrlPos;

	public GameObject LeftAnchor;

	public GameObject RightAnchor;

	public GameObject LeftPos;

	public GameObject RightPos;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
