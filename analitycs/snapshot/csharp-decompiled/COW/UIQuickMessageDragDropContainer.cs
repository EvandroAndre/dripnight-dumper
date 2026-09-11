namespace COW;

public class UIQuickMessageDragDropContainer : UIDragDropContainer
{
	private bool IsListTop;

	private bool IsListBottom;

	private UIQuickMessageSettingController m_Parent;

	private IQuickMsgContainerData m_Container;

	private UIWidget UIWidget;

	private const int DragingDepth = 500;

	public void Init(UIQuickMessageSettingController parent, IQuickMsgContainerData msgContainerData)
	{
	}

	private void OnDragDropItemOver()
	{
	}

	public void OnMsgDragStart()
	{
	}

	public void OnMsgDragRelease()
	{
	}
}
