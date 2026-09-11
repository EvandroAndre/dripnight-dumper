using COW.GamePlay;

namespace COW;

internal class CheckBoxPlayerOverlapTrigger : CheckBoxCrossHairTrigger
{
	private GMPGMPFNMFP m_CacheHitInfo;

	protected override void OnEnable()
	{
	}

	public override void UpdateOffYWithDeg(float deg)
	{
	}

	public override bool HasAgainstEntities()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnEnable()
	{
	}

	public new void _003C_003EiFixBaseProxy_UpdateOffYWithDeg(float P0)
	{
	}

	public new bool _003C_003EiFixBaseProxy_HasAgainstEntities()
	{
		return false;
	}
}
