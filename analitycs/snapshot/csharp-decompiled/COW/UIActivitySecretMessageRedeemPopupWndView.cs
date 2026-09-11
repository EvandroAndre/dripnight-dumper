using GCommon;
using UnityEngine;

namespace COW;

public class UIActivitySecretMessageRedeemPopupWndView : UIBaseView
{
	public UIButton ConfirmBtn;

	public UILabel SecretMessageLabel;

	public UIInput SecretMessageInput;

	public UILabel HelpTipsLabel;

	public GameObject SecretMessageInputMask;

	public UIPanel GuideMaskPanel;

	public UIButton GuideMask;

	public UIButton PasteBtn;

	public UIButton ConfirmBtnGrey;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
