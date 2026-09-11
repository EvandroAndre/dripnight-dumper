using System;
using UnityEngine;

namespace COW.GamePlay;

internal interface KIFFPOOEIOF : MOOLACGHPHJ
{
	bool NJHEMAJLAMM { get; }

	bool DAOAFMGLPLH { get; }

	Action CPINEHCNEMJ { set; }

	Action CBCCGIKPIHN { set; }

	void Init(JJLCALJHHDF JCONDDPFBKK, Transform HCFDIIDBPAJ, bool DCAPIHJMMBL);

	void OnGetOn(Player KDJNEHDAAFL);

	void OnGetOff(Player KDJNEHDAAFL);

	void SetVisible(bool OGECPGHMIHA);

	void Jump();

	void StopJump();

	void Dash();

	void StopDash();

	void ApplyAxisControl(Vector3 AJMKJNOFBKK);

	void OnForceSync(Vector3 NJEIPFFBIPK);

	bool DriverHasInput();
}
