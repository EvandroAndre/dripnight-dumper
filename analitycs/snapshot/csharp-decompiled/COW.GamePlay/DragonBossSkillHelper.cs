using System.Collections.Generic;
using UnityEngine;
using message;

namespace COW.GamePlay;

public class DragonBossSkillHelper : MonoBehaviour
{
	public DragonBossHeadEffect LeftHeadTypeEffect;

	public DragonBossHeadEffect RightHeadTypeEffect;

	public GameObject LeftHeadRoot;

	public GameObject RightHeadRoot;

	public GameObject CombineHeadRoot;

	public GameObject WeaknessRoot;

	public GameObject LifeRoot;

	public Transform LeftHeadSkillTrans;

	public Transform RightHeadSkillTrans;

	public Vector3 LeftHeadPos;

	public Vector3 RightHeadPos;

	public Vector3 CombineHeadPos;

	public Vector3 WeaknessPos;

	public Vector3 LeftClawPos;

	public Vector3 RightClawPos;

	public List<DragonSkillInfo> SkillInfoLst;

	public List<GameObject> LifeCountEffects;

	public void InitHead(bool ELFLMLKEAMP, int KOMNJCMOGCI, HNEMEABFKEE ABGNFPDNHDK = HNEMEABFKEE.DragonSkillType_None, HNEMEABFKEE NGNMLMPCPDC = HNEMEABFKEE.DragonSkillType_None)
	{
	}

	public void SetHeadType(int AHIBPDDFHCD, HNEMEABFKEE PFBFDKAKHEB)
	{
	}

	public void ShowLifeOrWeaknessView(bool CCJAMOKEEMP, bool IHDEFEEGDPG)
	{
	}

	public void UpdateLifeCntEffect(int DIEAJDBAFIL)
	{
	}

	public void OnSkillPhaseEnter(FNLMGJPJIDN PPPGENPKBIN, DCEDLLLOGBO LENJFKDNPMO)
	{
	}

	public void OnSkillPhaseExit(FNLMGJPJIDN PPPGENPKBIN, DCEDLLLOGBO LENJFKDNPMO)
	{
	}

	public DragonSkillInfo GetSkillInfo(DCEDLLLOGBO CCNBNLAPJFM, KHECGFMFCJO AHIBPDDFHCD)
	{
		return null;
	}
}
