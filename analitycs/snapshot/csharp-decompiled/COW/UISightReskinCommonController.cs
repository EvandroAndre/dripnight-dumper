using GCommon;
using UnityEngine;

namespace COW;

public class UISightReskinCommonController : UIBaseController
{
	private UISightReskinCommonView m_View;

	private float m_HeightScale;

	private Vector3 m_DefaultRootScale;

	private GameObject m_OpeningVFXObject;

	private ResourceID m_LoadedOpeningVFXResId;

	private GameObject m_SightVFXObject;

	private ResourceID m_LoadedSightVFXResId;

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

	public void SetData(uint weaponSkinId, uint scopeAttachmentId, bool useSpecialSightReskin = true, bool useEvoGunPreviewScale = false)
	{
	}

	private void RefreshRootScale(uint scopeAttachmentId, bool useEvoGunPreviewScale)
	{
	}

	private void ReplayRootAnimation()
	{
	}

	private void RefreshVFXSlot(ResourceID newResId, ref GameObject slotObject, ref ResourceID slotResId)
	{
	}

	private void ClearVFXSlot(ref GameObject slotObject, ref ResourceID slotResId)
	{
	}

	private void ClearAllVFX()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
