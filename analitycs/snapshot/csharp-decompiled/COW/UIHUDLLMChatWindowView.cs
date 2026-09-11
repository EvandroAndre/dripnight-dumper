using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDLLMChatWindowView : UIBaseView
{
	public UILabel Title;

	public UIButton BtnClose;

	public GameObject MessageContainer;

	public UIInput InputContainer;

	public UIButton EnterBtn;

	public UIWidget ContainerWidget;

	public UIHUDLLMChatDragItem DragItem;

	public GameObject DisableMask;

	public GameObject EnableMask;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
