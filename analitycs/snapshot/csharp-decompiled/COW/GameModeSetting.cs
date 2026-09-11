using System;

namespace COW;

internal class GameModeSetting : ICloneable
{
	public readonly int PlayerMaxHP;

	public readonly int VehicleMaxHP;

	public readonly bool RandomAirLineEndJump;

	public readonly bool EnableInventory;

	public readonly bool EnableVehicleChangeSeat;

	public readonly bool EnableVehicleBoost;

	public readonly bool EnableVehicleJump;

	public readonly bool LimitCsPickItem;

	public readonly bool EnableVehicleRepairKit;

	public readonly bool EnableVehicleFire;

	public readonly bool EnableVehicleFireLeave;

	public readonly bool EnableVehicleAimAssist;

	public readonly bool EnableVehiclePassengerFire;

	public readonly bool EnableVehicleDriverWeaponFire;

	public readonly float VehicleDriverCameraLerp;

	public readonly bool EnableInGameQuit;

	public readonly bool HuntingGroundAttackAI;

	public readonly bool EnableReplaceEPWithVehicleHp;

	public readonly bool EnableSkySurfing;

	public readonly bool DriverFreeCamera;

	public readonly bool EnableStrop;

	public readonly bool EnableRailStrop;

	public readonly bool EnableCatapult;

	public readonly bool EnableCannon;

	public readonly bool EnableOilDrum;

	public readonly float SkyDivingForceToOpenParachuteHeight;

	public readonly bool SkyDivingInVehilceCanFire;

	public readonly bool ShowAutoSlidingBtn;

	public readonly bool EnableVehicleInvincible;

	public readonly bool UnlimitedAmmo;

	public readonly bool UnlimitBagCapacity;

	public readonly bool BanAimAssist;

	public readonly bool EnableGunFeelSystem;

	public readonly bool CheckGunFeelEnable;

	public readonly bool CheckGunFeelSpread;

	public readonly bool CheckGunFeelSoftAssist;

	public readonly bool EnableGunTraceSmokeConfig;

	public readonly bool AutoFireAvailable;

	public readonly bool NoLoadOut;

	public readonly bool EnableBigHead;

	public readonly bool EnableFireColliderScale;

	public readonly float FireColliderRadiusScale;

	public readonly float FireColliderHeightScale;

	public readonly int ScoreToWin;

	public readonly int ScoreToWinEndTime;

	public readonly float MatchStartPrepareTime;

	public readonly int DoubleScoreStartTime;

	public readonly int ResultShowEmoteId;

	public readonly int ResultShowEmoteId_SnowManWin;

	public readonly int ResultShowEmoteId_SnowManLose;

	public readonly bool NeedResultShowData;

	public readonly bool BanAvatarSkill;

	public readonly bool BanPetSkill;

	public readonly bool EnableShowBag;

	public readonly float MatchExpireTime;

	public readonly bool EnableInventoryPreload;

	public readonly bool CreateVehicleHudOnSceneLoaded;

	public readonly bool CreateObserverHudOnSceneLoaded;

	public readonly bool GrenadePickupSwitch;

	public readonly bool EnableAssistantTips;

	public readonly bool EnableAssistantTriggerTips;

	public readonly bool EnableAssistantMarkItemTips;

	public readonly int MaxPumpkinOnHead;

	public readonly int GameIntroDelayTime;

	public readonly int GameIntroTime;

	public readonly bool SafeZoneIgnoreFirstOne;

	public readonly float MinimapScale;

	public readonly bool MinimapEnableDynamicScaling;

	public readonly bool MinimapEnableFirstScale;

	public readonly bool MinimapEnableSafezoneScale;

	public readonly bool MinimapNeverScale;

	public readonly bool MinimapEnableVehicleScale;

	public readonly float MinimapFirstScaleStableDuration;

	public readonly float MinimapFirstScaleDuration;

	public readonly float MinimapSafezoneMaxHalfWidth;

	public readonly float MinimapSafezoneMinHalfWidth;

	public readonly float MinimapVehicleHalfWidth;

	public readonly float MinimapCatapultHalfWidth;

	public readonly float MinimapCatapultWithDetectionHalfWidth;

	public readonly float MinimapStropeHalfWidth;

	public readonly float MinimapCanonHalfWidth;

	public readonly float MinimapSlideHalfWidth;

	public readonly float MinimapHomerUAVHalfWidth;

	public readonly float MinimapHomerUAVScaleCSMode;

	public readonly bool CenterOuterSafeZoneOnBigMap;

	public readonly float BigMapMaxCenterSafeZoneScale;

	public readonly bool BuffIconOpen;

	public readonly bool DisableJumpOnIceWall;

	public readonly float RoundBuffPickTimeMS;

	public readonly uint TeamParachuteMarkPOIDistanceSqr;

	public readonly bool EnableTrainingChat;

	public readonly float ChatBoxCloseDelay;

	public readonly float VoiceBoxShowDelay;

	public readonly float AddFriendCloseDelay;

	public readonly float AddFriendTeamFlightCloseDelay;

	public readonly int ChatMsgLengthLimit;

	public readonly float ChatMsgCD;

	public readonly float TextChatCD;

	public readonly float AddFriendInfoCloseDelay;

	public readonly float InviteDisagreeDelay;

	public readonly float HangeUpExpireTime;

	public readonly float HangeUpNotifyQuitTime;

	public readonly bool CameraModeHangeUpNewCheck;

	public readonly bool EnableHandUpStartBotAgent;

	public readonly float HandUpBotAgentWarningTime;

	public readonly float LobbySocialAreaReconnectGSIntervalTime;

	public readonly int LobbySocialAreaAutoJoinQueueDelay;

	public readonly string LobbySocialAreaStorePosHeightRange;

	public readonly uint SubGameLobbyLWMaxRound;

	public readonly bool FollowEmoteOpen;

	public readonly float SubGameLobbyLWBlockSignUpAfterStateReleaseSec;

	public readonly float SubGameLobbyLWFightEndDamageTimeSec;

	public readonly float SubGameLobbyLWBleedingTipsAheadSec;

	public readonly int SubGameLobbyLWPrepareCountdownShowSec;

	public readonly float SubGameLobbyLWBooyahShowDelay;

	public readonly uint SubGameLobbyLWChampionEmotionID;

	public readonly float SubGameLobbyLWScoreboardScaleFactorDeltaPerMetre;

