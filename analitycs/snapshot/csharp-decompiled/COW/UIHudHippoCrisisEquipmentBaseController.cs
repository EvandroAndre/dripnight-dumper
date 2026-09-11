using UnityEngine;

namespace COW;

public class UIHudHippoCrisisEquipmentBaseController : UIHippoCrisisCanDragItem, IUIHippoCrisisDragResponseController
{
	public bool? IsEmpty;

	protected GameObject EmptyWarning;

	protected GameObject Empty;

	protected GameObject NotEmpty;

	protected UIButton EquipClickBtn;

	protected GameObject Selected;

	protected GameObject BreathVFX;

	protected override void OnUIInit()
	{
	}

	private void OnShowItemBriefBox(object[] data)
	{
	}

	protected override void RefreshIcon()
	{
	}

	public void RefreshEmptyWarning(bool show)
	{
	}

	public void RefreshBreathVFX(bool show)
	{
	}

	public void HideBreathVFX()
	{
	}

	public virtual void OnClickBtn()
	{
	}

	public void HideSelected(object[] data)
	{
	}

	public virtual void SetData(EHippoCrisisEquipmentSlot slot, IHippoCrisisBackPackItemUIData data, EDragReleaseResponseAreaType areaType)
	{
	}

	public override bool OnDragStart()
	{
		return false;
	}

	public HippoCrisisDragOperationResult HippoCrisisDragResponseCB(HippoCrisisDragSourceInfo sourceInfo, EDragReleaseResponseAreaType areaType)
	{
		return default(HippoCrisisDragOperationResult);
	}

	public UIHippoCrisisDragResponseContainer GetDragResponseContainer()
	{
		return null;
	}

	public override void OnDragRelease(GameObject surface)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshIcon()
	{
	}

	public bool _003C_003EiFixBaseProxy_OnDragStart()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnDragRelease(GameObject P0)
	{
	}
}
