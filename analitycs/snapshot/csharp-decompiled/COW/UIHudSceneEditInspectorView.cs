using GCommon;
using UnityEngine;

namespace COW;

public class UIHudSceneEditInspectorView : UIBaseView
{
	public UIButton CloseBtn;

	public UIInput NameLabel;

	public UIButton EditNameButton;

	public UIToggleButtonGroup SetUpTabToggleGroup;

	public GameObject BaseAttributeRoot;

	public UITable AttributeItemTable;

	public GameObject GraphContainer;

	public UIButton OpenGraphButton;

	public GameObject AdvancedAttributeRoot;

	public UITable AdvacnedAttributeItemTable;

	public UIButton AddComponentButton;

	public BoxCollider MaskCollider;

	public UIScrollView ScrollBaseContentPanel;

	public UIScrollView ScrollAdvancedContentPanel;

	public GameObject AddingComponents;

	public UIGrid AddableCompItemGrid;

	public UIButton AddCompMaskCollider;

	public GameObject LowestValueTipsData;

	public UIDragScrollView AdvancedAttributeDragSroll;

	public UIButton AddableComponentsDetails;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
