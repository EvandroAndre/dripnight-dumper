namespace COW;

public class UICommonSettingDragDropContainer : UIDragDropContainer
{
	private bool IsListTop;

	private bool IsListBottom;

	private UIWidget UIWidget;

	private const int DragingDepth = 500;

	private ICommonSettingDragParent m_Parent;

	private ICommonSettingDragItem m_Item;

	public const int None = -1;

	public const int ListTop = -2;

	public const int ListBottom = -3;

	public void Init(ICommonSettingDragParent parent, ICommonSettingDragItem item)
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
