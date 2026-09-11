using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudGeneralConstructionMapItemController : UIBaseController
{
	private Color DefaultColor;

	private Color TeammateColor;

	private Color COLORUSED;

	private Color EmemyColor;

	private UIHudGeneralConstructionMapItemView m_View;

	private uint m_ObjectID;

	private OPICPDCLKAG m_ObjectType;

	private bool m_DuringFlash;

	private Vector3 m_WorldPos;

	private uint m_DelayID;

	public Vector3 WorldPos => default(Vector3);

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override bool RecyleDontDestroy()
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIClose()
	{
	}

	public void SetViewData(GEventLevelMapIconEvent gEvent)
	{
	}

	private void ShowPantherTruckIcon(BHGGAEEHJCO playerID)
	{
	}

	private void ShowIcon(string name)
	{
	}

	private void ShowMapScanMachineIcon(GEventLevelMapIconEvent gEvent)
	{
	}

	private void RefreshMapScanMachineIcon(BHGGAEEHJCO playerID)
	{
	}

	public void SwitchObserver(BHGGAEEHJCO playerID)
	{
	}

	public bool CheckPositionInArea(Vector3 position)
	{
		return false;
	}

	private bool NeedBigMapMark()
	{
		return false;
	}

	public bool NeedTrackSearch()
	{
		return false;
	}

	public uint GetObjectID()
	{
		return 0u;
	}

	public OPICPDCLKAG GetObjectType()
	{
		return OPICPDCLKAG.Invalid;
	}

	public void Flash()
	{
	}

	public void StopTween()
	{
	}

	public bool _003C_003EiFixBaseProxy_RecyleDontDestroy()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
