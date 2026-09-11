namespace COW;

internal class CheckBoxOutRoomCrossHairTrigger : CheckBoxCrossHairTrigger
{
	protected float m_MaxAngle;

	public override bool HasAgainstEntities()
	{
		return false;
	}

	public override void UpdateOffYWithDeg(float deg)
	{
	}

	public new bool _003C_003EiFixBaseProxy_HasAgainstEntities()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_UpdateOffYWithDeg(float P0)
	{
	}
}
