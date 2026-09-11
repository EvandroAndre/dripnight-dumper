using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UINinthSYSPrivilegeRewardItemController : UIBaseController
{
	private UINinthSYSPrivilegeRewardItemView m_View;

	private GameObject m_LevelUIFX;

	private ResourceID m_LevelUIFXRes;

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

	public void SetRewardDesc(uint item_id, NinthSysAwardDesc.ELevel level, uint amount, uint expire_time)
	{
	}

	private string GetLevelSpriteName(NinthSysAwardDesc.ELevel level)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
