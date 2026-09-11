using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIEnemyChargeHintObjectController : UIBaseController
{
	private UIEnemyChargeHintObjectView m_View;

	private BHGGAEEHJCO m_TargetPlayerID;

	private float m_distance;

	private bool m_IsFireAndNoBlood;

	private float m_StartTime;

	public BHGGAEEHJCO TargePlayerID => default(BHGGAEEHJCO);

	public float StartTime => 0f;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetInfo(BHGGAEEHJCO playerID, float distance, float startTime, bool isFireAndNoBlood)
	{
	}

	public void UpdateStatus(float distance)
	{
	}

	public void ResetIconRotation()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
