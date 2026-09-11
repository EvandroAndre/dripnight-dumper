using System.Text;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHypercrateDistanceInfoController : UIBaseController
{
	private UIHypercrateDistanceInfoView m_View;

	private LevelObjectHypercrate m_Hypercrate;

	private FollowCamera m_FollowCamera;

	protected Camera m_FollowCameraComponent;

	private StringBuilder m_Builder;

	private uint m_VFXHolder;

	private const float DeltaHeight = 3f;

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

	public void SetData(LevelObjectHypercrate hypercrate)
	{
	}

	public void UpdateDistance()
	{
	}

	public void Update()
	{
	}

	private void LateUpdate()
	{
	}

	private void UpdateNamePosition(Transform trans, Vector3 position)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
