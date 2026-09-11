using GCommon;
using UnityEngine;

namespace COW;

public class UIBigEventLobbyEnterItemView : UIBaseView
{
	public GameObject CheckboxForNotifyBoxContent;

	public UIToggle CheckboxForNotify;

	public UILabel TitleLabel;

	public UILabel ActTimeLabel;

	public UISprite RewardIcon;

	public UISprite RewardIcon_bg;

	public UIButton GotoBtn;

	public GameObject BtnStateGoto;

	public GameObject BtnStateClose;

	public UILabel closeLabel;

	public UINetworkTexture CDNBg;

	public UILabel NotifyLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
