using GCommon;
using UnityEngine;

namespace COW;

public class UILobbyV2GameAssistRequestItemView : UIBaseView
{
	public Transform CallSignContainer;

	public UIButton AcceptSprite;

	public UIButton RefuseSprite;

	public Transform HighLightContainer;

	public GameObject Line;

	public UIButton ProfileBtn;

	public UIWidget ProfileWidget;

	public GameObject ExtraInfoContainer;

	public UITable ExtraInfoTable;

	public UILabel CommonFriendLabel;

	public UILabel AddFromLabel;

	public UIButton DetailsBtn;

	public Transform ArrowIcon;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