	public readonly string SubGameLobbyLWScoreboardWorldPosition;

	public readonly bool NoPowerGun;

	public readonly int KillNotificationTeamColor;

	public readonly bool KillNotificationTeamSound;

	public readonly float PVE_LightTowerPrepareTime;

	public readonly bool IsEventZomibieFootballLanucher;

	public readonly int SafeZoneIndexToObsoleteExtraLife;

	public readonly int ArmsInfoListDelayTime;

	public readonly bool IsStackedKillOnlyLocalShow;

	public readonly bool ShowAdditionalKillNotifyIfDead;

	public readonly bool IsKillOnlyLocalShow;

	public readonly bool BigMapShowIconToggleBtn;

	public readonly bool IsNeedGoldenAttachmentsShow;

	public readonly float MinimapScaleToGameZone;

	public readonly int GameShowLoserAudioRank;

	public readonly float EscortMatchBoss_MaxHP;

	public readonly float EscortMatchBoss_HPReviveRate;

	public readonly float EscortMatchBoss_PlayerAddHPRate;

	public readonly bool NeedIntroCutscene;

	public readonly float TransformPawnCameraOffset;

	public readonly bool HumanTireOpen;

	public readonly bool HumanTireTeammateOpen;

	public readonly bool HumanTireOppomentOpen;

	public readonly bool IsShowEquipNotificationTip;

	public readonly bool IsShowAttachmentNotificationTip;

	public readonly float TrainingWaitingPortalTime;

	public readonly int WeatherNightStart;

	public readonly int WeatherNightEnd;

	public readonly int weatherTwilightStart;

	public readonly int weatherTwilightEnd;

	public readonly int MeteorDuration;

	public readonly string MeteorSpecificTime;

	public readonly int EnableMVPShow;

	public readonly bool EnableMatchResultAvatarForLowMemory;

	public readonly bool EnableMatchResultAvatarForLowSetting;

	public readonly bool EnableMatchResultMultiAvatarForLowMemory;

	public readonly uint CSSAPBooyahEmoteID;

	public readonly string CSSAPGiftBoxModelRes;

	public readonly float AimProtectAreaXOffset;

	public readonly float AimProtectAreaYOffset;

	public readonly float AimKnockDownXOffsetDivide;

	public readonly float AimKnockDownYOffsetDivide;

	public readonly float AimAssistKnockDownParam;

	public readonly bool DisableAimAssistReviveParachutingTarget;

	public readonly bool HumanTireRankModeOpen;

	public readonly bool PlayerReadyNeedDelay;

	public readonly bool NeedPreloadPlayerAnimators;

	public readonly bool NeedPreloadVestHelmetBackpack;

	public readonly bool ShowBulletHole;

	public readonly float GuildWarWarehouseStoreTime;

	public readonly float GuilWar_NormalTime;

	public readonly bool EnableModeChat;

	public readonly int ModeChatMaxMsgCnt;

	public readonly float CSBotAgentTimeoutReconHintDelay;

	public readonly float CSBotAgentTimeoutReconHintDuration;

	public readonly bool EnableReviveBox;

	public readonly uint ReviveBoxCost;

	public readonly float ReviveBoxEndTimeGlobal;

	public readonly float ReviveBoxPosMarkShowDistance;

	public readonly string ReviveBoxModelResID;

	public readonly string UIFXReviveBoxPosMarkResID;

	public readonly string UIFXReviveBoxMapIconResID;

	public readonly string UIFXReviveBoxRulerIconResID;

	public readonly string UIFXReviveBoxTeammateItemResID;

	public readonly string UIFXReviveBoxTeammateItemWaitingResID;

	public readonly string UIFXReviveBoxIconHighlightResID;

	public readonly string SFXReviveBoxInteracting;

	public readonly string VFXPOIMissionFinishLootFlyResID;

	public readonly string FragmentCollectorModelResID;

	public readonly string FragmentCollectorColResID;

	public readonly string FragmentModelResID;

	public readonly string FragmentColResID;

	public readonly float FragmentCollectorFloatHeight;

	public readonly string VFXFragmentFlyResID;

	public readonly string SFXFragmentCollectorStartBreak;

	public readonly string SFXFragmentBreak;

	public readonly string OccupyPointModelResID;

	public readonly string OccupyPointColResID;

	public readonly string OccupyPointScaleByPOI;

	public readonly string SFXOccupyPointActive;

	public readonly string SFXOccupyPointFinish;

	public readonly string SFXOccupyPointOccupy;

	public readonly float FlightBubbleAttractStartDistance;

	public readonly float FlightBubbleAttractSpeed;

	public readonly int FlightBubbleAttractMaxDurationMs;

	public readonly float FlightBubbleMinSpawnDistance;

	public readonly int FlightBubbleSpawnRetryMaxCount;

	public readonly float ADS1v1PrepareCountdownDuration;

	public readonly float ADS1v1PrepareTransportDuration;

	public readonly float ADS1v1TransportAnimDuration;

	public readonly float ADS1v1EndCountdownDuration;

	public readonly float ADSNormalDuration;

	public readonly float ADSNormalBonusDuration;

	public readonly float ADS1v1Duration;

	public readonly bool CenterSafeZoneOnBigMap;

	public readonly bool CenterSafeZoneOnMiniMap;

	public readonly bool CenterSafeZoneOnSideMap;

	public readonly bool OBCenterSafeZoneOnBigMap;

	public readonly bool OBCenterSafeZoneOnSideMap;

	public readonly int OBCenterSafeZoneStartStage;

	public readonly int OBCenterSafeZoneEndStage;

	public readonly int OBCenterSafeZoneEndBaseRadius;

	public readonly bool UseNewDeathCamera;

	public readonly bool EnableShowMapMarkInHud;

	public readonly bool UseFullAttachment;

	public readonly bool TeamBarStrikeDownIconShowMode;

	public readonly bool EnableCameraShakeInCabin;

	public readonly float BluetearsAirdropScaleInit;

	public readonly float BluetearsAirdropScaleFinal;

	public readonly float BluetearsAirdropInteractTime;

	public readonly float BluetearsBubblesAccelerateCDTime;

	public readonly float BluetearsBubblesInteractValidMinHeight;

	public readonly float BluetearsBubblesInteractValidMaxHeight;

	public readonly bool BluetearsAirdropEnable;

