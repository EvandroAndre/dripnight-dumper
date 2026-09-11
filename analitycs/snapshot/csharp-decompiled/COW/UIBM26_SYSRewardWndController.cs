using GCommon;
using UnityEngine;

namespace COW;

public class UIBM26_SYSRewardWndController : CommonRewardWindowStyleBaseController
{
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override void AdjustBtnStyle(bool GuideOnLeft = false)
	{
	}

	protected override string GetGuideBtnSpriteName()
	{
		return null;
	}

	protected override string GetNormalBtnSpriteName()
	{
		return null;
	}

	protected Color GetGuideBtnLabelColor()
	{
		return default(Color);
	}

	protected Color GetNormalBtnLabelColor()
	{
		return default(Color);
	}

	public override Color GetFastEquipDisableColor()
	{
		return default(Color);
	}

	public void _003C_003EiFixBaseProxy_AdjustBtnStyle(bool P0)
	{
	}

	public string _003C_003EiFixBaseProxy_GetGuideBtnSpriteName()
	{
		return null;
	}

	public string _003C_003EiFixBaseProxy_GetNormalBtnSpriteName()
	{
		return null;
	}

	public Color _003C_003EiFixBaseProxy_GetFastEquipDisableColor()
	{
		return default(Color);
	}
}
