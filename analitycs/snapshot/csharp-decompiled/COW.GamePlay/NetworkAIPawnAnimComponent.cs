using System.Collections.Generic;
using GCommon;
using UnityEngine;
using message;

namespace COW.GamePlay;

internal class NetworkAIPawnAnimComponent : NetworkAIPawnAnimBaseComponent
{
	public bool IsOptAnimFrameRate;

	public bool IsCrossFadeDeadAnim;

	public DIJJJMLPHBH DefaultAnimationClipType;

	public List<AnimationClipInfo> AnimationClipInfos;

	public List<SkillAnim> m_SkillAnimList;

	public List<AIDismemberConfig> m_DismemberConfig;

	public SkinnedMeshRenderer m_DismemberSMR;

	private Dictionary<int, Dictionary<int, List<AnimationClip>>> CBPGMFCLILD;

	private Animation DICJEECBLJO;

	protected const float HOHLDFAIFFA = 15f;

	public Collider KnockdownBevRefCollider;

	public override Animation BOOEEADMDKD => null;

	public override void Init(NetworkAIPawn LDCIMNAAGNO, Animation EHIPCDMGFKB = null, Animator LBFLOFBKDJG = null)
	{
	}

	private void GLJJOFDKOMD()
	{
	}

	private string BFCFEKCGFDL(DIJJJMLPHBH MILFLGEIPMD)
	{
		return null;
	}

	private ResourceID DMPDINHHIGI(DIJJJMLPHBH MILFLGEIPMD)
	{
		return default(ResourceID);
	}

	private AnimationClip OBIGMODDFNB(DIJJJMLPHBH MILFLGEIPMD)
	{
		return null;
	}

	private void OHPJOGKNMJI()
	{
	}

	public override void UpdateAnimSpeed(float GKKELMDDGBJ)
	{
	}

	public override void PlayAttack()
	{
	}

	public void CrossFadeByClipType(DIJJJMLPHBH MILFLGEIPMD)
	{
	}

	public void CrossFadeQueuedByClipType(DIJJJMLPHBH MILFLGEIPMD)
	{
	}

	public override void PlayHitfly()
	{
	}

	public override void StopHitfly(bool ODBECFEKBNJ)
	{
	}

	public override void Dead(bool IECLLKLGNME, bool EEGKGEIJCKN)
	{
	}

	public override void SetSpeed(float IMKNJGHAHPI)
	{
	}

	private string MHBMMIHGGHG(float IMKNJGHAHPI)
	{
		return null;
	}

	private void DHFMKDJJNMH()
	{
	}

	public override bool PlaySkillAnim(DCEDLLLOGBO LENJFKDNPMO, FNLMGJPJIDN EAEECLBHHNK, float EFICABLDOBG, float HBJNAHBKLDB, bool FGMPOFHPGKG)
	{
		return false;
	}

	private void MEFHGLDHLFN(List<AnimationClip> AHENOEOKMEA, float EFICABLDOBG, float HBJNAHBKLDB)
	{
	}

	private void BGEKIJACDIO(List<AnimationClip> AHENOEOKMEA, float EFICABLDOBG, float HBJNAHBKLDB)
	{
	}

	public override bool UpdateSkillAnim(DCEDLLLOGBO LENJFKDNPMO, FNLMGJPJIDN EAEECLBHHNK, int AEGNEFBOJLB, float AFCGDIOJMGI)
	{
		return false;
	}

	public override void OnDismemberPartsChanged(Dictionary<int, bool> CDOIICIPKLB, bool DHFADMKLDJC)
	{
	}

	private void IDHPJMKGMHD(ref Vector4 MAMHOPHGONK, int NPEMKNFIIHL, bool OGECPGHMIHA)
	{
	}

	public override void PlayBeHitAnim(LLEDPGIGCMO CCNBNLAPJFM, bool IPNPKMJDIPC)
	{
	}

	public override void ChangeToKnockdownBev(bool DHFADMKLDJC)
	{
	}

	public override void EnableKnockdownRefCollider(bool OGECPGHMIHA)
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

	public bool _003C_003EiFixBaseProxy_UpdateSkillAnim(DCEDLLLOGBO P0, FNLMGJPJIDN P1, int P2, float P3)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnDismemberPartsChanged(Dictionary<int, bool> P0, bool P1)
	{
	}

	public void _003C_003EiFixBaseProxy_PlayBeHitAnim(LLEDPGIGCMO P0, bool P1)
	{
	}
}
