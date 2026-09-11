using COW.GamePlay;
using GCommon;
using UnityEngine;
using message;

namespace COW.HUD;

public class UIHudEnermyPointController : UIHudNameBaseController
{
	protected UIHudEnermyPointView m_View;

	private BHGGAEEHJCO m_BindPlayer;

	private int m_EndServerTime;

	private MarkEnemyType m_EnemyType;

	private BEAFJIDDDMB m_CommonMarkerType;

	private bool m_bIsShowScannerMark;

	public bool IsUsing;

	private uint m_HideDelayCall;

	private CommonParticleEffect m_MarkEffect;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void BindEnermy(BHGGAEEHJCO pID, int endServerTime, MarkEnemyType markType, bool isScannerMark = false, BEAFJIDDDMB commonMarkerType = BEAFJIDDDMB.EMarkerType_None)
	{
	}

	public void RefreshMark(BHGGAEEHJCO pID, int endServerTime, MarkEnemyType markType, bool isScannerMark = false, BEAFJIDDDMB commonMarkerType = BEAFJIDDDMB.EMarkerType_None)
	{
	}

	public void UnBindEnermy()
	{
	}

	protected override bool NeedAutoScaleByDistance()
	{
		return false;
	}

	protected override bool NeedUpdatePosition()
	{
		return false;
	}

	protected override Vector3 TargetPosition()
	{
		return default(Vector3);
	}

	private Vector3 GetRefPos(Player p)
	{
		return default(Vector3);
	}

	protected override bool IsVisibleWithZoneType(int zonetype)
	{
		return false;
	}

	private void PlayAnim()
	{
	}

	private void StopAnim()
	{
	}

	private void _003CRefreshMark_003Eb__12_0()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public bool _003C_003EiFixBaseProxy_NeedAutoScaleByDistance()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_NeedUpdatePosition()
	{
		return false;
	}

	public Vector3 _003C_003EiFixBaseProxy_TargetPosition()
	{
		return default(Vector3);
	}

	public bool _003C_003EiFixBaseProxy_IsVisibleWithZoneType(int P0)
	{
		return false;
	}
}
