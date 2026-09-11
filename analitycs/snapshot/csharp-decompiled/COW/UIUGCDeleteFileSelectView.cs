using GCommon;
using UnityEngine;

namespace COW;

public class UIUGCDeleteFileSelectView : UIBaseView
{
	public UIButton BtnApply;

	public UIButton BtnPublished;

	public UILabel PublishedDesc;

	public UILabel PublishedTime;

	public UIButton BtnLocal;

	public UILabel LocalDesc;

	public UILabel LocalTime;

	public GameObject PublishSelected;

	public GameObject LocalSelect;

	public GameObject WaningIcon;

	public GameObject LocalWarningDesc;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
