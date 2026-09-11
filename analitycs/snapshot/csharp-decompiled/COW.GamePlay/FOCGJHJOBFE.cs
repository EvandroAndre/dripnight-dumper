using System.Collections.Generic;
using UnityEngine;

namespace COW.GamePlay;

internal interface FOCGJHJOBFE
{
	BHGGAEEHJCO BHGGAEEHJCO { get; }

	OKEAMEELLBB GBOBMPPGCAO { get; }

	Player OEMPIHKIEPI { get; }

	List<Vector3> GetBoundingBoxList();

	GameObject GetGameObject();

	bool IsInVehicle();

	Vehicle VehicleIAmIn();

	bool IsPassengerInVehicleCanFire();

	bool IsVehicleSupportDriverWeaponFire();

	bool IsOnStrop();

	bool IsOnChair();

	bool IsInCatapult();

	bool IsOnGrapplingHook();

	bool IsOnHook();

	bool IsOnVMEHook();

	bool HasGrapplingHook();

	bool HasHook();

	bool HasVMEHook();

	LevelStrop GetStropIAmOn();

	NAELPAAELNO GetItemOnHand();

	NAELPAAELNO GetRealItemOnHand();

	bool HasHeuristicTarget();

	OKEAMEELLBB GetHeuristicTarget();

	bool IsTargetFriend(OKEAMEELLBB PFJFADHEJLJ);

	bool HeuristicTargetIsFriend();

	bool GetSightingState();

	bool IsSightingUIAvailable();

	void OnSightingUIStateChange(bool BNEEMDFEMDB, float HFPLKBHDHJJ);

	bool IsLockFire();

	bool IsShowLockFireUI();

	float GetLockFireFinishProgress();

	bool IsReallyInStealth();
}
