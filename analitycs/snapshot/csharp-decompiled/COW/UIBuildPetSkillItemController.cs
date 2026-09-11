using GCommon;

namespace COW;

public class UIBuildPetSkillItemController : UIBaseController
{
	private UIBuildPetSkillItemView m_View;

	private UIModelPet m_ModelPet;

	private UIModelLoadout m_ModelLoadout;

	private UIModelUser m_ModelUser;

	private UILockController m_LockCtrl;

	private uint m_PetSkillId;

	private bool m_NotNeedNotCarryPetIcon;

	private bool m_NotNeedMirrorIcon;

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	private void OnClickItem()
	{
	}

	private void OnClickMask()
	{
	}

	public void RefreshData()
	{
	}

	public void SetSelectHighLight(bool state)
	{
	}

	public void SetData(uint petSkillId = uint.MaxValue)
	{
	}

	public void SetDisableTouch()
	{
	}

	private void SetPetNotEmpty(bool state)
	{
	}

	public void SetNotNeedShowNotCarryPet()
	{
	}

	public void SetNotNeedMirrorIcon()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
