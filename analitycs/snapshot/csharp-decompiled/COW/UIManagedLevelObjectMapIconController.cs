using COW.GamePlay;
using GCommon;
using message;

namespace COW;

public class UIManagedLevelObjectMapIconController : UIManagedMapContentIconController
{
	private VisualInstanceHolder m_ContentHolder;

	private UIManagedLevelObjectMapIconViewData m_ViewData;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override bool KeepRotationUp()
	{
		return false;
	}

	public override bool KeepVisuallyConstantWhenScale()
	{
		return false;
	}

	public override void SetViewData(object viewData)
	{
	}

	protected override void RestoreBeforeRecycled()
	{
	}

	public virtual bool IsMarkingSupported()
	{
		return false;
	}

	public virtual OPICPDCLKAG GetLevelObjectType()
	{
		return OPICPDCLKAG.Invalid;
	}

	public virtual EILKGGIDJEH GetMarkPointType()
	{
		return EILKGGIDJEH.EItemMarkPointType_Location;
	}

	private void LoadContentForMapIcon()
	{
	}

	public bool _003C_003EiFixBaseProxy_KeepRotationUp()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_KeepVisuallyConstantWhenScale()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_SetViewData(object P0)
	{
	}
}
