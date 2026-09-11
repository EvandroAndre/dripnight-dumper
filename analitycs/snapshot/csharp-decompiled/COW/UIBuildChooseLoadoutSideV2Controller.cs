using GCommon;
using UnityEngine;

namespace COW;

internal class UIBuildChooseLoadoutSideV2Controller : UIBaseChooseLoadoutV2Controller
{
	private UIBuildChooseLoadoutSideV2View m_View;

	private UICommonGuideController m_GuideController;

	private const float ARROW_EFFECT_CD = 8.5f;

	private uint m_DelayCall;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void InitView()
	{
	}

	protected override void RefreshLoadoutLevelList()
	{
	}

	protected override void RefreshSelectedMode()
	{
	}

	private void CheckLoadoutV2Guide()
	{
	}

	private void OnGuideFinish()
	{
	}

	public override UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	protected override void OnUIDestroy()
	{
	}

	private void PlayItemArrow()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshLoadoutLevelList()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshSelectedMode()
	{
	}

	public UIEasyListItemController _003C_003EiFixBaseProxy_OpenItemController(Transform P0)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
