using GCommon;
using UnityEngine;
using message;

namespace COW.GamePlay;

internal interface EBMMLGGDMCC
{
	GameObject GameObject();

	void RegisterPlayer(Player HOLCKBLEJFN, GameObject DAGCFDAIEDN);

	void UnregisterPlayer();

	Player GetPlayer();

	void UpdateSkill(float OKJIFBCMDAD, float HOGHEFNINAE);

	void OnActSkillFinished(DMPADEOHJNJ LENJFKDNPMO);

	void TryToCastActSkillByIndex(int NIBBKONKPHP, bool CMLBHCJPJDA);

	void PlaySkillPhaseAnim(string ALACCKPIIKE);

	void OnPlayerPlayAnim(AnimationID IJJHJMBOKEB);

	void SetColliderEnable(bool AOOAGBBHDFA, int NDJPACKNMOG);

	bool IsRunningSkill();

	bool CheckSkillCanCast(int NIBBKONKPHP);
}
