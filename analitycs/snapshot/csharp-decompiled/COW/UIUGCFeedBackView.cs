using GCommon;
using UnityEngine;

namespace COW;

public class UIUGCFeedBackView : UIBaseView
{
	public UITable Table;

	public UIGrid FirstGrid;

	public UIGrid SecondGrid;

	public GameObject SencondQuestion;

	public UILabel InputLabel;

	public UIInput InputField;

	public UIButton BtnSubmit;

	public UIButton BtnCancel;

	public GameObject EnableBg;

	public GameObject DisableBg;

	public UILabel SecondTitle;

	public UILabel SelectedTxt1;

	public UILabel SelectedTxt3;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
