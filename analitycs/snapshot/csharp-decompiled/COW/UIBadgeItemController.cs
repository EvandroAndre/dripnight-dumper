using GCommon;

namespace COW;

public class UIBadgeItemController : UIBaseController
{
	private UIBadgeItemView m_View;

	public BadgeItemState State;

	private uint m_BadgeItemId;

	private UIModelClan m_ModelClan;

	private ClanIconType m_Type;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetBadgeType(ClanIconType type)
	{
	}

	public void SetClanBadgeItemId(uint id)
	{
	}

	public void SetBadgeLockState(uint unlockLv)
	{
	}

	public void SetSprite(string ResName)
	{
	}

	public void SetExpireTime(ulong expireTime)
	{
	}

	private void OnSelectBadge()
	{
	}

	public void SetBadgeSelectState(bool HasSelect)
	{
	}

	public void SetBadgeNormalState()
	{
	}

	public void SetBadgeUsingState(bool HasUsing)
	{
	}

	public void SetBadgeSpecialEffect()
	{
	}

	public void SetCustomBadge(string url)
	{
	}

	private void _003CSetExpireTime_003Eb__11_0()
	{
	}

	private bool _003CSetExpireTime_003Eb__11_1(ClanBadgeItemInfo item)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