	public readonly string BluetearsAirdropItemDisplay;

	public readonly float BluetearsAirdropHoldRadius;

	public readonly float BluetearsWhalePortalScale;

	public readonly float BluetearsWhaleCSPortalScale;

	public readonly float BluetearsWhaleSpawnOffset;

	public readonly float BluetearsWhaleCSPawnOffset;

	public readonly float BluetearsWhaleSpawnEndPortalLeftTime;

	public readonly float BluetearsWhaleCSEndPortalLeftTime;

	public readonly bool MarkPointUseOriginalPosWhenDontHit;

	public readonly float SwimmingSurfDashBasicSpeed;

	public readonly bool EnableSwimmingSurfChangemMove;

	public readonly bool EnableDefaultWakeBoard;

	public readonly bool EnableWakeBoardToSwim;

	public readonly bool EnableSwimmingSurfKeepDash;

	public readonly bool EnableSwimmingSurfKeepDashForMeleeWeapon;

	public readonly float Pregame_Duration;

	public readonly float Preset_Duration;

	public readonly int RP_GameObjective;

	public readonly int RP_SoulPerPhase;

	public readonly int RP_SoulDrainRadius;

	public readonly float RP_GameTime;

	public readonly int RP_HP;

	public readonly float Control_ControlPointActivatingTime;

	public readonly float Control_ChangeActivateControlPointInterval;

	public readonly float Control_StartActivateControlPointInterval;

	public readonly float Control_ZoneCloseTips;

	public readonly float Control_ZoneActivateTips;

	public readonly float Control_TryingControlDelay;

	public readonly int ForceTutorial_BotWeapon1;

	public readonly int ForceTutorial_BotWeapon2;

	public readonly int ForceTutorial_BotWeapon3;

	public readonly int ForceTutorial_BotWeapon4;

	public readonly int ForceTutorial_BotWeapon5;

	public readonly int ForceTutorial_BotWeapon6;

	public readonly int ForceTutorial_BotWeapon7;

	public readonly int ForceTutorial_BotWeapon8;

	public readonly string ForceTutorial_MedicalKit;

	public readonly string ForceTutorial_LootBoxItem;

	public readonly string ForceTutorial_FPSLootBoxItem;

	public readonly float ForceTutorial_BotShootTime;

	public readonly float ForceTutorial_BotShootGap;

	public readonly int ForceTutorial_BotDamageToTeammate;

	public readonly int ForceTutorial_BotDamageToTeammate2;

	public readonly int ForceTutorial_BotDamageToPlayer;

	public readonly int ForceTutorial_BotDamageToPlayerLOW;

	public readonly int ForceTutorial_BotEnemyModel;

	public readonly int ForceTutorial_BotTeammateModel;

	public readonly string ForceTutorial_KellyClothes;

	public readonly string ForceTutorial_MaximClothes;

	public readonly string ForceTutorial_BotEnemyClothes;

	public readonly string ForceTutorial_BotTeammateClothes;

	public readonly uint ForceTutorial_IceWallItemID;

	public readonly uint ForceTutorial_GrenadeItemID;

	public readonly uint ForceTutorial_SkillCardItemID;

	public readonly uint ForceTutorial_IceWallNum;

	public readonly uint ForceTutorial_IceWallNumNewBie;

	public readonly int ForceTutorial_IceWallMaxNum;

	public readonly int ForceTutorial_IceWallHP;

	public readonly uint ForceTutorial_IceLifeTime;

	public readonly float ForceTutorial_IceCrackHPThreshold;

	public readonly int ForceTutorial_GrenadeNum;

	public readonly float ForceTutorial_KillBotIntervalTime;

	public readonly float ForceTutorial_ProtectGuideTime;

	public readonly float ForceTutorial_CameraOutSizeTime;

	public readonly float ForceTutorial_CameraOutSizeX;

	public readonly float ForceTutorial_VeteranEndTime;

	public readonly float ForceTutorial_TeammateCureSelfTime;

	public readonly uint ForceTutorial_TeammateNewBieQuickChatID;

	public readonly uint ForceTutorial_TeammateHelpQuickChatID;

	public readonly uint ForceTutorial_TeammateFpsThankQuickChatID;

	public readonly uint ForceTutorial_SupplyQuickChatID;

	public readonly float ForceTutorial_ProcessSupplyInterval;

	public readonly int ForceTutorial_SkillCardUseLimit;

	public readonly uint ForceTutorial_SkillID;

	public readonly float ForceTutorial_TeammateDamageIncreaseTime;

	public readonly int ForceTutorial_TeammateDamageToIceWall;

	public readonly int ForceTutorial_TeammateDamageToEnemy;

	public readonly uint ForceTutorial_BIRTH_WEAPON_ID;

	public readonly int ForceTutorial_Bot_SkillBlowUp_MaxDis;

	public readonly float ForceTutorial_TeammateCrawlTime;

	public readonly int ForceTutorial_PlayerLowestHP;

	public readonly int ForceTutorial_PlayerHealToHitHP;

	public readonly float ForceTutorial_NewBieEnemyMoveTime;

	public readonly float Banknote_ScoreChangeDelay;

	public readonly float SPPlayLastSafeZoneBGMRadius;

	public readonly float BountyRepairPoint;

	public readonly float AstrolGateTeleportInterval;

	public readonly uint AstrolGateTeleportCountMax;

	public readonly float AtrolGateTeleportMaxRadius;

	public readonly int TrapCatchDurationMS;

	public readonly int TrapDelayActiveTimeMS;

	public readonly int TrapRescureTimeMS;

	public readonly bool EnableQuickChat;

	public readonly bool BR_CanRevive;

	public readonly bool EnableAskPurchaseCSItem;

	public readonly bool EnableRequestHelpPurchaseQuickChat;

	public readonly bool EnableResponseHelpPurchaseQuickChat;

	public readonly bool IsDoubleClickBuy;

	public readonly float DoubleClickBuyInterval;

	public readonly bool LastRoundMatchPointTransition;

	public readonly bool ShowMusicBeatCombo;

	public readonly bool EnableAceShow;

	public readonly int GroupMode3AceKillStreak;

	public readonly int GroupMode4AceKillStreak;

	public readonly int GroupMode5AceKillStreak;

	public readonly bool ShowDeadPopMsg;

	public readonly bool NeedCheckIsSmallSafeZone;

