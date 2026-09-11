using System.Collections.Generic;
using UnityEngine;
using message;

namespace COW.GamePlay;

internal interface OKEAMEELLBB
{
	Vector3 MOEFFAIDCBP { get; }

	Quaternion LFCNHAJBHEE { get; }

	GameObject EPJPNAKMFMB { get; }

	bool DBELGKKHKJP { get; }

	Collider JDNPECFMMFP { get; set; }

	bool IDFBHMDOBLL { get; }

	bool HLFBNDNFMCL { get; }

	bool IsVisible();

	bool IsStreamerVisible();

	float GetAttackableRadius();

	Vector3 GetAttackableCenterWS();

	Vector3 GetHitDamagePos();

	bool NeedAssit();

	bool CanAssitByWeapon(Player KALJPOOLDAD, FDAEPHMIEPC KEDHIAANLGO);

	bool IsSameTeamWithPlayerID(BHGGAEEHJCO KIFNGKDMHGM);

	bool CanAssistByUGC(float PHGFEGOEOLD);

	string GetUGCEntityID();

	uint GetAttackableID();

	DPNIICGMOJG GetAttackableType();

	void TakeDamage(GLLLEDKLLDA PMMCGNJHOOA, LOAEBBHPMEK AOJANNHGCEA = null, List<float> LFLPGCMLPFM = null, uint AHPBOLHPNMH = 0u);

	void TakeHealing(DLOFHLEHHNP LDOJBPIKBIK, List<float> LFLPGCMLPFM = null);
}
