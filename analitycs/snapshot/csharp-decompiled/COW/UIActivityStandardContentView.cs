using GCommon;
using UnityEngine;

namespace COW;

public class UIActivityStandardContentView : UIBaseView
{
	public GameObject ScrollView_NoTabs;

	public GameObject ScrollView;

	public UITable ContentTable;

	public ActivityAwardDescription AwardDescTemplate;

	public GameObject Gained;

	public UILabel GainedLabel;

	public GameObject Title;

	public UIDragScrollView DragArea;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