	public readonly float Football_Radius;

	public readonly float Football_PendingTime;

	public readonly float Football_ShootSpeedMax;

	public readonly float Football_HighShootYMultiple;

	public readonly float Football_ShootAngleMin;

	public readonly float Football_HighShootAngleMin;

	public readonly float Football_ShootAngleMax;

	public readonly float Football_HighShootOffsetRatio;

	public readonly bool InGameTokenShow;

	public readonly int ScoreToShowEffect;

	public readonly float EnergyStoneBoxActiveTime;

	public readonly float AllEnergyStoneScoreBonus;

	public readonly int ChokePointBuffDuration;

	public readonly float ChokePointBuffScourBonus;

	public readonly bool OpenFootStepAndFireUIHint;

	public readonly bool IsCollectionTransformDisable;

	public readonly bool TDMLikeShopEnablePurchaseDuringDeath;

	public readonly bool TDMLikeShopEnableEndSelectionManuallyAfterRevival;

	public readonly float LowBloodLine;

	public readonly string LowBloodLineEffect;

	public readonly uint LuckyDrawBoxRerollCost;

	public readonly uint LuckyDrawBoxFirstDropCost;

	public readonly uint LuckyDrawBoxDropCost;

	public readonly uint GameTimeRedLabelSeconds;

	public readonly uint GameTimeRedLabelTwoBossSeconds;

	public readonly uint DeathMatchTargetRestCnt;

	public readonly bool IsBrScoreboardOpen;

	public readonly bool ShowEnemySkill;

	public readonly float AIAimAssistWeight;

	public readonly bool AbandomLifeEnable;

	public readonly float AIHPShowTime;

	public readonly float AIWolfHPShowTime;

	public readonly int MaxEnemyHpCount;

	public readonly float BossHalloweenHPShowTime;

	public readonly bool IsNeedDirectionRuler;

	public readonly bool IsNeedRemainingInfo;

	public readonly bool BigMapAirLineDefaultShow;

	public readonly float BigMapAirLineDefaultShowTimer;

	public readonly int PlayerCountPerTeam;

	public readonly int InGameTokenUnitCount;

	public readonly uint HG_Recommand_ItemID;

	public readonly float Football_MatchStartPendingTime;

	public readonly float FootballGame_WaitingTime;

	public readonly float FootballGame_PrepareTime;

	public readonly float FootballGame_MatchTime;

	public readonly float FootballGame_OverTime;

	public readonly string DefaultSceneAudioResource;

	public readonly float WeaponFireRestrictInWaitingPhase;

	public readonly float SceneAudioFadeTime;

	public readonly bool NoPlayerDamage;

	public readonly bool NoDamage;

	public readonly bool PropertyChangeSwitch;

	public readonly bool EnableTeammateNameHud;

	public readonly float CS_1stphaseShopAddTime;

	public readonly float CS_1stphaseShopAddRange;

	public readonly float CS_PhasePrepareTimeFirstRound;

	public readonly float CS_WaitingTimeBeforeGame;

	public readonly bool CS_1stphaseShopDelayCloseSwitch;

	public readonly int CS_PhasePrepareTime;

	public readonly float CS_PhaseCutsceneDelayTime;

	public readonly float CS_PhaseCutsceneStableTime;

	public static readonly bool EnableLoadImageImmediately;

	public readonly string EnablePlayerMoveNetDelayRegion;

	public readonly string NetDelayLegalTimeSRegion;

	public readonly string NetDelayLegalMoveSpeedRegion;

	public readonly string NetDelayLegalMaxMoveDistanceRegion;

	public readonly string EnableNetDelaySyncSelfDamageRegion;

	public readonly string SyncSelfDamagePingRegion;

	public readonly string PingUpdateIntervalRegion;

	public readonly string PingAverageCountRegion;

	public bool EnableServerAuthorizedPhysXStateSwitch;

	public bool EnablePlayerMoveNetDelay;

	public float NetDelayLegalMoveSpeed;

	public float NetDelayLegalTimeS;

	public float PosSyncMinTimeS;

	public bool EnableNetDelaySyncSelfDamage;

	public uint SyncSelfDamagePing;

	public float AceVFXHTeamMatesInfoAndScoreBoardContinueTime;

	public float AceVFXPlayerContinueTime;

	public float PingUpdateInterval;

	public uint PingAverageCount;

	public float HighPunishmentVisibleRange;

	public float MoveCircleMinimapScale;

	public readonly float IceWallMakerKillerCollectRange;

	public readonly float IceWallMakerNotKillerCollectRange;

	public readonly float UIPDMRankNextPlayTime;

	public readonly float UIPDMRankEdgeToCenterTime;

	public readonly float UIPDMRankAnimTime;

	public readonly float UIPDMRankStartTime;

	public readonly float UIPDMRankStopTime;

	public readonly bool IsHeadShotOnly;

	public readonly bool IsWeaponCombineDefault;

	public readonly bool ShowTrail;

	public readonly string ShowTrailResourceID;

	public readonly string VVBuffGeneratorResourceID;

	public readonly string VVBuffGeneratorCountDownResourceID;

	public readonly float ShowTreasuryCountDownTime;

	public readonly float TreasuryOpenable;

	public readonly bool EnableTreasuryMapIcon;

	public readonly string SoloReviveOpenMatchMode;

	public readonly int SoloReviveRedHintTime;

	public readonly int SoloReviveMaxTime;

	public readonly string SoloReviveCoinsList;

	public readonly int SoloReviveTimes;

	public readonly int SoloReviveWaitTime;

	public readonly int SoloRPReviveMaxTime;

	public readonly bool IsAimAssistKnockdownLevelDown;

	public readonly bool SkipKnockdownAimAssistNeedMoveTowardsStandMan;

	public bool IsRadarOpen;

	public readonly int TargetRefreshTime;

	public readonly float TrainDummyMaxHP;

	public readonly float TrainDummyDefaultHP;

	public readonly int TrainDummyReviveTime;

	public readonly bool ShowToxicWarningWnd;

	public readonly bool ShowToxicWarningWnd_EscFromBattle;

	public readonly bool ShowToxicWarningWnd_Dead;

	public readonly bool ShowToxicWarningWnd_VoiceReportRelated;

	public readonly uint MaxTechPoint;

	public readonly float TechInteractValidUpPos;

	public readonly float TechInteractValidDownPos;

