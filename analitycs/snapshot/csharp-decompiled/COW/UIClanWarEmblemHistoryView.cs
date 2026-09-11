using GCommon;
using UnityEngine;

namespace COW;

public class UIClanWarEmblemHistoryView : UIBaseView
{
	public UIButton ShareBtn;

	public GameObject SelfContent;

	public GameObject OtherContent;

	public UIEasyList SelfEasyList;

	public GameObject SelfEmptyNode;

	public Transform SelfRegionGloryPos;

	public Transform SelfGlobalGloryPos;

	public UIEasyList OtherEasyList;

	public GameObject OtherEmptyNode;

	public Transform OtherRegionGloryPos;

	public Transform OtherGlobalGloryPos;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
