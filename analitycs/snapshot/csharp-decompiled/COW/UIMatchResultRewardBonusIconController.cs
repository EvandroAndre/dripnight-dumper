using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIMatchResultRewardBonusIconController : UICommonBonusIconController
{
	public const string BonusIconColorStr = "#ffba00";

	private readonly List<ResourceID> m_SpriteIDs;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnShowTipsBtnClick()
	{
	}

	protected override void RefreshVisibilityInternal()
	{
	}

	private void PrepareSpriteList()
	{
	}

	private void SetMatchResultTipsData()
	{
	}

	private void SetGameBuffTipsData()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