	public readonly bool DisableUGCChangePlayerChothes;

	public readonly float VoiceBoxCloseDelay;

	public static string UGCResCheckFlag;

	public readonly bool TechAirdropOpen;

	public readonly string YellowPingThresholdRegion;

	public readonly string RedPingThresholdRegion;

	public int YellowPingThreshold;

	public int RedPingThreshold;

	public readonly bool EnableOptimizeParachuteProcess;

	public readonly bool EnableOptimizeParachuteProcessV2;

	public readonly float SkyDivingMinVSpeed;

	public readonly float SkyDivingMaxVSpeed;

	public readonly float SkyDivingMinHSpeed;

	public readonly float SkyDivingMaxHSpeedRatio;

	public readonly float SkyDivingMaxHSpeed;

	public readonly float SkySurfingMinVSpeed;

	public readonly float SkySurfingMaxVSpeed;

	public readonly float SkySurfingMinHSpeed;

	public readonly float SkySurfingMaxHSpeed;

	public readonly float ParachutingMinHSpeed;

	public readonly float ParachutingMaxHSpeed;

	public readonly float ParachutingMinVSpeed;

	public readonly float ParachutingMaxVSpeed;

	public readonly float CatapultLaunchUseTime;

	public readonly float LevelLockAirdropInteractTimeFromZeroToOne;

	public readonly float LevelLockAirdropInteractTimeFromOneToTwo;

	public readonly float LevelLockAirdropInteractTimeFromTwoToThree;

	public readonly float LockAirdropMapIconDeleteTime;

	public readonly bool EnableStableVehicleBounceProjectile;

	public readonly float AutoPickupTemporaryCloseTime;

	public readonly float DiwaliLotusLampTimeFromZeroToOne;

	public readonly float DiwaliLotusLampTimeFromOneToTwo;

	public readonly float DiwaliLotusLampTimeFromTwoToThree;

	public readonly int DiwaliLotusLampEnterGuideTimes;

	public readonly bool EnableQTEUnFreeze;

	public readonly uint QTEUnFreezeClickCnt;

	public readonly int WLGP25WishPoolCoinCost;

	public readonly bool IsCabinWaitingInteractionOpen;

	public readonly bool IsWaitingPhaseThumbUpOpen;

	public readonly string SurvivorRemainBoard;

	public readonly bool StepVibratingSwitch;

	public readonly bool EnablePlayerFakeHeight;

	public readonly float PlayerFakeHeightYDelta;

	public readonly float PlayerHeightFakeRatio;

	public readonly float CSRoundDragonScale;

	public readonly float CSRoundDragonPopupShowTime;

	public readonly bool AffixPopupOpen;

	public readonly float AffixPopupTime;

	public readonly string AffixPopupTitleKey;

	public readonly string AffixPopupCandidates;

	public readonly bool DisableChargeShotGunHoldFire;

	public bool FPPGameModeEnable;

	public bool FPPEnablePlayerCamera;

	public float FPPPlayerCameraFarClip;

	public bool FPPEnableMatchIntro;

	public float FPPModelStandYOffset;

	public float FPPModelCrouchYOffset;

	public float FPPModelCreepYOffset;

	public float FPPModelStandZOffset;

	public float FPPModelCrouchZOffset;

	public float FPPModelCreepZOffset;

	public readonly float FPPModeForwardSpeedRatio;

	public readonly float FPPModeBackupSpeedRatio;

	public readonly float FPPModeLateralSpeedRatio;

	public readonly float FPPModeJumpHeightRatio;

	public readonly float FPPModeDashSpeedRatio;

	public readonly float FPPModeSpeedAngleTangent;

	public bool FPPModeHitEffect;

	public bool FPPModeFireEffect;

	public bool FPPModeSightUI;

	public bool FPPEnableDamageEffect;

	public int FPPBeDamageEffectHPThreshold;

	public float FPPAccurateFireTime;

	public bool FPPRecoil;

	public bool FPPVibrateRotate;

	public float FPPVibrateRotateSpeed;

	public float FPPWeaponRotationXAngle;

	public float FPPWeaponRotationZAngle;

	public float FPPRecoilYCycleTime;

	public float FPPRecoilZCycleTime;

	public float FPPRecoilYFactor;

	public float FPPRecoilZFactor;

	public float FPPRecoilBackwardX;

	public float FPPRecoilBackwardZ;

	public float FPPRecoilBackwardSpeed;

	public bool FPPBulletEffect;

	public float FPPSubMachineGunBulletLifeTime;

	public float FPPShotGunBulletLifeTime;

	public float FPPRifleBulletLifeTime;

	public bool FPPFootStep;

	public bool FPPElectricZoneHint;

	public bool FPPEnableFastRunEffect;

	public float FPPHeadKillEffectScale;

	public float FPPCameraMaxfireRotateAngle;

	public float FPPCameraFireRotateTime;

	public float FPPCameraMaxfireZoomOffset;

	public float FPPCameraFireZoomTime;

	public int FPPDebugWeaponBindType;

	public float FPPMoveJoyStickAngle;

	public float FPPPreMoveJoyStickAngle;

	public float FPPTwoToOneScreenLength;

	public float FPPFourToThreeScreenLength;

	public float FPPSmallTwoToOneScreenLength;

	public float FPPSmallFourToThreeScreenLength;

	public bool FPPInspectionControl;

	public bool FPPChangeGunTrace;

	public float FPPChangeGunTraceLength;

	public float FPPPlayRecoverSoundCd;

	public float FPPDashAnimationSpeedScale;

	public float FPPIceWallDeltaDistanceRatio;

	public float FPPPlayerFiringDampRadio;

	public bool EnablePcCameraSimulate;

	public bool ShieldDamageHintTxt;

	public bool SocialMusicBox;

	public bool WeaponQTENoFail;

	public bool WeaponQTEByFireBtn;

	public bool UrnDieMergeCover;

	public float UrnDestroyRange;

	public bool UseNewFeedbackStyle;

	public bool UseNewVictoryStyle;

	public bool UrnDieRandomGenerate;

	public bool UrnDieEmptyModelGenerate;

	public float VehicleAutoUseRouteTokenTime;

	public readonly int HelicopterForcedDownTime;

	public readonly int HelicopterForcedDownHint;

	public float UseActionGetOnSlideDis;

	public float SlideMoveHintShowTime;

	public bool ShowDebugSlideLine;

