using GCommon;
using UnityEngine;

namespace COW;

public class UIHudCustomShareCodePopupWindowView : UIBaseView
{
	public UIButton CopyOrUseBtn;

	public UILabel InValidLabel;

	public GameObject InValidContainer;

	public GameObject BtnLoading;

	public UILabel DescLabel;

	public UILabel BtnDisableLabel;

	public UILabel BtnEnableLabel;

	public GameObject BtnEnable;

	public GameObject BtnDisable;

	public UIInput InputContent;

	public UIButton SensitivityBtn;

	public Transform SensitivityPopUpTrans;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
