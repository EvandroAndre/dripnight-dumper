using System.Collections.Generic;
using UnityEngine;

namespace COW.GamePlay.UGCRuntime;

public interface IUGCMatchHumanPlayer : IBridgingEntity
{
	IUGCUser GetUGCOwner();

	uint GetProtoPlayerID();

	uint GetHostTeamIndex();

	string GetNickName();

	void ResetExtraSafeZoneDamage();

	Vector3 GetPosition();

	Vector3 GetForward();

	void SetForward(Vector3 forward);

	int GetCurHP();

	void SetCurHPInternal(int v);

	int GetMaxHP();

	void SetMaxHP(int v);

	int GetCurEP();

	void SetCurEP(int v);

	int GetMaxEP();

	void SetMaxEP(int v);

	int GetMaxSP(uint t);

	void SetMaxSP(int v, uint t);

	int GetCurSP(uint t);

	void SetCurSP(int v, uint t);

	bool IsAI();

	bool IsDead();

	bool IsKnockDown();

	int GetLastSpawnOrReviveTime();

	bool IsGod();

	void SetGod(bool isGod, float godTime, bool isNeedBoradCast);

	void SetLastCheckPointID(int value);

	int GetLastCheckPointID();

	void SetNextCheckPointID(int value);

	int GetNextCheckPointID();

	void SetCSFactionId(int v);

	int GetCSFactionId();

	float GetUGCWeaponDamageRate();

	void SetUGCWeaponDamageRate(float value);

	int AddHP(int v, int weaponDataId, int addHpType);

	uint[] GetSkillIDs();

	void SetPlayerSkills(uint[] skills);

	uint[] GetPlayerRealSkills();

	int GetItemCountWithSameDataID(uint itemID);

	int RemoveItemByUGC(uint itemID, uint count);

	bool DestroyEquipment(uint itemType, uint slot);

	bool DestroyEquipmentBySlot(uint slot, int count);

	int GetHumanModelID();

	void SetHumanModelID(uint id);

	void SetUGCRunSpeedScale(float scale);

	float GetUGCRunSpeedScale();

	void SetUGCCrouchSpeedScale(float scale);

	float GetUGCCrouchSpeedScale();

	void SetUGCDashSpeedScale(float scale);

	float GetUGCDashSpeedScale();

	void SetUGCKnockDownSpeedScale(float scale);

	float GetUGCKnockDownSpeedScale();

	void SetUGCCreepSpeedScale(float scale);

	float GetUGCCreepSpeedScale();

	void SetUGCJumpHeightScale(float scale);

	float GetUGCJumpHeightScale();

	void SetUGCInjuredRate(float v);

	float GetUGCInjuredRate();

	void SetUGCJumpStatusJumpHeightScale(float scale);

	void Teleport(Vector3 pos, Vector3 forward, bool keepDashing);

	void SetRevivePosition(Vector3 pos);

	Vector3 GetRevivePosition();

	void UGCRevive();

	void SetIdentity(int v);

	int GetIdentity();

	void SetZombieLevel(int v);

	int GetZombieLevel();

	void InfectionZombieTypeChange();

	void UGCShopBuyItem(Dictionary<int, int> itemDic);

	bool IsRemoveAllEquipmentOnDeath();

	void SetRemoveAllEquipmentOnDeath(bool v);

	void ChangeCustomizeCloth(uint style, uint mainColor1, uint mainColor2, uint otherColor);

	void RemoveCustomizeCloth();

	void StopDash();

	void RemoveAllInventory();

	void SendForceSyncServerStateToPlayerWithForceType(uint forceType);

	void SetPlayerBonesScale(int bonesType, Vector3 scale);

	string GetUserUID();

	bool IsHitFlying();

	void OnUGCHitFly(Vector3 dir, float flyTime, float velocityY, float velcityXZ, bool changeFwd);

	void GiveMetropolisReward(int count, bool isReal, uint from, uint zoneID);

	void UnlockMetropolisItem(uint itemType, uint dataID, bool unlock);

	void UpdateMetropolisMissionProgress(int missionID, int value);

	void QuitMetropolisMiniGame(uint quitType, uint gameID);

	int GetAvatarGender();

	uint GetClothIDByWardrobeType(uint wardrobeType);

	void SetClothIDByWardrobeType(int value, uint wardrobeType);

	void SetClothID(int value);

	uint GetSummaryClothIDByWardrobeType(uint wardrobeType);

	int GetUGCSyncSubLevelID();

	int GetPlayerWeaponSkinIDByWeaponID(int weaponID);

	void SetPlayerWeaponSkinIDByWeaponID(int weaponID, int weaponSkinID);

	void SetPlayerWeaponSkinID(int skinID);

	uint GetEquippedWeaponSkinID(uint weaponID);

	uint[] GetPlayerBagRepItemAllItemGoodsType();

	uint[] GetPlayerBagItemGoodsType();

	string[] GetPlayerEquipmentsBySlot(int slot);

	string ToggleSpecialItemState(int itemID, bool enable);
}
