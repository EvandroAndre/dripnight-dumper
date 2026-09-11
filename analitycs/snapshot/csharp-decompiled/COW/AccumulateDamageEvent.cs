using GCommon;

namespace COW;

internal class AccumulateDamageEvent : GEvent
{
	public bool NeedShow;

	public int PelletCount;

	public int HeadShotCount;

	public float HitTime;

	public float FireInterval;

	public GEvent Reset(bool needShow, int pelletCount, int headShotCount, float hitTime, float fireInterval)
	{
		return null;
	}

	public void Copy(AccumulateDamageEvent damageEvent)
	{
	}
}
