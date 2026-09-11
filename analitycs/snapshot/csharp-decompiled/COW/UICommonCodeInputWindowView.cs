using GCommon;
using UnityEngine;

namespace COW;

public class UICommonCodeInputWindowView : UIBaseView
{
	public UILabel title;

	public UIGrid codeGrid;

	public UILabel codeItem;

	public UIGrid btnGrid;

	public UIToggleButtonGroup btnToggleGroup;

	public GameObject btnItem;

	public UIButton CodePasteBtn;

	public GameObject PasteIcon;

	public GameObject PasteIconGrey;

	public UIButton QRSCanBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
