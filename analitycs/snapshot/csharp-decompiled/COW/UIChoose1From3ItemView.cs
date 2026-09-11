using GCommon;
using UnityEngine;

namespace COW;

public class UIChoose1From3ItemView : UIBaseView
{
	public UILabel ItemName;

	public GameObject HighLight;

	public UIButton ItemButton;

	public BaseItemView ItemIconContainer;

	public UISprite NewQualityicon;

	public GameObject NotRecharge;

	public GameObject ChooseHasRecharge;

	public GameObject PriceContent;

	public UILabel Price;

	public UISprite BG;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
