using GCommon;
using tcp;

namespace COW;

internal class UIAvatarExpItemController : UIWeaponExpItemController
{
	private UIModelAvatarProfile m_ModelAvatarProfile;

	private AvatarProfile m_AvatarProfile;

	private uint m_AvatarId;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void SetWeaponExpData(WeaponExpUpdateInfo info)
	{
	}

	public override void ShowUpdateProgress()
	{
	}

	protected override void UpdateIcon(int level)
	{
	}

	protected override void OnGoPosBtnCLick()
	{
	}

	private void Update()
	{
	}

	private void _003CShowUpdateProgress_003Eb__6_0()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_SetWeaponExpData(WeaponExpUpdateInfo P0)
	{
	}

	public void _003C_003EiFixBaseProxy_ShowUpdateProgress()
	{
	}

	public void _003C_003EiFixBaseProxy_UpdateIcon(int P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnGoPosBtnCLick()
	{
	}
}
