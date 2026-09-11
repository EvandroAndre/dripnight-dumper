using GCommon;
using UnityEngine;

namespace COW;

public class UIBigEvent_CustomCardItemView : UIBaseView
{
	public UINetworkTexture Background;

	public UILabel StateLabel;

	public UINetworkTexture Card;

	public UIButton Button;

	public UINetworkTexture BtnTex;

	public UILabel BtnLabel;

	public Transform ProfileInfoRoot;

	public UITable Table;

	public GameObject Token;

	public UISprite TokenIcon;

	public UILabel TokenCount;

	public UILabel Need;

	public UILabel GiveRecordLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
