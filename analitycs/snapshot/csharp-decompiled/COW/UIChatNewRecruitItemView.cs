using GCommon;
using UnityEngine;

namespace COW;

public class UIChatNewRecruitItemView : UIBaseView
{
	public UILabel Mode;

	public GameObject GroupRoot;

	public GameObject GameBufIcon;

	public UISprite GameBufIconSprite;

	public UITable TagTable;

	public UITable GroupHeadTable;

	public Transform GroupHeadTrans;

	public UISprite MapBonusBuffIcon;

	public UISprite bg;

	public UITable IconTable;

	public GameObject CSbuff;

	public UILabel DefaultTagLabel;

	public UISprite LadderMaxIcon;

	public UISprite LadderMinIcon;

	public GameObject SelfBG;

	public UITable Table;

	public GameObject Ladderlimits;

	public UISprite Light_FollowBgChange;

	public GameObject DefaultTagLabelContainer;

	public Transform LadderMaxBRIcon;

	public Transform LadderMinBRIcon;

	public GameObject GroupView;

	public GameObject RoomView;

	public UILabel ModeName;

	public UILabel MapName;

	public UILabel GameMode;

	public UILabel GroupMode;

	public UILabel NumberLabel;

	public UIButton Button;

	public GameObject LadderCSPeakMax;

	public GameObject LadderCSPeakMin;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
