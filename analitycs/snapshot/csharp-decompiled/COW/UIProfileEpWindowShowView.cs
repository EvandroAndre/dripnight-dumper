using GCommon;
using UnityEngine;

namespace COW;

public class UIProfileEpWindowShowView : UIBaseView
{
	public UIScrollView ScrollViewRoot;

	public UIPanel ScrollViewPanel;

	public Transform ItemListGridTF;

	public UIGrid ItemListGrid;

	public GameObject NewCon;

	public UIScrollView NewScrollView;

	public GameObject BpCon;

	public GameObject EpCon;

	public UIGrid BpGrid;

	public UIGrid EpGrid;

	public GameObject OldCon;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
