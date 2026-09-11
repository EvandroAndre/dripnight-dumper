using GCommon;
using UnityEngine;

namespace COW;

public class UISparkPetDoubleCheckPopupView : UIBaseView
{
	public UIButton BackButton;

	public UIButton ConfirmButton;

	public UINetworkTexture BuddySparkPetCDN;

	public UINetworkTexture LocalSparkPetCDN;

	public UILabel PlayerName;

	public UILabel BuddyName;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
