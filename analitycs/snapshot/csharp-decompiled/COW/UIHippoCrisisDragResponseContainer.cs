using UnityEngine;

namespace COW;

public class UIHippoCrisisDragResponseContainer : UIDragDropContainer
{
	private IUIHippoCrisisDragResponseController m_Ctrl;

	public EDragReleaseResponseAreaType AreaType;

	public void Init(IUIHippoCrisisDragResponseController ctrl)
	{
	}

	public HippoCrisisDragOperationResult HippoCrisisDragResponseCB(HippoCrisisDragSourceInfo hippoCrisisDragSourceInfo)
	{
		return default(HippoCrisisDragOperationResult);
	}

	protected void OnDragOver(GameObject dragged)
	{
	}

	protected void OnDragOut(GameObject dragged)
	{
	}
}
