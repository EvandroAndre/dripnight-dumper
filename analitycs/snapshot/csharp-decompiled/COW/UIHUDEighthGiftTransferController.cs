using System.Collections.Generic;
using GCommon;
using UnityEngine;
using message;

namespace COW;

internal class UIHUDEighthGiftTransferController : UIBaseController
{
	public const uint VISIBILITY_AfterLandWelcomeOrGetReward = 1073741824u;

	private UIHUDEighthGiftTransferView m_View;

	private List<UIEighthGiftTeamMono> m_ItemList;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	public void SetShowData(NJOGGDIEJNN msg)
	{
	}

	private int SortTeamTable(Transform item1, Transform item2)
	{
		return 0;
	}

	private void CloseSelf()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
