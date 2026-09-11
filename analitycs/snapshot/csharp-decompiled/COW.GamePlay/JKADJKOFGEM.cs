using System.Collections.Generic;
using message;

namespace COW.GamePlay;

internal interface JKADJKOFGEM
{
	void PushPlayerSyncedStateData(object CHDPPLFBCJA, uint OJFBGFOOKEK);

	void PushPlayerSyncedOptimizedStateData(object CHDPPLFBCJA, uint OJFBGFOOKEK);

	void PushPlayerSyncedPosition(object HADLEHOEAOH, uint OJFBGFOOKEK);

	void SyncStartFire(byte CBCAJJJCKLH);

	void SyncStopFire();

	void SyncStartReload(float NKNNPEMLIGD);

	void SyncStartSegmentReload(float NKNNPEMLIGD, float OPGOLPJOEGO);

	void SyncStopReload(EIMGDHFECAL APHHNHEDHKD);

	void SyncStartWeaponExpansionAbility();

	void SyncExecuteWeaponExpansionAbility(HOKIGPKKDJO KAEPDGADBPN);

	void SyncExecuteWeaponExpansionAbilityState(CEIFDKNFJJH KAEPDGADBPN);

	void SyncEndWeaponExpansionAbility();

	void SyncPickupInventory(BDEEPLNDDPD APHHNHEDHKD);

	void SyncDropInventory(uint DBPPPOBFJNP, uint NHPFOMNHMGM, byte OINKNIGKDMO, uint LADDHFKOBJG);

	void SyncDropInventoryForDeath(CAOFOMKBHBD APHHNHEDHKD);

	void SyncUpdateScoreboardInventory(DCHICBJFCKB APHHNHEDHKD);

	void SyncUpdateTeamScoreboardInventory(List<KGCINJIENNL> IPCPKIPFHKF);

	void SyncRemoveInventoryList(NBHDGJCAOFK APHHNHEDHKD);

	void SyncEquipmentChanged(HFMMCIINEED APHHNHEDHKD);

	void SyncEquipmentChangedForDeath(JIJCIPNLFMJ APHHNHEDHKD);

	void SyncAttachmentChanged(OCLFCDOMGLA APHHNHEDHKD);

	void SyncUnEquipAttachment(NILPAOHDCPC APHHNHEDHKD);

	void SyncSafeBoxInventoryChanged(LPEIDOGINNA APHHNHEDHKD);

	void SyncAttachmentChangedForDeath(CPNGLJFOPKC APHHNHEDHKD);

	void SyncPlayersVisibility(ulong EIOKHLKJEEL);

	void SyncStateWithServer(PGABPEBFLOK APHHNHEDHKD);

	void SyncDoAction(BDKHPEHCEFN APHHNHEDHKD);

	void SyncTryUseInventory(bool MHGKOFHHDHE, uint HIDANNMJCDP);

	void SyncLoadoutRuntimeValue(KFEOHKFMACA APHHNHEDHKD);

	void SyncStartWholeBodyFire(byte CBCAJJJCKLH, uint JFAOBKKPAHD);

	void SyncPlayEmotionAnimation(KKHHIILGECK APHHNHEDHKD);

	void SyncKnockDown(FKEKGMFJALP APHHNHEDHKD);

	void SyncRevive(Player.CFIGAMOOFLH LJLOKNOKHOH);

	void OnRequestResureTargetRes(DFGBGPMMPJA AOFCDPKJKJO);

	void OnRequestStopResureTargetRes(JHNDCJKBCGA AOFCDPKJKJO);

	void OnRequestExecuteTargetRes(MNJALCHBDLJ AOFCDPKJKJO);

	void OnRequestStopExecuteTargetRes(MFCEALDIPEK AOFCDPKJKJO);

	void RequestFoceSyncPosition();

	void SyncStartGrenade();

	void SyncStopGrenade();

	void SyncTriggerGrenade();

	void SyncInventoryInfo(LKIPCGKEMOH AOFCDPKJKJO);

	void SyncAttachmentInfo(List<FLJKANILEDD> LNDBIIGBHEK);

	void SyncTeleportInfo(PGABPEBFLOK APHHNHEDHKD);
}
