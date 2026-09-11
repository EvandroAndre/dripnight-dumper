using UnityEngine;

namespace COW;

public class UIBaseChooseLoadoutItemController : UIBaseLoadoutItemController
{
	public UIButton ItemBtn;

	public GameObject EquipedArrow;

	public GameObject SelectedHighLight;

	public GameObject AdjustRedDot;

	public GameObject LockMask;

	public GameObject LockIcon;

	public int ItemIndex;

	public bool IsSelected;

	public UIWidget LoadoutItemWidget => null;

	public UIButton LoadoutItemButton => null;

	public GameObject Content => null;

	protected override void OnUIInit()
	{
	}

	protected override void SetEmptyState()
	{
	}

	public void SetEquiped(bool value)
	{
	}

	public void SetSelected(bool value)
	{
	}

	public virtual void SetData(uint id, int index)
	{
	}

	private void OnBtnClicked()
	{
	}

	public bool LoadoutCanGuide(int loadoutId)
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_SetEmptyState()
	{
	}
}