	public float TriggerSlideCheckDis;

	public float TriggerSlideCheckDisInMid;

	public float SlideLerpStopThresholdSqr;

	public float SlideNeedLerpCheckDis;

	public float SlideLerpRunningTime;

	public float FinishSlideProtectTime;

	public float SlideGetOnSlideRunningSpeed;

	public float SlideInitRunningSpeed;

	public float SlideRunningSpeedIncrease;

	public float SlideRunningSpeedReduce;

	public float SlideRunningSpeedMax;

	public float SlideCheckChangeDirTime;

	public float SlideFowardAligmentCheckDelta;

	public float SlideFowardAligmentDegreesSpeed;

	public float SlideJumpOutAngleDegree;

	public float SlideJumpOutSpeed;

	public float SlideJumpMaxHeight;

	public bool EnableSlideAndStropWarningHint;

	public bool IsFireCanJumpOnSlide;

	public bool CanJumpOnSlide;

	public float SlideForceDirDistance;

	public bool CanTriggerOnSlideInMid;

	public bool CanTriggerOnSlideOff;

	public bool EnableSlideScan;

	public uint SFRoleplayMaxEnergy;

	public float SFRoleplayCSDelayShopTime;

	public bool SwordOfJusticeOpen;

	public int WeaponTermAssign;

	public float VehicleChangeSpeedZoneMarkShowDistance;

	public float ItemGeneratorUnlockTime;

	public float VehicleDriverFireResetCameraFreeSpeed;

	public float CSAffixIntro_ExtraHoldTime;

	public float IIV1v1GotoLandMaskShowTime;

	public float IIV1v1LeaveLandMaskShowTime;

	public float IIV1v1LandWaitingTime;

	public float EighthBRTrainAppearTime;

	public float EighthBRTrainWaitTime;

	public float EighthBRTrainIconLightTime;

	public float EighthBRLandBattleShowLeftTime;

	public float EighthBRFloatingLandDelayShowResultTime;

	public float EighthBRFloatingLandWaitingTime;

	public float EighthBRLeaveLandRewardHintTime;

	public float EighthBRBooyaTrainPosX;

	public float EighthBRBooyaTrainPosY;

	public float EighthBRBooyaTrainPosZ;

	public float EighthBRBooyaTrainRotY;

	public float ReviveZoneUIWarningRate;

	public bool ForceUseNewHitHint;

	public bool ItemGeneratorMarkShowInFightingPhase;

	public bool LowGravityAreaDebug;

	public bool ScopeDispersionDisplaySwitch;

	public float ScopeDispersionDisplayFactor;

	public readonly bool BooyahBountyOpening;

	public readonly bool BountyKillVFXOpen;

	public readonly string BooyahBountyGameplayAffixDetailIDs;

	public readonly float BooyahBountyUavCoinTipsCooldownSecs;

	public readonly uint TechAirdropSkinType;

	public readonly bool TechAirdropCanFireThrough;

	public readonly string SpecialCSMatchWinVFXOffset;

	public readonly float TeamGatherPointAvailableDistanceClient;

	public readonly bool IsShowCSTeamGoalPath;

	public readonly string ShowCSTeamGoalPathRankSort;

	public readonly string ShowCSTeamGoalPathType;

	public readonly bool IsShowCSTeamGoalMVPUIFX;

	public readonly float CSTeamGoalPathDelayHideTime;

	public readonly float HelicopterClientRelativeMaxHeight;

	public readonly int UnlockBountyValue;

	public readonly int UnlockBountyVehicleValue;

	public readonly bool EnableSyncHudOperate;

	public readonly bool IsRoundMVPTipsOpen;

	public readonly string RoundMVPVFX;

	public readonly string CSRoundGiantObject;

	public readonly uint CSShopSkinType;

	public readonly uint FightClubShopSkinType;

	public readonly float TechAirdropDelayShowCSShop;

	public readonly float TechBuildDelayShowCSShop;

	public readonly float EighthTrainTipsShowTime;

	public readonly float EighthTrainDetialTipsShowTime;

	public readonly int EighthTrainDetailTipsDepth;

	public readonly bool IsInGameNewUIOpen;

	public readonly bool EnableDynamicTeamID;

	public readonly string OB47AuroraA;

	public readonly string OB47AuroraB;

	public readonly string OB47AuroraC;

	public readonly float OB47AuroraInteractProgressTime;

	public readonly float OB47AuroraInteractEndTime;

	public readonly int OB47AuroraInteractTime;

	public readonly int OB47AuroraExtraCoin;

	public readonly string WeatherSystemRes;

	public readonly string Carni25WeatherSystemRes;

	public readonly string TreasureHuntWeatherSystemRes;

	public readonly bool TreasureHuntUnderTreasuryDontCheck;

	public readonly float IceBoxHudShowDistance;

	public readonly float IceBoxHudOffsetY;

	public readonly bool CameraGazeSwitch;

	public readonly float FFWSFireZoneTrophyHeightRatio;

	public readonly float FFWSFireZoneTrophyMinHeight;

	public readonly int FFWSFireZoneNumber;

	public readonly float MinCameraGazePointDistance;

	public readonly float MaxCameraGazePointDistance;

	public readonly float CameraGazePointChangeThreshold;

	public readonly float CameraGazePointChangeTime;

	public readonly bool IsNormalUseSniperShowCrosshair;

	public readonly bool CanFullEPPurchase;

	public readonly bool PlayerOnSlopeCheck;

	public readonly bool EnableBehaviorTreeOutOfControl;

	public readonly bool AllowBuildingGunIfOutOfControl;

	public readonly float SnowmanModeSpeedUpValue;

	public readonly string SnowmanModeLevel0Des;

	public readonly string SnowmanModeLevel1Des;

	public readonly string SnowmanModeLevel2Des;

	public readonly string SnowmanModeLevel3Des;

	public uint CSShopEventFilterOpen;

	public uint LootExtraItemId;

	public readonly float XRay_ColorMinAlpha;

	public readonly bool XRay_IgnoreCrouchingEnemy;

	public readonly bool IsDeadBoxCanRevive;

	public readonly bool IsDeadBoxNeedOpen;

	public readonly bool IsDeadBoxTeammateCanPickup;

	public readonly float DeadBoxOpenDuration;

	public readonly float DeadBoxReviveDuration;

