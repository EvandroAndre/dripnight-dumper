using GCommon;
using UnityEngine;

namespace COW;

public class UIChatMessageItemNewGroupInviteView : UIBaseView
{
	public UISprite BG;

	public UILabel ModeName;

	public UISprite LadderMaxIcon;

	public UISprite LadderMinIcon;

	public UILabel LabelGroupNum;

	public UISprite GameBufIcon;

	public UISprite MapBonusBufIcon;

	public GameObject CSbuff;

	public GameObject Ladderlimits;

	public UITable Buff_Container;

	public Transform LadderMaxBRIcon;

	public Transform LadderMinBRIcon;

	public GameObject CSPeakMax;

	public GameObject CSPeakMin;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
