using GCommon;
using UnityEngine;

namespace COW;

public class UICustomRoomRankTeammateView : UIBaseView
{
	public UILabel Nickname;

	public UITable2Item Container;

	public UILabel KDAValue;

	public UILabel DamageValue;

	public GameObject HighlightBG;

	public UISprite SelfHighlightBG;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
