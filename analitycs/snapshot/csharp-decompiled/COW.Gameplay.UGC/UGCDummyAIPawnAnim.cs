using COW.GamePlay;
using UnityEngine;
using message;

namespace COW.Gameplay.UGC;

internal class UGCDummyAIPawnAnim : NetworkAIPawnAnimBaseComponent
{
	private Animation mAnimation;

	public override Animation Animation => null;

	public override void Init(NetworkAIPawn owner, Animation animCopy = null, Animator animator = null)
	{
	}

	public override void UpdateAnimSpeed(float s)
	{
	}

	public override void PlayAttack()
	{
	}

	public override void PlayHitfly()
	{
	}

	public override void StopHitfly(bool isDead)
	{
	}

	public override void Dead(bool isHeadShot, bool isByVehicle)
	{
	}

	public override void SetSpeed(float speed)
	{
	}

	public override bool PlaySkillAnim(DCEDLLLOGBO skillType, FNLMGJPJIDN phaseType, float phaseDuration, float loopAnimSpeed, bool isRandomAnimInList)
	{
		return false;
	}

	public override void ChangeToKnockdownBev(bool isInit)
	{
	}

	public override void EnableKnockdownRefCollider(bool enable)
	{
	}

	public Animation _003C_003EiFixBaseProxy_get_Animation()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_UpdateAnimSpeed(float P0)
	{
	}

	public void _003C_003EiFixBaseProxy_PlayAttack()
	{
	}

	public void _003C_003EiFixBaseProxy_PlayHitfly()
	{
	}

	public void _003C_003EiFixBaseProxy_StopHitfly(bool P0)
	{
	}
}
