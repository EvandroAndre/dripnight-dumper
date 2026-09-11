using GCommon;
using UnityEngine;

namespace COW;

public class UIActivityProgressContentTemplateView : UIBaseView
{
	public GameObject ProgressTable;

	public UISprite Token;

	public UILabel TokenLabel;

	public UIScrollView ScrollView;

	public UITable Table;

	public UIButton OperationButton;

	public UILabel CircleLabel;

	public GameObject ProgressBg;

	public UINetworkTexture ProgressBgCnd;

	public GameObject OperationButtonPic;

	public UINetworkTexture OperationButtonCdn;

	public UILabel OperationLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
