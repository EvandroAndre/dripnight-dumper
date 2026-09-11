using UnityEngine;

namespace COW.GamePlay;

internal interface LEDGHNBKNPP
{
	bool NOHCHPHIJHP { get; }

	void Init(CarInWaterParam KDJNEHDAAFL, VehicleControllerInterface AICBEDFDNIG);

	void EnterWaterTrigger(Collider GLJGHEAPBOF);

	void UpdateInWater(float OKJIFBCMDAD, float HOGHEFNINAE);

	bool CheckEnteredWater(int PMNDMAKPFGE);

	bool HasExitedWater();

	void ExitWater(bool BCCNMIHFBGE);

	void PlayTransformingAnim(bool OBHJMCMFIOH, bool HNIOHDJLGEO);

	bool CheckExitedWater(int PMNDMAKPFGE);
}
