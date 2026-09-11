using System.Collections.Generic;
using GCommon;
using UnityEngine;
using message;

namespace COW.GamePlay;

internal class NetworkAIPawnAnimComponent_BossDragon : NetworkAIPawnAnimComponent
{
	public Animation BodyAnimation;

	public Animation LeftHeadAnimation;

	public Animation RightHeadAnimation;

	public Animation CombineHeadAnimation;

	public DynamicBone LeftHeadDynamicBone;

	public DynamicBone RightHeadDynamicBone;

	public List<AnimationClipInfo> BodyAnimationClipInfos;

	public List<AnimationClipInfo> LeftHeadAnimationClipInfos;

	public List<AnimationClipInfo> RightHeadAnimationClipInfos;

	public List<AnimationClipInfo> CombineHeadAnimationClipInfos;

	private Dictionary<int, List<AnimationClipInfo>> MICCHFFJPOJ;

	private Dictionary<int, Dictionary<int, Dictionary<int, List<AnimationClip>>>> MPCEHKOLGAO;

	private NetworkAIDragonBoss OGEOPEMEJOB;

	public List<SkillAnim> m_BodySkillAnimList;

	public List<SkillAnim> m_LeftHeadSkillAnimList;

	public List<SkillAnim> m_RightHeadSkillAnimList;

	public List<SkillAnim> m_CombineHeadSkillAnimList;

	public List<SkillAnim> m_BodyLeftClawAnimList;

	public List<SkillAnim> m_BodyRightClawAnimList;

	public List<SkillAnim> m_CombineHead_LeftClawAnimList;

	public List<SkillAnim> m_CombineHead_RightClawAnimList;

	private uint FOMKOILIJPI;

	private uint HBBMMDMMAJF;

	private KHECGFMFCJO MJLFBHKFBJF;

	public override void Init(NetworkAIPawn LDCIMNAAGNO, Animation EHIPCDMGFKB = null, Animator LBFLOFBKDJG = null)
	{
	}

	private void DAFIIBGLIDF()
	{
	}

	private void GFFJFBFNIGH(Animation FKNFFGLOAIN, List<AnimationClipInfo> LECACNMJAJD)
	{
	}

	private void OHPJOGKNMJI(Animation DICJEECBLJO)
	{
	}

	private void GLJJOFDKOMD()
	{
	}

	private AnimationClip OBIGMODDFNB(BHJAAECMJHM MDJKOCLLCHC, DIJJJMLPHBH MILFLGEIPMD)
	{
		return null;
	}

	private string BFCFEKCGFDL(BHJAAECMJHM MDJKOCLLCHC, DIJJJMLPHBH MILFLGEIPMD)
	{
		return null;
	}

	private ResourceID DMPDINHHIGI(BHJAAECMJHM MDJKOCLLCHC, DIJJJMLPHBH MILFLGEIPMD)
	{
		return default(ResourceID);
	}

	public override void Dead(bool IECLLKLGNME, bool EEGKGEIJCKN)
	{
	}

	private void BOLLGJKJNGP(BHJAAECMJHM MDJKOCLLCHC, Animation EHKHGICCIEG)
	{
	}

	public override void SetSpeed(float IMKNJGHAHPI)
	{
	}

	private void OCPHANODDGJ(BHJAAECMJHM MAMHOPHGONK, Animation EHKHGICCIEG)
	{
	}

	public void PlayRebornAnim(uint CFKCFJKNOPF, IBLIKLJDLBM BAAPOODIJED, uint PFBFDKAKHEB)
	{
	}

	private void BMIECKPCOML()
	{
	}

	private void CEJHGNCNHEN(BHJAAECMJHM MAMHOPHGONK, List<SkillAnim> ALNEEHPDADK, Animation FKNFFGLOAIN)
	{
	}

	public override bool PlaySkillAnim(DCEDLLLOGBO LENJFKDNPMO, FNLMGJPJIDN EAEECLBHHNK, float EFICABLDOBG, float HBJNAHBKLDB, bool FGMPOFHPGKG)
	{
		return false;
	}

	private bool PKHKPLBELII(DCEDLLLOGBO LENJFKDNPMO)
	{
		return false;
	}

	private bool EHOGMDBBOEA(BHJAAECMJHM MAMHOPHGONK, Animation FKNFFGLOAIN, DCEDLLLOGBO LENJFKDNPMO, FNLMGJPJIDN EAEECLBHHNK, float EFICABLDOBG, float HBJNAHBKLDB, bool FGMPOFHPGKG)
	{
		return false;
	}

	private void MEFHGLDHLFN(Animation FKNFFGLOAIN, List<AnimationClip> AHENOEOKMEA, float EFICABLDOBG, float HBJNAHBKLDB)
	{
	}

	private void BGEKIJACDIO(Animation FKNFFGLOAIN, List<AnimationClip> AHENOEOKMEA, float EFICABLDOBG, float HBJNAHBKLDB)
	{
	}

	public override bool UpdateSkillAnim(DCEDLLLOGBO LENJFKDNPMO, FNLMGJPJIDN EAEECLBHHNK, int AEGNEFBOJLB, float AFCGDIOJMGI)
	{
		return false;
	}

	private void CFNDHEHCPFH(BHJAAECMJHM MAMHOPHGONK, Animation FKNFFGLOAIN, DCEDLLLOGBO LENJFKDNPMO, FNLMGJPJIDN EAEECLBHHNK, int AEGNEFBOJLB, float AFCGDIOJMGI)
	{
	}

	public KHECGFMFCJO GetCurCastingHead()
	{
		return KHECGFMFCJO.DragonHead_None;
	}

	public void OnHeadRebornStart(int KFDNCIOCFAA)
	{
	}

	public void OnHeadRebornEnd(int KFDNCIOCFAA)
	{
	}

	public void _003C_003EiFixBaseProxy_Init(NetworkAIPawn P0, Animation P1, Animator P2)
	{
	}

	public void _003C_003EiFixBaseProxy_Dead(bool P0, bool P1)
	{
	}

	public void _003C_003EiFixBaseProxy_SetSpeed(float P0)
	{
	}

	public bool _003C_003EiFixBaseProxy_PlaySkillAnim(DCEDLLLOGBO P0, FNLMGJPJIDN P1, float P2, float P3, bool P4)
	{
		return false;
	}

	public new bool _003C_003EiFixBaseProxy_UpdateSkillAnim(DCEDLLLOGBO P0, FNLMGJPJIDN P1, int P2, float P3)
	{
		return false;
	}
}
