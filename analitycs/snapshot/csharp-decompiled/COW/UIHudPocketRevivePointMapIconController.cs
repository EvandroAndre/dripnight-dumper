using COW.GamePlay;
using GCommon;
using message;

namespace COW;

public class UIHudPocketRevivePointMapIconController : UIManagedLevelObjectMapIconController
{
	private const string m_FriendlySpriteName = "Minimap_ResurrectionMachine_01";

	private const string m_HostileSpriteName = "Minimap_ResurrectionMachine_02";

	private VisualInstanceHolder m_BackgroundVfxHolder;

	private UIHudPocketRevivePointMapIconView m_View;

	private UIHudPocketRevivePointMapIconViewData m_ViewData;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override bool KeepRotationUp()
	{
		return false;
	}

	public override bool KeepVisuallyConstantWhenScale()
	{
		return false;
	}

	public override bool IsMarkingSupported()
	{
		return false;
	}

	public override OPICPDCLKAG GetLevelObjectType()
	{
		return OPICPDCLKAG.Invalid;
	}

	public override EILKGGIDJEH GetMarkPointType()
	{
		return EILKGGIDJEH.EItemMarkPointType_Location;
	}

	public override void SetViewData(object viewData)
	{
	}

	public override void OnTrackedPlayerChanged(BHGGAEEHJCO trackedPlayer)
	{
	}

	protected override void RestoreBeforeRecycled()
	{
	}

	private void SetupDefaultState()
	{
	}

	private void LoadVfxFromRelationWithTrackedPlayer()
	{
	}

	private void TryReleaseBackgroundVfxHolder()
	{
	}

	private void LoadWorkingBackgroundVfx(ResourceID backgroundVfx)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new bool _003C_003EiFixBaseProxy_KeepRotationUp()
	{
		return false;
	}

	public new bool _003C_003EiFixBaseProxy_KeepVisuallyConstantWhenScale()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_IsMarkingSupported()
	{
		return false;
	}

	public OPICPDCLKAG _003C_003EiFixBaseProxy_GetLevelObjectType()
	{
		return OPICPDCLKAG.Invalid;
	}

	public EILKGGIDJEH _003C_003EiFixBaseProxy_GetMarkPointType()
	{
		return EILKGGIDJEH.EItemMarkPointType_Location;
	}

	public new void _003C_003EiFixBaseProxy_SetViewData(object P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnTrackedPlayerChanged(BHGGAEEHJCO P0)
	{
	}

	public void _003C_003EiFixBaseProxy_RestoreBeforeRecycled()
	{
	}
}
