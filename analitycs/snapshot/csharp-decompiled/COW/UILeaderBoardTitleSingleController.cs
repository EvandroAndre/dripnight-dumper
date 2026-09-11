using GCommon;
using UnityEngine;

namespace COW;

public class UILeaderBoardTitleSingleController : UIBaseController
{
	public enum ELeaderBoardTitlePivot
	{
		None,
		Left,
		Right
	}

	private UILeaderBoardTitleSingleView m_View;

	private UIModelLeaderBoardTitle m_Model;

	private UILeaderBoardTitleIconController m_IconCtrl;

	private const int MINWIDTH_TO_SCROLL = 158;

	private const int MAXWIDTH_TO_SHRINK = 478;

	private Vector3 m_IconScale;

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

	private void SetBG(ResourceID bgRes, ELeaderBoardTitlePivot pivot)
	{
	}

	private void SetBGAnchor(ELeaderBoardTitlePivot pivot)
	{
	}

	private void OpenIconController(uint rank, ResourceID iconRes, ResourceID iconVFXRes, Transform trans, Color iconLabelColor, Color iconShadowColor, bool isPeakTitle = false)
	{
	}

	public void SetData(LeaderBoardTitleShowingParams showParams, ELeaderBoardTitlePivot pivot, bool needAutoFit = false, ELeaderBoardTitleIconScale scaleType = ELeaderBoardTitleIconScale.None)
	{
	}

	public float GetSizeY(bool isIcon = true)
	{
		return 0f;
	}

	public void SetVFXVisibility(bool isVisible)
	{
	}

	public ResourceID _003C_003EiFixBaseProxy_GetResID()
	{
		return default(ResourceID);
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
