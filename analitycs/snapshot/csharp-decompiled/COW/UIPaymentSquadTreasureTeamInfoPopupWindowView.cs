using GCommon;
using UnityEngine;

namespace COW;

public class UIPaymentSquadTreasureTeamInfoPopupWindowView : UIBaseView
{
	public GameObject Top;

	public UILabel TitleLabel;

	public UILabel DescTopLabel;

	public UIButton BtnCheck;

	public UINetworkTexture TopBG;

	public GameObject Bottom;

	public UILabel TeamNameLabel;

	public UITable TeamTable;

	public UIButton BtnJoin;

	public UIButton BtnUnJoin;

	public GameObject BottomBG;

	public UILabel DescDownLabel;

	public UINetworkTexture TitleCDN;

	public UIButton Close;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
