using GCommon;
using message;

namespace COW.HUD;

internal class UISPHudMatchResultController : UIBaseController
{
	private const int SOLO_TOP_COUNT = 4;

	private const int DUO_TOP_COUNT = 4;

	private const int QUAD_TOP_COUNT = 3;

	private UISPHudMatchResultView m_View;

	private CMDBIPLGLGA m_CurrentGroupMode;

	private int m_TopCount;

	private float m_OriginalScrollViewHeight;

	private float m_OriginalScrollViewYPosition;

	private float m_RealScrollViewHeight;

	private bool m_IsScrollViewMoving;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnScrollViewDragStarted()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnScrollViewTWPositionFinish()
	{
	}

	private void OnScrollViewTWAlphaFinish()
	{
	}

	private void OnScrollViewQuadTWPositionFinish()
	{
	}

	private void OnScrollViewQuadTWAlphaFinish()
	{
	}

	public void Update()
	{
	}

	private void OnBackToLobbyButtonClick()
	{
	}

	private void BackBtnTriggered(object[] data)
	{
	}

	private void OnBackBtnClick()
	{
	}

	private void RefreshUI()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
