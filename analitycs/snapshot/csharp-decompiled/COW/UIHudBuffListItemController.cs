using COW.GamePlay;
using GCommon;
using message;

namespace COW;

internal class UIHudBuffListItemController : UIBaseController
{
	private UIHudBuffListItemView m_View;

	public BountyPickupStatus BountyStatus;

	private float m_TotalLife;

	private float m_CurrentLife;

	private MFHOLGEKNLI _003CBuffBevTypeID_003Ek__BackingField;

	public MFHOLGEKNLI BuffBevTypeID
	{
		get
		{
			return _003CBuffBevTypeID_003Ek__BackingField;
		}
		set
		{
			_003CBuffBevTypeID_003Ek__BackingField = value;
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetUIData(OAICFPKEJNE bevData)
	{
	}

	protected void Update()
	{
	}

	public void UpdateLifeTime(float life)
	{
	}

	private void UpdateCDProgress()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
