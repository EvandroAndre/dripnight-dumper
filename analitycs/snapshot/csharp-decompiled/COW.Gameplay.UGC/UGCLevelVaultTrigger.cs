using COW.GamePlay;
using COW.GamePlay.UGCRuntime;
using UnityEngine;

namespace COW.Gameplay.UGC;

public class UGCLevelVaultTrigger : LevelUGCCustomizeTrigger, DDAFIHCLBBB
{
	public ClimbingTrigger climbingTrigger;

	public Transform climbTarget;

	public Transform climbArrow;

	public float defualtScale;

	public float climbHeightOffset;

	public float Length
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float Height
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	private void Start()
	{
	}

	public void SetLayer(bool isEditMode)
	{
	}

	public override bool CreateDynamicallyForUGC(string entityID)
	{
		return false;
	}

	public void RefreshTarget()
	{
	}

	public void RefreshArrow()
	{
	}

	protected override string GetObjectTag()
	{
		return null;
	}

	public override void OnSyncUGCEntityProperty(long propertyIndex, UGCSimpleValue newValue)
	{
	}

	public new bool _003C_003EiFixBaseProxy_CreateDynamicallyForUGC(string P0)
	{
		return false;
	}

	public new string _003C_003EiFixBaseProxy_GetObjectTag()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnSyncUGCEntityProperty(long P0, UGCSimpleValue P1)
	{
	}
}
