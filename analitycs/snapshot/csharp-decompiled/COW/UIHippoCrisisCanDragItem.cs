using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIHippoCrisisCanDragItem : UIBaseController
{
	protected UIModelHippoCrisis m_modelHippoCrisis;

	protected UISprite DragIcon;

	public UIHudHippoCrisisDragDropItem m_DragItemUtil;

	protected IHippoCrisisBackPackItemUIData m_Data;

	protected EHippoCrisisEquipmentSlot m_Slot;

	public EHippoInventory.EquipType m_EquipType;

	protected UIHippoCrisisDragResponseContainer DragResponseContainer;

	protected UIButton ClickBtn;

	public bool IsAttachment;

	public BoxCollider ResponseContainerBox;

	protected UISprite ItemIcon;

	protected UIColor QualityBg;

	protected UISprite LightBg;

	protected UISprite QualityBG_NEW;

	protected override void OnUIInit()
	{
	}

	protected virtual void RefreshIcon()
	{
	}

	public virtual bool OnDragStart()
	{
		return false;
	}

	public virtual void OnDragRelease(GameObject surface)
	{
	}

	private HippoCrisisDragSourceInfo CreateHippoCrisisDragSourceInfo()
	{
		return default(HippoCrisisDragSourceInfo);
	}

	public virtual void OnDragDropMove(Vector2 delta)
	{
	}

	public virtual void OnItemClick()
	{
	}

	public void SetDragAreaType(EDragReleaseResponseAreaType areaType)
	{
	}

	public EDragReleaseResponseAreaType GetDragAreaType()
	{
		return EDragReleaseResponseAreaType.None;
	}

	public IHippoCrisisBackPackItemUIData GetDragData()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
