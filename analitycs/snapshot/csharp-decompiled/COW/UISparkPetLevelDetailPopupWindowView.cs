using GCommon;
using UnityEngine;

namespace COW;

public class UISparkPetLevelDetailPopupWindowView : UIBaseView
{
	public UILabel CurrentText;

	public UILabel DetailDesc;

	public UIScrollView RewardScrollView;

	public UIEasyList RewardItemEasyList;

	public UILabel CurrExpLabel;

	public UILabel JuniorCurrentStateLabel;

	public UINetworkTexture JuniorSparkCDN;

	public UINetworkTexture EvolvedSparkCDN;

	public UILabel EvolvedLevelLabel;

	public UILabel EvolvedCurrentStateLabel;

	public UINetworkTexture UltimateSparkCDN;

	public UILabel UltimateLevelLabel;

	public UILabel UltimateCurrentStateLabel;

	public UIProgressBar ProgressBars;

	public UILabel JuniorLevelLabel;

	public UIButton CloseButton;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
