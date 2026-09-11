using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UILeaderBoardTitleIconController : UIBaseController
{
	private UILeaderBoardTitleIconView m_View;

	private GameObject m_VFX;

	private Dictionary<ResourceID, GameObject> m_VFXDict;

	private ELeaderBoardTitleIconType m_IconType;

	private bool m_IsVisible;

	private uint m_DelayCallID;

	private GameObject m_LeaderBoardTitleIconVFX;

	public bool IsIconVisible => false;

	protected override ResourceID GetResID()
	{
		return default(ResourceID);
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void SetRankLabels(uint rank)
	{
	}

	private void SetVFX(ResourceID iconVfxRes)
	{
	}

	public void SetData(uint rank, uint iconType, Vector3 scale, bool isPeakTitle = false)
	{
	}

	public void SetData(uint rank, ResourceID iconRes, ResourceID iconVFXRes, Vector3 scale, Color iconLabelColor, Color iconShadowColor, bool isPeakTitle = false)
	{
	}

	public Vector2 GetIconSize()
	{
		return default(Vector2);
	}

	public void SetIconVisibility(bool isVisible)
	{
	}

	public void SetVFXVisibility(bool isVisible)
	{
	}

	public void SetIconDelayShow(float time)
	{
	}

	public void PlayIconEnterEffect()
	{
	}

	public void SetScaleByTeamUpRecommendReason()
	{
	}

	public void SetView(UILeaderBoardTitleIconView view)
	{
	}

	private void _003CSetIconDelayShow_003Eb__20_0()
	{
	}

	public ResourceID _003C_003EiFixBaseProxy_GetResID()
	{
		return default(ResourceID);
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