	public readonly int HippoCrisisCountDownShowInternalSec;

	public readonly int HippoCrisisSafeBoxDefaultCapacity;

	public readonly int HippoCrisisBagDefaultCapacity;

	public readonly int HippoCrisisDefaultMaxReviveCount;

	public readonly string SafeBoxAutoPickUpType;

	public readonly bool HippoCrisisKeepOpenBoxWhenPickUp;

	public readonly float HippoCrisisRetreatTimeSec;

	public readonly bool EnableGlobalActiveSkillCD;

	public readonly float GlobalActiveSkillCDTimeSec;

	public readonly string CanEquipAndCapacityFreeTypes;

	public readonly bool EnableSantinoDummyMovePerformance;

	public readonly float SantinoDummyColliderRadiusScale;

	public readonly bool CheckIsOnMotionPlatform;

	public readonly bool IceWallCanPutOnTrain;

	public readonly bool IceWallCanPutOnWLGP25Island;

	public readonly string MotionPlatformCheckAreas;

	public readonly float BuildingGunOnSlideFireInterval;

	public readonly float NBGP2BloodMoonAirdropPosMarkAllowDistance2D;

	public readonly float NBGP2BloodMoonRoundSafeZoneAlphaScale;

	public readonly float EnvWeatherZoneBackToDefaultDurationSecs;

	public readonly float TrainHitFlyTriggerStayCheckInterval;

	public readonly float WaitingLandTrainIntervalTime;

	public readonly float WaitingLandTrainSpeed;

	public readonly float WaitingLandTrainHitFlySpeedXZ;

	public readonly float WaitingLandTrainHitFlySpeedY;

	public readonly float WaitingLandTrainHitFlyTime;

	public readonly float SmartIcewallAutoChangeWeaponWaitTime;

	public readonly string AirlineSpeedUpRatios;

	public readonly string AirlineSpeedUpVFXs;

	public readonly string AirlineSpeedUpUIFXs;

	public readonly float TechBuildPointSpawningVfxLifetimeSecs;

	public readonly bool HypercrateContainerPickOptimize;

	public readonly bool EnableFerrisWheelInteraction;

	public readonly bool EnableIceWallShieldOnSlide;

	public readonly bool DropUselessAttachment;

	public readonly bool EnableAutoPickUpFunc;

	public readonly int HCMatchResultShowEffectMinLevel;

	public readonly bool EnableShowZombieHurtHint;

	public readonly bool EnableRelatedWeaponIDSwitch;

	public readonly bool EnableCameraMode;

	public readonly bool IsZombieMapShow;

	public readonly float InfinityIceWallEndCD;

	public readonly string MotionPlatformForbiddenDummyZones;

	public readonly string MotionPlatformForbiddenPersonalAirdropZones;

	public readonly bool EnableParachutingOnPlatform;

	public readonly bool EnableCSPrepareClearMovePlatformProtect;

	public readonly float CSPrepareClearMovePlatformProtectDelayTime;

	public readonly float SFRoleplayGhostCircleLerpDistance;

	public readonly string CSRoundFilterOpen;

	public readonly bool MultiPickupTriggerOptimizeEnable;

	public readonly bool RecyclePlayerExitPickupTriggersEnable;

	public readonly float SnowSlideRunLowSpeedScale;

	public readonly float SnowSlideDashLowSpeedScale;

	public readonly float SnowSlideRunSpeedScale;

	public readonly float SnowSlideDashSpeedScale;

	public readonly float SnowSlideRunLowSpeedScale_HomerSkill;

	public readonly float SnowSlideDashLowSpeedScale_HomerSkill;

	public readonly float SnowSlideRunSpeedScale_HomerSkill;

	public readonly float SnowSlideDashSpeedScale_HomerSkill;

	public readonly float SnowSlideMaxJumpHeight;

	public readonly int GetOnSnowSlideCDTime;

	public readonly bool EnableSnowSlideDashGradualChange;

	public readonly float SnowSlideDashStartSpeedLerpDuration;

	public readonly float SnowSlideDashExitSpeedLerpDuration;

	public readonly float FreeMoveAngularSpeedSnowSlide;

	public readonly float BackOffSnowSlideNormal;

	public readonly float BackOffSnowSlideDash;

	public readonly float SnowSlideEstimateJumpDashSpeed;

	public readonly float SnowSlideGrabSpeed;

	public readonly float SnowSlideDoubleJumpHeight;

	public readonly float SnowSlideSpeedEffectMinSpeed;

	public readonly bool EnableSingleShotContinueFireAfterReload;

	public readonly string BattleBoardOpenMatchMode;

	public readonly float BattleBoardDisappearTime;

	public readonly int BattleBoardMVPShowLimit;

	public readonly string BattleBoardPKShowLimit;

	public readonly bool ShowBackpackAmmo;

	public readonly float BigitemsDisplayLastSecs;

	public readonly bool NBGP2BigItemIconDisplayAlways;

	public readonly bool CSPeakBoardVoiceOpen;

	public readonly bool CSPeakBeginVoiceOpen;

	public readonly bool CSPeakBooyahVoiceOpen;

	public readonly float WinchesterBoltAnimTime;

	public readonly float WinchesterBoltPreRollAnimTime;

	public readonly string MapCenterPoint;

	public readonly string FFWSCenterPoint;

	public readonly float FFWSAngle;

	public readonly float FFWSFlameOffYAngle;

	public readonly float FFWSCenterPointRadius;

	public readonly bool SantinoCanUseOnMovePlatform;

	public readonly uint CSLoadoutAttackKillCountBase;

	public readonly uint CSLoadoutAttackKillCountIncrease;

	public readonly uint CSLoadoutAttackKillGetTokenCount;

	public readonly string TreasuryUpgradeCost;

	public readonly uint[] TreasuryUpgradeCostArray;

	public readonly bool TreasuryCanUpgrade;

	public readonly float UIMarkStartY;

	public readonly bool WLGP25IslandEnable;

	public readonly bool WLGP25SkateboardEnable;

	public readonly int DyingTimeout;

	public readonly float EnergyDeviceBeforeLandingHintTime;

	public readonly bool Carni25Enable;

	public readonly bool Carni25CSEnable;

	public readonly bool EnableSpecalPickupEffect;

	public readonly float FFWSFlagScale;

	public readonly string CustomSpawnAreaFences;

	public readonly float AirdropWeaponMarkOffsetY;

