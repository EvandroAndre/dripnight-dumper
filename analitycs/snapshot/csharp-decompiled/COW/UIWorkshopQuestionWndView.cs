using GCommon;
using UnityEngine;

namespace COW;

public class UIWorkshopQuestionWndView : UIBaseView
{
	public GameObject ReportTypeFilter;

	public UIInputEnhance ReportDescInput;

	public UITable UploadContainer;

	public UIButton BtnConfirm;

	public GameObject BtnMask;

	public GameObject BtnNormal;

	public GameObject ModuleTypeFilter;

	public GameObject ModuleContainer;

	public UIScrollView ReportDescSV;

	public UILabel ReportDescLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
