using GCommon;
using UnityEngine;

namespace COW;

public class UIHudSceneEditTimelineInspectorView : UIBaseView
{
	public UIButton CloseBtn;

	public GameObject Container;

	public GameObject AttributeRoot;

	public UIScrollView ScollContentScrollView;

	public UIPanel ScollContentPanel;

	public UITable AttributesContainer;

	public UITable AttributeItemTable;

	public UIPanel UIHudSceneEditTimelineInspector;

	public UILabel NameLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