	public readonly float PocketReviveGroundAngleClientMax;

	public readonly bool EnableCubicMap;

	public readonly bool EnableCSAbilityPoint;

	public readonly float SpawnGodTimeSec;

	public readonly bool EnableTrainingMatchQuitGodAfterControl;

	public readonly string StealthRestrictedSlots;

	public readonly bool EnableStealthCannotFireStrongNotice;

	public readonly bool EnableStealthWarningHint;

	public readonly bool EnableStealthStepVibrate;

	public readonly bool EnableSnowSlideWarningHint;

	public readonly bool EnableSnowSlideStepVibrate;

	public readonly float SnowSlideWarningMinVelocitySqr;

	public readonly string PlayerFastFallingType;

	public readonly string MiniMapAffixProcessRes;

	public readonly string MiniMapAffixProcessAnim;

	public readonly bool EnableHitTagHackCheck;

	public readonly float CoinMakerSharedScope;

	public readonly bool LeaveTeamUseSelfTeamFlight;

	public readonly bool FixLeaveTeamFlightLeftoverParachute;

	public readonly bool FixTeamFlightReviveWorldTransformAfterSkyDiving;

	public readonly bool FixTeamFlightLandingExitRestorePersonalFlight;

	public readonly bool EnableCarni25GPDanceNoAimAssist;

	public readonly string BotAgentIdleDetectionCycleTime;

	public readonly float LandingFightProtectionEndTime;

	public readonly float LandingFightProtectionDuration;

	public readonly float LandingFightProtectionHintTime;

	public readonly bool TreasuryUpgradeOpenGateDirectly;

	public readonly bool TreasuryUpgradeOpenGateNoNeedKey;

	public readonly string HotZoneEffectResName;

	public readonly string HotZoneEffectMapIcon;

	public readonly float GB_GPKickValidClientDistance;

	public readonly float GB_GPKickValidWeaponDistance;

	public readonly float GB_GPKickMinYAngle;

	public readonly float GB_GPKickMaxYAngle;

	public readonly float GB_GPKickInterval;

	public readonly float GB_GPKickChargeRatioDefault;

	public readonly float GB_GPKickClickRatio;

	public readonly float GB_GPKickChargeFullTime;

	public readonly float GB_GP_KickPlayerSpeed;

	public readonly float GB_GP_CanKickAngleMax;

	public readonly float GB_GP_GulagEnableTimeLimit;

	public readonly float GB_GP_GulagPreEnterTime;

	public readonly float GB_GP_GulagWaitingTime;

	public readonly string GB_GPSoccerGoalLevelColor;

	public readonly bool GB_GPShowKickballUI;

	public readonly float GB_GPFootballCameraBackOffset;

	public readonly float GB_GPFootballJumpHeight;

	public readonly bool GB_GPCanKickBallOnMovePlatform;

	public readonly float SoftCloseNoticeThreshold;

	public readonly float SoftCloseCountdownThreshold;

	public readonly float LobbySocialAreaCarryPlayerDistanceRange;

	public readonly float LobbySocialAreaDancePoolJoinDistanceRange;

	public readonly float FollowMoveEmoteTriggerRange;

	public readonly float SunMoon_StartFallingSec;

	public readonly float SunMoon_StartFallingAbsHeight;

	public readonly float SunMoon_StopFallingRelativeHeight;

	public readonly float SunMoon_FallingSpeed;

	public readonly float SunMoon_SkyBoxRange;

	public readonly float SunMoon_AutoPickupRange;

	public static bool PlayerOnNarrowFlatCheck;

	public static bool VendingMachineBreakOpen;

	public static float VendingMachineBreakDamage;

	public static float PlayerOnNarrowFlatCheckInterval;

	public static float PlayerOnNarrowFlatCheckHeight;

	public static float PlayerOnNarrowFlatCheckMaxValidRadius;

	public static float PlayerOnNarrowFlatCheckDistance;

	public static float PlayerOnNarrowFlatCheckPushSpeed;

	public static float PlayerOnNarrowFlatCheckInputLockDuration;

	public readonly float BTFishingMinTIme;

	public readonly float BTFisingMaxTime;

	public readonly uint BluetearsFishingSelfMaxShow;

	public readonly float BTTelportUseTime;

	public readonly uint BluetearsFishingTeammateMaxShow;

	public readonly uint BluetearsFishingEnemyMaxShow;

	public readonly bool BluetearsFishTailShowBySpeed;

	public readonly float BluetearsFishTailShowSpeed;

	public readonly float BluetearsFishDropTime;

	public readonly float BluetearsFishDropStartHeight;

	public readonly float BluetearsFishDropEndHeight;

	public readonly float BluetearsFishDropForwardOffset;

	public readonly uint BluetearsFishingLoopInteractCount;

	public readonly bool IsPOIDisplayOn;

	public readonly bool IsPOIDisplayAnimOn;

	public readonly float POIDisplayAnimMaxStartDelay;

	public readonly float POIDisplayAnimStartDelayIntervalMin;

	public readonly float POIDisplayAnimStartDelayIntervalMax;

	public readonly int MinimapInfoDuration;

	public readonly bool IsMinimapInfoShowCoin;

	public readonly bool IsPOIBlueCircle3DDisplayOn;

	public readonly bool NinthWeaponAwakeSent;

	public readonly bool PresetPickOpen;

	public readonly bool CustomRoomPresetPickOpen;

	public readonly float BloodmoonGPTotemRespawnVFXTimeSec;

	public readonly float BloodmoonGPVFXVisibleRangeMeters;

	public readonly int BloodmoonGPVFXVisibilityCheckTickInterval;

	public readonly float BloodmoonGPTotemMissionTriggerRadiusMeters;

	public readonly uint BloodmoonGPRewardBuffID;

	public readonly int BloodmoonGPMaxWolfHpUiCount;

	public readonly float HorseJumpHeight;

	public readonly bool EnableRescueAssist;

	public readonly float RescueAssistTimeRatio;

	public readonly bool RescueAssistEnableSkillBonusRatio;

	public readonly float CarryPositionOffsetYMale;

	public readonly float CarryPositionOffsetYFemale;

	public readonly float CarryMeleeFireAngle;

	public readonly string DamageFontSizeConfig;

	public readonly string NonHeadDamageFontSizeConfig;

	public object Clone()
	{
		return null;
	}
}
