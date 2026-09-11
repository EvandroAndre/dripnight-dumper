using GCommon;
using proto;

namespace COW;

public class UICSBanPickPassiveSkillItemController : UIBaseController
{
	private sealed class _003C_003Ec__DisplayClass10_0
	{
		public uint loadoutID;

		internal bool _003CSetLoadoutInfo_003Eb__0(Item x)
		{
			return false;
		}
	}

	private UICSBanPickPassiveSkillItemView m_View;

	private UIModelAvatarProfile m_ModelAvatarProfile;

	private UIModelPet m_ModelPet;

	private UIModelLoadout m_ModelLoadout;

	private UIModelInventory m_ModelInventory;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void SetPassiveSkillInfo(uint skillID)
	{
	}

	public void SetPetInfo(uint petID)
	{
	}

	public void SetLoadoutInfo(uint loadoutID)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
