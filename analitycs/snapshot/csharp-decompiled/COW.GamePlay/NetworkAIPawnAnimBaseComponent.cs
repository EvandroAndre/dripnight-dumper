using System.Collections.Generic;
using UnityEngine;
using message;

namespace COW.GamePlay;

internal abstract class NetworkAIPawnAnimBaseComponent : MonoBehaviour
{
	protected NetworkAIPawn HBCNAPJDJHH;

	public bool SkipDeathAnim;

	protected float LFCJNKFBNOB;

	protected float JEBCKNIJAAK;

	public virtual Animation BOOEEADMDKD => null;

	public virtual Animator ILFEOCFCNAB => null;

	public abstract void Init(NetworkAIPawn LDCIMNAAGNO, Animation EHIPCDMGFKB = null, Animator LBFLOFBKDJG = null);

	public virtual void PlayAttack()
	{
	}

	public virtual void PlayHitfly()
	{
	}

	public virtual void StopHitfly(bool ODBECFEKBNJ)
	{
	}

	public abstract void Dead(bool IECLLKLGNME, bool EEGKGEIJCKN);

	public abstract void ChangeToKnockdownBev(bool DHFADMKLDJC);

	public abstract void EnableKnockdownRefCollider(bool HCLGHJNEFIC);

	public abstract void SetSpeed(float IMKNJGHAHPI);

	protected void GDNCCNDJFKE()
	{
	}

	public abstract bool PlaySkillAnim(DCEDLLLOGBO LENJFKDNPMO, FNLMGJPJIDN EAEECLBHHNK, float EFICABLDOBG, float HBJNAHBKLDB, bool FGMPOFHPGKG);

	public virtual bool UpdateSkillAnim(DCEDLLLOGBO LENJFKDNPMO, FNLMGJPJIDN EAEECLBHHNK, int AEGNEFBOJLB, float AFCGDIOJMGI)
	{
		return false;
	}

	public virtual void UpdateAnimSpeed(float GKKELMDDGBJ)
	{
	}

	public virtual void OnDismemberPartsChanged(Dictionary<int, bool> CDOIICIPKLB, bool DHFADMKLDJC)
	{
	}

	public virtual void PlayBeHitAnim(LLEDPGIGCMO CCNBNLAPJFM, bool IPNPKMJDIPC)
	{
	}
}
