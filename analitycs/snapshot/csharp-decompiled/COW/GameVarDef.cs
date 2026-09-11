using COW.GamePlay;

namespace COW;

public class GameVarDef
{
	public static bool EnableLoadLocalFileInfoCache;

	public static readonly bool AllowAutoDownloadInDownloadingState;

	public static readonly float ReservedFloat01;

	public static readonly float ReservedFloat02;

	public static readonly float ReservedFloat03;

	public static readonly float ReservedFloat04;

	public static readonly int ReservedInt01;

	public static readonly int ReservedInt02;

	public static readonly int ReservedInt03;

	public static readonly int ReservedInt04;

	public static readonly long ReservedLong01;

	public static readonly long ReservedLong02;

	public static readonly long ReservedLong03;

	public static readonly long ReservedLong04;

	public static readonly bool ReservedBool01;

	public static readonly bool ReservedBool02;

	public static readonly bool ReservedBool03;

	public static object ReservedObject01;

	public static object ReservedObject02;

	public static object ReservedObject03;

	public static object ReservedObject04;

	public static readonly bool MailDelayCreate;

	public static readonly bool ReservedBool04;

	public static readonly bool EnableBugReportTime;

	public static readonly bool EnableResetScheduleNotifyAsync;

	public static readonly bool DelayCreateStartGame;

	public static readonly bool GachaProtoSendImmediately;

	public static readonly bool CustomRoomDelayRefreshPlayerList;

	public static readonly bool CustomRoomNoClearRefreshPlayerList;

	public static readonly bool EnableTriggerFountainAsyncLoad;

	public static readonly bool ResetJumpStartInfoInFalllingStateEnter;

	public static readonly bool EnableKeepCreepOnTransientFalling3P;

	public static readonly float HighFallActionSpeed;

	public static readonly bool EnableLoadImageImmediately;

	public static readonly bool EnableFountainNoParent;

	public static readonly bool EnableDownloadCentreDownloadedSizeInNewWay;

	public static readonly bool CalendarMgrPreferEnhancedEventId_iOS;

	public static readonly bool CalendarMgrLookupEnhancedEventId_iOS;

	public static readonly bool EnableNewHPStateShowWay;

	public static readonly bool EnablePlanarReflectionPro;

	public static float AssistantRaycastFPPOffsetDis;

	public static readonly uint OccupationUpdateWeaponContinueHitDetalTime;

	public static readonly bool EnableIconCDNMatchInString;

	public static readonly bool BRUpgradeSysHideAllIfNotOpen;

	public static readonly int TutorialUpgradeTabMaxShowCount;

	public static readonly bool EnableAirphaseWeaponSkinLazyLoad;

	public static readonly bool EnableBackWeaponSkinLazyLoad;

	public static readonly bool EnableStreamerBasedWeaponSkinLazyLoad;

	public static readonly bool EnableWeaponSkinCacheLazyLoad;

	public static readonly bool EnableDownloadVersionLocalFileinfoOptimize;

	public static readonly bool EnableStartupKeyValueFieldCache;

	public static readonly bool EnableLazyInitLobbySceneEdit;

	public static readonly bool EnableLazyInitLobbySparkPet;

	public static readonly bool EnableLazyLoadSparkPetConfig;

	public static readonly float MultiPlayerEmoteDriverDistance;

	public static readonly float MultiPlayerEmotePassengerDistance;

	public static readonly float MultiPlayerEmotePassengerMaxHeight;

	public static readonly float MultiPlayerEmoteViewDistance;

	public static readonly bool EnablePlayerHurtEffectAysncLoadInNewWay;

	public static readonly bool EnableDecalTextureOverride;

	public static float ReviveCardBubbleFillTime;

	public static float ReviveCardBubbleRepeatFillTime;

	public static string HelpMeQuickChatId;

	public static float HelpMeQuickChatMuteCD;

	public static bool EnableInternalSetRotation;

	public static readonly float RunSpeed;

	public static readonly float DashSpeedScale;

	public static readonly float CrouchSpeed;

	public static readonly float CreepSpeed;

	public static readonly float DieingSpeed;

	public static readonly float StropSpeed;

	public static bool StropFallingResetSpeed;

	public static readonly float CatapultSpeed;

	public static readonly bool Reset3PInCatapult;

	public static readonly float StropUseCooldown;

	public static readonly float StropFOV;

	public static readonly float StropFOVFadeDuration;

	public static readonly float CannonFOV;

	public static readonly bool GetEVDataInThread;

	public static readonly bool EnableEVDataEnc;

	public static readonly bool StopAnimEffectWhenStartOnBoard;

	public static readonly bool EnableCybermushroomscanDoCache;

	public static readonly float ActiveSkillCameraFOV;

	public static readonly bool EnableBackGroundOptimize;

	public static float SwitchStropCD;

	public static float SwitchStropHideUITime;

	public static bool Enable1pInGameAnmatorAlwaysAnim;

	public static readonly bool FixCullingTransformTPose;

	public static bool EnableFixRemmapIndexOutOfBounds;

	public static bool FixUGCAudioBug;

	public static readonly bool EnableAutoSaveSmapsWhenCrash;

	public static readonly bool TryFixAudioConfigurationManagedCallbackCrash;

	public static float SwitchStropLerpPosTime;

	public static bool EnableWwisePostRunningInfoEventOpt;

	public static bool EnableWwiseEndCallBackOpt;

	public static bool EnableBetaOptionalAstcForEtc;

	public static bool EnableInGameLikeAudioAysncPlay;

	public static bool EnableInGamePurchaseAudioAsync;

	public static bool EnableSwimSoundAsyncPlay;

	public static uint StropBoostMax;

	public static float StropBoostCooldown;

	public static bool StropDashChangeCameraOffset;

	public static bool EnableFireOnStrop;

	public static bool EnableStropDash;

	public static bool EnableStropAimAssist;

	public static bool EnableBeAimAssistWhenStropDash;

	public static bool FollowEmoteSwitch;

	public static int FollowEmoteHudClose;

	public static int FollowEmoteHeadCount;

	public static float FollowEmoteDriverDistance;

	public static float FollowEmotePassengerDistance;

	public static float FollowEmoteMaxHeightDiff;

	public static float FollowMoveEmoteTriggerRange;

	public static bool EnableFollowEmoteQueueClientStateSync;

	public static bool EnableFollowEmoteRenderInterpolation;

	public static float FollowEmoteRenderSnapDistance;

	public static int FollowEmoteRenderSegmentMinDenom;

	public static bool EnableActiveSkillOnSlide;

	public static float SlideSamplingDis;

	public static float SlideBigMapSamplingDis;

	public static int SlideBigMapSamplingMaxStep;

	public static bool EnableSlideScanGreenHint;

	public static float RefreshSlideScanHintCD;

	public static float SlideScanRadius;

	public static uint GuideGetOffSlideCnt;

	public static float GuideGetOffSlideTriggerTime;

	public static bool FixCrouchFireAnim;

	public static bool RefreshSniperMemoryStateOnCSRoundChanged;

	public static bool CSShopSkinElementAsync;

	public static bool HorizontalDisplayOfStoreWeaponIcons;

	public static bool WeaponPropertyItemShowValue;

	public static float StoreShowImageItemSpriteRotationZ;

	public static float StoreShowImageItemSpriteScale;

	public static bool StoreShowImageItemSpriteFlipX;

	public static bool EnableStopAudioMusicOnGameDestory;

	public static readonly float ZiplineUseCD;

	public static readonly float ZipLineCancelCD;

	public static readonly float ShoalSpeedScale;

	public static readonly float SimGravityY;

	public static readonly float LightLaserTime;

	public static readonly float MaxJumpHeight;

	public static readonly float HighFallingHeight;

	public static readonly float FountainHighFallingHeight;

	public static readonly float StandingColliderHeight;

	public static readonly float CrouchingColliderHeight;

	public static readonly float MovingCrouchingColliderHeight;

	public static readonly float LowGravityAreaFallingHeight;

	public static readonly float SniperStandingColliderHeight;

	public static readonly float SniperStandingColliderRadius;

	public static readonly float SniperCrouchingColliderHeight;

	public static readonly float SniperCrouchingColliderRadius;

	public static readonly float SniperCreapingColliderYPos;

	public static readonly float SniperCreepingColliderHeight;

	public static readonly float SniperCreepingColliderRadius;

	public static readonly float PlayerHudNameInSkyOffset;

	public static readonly bool OpenCDNDownloadInAstc;

	public static readonly bool PreCacheReviveWeaponSkins;

	public static readonly bool UseProfileWeaponDictionary;

	public static readonly float PlayerACEFirstVFXContinueTime;

	public static readonly float PlayerACESecondVFXDelayTime;

	public static readonly float PlayerACESoundDelayTime;

	public static readonly float Naru2BigitemCreateMiniFlashTime;

	public static readonly float Naru2BigItemCreateMiniShowTime;

	public static readonly float Naru2BigItemShowLodSqr;

	public static readonly float Naru2HiraishinTeleportDistanceSqr;

	public static readonly string Naru2BigItemDefaultIcon;

	public static readonly float Naru2EggEggEasterTelescopeContainerSearchRange;

	public static readonly float Naru2EggEggEasterTelescopeContainerSearchInterval;

	public static readonly string IsInSearching;

	public static readonly float Hudsettingright;

	public static readonly float Hudsettingleft;

	public static readonly float Hudsettingtop;

	public static bool MallProtoParallelSending;

	public static bool VaultProtoParallelSending;

	public static bool WeaponProtoParallelSending;

	public static bool BooyahPassProtoParallelSending;

	public static bool ProfileProtoParallelSending;

	public static readonly float Hudsettingbuttom;

	public static string HudSettingBtnScaleRange;

	public static float HudSettingBtnAlphaMin;

	public static float HudSettingShareCodeGenCd;

	public static float HudSettingShareCodeDownloadCd;

	public static bool HudSettingEnableShareCodeVersionCheck;

	public static bool HudSettingChangeButtonColorInGame;

	public static bool EnableUGCScrollViewCulling;

	public static float CSCoinPositionOffsetX;

	public static float TrainingZoneQuitPositionOffsetX;

	public static float TrainingZoneQuitPositionOffsetY;

	public static string CollectionTrialPrivilegeShowPosition;

	public static uint LoadoutAttackStrengthenPrice;

	public static readonly bool ObPlayerCanShowRevive;

	public static readonly bool DisableMakePixelPerfectForLowQuality;

	public static readonly float LobbyshowAllReadyVfx;

	public static readonly float FallingTimeToCheckHighFalling;

	public static readonly float FallingHeightScaleToCheckHighFalling;

	public static readonly float FreeMoveAngularSpeed;

	public static readonly float BPSkipUnlockCd;

	public static readonly float FreeMoveAngularSpeedStand;

	public static readonly float FreeMoveAngularSpeedCrouch;

	public static readonly float FreeMoveAngularSpeedCreep;

	public static readonly float FreeMoveAngularSpeedKnockDown;

	public static readonly float InCarColliderHeight;

	public static readonly bool EnableCacheOberverOnDead;

	public static readonly bool EnableAsyncHeadPicEffect;

	public static readonly float SkyDivingSpeedDelta;

	public static readonly float SkyDivingRotationSpeed;

	public static readonly float SkyDivingTimeToOpenParachute;

	public static readonly float SkySurfingRotationSpeed;

	public static readonly float SkySurfingSpeedDelta;

	public static readonly float SkyDashingRotationSpeed;

	public static readonly float SkySurfingStanceButtonOffHeight;

	public static readonly bool UseLStreamer;

	public static readonly bool EnableLoadABSceneAdditiveTimer;

	public static readonly uint LoadABSceneAdditiveTimer;

	public static readonly bool EnableStreamerUnloadTimer;

	public static readonly int EnableStreamerUnloadCount;

	public static readonly uint UnloadTimer;

	public static readonly bool LoadGppLibSOToABHotUpdate;

	public static readonly bool EnableCopyAndUnzipUnzipErrorRepeatCopy;

	public static readonly bool EnableIceWallWrapper;

	public static readonly bool CheckBpEscIsInActive;

	public static readonly bool AsyncLoadIceWallWrapper;

	public static readonly bool UseLContainer;

	public static readonly bool AsyncLoadLContainer;

	public static readonly string GGPSDKPackageNameList;

	public static readonly bool EnableAstcHotUpdate;

	public static readonly float ParachutingMaxAngleTilt;

	public static readonly float ParachutingMinAngleTilt;

	public static readonly float ParachutingTiltSpeed;

	public static readonly float ParachutingMaxAngleRoll;

	public static readonly float ParachutingMinAngleRoll;

	public static readonly float ParachutingRollSpeed;

	public static readonly float ParachutingTurningRadius;

	public static readonly float ParachutingOpenDuration;

	public static readonly int DefaultBagCapacity;

	public static readonly float HitDamageRatioHead;

	public static readonly float HitDamageRatioBody;

	public static readonly float HitDamageRatioLimb;

	public static readonly float HitDamageRatioVehicle;

	public static readonly float HitDamageRatioSniperExtension;

	public static readonly float SkyDivingCameraUpOffset;

	public static readonly float SkyDivingCameraBackOffset;

	public static readonly float OnBoardCameraUpOffset;

	public static readonly float OnBoardCameraBackOffset;

	public static readonly float SkySurfingCameraUpOffset;

	public static readonly float SkySurfingCameraBackOffset;

	public static readonly float ParachutingCameraUpOffset;

	public static readonly float ParachutingCameraBackOffset;

	public static readonly float SkyDivingCameraShakeFactor;

	public static readonly float ParachutingCameraShakeDuring;

	public static readonly float ParachutingCameraShakeFactor;

	public static readonly float LandingCameraShakeDuration;

	public static readonly float LandingCameraShakeFactor;

	public static readonly float GroupInviteCoolDown;

	public static readonly float AnimSpeedRunFist;

	public static readonly float AnimSpeedRunPistol;

	public static readonly float AnimSpeedRunGun;

	public static readonly float AnimSpeedRunAWM;

	public static readonly float AnimSpeedDash;

	public static readonly float AnimSpeedCrouch;

	public static readonly float AnimSpeedCrawl;

	public static readonly float AnimSpeedFireWalk;

	public static readonly float AnimSpeedFireCrouchWalk;

	public static readonly int AlarmSoundChangeRadius;

	public static readonly float AlarmSoundStartSecound;

	public static readonly float AlarmSoundDuringSecound;

	public static readonly float GunFireBoneDeltaAngeX;

	public static readonly float GunFireBoneDeltaAngeX_Crouch;

	public static readonly float GunFireBoneDeltaAngeZ_Crouch;

	public static readonly float IKBoneRotateSpeed;

	public static readonly float VehicleHitSoundMinSpeedSqr;

	public static readonly int EnableGameVoice;

	public static readonly bool ReleaseMicWhenMute;

	public static readonly bool OpenNewPlayerHud;

	public static readonly bool OpenNewDownloadHandlerWay;

	public static readonly bool LimitPickupItem;

	public static readonly bool EnableExitCommModeWhenHeadsetPlugin;

	public static readonly bool RemoveDeadTeammatesOnMap;

	public static readonly int DurationDeadTeammatesOnMap;

	public static readonly bool ShowTeammateFiringOnMap;

	public static readonly bool ShowEnemyFiringOnMap;

	public static readonly bool ModifyAvatarCode;

	public static readonly bool ModifyAvatarDataCode;

	public static readonly int VegetationNewViewDistance;

	public static readonly float DeadFlySpeedByCar;

	public static readonly float AnimSpeedSwim;

	public static readonly float DynamicSplashOffsetY;

	public static readonly string CSTutorialPopupCDN;

	public static readonly bool EnableUpdateAxisTouchOptimize;

	public static readonly bool EnableVersionInfoSaveFileOptimize;

	public static readonly bool IsEnhanceTeammateDown;

	public static readonly int PartyGameMoviePlayTime;

	public static readonly int PartyGameSoloDancePosMarkCloseDistance;

	public static readonly int PartyGameSoloDanceCheckIsInZoneDistance;

	public static readonly float PartyGameSoloDanceInvitationInterval;

	public static readonly float PartyGameSoloDanceInvitationAutoHideTime;

	public static readonly float PartyGameSoloDancePosMarkAutoHideTime;

	public static readonly uint PartyGameSoloDanceDefaultEmoteId;

	public static readonly bool RegisterCheckNewbiePickNewbie;

	public static readonly float PartyGamMusicBeatIntervalThreshold;

	public static readonly float SwitchWeaponInterval;

	public static readonly bool SingersBModeNotShowClothForLowest;

	public static readonly bool EnableOptionalDownloadData;

	public static readonly bool EnableOptionalMapRefOptionalRedefId;

	public static readonly bool EnableOptionalDownloadRecursiveDependencies;

	public static readonly bool ChangeToWalkingWhileGetOnVehicleInSkyState;

	public static readonly bool EnableRUDPFastResend;

	public static readonly int OptionalAutoDownLoadStandard;

	public static readonly bool EnableCdnCacheInAdvance;

	public static readonly int CacheCDNImageSizeMinBytes;

	public static readonly int InteractionInfoMaxLimit;

	public static readonly bool EnableLevelClimbTriggerOnStart;

	public static readonly int UDP_MTU_LIMIT;

	public static readonly double UDP_RECONNECT_DELAY;

	public static readonly double UDP_RESEND_TIMEOUT;

	public static readonly double UDP_HELLO_RESEND_TIMEOUT;

	public static readonly int UDP_HELLO_MAX_RESEND_COUNT;

	public static readonly int UDP_MAX_RESEND_COUNT;

	public static readonly int UDP_MSG_KEY_MIN;

	public static readonly int UDP_MSG_KEY_MAX;

	public static readonly int UDP_MSG_KEY_MID;

	public static readonly bool RUDP_C2S_ACK_ENC_ENABLE;

	public static readonly bool OpenStreamOptionalMove;

	public static readonly bool OpenStreamIconCDNMove;

	public static readonly bool IsTurnOnBuffHUDSupportBuffECA;

	public static readonly bool EnableBuffHUDRepositionOptimize;

	public static readonly int RUDPFastResendTimeoutMaxStepCount;

	public static readonly float RUDPFastResendTimeoutStepInterval;

	public static readonly int HandleUDPPacketsFrameNumLowest;

	public static readonly int HandleUDPPacketsFrameNumLow;

	public static readonly int HandleUDPPacketsFrameNumUltra;

	public static readonly int HandleUDPPacketsMinPerFrameLowest;

	public static readonly int HandleUDPPacketsMinPerFrameLow;

	public static readonly int HandleUDPPacketsMinPerFrameUltra;

	public static readonly bool EnableCollectionEffect;

	public static readonly bool EnableQualityNewIsEffect;

	public static readonly bool EnableUnSerializeRudpMsgThread;

	public static readonly bool EnableSerializeRudpMsgThread;

	public static readonly uint AutoExpandBrGroupModeLevel;

	public static readonly uint NewbieGroupModeSoloUILevel;

	public static readonly bool HandleUDPPacketsTimeLimit;

	public static readonly uint HandleUDPPacketsTimeLimitMS;

	public static readonly float HandleUDPPacketsWaitTimeMaxMs;

	public static readonly bool HandleUDPPacketsTimeLimitEnableLog;

	public static readonly uint HandleUDPPacketsTimeLimitMSForDeath;

	public static readonly bool HandleUDPPacketsWaitTimeMax;

	public static readonly bool HandleUDPPacketsWaitTimeMaxDelayEnable;

	public static readonly float HandleUDPPacketsWaitTimeMaxDelaySec;

	public static readonly bool EndGameEventLogRecordContent;

	public static readonly bool EndGameEventLogComplete;

	public static readonly bool DelaySendEndGameEventLog;

	public static readonly bool DelayDestroyPlayer;

	public static readonly bool DelayCreatePlayerSetMaps;

	public static readonly bool NoCreateAiBevTreeFor3P;

	public static readonly float CSRankLoadingTimeLength;

	public static readonly float BRRankLoadingTimeLength;

	public static readonly int CupApplyNoteMax;

	public static readonly int CupInviteNoteMax;

	public static readonly uint EmptySkillId;

	public static readonly float LobbyEnterItemSizeRatio;

	public static readonly float TransferLeaderCd;

	public static readonly string RankGroup;

	public static readonly string CSRankGroup;

	public static readonly string PeriodicRankGroup;

	public static readonly uint RankingTokenID;

	public static readonly bool EnableChangeResolutionHippo;

	public static readonly bool DisableReset3dCameraByPreviewComp;

	public static readonly float CarCrashSpeedScale;

	public static readonly float CarCrashAngle;

	public static readonly float VehicleKillPersonMinSpeedSqr;

	public static readonly float CarCrashDamageScaleToPlayer;

	public static readonly float CarCrashDamageScaleToTeamate;

	public static readonly float CarCrashDamageScaleToVehicle;

	public static readonly float CarCrashDamageScaleToPlayerInVehicle;

	public static readonly float CarCrashDamageScaleWhenHitWall;

	public static readonly float CarCrashProtectTimeForHitPlayer;

	public static readonly float CarCrashProtectTimeForHitCar;

	public static readonly float CarCrashProtectTimeForHitWall;

	public static readonly bool UseNewCarCrash;

	public static readonly float SwapWeaponCD;

	public static readonly bool EnableRebateCard;

	public static readonly bool EnablePaymentBundle;

	public static readonly bool PaymentPriceShowLoading;

	public static readonly bool PreferExternalUnityPaymentShop_ThirdParty;

	public static readonly string PaymentShopFallbackStrategy;

	public static readonly float SilenceWeaponHintRange;

	public static readonly string ForceBlackBloodRegions;

	public static readonly string OptionalBlackBloodRegions;

	public static readonly bool DisableWebViewWindow;

	public static readonly bool DisableWebViewScaling;

	public static readonly bool DisableWebViewCookie;

	public static readonly bool DisableWebViewJavascriptInjection;

	public static readonly bool DisableWebViewMediaManipulationOnHideAndShowByJavaScript;

	public static readonly string WebPageFallbackStrategy_iOS;

	public static readonly string WebPageFallbackStrategy_Android;

	public static readonly bool WebView_OnlyAutoPlayMediaWithWIFI_iOS;

	public static readonly bool WebView_OnlyAutoPlayMediaWithWIFI_Android;

	public static readonly bool WebViewWindow_AllowRedirectionToExternalBrowser;

	public static readonly bool WebViewModUserAgent_iOS;

	public static readonly bool WebViewModUserAgent_Android;

	public static readonly string WebViewFallbackUrl_Android;

	public static readonly bool WebViewHideIfFallbackFails_Android;

	public static readonly string WebViewDefaultFallbackUrlForBlacklistedDomain;

	public static bool AndroidWebViewUseActivity;

	public static bool AndroidWebView_AllowAudioCapture;

	public static bool AndroidWebView_AllowVideoCapture;

	public static string AndroidWebView_WhiteListDomains_SystemCalendar;

	public static bool AndroidWebViewActivity_ProcessPermissionRequests;

	public static bool AndroidWebViewActivity_IgnoreInsetsOnTouch;

	public static bool AndroidWebViewActivity_IgnoreInsetsDuringLayoutIfWindowed;

	public static bool AndroidWebViewActivity_NormalizeCoords_OnTouch;

	public static bool AndroidWebViewActivity_EnforceTransparentBackground_26;

	public static bool AndroidEnhancedNetworkType;

	public static bool UseMsdkRegForm;

	public static string CheckWebViewBeforeMsdkRegForm_Regions;

	public static string SkipMsdkRegFormIfWebViewDisabled_Regions;

	public static string ShowLoadingForMsdkRegForm_Regions_iOS;

	public static string ShowLoadingForMsdkRegForm_Regions_Android;

	public static bool ForceWebViewAuth_Twitter_iOS15AndAbove;

	public static int Auth_VK_MinIOSVersion;

	public static int AuthByWeb_FB_MinIOSVersion;

	public static int VK_LinkSharingWorkaround_iOS;

	public static int VK_LinkSharingWorkaround_Android;

	public static int VK_ImageSharingWorkaround_iOS;

	public static int VK_ImageSharingWorkaround_Android;

	public static readonly float UavRange;

	public static readonly float UavModelDisplayRange;

	public static readonly float UavRevealTime;

	public static readonly float SwimSpeed;

	public static readonly float SwimSurfSpeed;

	public static readonly bool CharacterRecvShadow;

	public static readonly float SwimDashScale;

	public static readonly bool EnableLightmapInLowQuality;

	public static readonly bool CleanFFAntiState;

	public static readonly bool EnableSkySurfing;

	public static readonly float EatMushroomTime;

	public static readonly float UseArmortoolsTime;

	public static readonly float UseInfoBoxTime;

	public static readonly int NickNameMaxLength;

	public static readonly bool Enable3PAsyncLoadSkateboard;

	public static readonly bool Enable1PAsyncPoolSkateboard;

	public static readonly bool EnableClimb;

	public static readonly bool EnableClimbVehicleHighCheck;

	public static readonly bool EnableMoveDirectionCheckInClimb;

	public static readonly bool EnableCrossOverOnJumpAscent;

	public static readonly float CrossOverJumpAscentMaxDuration;

	public static readonly float CrossOverJumpAscentMinVSpeed;

	public static readonly float CrossOverJumpAscentForwardMinDot;

	public static readonly float CheckTimeAfterJump;

	public static readonly float CrossOverJumpAscentPhysicsCheckInterval;

	public static readonly float CrossOverJumpAscentPhysicsCheckMoveThresholdSqr;

	public static readonly float CrossOverJumpAscentPhysicsCheckForceTimeLeft;

	public static readonly float CrossOverAnimTime;

	public static readonly float CrossOverJumpTimeDefault;

	public static readonly float CrossOverFallTimeDefault;

	public static readonly float ClimbCameraDuration;

	public static readonly float AskChangeSeatCoolDown;

	public static readonly float WaitingForConfirmationTimeout;

	public static readonly float GunTrace3PMinDistanceSqr;

	public static readonly float GunTrace3PMinDistanceSqrForWaterGunBoom;

	public static readonly float GunTrace3PTimeInterval;

	public static readonly bool ChangingOcclusionTransparency;

	public static readonly bool ChangeOcclusionTransparencyWhenMoving;

	public static readonly bool ChangeOcclusionTransparencyWithoutLowQuality;

	public static readonly float ChangingTransparencyTimeLimit;

	public static readonly float ChangingTransparencyStep;

	public static readonly float ChangingTransparencyTarget;

	public static readonly bool SaveLocationInPlatform;

	public static readonly ulong HeatEndTime;

	public static readonly ulong VersionUpDateTime;

	public static readonly float GunTrace3PTimeIntervalInMax;

	public static readonly bool MAXQualityAB;

	public static readonly float IPMusicRotateAnglePerSecondMax;

	public static readonly bool DisableMovieBG;

	public static readonly float GunTrace3PMaxDistance;

	public static readonly float GunTraceHitDistanceThreshold;

	public static readonly uint HeadShotGunTraceColorHex;

	public static readonly float FastReviveAfterBooyah;

	public static readonly bool EnableCustomRoom;

	public static readonly bool EnableCustomRoomAuthority;

	public static readonly int AbbreviationMaxCharacters;

	public static readonly int DebugLogDeleteTimeSecondsLimit;

	public static readonly int PCMDeleteTimeSecondsLimit;

	public static readonly string AbbreviationSeparator;

	public static readonly int CustomRoomCSShopMaxCost;

	public static readonly int CustomRoomCSShopCostInterval;

	public static readonly int CustomRoomCSMaxRound;

	public static readonly string CustomRoomCSInitCoin;

	public static readonly int EsportsSplashWidth;

	public static readonly int EsportsSplashHeight;

	public static readonly int EsportsSplashPosX;

	public static readonly int EsportsSplashPosY;

	public static readonly bool UsingLobbyInviteInRoom;

	public static readonly int VeteranActivateVeteranReminderTime;

	public static readonly bool EnableLateInitGameVoice;

	public static readonly uint MaxReleaseCDNSetTimesForEasyList;

	public static readonly bool AutoTaskSettingSyncOpen;

	public static readonly bool EnableLUTHighQuality;

	public static readonly bool EnableLUTMidQuality;

	public static readonly bool HighFPSSetting;

	public static readonly float VehicleSkyDivingCameraUpOffset;

	public static readonly float VehicleSkyDivingCameraBackOffset;

	public static readonly float VehicleParachutingCameraUpOffset;

	public static readonly float VehicleParachutingCameraBackOffset;

	public static readonly float VehicleSkyDivingMinVSpeed;

	public static readonly float VehicleSkyDivingMaxVSpeed;

	public static readonly float VehicleSkyDivingMinHSpeed;

	public static readonly float VehicleSkyDivingMaxHSpeed;

	public static readonly float VehicleSkyDivingRotationSpeed;

	public static readonly float VehicleParachutingMinHSpeed;

	public static readonly float VehicleParachutingMaxHSpeed;

	public static readonly float VehicleParachutingMinVSpeed;

	public static readonly float VehicleParachutingMaxVSpeed;

	public static readonly float VehicleParachutingRollSpeed;

	public static readonly bool EnableShootTraceAdjustment;

	public static readonly float ShootTraceAdjustmentDistanceThreshold;

	public static readonly float RejoinMatchWaitingForSteaming;

	public static readonly float UGCCommonRejoinMatchWaitingForSteaming;

	public static readonly float SpecialWaitingLandCloseLoadingDelay;

	public static readonly float SpecialWaitingLandCloseLoadingDelay_Low;

	public static readonly float SpecialWaitingLandCloseLoadingDelay_High;

	public static readonly bool SpecialWaitingIslandStreamerSyncLoad;

	public static readonly float SpecialWaitingIslandStreamerCheckInterval;

	public static readonly bool SpecialWaitingIslandStreamerShrinkRange;

	public static readonly string SpecialWaitingIslandStreamerShrinkRangeStr;

	public static readonly bool WinterlandStreamerShrinkRange;

	public static readonly string WinterlandStreamerShrinkRangeStr;

	public static readonly float SlopeLimit;

	public static readonly float StepOffset;

	public static readonly float SkinWidth;

	public static readonly float CCTRadiusNormal;

	public static readonly float CCTRadiusCreep;

	public static readonly float CCTRadiusUGCNormal;

	public static readonly float CCTRadiusUGCCreep;

	public static readonly float CreepSlopeLimit;

	public static readonly float CreepStepOffset;

	public static readonly float CreepColliderHeight;

	public static readonly float BoardSurfingColliderHeight;

	public static readonly bool EnableBoardSurfingResizeCCT;

	public static readonly float LobbyAdAutoScrollTime;

	public static readonly float GachaAdAutoScrollTime;

	public static readonly float CDNAutoScrollTime;

	public static readonly float DelayShowBreathEffect;

	public static readonly float DelayShowReviveTips;

	public static readonly float GachaClothTabAutoScrollTime;

	public static readonly float IAPCDNAdAutoScrollTime;

	public static readonly float SpectatorCameraHeight;

	public static readonly float SpectatorCameraHDis;

	public static readonly float SpectatorCameraAngle;

	public static readonly string RoomOBFreeCamEnabled;

	public static readonly bool HideScreenVfxByUIGroup;

	public static readonly string RoomOBUsingSingleItem;

	public static readonly float RoomOBCameraHeightMin;

	public static readonly float RoomOBCameraHeightMax;

	public static readonly float RoomOBNearByDis;

	public static readonly float RoomOBNearByPlayerRefreshRate;

	public static readonly float RoomOBFreeCamMoveMinSpeed;

	public static readonly float RoomOBFreeCamMoveMaxSpeed;

	public static readonly float RoomOBFreeCamMoveDeltaSpeed;

	public static readonly float RoomOBFreeCamHeight;

	public static readonly float RoomOBFreeCamHDis;

	public static readonly float RoomOBFreeCamAngle;

	public static readonly bool RoomOBFreeCamGroundClampEnable;

	public static readonly float RoomOBFreeCamGroundClearance;

	public static readonly float SPHudNameScale;

	public static readonly float SPHudNameFixedRadius;

	public static readonly float SPHudNameFreeRadius;

	public static readonly float SPHudNameShiftRadius;

	public static readonly float SPHudNameSightingAlpha;

	public static readonly float SpectatorNamePlateScaleOffset;

	public static readonly float SpectatorNamePlateScaleOffsetMiniMap;

	public static readonly float SpectatorNamePlateScaleMiniMapCSMode;

	public static readonly float SpectatorBombZoneScaleOnMiniMap;

	public static readonly float SpectatorBombZoneScaleOnBigMap;

	public static readonly float SPCSHudShowTeamExtraInfoTime;

	public static readonly float SPMatchResultScrollViewMoveSpeed;

	public static readonly float SPHudNameMinAlpha;

	public static readonly float SPHudNameMaxAlpha;

	public static readonly float SPHudNameStartChangeAlphaDistance;

	public static readonly float SPHudNameMinAlphaDistance;

	public static readonly float FireSoundMiddleSqrRange;

	public static readonly float FireSoundLongSqrRange;

	public static readonly float BulletDropSoundDelay;

	public static readonly int GuestPlayLadderMatchLevelLimit;

	public static readonly int OildrumMaxDurability;

	public static readonly int ReactorMaxDurability;

	public static readonly float ReactorExplodeTime;

	public static readonly int OildrumExplodeRadius;

	public static readonly int OildrumExplodeMaxDamage;

	public static readonly int OildrumExplodeMinDamage;

	public static readonly int OildrumExplodeThreshold;

	public static readonly float SmokedrumUsePrepareTime;

	public static readonly float AmmoBoxUsePrepareTime;

	public static readonly float SkyDivingForceToOpenParachuteHeight;

	public static readonly bool SpeedRoyalBGMEnable;

	public static readonly float SpeedRoyalBGMDelay;

	public static readonly int StropFallingDamageMax;

	public static readonly bool EnableTreasureMap;

	public static readonly bool EnableBountyContract;

	public static readonly bool DisplayLocalizedPriceForIAP;

	public static readonly string IAPProductsVersion;

	public static readonly string PaymentBundlesVersion;

	public static readonly string RebateCardsVersion;

	public static readonly bool SpawnObjectNoPlacementOpen;

	public static readonly bool NoCarepackageOpen;

	public static readonly float NoCarepackageOffset;

	public static readonly bool TreasureHuntVisibleTriggerOpen;

	public static readonly float TreasureHuntOpenFrontDoorTime;

	public static readonly float TreasureHuntUnderTreasuryRange;

	public static readonly float TreasureHuntUnderTreasuryStreamerExtraRange;

	public static readonly float TreasureHuntDelayDetachBackDoorTime;

	public static readonly float MinimapFullEdgeUIFXTime;

	public static readonly float TreasureHuntMapIconUIFXTime;

	public static readonly string TreasureHuntSpecialItemIds;

	public static readonly string TreasureHuntSpecialItemIdKeys;

	public static readonly string TreasureHuntSpecialItemIdIcons;

	public static readonly bool TreasureHuntReleaseMemoryForMatchEndDontDestory;

	public static readonly float TreasureHuntNormalTreasureDigTime;

	public static readonly float TreasureHuntNormalTreasureDigAnimTime;

	public static readonly float SpectatorCameraMoveSpeed;

	public static readonly float SpectatorCameraFastMoveSpeedRatio;

	public static readonly float SpectatorCamreraRotateSpeed;

	public static readonly float SpectatorCameraMoveAcceleration;

	public static readonly float SpectatorCameraMoveDeceleration;

	public static readonly float SpectatorCameraMoveSpeedRatioMin;

	public static readonly float SpectatorCameraMoveSpeedRatioMax;

	public static readonly float SpectatorCameraRotateSpeedRatioMin;

	public static readonly float SpectatorCameraRotateSpeedRatioMax;

	public static readonly float SpectatorCameraSpeedChangeDelta;

	public static readonly float SpectatorCameraMoveSpeedUp;

	public static readonly float SpectatorCameraRotateSpeedUp;

	public static readonly float SpectatorCameraMoveSlowDown;

	public static readonly float SpectatorCameraRotateSlowDown;

	public static readonly float SpectatorCameraRotate360Time;

	public static uint LimitClothUnlockLevel;

	public static bool ChatChannelShowTitleEffects;

	public static bool IsNewPGCResRefEnabled;

	public static bool IsNewPGCTagDownloadEnabled;

	public static readonly float SpectatorSoundRange;

	public static bool UMAMeshOptimize;

	public static readonly float AirlineStartDistance;

	public static readonly float FootballRadius;

	public static readonly float FootballRadius_SnowMan;

	public static readonly float FootballRadiusGrowUp;

	public static readonly float FootballRadiusGrowUpSnowMan;

	public static readonly float FootballRadiusMax;

	public static readonly float FootballRadiusSnowManReborn;

	public static readonly float FootballBackOffsetFactor;

	public static readonly float FootballUpOffsetFactor;

	public static readonly float FootballDuration;

	public static readonly float FootballStartMinSpeed;

	public static readonly float FootballStartMaxSpeed;

	public static readonly float FootballSpeedYFloor;

	public static readonly float FootballSpeedBounceFade;

	public static readonly float FootballSpeedBounceFadeAfterGoals;

	public static readonly float FootballSpeedBounceFadeXZ;

	public static readonly float FootballLauncherHAngleMax;

	public static readonly float FootballLauncherVAngleMax;

	public static readonly float FootballAdjustAccForward;

	public static readonly float FootballAdjustAccRight;

	public static readonly float FootballAdjustAccForward_SnowMan;

	public static readonly float FootballAdjustAccRight_SnowMan;

	public static readonly float FootballAdjustAccForward_RushingPets;

	public static readonly float FootballAdjustAccRight_RushingPets;

	public static readonly float FootballSpeedBounceFadeXZ_RushingPets;

	public static readonly float FootballRadiusGrowUp_RushingPets;

	public static readonly float FootballRadiusMax_RushingPets;

	public static readonly string FFAntihackDefenceLevel;

	public static readonly bool FFAntihackLightInitOnThread;

	public static readonly bool EnableCustom;

	public static readonly int CarePackageMaxNum;

	public static readonly bool VehicleMissileUsingPlayerAimUI;

	public static readonly bool NewNotchForAndroid;

	public static readonly bool LeavesNotchForAndroid;

	public static readonly float NotchForAndroidThreshold;

	public static readonly float NotchSizeForAndroid;

	public static readonly float NotchSizeForiOS;

	public static readonly bool AutoNotchForiOS;

	public static readonly bool AutoNotchForAndroid;

	public static readonly float AutoNotchSizeBiasForiOS;

	public static readonly float AutoNotchSizeBiasForAndroid;

	public static readonly string PGSRecallReadIPRegions_Mobile;

	public static readonly string PGSRecallReadIPRegions_HPE;

	public static readonly string PGSRecallWriteIPRegions_Mobile;

	public static readonly string PGSRecallWriteIPRegions_HPE;

	public static readonly bool PGS_FeatureMasterSwitch;

	public static readonly bool PGS_AllowServerSideAccess;

	public static readonly bool PGS_Achievements;

	public static readonly bool GameCenter_AuthAfterLogin;

	public static readonly bool GameCenter_ShowViewControllerDuringAuthAfterLogin;

	public static readonly ulong GameCenter_AuthFailureCooldownSecs;

	public static readonly bool CanEnemySeeActionCollection;

	public static readonly bool EnableVibrateFeature;

	public static readonly bool NeedSignatureInfo;

	public static readonly bool ObserverCanThumbUp;

	public static readonly bool PanicButtonForLocalNotification;

	public static readonly long LocalNotificationStatsEventLogInterval;

	public static readonly int DaysOfNotifyForAll;

	public static readonly int DaysOfNotifyForRebateCards;

	public static readonly int DaysOfNotifyForFreeGacha;

	public static readonly int NewbieRetentionNotificationHour;

	public static readonly int NewbieRetentionNotificationMinute;

	public static readonly float NewbieRecruitWaitTime;

	public static readonly float NewbieRecruitDisapearTime;

	public static int NewbieTeamUpRecommendPopupCD;

	public static readonly string TimeoutForLocalNotifications_Mins;

	public static readonly bool EnableFirebase;

	public static readonly bool EnableFirebase_Messaging;

	public static readonly bool EnableFirebase_Analytics;

	public static readonly bool EnableFirebase_Crashlytics;

	public static readonly int FirebaseCrashlytics_LogTypes;

	public static readonly bool FirebaseMessaging_UseUserProperties;

	public static readonly bool FirebaseMesaging_UseTopics;

	public static readonly bool disableCacheForFirebaseAnalytics;

	public static readonly bool disableCacheForFirebaseMessaging;

	public static readonly bool UseEventLogForFcmRmtNtfRecv;

	public static readonly bool FcmTokenForceUpdateOnLogin;

	public static readonly int FcmTokenInspectionInterval_Days;

	public static readonly bool FcmTopicForceUpdateOnTokenChanged;

	public static readonly bool FcmTopicUpdateTimeout_Android;

	public static readonly bool FcmTopicUpdateTimeout_iOS;

	public static readonly int FcmTopicUpdateTimeout_S;

	public static readonly bool FcmTopicUpdateRetry;

	public static readonly int FcmTopicUpdateMinRetryInterval_S;

	public static readonly int FcmTopicUpdateMaxRetryInterval_S;

	public static readonly bool ShowIAPBundleForIOSReview;

	public static readonly int MinutesOfNotifyBeforeIAPBundleEnds;

	public static readonly int MaxMinutesOfDelayForRebateCardsNotify;

	public static readonly int MaxMinutesOfDelayForFreeGachaNotify;

	public static readonly int MaxMinutesOfDelayForVeteranActivation;

	public static readonly int MaxMinutesOfDelayForVeteranReminder;

	public static readonly int MaxMinutesOfDelayForNewPlayerLevelUpTask;

	public static readonly int MaxMinutesOfDelayForBooyahDayActivity;

	public static readonly int MaxMinutesOfDelayForBigEventActivityStart;

	public static readonly int MaxMinutesOfDelayForBigEventTemplateActivityStart;

	public static readonly int MaxMinutesOfDelayForLiveTvNotify;

	public static readonly int MaxMinutesOfDelayForEsportsAnnouncementNotify;

	public static readonly int MaxMinutesOfDelayForClanWarNotify;

	public static readonly int MaxMinutesOfDelayForNBCollection;

	public static readonly int DaysFromLastLoginForFriendReunion;

	public static readonly bool EnableVeteranBundle;

	public static readonly bool EnableNewPlayerBundle;

	public static readonly string FriendReunionUrl;

	public static readonly string AvatarGuildUrl;

	public static readonly string AvatarGuildUrlIND;

	public static readonly string AvatarGuildUrlUS;

	public static readonly int Ping1;

	public static readonly int Ping2;

	public static readonly bool PingColor;

	public static readonly int PingCount;

	public static readonly int PingMaxValue;

	public static readonly string ShowTestXHRate;

	public static readonly string ShowTestXHRegion;

	public static readonly int MTUFix;

	public static readonly float ObserverSwitchDelay;

	public static readonly float TeamDefeatedDelay;

	public static readonly float MissileTraceLength;

	public static readonly float ScanAirLineTransparency;

	public static readonly bool SkinOnQualitySwitch;

	public static readonly bool TeammateSkinCheckMemorySwitch;

	public static readonly bool HudTeamAvoidSameUID;

	public static readonly float VehicleJoyStick_Range;

	public static readonly float VehicleJoyStick_ThrottleAndBrakeDeadZoneAngle;

	public static readonly float VehicleJoyStick_TurnDeadZoneAngleStart;

	public static readonly float VehicleJoyStick_TurnDeadZoneAngleEnd;

	public static readonly float VehicleJoyStick_LeftBaseVector_x;

	public static readonly float VehicleJoyStick_LeftBaseVector_z;

	public static readonly string APIToken;

	public static readonly bool ShowEPTopPlayerOnAirplane;

	public static readonly bool ShowEPRankingOnInHud;

	public static readonly bool CanSwimSurfing;

	public static readonly float PingTimeout;

	public static readonly float TCPPingTimeout;

	public static readonly float VehicleSkinHideDelay;

	public static readonly bool ShowSkinOnQualityMiddle;

	public static readonly bool UseAsyncSceneUnload;

	public static readonly bool UseNewUnloadType;

	public static readonly int UnloadType;

	public static readonly int UnloadMaxScene;

	public static readonly int UnloadMaxFreeMemory;

	public static readonly int UnloadMaxFreeMemoryIOS;

	public static readonly int UnloadProcessMemory;

	public static readonly float UnloadProcessMemFreq;

	public static readonly bool OpenProcessMemUnload;

	public static readonly int UnloadMaxUsedMemory;

	public static readonly float UnloadMaxWaitTime;

	public static readonly float UnloadMaxFreeMemFreq;

	public static readonly int AlarmtAvailMemorySize;

	public static readonly int CustomRoomSimulationInfoLevel;

	public static readonly bool EnableUMAGC;

	public static readonly bool EnableUMAGCOnIOS;

	public static readonly bool ShowEPOnWaitland;

	public static readonly bool ShowEPAvatarNormal;

	public static readonly bool ShowEPOnWaitForLow;

	public static readonly float CardCloseTime;

	public static readonly float ClanGroupInviteIconShowTime;

	public static readonly float ClanGroupInviteCoolDownTime;

	public static readonly float ClanWarNewsMapAutoScrollTime;

	public static readonly float ClanWarShowProbability;

	public static readonly int ClanWarReadyCountDown;

	public static readonly ulong ClanWarMatchCD;

	public static readonly int ClanWarGroupMode;

	public static readonly bool LogoutSDKOnBindSuccess;

	public static readonly string SecondaryRegionOn;

	public static readonly float PickupInstantTime;

	public static readonly int MallPurchaseMaxCount;

	public static readonly bool ShowHighFrameRateSetting;

	public static readonly bool InGameFrameSetting;

	public static readonly bool ApplyNewRecommendQualitySettingRule;

	public static readonly bool ShowEnemyFireHint;

	public static readonly bool ShowEnemyFootStepHint;

	public static readonly bool ShowEnemyFireHintDefault;

	public static readonly bool ShowEnemyFootStepHintDefault;

	public static readonly bool EnableFootstepMaterial;

	public static readonly float FootstepMaxAudibleDistanceSqr;

	public static readonly float MissileStartPosOffsetFactor;

	public static readonly bool EnableFileInfoEncryptionAndroid;

	public static readonly bool EnableFileInfoEncryptionIOS;

	public static readonly bool EnableGGPDecryptFailureProtection;

	public static readonly bool IOSTextureHDSupport;

	public static readonly bool IsRedEnvelopeEnable;

	public static readonly int RedEnvelopeMaxPlantNumPerMatch;

	public static readonly bool EnableSparkEvent;

	public static readonly float SparkPetTopTipDisplayTime;

	public static readonly bool EnableFixBackMountWpInvisibleFor3P;

	public static readonly bool EnableTrainingModeExitTriggersWhenTeleport;

	public static readonly bool EnableCheckNullPlayerWhenIterator;

	public static readonly bool EnableForceDelPlayerWhenDestoryPlayerGO;

	public static readonly bool EnableFixRedAimingSpot;

	public static readonly bool EnableArrangeDestroyMultiplePlayer;

	public static readonly bool EnableLobbyCamGyro;

	public static readonly bool EnableLobbyCamGyroDefault;

	public static readonly ulong VisibleFlagInWaitingRoom;

	public static readonly ulong VisibleFlagInWaitingRoomLow;

	public static readonly ulong VisibleFlagInWaitingRoomLowest;

	public static readonly bool EnableNBVisibleFlag;

	public static readonly ulong NBVisibleFlagInWaitingRoom;

	public static readonly ulong NBVisibleFlagInWaitingRoomLow;

	public static readonly ulong NBVisibleFlagInWaitingRoomLowest;

	public static readonly ulong ClothFlagInSoloBrLowest;

	public static readonly ulong ClothFlagInBattleLow;

	public static readonly ulong ClothFlagInReapeLow;

	public static readonly ulong ClothFlagInBattleTeamLow;

	public static readonly bool ClothCacheInWaitingRoomForLow;

	public static readonly bool ClothesFlagsForIOSLowMem;

	public static readonly bool KeepClothFlagSameForBattleAndWaitingRoom;

	public static readonly bool HideTeammateClothesForLowMemInWaitingRoomForBrMode;

	public static readonly bool HideTeammateClothesForLowMemInBattleForBrMode;

	public static readonly ulong ClothFlagInBattleFor32bitUltra;

	public static readonly ulong ClothFlagInBattleTeamFor32bitUltra;

	public static readonly ulong ClothFlagInBattleLowIOS;

	public static readonly bool ClothCacheInWaitingRoomForLowIOS;

	public static readonly ulong ClothFlagInBattleLowIOS12;

	public static readonly bool ClothCacheInWaitingRoomForLowIOS12;

	public static readonly int GachaCouponExpireInfoDaysLimit;

	public static readonly int FFANTIHACKEXT_SPLIT_THRESHOLD;

	public static readonly int UMA1PTextureScaleLow;

	public static readonly int UMA1PTextureScaleTeamLow;

	public static readonly int UMA1PTextureScaleLowIOS;

	public static readonly int UMA1PTextureScaleLowIOS12;

	public static readonly int UMA3PTextureScaleHD;

	public static readonly int UMA3PTextureScaleNormal;

	public static readonly int UMA3PTextureScaleLow;

	public static readonly int UMA3PTextureScaleUltraPlus;

	public static readonly int ShangrilaMaxShowDays;

	public static readonly bool Apply3PSkinOffSwitch;

	public static readonly uint Apply3PSkinMask;

	public static readonly bool OptimizePet;

	public static readonly bool NoPetShowingForOtherTeamsTeammates;

	public static readonly bool NoPet3PActiveAnimShowing;

	public static readonly bool ReleasePetAnimByRefCnt;

	public static readonly bool AsyncLoadPetAnim;

	public static readonly bool ShowTurtleDecreaseDamageArrow;

	public static readonly float VehicleSpeedEulerPerKm;

	public static readonly float SkyDivingTimeToOpenParachuteRebornDelta;

	public static readonly float RebornSkyDivingSpeedRate;

	public static readonly float SkyDivingForceToOpenParachuteHeightRebornDelta;

	public static readonly float MaxAP;

	public static readonly float RevengeInfoHintRange;

	public static readonly float DamageResistPerAP;

	public static readonly float RequestTeamParachuteCDTime;

	public static readonly float RejectTransferTeamParachuteTime;

	public static readonly bool UIInvitationMiniMode;

	public static readonly bool EnableABHotUpdatesFileExistOptimize;

	public static readonly bool EnableABFileFindOptimize;

	public static readonly bool EnableNeedDownloadOptionalBundleOptimize;

	public static readonly float AndoridTextureCDNStroageMB;

	public static readonly float IOSTextureCDNStroageMB;

	public static readonly bool EnableHotUpdateInternalStorage;

	public static readonly int EnableFlagAutoStartDownload;

	public static readonly bool OptionalDownloadOpenCantSaveWithoutFiles;

	public static readonly int OptionalDownloadMaxThreads;

	public static readonly uint OptionalDownloadRepairTimeCD;

	public static readonly bool OptionalDownloadFixOpen;

	public static readonly bool OptionalDownloadHashCheckOpen;

	public static readonly uint OptionalDownloadFixWndToastTimes;

	public static readonly int OptionalBackgroundDownloadThreadSleepTime;

	public static readonly bool OptionalDeepFileCheck;

	public static readonly bool EnableOverrideWithFullData;

	public static readonly bool EnableRimLighting;

	public static readonly bool EnableBlackWhite;

	public static readonly int PetMotionLerpMaxTargetTickCount;

	public static readonly float PetVisibleRange;

	public static readonly float PetPlayButtonCD;

	public static readonly float PetWanderSpeed;

	public static readonly float PetRunSpeed;

	public static readonly float PetDashSpeedScale;

	public static readonly bool HideTeammatePet;

	public static readonly bool UseEmptyPetShellWhenAutoHide;

	public static readonly int MinutesBetweenSendingCachedEventLogs;

	public static readonly bool SpawnEventBonusAI;

	public static readonly bool CanEatMushroomDuringTransform;

	public static readonly bool EnableSnowFlake;

	public static readonly bool EnableMultiThreadDownload;

	public static readonly float ClanPointsRankRequestIntervalTime;

	public static readonly float RTShadowDistance;

	public static readonly float RTShadowDistanceOnAndroid;

	public static readonly float RTShadowDistanceIfNotUsed;

	public static readonly bool RTShadowV2;

	public static readonly bool RTShadowLowResolution_Android;

	public static readonly bool RTShadowLowResolution_IOS;

	public static readonly float LeaderBoardRequestCDTime;

	public static readonly float WeaponPowerLeaderBoardRequestCDTime;

	public static readonly ulong ClanWarRecruitCDTime;

	public static readonly bool OpenWholeBodyAttackWeapon;

	public static readonly float TrendAgentBVoteNextTime;

	public static readonly float TrendAgentBVoteIntervalTime;

	public static readonly bool EnableWhitelistFromServer;

	public static readonly bool EnableCompatibleGraphicsDeviceName;

	public static readonly bool HD3PInWaitingRoom;

	public static readonly float RTShadowNormalBias;

	public static readonly bool EnableCharacterBackLight;

	public static readonly bool EnableInGameAsyncPreload;

	public static readonly bool EnableFrontEndGameAsyncPreload;

	public static readonly bool FirstLoginNeedWaitePreload;

	public static readonly bool EnableAsyncGetTreasuryModel;

	public static readonly bool EnableAsyncGetTreasuryModelForHeight;

	public static readonly float TreasuryProgressToHideUpgrade;

	public static readonly float TreasuryUpgradeTime;

	public static readonly float VaultRoomUpGradeDiscount;

	public static readonly int ItemMarkTreasuryOffsetY;

	public static readonly bool EnableAsyncLoadAirDropModel;

	public static readonly bool EnableFireFastWeaponStateFixed;

	public static readonly bool ModifyGrassUtrlaLODDist;

	public static readonly bool EnableSmallerGrassMesh;

	public static readonly int PreloadCountPerFrame;

	public static readonly int MaxCDNDownloadCount;

	public static readonly int MaxCDNIconDownloadCount;

	public static readonly int MaxCDNLoadCount;

	public static readonly bool ShouldClearCDNCoroutines;

	public static readonly bool EnableShowTargetOnMap;

	public static readonly bool EnableShowTargetOnHud;

	public static readonly float InvitationCDTime;

	public static readonly float MixGroupInviteCDTime;

	public static readonly int MaxInvitationDisplay;

	public static readonly uint InResultKDAKillThreshold;

	public static readonly uint InResultKDADamageThreshold;

	public static readonly uint InResultKDAHelpUpThreshold;

	public static readonly uint InResultKDAAssistThreshold;

	public static readonly float InResultInviteCDTime;

	public static readonly float HighPingCountDownTime;

	public static readonly float LoadoutEmptyBoxCountDownTime;

	public static readonly float QueryJoinTeammateSocialDownTime;

	public static readonly float InvitationBlockTime;

	public static readonly int RoomTickBlockTime;

	public static readonly float WaitingRoom3PVolume;

	public static readonly float PVEGunVolume;

	public static readonly bool DefaultAutoFire;

	public static readonly bool EnableNewLocParse;

	public static readonly bool EnableNewLocFix;

	public static readonly bool FixItemLocIdx;

	public static readonly bool EnableNewUMABuild;

	public static readonly int WaitingIslandGiantEasterEggHp;

	public static readonly float DurationForEatingChicken;

	public static readonly bool UGCEnableAnimBlendFFAnimator;

	public static readonly float CatapultHorizontalMinAngle;

	public static readonly float CatapultHorizontalMaxAngle;

	public static readonly float CatapultVerticalMinAngle;

	public static readonly float CatapultVerticalMaxAngle;

	public static readonly float PropCatapultHorizontalMinAngle;

	public static readonly float PropCatapultHorizontalMaxAngle;

	public static readonly float PropCatapultVerticalMinAngle;

	public static readonly float PropCatapultVerticalMaxAngle;

	public static readonly float PropCatapultSpeed;

	public static readonly bool CatapultLaunchLineOptimize;

	public static readonly int CatapultLaunchLineWithHitDetectionPosCnt1;

	public static readonly float CatapultLaunchLineWithHitDetectionInterval1;

	public static readonly int CatapultLaunchLineWithHitDetectionPosCnt2;

	public static readonly float CatapultLaunchLineWithHitDetectionInterval2;

	public static readonly float CatapultLaunchLineWithHitDetectionAngle;

	public static readonly int CatapultLaunchLineSplitSegmentPointCount;

	public static readonly float CannonHorizontalMinAngle;

	public static readonly float CannonHorizontalMaxAngle;

	public static readonly float CannonVerticalMinAngle;

	public static readonly float CannonVerticalMaxAngle;

	public static readonly string MemoryCheckString;

	public static readonly float FlashEffectScale;

	public static readonly string GER_SponsorId;

	public static readonly string GER_ApiKey;

	public static readonly float TcpBackgroundDeactiveTime_IOS;

	public static readonly float TcpBackgroundDeactiveTime_Android;

	public static readonly bool UdpReuseStreamWriter;

	public static readonly float MapUpLength;

	public static readonly float MapRightLength;

	public static readonly float MapDownLength;

	public static readonly float MapLeftLength;

	public static readonly int LowestQualityMemoryThre;

	public static readonly int IOSMemoryLevelLowThre;

	public static readonly int MemoryLevelLowThre;

	public static readonly int MemoryLevelMediumThre;

	public static readonly int MemoryLevelHighThre;

	public static readonly int MemoryLevelSuperHighThre;

	public static readonly bool ShowBooyahTvInLowMem;

	public static readonly bool OptimizePInvokePerf;

	public static readonly int OptimizeAndroidReadCpuFreq;

	public static readonly bool CacheTotalMemory_Android;

	public static readonly int Cache3PResMemThre;

	public static readonly int CloseTriBufMemThreshold;

	public static readonly int DisabelGhostShadowEffectMemoryLevelHighThre;

	public static readonly bool IsTurnOnGhostShadowEffect;

	public static readonly int GhostCircleReviveTimes;

	public static readonly int GhostCircleReviveRedCount;

	public static readonly bool EnableGoogleEngagementRewards;

	public static readonly string GoogleEngagementRewards_ElitePassPurchase;

	public static readonly bool SensorBeaconHintAlwaysShow;

	public static readonly float SensorBeaconHintDutation;

	public static readonly float SensorBeaconHintCD;

	public static readonly float LobbyChatDispearDelay;

	public static readonly float LobbyChatShowTime;

	public static readonly uint WorldChatLevelLimit;

	public static readonly ulong WorldChannelSendCD;

	public static readonly ulong SocialChannelSendCD;

	public static readonly ulong WorldChannelVFXCD;

	public static readonly ulong SocialChannelVFXCD;

	public static readonly ulong RecruitNotcieCD;

	public static readonly float LiftTopMessageShowTime;

	public static readonly float LiftTopMessageListShowTime;

	public static readonly int ShowPrivateWarningCD;

	public static readonly float ChatClanLuckyBagMessageShowTime;

	public static readonly uint ChatBlockMaxCount;

	public static readonly ulong FastRecruitValidTime;

	public static readonly int ChatCharacterLimit;

	public static readonly int RoomChatCharacterLimit;

	public static readonly uint ChatReportMaxTimes;

	public static readonly uint ClanReportMaxTimes;

	public static readonly uint EsportsBubbleTweenDuration;

	public static readonly int EsportsBubbleScrollTime;

	public static readonly bool SimpleDamageCheckForAI;

	public static readonly int TreasureBoxMaxOpenCount;

	public static readonly uint PVEResurrectionCoinID;

	public static int ReviveTimeout;

	public static int PengdingReviveCamraTime;

	public static int LocalDeathCamraTime;

	public static float FinalShotExtraObserverDelay;

	public static bool EnableFinalShotLastKillCameraDelay;

	public static int LocalPlayerDestroyDelayTime;

	public static readonly bool EnableShowMaxHypePlayerPosInMap;

	public static readonly bool EnableShowHypeEnemyHudLevel;

	public static readonly bool EnableRankCardFeature;

	public static readonly float GrapplingHookMinRange;

	public static readonly float GrapplingHookJumpHeightOffset;

	public static readonly float GrapplingHookPlayerMaxRadianHeightRange;

	public static readonly float GrapplingHookPlayerMaxRadianHeight;

	public static readonly float GrapplingHookPlayerMinSpeed;

	public static readonly float GrapplingHookPlayerMaxSpeed;

	public static readonly float GrapplingHookPlayerMinSpeedDist;

	public static readonly float GrapplingHookPlayerMaxSpeedDist;

	public static readonly float GrapplingHookPlayerSpeedReachFactor;

	public static readonly float FaithJumpingPlayerMaxRadianHeight;

	public static readonly float FaithJumpingPlayerG;

	public static readonly float MGSLockRadiusRate;

	public static readonly float MGSLockTime;

	public static readonly float MGSLockPreTime;

	public static readonly float NoHeadshotTimeAfterPoseSwitch;

	public static readonly bool IsCrouchScatterOpen;

	public static readonly float CrouchScatterAngle;

	public static readonly float CrouchScatterTime;

	public static readonly bool IsLyingScatterOpen;

	public static readonly int ShootingTargetMaxHP;

	public static readonly float PriorityStepVolumeRate;

	public static readonly bool EnableOptimizeUnZip;

	public static readonly bool EnableParachutingBGM;

	public static readonly string RebateCardSubscribableRegions_iOS;

	public static readonly string RebateCardSubscribableRegions_Android;

	public static readonly int SubscriptionRenewalMailAdvanceDays_MiniWeekly;

	public static readonly int SubscriptionRenewalMailAdvanceDays_Weekly;

	public static readonly int SubscriptionRenewalMailAdvanceDays_Monthly;

	public static readonly string EvoPassSubscribableRegions_iOS;

	public static readonly string EvoPassSubscribableRegions_Android;

	public static readonly string ElitePassSubscribableRegions_iOS;

	public static readonly string ElitePassSubscribableRegions_Android;

	public static readonly string SubscriptionBundleSubscribableRegions_iOS;

	public static readonly string SubscriptionBundleSubscribableRegions_Android;

	public static readonly string RecommitBeforePaymentRegions_iOS;

	public static readonly string RecommitBeforePaymentRegions_Android;

	public static readonly bool PreventDuplicatePaymentAfterScanAndClear;

	public static readonly bool EnableUpdateProductsAfterRecommit;

	public static readonly bool EnableOBBCheck;

	public static readonly bool ForceShowNewVersionEP;

	public static readonly bool ShowPaymentFailureSignature;

	public static readonly bool ShowBlackWhiteEffect;

	public static readonly float FoldWingGlidingStartMinHeight;

	public static readonly float FoldWingGlidingAutoStopHeight;

	public static readonly float FoldWingGlidingManualStopMinTime;

	public static readonly float FoldWingGlidingHSpeed;

	public static readonly float FoldWingGlidingVSpeed;

	public static readonly float FoldWingFallingVSpeed;

	public static readonly float FoldWingGlidingAngleDelta;

	public static readonly float CCTCheckInterval;

	public static readonly bool DynamicBoneRotateOptimize;

	public static readonly bool DynamicBoneRotateUseNewPitch;

	public static readonly float DynamicBoneRotateMin;

	public static readonly bool EnableDynamicBoneColliderCacheOpt;

	public static readonly bool SetGroundFor3P;

	public static readonly bool SetGroundOnlyInFrustum;

	public static readonly bool SetPosForInvisible3P;

	public static readonly uint SubscribableBeforePreorder_Hours;

	public static readonly uint SubscribableAfterPreorder_Hours;

	public static readonly float PCAutoBattleCheckTimeInterval;

	public static readonly bool PCAutoBattleTypeCheckDamage;

	public static readonly bool PCAutoBattleTypeCheckKnockedDown;

	public static readonly float PCAutoInTeamCheckCD;

	public static readonly float PCAutoInTeamEnemyCheckDis;

	public static readonly float PCAutoInTeamSwitchDelay;

	public static readonly uint PCDelayOBSeconds;

	public static readonly bool ShowBRAndCSFinalKill;

	public static readonly bool IsHighlightCameraEffectOn;

	public static readonly float MatchEndFinalKillTimeScale;

	public static readonly float MatchEndFinalKillDuration;

	public static readonly float WhizBySoundHappenRate;

	public static readonly float WhizBySoundVolumeMin;

	public static readonly float WhizBySoundVolumeMax;

	public static readonly int OneShotLimitInOneFrame;

	public static readonly float RotationSensitivityMin;

	public static readonly float RotationSensitivityMax;

	public static readonly float AimRotationSensitivityMin;

	public static readonly float AimRotationSensitivityMax;

	public static readonly float GooglePCRotationSensitivityMin;

	public static readonly float GooglePCRotationSensitivityMax;

	public static readonly float UGC1PSensitivitySettingDefault;

	public static readonly float SensitivityMaxSetting;

	public static readonly float Sensitivity1PMaxSetting;

	public static readonly float X1ScopeMaxSetting;

	public static readonly float X2ScopeMaxSetting;

	public static readonly float X4ScopeMaxSetting;

	public static readonly float X8ScopeMaxSetting;

	public static readonly float FreeLookMaxSetting;

	public static readonly bool UseXG;

	public static readonly bool DisableXGForLowMemoryLevel;

	public static readonly bool UseXG_FCM;

	public static readonly bool IgnoreBigEventTemplateIfHaveBigEvent;

	public static readonly uint SettingAutoTaskCountDownTime;

	public static readonly bool EnableQualitySettingCache;

	public static readonly int EnableLobbyHDRecipe;

	public static readonly float PlayerAssistantAudioCDTime;

	public static readonly float PlayerAssistantItemMarkTime;

	public static readonly float PlayerAssistantItemMarkDistance;

	public static readonly float PlayerAssistantItemMarkCDTime;

	public static readonly float InGameItemMarkAlphaThreshold;

	public static readonly float InGameItemMarkResponseShowEffectDuration;

	public static readonly float InGameItemMarkAlphaValue;

	public static readonly float InGameItemMarkOneClickInterval;

	public static readonly float InGameThumbUpStayTime;

	public static readonly float InGameSendRewardSuccessStayTime;

	public static readonly float InGameThumbUpKillStayTime;

	public static readonly bool UseSniperCollider;

	public static readonly int ChampionshipContactIDMaxLength;

	public static readonly ulong ChampionshipTeamInfoEditCoolDown;

	public static readonly ulong ChampionLeaderboardCD;

	public static readonly uint VisitorInteractionInfoCD;

	public static readonly ulong SetFriendAliasCD;

	public static readonly ulong OB47AwakenAvatarClaimTimeCD;

	public static readonly ulong OB48SettingNewbieGuidTime;

	public static readonly bool WebViewPromptFaulty;

	public static readonly bool WebViewFallbackToBrowser;

	public static readonly bool WebViewDeferredDisplay;

	public static readonly float WebViewLoadingProgressAnimationDuration;

	public static readonly float WebViewPromptReloadDuration;

	public static readonly float webViewProgressBarLaunchPercentage;

	public static readonly float webViewProgressBarLaunchDuration;

	public static readonly string webViewProgressTextLaunchColor;

	public static readonly string webViewProgressTextLoadColor;

	public static readonly bool IngameAvatarPoolDynamicEffects;

	public static readonly bool LobbyAvatarMateriaAnimEffects;

	public static readonly bool IngameAvatarMateriaAnimEffects;

	public static readonly float TeamBarStrikeDownIconShowTime;

	public static readonly string KillNotificationTeamSoundTime;

	public static readonly bool DoFixBugDonotInitUIState;

	public static readonly bool DoFixMatchEndWinnerQuit;

	public static readonly bool DoFixOBReconnectLocalMatchEnd;

	public static readonly bool DoFixClearTriggersOnRevive;

	public static readonly bool DoFixStuckWhenKnockdownDuringCrossover;

	public static readonly bool DoFixClearTriggersOnUnEquipTeamFlight;

	public static readonly bool DoFixWaterNoSwimForceSync;

	public static readonly bool DoFixAddDeadTeammateHudName;

	public static bool DoFixBuffIconCDSyncOnlySelf;

	public static bool DoFixJetpackShoesModelReconnect;

	public static bool DoFixAvatarFrameInitOnKillCam;

	public static bool DoFixClearFlightUsingFuncOnKillCam;

	public static bool DoFixUIMaleAvatarPingPongReverseResetOnDisable;

	public static bool UIGroupSwitchUsePos;

	public static bool UIAnimatedAlphaOpt;

	public static readonly bool UIGroupSwitchOpt;

	public static readonly bool UIGroupSwitchSkipUIPanelLateUpdate;

	public static readonly float STREAMING_TILE_STREAMING_RANGE;

	public static readonly float STREAMING_TILE_SIZE_X;

	public static readonly float STREAMING_TILE_SIZE_Y;

	public static readonly float STREAMING_TILE_SIZE_Z;

	public static readonly int NeedPingIDCDelayThreshold;

	public static readonly bool UseLiveScreen;

	public static readonly float PaintSprayerFloatingCheckMaxDiffuse;

	public static readonly float PaintSprayerOutNormalDistance;

	public static readonly float PaintSprayerShowDelay;

	public static readonly bool ShowGrowManual;

	public static readonly bool EnableFoliageSupportScreenShot;

	public static readonly bool PVPFireShakeEnable;

	public static readonly bool PVEFireShakeEnable;

	public static readonly int CSFactionShowTime;

	public static readonly float CSFactionDelayTime;

	public static readonly int PVEAnimOptTicksPerSecond;

	public static readonly float FactionShowTime;

	public static readonly float BombFactionShowTime;

	public static readonly string ArabicExtraString;

	public static readonly float HighQualityOptionalSpeedScale;

	public static readonly float HighQualityOptionalSpeedScaleLimit;

	public static readonly float MiddleQualityOptionalSpeedScale;

	public static readonly float MiddleQualityOptionalSpeedScaleLimit;

	public static readonly float LowQualityOptionalSpeedScale;

	public static readonly float LowQualityOptionalSpeedScaleLimit;

	public static readonly float OptionalSpeedUpDelay;

	public static readonly ulong GetTeamMatchStatsHistoryCacheTime;

	public static readonly float CSShopDelayClose;

	public static readonly string WebViewJavaScriptName;

	public static readonly bool WebViewRunJavaScript;

	public static readonly bool EnableUnloadUnusedAssetAfterSplash;

	public static readonly float SetMusicVolumeOnPlayAvatarVoice;

	public static readonly uint HealingDanceEmoteID;

	public static readonly float HealingDanceAudioLength;

	public static readonly float DistanceWithDownloadEffectControl;

	public static readonly float DownloadEffectDuration;

	public static readonly float FindTreasureMapTime;

	public static readonly float FindFoxToriiTime;

	public static readonly int EnableGuideRegisterDay;

	public static readonly int EnableGuideLevel;

	public static readonly bool EnableSafeZoneExistOnMapWhenShrinkEnd;

	public static readonly float ThresholdSafeZoneMinRadiusWhenShrinkEnd;

	public static readonly float BattleFlagSpawnDistanceForward;

	public static readonly float BattleFlagSpawnDistanceRight;

	public static readonly float BattleFlagSpawnDistanceUp;

	public static readonly float BattleFlagDirectionRightOffset;

	public static readonly bool EnableLobbyBgRotate;

	public static readonly bool HasOptionalAbs;

	public static readonly bool CheckOptionalInLauncher;

	public static readonly bool EnableIngameLikeManyTimes;

	public static readonly bool EnableOptionalDownloadVoice;

	public static readonly bool EnableOptionalDownloadMap;

	public static readonly bool EnableOptionalDownloadPet;

	public static readonly bool EnableOptionalFullScreenCG;

	public static readonly bool EnableOptionalAvatar;

	public static readonly bool EnableOptionalDownloaEmotion;

	public static readonly bool EnableOptionalDownloadMap1;

	public static readonly bool EnableOptionalDownloadMap1HD;

	public static readonly bool EnableOptionalDownloadMap2;

	public static readonly bool EnableOptionalDownloadMap4;

	public static readonly bool EnableOptionalDownloadMap4HD;

	public static readonly bool EnableOptionalDownloadCloth;

	public static readonly bool EnableOptionalDownloadWerewolves;

	public static readonly bool EnableOptionalDownloadRushB;

	public static readonly bool EnableOptionalDownloadRushingPets;

	public static readonly bool EnableOptionalDownloadNewBlast;

	public static readonly bool EnableOptionalDownloadSingersB;

	public static readonly bool EnableOptionalDownloadHuntingGround;

	public static readonly bool EnableOptionalDownloadInGameRes;

	public static readonly bool EnableOptionalDownloadMapPonyRes;

	public static readonly bool EnableOptionalDownloadWeRunRes;

	public static readonly bool EnableOptionalDownloadUGCOldParadiseRes;

	public static readonly bool EnableUGCCustomRes;

	public static readonly bool EnableUGCSubLevelStreamingVisibilityMode;

	public static readonly bool DisableUGC1PModelShadow;

	public static bool UGCTutorialForceLockGridGran;

	public static float UGCTutorialGridGran;

	public const float UGCTutorialGridGranMin = 0.1f;

	public const float UGCTutorialGridGranMax = 1f;

	public static float UGCTutorialNewbieExitGuideDelaySec;

	public static float UGCTutorialNewbieExitGuideAutoHideSec;

	public static float UGCTutorialTaskCompletePresentationDelaySec;

	public static readonly bool EnableOptionalDownloadMapMax;

	public static readonly bool EnableOptionalDownloadLudo;

	public static readonly bool EnableOptionalDownloadLobbyResource;

	public static readonly bool EnableOptionalDownloadInfection;

	public static readonly bool EnableOptionalDownloadFootball;

	public static readonly bool EnableOptionalDownloadUGC;

	public static readonly bool EnableOptionalDownloadTraining;

	public static readonly bool EnableOptionalDownloadSocial;

	public static readonly bool EnableOptionalDownloadLoneWolf;

	public static readonly bool EnableOptionalDownloadLoneWolfStrikeOut;

	public static readonly bool EnableOptionalDownloadMapHippo;

	public static readonly bool EnableOptionalDownloadMapHippoVersionCheck;

	public static readonly bool EnableOptionalDownloadMapHippoVersionCheckInIOS;

	public static readonly bool EnableOptionalDownloadMapHippoVersionCheckHD;

	public static readonly bool EnableOptionalDownloadMapHippoVersionCheckHDInIOS;

	public static readonly bool EnableOptionalDownloadMapHippoVersionCheckTrail;

	public static readonly bool EnableOptionalDownloadSnowDuel;

	public static readonly bool EnableOptionalDownloadMultiRegionRes;

	public static readonly bool EnableBackgroundDownloadLocalNotify;

	public static readonly bool EnableReCheckOptional;

	public static readonly bool DisableTerrainBlendingShadow;

	public static readonly bool EnableTerrainSaveZoneSeam;

	public static readonly float TerrainSaveZoneSeamShowDist;

	public static readonly int VehicleNetworkSpeedQueueCount;

	public static readonly float VehicleWaterUploadZeroVelocitySpeedThreshold;

	public static readonly bool VehicleSeatsSetVisible;

	public static readonly bool VehicleTeleportWhenSetVisible;

	public static readonly bool PlayerTeleportWhenSetVisible;

	public static readonly bool EnableMambetUnityVoiceCapture;

	public static readonly bool EnableMambetExternalVoiceCapture;

	public static readonly bool EnableFreeFireVoiceMemberChanged;

	public static readonly float LudoLocalPlayerHeadInfoScale;

	public static bool UnLoadNoCacheConfigText;

	public static readonly bool ShowMallGround;

	public static bool EnabledSortInventory;

	public static bool EnabledFixInventory;

	public static float NetworkDetectionCDTime;

	public static int WinNeedFinishChessNumber;

	public static int WinNeedFinishPlayerNumber;

	public static readonly float TrainingMode_ShowPlayerListRange;

	public static readonly bool TrainingMode_EnableWeatherTime;

	public static readonly bool TrainingMode_Build1PImmediately;

	public static readonly float TrainingWeaponVolumeInSocial;

	public static readonly float LobbySocialAreaWeaponVolume;

	public static readonly bool EnableCrossFrameUpdate;

	public static readonly bool EnableCrossFrameUpdateForMax;

	public static readonly bool EnableCrossFrameUpdateAsync;

	public static readonly bool FastUmaReadyForAnimCrossFrameUpdate;

	public static readonly bool MapOffsetUsingNew;

	public static readonly bool MapDrawInfoUsingOwn;

	public static readonly int CrossFrameUpdateQualityLevel;

	public static readonly int CrossFrameDistQualityLevel;

	public static readonly int CrossFrameUpdateInterval;

	public static readonly float CrossFrameDistThresholdSqr;

	public static readonly bool UnloadPreviewDataSwitch;

	public static readonly bool LowMemoryPhoneClearAssetInFrontend;

	public static readonly bool LowMemoryPhoneClearCDN;

	public static readonly bool Android32BitClearCDN;

	public static readonly bool LowMemoryPhoneSkipGachaFullCG;

	public static readonly bool LowMemoryPhoneClearAssetsForPreview3DModel;

	public static readonly bool ClearCDNCacheAfterAutoTask;

	public static readonly bool ClearUnusedAssetsAfterSplashBannerForAllPlatform;

	public static readonly bool IsLobbyGachaConfirmWndDifferent;

	public static readonly float MovieLevelOpeningTimepoint;

	public static readonly float FlightAnimOpeningTimepoint;

	public static readonly int VeteranReminderDays;

	public static readonly float AutoOpenBoxBundleVFXTime;

	public static readonly bool DisablePreserveContent;

	public static readonly bool NeedUIBGGlassBlur;

	public static readonly bool NeedUIGrabScene;

	public static readonly string AndroidTryFixingSubscriptionOnHoldURL;

	public static readonly string FastTipsUrl;

	public static readonly string AndroidTryFixingSubscriptionGracePeriodURL;

	public static readonly int SubscriptionGracePeriodReminderWindowDismissCountdown_S;

	public static readonly int Team1Index;

	public static readonly int Team2Index;

	public static readonly string Team1ColorStr;

	public static readonly string Team2ColorStr;

	public static readonly string DefaultTeamColorStr;

	public static readonly string MovieLevelOpeningRegions_IOS;

	public static readonly string MovieLevelOpeningRegions_Android;

	public static readonly string NewBackButtonStyleRegion;

	public static readonly string GuestAccountEnableRegion;

	public static readonly string AndroidSensityParamsHigh;

	public static readonly string IosSensityParamsHigh;

	public static readonly string GooglePCSensityParamsHigh;

	public static readonly string AndroidSensityParamsMedium;

	public static readonly string IosSensityParamsMedium;

	public static readonly string GooglePCSensityParamsMedium;

	public static readonly string SensiSettingAutoEquipWeapon;

	public static readonly string UseNewDeathCameraMode;

	public static readonly string CrashTipMapList;

	public static readonly string BugReportDisabledIPRegions;

	public static readonly string FFAntihackEmulatorCheckDisbaledClientVariant;

	public static readonly bool NeedFirstGuideMatch;

	public static readonly bool NeedShrinkTaskWidth;

	public static readonly float FirstGuideMatchMakingDuration;

	public static readonly int FirstGuideMatchMapID;

	public static readonly int FirstGuideMatchMode;

	public static readonly int FirstGuideMatchGameMode;

	public static readonly bool IsBrScoreboardGuideOpen;

	public static readonly bool IsCsNewScoreboardOpen;

	public static readonly float ScoreBoardOpenTime;

	public static readonly uint GetTeamSlotCD;

	public static readonly int TutorialBRMapID;

	public static readonly int TutorialBRMatchMode;

	public static readonly int TutorialBRGameMode;

	public static readonly int TutorialBRLobbyGuideMaskPR;

	public static readonly float TutorialBRShrinkZoneSecondsAfterSoloGame;

	public static readonly int BRTutorialTaskEnabledMatchModes;

	public static readonly int BRTutorialTaskMaxPlayerLevel;

	public static readonly int BRTutorialTaskMaxRank;

	public static readonly string TutorialsWontShowAfterTutorialSingleGame;

	public static readonly string PickupListNewMode;

	public static readonly bool NeedTutorialCSMatch;

	public static readonly int TutorialCSMapID;

	public static readonly int TutorialCSMatchMode;

	public static readonly int TutorialCSGameMode;

	public static readonly float TutorialCSPathArrowHideDelay;

	public static readonly float TutorialCSPathArrowInterval;

	public static readonly int RelaunchDelayAfterObbDownloadedMS;

	public static readonly bool EnableForceGC;

	public static readonly int ForceGCCount;

	public static readonly bool EnableClearAllLoadedResourceAfterCleanAssets;

	public static readonly bool NeedOptimizeCSVInMemory;

	public static readonly bool NeedOptimizeCSVInMemoryAll;

	public static readonly bool NeedOptimizeBundle32Bit;

	public static readonly bool ShowNewTutorial;

	public static readonly int NicknameLengthMin;

	public static readonly int EffectPoolMaxSize;

	public static readonly bool EnableBundleOptimize;

	public static readonly bool EnableUGCOutline;

	public static readonly float HoverBoardAniBlendSpeed;

	public static readonly float HB_DoubleJumpInterval;

	public static readonly float HB_CheckSkateboardJumpInterval;

	public static readonly float TutorialDefaultDuration;

	public static readonly int TutoEpInfoVal;

	public static readonly float TutoBagNotEnoughProportion;

	public static bool OptimzeNGUIVisible;

	public static bool OptimzeNGUIAlpha;

	public static bool OptCheckWidgetAlpha;

	public static bool EnableCheckWidgetAlphaDirtyOpt;

	public static readonly bool EnableDesertStorm;

	public static readonly bool GameModeUseMediumSize;

	public static readonly bool MultiDownloadGCMerge;

	public static readonly int MultiDownloadGCIndex;

	public static readonly bool NeedInitFileLength;

	public static readonly int FrontEndLowMemCDNCountThreshold;

	public static readonly int FrontEndLowMemCGCountThreshold;

	public static readonly int FrontEndLowMemUMACountThreshold;

	public static readonly int FrontEndLowMemPreview3dModelCountThreshold;

	public static readonly bool EnableCDNDownloadOptimized;

	public static readonly bool EnableCDNLocalLoadOptimized;

	public static readonly bool UseFixedPointGetTextureData;

	public static readonly bool UseSmallRtForMatchEndPlayer;

	public static readonly bool ResultPlayerAvatarDelayRelease;

	public static readonly bool ResultPlayerAvatarRelease;

	public static readonly bool ResultPlayerAnimRelease;

	public static readonly bool ChangeResultAvatarReleaseOrder;

	public static readonly bool EnableMatchResultReleaseMemoryOnlyLowMemory;

	public static readonly bool ReleaseResourcesOnMatchEndForLowMemory;

	public static readonly bool DeleteDcsOnReleaseResourcesForMatchEnd;

	public static readonly bool ReleaseLightmapMemoryFor64bitHigh;

	public static readonly bool ReleaseLightmapMemoryFor64bitHigh_IOS;

	public static readonly bool ReleaseLightmapMemoryOnUnloading;

	public static readonly bool ReleaseLightmapMemoryOnUnloading_IOS;

	public static readonly bool ReleaseAssetsOnUnload;

	public static readonly bool ResultPlayerAvatarReleaseFor32bit;

	public static readonly bool ResultPlayerAvatarReleaseForIOSLowMem;

	public static readonly bool EnableMatchResultReleaseMemoryLowSetting;

	public static readonly bool EnableMatchResultForceReleaseMemoryOnLowMemory;

	public static readonly bool TryFixMatchResultReleaseMemory;

	public static readonly bool EnableMinimalDebuggingOnLowMemory;

	public static readonly bool EnableUISpriteMemoryOptimizationOnLowMemory;

	public static bool EnableInGameUIDontDestroy;

	public static bool EnableInGameSettingCacheReuse;

	public static bool KillCamDurationNotChangeChildCtrlParent;

	public static bool EnableInGameUIKillCamDontDestroy;

	public static readonly bool DontDestroyABNotUnLoad;

	public static readonly bool MaualGcWhenCloseInGameAutoGC;

	public static readonly bool MaualGcWhenInGameNoGC;

	public static readonly bool DisableBigMapGcWhenSuperHighMemoryLevel;

	public static readonly int BigMapGCIntervalHighMemoryLevelSeconds;

	public static readonly int BigMapGCIntervalMidMemoryLevelSeconds;

	public static readonly bool LoadLoadingSceneWaitEndOfFrame_1;

	public static readonly bool LoadLoadingSceneWaitEndOfFrame_2;

	public static readonly bool LoadGameProcessWaitEndOfFrame_1;

	public static readonly bool LoadGameProcessWaitEndOfFrame_2;

	public static readonly bool LoadLoadingSceneSyncLoadGameProcess;

	public static readonly bool StopAsyncLoadWhenIsLoading;

	public static readonly int SyncLoadUmasCount;

	public static readonly int AsyncLoadCount;

	public static readonly bool AsyncLoadCountLimit;

	public static readonly bool EnableAsyncLoadVehicleBeyond100m;

	public static readonly bool LoadLoadingSceneSingleNoGc;

	public static readonly bool LoadGameSceneSingleNoGc;

	public static readonly bool DisableApplyTexturUnloadUnusedAssets;

	public static readonly uint AsyncCallBackTime;

	public static readonly uint AsyncCallBackTimeCabin;

	public static readonly bool PoolManagerCallBackTimeLimit;

	public static readonly bool PoolManagerCachedTimeLimit;

	public static readonly uint PoolManagerCallBackTime;

	public static readonly uint PoolManagerCallBackTimeCabin;

	public static readonly bool EnablecCabinLimitTime;

	public static readonly bool CacheAnimtiorCtrl_Fist;

	public static readonly float AsyncLoadCheckTime;

	public static readonly bool EnableLoadingSmooth;

	public static readonly bool EnableLoadingDestroyImmediate;

	public static readonly uint LoadingHandleRUDPPacketsTimeLimitMS;

	public static readonly uint JoinMatchTime;

	public static readonly uint PreloadUMATime;

	public static readonly uint InitVehicleTime;

	public static readonly bool StreamerStaticHandlerTimeLimit;

	public static readonly uint StreamerStaticDefaultHandlerTime;

	public static readonly bool StreamerStaticHandlerFinishImmediate;

	public static readonly uint LStreamerStaticHandlerTime;

	public static readonly bool EventDispatchHandlerTimeLimit;

	public static readonly uint EventDispatchHandlerTime;

	public static readonly bool ClearStreamerPreview;

	public static readonly bool ClearStreamerFacadeFCO;

	public static readonly bool EnableUnloadUnusedAssetsOnLowMemory;

	public static readonly bool EnableUnloadUnusedAssetsNormal;

	public static int UnloadUnusedAssetsNormalInterval;

	public static readonly bool EnableUnloadUnusedAssetsEmergency;

	public static int UnloadUnusedAssetsEmergencyInterval;

	public static int UnloadUnusedAssetsEmergencyThreshold;

	public static bool UnloadEmergencyIgnoreMemDiffOnLowMemory;

	public static bool UnloadEmergencyIgnoreMemDiffClearLoaded;

	public static bool ClearPoolUnloadUnusedAssetsEmergency;

	public static bool GCUnloadUnusedAssetsEmergency;

	public static bool ReleaseMonoRefsOnManualGc;

	public static readonly bool EnableUnloadUnusedAssetsForce;

	public static readonly bool EnableGCNormal;

	public static int GCNormalInterval;

	public static int GCNormalInterval_Low;

	public static readonly bool EnableGCEmergency;

	public static int GCEmergencyInterval;

	public static readonly bool EnableGCsForce;

	public static readonly float CsRoundLowMemThresholdGB;

	public static readonly bool ForceGCOnCsRoundChangeForLowMemory;

	public static readonly bool ReleaseMemOnCsRoundChangeForLowMemoryNonAbScene;

	public static readonly bool UseSmallOverlayTextureFor32bitIOSLowMem;

	public static readonly bool NotShowingTeammatePetFor32Bit;

	public static readonly bool NotShowingTeammatePetFor32BitIOSLowMem;

	public static readonly bool NotShowingEnemyCollectionResFor32Bit;

	public static readonly bool NotPlay3PNonTeammateEmoteFor32Bit;

	public static readonly bool EnableForceMiddleQualityFor32Bit;

	public static readonly bool ChecksOverlayInSlotBeforeResource;

	public static readonly bool UMARenderTextureGetTemporary;

	public static readonly bool DisableWhiteScreenFor32Bit;

	public static readonly bool UseRTGetTemporary;

	public static readonly int DefaultGlobalMaximumLOD;

	public static readonly int DefaultGlobalMaximumLODFor32Bit;

	public static readonly bool UseLodWarmUp;

	public static readonly int ClanIDLengthMax;

	public static readonly bool CountFpsByFrame;

	public static readonly bool LevelContainerBaseInventoryListDirtyUpdate;

	public static readonly bool EnableUIHudItemMarkBtn;

	public static readonly float MapMarkCloseDelayTime;

	public static readonly float HudNameEnemyKnifeDelayTime;

	public static readonly float HudNameEnemyRemoveDelayTime;

	public static float HudNameEnemyHeadShotRemoveDelayTime;

	public static int HudNameEnemyHeadShotEnhanceDamageThreshold;

	public static readonly float HudNameRemoveDelayTimeForPC;

	public static bool UIHudCSShopTeammateWeaponInfoItemAsyncLoadUIAtlas;

	public static bool EnableInitControllerReflectionData;

	public static bool EnablePoolManagerTiled;

	public static bool EnableMatchContainerTiled;

	public static bool EnableUIRootTiled;

	public static bool FixSingleTutorialAudioBug;

	public static bool EnableSceneRootTiled;

	public static readonly float FreeLookCameraSensitivityScale;

	public static readonly float FreeLookCameraSensitivityScaleOnVehicle;

	public static readonly bool FollowCameraRightTraceCameraCollision;

	public static readonly bool FFAntihackSDKDetailEncryptBySHA1;

	public static readonly bool ExcludeKillCameraFpsCount;

	public static readonly int BlocklistMaxNum;

	public static readonly int RefAllAvailableNum;

	public static readonly int MaxRecentPlayersCount;

	public static readonly int RefreshPlayerPresenceCD;

	public static readonly int RefreshPlayerPresenceForceCD;

	public static readonly bool EnableCheckFileStates;

	public static readonly int AmountToAddFriendByContinuousTalk;

	public static readonly ulong GroupInviteRefreshTimeCD;

	public static readonly ulong NewBeeRecFriendRefreshCD;

	public static readonly uint NewBeeRecActiveDaysThreshold;

	public static readonly int NewBeeRecTier1FriendMax;

	public static readonly int NewBeeRecTier1ActiveMax;

	public static readonly int NewBeeRecTier1RecommendCount;

	public static readonly int NewBeeRecTier2FriendMax;

	public static readonly int NewBeeRecTier2ActiveMax;

	public static readonly int NewBeeRecTier2RecommendCount;

	public static readonly int NewBeeRecTier3FriendMax;

	public static readonly int NewBeeRecTier3ActiveMax;

	public static readonly int NewBeeRecTier3RecommendCount;

	public static readonly ulong GroupChangePublicCD;

	public static readonly ulong RelayMartDiscountCodeShareRefreshTimeCD;

	public static readonly uint RelayMartDiscountCodeGetRefreshTimeCD;

	public static readonly bool TeammateGrenadeBeepClipSound;

	public static readonly ulong ProfileSettingCD;

	public static readonly ulong DressUpClickCD;

	public static readonly int ProfileInputMaxLength;

	public static readonly int UUGProfileInputMaxLength;

	public static readonly float ProfileSocialMediaMSDKTimeoutCD;

	public static readonly bool NGUI_InspectMobileInput;

	public static bool FixUIInput_iPad26NumPad;

	public static bool ClearReplicationPool;

	public static readonly bool CanAddFriendTabRefreshState;

	public static bool EnableNewFriendTeamUpInviteAfterAddFriend;

	public static readonly bool DisableItemOutline;

	public static readonly float GlideDistAfterGrapplingHookMax;

	public static readonly float GlideSpeedAfterGrapplingHook;

	public static readonly float GlideAngleAfterGrapplingHook;

	public static readonly float MVEPlayerMaxRadianHeight;

	public static readonly bool RemoveUIRigidbody;

	public static readonly bool ImmediateRemoveUIRigidbody;

	public static readonly bool ImmediateRemoveUIRigidbodyUsingDestroy;

	public static readonly bool UseUITextureClipper;

	public static readonly bool UseUILabelCheckCharBeforeShape;

	public static readonly bool HalfbuzzIgnoreLeadingSpace;

	public static bool UMAReleaseDataOnRaceChange;

	public static bool UMAUsingAvatarSimple;

	public static bool UMAPreAsyncLoading;

	public static readonly bool UMAUseSharedSbStrForUrl;

	public static readonly bool UMAUseMutableStringForUrl;

	public static readonly bool UMAAsyncLoadingLobby;

	public static readonly bool UMAAsyncLoadingLobbyOnce;

	public static readonly bool UMAAsyncLoadingInGame1P;

	public static readonly bool UMAAsyncLoadingInGame3P;

	public static readonly bool UMATryLoadOnSetSlot;

	public static readonly bool UMAReAddBaseSlotsWhenLoadFailed;

	public static readonly bool UMASkipBuildIfNotVisibleV2;

	public static readonly bool UMASkipBuildIfNotVisible;

	public static readonly bool UMASkipBuildIfNoVisibleChange;

	public static readonly bool UMASkipBuildIfNoVisibleChangedSlots;

	public static readonly bool UMANoSkipForceUpdateAfterBuild;

	public static readonly bool UMABlitForRT;

	public static readonly bool UMADrawTextureForRT;

	public static readonly bool UMARefCntInLobby;

	public static readonly bool BuildAfterWardrobeSlotsLoadedProtect;

	public static readonly bool UMAPoolSlotOverlays;

	public static readonly bool UMAPoolSlotOverlaysFixMatch;

	public static readonly bool UMAOptBuildGc;

	public static readonly bool UMAUnsafeParseRecipeData;

	public static readonly bool UMAFixNoClothTextureMergeForAdditive;

	public static readonly bool UMALowerBodyNOMerge;

	public static readonly bool PreloadBotAssetsInRootCache;

	public static readonly bool FixSlotOverlayCacheBotId;

	public static readonly bool FixTexMergeForColorMask;

	public static readonly bool UMALobbyTeammateScaleNormalSpecTex;

	public static readonly bool UMALowMemLobbyScaleNormalSpecTex;

	public static readonly bool UMALowMemInGameScaleNormalSpecTex;

	public static readonly bool UMA32BitInGameScaleNormalSpecTex;

	public static readonly bool UMAIOSLowMemInGameScaleDiffuseTex;

	public static readonly bool UMALowMemLobby1PUsingRGBA565;

	public static readonly bool UMALowMemLobby3PUsingRGBA565;

	public static readonly bool UMALowMemInGame1PUsingRGBA565;

	public static readonly bool UMALowMemInGame3PUsingRGBA565;

	public static readonly bool AvatarManagerCacheUseHighQuality;

	public static readonly bool FixAvatarManagerReuse;

	public static readonly bool FixAvatarReuseBackpack;

	public static readonly bool CachePlayerShowClothes;

	public static readonly bool OptPlayerSkinMapMem;

	public static bool EnableReportOutOfBoundsErrorLogs;

	public static bool EnableLogOutOfBoundsErrorNonFatal;

	public static bool EnableReportIOFailedLogs;

	public static bool BetterListUsePool;

	public static bool BetterListPoolClearBuffer;

	public static bool ClearInvalidAABBMesh;

	public static readonly bool UMAInGameReleaseByRefCountForLow;

	public static readonly bool UMAInGameReleaseByRefCountForLowest;

	public static readonly bool UMAInGameReleaseByRefCountForUltra;

	public static readonly bool EnableAstcAbForEtc;

	public static readonly bool UMAInGameReleaseByRefCountForIOSMem;

	public static readonly bool UMAInGameReleaseByRefCountFor32Bit;

	public static readonly bool ClearUmaGeneratedMaterialsOnDestroy;

	public static readonly bool UMAInGameClearSlotMeshes;

	public static readonly bool UMAInGameReleaseSlotMeshes;

	public static readonly bool UMAInGameReleaseOverlayTextures;

	public static readonly bool UMAEnableHeadAdditiveFlow;

	public static readonly bool UMAFixAdditiveStaleAlphaTex;

	public static readonly bool UMANoTextureMergeFor1P;

	public static readonly bool UMANoClothTextureMergeForLow1P;

	public static readonly bool UMAUpdateLoobyTextureSize;

	public static readonly bool UMAFastGenerationInGame;

	public static readonly bool UMAReuseDynamicBoneInGame;

	public static readonly bool UMAReuseMaterial;

	public static readonly int UMATryFixNullMatChannels;

	public static readonly int UMASkipUpdateUMABody;

	public static readonly bool UMASkipBoneResetWhenEnsure;

	public static readonly bool UMADeepRemoveUmaDataWhenDestroy;

	public static readonly bool UMAOptGc;

	public static readonly bool OptLocLoadingGc;

	public static readonly bool LoadTransLazy;

	public static readonly bool TransCsvLocKeyToIdxInBuildTime;

	public static readonly bool FixSetMultiThreadGet;

	public static readonly bool RemoveItemIconNmaeInBuildTime;

	public static bool SpawnPoolOptAsyncGc;

	public static bool OptCsvCreateInstanceGc;

	public static readonly bool CabinWaiting_UmaSkipBuildForNotVisible;

	public static readonly bool CabinWaiting_HideScenes;

	public static readonly bool CabinWaiting_StopStreamerUpdate;

	public static readonly bool CabinWaiting_SetOnBoardBeforeSetVisible;

	public static readonly bool CabinWaiting_PreloadInvisiblePlayerClothes32Bit;

	public static readonly bool CabinWaiting_PreloadInvisiblePlayerClothes64Bit;

	public static readonly bool CabinWaiting_PreloadInvisiblePlayerClothesIOSMem;

	public static readonly bool CabinWaiting_AsyncPreloadInvisiblePlayerClothes;

	public static readonly bool CabinWaiting_PreloadTeammateClothesForLowMem;

	public static readonly bool CabinWaiting_PreloadAirplaneModel;

	public static readonly bool CabinWaiting_NoCrossFrameUpdateAnimator;

	public static readonly bool CabinWaiting_Gc;

	public static readonly bool CabinWaiting_GcForceNoInterval;

	public static readonly bool CabinWaiting_NoRequestStopEmotion;

	public static readonly bool CabinWaiting_ShowWeaponSkin;

	public static readonly int CabinWaiting_DelayCloseMaskFrames;

	public static readonly bool CabinWaiting_ClearAllLoadedResource;

	public static readonly bool CabinWaiting_CancelAsyncLoadings;

	public static readonly bool CabinWaiting_CancelUmaAsyncLoadings;

	public static readonly bool CabinWaiting_DestroyCabinImmidiately;

	public static readonly bool CabinWaiting_DestroyCabinColliders;

	public static readonly bool CabinWaiting_UnloadBgmForLowMem;

	public static readonly bool SetFireLayersOnInitCollider;

	public static readonly bool SkateboardChangeRaycastCheckOb32;

	public static readonly bool SkateboardBlendMoveSoundsFor3P;

	public static readonly bool HoverboardGetOnByGs;

	public static readonly bool EnableInGameJoinVoiceRoomAfterPlayerAdd;

	public static readonly bool EnableInGameReturnToLobbyPopupMsg;

	public static readonly bool EnableReconnectIfReachMaxResendCount;

	public static readonly int ReconnectTimesIfReachMaxResendCount;

	public static readonly int ReconnectConfirmMaxDelayAllowed;

	public static readonly bool EnableReconnectIfJoinMatchTimeout;

	public static readonly bool EnableReconnectIfInGameDisconnect;

	public static readonly bool DropMatchIfLoadingFailed;

	public static readonly bool EnableWaitingRoomOverrideBagPack;

	public static readonly bool EnableButtonDisableForKnockDown;

	public static readonly int ResolutionReduceType;

	public static readonly float ResolutionReduceRate;

	public static readonly string ResolutionReduceRegions;

	public static readonly bool ChangeResolutionOnAppPause;

	public static readonly float ResolutionHeightReduceRateLow;

	public static readonly bool EnableMinResolutionHeightLow;

	public static readonly int MinResolutionHeightLow;

	public static readonly float ResolutionHeightReduceRateLowSp;

	public static readonly bool EnableMinResolutionHeightLowSp;

	public static readonly int MinResolutionHeightLowSp;

	public static readonly bool ForceBlitTypeAlways;

	public static readonly int BlitTypeNeverMinAPILevel;

	public static readonly bool EnableGCMapCS;

	public static int GCMapCSInterval;

	public static int GCMapCSInterval_Mid;

	public static int GCMapCSInterval_Low;

	public static bool UseObjectPool;

	public static bool UseObjectPoolLowMemory;

	public static bool UseObjectPoolLazyRegister;

	public static bool EnableAsyncDeathKillerEffect;

	public static bool EnableLoadAbAsync;

	public static bool EnableWeaponSkinResAsync;

	public static bool EnableFppWeaponEffectAsync;

	public static bool EnableLowMemEnterGameLoadFPPConfig;

	public static bool EnableWeaponEffectResAsyncFor1P;

	public static bool EnableWeaponEffectResAsyncFor3P;

	public static bool EnableWeaponModelResAsync;

	public static bool EnablePickUpModelResAsync;

	public static bool EnableVehicleSkinResAsyncFor3P;

	public static bool EnableAsyncLoadLootBoxSkin;

	public static bool EnableAsyncLoadClothesEffect;

	public static bool EnableAsyncLoadClothesEffectFor1P;

	public static bool EnableAsyncLoadGrenadeSkin;

	public static bool EnableExtraClothEffectWithNoUMA;

	public static bool EnableAsyncLoadAudioClipForLowest;

	public static bool EnableAsyncLoadAudioClipForLow;

	public static bool EnableAsyncLoadAudioClipForHigh;

	public static float AsyncLoadAudioClipMaxDelay;

	public static bool EnableAsyncOneShotOnMax;

	public static bool EnableAsyncLoadAssassinGirlAudio;

	public static bool EnableAsyncHelicopterDisableAudio;

	public static float HelicopterTurnTiltSpeed;

	public static bool EnableAsyncLoadGroupAnim;

	public static bool EnablePreDistCheckForDefaultAudioSrc;

	public static bool EnablePreLoadFontTextute;

	public static bool EnablePreRequestCharacters;

	public static bool EnableBackgroundCache;

	public static bool EnableBackgroundCacheWeaponAnimator;

	public static bool EnableBackgroundCacheWeaponEffect;

	public static bool EnableBgCache3pWeaponEffectCs;

	public static bool EnableBgCache3pWeaponEffectBr;

	public static bool EnableBackgroundCacheSkill;

	public static bool EnableBackgroundCache3PSkill;

	public static bool EnableCSBackgroundCache3PIcewall;

	public static bool EnableBackgroundCacheCSBuff;

	public static bool EnableBackgroundCacheAutoPickupWeapon;

	public static bool EnableCacheManualPickupWeapon;

	public static bool EnablePickupItemReshowActionBtn;

	public static bool EnableBackgroundCacheAutoPickupFppWeapon;

	public static bool EnableBackgroundCacheGrenade;

	public static bool EnableBackgroundCache3pGrenade;

	public static bool EnableWeapon3PHearSoundCache;

	public static bool EnableCachePickupLandmine;

	public static bool EnableCacheFistRes;

	public static bool EnableCacheWeaponResWhenAddBR;

	public static bool EnableCacheWeaponResWhenAddCS;

	public static bool EnableCacheSkillInstant1p;

	public static bool EarlyCacheSkill1p;

	public static bool EnableCacheSkill3pBR;

	public static bool EnableSkillPrecache3POnlyForHighMem;

	public static bool EnableCacheSkillInstant3pCS;

	public static bool EnableCacheIceWallInstant1p;

	public static bool EnableCacheIceWall3pBR;

	public static bool EnableCacheIceWallInstant3pCS;

	public static bool EnableCacheWeaponInstant1pCS;

	public static bool EnableCacheMoreShopType;

	public static bool EnableAsyncLoadIngameEmoteEffect;

	public static bool EnableAsyncLoadIngameTransEffect;

	public static bool EnableAsyncLoadIngameGroupEffect;

	public static bool EnableAsyncLoadIngameLastKillEffect;

	public static bool EnableAsyncLoadIngameSuperEmoteAnim;

	public static bool EnableAsyncLoadIngameEmoteAnim;

	public static bool EnableAsyncLoadIngameDuoEmoteAnim;

	public static bool EnableAsyncLoadIngameTransAnim;

	public static bool EnableAvatarTimelineSyncResetActiveAnimator;

	public static bool EnableAvatarTimelineSyncLoopAnimator;

	public static bool EnableEmoteEffectPoolGet;

	public static bool EnableStoneHitEffectOnNoPlacementTrigger;

	public static bool EnableCheckEmoteEffectPlayInCustomAnimState;

	public static bool EnableDestroyEffectWhenDelayDestroying;

	public static bool EnableClearEmotionEffectsWhenChangeRace;

	public static bool EnableLevelObjectByType;

	public static bool EnableLevelObjectNameWithID;

	public static bool EnableAllRecipePreloadForHighMem;

	public static bool EnableAllRecipePreloadForMediumMem;

	public static bool EnablePreloadVestHelmetBackpack;

	public static bool EnableWaitingRoomEPPlayerEffect;

	public static int SmokeEffectMaxNum;

	public static uint HitEffectMaxNumForLowMem;

	public static bool FixPoolManagerMaxSizeForAsync;

	public static bool TokenModeEnableAllyPick;

	public static bool IsTokenFollowPlayer;

	public static int GIANT_OverFighting_CountDown;

	public static bool isShowCSLeaderboard;

	public static bool EnableTrustItemCountFromServer;

	public static bool EnableSliderTrigger;

	public static bool EnableNativeCheck;

	public static bool EnablePlatformCheck;

	public static bool EnableMMKPlatformCheck;

	public static bool EnableSupCheck;

	public static bool EnableVersionRowErrorUpdate;

	public static float PlantGrownTotalTime;

	public static float PlantAccRatePerPerson;

	public static bool RescureShowTimeToOther;

	public static float HumanTireCheckDistanceThreshold;

	public static float HumanTireCheckHeightThreshold;

	public static bool WeaponSkinFistEffectEnabled;

	public static int UMAGarbageCollectionRateNew;

	public static int UMAGarbageCollectionRateNewOB47;

	public static bool SafeReleaseAnoymousMappingTmp;

	public static bool CanReloadContinueShoot;

	public static bool WeaponStateMachineStartFiringOnlyDoOnce;

	public static bool WeaponStateMachineClearFireTrigger;

	public static bool CanRunSpeedUpSkillContinueShoot;

	public static bool CanInvincibleContinueShoot;

	public static bool CanInvincibleReloadAndSwapWeapon;

	public static bool CanSwapWeaponContinueShoot;

	public static bool CanEnterWalkContinueShoot;

	public static float MapLengththreshold;

	public static float LoginFailedCd1;

	public static float LoginFailedCd2;

	public static float LoginFailedCd3;

	public static uint LoginFailedCd4;

	public static bool ForbidenRepeatLogin;

	public static bool SetSpecialPlayerRotationInCabin;

	public static bool EnableUMAGCForUltra;

	public static bool UnloadSplashTexture;

	public static readonly float SpectatorMinimapScale1;

	public static bool EnableVehicleBrakeLightFunction;

	public static bool EnableVehicleBrakeLightAtLowSetting;

	public static bool EnableVehicleBrakeLightAtLowSettingInCommonVersion;

	public static float VehicleScratchOverGroundHeightThreshold;

	public static float PlayerPosDistDiffAllowedInOneFrame;

	public static bool PlayerPosDistDiffCheckEnable;

	public static bool PlayerPosDistDiffCheckIgnoreGroundedEnable;

	public static bool PlayerPosStuckFixEnable;

	public static float PlayerPosStuckFixTime;

	public static bool EnablePhysXStateSwitchPreCheck;

	public static float ServerAuthorizedPhysXStateSwitchTimeout;

	public static float ServerAuthorizedPhysXStateSwitchAutoRetryInterval;

	public static float ServerAuthorizedPhysXStateSwitchIgnoreSyncedOnBoardDuration;

	public static bool EnableVehilceHornFunction;

	public static bool EnableSlicedDestroyStremaerObject;

	public static float AirtransportDestroyDelayTime;

	public static float VehicleLowSpeedThreshold;

	public static float VehicleMiddleSpeedThreshold;

	public static float VehicleHighSpeedThreshold;

	public static float ParachutingStateMinAngleX;

	public static float ParachutingStateMaxAngleX;

	public static bool EnableFixForPlayerDelayReady;

	public static bool SendMallItemClickLog;

	public static bool EnableVoluner;

	public static float VehicleResetTime;

	public static float VehicleResetThresholdSpped;

	public static bool EnableTrainingVideoPlay;

	public static bool EnableTrainingVideoUpdate;

	public static int OwnPlayerVoice;

	public static uint WaitingIsland_MainLightColor;

	public static float UIPaymentDiamondEventProgressRunSpeed;

	public static float UIPaymentDiamondEventProgressDelayTime;

	public static bool HDFireEffectUseLight;

	public static float HDVehicleScratchLastingTime;

	public static int HDMaxVehicleScratchCnt;

	public static bool HDEnableVehicleScratchFunction;

	public static bool HDEnableVehicleDustFunction;

	public static bool HDEnableVehicleScratchAtLowSetting;

	public static bool HDEnableVehicleDustAtLowSetting;

	public static bool isOnlyShowBulletHoleInTraining;

	public static bool isShowBulletVFX;

	public static bool isShowBulletSound;

	public static bool HDEnableElectricZoneLogo;

	public static bool HDEnablePlayerDustEffect;

	public static bool HDEnablePlayerDustEffectAtLowSetting;

	public static bool MaxEnableUMAGC;

	public static bool HDEnableTreeReaction;

	public static bool HDEnableGrassReaction;

	public static bool HDEnableShrubReaction;

	public static int HDTreeHitProbability;

	public static int HDTreeHitMaxCount;

	public static float HDShrubAmplitude;

	public static readonly int MaxVersionMinMemory;

	public static int TerrainTextureStreaming;

	public static int PaymentAdLevel;

	public static int PaymentGrowthLevel;

	public static bool EnableCustomRoomSonoranNight;

	public static bool EnableAimAssistChange;

	public static bool EnableSkillIgnoreAimAssistInVehicle;

	public static bool FullScreenPreviewSwith;

	public static float SuicideCD;

	public static bool FixSightingCameraWallPierce;

	public static bool Phobid3PEmote4LowQuality;

	public static bool NeedShowBounceModelInAzores;

	public static bool UseNewSniperRaycast;

	public static bool OptimizeAnimator;

	public static bool EnableIsFiringCache;

	public static bool EnableGenerate;

	public static bool EnableGen;

	public static bool EnableSendLibs;

	public static bool DisableGameMemoryObserverByDeviceModel;

	public static bool EnableCustomUnloadMaxFreeMemFreq;

	public static float CustomUnloadMaxFreeMemFreq;

	public static bool NoUnloadWhileAsyncLoading;

	public static bool StreamSceneByIndex;

	public static string PetSkillTurtleBackDecreaseWeaponType;

	public static int PetSkillTurtleBackDecreaseAngle;

	public static bool EnableNBTreeVertexAnim;

	public static bool PreloadSAPCS;

	public static bool CSVAsyncDataMapAsyncLoad;

	public static bool EnableSkeletonUtilityBoneOnReset;

	public static bool EnableSkeletonUtilityBoneOnResetCallback;

	public static bool EnableSetBackCamerasVisible;

	public static bool EnableSetGameCameraVisible;

	public static bool EnableGraphicsJobs;

	public static int GraphicsJobsSyncPointValue;

	public static bool EnableEnLargeGfxWorkerStackSize;

	public static bool EnableStopXRARVR;

	public static bool TryFixIosCreateDepthStencilState;

	public static bool TryFixAirdropReconnectLaser;

	public static bool TryFixKatanaWeaponCDBug;

	public static bool EnableResetLowMemoryAsyncUploadBufferSize;

	public static bool EnableSkipShaderWarmUp;

	public static bool EnablePonyShaderWarmUp;

	public static bool EnableInGameEventShaderWarmUp;

	public static bool EnableShaderWarmupByConfig;

	public static int StartupShaderWarmupStep;

	public static bool EnableProgressivelyWarmupOnFirstLaunch;

	public static bool EnablePreventLoginBeforeWarmedUp;

	public static bool EnableStateStoreForSniperFiringDeactive;

	public static bool EnableAllowedSightListCheck;

	public static bool EnableCSShopPurchaseSFX;

	public static bool EnableBombShopPurchaseSFX;

	public static bool EnableTrainingShopPurchaseSFX;

	public static bool EnablePreZPass;

	public static bool HDEnablePreZPass;

	public static bool EnablePreZV2Pass;

	public static bool HDEnablePreZV2Pass;

	public static string DisablePreZGrapicDevices;

	public static string DisablePreZGpu;

	public static string HDDisablePreZGpu;

	public static bool EnbaleVersion;

	public static bool EnableForceSyncReqWhenAppResume;

	public static bool EnableIcewallAreaOccupiedCheck;

	public static bool EnableIceWallMotionPlatormCheck;

	public static bool EnableVehiclePhysicAfterSceneReady;

	public static bool EnableQuitGameWhenMM7;

	public static bool EnableContainerReactiveFor2018Emulator;

	public static bool EnableContainerReactiveFor2018RealPhone;

	public static bool EnableStaticContainerModelFixRotation;

	public static bool EnableDynamicContainerModelFixRotation;

	public static bool EnableCombinePRICallbackFor1P;

	public static bool SeafoodGlassCanAttack;

	public static float TwoToOneScreenLength;

	public static float FourToThreeScreenLength;

	public static float SmallTwoToOneScreenLength;

	public static float SmallFourToThreeScreenLength;

	public static float MoveJoyStickAngle;

	public static float PreMoveJoyStickAngle;

	public static bool MoveJoyStickKeepDashAfterFire;

	public static float FixedMoveJoyStickRegionScale;

	public static float MistakenlyTouchMovingJoystickSize;

	public static float MistakenlyTouchMovingJoystickTime;

	public static bool FixUIHudFireControllerSpriteNormalPos;

	public static bool EnableCheckButtonPressedDirtyAllMode;

	public static bool EnableCheckButtonPressedDirty;

	public static bool EnableCheckHudButtonClick;

	public static bool FallbackToDirectConnectWhenProxyFailed;

	public static bool NeedCheckVehicleResID;

	public static bool NeedCheckMovingJoystickConflictWithButton;

	public static bool DisableUserControlTouchWhenSettingWndOpen;

	public static bool IosShowRestoreButton;

	public static bool EnableIceWallOverlapPlayerCheck;

	public static bool EnableIceWallOverlapPlayerCheckInterval;

	public static float IceWallOverlapPlayerCheckInterval;

	public static float IceWallOverlapPlayerCheckHalfSizeExpand;

	public static float IceWallOverlapPlayerCheckStep;

	public static float IceWallOverlapPlayerCheckStartDelay;

	public static bool EnableSeqPreload;

	public static float SendJoinGameTimeoutTime;

	public static float RegisterExitDuration;

	public static bool UIBaseProfileLevelHideWhenZero;

	public static bool EnemyUseLowModelBackPack;

	public static bool EnableIceWallOverlapPlayerCheckOnlyUsing;

	public static bool EnableIceWallOverlapPlayerCheckByCheckBox;

	public static float HouseProbeDownDistance;

	public static bool EnableHouseMarkVoice;

	public static bool EnableIceWallVFXForQualityLowest;

	public static bool EnableIceWallVFXForQualityLow;

	public static float IceWallGrowUpTime;

	public static bool EnableIceWallIgnoreTraceFlagFire;

	public static float IceWallDisappearHintShowTime;

	public static float IceWallDisappearHintShowDecalStartAlp;

	public static float IceWallDisappearHintShowDecalEndAlp;

	public static float IceWallDisappearHintAnimFrequency;

	public static bool IsBRShowAceTeamIcon;

	public static bool EnableLobbyLookAt;

	public static bool EnableTriggerGrenade;

	public static bool NoPowerGunCombine;

	public static float AutoThrowGrenadeDelayTime;

	public static bool EnableHintTriggeredGrenade;

	public static bool TCPTokenEncrypt;

	public static uint TCPDeactiveTime;

	public static uint TCPQuickConnectTime;

	public static float TCPReconnectIntervalMax;

	public static bool TCPUnserializeMessageContentInThread;

	public static bool TCPNeedInitConfirm;

	public static bool TCPRecvBlockingSkipWait;

	public static bool DevicePerformanceSdk_Test;

	public static bool DevicePerformanceSdk_Enable;

	public static bool DevicePerformanceSdk_GameMode;

	public static bool DevicePerformanceSdk_MainThreadTargetFrame;

	public static bool DevicePerformanceSdk_Thermal;

	public static uint ShieldMaxHP;

	public static uint PhotographEmoteID1;

	public static uint PhotographEmoteID2;

	public static uint PhotographEmoteID3;

	public static uint PhotographEmoteID4;

	public static uint PhotographEmoteID5;

	public static uint PhotographEmoteID6;

	public static uint PhotographEmoteID7;

	public static uint PhotographEmoteID8;

	public static uint PhotographPartyEmoteID1;

	public static uint PhotographPartyEmoteID2;

	public static uint PhotographPartyEmoteID3;

	public static uint PhotographPartyEmoteID4;

	public static uint PhotographPartyEmoteID5;

	public static uint PhotographPartyEmoteID6;

	public static uint PhotographPartyEmoteID7;

	public static uint PhotographPartyEmoteID8;

	public static uint TrainingSnowBallItemID;

	public static bool EnableRefreshFile;

	public static float RefreshCD;

	public static uint EventLogCacheTime;

	public static uint EventLogTimeout;

	public static bool EventLogSmapMem;

	public static bool EnableRecordLeavePVPMemory;

	public static int EventLogSwapChangeDiff;

	public static bool NeedSendEventLogOnGameQuit;

	public static bool NeedSendEventLogOnGamePause;

	public static bool AppleLoginWhite;

	public static bool HttpRequestDelegateCheck;

	public static bool UIModelSceneChangeCalledInLoadAndRun;

	public static bool UIModelSceneChangeRemoveUIObserver;

	public static bool UIModelObseverCheck;

	public static int LobbyStartGameCoolDownTime;

	public static bool EnableGroundAmbience;

	public static bool EnableSimpleInvokeExceptionInfo;

	public static bool AndroidNotchUIAdapte;

	public static bool OpenUINoReflection;

	public static uint HttpTokenExpiredTime;

	public static string LobbyBGM2Region;

	public static bool Enable3DPlaceName;

	public static bool InjectFixBeforeLaunchGame;

	public static string CodePatchUrl;

	public static bool HidePingSignal;

	public static uint OptionalDownloadErrMsgShowCD;

	public static uint HDLobbyWwiseOptionalRedefid;

	public static uint AccountInfoCacheTime;

	public static bool SupportIPv6Only;

	public static bool HttpRequestDispose;

	public static bool HttpDeserializeInThread;

	public static bool HttpSendNextSameFrame;

	public static float AngularSleepTolerance_ON;

	public static float AngularSleepTolerance_OFF;

	public static float LinearSleepTolerance_ON;

	public static float LinearSleepTolerance_OFF;

	public static float LoadoutScannerDestroyTime;

	public static bool EnableUIHudWeaponSwitchSpriteAsyncLoad;

	public static bool EnableFontTextureOpt;

	public static bool EnableSkinnedCompressInLowMemory;

	public static bool EnableSkinnedCompressInUltraQuality;

	public static uint EngineSwitchFlags;

	public static uint EngineSwitchFlags2;

	public static uint EngineSwitchFlags3;

	public static int CustomGfxDeviceRingBufferSize;

	public static bool EnableShaderStripSettings;

	public static bool EnableShaderKeywordStripByConfig;

	public static int Il2cppSwitchFlags;

	public static bool OpenIl2cppThreadStackShrink;

	public static int BackgroundJobSystemThreadNum;

	public static bool EnableAnim16bitClone;

	public static int KillNotifiyFilter;

	public static bool EnableForceUseApkShader;

	public static bool EnableStripABShader_Android;

	public static bool EnableStripABShader_IOS;

	public static bool EnableStripShader_Android_32bit;

	public static bool EnableStripShader_Android_64bit_lowMem;

	public static bool EnableStripShader_Android_64bit_highMem;

	public static bool EnableStripShader_Android_64bit_UltraMem;

	public static bool EnableStripShader_iOS_32bit;

	public static bool EnableStripShader_iOS_64bit_lowMem;

	public static bool EnableStripSahder_iOS_64bit_highMem;

	public static bool EnableStripShader_iOS_64bit_UltraMem;

	public static bool EnableSaveCustomSettings;

	public static bool FastBinaryReadBytesGCOptimize;

	public static bool FastBinaryWriterOptWriteFloat;

	public static bool FastBinaryReaderOptReadFloat;

	public static int ApplicationInitOptSwitch;

	public static int ApplicationInitFailedMaxTimes;

	public static int ApplicationSizeThreshold;

	public static int Adjust8CoreOnly1Big;

	public static int ResMgrCacheClose;

	public static int GlobalGameMgrCacheClose;

	public static int CustomRemapperOpt;

	public static int ZipInflateBufferSizeKB;

	public static bool SkipGetDefaultExecutionOrder;

	public static int SkipGetDefaultExecutionOrderMaxFailedTimes;

	public static string SystemFontsWhiteList;

	public static string SystemFontsBlackList;

	public static bool EnableSystemFontsTrim;

	public static bool EnableReplaceGGPSO;

	public static bool EnableReplaceGGPSO_2022;

	public static long GGPUpdateFlag;

	public static bool CSSOTeamThemeColor;

	public static string FemaleAvatarColorStart;

	public static string AvatarColorStart;

	public static string AvatarColorEnd;

	public static bool UMAUseRGB565For3I3A;

	public static bool UMAUseRGB565ForAllShader;

	public static bool UMAEnableHighRGB565;

	public static bool UMAEnableMAXHighRGB565;

	public static bool UMAEnableAtlasResolutionScale;

	public static bool UMAEnableMAXAtlasResolutionScale;

	public static float UMAAtlasResolutionScale;

	public static bool UMATextureProcessSetEffectType;

	public static bool EnableEasternText;

	public static bool EnableSyllabificationInThai;

	public static float LiteDataCoolDownSecs;

	public static float LiteDataDelaySecs;

	public static bool DisableNonExpectionLogs;

	public static float UAVFightTime;

	public static bool EnableTrainingVideoForLowQualityPhone;

	public static bool EnableCameraMatrixCheck;

	public static float CenterSafeZoneTargetRadius;

	public static float MiniMapSafeZoneTargetRadius;

	public static float SideMapSafeZoneTargetRadius;

	public static float BigMapCenterSafeZoneMaxRatio;

	public static ulong OBMapCenterSafeZoneEnableCD;

	public static float BooyahEmoteTime;

	public static bool EnableMapMaskSupplement;

	public static bool EnableHippoMapMaskSupplement;

	public static float FountainFallingMoveRatio;

	public static bool FountainFallingCanMove;

	public static float LobbyDailyTaskTipProbability;

	public static float LobbyDailyTaskTipInterval;

	public static uint LessIsMoreMinReloadInterval;

	public static int LessIsMoreMaxReloadFailures;

	public static uint LessIsMorePendingReloadInterval;

	public static string PaymentOfferPersonalized_TypesPerLockRegion_GooglePlay;

	public static readonly bool UnloadEmbeddedSceneObjects;

	public static readonly bool UnloadEmbeddedSceneObjectsFor64bitHigh;

	public static readonly bool UnloadEmbeddedSceneObjectsFor64bitHigh_IOS;

	public static bool ShowLegPack;

	public static bool LowQuality1PShowSecondaryWeapon;

	public static bool LowQuality3PShowSecondaryWeapon;

	public static bool ShowSecondaryWeaponModel;

	public static float InGameMusicElementPlayIntervalTime;

	public static bool PlayAvatarVoiceWithChannel;

	public static int InGameTokenUnitCount;

	public static int MuchTokenCount;

	public static bool UseNewDeathCamera;

	public static bool UseNewDeathCameraInRanking;

	public static float TeleportDoorDuration;

	public static float TeleportDoorUseCD;

	public static bool TeleportDoorToOtherDoor_TriggerOn;

	public static bool CheckSoloMatchMakingGameMode;

	public static int MiniGameRankCnt;

	public static bool UseLevelSpaceShieldNew;

	public static bool EnableTimeSlicedUnloadScene;

	public static bool ClearStreamerRangeCacheExitGame;

	public static bool ClearStreamerRangeCacheAfterReset;

	public static bool DynamicGeneratorCheckCamDown;

	public static float DynamicGeneratorCamBackOffset;

	public static bool DecalSystemCheckCamDown;

	public static bool DecalSystemShowAllinCell;

	public static float DecalVisibleMaxHeight;

	public static int DecalSystemInstanceNumLimit;

	public static float HighGrassHeightScale_Neo;

	public static float MiddleGrassHeightScale_Neo;

	public static float LowGrassHeightScale_Shangrila;

	public static float MiddleGrassHeightScale_Shangrila;

	public static float HighGrassHeightScale_Shangrila;

	public static bool EnableVariableFadeSpeed;

	public static bool NoResetUplayerAnimationWhenReloading;

	public static bool OpenClickEffect;

	public static int StreamerMaxParallel;

	public static int FriendMatchStartTime;

	public static int RecommendFriendCountLimit;

	public static int RecommendFriendRankLimit;

	public static int RecommendFriendCSRankLimit;

	public static int RecommendFriendLevelLimit;

	public static int RecommendFriendMatchCD;

	public static int RecommentFriendTeamRankLimit;

	public static int FriendCountLimit;

	public static int ReservationCountLimit;

	public static int ReservationAcceptLimit;

	public static float ReservationTimeoutDuration;

	public static int BookPlayerRefreshCD;

	public static float NearbyPlayerRefreshCD;

	public static bool Enable3PDelayDestroyProjectile;

	public static bool Phobid1PChangeWeaponWhenCrawlToStand;

	public static bool EnableQuickChat;

	public static bool EnableQuickChatInRankMatch;

	public static int ChooseQuickChatMaxCount;

	public static float QuickChatSendCD;

	public static int QuickMessageAfterDeathCD;

	public static float QuickChatShowTime;

	public static bool NameAlphaEnable;

	public static float NameAlphaDist;

	public static float NameAlphaValue;

	public static float NameAlphaScreenWidthRatio;

	public static float NameAlphaScreenHeightRatio;

	public static bool IsPoenHeadShotSound;

	public static float BombDropPosAlphaValue;

	public static float BombDropPosAlphaScreenWidthRatio;

	public static float BombDropPosAlphaScreenHeightRatio;

	public static float BombCountDownDangerousTime;

	public static uint SelfHeroicMarkCDTime;

	public static uint FetchHeroicMarkCDTime;

	public static uint FetchRelationshipCDTime;

	public static bool EnableQuickVersionCheck;

	public static uint QuickVersionCheckCount;

	public static float LobbyAvatarTouchOffsetX;

	public static float LobbyAvatarTouchOffsetY;

	public static float EmoteLeaderRange;

	public static float Superemotetriggerrange;

	public static float SuperemoteBtnHideTime;

	public static float SuperemoteSetUIGroupInAdvanceTime;

	public static bool SuperemoteClearVFXOnCabinWaitingEnd;

	public static bool SuperemoteClearAnimationOnCabinWaitingEnd;

	public static bool SuperemoteBEVCheckStateValid;

	public static bool SuperemoteIsCreepStopEmote;

	public static bool SuperemoteAlwaysAnimate3P;

	public static bool DelayResetAnimatorCullingMode;

	public static float DelayResetAnimatorCullingModeTime;

	public static uint MaxEmoteFollower;

	public static float DuoEmoteInviteRange;

	public static float DuoEmoteLobbyInviteTime;

	public static float Duoemotecirclesize;

	public static int HUDGrenadeAttackDefaultDirection;

	public static int HUDGrenadeDefenceDefaultDirection;

	public static int HUDThreeGrenadeAttackDefaultDirection;

	public static int HUDThreeGrenadeDefenceDefaultDirection;

	public static bool CanHUDGrenadeSlotChangeInGame;

	public static bool CanHUDSmartIceWallShowInGame;

	public static bool CanHUDSmartIceWallChangeBackWeaponInGame;

	public static string EnableIngameKillRegion;

	public static string EnableRoomGunSkinAttrSetting;

	public static string UGCRecommendMapSwitch;

	public static bool EnableDrivingFlightOnBoard;

	public static float FlightRoamColliderHeight;

	public static float CCTRadiusFlightRoam;

	public static float LagTimeToHint;

	public static float LagHintCooldown;

	public static float LagHintDuration;

	public static float PlayerStateSyncStallThresholdSec;

	public static float WaitStreamingTelDistance;

	public static float WaitStreamingTelDuration;

	public static bool WaitStreamingTelEnable;

	public static bool WaitStreamingTelEnable_CSMode;

	public static bool CreateObserverHudOnSceneLoaded;

	public static string EnableEmulatorWarning;

	public static bool CanShowCameraAnimInPreview;

	public static bool UseHDModelInPartyGame;

	public static bool HDAllowIOSLowMemory;

	public static bool FixRefreshConfigOrderInRestart;

	public static bool FixTeamFlightSound;

	public static int HDUnityNumRealVoices;

	public static int HDUnityNumVirtualVoices;

	public static bool HDShowShadowOption;

	public static bool HDDefaultNotUseHDAudioFor32Bit;

	public static bool HDDefaultNotUseHDAnimFor32Bit;

	public static bool HDDisableFixedDuplicateSound;

	public static bool HDEnbaleAudioObjectOptimize;

	public static float MaxDefaultPercetage;

	public static int HDDefaultLobby;

	public static readonly int HDLobbyArmAnimRandomMin;

	public static readonly int HDLobbyArmAnimRandomMax;

	public static bool HDLobbyNeedRotateLight;

	public static readonly float HDEPClickTick;

	public static readonly int HDItemClickLengthLimit;

	public static int HDDefaultWeaponSlot;

	public static int HDDefaultWeaponType;

	public static uint HDDefaultWeaponID;

	public static string HDDefaultWeaponScale;

	public static string HDDefaultWeaponPosition;

	public static string HDDefaultWeaponRotation;

	public static float HDDefaultWeaponSkinScaleX;

	public static float HDDefaultWeaponSkinScaleY;

	public static float HDDefaultWeaponSkinScaleZ;

	public static string HDDefaultIceWallPosition;

	public static string HDDefaultIceWallRotation;

	public static string HDDefaultIceWallScale;

	public static float HDCameraReduceAcceleration;

	public static float HDCameraReduceVelocityLimit;

	public static float HDLobbyRotateSpeed;

	public static float HDLobbyYardOpenAngle;

	public static bool HDCanOpenYard;

	public static bool HDCanOpenVehicleDisplay;

	public static bool HDCanOpenIceWallDisplay;

	public static bool HDCanOpenWeaponRack;

	public static string HDWeaponHideScabbardIDs;

	public static float HDIceWallRotateTime;

	public static float HDVehicleRotateTime;

	public static int HDDefaultVehicleType;

	public static uint HDDefaultVehicleID;

	public static int HDDefaultIceWallType;

	public static uint HDDefaultIceWallID;

	public static float HDVehicleChangeCD;

	public static bool HDCanOpenSkyboardDisplay;

	public static float HDSkyboardRotateTime;

	public static uint HDDefaultSkyboardID;

	public static int HDDefaultSkyboardType;

	public static string HDDefaultSkyboardPosition;

	public static string HDDefaultSkyboardRotation;

	public static string HDDefaultSkyboardScale;

	public static float HDSkyboardChangeCD;

	public static bool HDCSNeedLightning;

	public static float HDCSLightningMinRadius;

	public static float HDGoYardVelocity;

	public static bool HDOpenClothFloorVfx;

	public static bool HDLobbyIceWallAutoRotate;

	public static bool HDLobbyVehicleAutoRotate;

	public static bool HDLobbySkyboardAutoRotate;

	public static bool HDKeepCameraStateAfterRotate;

	public static bool HDCanPetRotateInLobby;

	public static bool HDLobbyVolumeFog;

	public static bool HDUltraQualityCloseShadow;

	public static bool HDShowCaptainLobby;

	public static float BTMiniMapScale;

	public static float BTFishSlientTime;

	public static float BTFishScaleFor1P;

	public static float BTFishScaleFor3P;

	public static float BTFallingFishScaleFor1P;

	public static float BTFallingFishScaleFor3P;

	public static float BTWaterCircleEnterTimeThreshold;

	public static string BTUnderWaterSwordPosition;

	public static string BTUnderWaterSwordRotation;

	public static float BTFishingPoolForbiddenRadius;

	public static float BTFishingPoolForbiddenHeight;

	public static float BTFishingPoolForbiddenBelowHeight;

	public static bool BTFishingPoolCheckPos;

	public static bool TryFixBTFish1PFlash;

	public static bool UpdateUAVPositionWhenCreate;

	public static bool HDEnable32BitForceMiddleQuality;

	public static bool HDUseSplashBannerPreviewMixCamera;

	public static bool DisableFlareLayerForGameCamera_Lowest;

	public static bool AimCheckPlayerStreamerVisibility;

	public static int PhysicsSpecialCheckLimit;

	public static int UIScreenDelayFrame;

	public static bool UIScreenOptimization;

	public static bool EnableReuseMemCacheMap;

	public static bool EnableUnzipLoaderOptimizeRead;

	public static bool ABSceneUnloadMesh;

	public static bool ABSceneUnloadTexture;

	public static bool ABSceneSkipUnloadForMapAzores;

	public static bool EnableClearHotUpdateFileInfoCache;

	public static bool SoloShowObserverSwitchCtrl;

	public static int ABSceneUnloadMemoryThreshold;

	public static int ABSceneUnloadMemoryThresholdIOS;

	public static bool EnableAudioDuplicateExcept;

	public static bool HitArmorSoundEffect;

	public static float HitFeedbackSoundCD;

	public static bool EnableAllEyeLookAt;

	public static bool StreamingSceneUnloadMesh;

	public static bool StreamingSceneUnloadTexture;

	public static int StreamingSceneUnloadMemoryThreshold;

	public static int StreamingSceneUnloadMemoryThresholdIOS;

	public static float WaitSecsBeforeMatchResult;

	public static bool WaitStreamerBeforeMatchResult;

	public static float WaitStreamerBeforeMatchResultMaxSecs;

	public static bool TryFixStreamerCurrentSceneLoading;

	public static string StreamPerformanceMap;

	public static int LowMemPreviewStreamRange;

	public static float LowMemPreviewStreamMaxY;

	public static int WaitingLandCreateOthersFireworksCount_Quality_Lowest;

	public static int WaitingLandCreateOthersFireworksCount_Quality_High;

	public static int WaitingLandCreateOthersFireworksCount_Quality_Ultra;

	public static int SPHUDCSRoundMVPTime;

	public static bool RemoveRevivePointMarkWhenDeactivated;

	public static int RevivePointMarkShowDis;

	public static float RevivePointVFXShowDelta;

	public static bool RevivePointMarkStick;

	public static bool RevivePointUsingStreamer;

	public static bool EnableBriefBoxTween;

	public static int AutoEnemyMarkSwitch;

	public static float AutoEnemyMarkDuration;

	public static float AutoRecommendMessageDuration;

	public static bool AutoRecommendMessageSwitch;

	public static bool EnableFixWorkSyncRemoveData;

	public static float SPHudNameDangerTime;

	public static bool EnableDecryptionStaticBufferOpt;

	public static bool EnableMedkitUseSound;

	public static bool EnableCheckWaterWhileSwimming;

	public static bool EsportsGotoInternalBrowser;

	public static bool EnableRunNewGameWhenLoading;

	public static string DefaultMaleClothList;

	public static string DefaultFeMaleClothList;

	public static readonly float DriftBottleAddFriendAutoCloseTime;

	public static string HudEnableHiddenList;

	public static string MonitorNetworkReachabilityHostName;

	public static readonly float NetworkCallbackForceReconnectCooldown;

	public static bool EnableLeadEmotionIgnoreSameId;

	public static string AutoClearOverTimeOptionalType;

	public static string AutoClearUnOwnedOptionalType;

	public static uint AutoClearTimeDel;

	public static uint AutoClearDelFileOneFrameNum;

	public static bool EnableLoginQueue;

	public static uint RequestQueueInfoIntervalWhileQueueIsFull;

	public static uint MinIntervalForRequestQueueInfo;

	public static uint MaxIntervalForRequestQueueInfo;

	public static float PartyModeDiceSpeedScale;

	public static bool EnableVersionCode;

	public static bool EnableQueryVulkanSupport;

	public static string VNLinkUrl;

	public static uint UGCNotifyTimeOutLimit;

	public static uint UGCGameTimeMax;

	public static uint CustomRoomCountDownTime;

	public static uint UGCRoomCountDownTime;

	public static int UGCCustomHudMaxDepth;

	public static int UGCCustomHudMinDepth;

	public static int UGCCustomHud3DContainerZBase;

	public static int UGCCustomHud3DContainerZStep;

	public static int UGCTeammatesCountMax;

	public static int WereWolvesWinPointCountDown;

	public static float WereWolvesChatIntervalCoolDown;

	public static bool EnableRushingPetsRoomTab;

	public static bool EnableWereWolvesRoomTab;

	public static uint GachaNewAnimationSwitch;

	public static bool CanEsocrtVehicleBeDamaged;

	public static bool EnableGameVoiceRegion;

	public static bool InAppReviewEnabled;

	public static bool ScreenShotWithPostEffect;

	public static bool DisablePostEffectFor32BitUltra;

	public static int CameraFilterForLowDevicesMinMemory;

	public static float BROpeningDubbingDelay;

	public static float ItemMarkPressThreshold;

	public static float ResetPlayerInputInterval;

	public static float ItemMarkObjectCheckDistance;

	public static float ItemMarkWndAutoHideTime;

	public static float PCReplayEventForwardSec;

	public static bool SendBRDeadInfoEventLog;

	public static bool OpenGrassMergeFreeBuffer;

	public static bool EnableGrassMeshDirtyFlag;

	public static bool EnableGrassNormal;

	public static bool EnableFoliageSplitUpdate;

	public static bool EnableForceBuildVisibleVegetation;

	public static bool EnableVegetationMultiGrid;

	public static int VegetationClearPSDelayCount;

	public static int FoliageSpliteUpdateDelayFrame;

	public static float GrassSplitUpdateEnableAngle;

	public static float TreeSplitUpdateEnableAngle;

	public static float TreeSplitUpdateEnablePos;

	public static bool UnloadTreeMeshByLod;

	public static bool EnableGrassCamHFOV;

	public static float VegetationPreviewHeight;

	public static bool DisableDeviceIdentifier_iOS;

	public static bool DisableDeviceIdentifier_Android;

	public static bool EnableMessagePoolOptimization;

	public static bool EnableNewOnceAmmoMethod;

	public static bool EnableFrameByFrameShotGunHitEffectLoading;

	public static bool UseOptimizedBundleData;

	public static float PhysicsUtil_TRACE_STEP_LARGE;

	public static float PhysicsUtil_TRACE_STEP;

	public const int PhysicsUtil_MAX_STEP_NUM = 20;

	public static float PlayerStartTraceHeight;

	public static bool EnableFFAntihackInfoExtra;

	public static bool LoadoutQuickUseNoPersonalShop;

	public static bool LoadoutQuickUseEnabled;

	public static bool DisableLoadoutUseOnVehicle;

	public static bool OptUIPanel;

	public static bool EnableHighFreqPanelIsolation;

	public static int RenderUIToMainCam;

	public static bool UpdateUISprite;

	public static bool OptNGUIGetCompnentsGc;

	public static bool LazyCreateUIWidgetConers;

	public static readonly bool OptimzeFrameTimeOB37;

	public static readonly bool AllowForceCheckBtnChange;

	public static bool PanelLateUpdateToPreCull;

	public static int PanelUpdateSelfInterval;

	public static bool EnablePanelUpdateSelfInterval;

	public static bool UIDrawCallUseShaderNameCache;

	public static int MapContentPanelUpdateSelfInterval;

	public static bool EnableIOSKeyboardOptimization;

	public static bool UseMutableString;

	public static bool MutableStringUseDecoder;

	public static bool UIInGamePoolCheckDuplicate;

	public static bool ReplaceDicWithIntervalTree;

	public static bool MergeSortForIntervalTree;

	public static bool SortCsvForIntervalTreeAtBuildTime;

	public static bool ClearAnimControllerWhenSwitchWeaponFor2018;

	public static bool SkipWeaponAnimCtrlChangeIfSame;

	public static float CupMatchRequestUseTicketCD;

	public static bool AnimationUseRecordUniqueID;

	public static string BRMasterDefaultRankIconBig;

	public static string BRMasterDefaultRankIconSmall;

	public static string CSMasterDefaultRankIconBig;

	public static string CSMasterDefaultRankIconSmall;

	public static string MasterDefaultRankNameKey;

	public static bool EnableWorkShopBg;

	public static uint WorkShopBitMapBasicSize;

	public static int WorkShopIconMinSize;

	public static bool EnableSuspendUI;

	public static bool EnableSuspendInventory;

	public static bool EnableSuspendIngameShop;

	public static bool EnableSuspendIngameShopV2;

	public static bool EnableSuspendPersonalIngameShopV2;

	public static bool EnableSuspendLuckyDrawBox;

	public static bool EnableSuspendCSShop;

	public static bool EnableSuspendBountyBoxShop;

	public static bool EnableSuspendMiniMap;

	public static bool EnableSuspendWeaponInfoBox;

	public static bool DisableUpdateSuspendUI;

	public static bool ReportInstantiateJank;

	public static int InstantiateJankTimeLimit;

	public static bool ReportProtoTypeJank;

	public static string FacebookGraphAPIVersion_iOS;

	public static string FacebookGraphAPIVersion_Android;

	public static bool PromptInstallFacebookAfterLoginFailure_AndroidDevice;

	public static bool PromptInstallFacebookAfterLoginFailure_AndroidEmulator;

	public static bool EnableUnsafeReplicationData;

	public static bool DisableArrayMap;

	public static bool DisableLazyDictionary;

	public static bool EnableCachedIPV6State;

	public static bool EnableWheelRollGSSidePhysics;

	public static bool HackEpicClothesToMaxLevel;

	public static bool UseOptEventDispatch;

	public static bool EventDispatchReuseArgArray;

	public static bool VegetationManagerUseJobs;

	public static bool DynamicGeneratorUseJobs;

	public static bool VegetationManagerStartOpt;

	public static bool EnableForceDestroyCDNTextures;

	public static int CupApplicationListRequestCD;

	public static int CupInvitationListRequestCD;

	public static int CupFriendTeamInfoRequestCD;

	public static int PropCatapultMaxUseTimes;

	public static int RoomShowChatMessageMaxCount;

	public static uint SceneEdit_RotateDegree;

	public static uint SceneEdit_PressRotateSpeed;

	public static float SceneEdit_LongPressInterval;

	public static float SceneEdit_ContinuousDeleteInterval;

	public static float SceneEdit_DeleteTutorialInterval;

	public static float UGCMiniSentryAttackRangeNear;

	public static float UGCMiniSentryAttackRangeMiddle;

	public static float UGCMiniSentryAttackRangeFar;

	public static bool EndHudActionTriggerOnDead;

	public static bool ReturnStropTriggerOnDead;

	public static bool EnableCacheNotable3pIcewallGeMedium;

	public static bool EnableCacheNotable3pSkillGeHigh;

	public static bool UseMemberShipSystemReplaceRebateCardSystem;

	public static bool MobileReplay_Enabled;

	public static bool MobileReplay_UsingOptimized1PPacketForReplay;

	public static bool MobileReplay_UsingOptimized1PPacketForRecord;

	public static bool MobileReplay_RecordPing;

	public static int MobileReplay_RecordPingDeltaMs;

	public static bool MobileReplay_RoundBtnUpdate;

	public static float MobileReplay_RoundBtnUpdateRate;

	public static bool MobileReplay_WhiteListForceSaveWhenPlay;

	public static bool MobileReplay_SaveAfterPlay;

	public static float MobileReplay_MinDiskSpace;

	public static bool MobileReplay_ForceOpen;

	public static float MobileReplay_TimeForward;

	public static float ReplayAutoSnapTime;

	public static bool IsBackwardReplayOpen;

	public static bool MobileReplay_HandleFrame;

	public static readonly float MobileReplay_PanelLifeTime;

	public static readonly float MobileRelay_AchievementDelay;

	public static readonly float MobileRelay_AchievementDuration;

	public static readonly int MobileReplayHighlightUpperTime;

	public static readonly int MobileReplayHighlightMergeTime;

	public static readonly bool UserUnityPlayerHighlihtPlayer;

	public static readonly int HighlightKnockdownStreakCount;

	public static readonly int MobileReplayHighlightMergeDistance;

	public static readonly bool IsTeamingReplayEnable;

	public static readonly int HighlightMultikillCount;

	public static readonly int MultikillHighlightNumber;

	public static readonly float ReplayAutoAccelerateTime;

	public static readonly bool UseMinimalEncoder;

	public static bool ShowChatBubble;

	public static float TeamChatBubbleDuration;

	public static float AimAssistTeammateScore;

	public static bool ShowHealingGunScreenEffect;

	public static bool PhysicFreezeBlockUserControl;

	public static float RefreshLuckyBagInfoCoolDownTime;

	public static bool FixStationaryAxisMoving;

	public static float FixStationaryAxisMovingThreshold;

	public static bool DisableRushingPetsUMA;

	public static float MapUIShowDeadBoxDuration;

	public static bool EnableFixTrainingSoundCloseWhenZoneChange;

	public static readonly string PollEventCounts;

	public static readonly string PollDuration;

	public static readonly int MaxImmediateEventCount;

	public static readonly uint ObGlobalEventEffectTimeMs;

	public static readonly uint ObEventEntryShowTimeSeconds;

	public static readonly bool DisableHDTeammateFor32Bit;

	public static int InGameChatSendCD;

	public static string SkipShadowCasterCheck;

	public static bool SetCastShadowAccordingToPlaneActive;

	public static bool SkipDisableShadowKeyword;

	public static bool LightShadowChangedInGroupMode;

	public static bool LobbyCloserShadow;

	public static bool UseCurrentServerTime;

	public static bool LoadDynamicAnimationClip;

	public static bool FixDynamicAniamtionClip1;

	public static bool DateTimeUtilServerTimeToLong;

	public static bool EnableReportSystemTimeDelta;

	public static bool FixDynamicAniamtionClip2;

	public static bool LoadDynamicAnimationClipOpt;

	public static bool LoadDynamicAnimationClipOptForInfectionMode;

	public static bool LoadAllDynamicAnimationClipsForHigh;

	public static bool LoadDynamicAnimationClipInUGC;

	public static bool OptSwitchAnimatorController;

	public static bool ClearAnimatorCacheOnDestroy;

	public static bool FixNoneBaseAniController;

	public static bool UseAnimationCacheInCustom;

	public static bool OptBindAnimator;

	public static bool UseAnimationClipOverridesDic;

	public static bool RevertCustomAnimOnSwitchOvc;

	public static bool WriteDefaultsUsingCachedOvc;

	public static bool FixAnimUnload;

	public static bool FixAnimUnloadOnlyNull;

	public static int RUSHINGPETSDISABLEBGM;

	public static bool ForceEnable3I3A;

	public static bool ForceDisable3I3A;

	public static int MemFor3gIOS;

	public static bool LazyLoadPlayerAnimClipsFor3I3A;

	public static bool LessClothesFor3I3A;

	public static ulong ClothesFlagFor3I3AForLowest;

	public static ulong ClothesFlagFor3I3AForLow;

	public static ulong ClothesFlagFor3I3AForHigh;

	public static bool LessPlayerInCabinFor3I3A;

	public static ulong PlayerInCabinFor3I3AForLowest;

	public static ulong PlayerInCabinFor3I3AForLow;

	public static ulong PlayerInCabinFor3I3AForHigh;

	public static int MaxPreloadMemLevelFor3I3A;

	public static bool ReleaseMemForMatchEndFor3I3A;

	public static bool HideSkinIfClothHiddenFor3I3A;

	public static bool CompressResMgrUrlsFor3I3A;

	public static bool NoShowFist3PFor3I3A;

	public static bool NoPlay3PNonTeammateEmoteFor3I3A;

	public static bool EnableUMAGCFor3I3A;

	public static bool ReleaseLightmapMemoryFor3I;

	public static bool NoPreloadInvisiblePlayerClothesFor3I;

	public static bool EnableLowMemoryCallbackFor3I3A;

	public static bool EnableLowMemoryUnloadFor3I3A;

	public static bool NoDisableAutoGcInGameFor3I3A;

	public static bool EnableCustomUIAtlasReleaserFor3I;

	public static bool ValidateCustomUIAtlasReleaserIngameFor3I3A;

	public static int EnableOptRemapperFor3I3A;

	public static bool DestroyNGUIMeshFor3I3A;

	public static bool DestroyNGUIMeshForLowMem;

	public static int DestroyNGUIMeshReserveCnt;

	public static int DestroyNGUIMeshMinVertsCnt;

	public static int DestroyNGUIMeshCheckCnt;

	public static bool EnableAutoGcOnShowMatchResult;

	public static bool DelayDisableAutoGcToCloseMaskFor3I3A;

	public static bool OptMemForAsyncLoadTickets;

	public static readonly bool FixUIDrawCallLeak;

	public static readonly bool OptMemForUIGeometry;

	public static readonly bool OptMemForUIGeometrySameCols;

	public static bool OpenBrightnessStretch;

	public static float DefaultBrightnessStretchThreshold;

	public static float DefaultBrightnessStretchSpeed;

	public static int VeteranLeaveTime;

	public static int VeteranBrLifetime;

	public static int VeteranBrKill;

	public static int VeteranBrMostKillsInMatch;

	public static int VeteranBrRevives;

	public static int VeteranBrSurvival;

	public static int VeteranBrLimit;

	public static int VeteranCsLifetime;

	public static int VeteranCsQuadraKill;

	public static int VeteranCsTripleKill;

	public static int VeteranCsDoubleKill;

	public static float VeteranCsWinRate;

	public static float VeteranCsHeadshotRate;

	public static int VeteranCsKill;

	public static int VeteranCsLimit;

	public static int VeteranShowGunsLimit;

	public static int VeteranShowLadderMatchSeasonInfoCsLimit;

	public static readonly bool VeteranReturnShowNewGamePlay;

	public static bool EnablePetModeVoiceChat;

	public static bool EnablePCShowCSAirDropUI;

	public static readonly bool OptSkillTemplateRaycast;

	public static readonly bool OptCsShopShowHide;

	public static readonly bool EnableCsShopTeammateWeaponInfoV2;

	public static readonly bool EnableCsShopTeammateWeaponInfoV2ShowCoin;

	public static readonly bool EnableCsShopKeepHorizontalReposition;

	public static readonly int EnableLoadResconfAndLocEarly;

	public static readonly int EnableBugReportEarly;

	public static readonly int BugReportMaxCountPerSession;

	public static readonly bool EnableVibrateSDK;

	public static readonly float VibrateVehicleSpeedUpMaxFactor;

	public static readonly float VibrateVehicleSpeedDownMaxFactor;

	public static readonly float VibrateVehicleStartFactor;

	public static readonly float VibrateEnemyMaxDistance;

	public static readonly float VibrateVehicleCheckInterval;

	public static readonly bool VIBRATION_FOOTSTEPSSWITCH;

	public static readonly bool VIBRATION_GUNFIRESWITCH;

	public static readonly bool VIBRATION_HUNTSWITCH;

	public static readonly bool VIBRATION_AUTOWEAPONSSWITCH;

	public static readonly bool VIBRATION_HALFAUTOWEAPONSSWITCH;

	public static readonly bool VIBRATION_BLOTWEAPONSSWITCH;

	public static readonly bool VIBRATION_MELEEWEAPONSSWITCH;

	public static readonly bool VIBRATION_OTHERWEAPONSSWITCH;

	public static readonly bool VIBRATION_CARDRIVINGSWITCH;

	public static readonly bool VIBRATION_CARHUNTSWITCH;

	public static readonly bool VIBRATION_CARCRASHSWITCH;

	public static readonly bool VIBRATION_MOUNTABLEANIMALSWITCH;

	public static readonly bool VIBRATION_ROULETTE;

	public static readonly bool VIBRATION_PICKUPITEM;

	public static readonly int CardCoolDownCasual;

	public static readonly int CardCoolDownAdvanced;

	public static readonly int CardCoolDownWerewolves;

	public static readonly int CardCoolDownWorkshop;

	public static readonly uint RecommandedNeedKillCount;

	public static readonly uint RecommandedNeedDamage;

	public static readonly bool IsBRModeDestructibleEnabled;

	public static readonly bool StorePreviewKeepHairWhenSameAvatarIDSwitch;

	public static readonly int MAX_WorkshopSettingLength;

	public static readonly int MAX_AttributeSettingLength;

	public static readonly int MAX_ModeSettingLength;

	public static readonly float WinterLandBGMReducePrecent;

	public static readonly float WorkShopItemCirclePlayTime;

	public static readonly int MaxTempReplayNumber;

	public static bool UseIntKeyModels;

	public static readonly int EnableFluxInLobbyIfQualityGreaterEqualThan;

	public static readonly int EnableFluxInGameIfQualityGreaterEqualThan;

	public static readonly float GameMissionTimeWarningPercentage;

	public static readonly float GameMissionStartTipsDuration;

	public static readonly float GameMissionEndTipsDuration;

	public static readonly string GameMission_SpawnPoint_MatchMode;

	public static readonly bool GameMission_HitList_RoomSwitch;

	public static readonly float LobbyGachaIntroDuration;

	public static readonly float EmoteBGMReducePrecent;

	public static readonly float ModePreference;

	public static readonly int RankModePrefenceCount;

	public static readonly bool EnableIOSDeleteAccount;

	public static readonly float TreasuryGateOpenTime;

	public static readonly float UGCMapContentScopeScale;

	public static readonly float MaxAnimSpeed;

	public static readonly bool NeedShowTransformAfterSingleAnim;

	public static readonly bool NeedRequestGameOpeningInfoAgain;

	public static readonly bool NeedAimAssistOnChargeFinish;

	public static readonly bool NeedCancelAvatarTransformerLoad;

	public static readonly bool NeedAutoAdjustHeight;

	public static readonly bool NeedShowSwitchFailedTips;

	public static readonly bool Use3pPetModelIfPoolQualityOrMemory;

	public static readonly bool BigHeadKillUIAsyncLoad;

	public static readonly float SkateStartCameraAnimOffset;

	public static readonly float SkateCameraAnimTime;

	public static readonly float StarFallingSpeedH;

	public static readonly float StarFallingSpeedV;

	public static readonly bool EnableBloom;

	public static readonly float FlightGravity;

	public static readonly float TunnelSkateBoardFowardSpeed;

	public static readonly float TunnelSkateBoardLeftAndRightSpeed;

	public static readonly float SingersHudTonePreTime;

	public static readonly float SingersBPlayerCallDanceScale;

	public static readonly uint SingerBSkateBoardID;

	public static readonly uint SingerBFlightID;

	public static readonly uint SingerBTimeLineFastSpeed;

	public static readonly float SingersBHoverBoardAniBlendSpeed;

	public static readonly int SingersBLowQualityShowPlayerCount;

	public static readonly float SingersBBigScreenShotShowTime;

	public static readonly float SingersBStarFallingSafeHeight;

	public static readonly string MshopLandingWebFlag;

	public static readonly string MshopTestLandingWebFlag;

	public static readonly string AutoFlightRootPos;

	public static readonly string AutoFlightRootRot;

	public static readonly float AutoFlightBombIdleYOffset;

	public static readonly float BalloonCoolDownTime;

	public static readonly float BalloonUpSpeed;

	public static readonly float BalloonExistTime;

	public static readonly int BalloonMaxNum;

	public static float Treatment_warn_boundary;

	public static readonly float UIAvatarLinkBubbleDisplayLength;

	public static readonly int UIAvatarLinkBubbleClickCooldown;

	public static float LagEffectDurationTime;

	public static float LagEffectKeepScaleDistance;

	public static float LagEffectScaleMaxDistance;

	public static float LagEffectMaxShowDistance;

	public static float LagEffectMaxScale;

	public static bool UseFixCrossHeight;

	public static int CreditBehaviorHighPingValue;

	public static int CreditBehaviorHighPingLastTime;

	public static string CustomRoomModeNum;

	public static float DWShieldOffset;

	public static string VersionDownloadLink;

	public static bool BlockUrlAndEmail;

	public static bool BlockPhoneNumber;

	public static bool BRShowStackKillVfx;

	public static int UGCQuitFeedback;

	public static float MarkScreenOffsetTop;

	public static float MarkScreenOffsetBottom;

	public static float MarkScreenOffsetLeft;

	public static float MarkScreenOffsetRight;

	public static float ItemMarkScreenOffsetTop;

	public static float ItemMarkScreenOffsetBottom;

	public static float ItemMarkScreenOffsetLeft;

	public static float ItemMarkScreenOffsetRight;

	public static bool UGCQuitMidwayNeedShowMatchResultComment;

	public static bool DeleteInventoryByUniqueID;

	public static int NBReviveVFXMinHeight;

	public static float NBScrollItemSpawnForwardDis;

	public static readonly int RoomAutoRevivalToken;

	public static readonly uint BRShopTokenGunTeamHitProgressMax;

	public static readonly uint BRShopTokenGunTeamHitProgressDecayStaleMs;

	public static readonly uint BRShopTokenGunTeamHitProgressDecayPerSecond;

	public static readonly float BRShopTokenGunTeamHitExplodeEffectDuration;

	public static readonly int RoomAutoRevivalLimitStage;

	public static readonly uint RoomAutoRevivalLimitTimes;

	public static readonly float UpgradeGemGetFragmentAnimTime;

	public static readonly float UpgradeGemGetCompleteAnimTime;

	public static readonly float UpgradeGemGetLevelUpAnimTime;

	public static readonly int DWShieldFixPosInterval;

	public static readonly bool SkillUpgradeMaxWhenPlayerLevelMax;

	public static readonly bool Use3PStopFire_WaitingChangeClipAnim;

	public static readonly bool UseIngameHudMiniSwitch;

	public static readonly bool ShowWeaponSkinActiveButton;

	public static readonly bool IsMergeDoubleHoldButton;

	public static readonly bool IsEvogunBuffShow;

	public static bool OptimizeLoadUmaText;

	public static readonly float GrapplingHookGunFOV;

	public static readonly float FateRandomSubmodeShowTime;

	public static readonly float DigitaluniverseBGScaleMin;

	public static readonly float DigitaluniverseBGScaleMax;

	public static readonly float DigitaluniverseBGScaleHideNameThre;

	public static readonly float DigitaluniverseBGPosx;

	public static readonly float DigitaluniverseBGPosy;

	public static readonly float DigitaluniverseBGBlurMin;

	public static readonly float DigitaluniverseBGBlurMax;

	public static readonly float DigitaluniverseFake3DParam;

	public static readonly float DigitaluniverseBGPosx1;

	public static readonly float DigitaluniverseBGPosy1;

	public static readonly float LevelContainerUpDelta;

	public static readonly bool NoLevelContainerUpDeltaForZeroRadius;

	public static float BlockEditHoldDelay;

	public static bool EnableBlockEditOptimized;

	public static int BlockEditOnceBuildPresetBlockNum;

	public static uint BlockEditExpandableMaxCount;

	public static float BlockEditSearchAPIUtilizationFactor;

	public static readonly string BigPrizePushCameraEndPosition;

	public static readonly string BigPrizePushCameraRotation;

	public static readonly uint BRAirDropLightPickUpDeleteTime;

	public static readonly float BRAirDropLaserShrinkPercent;

	public static readonly float UseEnergyStoneBoxTime;

	public static readonly float UseChokePointTime;

	public static readonly float PCKillLeaderAnimationTime;

	public static readonly bool UploadCheckDataOnlyOnce;

	public static readonly uint MedkitElseID;

	public static readonly bool EnablePocketReviveUseSoundAsync;

	public static readonly bool EnableTrainingIslandBloom;

	public static readonly bool UseNewPin;

	public static readonly float PickUpPinDeltaDelayTime;

	public static readonly int RoyaleVFXNumUpper;

	public static readonly int LoadingWaitingTime;

	public static readonly float SeafoodLittleGirlBoxInterTime;

	public static readonly float SeafoodLittleGirlStartTurnHeadTime;

	public static bool DelayShowKillNotification;

	public static bool DelayRefreshTeammatesOnSwitchObserver;

	public static bool PlayerEffectUseAsyncLoad;

	public static bool PlayerParachuteSkinUseAsyncLoad;

	public static bool PlayerParachuteUseAsyncLoad;

	public static readonly int PreInitPoolMaxSize;

	public static bool PrePoolInstantResource;

	public static int PrePoolInstantPerFrame;

	public static bool PrePoolInstantResource_FrontEndGame;

	public static bool PreInstantHudName;

	public static bool OpenInventorySmooth;

	public static bool InitInventoryItemPool;

	public static bool InitSkillTemplatePool;

	public static bool DisableCharactorColliderAndAnimatorOnPlane;

	public static readonly float UGCWeaponDamageRateSuper;

	public static bool UseColliderFilter;

	public static float Gun_Line_Check_Step_Change_Threshold;

	public static readonly bool RecycleCarAudioOnGetOff;

	public static readonly bool DelayInstCarShoalAudio;

	public static readonly bool RecycleWeaponBoxOpenEffect;

	public static string SkipOptionalMapConfigIdArray;

	public static string SkipOptionalMapIdArray;

	public static int UGCAutoDownloadSizeOutsideRoom;

	public static int UGCAutoDownloadSizeInRoom;

	public static string UGCUnlockForSmallSizeRemainToDownloadRegions;

	public static uint UGCCustomResUpdateTimeThreshold_Short;

	public static uint UGCCustomResUpdateTimeThreshold_Long;

	public static bool FixPreLoadResourceID;

	public static bool RouletteChatEnable;

	public static bool MedkitRouletteEnable;

	public static bool GrenadeRouletteEnable;

	public static float IcewallReleaseDistance1;

	public static float IcewallReleaseDistance2;

	public static bool SmartIcewallOpen;

	public static float NewbieIcewallControl;

	public static int NewbieSmartIcewallAutoChangeWeaponLevel;

	public static int SmartIcewallAutoChangeWeaponForceFireTick;

	public static float SmartIcewallTime;

	public static float SmartIceWallDownRayLength;

	public static int SmartIceWallFireWaitTickCnt;

	public static float SmartIceWallDownRayLength2;

	public static int SmartIceWallDownRayMaxCheckCnt;

	public static bool IsHotMapUGCMatchMakingEnabled;

	public static int HalfWayJoinPerTimes;

	public static float TechDeviceDragMinTime;

	public static string QuickReloadDefaultValue;

	public static string FreeLookDefaultValue;

	public static string RunModeDefaultValue;

	public static string VehicleControlModeDefaultValue;

	public static string SmartIceWallShowDefaultValue;

	public static string FootStepsVibrateDefaultValue;

	public static string CrossHairReloadDefaultValue;

	public static string CrossHairModeDefaultValue;

	public static string HUDButtonHintNewbieValue;

	public static int InitialSettingLevelLimit;

	public static string DisableInGameQuitMatchMode;

	public static string DisableKillDetailMatchMode;

	public static string DisableKillDetailGameMode;

	public static float ReplayHighlightScore;

	public static float CoinCountChangeTime;

	public static float ChangeToSuperMedkitHP;

	public static float ChangeToSuperMedkitCD;

	public static float UsingShieldRecoverHPThreshold;

	public static float InfectionHPShowTime;

	public static bool InfectionOpenGameVoice;

	public static float ReplayOverlookHeight;

	public static float SpecialCharacterVoiceCoolDown;

	public static int ModeChooseType;

	public static bool EnableHighlightAnim;

	public static float HighlightAnimForwardSecond;

	public static float HighlightAnimTotalSecond;

	public static int HighlightMemoryLowMB;

	public static int HighlightMemoryMidMB;

	public static float HighlightStartDelayShort;

	public static float HighlightStartDelayLong;

	public static int HighlightStartDelayMemoryMB;

	public static bool NeedProcessAH;

	public static bool EnableConveyer;

	public static bool Enable3PEnterMovePlatform;

	public static float DigitalUniverseBCoreImageDistance;

	public static float DigitalUniverseBFake3DFocusDistance;

	public static uint DigitalUniverseBTrackPeopleMaximumNumberFactor;

	public static int Trackradius;

	public static float Coefficientofcompressibility;

	public static float Planetoffset;

	public static int DigitaluniverseBGuiderail;

	public static bool EnableVegetationSimulateInterval;

	public static bool EnableVegetationLODUnload;

	public static bool DisableVegetationSameMeshUnloadInOldParadise;

	public static int VegetationSimulateFrameInterval;

	public static int VegetationFindPotentVisibleInterval;

	public static float VegetationSplitUpdateEnableAngle;

	public static float VegetationSplitUpdateEnablePos;

	public static int QuadraKillThumbTimerMaxLimit;

	public static int WaitingPhaseThumbUpBtnShowTime;

	public static bool HideWaitingPhaseThumbUpAfterClick;

	public static bool NBOrangeFoxStartGameAnimHidePreview;

	public static float NBKuramaSpecialAnimInterval;

	public static float NBOrangeFoxCameraShakeDuration;

	public static float NBOrangeFoxCameraShakeFactor;

	public static float NBOrangeFoxStartGameAnimDelay;

	public static float NBOrangeFoxShootTreasureOffsetY;

	public static string NBOrangeFoxHitInterval_1;

	public static string NBOrangeFoxHitInterval_2;

	public static string NBOrangeFoxHitInterval_3;

	public static string NBOrangeFoxHitTreasuryInterval;

	public static float NBOrangeAttackHoleIconDeleteTime;

	public static float NBOrangePlaneDropHeightPercent;

	public static float NBRamanInteractTime;

	public static float NBRamanLoopTime;

	public static float NBTransformSpeed;

	public static bool NBOrangeFoxSkipPreloadReconnect;

	public static bool NBOrangeFoxUnloadAssetAfter1PLanding;

	public static bool NBSkipSkillSpitPostAnimIfInIdle;

	public static float SeafoodCookieShopInteractTime;

	public static float InfiniteEatCakeTime;

	public static float WLGP25DeerActionTime;

	public static float InfiniteCakeCD;

	public static float InfiniteCakeHPEPRange;

	public static int LandingPOIHistoryCount;

	public static bool EnableDynamicGeneratorTickInterval;

	public static int DynamicGeneratorTickInterval;

	public static float DynamicGeneratorTickUpdateEnableAngle;

	public static float DynamicGeneratorTickUpdateEnablePos;

	public static bool EnablePlayerPostUpdateInterval;

	public static int PlayerPostUpdateInterval;

	public static bool EnablePlayerPostUpdateIntervalByFrustum;

	public static int PlayerShadowUpdateInterval;

	public static bool EnablePlayerUpdateKinematicsInterval;

	public static int PlayerUpdateKinematicsInterval;

	public static bool EnablePlayerUpdateBehaviourInterval;

	public static int PlayerUpdateBehaviourInterval;

	public static bool EnablePlayerUpdateBehaviourIntervalByFrustum;

	public static bool EnablePlayerUpdateIntervalByFrustum;

	public static float CameraFrustumDeltaAngle;

	public static bool EnableOptionalDownloadVersionMutableSplit;

	public static bool EnablePlayerUpdateIntervalByDistance;

	public static int PlayerUpdateIntervalDistance;

	public static int ForcePlayerUpdateDistance;

	public static int PlayerNotUpdateDistance;

	public static bool FrezeeInvisiblePlayerUpdate;

	public static bool EnableClickEffectInputPosCheck;

	public static bool EnableOptAnimationIntervalByFrustum;

	public static bool EnableHudItemMarkUpdateInterval;

	public static bool EnableMinimapUpdateInterval;

	public static bool EnableHudNameBaseUpdateInterval;

	public static bool EnableMapContentUpdateInterval;

	public static float MapContentUpdateDistance;

	public static int MapContentUpdateAngle;

	public static bool EnableWeaponSwitchInfoUpdateInterval;

	public static bool EnableHudNameControllerUpdateInterval;

	public static float HudNameControllerUpdateDistance;

	public static float HudNameControllerHPDiff;

	public static float EliteHPShowDistance;

	public static bool EnableRescureUpdateInterval;

	public static bool EnableSafeZoneInfoUpdateInterval;

	public static bool EnableDirectionRulerUpdateInterval;

	public static bool EnableHudKillNotificationUpdateInterval;

	public static bool EarlyInitGGP;

	public static bool LoadUmaIndexerAfterGGP;

	public static bool EnablePVS;

	public static bool EnablePVSAsyncLoad;

	public static bool EnablePVSAsyncLoadAB;

	public static bool EnablePVSDebug;

	public static bool EnablePVSSkipVersionCheck;

	public static bool EnablePVSOnLowMemory;

	public static bool EnablePVSCullParticleSystem;

	public static bool EnablePVSInPony;

	public static bool EnablePVSInSonoran;

	public static bool EnablePVSInShangrila;

	public static bool EnablePVSInParadiseBase;

	public static bool EnablePVSInParadiseExchangeA;

	public static bool EnablePVSInParadiseExchangeB;

	public static bool PVSAsyncTileTicketMismatchFix;

	public static bool EnablePotentiallyVisibleSet;

	public static bool EnablePVSCustomTile;

	public static bool EnablePVSForceRenderingOff;

	public static bool EnablePVSStaticObject;

	public static bool EnablePVSCombineData;

	public static int DisablePVSItemTyeFlag;

	public static bool EnableDynamicPVS;

	public static bool EnableDynamicPVSForPlayer;

	public static bool EnableDynamicPVSSkipVersionCheck;

	public static bool EnableInGameMinimapAABBTest;

	public static bool EnableOptTransformPoint;

	public static bool EnableWeaponSkinPokedex;

	public static bool EnableWeaponSKinPokedexShare;

	public static int InGameExtractRenderNodePerJob;

	public static int DefaultExtractRenderNodePerJob;

	public static bool PlayerHookOnZeppelin;

	public static bool AirZeppelinUseSpecifiedStropPoint;

	public static uint SingersBSpeedSkill;

	public static bool AirZeppelinOpenBattle;

	public static readonly int LobbyFaultVFXSwitch;

	public static bool FixFireAnimWhenUseInhaler;

	public static bool EnableLuckyDrawBoxLevelEffect;

	public static bool Stop3PFireAnimLocally;

	public static int ReplaceRGB565Behavior;

	public static float VehicleDirveCameraHeightCheck;

	public static bool GachaNeedRecoverPreview;

	public static float MeleeWeaponPotentialTagetCheckInterval;

	public static bool CrossHairNullTargetDefaultAimingRed;

	public static bool ParellelForEachInitOptionalDownloadFile;

	public static bool IsDeadTalkOpen;

	public static bool IsDownMarkMapOpen;

	public static int CSShopRecommendRank;

	public static int CSShopRecommendFightLimit;

	public static int CSItemNewTagLimit;

	public static int BRHotTagRank;

	public static int BRItemHotTagLimit;

	public static int BRItemNewTagLimit;

	public static float OpenItemNewHotTagValue;

	public static int SAPFlodWingJumpHight;

	public static int SAPFlodWingJumpSpeed;

	public static int SAPFlodWingID;

	public static bool FirstLoadFrontEndGameAssetWaitCleanUp;

	public static int MultithreadPreloadThreadCount;

	public static bool RefreshCapacityByServerSync;

	public static bool OBHUD_EMOJI_ASYNC_LOAD;

	public static string ObserverEmojiRes;

	public static readonly int ObserveEmojiCd;

	public static readonly int ObserveLikeCd;

	public static readonly uint ObserverReward;

	public static readonly bool KickUserInMatchGame;

	public static bool IsLiftUpSquatIconOpen;

	public static float WholeBodyFireMaxWaitTime;

	public static float FootballGame_MaxHitSoundSpeed;

	public static float FootballGame_WaitingTime;

	public static float FootballGame_MatchTime;

	public static bool FootballGame_Open;

	public static string FootballGameOpenTime;

	public static string FootballGameEndTime;

	public static string Football_ItemInfo;

	public static bool EnableResourcePathCompression;

	public static bool EnableStoreResMemOptimize;

	public static bool EnableActivityInfoMemOptimize;

	public static bool ReleaseMemAfterGetProtolData;

	public static bool ForceSkipUIPanel;

	public static bool ForceSkipBigMapEnable;

	public static bool DisableAsyncLoadInGameUnloadUnuse;

	public static bool EnableStringCache;

	public static bool EnableUMAMaxNumOpt;

	public static float BPSpineAnimStepFourTime;

	public static float BPSpineAnimStepTwoTime;

	public static float AbandomLifeTime;

	public static float MicPressedThresholdTime;

	public static int LockInZepplinTickCount;

	public static float NewSeasonTipTime;

	public static float SeasonEndTipTime;

	public static bool EnableUpdateNearWaterForLowQuality;

	public static float UpdateNearWaterForLowQualityBeginHeight;

	public static float UpdateNearWaterForLowQualityEndHeight;

	public static bool IsWinCountResultAnimationOn;

	public static bool IsWinCountResultOn;

	public static bool IsWinCountLeaderboardOn;

	public static string WinCountLobbyGameMode;

	public static int MinWinCountNum;

	public static int MinBooyahCountNum;

	public static readonly uint CSSpecialWinStreakNum;

	public static readonly uint BRSpecialWinStreakNum;

	public static bool LogFpsToFileOnLeaveGame;

	public static bool RegisterGcFinished;

	public static bool LogGcFinished;

	public static bool CloseGCInRefreshConfig;

	public static bool CloseGCInRefreshConfigForLowMem;

	public static bool CloseGCInRefreshConfigForIOS;

	public static bool GetGcFinishedTime;

	public static bool EnableDumpIl2cppStats;

	public static int DumpIl2cppStatsDeep;

	public static bool CloseBRAutoHasGroup;

	public static bool OptPathNameMgrMemForLowMemOnly;

	public static bool OptPathNameMgrMemFor32Bit;

	public static int OptPathNameMgrMem;

	public static int OptPathNameMgrIDRemap;

	public static int OptMonoScriptNameMem;

	public static int OptMonobehaviourNameMem;

	public static int OptPathNameMgrVecMem;

	public static bool OptPathNameMgrVecMemForLowMemOnly;

	public static bool Use8AlignmentFor32Bit;

	public static bool Use8AlignmentFor32BitForUnity22;

	public static bool ClearRefsAfterPreloadDone;

	public static int ClearLoadedResBeforeUnloadUnusedInterval;

	public static int GameEntryAwakeMsLimit;

	public static int GameEntryAwakeMsLimitBeforePreloadConfigData;

	public static int DelayLoadIl2cppSoOption;

	public static bool FastQuit_NativeDoneFast;

	public static bool FastQuit_JoinThreadsWithTimeout;

	public static int FastQuit_JoinThreadsTimeoutMs;

	public static bool FastQuit_KillOnJoinThreadsTimeout;

	public static int FastQuit_UnityPlayerDestroyTimeoutMs;

	public static int FastQuit_UnityPlayerUpdateDisplayTimeout;

	public static bool FastQuit_UnityPlayerUpdateDisplayCheckRunning;

	public static bool LogQuitTimeout;

	public static bool EnableOptPreloadTable;

	public static bool Enable2018PostEffect;

	public static bool FixTexFormatCrash;

	public static bool EnableGetGPUTime;

	public static bool EnableSyncInUpdateTime;

	public static bool EnableVSyncFix;

	public static bool EnableForceSafeForMonoBehaviour;

	public static bool EnableFixGeneralConnection;

	public static bool EnableKTX2;

	public static bool TryFixShaderCrash;

	public static bool EnableShaderDebugCompileInfo;

	public static bool EnableShaderSimpileCompileInfo;

	public static bool EnableSetSourcePlayableScript;

	public static bool EnableBlendShapeDataCompress;

	public static bool DisablePreloadShaderByFBX;

	public static bool TryFixAnrUnitySendMessage;

	public static bool TryFixGetChunkParametersCrash;

	public static bool TryFixGetMeshBufferCrash;

	public static bool TryFixRenderFlareCrash;

	public static int ShaderVersionFor2022;

	public static bool EnableBuildTimePickupMerge;

	public static bool EnableUnity2018ShaderFor2022;

	public static bool FixParticleMemOptFor22;

	public static bool ForceNonPooledFileCacherRead;

	public static bool MemsetZeroWhenFileIOFailed;

	public static bool SafeFreeFSBDataWhenIOFailed;

	public static bool OpenMetalLanguageVersionSelect;

	public static bool CheckCompressSkinMeshRender_2022;

	public static bool EnableGfxDevicePointerValidation;

	public static bool EnableResourceIDProtect;

	public static bool EnableInitFramedLoading;

	public static bool EnableInitFramedLoading_2022;

	public static bool EnableForceBothCompress;

	public static uint LazyInitIl2cppMetaInfo;

	public static uint LazyInitIl2cppMetaInfoV2;

	public static uint LazyInitIl2cppMetaInfoV2ForUnity22;

	public static int ReuseRegistrationMem;

	public static int EnableIOSLazyIl2cppMemThreshold;

	public static bool EnableAndroidLazyIl2cpp32Bit;

	public static int Il2cppGenericMethodSetReserveSize;

	public static int Il2cppUseNoEraseMaps;

	public static bool DisableAutoGcInGame;

	public static float DisableAutoGcInGameMinMemGb;

	public static long MonoMemIncrementForGc;

	public static int MonoMemCheckFrameInterval;

	public static float DisableAutoGcInGameMinMemGb_Lowest;

	public static float DisableAutoGcInGameMinMemGb_Low;

	public static float DisableAutoGcInGameMinMemGb_High;

	public static float DisableAutoGcInGameMinMemGb_UltraPlus;

	public static bool EnableInGameSettingCoroutine;

	public static float PrimeSetShareGroupMemberInfoGuideTime;

	public static bool OptStreamerUpdateForObjectTokenMachine;

	public static bool OptStreamerUpdateForInGameShop;

	public static float OptStreamerUpdateForInGameShopAdditionalRange;

	public static int WaitingRoomTakePhotoPlayEmoteId;

	public static float WaitingRoomTakePhotoPlayEmoteNormalizeTime;

	public static bool DelayVehicleEngineVoice;

	public static int VehicleEngineWaitFrame;

	public static bool IsCDNDownloadFailEventLogSend;

	public static int CDNDownloadFailEventLogNumber;

	public static bool IsMotorcycleFrontWheelRotatePolish;

	public static string GooglePlaySubscriptionManagementUrl_Web;

	public static string AppStoreSubscriptionManagementUrl_Web;

	public static string GooglePlaySubscriptionManagementUrl_App;

	public static string GooglePlayStorePackageName;

	public static string AppStoreSubscriptionManagementUrl_App;

	public static bool LogProtocolStats;

	public static bool UILabelTopMargin;

	public static bool UILabelNeedCJKFilter;

	public static bool EnableGameVoiceVolumeBalance;

	public static float GameVoiceVolumeBalanceLeftValue;

	public static float GameVoiceVolumeBalanceRightValue;

	public static uint SmurfAccountTimeDetectionThresholdValue;

	public static bool IsBeMarkIceWallShowSelfMarkIcon;

	public static bool DisableFlySnowEffect;

	public static readonly float PinStatusAutoSwitchDuration;

	public static readonly float PinStatusSwitchDuration;

	public static float MaxUGCSpeedUpScale;

	public static float MaxRunSpeedUpScale;

	public static float MaxDashSpeedUpScale;

	public static float MaxWeaponAndSkillRunSpeedUpScale;

	public static bool EnableFixHSMinRatio;

	public static bool IsCsLoadoutOpen;

	public static int UGCRoomAutoMatch;

	public static int UGCRoomAutoMatchDuration;

	public static float UGCRoomAutoMatchNoRoomDelayMin;

	public static float UGCRoomAutoMatchNoRoomDelayMax;

	public static uint RefreshRoomCDSecond;

	public static uint UGCRefreshRoomCDSecond;

	public static bool UGCFastShowMatchRestult;

	public static bool UGCClientRuntime;

	public static bool UGCUseUnsafeCode;

	public static bool IsMarkShowOnHead;

	public static bool IsMarkTriangleHide;

	public static bool IsTeammateStatusDisplayOpen;

	public static readonly float JumpPadFOVFadeInDuration;

	public static readonly float JumpPadFOVFadeOutDuration;

	public static readonly float JumpPadUpFOV;

	public static readonly float JumpPadMaxHSpeed;

	public static readonly float JumpPadFallingDefaultAnimNoramlizedTime;

	public static readonly bool LuckyDrawBoxMarkItemOpen;

	public static readonly float HGBossHPAnimSpeed;

	public static readonly int HGBossHPAnimTriggerValue;

	public static readonly float HGDifficultyItemDelayTime;

	public static readonly float WholeBodyMovingSlowRate;

	public static readonly float WholeBodyFireContinueDuration;

	public static readonly float HGTwoBossHPAnimSpeed;

	public static readonly int HGTwoBossHPAnimTriggerValue;

	public static readonly float LevelInstrumentUseCD;

	public static readonly float LevelWishingTreeUseCD;

	public static readonly float WaitingCupUseCD;

	public static readonly float CupBanWaitingRemainTime;

	public static long ClothAHResource;

	public static readonly string BigMapNoSlideMode;

	public static readonly string MiniMapHideCloseBigMapTips;

	public static float BigMapSlideStationMarkOffset;

	public static readonly float CSWeapenTipOpenTime;

	public static readonly bool PropertyChangeSwitch;

	public static readonly bool NameDistanceUseStringBuilder;

	public static bool EnablePendingRevivePlayersThermalView;

	public static readonly int TutorRecruitLevelLimit;

	public static readonly float TreasuryModelStreamerRangeDelta;

	public static readonly bool NeedCombineSceneEditObjectMesh;

	public static readonly bool NeedCombineSceneEditObjectMeshPreZ;

	public static readonly bool EnableUsePhysicalCCT;

	public static readonly bool EnableDynamicCombinerInUGC;

	public static readonly bool EnableDynamicCombinerPreZ;

	public static readonly bool EnableDynamicCombinerMultiThread;

	public static readonly bool EnableDynamicCombinerDifferentIndex;

	public static readonly int DynamicCombinerMaxVertexPerMesh;

	public static readonly int DynamicCombinerMaxVertexPerBatch;

	public static readonly int DynamicCombinerMaxTranglePerBatch;

	public static readonly int DynamicCombinerRefreshBoundsFrameInternal;

	public static readonly int DynamicCombinerRefreshLODFrameCount;

	public static readonly bool DynamicCombinerUseDestroyInClear;

	public static readonly bool EnableSingleLineCheckStaticObject;

	public static readonly bool EnableUnmanagerArray;

	public static readonly bool IsMileStoneSystemOpen;

	public static readonly bool IsWeaponProficiencySystemOpen;

	public static readonly bool IsAchievementSystemOpen;

	public static int RecommendIconNum;

	public static readonly string BigMapShowMissionMode;

	public static readonly int BigMapGCIntervalSeconds;

	public static bool InGameAutoQuickChatV2Open;

	public static float QuickChatV2VoiceInterval;

	public static bool TeamRallySystemEnabled;

	public static readonly float TeamRallyDuration;

	public static readonly float TeamRallyCooldown;

	public static readonly float LevelLockAirdropInteractRadius;

	public static readonly float LevelLockAirdropInteractTimeCooldown;

	public static readonly int LevelLockAirDropIconDisappearTime;

	public static readonly float LevelLockAirValidHeight;

	public static bool EnableNewCrossHairTypeAimColor;

	public static bool OptimizeLobbyPerformanceOnPopupWindowShow;

	public static bool AndroidStripURIOnTakenScreenshot;

	public static readonly float ScreenShotMessageWindowTime;

	public static readonly string ScreenShotMessageWindowInGameRegions;

	public static readonly string ScreenShotMessageWindowFrontEndRegions;

	public static readonly bool IsClickBlankToCloseInBigUIFrameSize;

	public static readonly bool IsClickBlankToCloseInMidUIFrameSize;

	public static readonly bool IsClickBlankToCloseInSmallUIFrameSize;

	public static readonly bool IsClickBlankToCloseInWeapenSysEntrance;

	public static readonly bool IsClickBlankToCloseInCommonRewardWnd;

	public static readonly float MaxPropCatapultAvailibleAngle;

	public static readonly float MaxPropTeleportDoorAvailibleAngle;

	public static readonly float MaxPropTeleportDoorDeltaAngle;

	public static readonly float PropTeleportMaxYDelta;

	public static readonly float PlayerOnStaticGroundCheckDist;

	public static readonly float TeleportDoorOverLapCheckSqrDist;

	public static readonly float EventLeaveGameJankLimitRatio;

	public static readonly float EventLeaveGameJankLimitMs;

	public static readonly float EventLeaveGameBigJankLimitRatio;

	public static readonly float EventLeaveGameBigJankLimitMs;

	public static readonly int EventLeaveGamePlayerNumFPSPercent;

	public static readonly bool EventLeaveGamePlayerCPUTimeEnable;

	public static readonly bool EnablePlaneAO;

	public static readonly bool EnableAOFields;

	public static readonly bool VaultVerticalScreenSwitch;

	public static readonly bool VaultLoveBtnOpen;

	public static readonly bool EnableUserInputMaskBigMap;

	public static readonly float WeaponDetailHideDragTolerance;

	public static readonly float MaxPropJumpPadAvailibleAngle;

	public static readonly float JumpPadSmartFixAngle;

	public static readonly bool EnableCrossHairColorChange;

	public static readonly bool EnableJumpPadSmartCrossHair;

	public static readonly int FPSHintIntervalDay;

	public static readonly string FPSHintCheckGameMode;

	public static readonly string FPSHintCheckGameMap;

	public static readonly bool EnableGamePerfMonitor;

	public static readonly int FPS60HintThreshod;

	public static readonly int FPS40HintThreshod;

	public static readonly int FPS30HintThreshod;

	public static readonly int FPSShakePerMinuteHint;

	public static readonly int BombShopInterval;

	public static bool ModifyCustomIndexWhenJoinGame;

	public static readonly bool ObserverUserControllerEnable;

	public static readonly bool BanEnemyFlight;

	public static string NewbieTopMode;

	public static int NewbieTopLevel;

	public static readonly bool CleanTexWhenUMAResourceRelease;

	public static readonly bool AddDirtyWhenUMAResourceRelease;

	public static readonly bool RemoveDataWhenUMAResourceRelease;

	public static readonly int UmaGeneratorSkipAddDirtyUmaCnt;

	public static readonly bool UmaNoDelayBuildFor1PForCabinPhaseEnd;

	public static readonly bool UseUMAGarbageCollectionNewRate;

	public static readonly bool FixUmaDataOnDestroyCrash;

	public static readonly bool FixUMASignatureDecal;

	public static string NameUMASignatureDecal;

	public static readonly int WeaponIconNumInWaitingGame;

	public static readonly float WeaponIconMaxDistanceInWaitingGame;

	public static readonly float WeaponIconUpdateIntervalInWaitingGame;

	public static bool GameModeMainUseAsyncLoad;

	public static bool GameModeMainShowHippoCrisisFirst;

	public static uint WeaponIceWallID;

	public static uint NewIceWallWeaponID;

	public static uint IceWallMakerWeaponID;

	public static bool AsyncLoadAnonymousCSV;

	public static readonly float FriendShipProgressBarScale;

	public static bool BRAutoTagEnable;

	public static float BRAutoTagInterval;

	public static float BRAutoTagRange;

	public static float BRAutoTagRangeSqr;

	public static uint BRAutoTagItemDataID;

	public static float BRAutoTagTreasuryRidus;

	public static float BRMatchReviewSemiAIDecoySampleInterval;

	public static float ItemFinderTagHeight;

	public static bool ItemFinderTagLine;

	public static float ItemFinderTagTransparency;

	public static float ItemFinderTagScale;

	public static float ItemFinderTagDistance2Scale;

	public static float ItemFinderTagHideForAttackOrBeHitTimeDelay;

	public static bool PinAfterDeath;

	public static int PinAfterDeathCD;

	public static bool TestMatchRecommend;

	public static float MarkSoundCD;

	public static float SearchMapObjectInterval;

	public static float SearchMapObjectRadius;

	public static float SearchMapSeafoodGlassBrdigeRadius;

	public static bool UseNewCSMinimap;

	public static bool SearchMapObjectLuckyBoxEnable;

	public static float SyncSFRoleplayRoleCD;

	public static int SFRoleplayChangeRoleCD;

	public static float DeadDetailKillerNameCarouselTime;

	public static float SFRoleplayHideChangeRoleTime;

	public static float SFRoleplayNotebookTriggerRange;

	public static float PunishModelDelayTime;

	public static bool SuperEmoteChangeAimRotation;

	public static string NeedAdjustPaddingSpriteName;

	public static int AdjustPaddingSpritePixel;

	public static string ShopReviveCardFiltrationItem;

	public static float AutoQuickChatParachuteHeight;

	public static float AutoQuickChatBRStartTime;

	public static string AutoQuickChatFirstPickupWeaponIds;

	public static string AutoQuickChatFirstPickupWeaponTypes;

	public static float FriendLeaderboardRefreshCD;

	public static bool PickUpCombineEnable;

	public static bool AutoPickupPoolOptEnabled;

	public static bool AutoPickupInvokeOptEnabled;

	public static bool AutoPickUpSortAttachmentEnable;

	public static bool DescOfWeaponAccessorySwitch;

	public static int InventoryCombineDefaultState;

	public static bool InventoryDropItemDefaultType;

	public static bool SetParentWhenInstantiate;

	public static bool InstantiateUIUnderUIRoot;

	public static bool EnableUIPhysicsScene;

	public static bool EnableUIPhysicsSceneUpdate;

	public static int UIPhysicsSceneUpdateFrameInterval;

	public static bool EnableUICameraSkipCulling;

	public static bool EnableCollectOnWillRenderObject;

	public static bool EnableLegacyOnWillRenderObjectRegister;

	public static bool EnableBone2SkinFor3P;

	public static bool EnableUIPanelThread;

	public static int EnableUIPanelThreadByRecommendedQuality;

	public static float InGameAnimatedAlphaMinDelta;

	public static string AHEMU;

	public static bool ValidateCustomUIAtlasReleaserIngameOnLowMemory;

	public static bool CustomUIAtlasReleaseNeverVisibleIngame;

	public static bool CustomUIAtlasReleaseOnce;

	public static int CustomUIAtlasReleaserPendingCount;

	public static int CustomUIAtlasReleaserContinuousFrameNum;

	public static int CustomUIAtlasReleaserAtlasNum;

	public static bool CleanupNewBieGuildInGame;

	public static bool DisableHighResLoadInEffectLoad;

	public static bool VisualInstanceHolderApplyAsyncInstantiate;

	public static bool VFXCreateHelperApplyAsyncInstantiate;

	public static bool SwapLandscapeOrientationsWhenAutoRotate_iOS;

	public static bool DynamicFontFallbackToNotDefGlyph;

	public static bool EnableAccelerationOnFalling;

	public static float AccelerationOnFalling;

	public static bool EnableOnGroupJoinCoroutine;

	public static bool DisableLeaderboardSortByTeamIndexCS;

	public static bool DisableLeaderboardSortByTeamIndexBR;

	public static int SimpleHudNameDistance;

	public static bool DelayLoginCancel;

	public static readonly float MultiSessionAdviceRUDPResentPercentage;

	public static int LuckyBuffAutoSendCD;

	public static string LuckyBuffAutoSendRegions;

	public static int PreveteranLuckyBuffPopupCD;

	public static readonly bool UILobbyAdHideOutCountDown;

	public static int MultiSessionTimeOutSeconds;

	public static bool EnableNewKillNotification;

	public static bool OptimizeUIActiveStateOnUIClose;

	public static readonly float InGameShopEffectDistance;

	public static bool UIUseAddComponentUncheck;

	public static bool ABStreamerUseAddComponentUncheck;

	public static bool UseInGameUIPoolManager;

	public static readonly float AimStartPostionHeightForCreep;

	public static readonly bool EnableCDNICONPreDownload;

	public static bool EnableActivityRegionCDNPreDownload;

	public static bool UMARTEnablePool;

	public static bool EnableApplyOverridesByName;

	public static readonly uint FailHackCdtId;

	public static bool OptimizeUpdateInventory;

	public static bool UseRewardWndQueue;

	public static bool CanCreepRunFast;

	public static bool CanCrouchingRunFast;

	public static bool CanJumpFallingRunFast;

	public static bool ShowDashWhenSighting;

	public static bool KeepDashForMeleeWeapon;

	public static bool EnableSprintMeleeSpinePitchCompensation;

	public static float SprintMeleeSpinePitchCompensation;

	public static float SprintMeleeSpinePitchCompensationBlendSpeed;

	public static float SprintMeleeSpineRestSampleStableTime;

	public static bool SprintMeleeSpineUseHardcodedRestPose;

	public static float SprintMeleeSpineHipsRestEulerInRootX;

	public static float SprintMeleeSpineHipsRestEulerInRootY;

	public static float SprintMeleeSpineHipsRestEulerInRootZ;

	public static bool SprintMeleeSpineLogRestPoseOnSample;

	public static readonly bool AllowInGameReplayKit;

	public static readonly int HistoryKillHighLightNumber;

	public static readonly int AchievementPreviewTriggerNumber;

	public static readonly float Replay_View_Duration;

	public static readonly bool ReplayEnableConfirmBox;

	public static readonly float ReplaykitMinStorageGB;

	public static readonly int AndroidReplaykitLobbyMinQuality;

	public static readonly int AndroidReplaykitInGameMinQuality;

	public static readonly int iOSReplaykitLobbyMinQuality;

	public static readonly int iOSReplaykitInGameMinQuality;

	public static readonly int EvoGunMatchHumanKillCount;

	public static bool MultipleLobbyPing;

	public static bool EnableAvatarAntialiasing;

	public static bool EnableDelaySyncAvatarSyncAvatarProperties;

	public static bool EnableDelaySyncAvatarSyncAvatarPropertiesInLobbySocialArea;

	public static readonly float ReplaykitMaxDuration;

	public static bool EnableFixRotationIfUpperPanelOpen;

	public static bool EnablePopupMaskForLeftRightAxisInput;

	public static bool EnableMapTriggerGrenadeHint;

	public static bool BanMoveInputForExecution;

	public static bool EnableNGUIRaycastNonAlloc;

	public static bool FixNGUINaNInFillAmount;

	public static bool FixNGUINaNByClearRemainBuffer;

	public static bool EnableNGUIWidgetUpdateOpt;

	public static bool EnableNGUIActiveByScale;

	public static bool EnableUIMeshValidation;

	public static bool EnableReloadCSVWithGC;

	public static bool UsingUMABoneWeightsCache;

	public static bool UsingUMABindPosesList;

	public static bool UsingUMAUnloadFromGfxDevice;

	public static bool UsingUMABoneWeights2;

	public static int ReplayDataCacheCount;

	public static int InitCacheStringCountDefault;

	public static int InitCacheStringCountLevelHigh;

	public static bool HoldSwitchAnimationController;

	public static bool SwitchAnimationControllerIfReallyVisible;

	public static bool ClearInvisibleController;

	public static bool ClearInvisibleAnimatorCache;

	public static int ClearControllerDelay;

	public static float LowestQualityOnePercentIncreaseTime;

	public static float LowQualityOnePercentIncreaseTime;

	public static float UltraQualityOnePercentIncreaseTime;

	public static float FakeLoadingProgressStartValue;

	public static float PinClearTriggerRadius;

	public static float PinClearTime;

	public static float TeammateLocScreenOffsetTop;

	public static float TeammateLocScreenOffsetBottom;

	public static float TeammateLocScreenOffsetLeft;

	public static float TeammateLocScreenOffsetRight;

	public static bool CreateChildControllerInAwake;

	public static bool CreateCachedPositionInAwake;

	public static uint NewbieCSHint;

	public static float ShowNewbieCSGuideTime;

	public static float ShowNewbieCSGuideRound;

	public static float ShowNewbieCSGuideVestLevel;

	public static float ShowNewbieCSGuideCoins;

	public static float SelfMarkTransparency;

	public static float SelfMarkScale;

	public static bool ReleaseUmaTextureAfterDeath;

	public static bool TurnOnAliveSetVisible;

	public static float MatchMakingMini;

	public static readonly string BuildAutoMode;

	public static ulong SwitchBuildPlanCD;

	public static uint BuildDefaultAvatar;

	public static uint DefaulfFemaleAvatar;

	public static uint DefaultMaleAvatar;

	public static uint MaxDelayFrameForCustomCloth;

	public static string PreCommunicationRegions;

	public static uint LimitedInviteNums;

	public static uint LimitedInviteCreditScore;

	public static float UltraPlusQualityOnePercentIncreaseTime;

	public static readonly float LWFactionShowTime;

	public static readonly float LWFactionShowMyTime;

	public static readonly int CS_PhaseCheckEquipmentTime;

	public static bool BagPackLogoDefault;

	public static bool FightReplayDefault;

	public static bool FightReplayVisible;

	public static bool ProcessModelInitAfterLoginInDeserialize;

	public static bool EnableEarlyLoginGetProfile;

	public static bool BackOwnFlightButton;

	public static bool LowCreditLevelTeammateMute;

	public static bool LowCreditLevelTeammateNoVolume;

	public static bool AdjustMicAndSpeakHudPos;

	public static bool VisibleGameGlobalMission;

	public static readonly float WeaponAvatarExpProgressSpeed;

	public static readonly float BPMatchResultExpProgressTime;

	public static bool EnableLogCPUFrequencies;

	public static readonly int ToxicInGameWindowFadeTime;

	public static readonly int ToxicInGameWindowBattleCDTime;

	public static readonly int VFXLobbyStartMatchMakingCD;

	public static readonly float FateRandomMarkIntervalThreshold;

	public static bool EnableCustomABReleaser32Bit;

	public static bool EnableCustomABReleaserLowMemory;

	public static bool UseFFHearFootStepVibrate;

	public static string VibrateSDKFallbackDeviceList;

	public static readonly bool DestroyUnusedNodeInQualityObjectInGame;

	public static float DebugWeaponAimAssistMaxScore;

	public static float DebugWeaponAimAssistMinScore;

	public static float DebugWeaponAimAssistDampCoefficient;

	public static float DebugWeaponAimAssistDampYSensitivity;

	public static float DebugWeaponReloadProgressAniTime;

	public static readonly float AimAssistDragOutKnockdownMinDis;

	public static readonly int VillainBloodPoolLineMax;

	public static readonly bool BuildExpandBtnState;

	public static readonly bool EvoGunWorldChannelShare;

	public static readonly bool HudSetActiveStateByGroupOnCreate;

	public static readonly int MatchResultRewardItemOffset;

	public static readonly bool MultiNetworkForceCelluarReconnectAfterWifiRecover;

	public static readonly bool IsPreloadAfterSceneLoaded;

	public static readonly bool ClearLobbyAnimEffect;

	public static readonly bool FastRunAfterClimbUseJoy;

	public static bool DebugFakeClientMUDP;

	public static bool UseResolveDNS;

	public static readonly bool EnableOptimizeByQuality;

	public static readonly bool GetRealDamageUseRightWeapon;

	public static readonly int maxHashWaitTimeOut;

	public static readonly int LoginAppFlyerEventDays;

	public static readonly bool EnableCacheTransformCollectionBr;

	public static readonly bool EnableCacheTransformCollectionCs;

	public static readonly bool UMAWarmupMeshBeforeSetting;

	public static readonly bool UMANoWasteRecalculateBounds;

	public static readonly bool UMAExplicitBoneWeightTranslation;

	public static readonly bool HitFeedbackPromotion_ArmorBody_On;

	public static readonly bool HitFeedbackPromotion_ArmorBody_DefaultValue;

	public static readonly float HitFeedbackPromotion_ArmorBody_HighlightTime;

	public static readonly float HitFeedbackPromotion_ArmorBody_ShowTime;

	public static readonly float HitFeedbackPromotion_ArmorBody_FadeTime;

	public static readonly float HitFeedbackPromotion_ArmorBody_DisappearTime;

	public static readonly float HitFeedbackPromotion_Vest_SoundDelay;

	public static readonly float HitFeedbackPromotion_Helmet_SoundDelay;

	public static readonly int ItemFinderAutoCloseTime;

	public static readonly int UMATextureMergeInitLength;

	public static readonly float SixthBVideoWaitSkipTime;

	public static readonly float SixthBFriendBarrageRatio;

	public static readonly int SixthBBarrageNameCD;

	public static readonly bool EnableMatchDrag;

	public static readonly float MatchReadyNotifyDuration;

	public static readonly float MatchReadyReciveNotifyCD;

	public static readonly float MatchReadySendNotifyCD;

	public static readonly bool IsOptWaitGameInitAfterLoadScene;

	public static readonly bool TeamCanSeeBornfire;

	public static readonly int UIPopupMessageDelayTime;

	public static readonly int TakeDamageDetail_SavedHistoryCount;

	public static readonly int Reportee_Damager_RecentlyMaxCnt;

	public static readonly int Reportee_Killer_RecentlyMaxCnt;

	public static readonly int TakeDamageDetail_DamangeMergeFrame;

	public static float HudStropAndSlideHintCheckCD;

	public static float HudSnowSlideHintCheckCD;

	public static float SnowSlideStepVibrateInterval;

	public static bool EnableSlideOffFallingChangeDir;

	public static readonly float FFWSVoiceVolume;

	public static readonly bool EnableFFWSVoiceCloseVoice;

	public static readonly float FFWSFlagBRDelaySShow;

	public static readonly float FFWSFlagDefaultScale;

	public static readonly float FFWSFlagDestroyDurating;

	public static readonly int FFWSCSTrophyRound;

	public static readonly uint FFWSCSTechAirDropSkinId;

	public static readonly float FFWSIconFlyDuration;

	public static readonly int HudHurtHint_DamageMin;

	public static readonly bool DisableOpeningSoundForActivity;

	public static readonly int HudHurtHint_DamageMax;

	public static readonly float HudHurtHint_ScaleMin;

	public static readonly float HudHurtHint_ScaleMax;

	public static readonly float VehicleHitIceWallBackWardForceStopTime;

	public static readonly float VehicleHitFlyRecoverSpeedScale;

	public static readonly float RecoverFromHitFlyInterval;

	public static readonly float VehicleHitFlySpeedScale;

	public static readonly float VehicleDestroyIceInvibleTime;

	public static readonly float RoundEndMvpChatBtnDuration;

	public static readonly float InGameGetBRPlatformHeadpicWaitTime;

	public static readonly float InGameGetCSPlatformHeadpicWaitTime;

	public static readonly string PlatformIconFriendSwitchVisable;

	public static readonly uint GameGlobalMissionTitleDefaultColor;

	public static readonly float GameGlobalMissionInstrumentUsedTime;

	public static readonly float GameGlobalMissionInstrumentFlyTime;

	public static readonly float GameGlobalMissionColorCubeWaitTime;

	public static readonly float CSGameGlobalMissionTutorialTime;

	public static readonly string OpenQuickMatchGameModeWhenObserve;

	public static readonly string CompatibleLoginLobbyCDN;

	public static readonly bool GGPLoginOnce;

	public static readonly bool EnableGGPOnLowMemory;

	public static bool EnableAsyncLoadTimeLog;

	public static float SetShareRequestingTime;

	public static bool EnableAsyncLoadWeaponFor3P;

	public static bool EnableAsyncLoadWeaponEffect;

	public static bool EnableAsyncLoadEffectFor1P;

	public static bool EnableAsyncLoadEffectFor3P;

	public static bool EnableAsyncLoadSkillFor3P;

	public static bool EnableAsyncLoadIceWallEffect;

	public static bool EnableAsyncLoadLevelObjectEffect;

	public static bool EnableAsyncLoadRevivePointBeyond100m;

	public static bool EnableAsyncLoadEffectBeyond100m;

	public static bool EnableAsyncLoadPickupItemAtlas;

	public static bool EnableAsyncLoadBagItemAtlas;

	public static bool EnableAsyncLoadSafeZoneEffect;

	public static bool EnableAsyncLoadUIHUD;

	public static bool EnableAsyncLoadUIVFX;

	public static bool EnableAsyncLoadLevelTreasuryUIObject;

	public static bool EnableAsyncLoadLevelProjectileEffect;

	public static bool EnableAsyncLoadHandWeaponKillEffect;

	public static bool EnableAsyncLoadHandWeaponImpactEffectFor1P;

	public static bool EnableAsyncLoadHandWeaponImpactEffectFor3P;

	public static bool EnableAsyncLoadInventoryWeaponAtlas;

	public static bool EnableAsyncLoadHelicopterCannonAtlas;

	public static bool EnableAsyncLoadInventorySlotBreathVFX;

	public static bool EnableAsyncLoadSkateboardModel;

	public static bool EnableAsyncLoadSkateboardModelFor1P;

	public static bool EnableAsyncLoadSkateboardEffectFor1P;

	public static bool EnableCustomStreamer;

	public static bool EnableCacheParachuteFlight;

	public static bool EnableCacheVehicleStat;

	public static bool EnableCsCache3pDefaultWeapon;

	public static bool EnableCache1pWeaponOnBuy;

	public static bool EnableCsCache3pBackWeapon;

	public static bool EnableCsCache1PWeapons;

	public static bool EnableCsCache1PWeaponsOnBuy;

	public static bool EnableWeaponPoolFix;

	public static bool EnableCache3PIceWallThreshold;

	public static int Cache3PIcewallThresholdMedium;

	public static int Cache3PIcewallThresholdHigh;

	public static readonly uint GameSurveySubmitCD;

	public static bool EnableAsyncAttachCatapultModels;

	public static bool EnableAsyncAttachPropCatapultModels;

	public static bool HidePlayerForFlightAsyncLoad;

	public static float MaxSwingPitch;

	public static float MaxSwingRoll;

	public static float ResetRotationSpeed;

	public static bool EnableReducePlayerUpdateBrightness;

	public static bool EnablePlayerSkillAddHpAndRescureKnockdownCast;

	public static float IceWallMakerReqInterval;

	public static bool EnableV2LobbyAvatarGroupLocation;

	public static int NewPlayerMessionDay2AvatarID;

	public static bool EnableOpeningCam;

	public static float CameraShakeCabinFactor;

	public static bool IsForbiddenOilDrum;

	public static bool UGCPainterDrawIncrementally;

	public static float UGCPainterDrawIncrementalTimeLimit;

	public static bool GetPayLevelInfoWithHttp;

	public static float TechAirdropIconUpCloseTime;

	public static float TechAirdropPosMarkCloseTime;

	public static float TechAirdropUnLockIconDuration;

	public static float TechAirdropPointShowDelay;

	public static float TechPointFlyDuration;

	public static readonly int LevelTechAirDropIconDisappearTime;

	public static int DiwaliLotusLampIconDisappearTime;

	public static bool EnableUseFFStopWatch;

	public static bool EnableLowFallingSwapWeapon;

	public static float CSShopCoinBtnClickCD;

	public static int CSShopNeedCoinCheckNum;

	public static bool AutoPingSyncToBackend;

	public static bool EnableShaderLabHashPropertyMap;

	public static bool EnableSoloChat;

	public static bool EnableShowBPMatchResultExp;

	public static bool CheckIceWallAgainstPortal;

	public static bool UseLobbyLodInMatchResult;

	public static int ShadowDistanceInMatchResult;

	public static bool EnableDateTimeNowOpt;

	public static int EnableDateTimeNowOptAndroidAPI;

	public static bool EnableSnowSlideGrabSwapWeapon;

	public static int AutoPingUdpPingPort;

	public static float ShootRangeUpperLimit;

	public static float ShootRangeUpperLimitForBuidingGun;

	public static float ShootRangeLowerLimit;

	public static float ShootRangeSquatUpperLimit;

	public static float ShootRangeSquatLowerLimit;

	public static float ShootRangeLieUpperLimit;

	public static float ShootRangeLieLowerLimit;

	public static float CameraBackOffectLowerCutAngle;

	public static float CameraBackOffectLowerAngleDist;

	public static float CameraUpOffectLowerAngleDist;

	public static float CameraUpOffectLowerHitDrawBackDist;

	public static float MinFireIKBoneRotateAngle;

	public static bool OAuthAvailabilityDependsOnAndroidSystemWebView;

	public static bool UnmapReservedWebViewVirtualMemory;

	public static bool UnmapReservedWebViewVirtualMemory_ProcMapsRevise;

	public static bool UnmapReservedWebViewVirtualMemorySp;

	public static string LocalNtfDisableRegions_RebateCardRedeem;

	public static string LocalNtfDisableRegions_IAPbundleCountdown;

	public static string LocalNtfDisableRegions_FreeGachaCooldown;

	public static string LocalNtfDisableRegions_Retention;

	public static string LocalNtfDisableRegions_VeteranActivate;

	public static string LocalNtfDisableRegions_VeteranReminder;

	public static string LocalNtfDisableRegions_NewPlayerActivity;

	public static string LocalNtfDisableRegions_BooyahDayActivity;

	public static string LocalNtfDisableRegions_LiveTvEsport;

	public static string LocalNtfDisableRegions_EsportsAnnouncement;

	public static string LocalNtfDisableRegions_ActivityStart;

	public static string LocalNtfDisableRegions_BackgroundDownload;

	public static string LocalNtfDisableRegions_ClanWar;

	public static string LocalNtfDisableRegions_ActivityTemplateStart;

	public static string LocalNtfDisableRegions_NBCollection;

	public static bool DontShowTriggerEffectInLobby;

	public static bool DontDestroyCommonAb;

	public static bool DontDestroyOBCommonAb;

	public static bool RebindPlayableAfterDestroy;

	public static bool LobbyShowWaitSplashData;

	public static readonly bool InviteNotifySetting;

	public static bool UnloadShaderSource;

	public static long UnloadShaderSource_MinDiskSpace;

	public static int ShieldHUDSplitValue;

	public static int EPHUDSplitValue;

	public static bool ShieldHitReact3D;

	public static bool ShieldHitReactSound;

	public static bool ShieldBrokeReactIcon;

	public static bool ShieldBrokeReactSound;

	public static float ShieldOtherColliderRatio;

	public static bool ShieldDamageTxtSpecialColor;

	public static string PushEventDeepLinkUrl;

	public static bool OpenDownLoadTeamItemInLobby;

	public static int PushEventSwitchSetCD;

	public static float QuickSwitchShieldRecoverAndMedTime;

	public static bool ActionHudGetShowStateByShowHideFlag;

	public static bool BanInuptInSlider;

	public static bool IgnoreEnemyInAimingAdjust;

	public static float CSRoundResultShowScoreTime;

	public static bool EnableUIDrawCallIndexBuffOpt;

	public static bool EnableReusableObjectDelayCall;

	public static int MapContentUpdateMarkTickCount;

	public static bool VolumeBalanceFix;

	public static bool MapContentUpdateMarkRedPointEnable;

	public static float WinterLandTeamInviteTime;

	public static readonly float PersonalGameShopPretime;

	public static float MapThrowerPretime;

	public static float MapThrowerPressAndHoldDelay;

	public static float MapThrowerFocusMapScale;

	public static uint MapThrowerPositionSelectOffset;

	public static bool MapThrowerBlockMove;

	public static bool MapThrowerAutoPin;

	public static uint MapThrowerDefaultQuickUseItemId;

	public static bool MapThrowerUnderwaterOffsetEnable;

	public static uint MapThrowerUnderwaterOffset;

	public static bool CampfireRotationOptimize;

	public static bool IsShowGrandMasterRank;

	public static uint MaxClanActiveContributionCount;

	public static bool EnableOptimizeParachuteProcess;

	public static int ElectricZoneDeBuffID;

	public static float NewCollectionTypeTipsBoxTimeInterval;

	public static float NewCollectionTypeTipsBoxCountDownTime;

	public static string Burning3DEffectSwitch;

	public static float BlowUpIceWallBallPosRatio;

	public static int GameAssistantIntroductionMessageMaxNum;

	public static string GameAssistantOpenRegions;

	public static int GameAssistantIntroductionNewPlayerMinLevel;

	public static int GameAssistantIntroductionNewPlayerMaxLevel;

	public static string GameAssistantIntroductionVeteranLeaveDaysType;

	public static bool HideGameAssistantHDYardOpen;

	public static int FriendReunionMaxRemindNum;

	public static float FriendReunionRemindCD;

	public static bool IsUseMedkitForceStand;

	public static bool IsUseMedkitForceStandOnlyEffectSprint;

	public static readonly float HealingWalkSpeedScale;

	public static readonly float CarryingWalkSpeedScale;

	public static readonly uint CarryBeCarriedChestIdFemale;

	public static readonly uint CarryBeCarriedLegsIdFemale;

	public static readonly uint CarryBeCarriedShoesIdFemale;

	public static readonly uint CarryBeCarriedChestIdMale;

	public static readonly uint CarryBeCarriedLegsIdMale;

	public static readonly uint CarryBeCarriedShoesIdMale;

	public static readonly string CarryTriggerCdnUrl;

	public static bool CarryWheelSoundEnabled;

	public static bool CheckFireIntervalForAllWeapons;

	public static bool CheckFireIntervalForSniper;

	public static int FrameInterValPosSyncBattleRoomForSpectator;

	public static int UpdateAnimRotQueueMaxTolerance;

	public static float PCAimRotationAccuracy;

	public static int PCDelayPackDisposeTick;

	public static uint NoBloodCriticalDamageLabelColor;

	public static uint NoBloodNormalDamageLabelColor;

	public static uint NoBloodAimHasTargetColor;

	public static uint NobloodAimObjectColor;

	public static string EnableSocialVoiceRegions;

	public static string DistanceVolumes;

	public static string LobbySocialDistanceVolumes;

	public static uint VoiceDownPlayerNum;

	public static uint VoiceDownPercent;

	public static uint TeamVoiceModeLimit;

	public static bool EnableMsgFuncWarmUp;

	public static bool EnableMsgFuncWarmUpAsync;

	public static bool UseCustomSplitNaviData;

	public static float ShowBeCluScanTipsTime;

	public static float ShowHinderFailTipsTime;

	public static float BeCluScanTipsTimeInterval;

	public static string RenovateMap;

	public static bool ShowNewInGame;

	public static float CSModeActiveAutoPickUpFightPhaseDelayTime;

	public static float DelayHideWeaponInfoSkillSwatGuyVfxTime;

	public static bool UnloadTreeShadowTex;

	public static bool EnableSnowInCustomRoom;

	public static bool EnableSandInCustomRoom;

	public static bool EnableDriverFreeCamera;

	public static float DriverFreeCameraEulerLerpSpeed;

	public static bool CustomizedIntervalPingCounter;

	public static bool LeaderBoardUseNewFriendReuqest;

	public static bool DisableUGCAudioResource;

	public static ulong GetClanMembersColdDown;

	public static float TakeDamageStartFireIntervalCheck;

	public static bool TCPPerFrameHandleOneMsgInMatchGame;

	public static bool WarmUpEnum;

	public static int MaximumDeltaTimeScale;

	public static bool PhysicsAutoSimulation;

	public static int InGameShopItemCntPerframe;

	public static float GuildIconRankCarouselDuration;

	public static bool CustomRoomMicrophoneOn;

	public static bool CSGameEnableExpandPickupTriggerDuringPreparePhase;

	public static bool LowGravityAreaSafeZoneCheck;

	public static bool EnableWrapContentProtection;

	public static int MapContentShowType;

	public static float JumpDashSpeed;

	public static int ReportChatContextLength;

	public static float HeadShotVFXLifeTime;

	public static bool EnableHeadShotHitEffect;

	public static float HeadShotHitEffectCooldown;

	public static float HeadShotHitEffectLifeTime;

	public static bool EnableClassWarmup;

	public static bool EnableNormalClassInit;

	public static bool EnableGenericClassFakeInit;

	public static bool EnableProtoTypeInit;

	public static bool UMA3PDefaultModelOnlyInGame;

	public static bool UMA3PDefaultModelOnlyInCabin;

	public static bool UMA3PNoAttachmentsInGame;

	public static bool UMA3PNoAttachmentsInCabin;

	public static bool UMA3PUseSharedModel;

	public static bool UMA3PKeepSharedModelWhenObserved;

	public static bool UMA3PDefaultModelOnlyIOSLowQualityOn;

	public static bool EnableAsyncLoadPreviewResource;

	public static bool DisableAsyncLoadPreviewVehicle;

	public static bool IsFriendObservationOpen;

	public static bool EnableProtoBufIMessage;

	public static float VehicleHpRedThreshold;

	public static float CounterAttackDelayTime;

	public static uint AddToWishListRecentlyHours;

	public static uint RequestOthersWishListCDSecs;

	public static uint RequestOthersBriefCDSecs;

	public static int FriendObserverQuitCountDownTime;

	public static bool UseCustomLightmapFallback;

	public static bool ShowScoreBoardLoadout;

	public static float VehicleCameraLowSpeedRotationDamping;

	public static float VehicleCameraRotationDampingChangeSpeed;

	public static string ClanWarBarrageRow;

	public static uint ClanWarBarrageCD;

	public static bool EnableNewStyleHPDamage;

	public static bool GrenadeLinePotentialHintEnabled;

	public static bool GrenadeLineSplitPotenialHintEnabled;

	public static float MatchMakingWaitingCarouselIntervalSecs_CSPEAK;

	public static float MatchMakingWaitingCarouselIntervalSecs;

	public static float MatchMakingWaitingCarouselTransitionSecs;

	public static bool ApplyIngameEnemyShowLeaderboardTitle;

	public static bool ApplyIngameTeammateShowLeaderboardTitle;

	public static float IngameShowLeaderboardCD;

	public static float IngameShowLeaderboardIconTime;

	public static bool Table2UseFrameCreate;

	public static bool EnableInstantiatePrefab;

	public static uint SeasonReplayBGMMusicId;

	public static bool EnableSnowSlideCustomParam;

	public static bool EnableLosePresetProtection;

	public static bool MultiThreadPreloadCSVData;

	public static bool MultiThreadPreloadRegionCSVData;

	public static float VehicleChipDeviceCD;

	public static uint MessageChannelLimit;

	public static bool SaveNotFriendMessageId;

	public static bool WishListGiftViewIsConsiderBundleBox;

	public static float GiveMeFiveStickerMoveDuration;

	public static float GiveMeFiveStickerMoveStopDistance;

	public static float GiveMeFiveStickerMoveAcceleration;

	public static int BattleStyleExpRatio;

	public static float CallForReviveCDTime;

	public static bool EnableGameVoiceEngineCallbackMessageV2;

	public static bool FFVoice_CBMSG_PROTO_V2;

	public static float GameVoiceEngineOwnPlayerOnMaxTime;

	public static bool EnableEnsureTransformHierarchyExists;

	public static bool EnablePersistReadObjectSkipAvaCheck;

	public static bool EnablePersistReadObjectAvaCheckByType;

	public static bool EnableParticleSyncFixAndroid;

	public static bool EnableLockForSceneList;

	public static bool EnableLightSettingFix;

	public static bool EnableWebRequestFix;

	public static bool EnableSkinMeshRenderSkip;

	public static bool EnableSkinMeshRenderSkipIOSOnly;

	public static bool TryFixOnRenderSurfaceDestroyed;

	public static bool TryFixTraverseDepthFirst;

	public static bool Is2019JobSchedulerMaxThreads;

	public static bool TryFixMedkitDuringCreepSwitch;

	public static bool EnableDrawMatchMatchResult;

	public static bool EnableAddDynamicClipsFix;

	public static bool EnableUMADecompressDataNoGC;

	public static bool CatchExceptionInAfterParseData;

	public static bool FixRenderTextureCrashIn2018;

	public static bool EnableAnimatorBuildAssetOpt;

	public static bool EnableMetalShaderAsyncCompile;

	public static bool EnableReportLockMutexTimes;

	public static bool EnableYieldMutexDuringAsyncLoad;

	public static float CameraMoveDis;

	public static float CabinWindRestrictThres;

	public static float CabinWindRestrictFadeTime;

	public static string OB44BossDragonWaitingPic;

	public static int NewLoadoutDefaultID;

	public static bool EnbaleNewCameraRightOffset;

	public static bool EnableUniqueAttachmentEquipment;

	public static bool ShowCrosshairPenetrateStatus;

	public static bool EnableDownloadCentreProgressRefreshOptimize;

	public static bool EnableDownloadCentreTabItemRefreshProgressOptimize;

	public static bool EnableDownloadCentreUpdateOptimize;

	public static bool IsBigMapSizeZoom;

	public static bool ReFocusPlayerWhenReOpenBigMap;

	public static bool UseBasicDictForTypes;

	public static int OB43BossProgress;

	public static int FeedbackShowCount1p;

	public static int FeedbackShowCount3p;

	public static int FeedbackCSModeShowCount;

	public static int FeedbackMvpShowCount;

	public static float FeedbackMvpUFXDelay;

	public static string FeedbackNotifyPriority;

	public static bool ContinueFireWeaponSkillForLevelObject;

	public static bool EnableElectricGirlEDMiniPawnFireSound;

	public static bool EnableTrimListInIOS;

	public static int FriendOBDelayTimeMs;

	public static float InGameTeamKillEffectRadius;

	public static int InGameTeamKillEffectPlayerNum;

	public static bool EnableKnockDownKeepForwardAsAiming;

	public static bool EnableKnockDownAuxAim;

	public static bool EnableLockAirdropModelStreamer;

	public static bool EnableLockAirdropEffectStreamer;

	public static bool EnablePreviewToolBtn;

	public static float PropertyTeleportDoorTransferDelay;

	public static readonly float FireIntervalScaleBuffECA_AccumulateLowerBound;

	public static readonly float FireIntervalScaleBuffECA_AccumulateUpperBound;

	public static bool EnableLLevelContainerInStreamerSS;

	public static int LLevelContainerStreamerRange;

	public static int LLevelContainerShowEffectRange;

	public static bool EnableLLevelContainerRangeScale;

	public static float LLevelContainerStreamerRangeScale;

	public static float DefaultWaitDelay;

	public static float FeedBackDelayWait;

	public static float FeedCombineNofityDelay;

	public static float KnockDownDelayTime;

	public static float FeedCombineNofityDelayMax;

	public static float FeedLastOneDelay;

	public static float HGTopEffectActiveDelayTime;

	public static float DropPickUpModelShortOffset;

	public static bool EnableRecylePlayer;

	public static bool RequestProtoBeforeOpen_UIWeaponSkinLobbyMain;

	public static bool RequestProtoBeforeOpen_UILadderMatchNavigation;

	public static bool RequestProtoBeforeOpen_UIProfile;

	public static bool RequestProtoBeforeOpen_UIGacha;

	public static bool RequestProtoBeforeOpen_UIDrawShop;

	public static bool RequestProtiBeforeOpen_UIMallV2;

	public static bool RequestProtoBeforeOpen_UIWeaponProficiency;

	public static bool TeammateInfoPageByTeamCount;

	public static ulong VehicleDefaultSetChange;

	public static bool PenetrateGrenadeTraceNormal;

	public static bool FeedbackCsRoundEnd;

	public static bool EnablePutIcewallNearByNoPlayerVehicle;

	public static bool EnableExtendVehicleHudCollider;

	public static int EnableDriverCameraInputBlend2BaseRot;

	public static bool SmartIceWallFixing;

	public static float SmartIceWallMoreCheckOffset;

	public static float SmartIceWallDoubleCheckHeight;

	public static bool SmartIceWallUsePlayerPosYFixStartTracePos;

	public static bool SmartIceWallUsePlayerCenterToCheckPoint;

	public static bool OpenBackgroundChannel;

	public static bool EnableJoinMatchResSetMatchID;

	public static bool EnableTrySlowDownTooFastMoto;

	public static bool DragonTaskSkipReplay;

	public static bool LoadingDefaultBGShowTop;

	public static bool KnockDownKeepEnemeyPin;

	public static bool DisableStreamerForLowestQuality;

	public static int WeaponPropertyShowNumMax;

	public static bool RemoveResourceURLsForceToLower;

	public static bool EnabledIL2cppClearNativeSymbol;

	public static bool EnabledGoalTriggerVFX;

	public static string MapLegendGameMode;

	public static bool KillCamRestoreUsingReload;

	public static float KillCamEntryTime;

	public static bool KillCamSkipHandleMatchEnd;

	public static bool KillCamReCreateUI;

	public static bool KillCamOptForOverWriteConfig;

	public static bool KillCamNoUseDataQueue;

	public static bool KillCamGCOptimize;

	public static float KillCamDeathTipsRemainingTime;

	public static int KillCamDeathTipsBRRankRequirement;

	public static int KillCamDeathTipsCSRankRequirement;

	public static float KillCamFinalShotDelayPlayTime;

	public static bool ReplayRecordKillCam;

	public static bool ReplayParseKillCam;

	public static bool EnableAutoTaskInLobbyNavigationShowed;

	public static bool EnableAutoTaskSeasonReplayInLobbyNav;

	public static bool EnableAutoTaskSeasonChangeInLobbyNav;

	public static bool EnableAutoTaskSeasonChangeGrandMasterMarkAnimInLobbyNav;

	public static bool EnableAutoTaskSeasonYearChangeInLobbyNav;

	public static bool EnableAutoTaskCSSeasonReplayInLobbyNav;

	public static bool EnableAutoTaskCSPeakTournamentSeasonChangeInLobbyNav;

	public static bool EnableAutoTaskCSPeakTournamentInvitationInLobbyNav;

	public static bool EnableAutoTaskCSSeasonChangeLobbyNav;

	public static bool EnableAutoTaskSeasonChangeCSGrandMasterMarkAnimInLobbyNav;

	public static bool EnableAutoTaskClanWarV2RoundResult_TcpLobbyNav;

	public static bool EnableAutoTaskClanWarV2LimitedEventStartLobbyNav;

	public static bool EnableAutoTaskNewPlayerUnlockFeatureBannerLobbyNav;

	public static float EnemyReviveHintRange;

	public static float EnemyReviveHintRelativeHeight;

	public static bool EnableCurrentRegionGCFree;

	public static float FeedbackMoveDelay;

	public static float SeasonReplayCloseBtnDelaySecs;

	public static bool ForceShowHighQuality;

	public static bool ForceShowLowInQualityLow;

	public static bool ForceShowHighInQualityHigh;

	public static int NewPlayerExpToNextLevelVal;

	public static int NewPlayerRewardMaxDisplayLevel;

	public static float NewPlayerSignEntranceBubbleHideTime;

	public static float NewPlayerLobbyEntranceBubbleHideTime;

	public static float WishlistBubbleDisplayTime;

	public static bool UseVisualEffectForOldBuffSystem;

	public static bool OldBuffEffectResAsync3p;

	public static bool OldBuffEffectResAsync1p;

	public static int DamageShieldEffect;

	public static uint DamageShieldColor;

	public static uint DamageShieldOffset;

	public static bool DisableWalkingPosCheckWhenCCDisabled;

	public static int OccupyPlayerMaxCount;

	public static bool MatchEndHideRound;

	public static float HealingMinThreshold;

	public static float BeachBallHitVFXCD;

	public static int BeachBallForceSyncTickCountDelta;

	public static bool EnableShowPlayerOutline;

	public static bool EnableShowTeamOutline;

	public static uint ShowPlayerOutlineMaxDistance;

	public static uint ShowPlayerOutlineMinDistance;

	public static float ShowPlayerOutlineMaxAlpha;

	public static float ShowPlayerOutlineMinAlpha;

	public static float ShowPlayerOutlineWidth;

	public static float ShowPlayerOutlineMaxWidth;

	public static float ShowPlayerOutlineMinWidth;

	public static uint ShowPlayerOutlineColor;

	public static bool EnableOutlineFuncInScript;

	public static bool OutlineVisibleJudgeInUpDate;

	public static string SpecialClothOutlineWidth;

	public static float PlayerOutlineWidthSpecial;

	public static bool IngameCustomOpen;

	public static uint ShowTeamOutlineMaxDistance;

	public static uint ShowTeamOutlineMinDistance;

	public static float ShowTeamOutlineMaxAlpha;

	public static float ShowTeamOutlineMinAlpha;

	public static float ShowTeamOutlineWidth;

	public static float ShowTeamOutlineMaxWidth;

	public static float ShowTeamOutlineMinWidth;

	public static uint ShowTeamOutlineColor;

	public static bool EnableThroughTeamOutline;

	public static bool EnablePlayerAdditiveEffect;

	public static bool EnableLobbyAdditiveEffect;

	public static bool EnableEffectHeadAdditiveEffect;

	public static bool EnableAdditiveEffectPlayableBehaviour;

	public static bool EnableAdditiveEffectTransparent;

	public static bool EnableAdditiveEffectHideClothFXLobby;

	public static bool EnableAdditiveEffectHideClothFXIngame;

	public static bool EnableAdditiveEffectLightingFix;

	public static uint NewbieRecommendWeaponExp;

	public static float MiniMapScaleAnimationTime;

	public static bool PickupListKeepPanelOffset;

	public static readonly bool ExchangePickupItemEnable;

	public static readonly int MaxExchangePickupItemNum;

	public static readonly float ExchangePickupItemCDTime;

	public static readonly float ExchangePanelAutoCloseCDTime;

	public static bool PickupListInInventorySortUpNew;

	public static float LevelAutoFlightBombDestroyDelayTime;

	public static bool EnableTimelineParticlePrepareFrame;

	public static bool Close2022TimelineParticlePrepareFrame;

	public static bool NGUICallCreatePanelOptimization;

	public static bool NGUIGridListOptimization;

	public static readonly bool SetRefreshRateToFrameRate;

	public static string TestMemoryAllocDevices;

	public static int TestMemoryAllocSize;

	public static int TestMemoryAllocCount;

	public static bool EnableSwitchBlueToothPlayLobbyBGM;

	public static bool MatchResultFeedbackShow;

	public static bool UVSeqPlayInGameProperty;

	public static bool TcpSessionOpenUTCTime;

	public static bool DoActionEndUseForceCacheMsgAnyWay;

	public static int LobbyTeamUpRecommendCD;

	public static bool FullFixGamePasueInput;

	public static int DelayCheckTeamUpRecommend;

	public static ulong TeamUpRecommendFloatingWindowDelay;

	public static ulong RequestTeamUpRecommendCD;

	public static uint TeamUpRecommendClientListMaxNum;

	public static int LobbyTeamUpRecommendFullShowDelay;

	public static int ElectricGirlAimTargetQueueWidth;

	public static bool HideTeammateAvatarIfNeedPlayEnterGroupAnim;

	public static string SAPSwitchMatchMode;

	public static bool EnableChangeVehcileCollisionDetectedMode;

	public static float SapMapFloatingIconHight;

	public static bool StopTeammateEmoteAndShowWeapon;

	public static bool EnableGetTransformNodeOpt;

	public static float AreaTriggerAutoMessageThreshold;

	public static int BugReportIntervalOnLowMemory;

	public static bool EnableLowMemoryOnlyLowMemory;

	public static int UnloadUnusedOnLowMemoryInterval;

	public static bool EnableUDPCmdHandlerAtFrameEnd;

	public static bool BRUMAHeadSlotsAsyncLoading;

	public static bool UMASlotsAsyncLoading;

	public static int IceWallModuleDefaultID;

	public static float IceWallGiftDuraing;

	public static float MapScalePiecewisePoint1;

	public static float MapScalePiecewisePoint2;

	public static float MapIconOneScale;

	public static float MapIconMaxScale;

	public static bool UMAPackBagUpdateEffectAsync;

	public static bool EnableInGameBackendFlagGuide;

	public static bool EnableSystemBackendFlagGuide;

	public static uint LobbyV2ShoppingMallBannerMaxShowNumber;

	public static float LobbyV2ShoppingMallBannerAutoScrollTime;

	public static string TrainingModeHideChatZoneType;

	public static uint SubSystemTrainMapsHighPriorityMaxLevel;

	public static bool IsOpenCSTeamGoal;

	public static bool IsOpenCSShowEnemyMark;

	public static uint GetAreaLeaderboardTitleRecordCD;

	public static bool EnableHelicopterMoveOnGround;

	public static int AssistExpiredTeamUpTimeLimit;

	public static int AssistExpiredTeamUpCountLimit;

	public static string CabinGlooAirdropPos;

	public static bool UMANoVestSlotAttachmentsInGame;

	public static int FountainRepeatBounceCheckMinimalProtectCount;

	public static bool GachaUseLobbyMusic;

	public static float IceWallModuleGuideDelay;

	public static float IceWallModuleGuideAudioDelay;

	public static bool UMAPreloadBaseRecipe;

	public static bool UMAPreloadBaseRecipeForSocialIsland;

	public static bool BRHideCallSignRank;

	public static bool MeleeWeaponSlashAttackAfterStand;

	public static int LeaderBoardScrollMinCount;

	public static bool VEventCompatible;

	public static bool SocialLobbySwitch;

	public static float NormalAirDropMapIconLifeTime;

	public static bool IsScrollViewPressOnCenterChildUseOnFinish;

	public static float SocialGroupHudFoldThreshold;

	public static float WeaponMeleeChargeAttackEndTime;

	public static float WeaponMeleeChargeAttachSlashGravity;

	public static bool CDNCacheOptimizeInGame;

	public static bool DeActiveStateMahchineForCombineReloading;

	public static bool LocalPlayerKilledForceHideProfile;

	public static bool FrontEndReturnSwitchInTempHiding;

	public static bool EnabldeTouchHitInfoPool;

	public static int InGameShopTokenItemDataId;

	public static int HippoCrisisTokenItemDataID;

	public static bool EnableSyncLocalLeadEmoteAnimation;

	public static bool BRMoveSafeZoneRoomSettingSwitch;

	public static bool V2WebviewResolveSwitch;

	public static bool EnableDynamicLandJumpanimReplace;

	public static bool DebugUIGroupChange;

	public static int ThrowItemCoolFrame;

	public static bool EnableMapPatch;

	public static bool EnableMapPatchSingleGOChangesAsync;

	public static bool EnableMapPatchReuseMaterial;

	public static bool EnableMapPatchReuseMaterialIncreaseABTexRef;

	public static bool EnableMapPatchReuseLightmapInfoForAlteration;

	public static bool EnableMapPatchExplicitlyReuseOldLightmap;

	public static bool EnableFFOIOSSpecialFix;

	public static bool EnableLevelObjectSetLayerRecursively;

	public static bool EnableSetlayerCullDistances;

	public static float Layer_StaticObjectCullDistance;

	public static float Layer_LevelObjectCullDistance;

	public static bool ChargeBusterHintSwitch;

	public static float ChargeBusterHintDistance;

	public static float ChargeBusterHintOutRangeTime;

	public static float ChargeBusterHintMaxTime;

	public static float ChargeBusterHintShowTime;

	public static bool DestroyPlayerGameObjectUsingNew;

	public static bool UsingCommonQuitRevive;

	public static string ForceHideNewVaultFirstTab;

	public static bool EnablePresetGuideV2;

	public static float HasDefaultNewbieChoice;

	public static int LadderMatchSplashMaxTriggerLevel;

	public static string LadderMatchSplashRegionOn;

	public static float SwichRightFireDelay;

	public static int JumpSuggestDistance;

	public static float JumpSuggestTimeThreshold;

	public static string SpecialEventWeaponLootBG;

	public static readonly bool UMAAnimUpdatedByEvent;

	public static readonly bool UMACopyBonesToUMA;

	public static readonly bool UMAFixAtlasSize0;

	public static float ShurikenTrace3PFireDistanceSqr;

	public static float ShurikenTranceMinDisntanceSpr;

	public static uint HomerSkillID;

	public static bool ScopeMagnificationHUDSwitch;

	public static bool ReloadTimeHUDSwitch;

	public static bool AccessoryNameTurnsRed;

	public static bool NameOfEmptyAccessorySlot;

	public static string PresetHudCDNGuideSkillId;

	public static uint NewPlayerShoppingMallBannerLevel;

	public static float HighPosHitHintDistance;

	public static uint NewPlayerQuickMatchLimitLevel;

	public static bool EnableShaderKeywordStripAndroid;

	public static string UIRegisterBgBlurCDN;

	public static string UIRegisterTransitionBgCDN;

	public static bool EnableChangeHudFireIconAtlas;

	public static uint PresetNewbieGetAvatarLevelLimit;

	public static float ForceTutorialRequestDataMaxTime;

	public static float ForceTutorialEndWaitingTime;

	public static readonly string ForceTutorial_LoadingCDN;

	public static readonly string ForceTutorial_ChangeHudCDN;

	public static readonly string RoomFunShareImageNarrowlyWin;

	public static readonly string RoomFunShareImageBigWin;

	public static float ForceTutorial_ChangeHudABTest;

	public static readonly string BRTutorial_AgentCDN;

	public static float ForceTutorialLoadingCdnChangeTime;

	public static readonly string ForceTutorial_SkillIntroduceCDN;

	public static int SafeZoneLowDamage;

	public static int SafeZoneMediumDamage;

	public static bool EnableFluxPoolManager;

	public static bool EnableFluxSetupFramebyFrame;

	public static int FluxSetupCountPerFrame;

	public static bool EnableDashInFiring;

	public static bool EnableDashInClimb;

	public static bool EnableDashInHighFalling;

	public static bool ShurikenScatterShot;

	public static int UGCPremiumWeeklyCardWarnDays;

	public static int UGCPremiumMonthlyCardWarnDays;

	public static bool PlaySwapWeaponSoundBySlot;

	public static bool EnableShurikenSniperCollider;

	public static bool ShowWeaponDamageInfoIcon;

	public static bool ShowWeaponPVEDamageInfoIcon;

	public static bool ShowMicPermissionDenial;

	public static bool EnableFluxWindNavigation;

	public static bool EnableFluxWindRotateAsCharacter;

	public static bool LerpTransformOnUpdate;

	public static int RotationPlan;

	public static bool Real60FrameSwitch;

	public static bool GroundedStopLerpIn60Frame;

	public static float CatapultFallingProtectTime;

	public static bool ChangePoseWhileCatapultFallingSide;

	public static bool WeaponExecutionBeKillVisible;

	public static bool StopSimDeadWhileInvisible;

	public static bool EnableCycleWaitForAyncPicLoadInGameShare;

	public static bool EnableExecutePotentialRes;

	public static float ExecuteEffectVisibleDis;

	public static bool EnableWeaponExecuteSkillAlwaysPlay;

	public static bool EnableFistExecution;

	public static int VictimPlayExecution;

	public static float BeExecutedCameraLerpeTime;

	public static float BeExecutedStartCheckRecoverCameraTime;

	public static bool EnableExecutionCameraStuckFix;

	public static bool EnableExecuteFireInteractionFix;

	public static float ExecuteFireInteractionCooldown;

	public static float VictimPlayExecutionUIFXCD;

	public static bool IsNewDeadCameraUseAimRotation;

	public static uint CoreReactivationDuration;

	public static uint CoreReactiveationRemainRedHintTime;

	public static uint CoreReactivationTimes;

	public static uint CoreReactivationTimesRedHintTime;

	public static int Pcm2Mp3BitRate;

	public static bool SkillIconAtlasUsingAsync;

	public static uint ShowJumpSuggestRankThreshold;

	public static bool EnableLaunchTagServerProgress;

	public static uint LaunchTagServerProgressCD;

	public static bool EnableReleaseFlightResources;

	public static bool EnableReleaseFlightAudio;

	public static bool EnableReleaseFlightClip;

	public static bool EnableReleaseFlightPlayerClip;

	public static bool EnableReleaseFlightResourcesInLowMemoryOr32BIT;

	public static bool EnableUseTeamFlightFrameForEnemy3PInLowMemoryOr32BIT;

	public static bool EnableReleaseLocalFlightResourcesInLowMemoryOr32BIT;

	public static bool EnableReleaseEnemyFlightResourcesIn4GMemIOS;

	public static bool ReviveEnemyDontShowFlightIn4GIOS;

	public static float DelayShowHomerSkillHint;

	public static bool ShowParentWeaponDataIDInTraining;

	public static bool EnableLevelObjectManagerDicWarmup;

	public static bool TryFixNoDelayObserverInitBug;

	public static bool UGCEnableCacheDescription;

	public static bool MultiFrameOnCSPurchased;

	public static bool MultiFrameOnCSCoinChanged;

	public static bool WaitOneFrameWhileOpenCSShopByRound;

	public static bool OpenCSShopCSAbilityPointItemRecycleOpt;

	public static uint ReplayHSCount;

	public static bool EnableEnergySaving;

	public static readonly float EnergySavingCountDownTime;

	public static bool ShowLobbyGuideAfterAutoTask;

	public static readonly bool EnableLobbyAurataChange;

	public static bool KeepFallingLandAnim;

	public static bool AlokHealingEffectScaleFix;

	public static int AuroraboySkillMaxResult;

	public static int AuroraboySkillMaxResultLow;

	public static int AuroraboySkillMaxResultLowest;

	public static float AuroraboyBuffScale1;

	public static float AuroraboyBuffScale2;

	public static float AuroraboyBuffScale3;

	public static int NinjaGirlProjectileVfxLevel;

	public static bool NinjaGirlProjectileVfxVisibleOnPCFreeSpactator;

	public static bool EnableAvatarSkillDataDeepClone;

	public static bool PlayerOnSlopeCheckByRaycast;

	public static float PlayerOnSlopeCheckInterval;

	public static float PlayerOnSlopeCheckSpan;

	public static float PlayerOnSlopeForceCheckSpan;

	public static float PlayerOnSlopeLogSpanCD;

	public static float CooperateEmoteJoinRegion;

	public static float CooperateEmoteVFXScale;

	public static float CooperateEmoteLobbyClipWidth;

	public static float CooperateEmoteLobbyClipHeight;

	public static float PlayerOnSlopeCheckMaxAngle;

	public static float PlayerOnSlopeCheckMinAngle;

	public static float PlayerOnSlopeMinBackPushSpeed;

	public static float PlayerOnSlopeMaxBackPushSpeed;

	public static bool InNormalRoomGroupInfoSync;

	public static bool EnableWeaponUISwitch;

	public static ulong PresetGuideDelayTimes;

	public static bool CallStopEmoteAtPlayFireAnim;

	public static bool KillCamGCCollect;

	public static bool KillCamUnLoadUnused;

	public static bool KillCamGCCollectHighLevelMem;

	public static int KillCamMemLevelLowThre;

	public static int KillCamMemLevelHighThre;

	public static int KillCamUnloadRefMaxFreeMemory;

	public static int KillCamUnloadRefInterval;

	public static bool BanFastRunWhenFire;

	public static bool ShowSpDetail;

	public static bool ShowSpDetailDefaultSp;

	public static bool ShowHint3D;

	public static string Hint3DScale;

	public static float Hint3DDisplayDuration;

	public static float Hint3DTriggerHeight;

	public static float Hint3DRadius;

	public static string Hint3DRadiusHeight;

	public static float Hint3DTriggerRotation;

	public static bool ShowHighPosHitHint;

	public static float Hint3DTriggerAngle;

	public static string ShowHint3DType;

	public static bool ShowHitTrace;

	public static string HitTraceParams;

	public static float HitTraceDelayDestoryTime;

	public static uint HitTraceCnt;

	public static uint RecommendLoadoutMaxLevel;

	public static bool HudUAVHPRaycast;

	public static float HudUAVHPRaycastInterval;

	public static bool PCOBOutlineSolid;

	public static float PCOBOutlineWidth;

	public static bool PCOBBuildingDissovle;

	public static string PCOBBuildingDissovleEffectMapConfigId;

	public static bool PCOBBackPackSeeThroughShaderChange;

	public static bool PCOBBackWeaponSeeThroughPropertyChange;

	public static bool PCOBVehicleSeeThroughPropertyDisabled;

	public static bool PCOBDeadBoxSeeThroughPropertyDisabled;

	public static bool EnableSkillIndicatorAlignNormalV2;

	public static bool OpenNBBigEventCacheKey;

	public static bool EnableTeamFlightSeatIndexOptimize;

	public static bool Enable3PForceSyncUpdateStateTickcount;

	public static int PresetMinSearchContentLength;

	public static float SafeZoneChooseTipCD;

	public static float SafeZoneChooseScale;

	public static float MapScanTimeDelay;

	public static uint ClanPrivilegeClaimReplyEmojiID;

	public static uint ClanRecommendFriendNum;

	public static bool PonyMapChangeTreeMaxNum;

	public static bool TreeGridSort;

	public static float PonyMapViewFarRatio;

	public static bool TreeSystemFadeSpeedRatioEnabled;

	public static bool TreeSystemFadeSpeedSeperataed;

	public static bool TreeSystemPreviewPrefabSupported;

	public static float GrassSystemFadeParameter;

	public static float PonyMapViewFarRatioLowQuliaty;

	public static float PonyMapViewFarRatioLowestQuliaty;

	public static bool EnableFerrisWheelRigidBody;

	public static readonly bool Enable32bitOpt;

	public static uint ModifyEquipRequestTimeOutThreshold;

	public static readonly float SafeZoneVfxDuaring;

	public static readonly float MapScanVfxDuaring;

	public static float RMDEatFoodTime;

	public static readonly string SysTB48;

	public static readonly string ActivityStyle2NBGP;

	public static readonly string ActivityStyle2FFWS2025;

	public static readonly string ActivityStyle2Carni25GP;

	public static readonly string ToxicSquatUpDeBuffOpen;

	public static bool EnableIceWallHacker;

	public static bool EnableIceWallHackerKill;

	public static bool EnableHipHackerKill;

	public static bool EnableSendHackStoreLog;

	public static bool HCLobbyUseNewPose;

	public static int BigMapChoosePointGuideCount;

	public static uint HippoCrisisMaxForceModifyNum;

	public static string HippoCrisisCannotSelectSellMaterialLevels;

	public static float HippoCrisisLocalMatchEndDelayTime;

	public static float EventLogNewSystemMaxDuringTime;

	public static readonly float EP_SwitchThreshold;

	public static float LimitedTimeRankShowCountDown;

	public static float OnBoardCameraCollisonCheckDistance;

	public static bool UGCSeparateLogicAndVisual;

	public static float UGCEpsilonPos;

	public static float UGCEpsilonRot;

	public static float UGCEpsilonScale;

	public static float UGCEpsilonVelSquare;

	public static float UGCEpsilonAVelSquare;

	public static bool UGCUseProtobufForPersona;

	public static bool UGCDisableTextureReload;

	public static bool UGCDisableNewTextureLoad;

	public static int UGCResourceShopEditorMinItemCount;

	public static float UGCResourceShopEditorRequestCoolingTime;

	public static bool UGCUseInternalPathToSaveGameBytes;

	public static float UGCMapResourceExportDataUrlRequestInterval;

	public static float CAMERA_MODE_HUD_ALPHA;

	public static float CAMERA_MODE_MAIN_PANEL_MIN_ALPHA;

	public static float CAMERA_MODE_LOOP_EMOTE_DURATION;

	public static float CAMERA_MODE_LOOP_EMOTE_DURATION_LOBBY;

	public static float LOBBY_TAKEPHOTO_EMOTEPLAY_CUTTIME;

	public static float LOBBY_TAKEPHOTO_EMOTEPLAY_CUTTIME_TRANSFORM;

	public static float CAMERA_MODE_INGAME_ZOOM_MIN;

	public static float CAMERA_MODE_INGAME_ZOOM_MAX;

	public static float SCROLL_DRAG_DELTA_2_ZOOM_RATIO;

	public static string CAMERA_MODE_OUTGAME_ZOOM_MAX;

	public static string CAMERA_MODE_OUTGAME_ZOOM_DIST;

	public static bool EnableCameraModeRotation;

	public static bool ELECTRICZONE_DAMAGE_AUTO_CLOSE_CAMERA_MODE;

	public static int CAMERA_MODE_VEDIO_START_COUNTDOWN;

	public static string CameraVibrationScale;

	public static float CameraVibrationScaleInvalidDragDelta;

	public static bool CameraModeCanStopVideoWhenStarting;

	public static bool CameraModeScreenShotOpt;

	public static bool CAMERA_MODE_INGAME_VERTICAL_TEMPLATE_ENABLE;

	public static bool CAMERA_MODE_PROJECTILE_WEAPON_FIRE_POSITION_FIXED;

	public static bool EnableFreeViewFixedMode;

	public static float FreeViewCameraCollisionRadius;

	public static bool CameraHackRuntimeCheckIsWaitingCabinPhase;

	public static bool AlwaysCanShowEmotePanel;

	public static bool UseNativeReadStream;

	public static bool LocUseNativeArray;

	public static bool PVSUseNativeArray;

	public static bool InitCDMUnloadBeforPreload;

	public static bool InitCsvDecryptionBeforPreload;

	public static float RequestReviveEffectShowTime;

	public static int FFVoiceUploadLogTimeOut;

	public static uint RankNewSeasonTipsDay;

	public static bool VehicleForceStopByHighYSpeed;

	public static bool EnableBackPackOcclusion;

	public static uint RankingTipsShowLowestLevel;

	public static int TipsStillShow;

	public static bool DelayCreateGrenadeModelOnGachaFeature;

	public static float MapScaleOffSet;

	public static bool FixFireOpenWhenSniperCloseNextFireAction;

	public static bool NO_ANIM_0_USE_PACEMAKER_END;

	public static bool EnableVehicleGroundPenetrationFix;

	public static bool VehicleGroundPenetrationFixTrikeDisablePenetrationResolve;

	public static float VehicleGroundPenetrationFixTrikeStuckMaxSpeedMps;

	public static float VehicleGroundPenetrationFixTrikeStuckMinPenetration;

	public static float VehicleGroundPenetrationFixTrikeStuckMaxLiftPerFrame;

	public static float VehicleGroundPenetrationFixTrikeRecoverMinFallSpeedMps;

	public static float VehicleGroundPenetrationFixDuration;

	public static float VehicleGroundPenetrationFixMinNormalY;

	public static float VehicleGroundPenetrationFixSafeMargin;

	public static float VehicleGroundPenetrationFixMaxLiftPerFrame;

	public static float VehicleGroundPenetrationFixOverlapPadding;

	public static float VehicleGroundPenetrationFixProbeUpOffset;

	public static float VehicleGroundPenetrationFixProbeDistance;

	public static float VehicleGroundPenetrationFixMinFallingSpeed;

	public static float VehicleGroundPenetrationFixMinWheelBaseSpan;

	public static float VehicleGroundPenetrationFixMinGroundSupportSpanRatio;

	public static float VehicleGroundPenetrationFixMinLiftScaleUnderPartialSupport;

	public static float VehicleGroundPenetrationFixSingleAxleLiftScale;

	public static float VehicleGroundPenetrationFixMinWheelSupportForceRatio;

	public static float VehicleGroundPenetrationFixMaxLiftPerFramePartialSupport;

	public static float VehicleGroundPenetrationFixMaxSuspensionExtensionRatio;

	public static float VehicleGroundPenetrationFixCompressedSuspensionRatio;

	public static float VehicleGroundPenetrationFixFrontRearHeightDiff;

	public static float VehicleGroundPenetrationFixFrontRearHeightDiffStrong;

	public static float VehicleGroundPenetrationFixCarDrivingMaxSpeedMps;

	public static float VehicleGroundPenetrationFixTrikeMinNormalY;

	public static float InGameShopModelSyncLoadDisSqr;

	public static bool NotSwitchAudioMixerGroupAtOnceWithCutSceneResource;

	public static int AIChatTimeOutTime;

	public static bool NeedShowSkillEffectV2;

	public static float BotAgentVoiceDelayPlay;

	public static float BotAgentVoiceVolume;

	public static float BotAgentCSVoiceVolume;

	public static float BotAgentSkipActionTime;

	public static int BotAgentSettingHideOnUserLevel;

	public static int BotAgentSettingHideOnMemLevel;

	public static float BotAgentDataTimeOutSeconds;

	public static float BotAgentUIHighLightSeconds;

	public static float BotAgentUIRectHighLightSeconds;

	public static float BotAgentVoiceMaxTime;

	public static float BotAgentManualTriggerCD;

	public static float BotAgentDragTriggerCD;

	public static bool AIActionOPTGC;

	public static float LoadoutAttackStrengthenWaitTime;

	public static bool UnloadAllEmbeddedSceneObjects;

	public static bool EnableLODShader;

	public static bool EnableShaderVariantCount;

	public static bool EnableShaderKeywordStrip;

	public static bool EnableShaderRuntimeReload;

	public static bool EnableParticleMemOpt;

	public static bool EnableParticleMemOpt2;

	public static bool EnableSkinnedCompress;

	public static bool EnableSkinnedCompress_2022;

	public static bool ClostNegScaleColliderWarning;

	public static bool EnablePackFontTextureOpt;

	public static bool EnableShaderKeywordStripAllLOD;

	public static bool EnableShaderStripAB;

	public static bool EnableShaderRecordMaterials;

	public static bool EnableShaderStripAllLOD;

	public static bool EnableShaderKeywordStripFallBack;

	public static bool EnableShaderKeywordStripBRNight;

	public static bool EnableRecordABPath;

	public static bool EnableShaderLoadPathConfig;

	public static bool EnableRefindShadowCaster;

	public static bool EnableParticleSyncFix;

	public static bool EnableSetGpuProgramsDequeueInterruptCallback;

	public static bool EnableForceClearAllIntermediateRenderers;

	public static bool EnableMonoScriptOptimize;

	public static bool EnableFileCacherReadOpt;

	public static bool EnableFileCacherReadOpt_2022;

	public static bool EnableShaderSubProgramMoveConstructor;

	public static bool CloseResourceMgrCache;

	public static bool EnableUnloadSubProgramSourceCode;

	public static bool EnableExtraLayer;

	public static bool EnableNoAllocRaycastExtraLayer;

	public static bool EnableDefaultExtraLayerToOne;

	public static bool EnablePhysicsZeroProtect;

	public static bool FixPhysicsExtraLayerWord0;

	public static bool UIMapRevivePointIconUsingAsync;

	public static bool RevivePointSyncUsingCo;

	public static bool CloseGlobalGameMgrCache;

	public static bool EnableDeleteShaderInShaderErrors;

	public static bool EnableEnsureShaderLabShaderExist;

	public static bool SkipBakedLight;

	public static bool EnableLogSampleInDev;

	public static bool DisableErrorLog;

	public static bool Enable2018ABstreamed;

	public static bool TeleportGunCheckFireThrough;

	public static bool CalculateWeaponFireReplace0WithWeaponRange;

	public static bool UseNewStopCutSceneWwise;

	public static bool EnableFullHDAnimOverrideCtrlCache;

	public static bool OptFullHDAnimOverrideCtrlGc;

	public static bool RecyclePropWhenAvatarRebuild;

	public static bool EnableInGameSkyBoxChange;

	public static readonly string GloowallHitVFX;

	public static readonly string GloowallPenetrateVFX;

	public static readonly bool IceWallPenetratedEffect;

	public static float ReviveCardTimeLimitRedNoticeDuration;

	public static float ReviveCardTimeLimitedShowDuration;

	public static float ReviveCardTimeBannedPopDuration;

	public static float ReviveCardTimeTimeoutPopDuration;

	public static bool IsAnniversaryAchievementRemindOpen;

	public static bool HttpRequestOptimizeAction;

	public static ulong AnniversaryRemindLaunchTimeStamp;

	public static int ImageShareStickerLimitNum;

	public static string OutGameTakePhotoMoveFocus_Profile;

	public static string OutGameTakePhotoMoveFocus_Lobby;

	public static string OutGameTakePhotoMoveFocus_LobbyGroup;

	public static string OutGameTakePhotoMoveFocus_Vertical;

	public static int UGCMaxReconnectToGameCount;

	public static int RegionChooseOkShowDelay;

	public static float CSModeCoinRollingTime;

	public static bool EnableDebugEightInfiniteItemReward;

	public static string QRCodeUrlTemplate;

	public static string Voice2TextOsSpeechRecognition;

	public static bool SpeechRecognition_AutoRestart_Android;

	public static bool SpeechRecognition_MaximizeStandby_Android;

	public static bool SpeechRecognition_DictationMode_Android;

	public static bool SpeechRecognition_ReportPartialResults_Android;

	public static bool SpeechRecognition_PreferOffline_Android;

	public static string SpeechRecognition_ForceStopOnErrors_Android;

	public static string SpeechRecognition_RestartOnErrors_Android;

	public static float ShopItemStartSaleTimeDelay;

	public static float POIMissionFireWorkHeight;

	public static float POIMissionFireWorkScale;

	public static float POIMissionModelStreamerExtraRange;

	public static float POIMissionLeaveWarningAreaTipsCD;

	public static float POIMissionShopVfxHeight;

	public static float POIMissionDelayDestroyJumppad;

	public static uint POIMissionBRShopSkin;

	public static uint LoadoutPersonalAirdrop;

	public static int MaxTime2OfGSPrepareGameData;

	public static bool EnableVariableFFVoiceIDC;

	public static float VariableFFVoiceIDCMaxLoss;

	public static int GroupPhotoMinIntimacy;

	public static bool IsBigEventAchievementOpen;

	public static bool HippoItemDragRestrictionByAngel;

	public static float HippoItemDragRestrictionAngelValue;

	public static float HippoItemDragRestrictionAngelValue_Backpack;

	public static string StickerRandomOffset;

	public static bool IsShowHippoSafeBoxUpLvBtn;

	public static string StoreAllExceptItemType;

	public static bool EnableEnvChangeWorkerEvent;

	public static float ActivityWeaponPopup2TipsDuration;

	public static float ActivityWeaponPopup2TipsDelayTime;

	public static string EighthBDecorationGuideSlot;

	public static float EighthOnBoardTipsShowTime;

	public static bool EighthGoLandExitTrigger;

	public static bool IIV1v1GoLandExitTrigger;

	public static float IIVFastFallingLerpDisSqr;

	public static float BigMapIIVTeleportDoorMarkOffsetOnFloatingLand;

	public static float BigMapIIVTeleportDoorMarkOffset;

	public static float IIVTempleWeatherFadeTime;

	public static float IIVEnergyMapShowDis;

	public static float IIVEnergyTrackTime;

	public static float IIVEnergyFlyTime;

	public static float IIVEnergyTextTime;

	public static float IIVEnergyNewUnlockTipsTime;

	public static string IIVLockSkill;

	public static int IIVInfiniteSpaceRequire;

	public static uint IIVHammerSkillId;

	public static float IIVFastFallingSpeed;

	public static float IIVFastFallingEffectOffset;

	public static float IIVFastLandingEffect3PDelayTime;

	public static float IIVTeleportUIEffectTime;

	public static float IIVTempleExitAnimTime;

	public static float IIVCollectAllCD;

	public static bool ShibuyaDisableGodEffect;

	public static bool EnableShibuyaFogAndBloom;

	public static float ShibuyaTeammateItemEffectTime;

	public static float SHIBUYA_PORTAL_SWITCH_DIS;

	public static float ShibuyaAirWallHintMinDis;

	public static float ShibuyaAirWallHintMaxDis;

	public static float ShibuyaDoorTeammateTagInterval;

	public static float ShibuyaAlarm;

	public static float ShibuyaCD;

	public static int ShibuyaMax;

	public static int SocialShibuyaMax;

	public static float ShibuyaEggTime;

	public static float ShibuyaEggOutTime;

	public static float ShibuyaStayTime;

	public static float ShibuyaCount;

	public static float ShibuyaChangeTime;

	public static int ShibuyaSize;

	public static string ShibuyaMiniMap;

	public static float ShibuyaMiniMapScale;

	public static float ShibuyaDoorUseCd;

	public static float GameModeMainSwipePixel;

	public static float SettingMagicVoice5Item;

	public static bool EnableMotionPlatformStateFix;

	public static bool EnableCheckExitMotionPlatformOnDead;

	public static bool EnableCheckEnterMotionPlatformOnRevive;

	public static int VoiceTestServerRegionId;

	public static bool EnableClanNameAndLogoCapture;

	public static bool EnableTotalDmaggeHitLast;

	public static bool EnableTotalDamageHitmarker;

	public static float AccumulatedDamageDelay;

	public static float AccumulateContinuousFireDelay;

	public static int HitmarkerTypeDefaultValue;

	public static bool StartDashWhenFallingApplySpeedDown;

	public static bool CheckPenetrateHitTrigger;

	public static bool CheckBtnPressDirtyOnReleased;

	public static bool VerticalTakephotoHideEmote;

	public static bool HackGetOffVehicleWhenEntityInfoIsNull;

	public static bool EnableUIDrawCallCacheSharedMaterial;

	public static bool ShowCdTimeTxtDefaultSetting;

	public static bool HUDButtonHintSettingEnable;

	public static bool HUDButtonHintDefaultValue;

	public static bool EnableTriggerDirectionDetect;

	public static bool EnableEntityHideDetect;

	public static bool EnableEnvChangeController;

	public static bool SkillAreaIndicatorSwitch;

	public static int LoadoutSupportBuffSlotCount;

	public static string LoadoutSupportBuffSlotUnlockCosts;

	public static float LoadoutSupportBuff1PTipsDuration;

	public static float LoadoutSupportBuff3PTipsDuration;

	public static float LoadoutSupportBuffHintCooldown;

	public static float LoadoutSupportBuffHintPlayerVFXLifetime;

	public static float TeamBuffSupporterPretime;

	public static float WeaponReinforcedAnvilPretime;

	public static uint LoadoutReinforceID;

	public static float LoadoutCSShopReinforceUIFXDuration;

	public static float BuffHUDVFXDataDelaySec;

	public static bool EnbaleFreezeAutoPickupDefaultType;

	public static bool EnableReviveResetFreezeAutoPickup;

	public static bool EnableDelayShowAttachmentNotificationTip;

	public static bool EnableOnResActionAttachmentChangedCoroutine;

	public static int LocalUserVoiceMaxLevel;

	public static int OtherUserVoiceMaxLevel;

	public static int SelfLowVolumeLevel;

	public static int OtherUserHighVolumeLevel;

	public static float LobbyVoiceDisconnectThreshold;

	public static float DiwaliLotusLampInteractRadius;

	public static float DiwaliLotusLampTimeFromZeroToOne;

	public static float DiwaliLotusLampTimeFromOneToTwo;

	public static float DiwaliLotusLampTimeFromTwoToThree;

	public static bool EnableHiraishinThrowFallingHigh;

	public static bool EnableFFOPortingHDLobby;

	public static bool EnableFFOPortingHDAnimation;

	public static bool FFOHDAnimationCheck32Bit;

	public static bool FFOHDAnimationCheckMemThreshold;

	public static bool FFOHDAnimationCheckIOSMem;

	public static bool EnableFFOPortingHDEffect;

	public static bool EnableFFOPortingHDTexture;

	public static float AutoFlightBombHeightLerpRatio;

	public static bool SplitGetOffVehicleBtn;

	public static bool EnableSocialTeammateVFXCheck;

	public static bool EnableGetOffVehicleKeepCameraRotation;

	public static bool EnableBlockGetOnOrOffVehicleWhenNoPlaceGetOff;

	public static int ProfileAlbumDeleteLimit;

	public static string KingVisualDefaultSpriteName;

	public static int NewbieFillPresetSkillsMaxLevel;

	public static int CSPeakMatchresultShowLeaderboardRankLowwer;

	public static int CSPeakMatchresultRankPosCalDelay;

	public static int TipsShowGachaLimitLevel;

	public static int MaxGetGiftNotifyCount;

	public static bool EnableLobbySocialArea;

	public static bool EnableBlockLobbySocialAreaMatchmaking;

	public static float LoginGoto2DLobbyProtectDelayTime;

	public static bool EnableLobbySocialAreaOfflineMode;

	public static bool EnableLobbySocialAreaDecoupleMapConfig;

	public static bool EnableLobbySocialAreaStreamerPlayerRetry;

	public static bool EnableLobbySocialAreaPickupShowFix;

	public static bool EnableLobbySocialAreaStartGGP;

	public static bool EnableLobbySocialAreaSubGameGGP;

	public static bool EnableLobbySocialAreaSubGameSecStart;

	public static float LobbySocialAreaSwitchCD;

	public static int LobbySocialGamePlayerDisplayLimit_L;

	public static int LobbySocialGamePlayerDisplayLimit_M;

	public static int LobbySocialGamePlayerDisplayLimit_H;

	public static float LobbySocialGamePlayerDisplayLimit_CloseRangeSquare_L;

	public static float LobbySocialGamePlayerDisplayLimit_CloseRangeSquare_M;

	public static float LobbySocialGamePlayerDisplayLimit_CloseRangeSquare_H;

	public static float LobbySocialGamePlayerDisplayLimit_LongRangeSquare_L;

	public static float LobbySocialGamePlayerDisplayLimit_LongRangeSquare_M;

	public static float LobbySocialGamePlayerDisplayLimit_LongRangeSquare_H;

	public static int LobbySocialGamePlayerDisplayCheckIntervalFrames;

	public static bool DisableConstantClipSamplingOptimization;

	public static uint NinthActivityWishEmoteID;

	public static float NinthTokenVFXFlySpeed;

	public static float NinthTokenVFXFlyArcHeightFactor;

	public static float NinthTokenVFXFlyTrailDelay;

	public static float NinthLevelPortalVFXDuration;

	public static float NinthLevelPortalRadius;

	public static float NinthLevelPortalMaxRadius;

	public static bool NinthStatueCameraSkipTransitionAnimation;

	public static float NinthStatueCameraTransitionDuration;

	public static float NinthFollowCameraExtraBackDistance;

	public static float NinthFollowCameraNoWalkingRadius;

	public static float NinthProgressLoadingDuration;

	public static float LobbySocialAreaSelectionAimDuration;

	public static float LobbySocialAreaSelectionMaxDistance;

	public static float LobbySocialAreaSelectionDistanceRange;

	public static float LobbySocialAreaSelectionDistanceDuration;

	public static float LobbySocialAreaSelectionDistanceCooldown;

	public static float LobbySocialAreaSelectionExpireDuration;

	public static float SoftCloseNoticeCloseTime;

	public static uint LobbyLWWinStreakStage1;

	public static uint LobbyLWWinStreakStage2;

	public static uint LobbyLWWinStreakStage3;

	public static float LobbySocialAreaUIAlphaDelay;

	public static float LobbySocialAreaUIAlphaDuration;

	public static float LobbySocialAreaUIContinuousMoveBlockAlphaSeconds;

	public static float LobbySocialMaxHudNameDistanceExcludeTeammates;

	public static uint LobbySocialMaxHudNameCountExcludeSelf;

	public static uint LobbySocialFriendMaxHudNameCount;

	public static uint LobbySocialBillboardWinStreakThreshold;

	public static int MediaMgrAlbumImageTexturePoolSize;

	public static int MediaMgrAlbumImageTexturePoolMaxAgeSecs;

	public static int AlbumThumbnailSize;

	public static int SystemAlbumImageAntiModStrategy;

	public static int AlbumImageAntiModSecs;

	public static bool AlbumImageAntiMod_iOS;

	public static bool TryDeleteBeforeSavingTextureToFile;

	public static bool IsScreenshotNeededInAlbum_Android_34AndAbove;

	public static bool IsScreenshotNeededInAlbum_Android_Below34;

	public static bool IsScreenshotNeededInAlbum_iOS;

	public static bool AndroidUseScreenCaptureCallback;

	public static int AgeCtrl_APIRetryWithExpBackoff_InitIntv_Secs;

	public static int AgeCtrl_APIRetryWithExpBackoff_MaxIntv_Secs;

	public static int AgeCtrl_APIRetryIntv_Secs;

	public static bool AgeCtrl_iOSPrecheckForMinor;

	public static bool AgeCtrl_AndroidBanCheckByInstallID;

	public static int AgeCtrl_AndroidBanCheckRetryIntv_Secs;

	public static int AgeCtrl_PrecheckRetryIntv_Secs;

	public static int AgeCtrl_AdultAge;

	public static int AgeCtrl_ProceedOnConsecutiveErrors;

	public static bool AgeCtrl_CheckForThirdPartyBuild;

	public static bool AgeCtrl_PromptWhenBannedByStrategy_iOS;

	public static bool AgeCtrl_PromptWhenBannedByStrategy_Android;

	public static int AgeCtrl_PromptWhenBannedByStrategy_Duration_Secs;

	public static bool IsAlbumScreenShotNeedAntiMod;

	public static bool EnableAsyncLoadReskinSightUI;

	public static bool EnableAsyncCrossHairUI;

	public static uint BRRankLeaderBoardMinRank;

	public static uint CSRankLeaderBoardMinRank;

	public static uint GrenadeHintFilter;

	public static bool RescureStatusSkipOBCheck;

	public static bool EnvChangeControllerCloseSkybox;

	public static float MatchResultPosterCSRankRatingThreshold;

	public static bool CdnNeedDownloadCheckIncludePreDownloadQueue;

	public static int AlbumScreenShotFileExpiredDays;

	public static bool ReturnToLobbyCheckAlbumOverTimeFile;

	public static uint VaultNotScrollCount;

	public static float WinterIslandFireworkDuration;

	public static float WinterIslandCSFireworkDuration;

	public static int MaxMagicVoiceInitRetryCnt;

	public static float MagicVoiceInitRetryDelaySec;

	public static bool IosEnableMagicVoice;

	public static bool EnableCheckOverlapWithSantioDummy;

	public static int AlbumPhotoMaxCacheLength;

	public static bool PCBooyahV2;

	public static float HangManagerSmoothUpdateThehold;

	public static int MotionPlatformReplayResetCount;

	public static float FFWSTrophyCupMoveMinY;

	public static float FFWSTrophyVFXRotationDuration;

	public static bool EnableFFWSFlameZoneAutoTiling;

	public static float FFWSTweenTipsDuration;

	public static float CSPeakBooyahVoiceDelay;

	public static bool NBGPShowCampBuffGetNotification;

	public static bool InGameCDNNetworkMaterialAutoLoadDefaultImg;

	public static float FFWSFlagCabinWaitDuration;

	public static float FFWSFlagBROpeningDuration;

	public static float FFWSFlagShowTrophyCupDuration;

	public static bool EnableHideLaunchTagInLoading;

	public static bool EnableClearEffectsUnparentEffect;

	public static bool EnableVegColorComponentOverride;

	public static bool NeedCheckKingBuffShowWithTeam;

	public static uint CsPeakHistoryRegionListNum;

	public static uint PhotoDecoretonsMaxNum;

	public static int LimitPresetAgentLevel;

	public static bool EnableIngameQuickReport;

	public static float PresetAgentDragTriggerCD;

	public static int PresetAgentAutoPromptLevel;

	public static int PresetAgentAutoPromptWaitTime;

	public static bool LobbyVerticalAvatarEffectSwitch;

	public static float GoldRatingLevelThreshold;

	public static float SilveryRatingLevelThreshold;

	public static readonly int Winterland25BLowStorageGB;

	public static readonly int Winterland25BHighStorageGB;

	public static readonly int Winterland25BMinAvailStorageMB;

	public static float WinterlandMapIconScaleInBigMap;

	public static float BloodmoonGPMapInteractingIconSizeMultiplier;

	public static float BloodmoonGPTotemMarkShowDurationSec;

	public static float WinterLandSnowSlideWayDashSpeedScale;

	public static float WinterLandIslandFallingAutoUseSnowSlideDuration;

	public static float WinterLandIslandIconDirShowDuration;

	public static float WinterlandIslandSnowSlideWayVSpeedRatio;

	public static float WinterlandIslandSnowSlideWayRisingGravity;

	public static float WinterlandIslandSnowSlideWayFallingGravity;

	public static float WinterlandSnowSlideWayMaxVSpeed;

	public static float WinterlandSnowSlideWayAutoJumpedMinHSpeed;

	public static readonly bool TutorialDataWithRegion;

	public static bool DontClearGroupUIWhenCreateGroupFail;

	public static readonly bool EnableLoneWolfQuickDuel;

	public static bool EnableDirectWriteSharedDataToFileStream;

	public static bool EnableReleaseAsyncOperation;

	public static float PresetAgentBubbleLifeTimeDelay;

	public static float PresetAgentBubbleFastMessageLifeTimeDelay;

	public static int MaxVoiceCacheCount;

	public static int MaxLLMAudioLength;

	public static readonly bool BattleCardTypeListHasRating_BR;

	public static readonly bool BattleCardTypeListHasRating_CS;

	public static readonly bool BattleCardTypeListHasRating_CSPeak;

	public static bool HeadshotSightFXOpen;

	public static bool CrosshairCenterAimTraceCloseMark;

	public static readonly uint WLGP25DeerGiveBuffActionTimes;

	public static uint CSPeakIconicWeaponAVGKillsThreshold;

	public static float CSPeakIconicWeaponHeadshotRateThreshold;

	public static uint CSPeakIconicWeaponAvgDamageThreshold;

	public static string PCSkyBoxCameraPosition;

	public static string PCSkyBoxCameraRotation;

	public static string AdvancedRevivePointNotifyEndTime;

	public static bool EnableObtainPendingTransactions;

	public static int EditLoadoutDescMinLength;

	public static int EditLoadoutDescMaxLength;

	public static float TeammateMuteChangeDelay;

	public static bool EnableOptimizedTreasureBoxLoading;

	public static bool EnableUAVFireOnRelease;

	public static bool EnableTakePhotoEmoteList;

	public static readonly string VodkaAppKey;

	public static readonly string VodkaAppSecret;

	public static readonly string VodkaServerURL;

	public static readonly string AdvVodkaAPIKey;

	public static readonly string AdvVodkaAPISecret;

	public static int VodkaLogLevel;

	public static string VodkaIsLockRegion;

	public static float GameVoiceRetryInitSec;

	public static bool UseNewJumpToFrame;

	public static bool EnableFallingDashOptimize;

	public static float WLGP25DeerHPEPRange;

	public static bool IceWallVFXPauseEnable;

	public static int IceWallVFXPauseEnableQualityLevel;

	public static float IceWallVFXPauseDistance;

	public static float VFXDistancePauserCheckInterval;

	public static bool IsOpenJoinTeammateSocialInReadyState;

	public static float WaitGroupInfoNotReadyTimeOut;

	public static float RelayMartDiscountCodeCheckingCD;

	public static float RelayMartPublicTipBubbleAutoHideTime;

	public static uint CSInfoRescuredStateShowFilter;

	public static bool IsUiSpriteDictOptimization;

	public static bool EnableEnvWeatherZoneFade;

	public static bool EnableEnvWeatherZoneFadeTargetWeatherFix;

	public static bool EnableEnvWeatherZoneNightModeRestore;

	public static bool EnableEnvWeatherBackupOnLightOverride;

	public static bool EnableEnvWeatherControllerWaterAutoRegister;

	public static bool EnablePCTeamKillCamera;

	public static int PCTeamKillCameraMinDistance;

	public static float PCTeamKillCameraMoveSpeedRatio;

	public static float PCTeamKillCameraLongDistanceSpeedRatio;

	public static float PCTeamKillCameraLongDistance;

	public static float PCTeamKillCameraMinMoveSpeed;

	public static float PCTeamKillCameraMaxMoveTimer;

	public static float PCTeamKillCameraStopMoveDistance;

	public static float PCTeamKillCameraMaxWaitTime;

	public static float InviteGroupBoxSearchCD;

	public static int AirdropWeaponMarkUpdateInterval;

	public static int Carni25GPAlokVoiceLang;

	public static float Carni25GPAlokHideDuring;

	public static float Carni25GPAlokStartDuring;

	public static float AirdropWeaponMarkTempHideTime;

	public static int ShowAskReviveQuickChatBtnLastZoneIndex;

	public static bool ClearPreloadWhenEmergency;

	public static bool SimpleperfSampleThread;

	public static bool ToggleCCTWhenPlayerPriHide;

	public static uint HighlightPhotoSaveMaxCnt;

	public static bool EnableHighlightPhoto;

	public static float BuffLoadoutScannerDelayDestroyDistance;

	public static float TreasureHuntNormalTreasureMapVisibleDistance;

	public static bool FluxColliderUseCache;

	public static bool TrainingModeEnableAutoRevive;

	public static bool EnableDolocAutoTrim;

	public static bool EnableStreamerPatchGCOpt;

	public static bool EnableFlightVisibilityOpt;

	public static bool EnableMultiFlightCreateVisibilityCheck;

	public static bool AndroidShareToLine_Upgrade_1;

	public static string SocialAreaWorkshopCode;

	public static bool IsSocialAreaWithUGCMapResEnabled;

	public static float BuffPopOverContainerSpacing;

	public static float BuffPopOverMinEdgeDistance;

	public static float RematchScanInterval;

	public static bool EnableShareQRCodeControlBtn;

	public static bool EnablePickupItemActivityBgAsyncLoadAtlas;

	public static string AirDropWeaponLevelBoxVFXAlphas;

	public static bool EnableKillAndKnockDownNotiVFXAsyncLoad;

	public static uint RematchPopupLabelThreshold_Kills;

	public static float RematchPopupLabelThreshold_Rating;

	public static uint RematchPopupLabelThreshold_Rescure;

	public static int RematchRecommendFriends;

	public static bool EnablePlayerFollowVFXAndIcon;

	public static float PlayerVFXShowSpeedLeftThreshold;

	public static float PlayerVFXShowSpeedRightThreshold;

	public static float PlayerVFXShowSpeedDecreaseLeftThreshold;

	public static float PlayerVFXShowSpeedDecreaseRightThreshold;

	public static float UIFXFollowPlayerSameTypeCooldown;

	public static bool EnableLUPObtainPendingTransactions;

	public static int UGCMAPTAGLIMIT;

	public static bool EnableTeleportAndGetOffVehicleSameFrameSkipEnterVehicle;

	public static float GAMEMODEMAINSWIPETIME;

	public static bool EnableNearbyPlayerSearchDistance_adjacent;

	public static float NearbyPlayerSearchDistance;

	public static float NearbyPlayerSearchDistance_adjacent;

	public static readonly float LocationUploadIntervalSeconds;

	public static readonly float LocationAutoUploadIntervalSeconds;

	public static bool EnableVehicleOverdrive;

	public static bool TryFixCSRouletteShowNoShopItem;

	public static bool EnableAdjustCreepAngleBiggerEpsilon;

	public static bool EnableAdjustCreepAngleFor3P;

	public static bool EnableGetPhysXStateOpt;

	public static bool EnableDownloadMultiResPriority;

	public static float BRRatingImproveThreshold;

	public static float RatingLvImproveTipTime;

	public static bool EnableExecutionCameraLerpOptimize;

	public static bool EnableAsyncCullResultsRelease;

	public static bool EnableRenderStateRecord;

	public static bool EnableCurrentGameModeSettingOpt;

	public static bool EnableQualityRenderer;

	public static bool EnableWriteToBuffersOpt;

	public static bool EnableSkipUpdateDrawCalls;

	public static bool EnableTreeGroupLowMeshDirtyMark;

	public static bool EnableResourceRecordEventLog;

	public static int ReviveCardMinCost;

	public static string ReviveCardRewardSpriteName;

	public static float TutorialGlobalEventAffixShowTime;

	public static uint OfflineEventLogAutoSave;

	public static uint OfflineEventLogAutoSend;

	public static float OfflineEventLogAutoSaveCnt;

	public static bool EnableNewAirdropHighlightEffect;

	public static bool EnablePlayerRaminInfoRating;

	public static bool FixGetAvatarPositionV2ByPosIdFunc;

	public static bool UseManualGcMode;

	public static bool EnableVFXDistancePauser;

	public static bool StopCureAniAfterAction;

	public static float SocialObjectSyncRangeSqr;

	public static bool EnableCheckSandModeBySwitchFunc;

	public static bool EnableOnCloseAllPopupWindows;

	public static bool EnableCheckMatchEndDelayWhenDisconnect;

	public static string BanStateDisabledArea;

	public static bool DisableOverrideMaterialOnCloseEventRoom;

	public static bool OptUDPMessageCreateInstanceGc;

	public static bool EnableOptimizedLocalObserverEntity;

	public static bool EnableMountableForceAuto;

	public static bool EnableHorseColliderOptShow;

	public static bool EnableHorseVehicleEffectOptShow;

	public static float HorseWoundedHPRange;

	public static float HorseDyingHPRange;

	public static float HorseDyingSpeed;

	public static readonly int PreInitPoolHorseSize;

	public static float HorseSpeedLineSpeed;

	public static float HorseDeadSpeed;

	public static float HorseDeadDuration;

	public static float HorseFireIkFixedAngleX;

	public static float HorseFireIkFixedAngleZ;

	public static bool DisableMishaForHorse;

	public static float HorseAimAngleRightLeft;

	public static float HorseAimAngleUp;

	public static float HorseAimAngleDown;

	public static bool EnableHorseAimForwardDeflect;

	public static float HorseAimForwardKeepAngle;

	public static bool EnableHorseAutoDriveRightTurn;

	public static float HorseAutoDriveRightTurnCoef;

	public static float HorseAutoDriveLeftTurnPriorityDeadZone;

	public static float HorseAutoDriveRightTurnDeadZone;

	public static float VehicleDriverFireRight;

	public static float VehicleDriverFireBack;

	public static float VehicleDriverFireUp;

	public static bool EnableVehicleDriverFireFollowVehicle;

	public static float HorseStanbyInternalMin;

	public static float HorseStanbyInternalMax;

	public static float DriverSupportFireAnimResetTime;

	public static float DriverSupportFirePitchMin;

	public static float DriverSupportFirePitchMax;

	public static float DriverSupportFireLerpAimSpeed;

	public static float HorseSteerLerpSpeed;

	public static bool MinimapRotationWithPlayer;

	public static bool IsOpenRightScopeNearWallOpt;

	public static bool IsOpenRightScopeInWallOpt;

	public static bool IsOpenRightScopeDelayPlayerShowOpt;

	public static int RightShootEffectType;

	public static float VoiceToTextWaitChannelPauseDelaySec;

	public static int InGameVoiceToTextSampleRate;

	public static float InGameVoiceToTextMinValidLength;

	public static int InGameVoiceToTextMaxRecordingLengthSec;

	public static bool FluxFrameRateindependent;

	public static bool FluxOnlySetupOnce;

	public static bool FluxRootCompensation;

	public static bool FluxHighFrameCatchupCompensation;

	public static bool EnableInGameChatInUGC;

	public static uint GB_GPDefaultExecutionSkillID;

	public static string GB_GPKnockdownMaleIdleResName;

	public static string GB_GPKnockdownMaleMoveResName;

	public static string GB_GPKnockdownFemaleIdleResName;

	public static string GB_GPKnockdownFemaleMoveResName;

	public static int GB_GPSafeZoneFirstAudioStageID;

	public static int GB_GPSafeZoneLastAudioStageID;

	public static float GB_GPFootballHitFlyPlayerVelocityThreshold;

	public static float GB_GPFootballHitIceWallVelocityThreshold;

	public static float GB_GPFootballAddSpeedPercent;

	public static float GB_GPFootballLowHighVFXSpeedThreshold;

	public static float GB_GPFootballHudHintCheckCD;

	public static float GB_GPFootballRollAnimSlowScale;

	public static float GB_GPFootballAimAssistLockHeight;

	public static bool GB_GPGulagCanRevive;

	public static bool GB_GPGulagCanPlaceIceWall;

	public static bool EnableWeaponShowCanAwakenIcon;

	public static string AwakenWeaponSwitchEffectVFX;

	public static string AwakenWeaponNameSuffix;

	public static bool EnableWeaponShowAwakenTerm;

	public static bool EnablePickupModelRotateToPlayer;

	public static float LaserSightMaxDis;

	public static float LaserSightMaxDisRunRatio;

	public static float NoticeEnemyFarDist;

	public static float NoticeEnemyNearDist;

	public static bool EnableIdleAnimationSwitcher;

	public static bool EnableUIGeometryPool;

	public static bool EnableUIInputEnsureGeometry;

	public static float CSBPRequestHelpPickTime;

	public static float CSBPRequestExChangeSkillTime;

	public static float CSBPRequestBanTime;

	public static float CSBPStageChangeVFXTime;

	public static bool UGCEnableSceneEditObjectAsyncLoad;

	public static float UGCMaxInstantiateTimePerFrame;

	public static string AccountBanRecheckTimeoutRange;

	public static bool EnableBagSpecialEffectDelay;

	public static float PresetSkillRequestCooldown;

	public static float PresetLoadoutRequestCooldown;

	public static float PresetPickChangingStateSyncInterval;

	public static float RelayMartShareDiscountCodeCoolDown;

	public static float PresetTagCarouselInterval;

	public static float GameVoice_RETRY_DEALY_SECOUND;

	public static int EditRecPlanNameMinLength;

	public static int EditRecPlanNameMaxLength;

	public static bool EnableFogOptimizeInParadise;

	public static bool EnableProfileInfoCacheOptimize;

	public static bool EnableBTFishSimOpt;

	public static bool IsUseSecondWeaponBoneLeftWeapon;

	public static int MaxInGameChatLength;

	public static bool HideSafezoneInfoForNotificaitonPopup;

	public static float CSBanPickClientDelay;

	public static bool WaterGunResetAimSwitch;

	public static bool SendStopMsgInFiringNeedLiftStateExit;

	public static float ItemNameScrollSpeed;

	public static float ItemNameScrollDelay;

	public static uint ItemNameScrollLength;

	public static float IngameBackSickleScaling;

	public static bool HighlightShakeOnlyOnLastEvent;

	public static float HighlightShakeTimeFactor;

	public static float HighlightShakeTimeGrowthFactor;

	public static float HighlightShakeXFactor;

	public static float HighlightShakeXGrowthFactor;

	public static float HighlightShakeYFactor;

	public static float HighlightShakeYGrowthFactor;

	public static float WaterGunHitSoundIceWallOrVehicleSpan;

	public static bool EnableScreenResizeListOpt;

	public static float CabinFaithEstablishmentDelay;

	public static float SetCameraFarClipOnBlueTears;

	public static bool SetVegetationDisableOnBlueTears;

	public static float SetCameraFarClipOnWaterCircle;

	public static readonly bool EnableGoldenAgeLensFlare;

	public static bool AttachCompareResultSortUseLinq;

	public static int FFVoiceValidatePreferredMethod;

	public static bool EnableBRBoardSurfingResizeCCT;

	public static bool EnableScreenSignature;

	public static uint BRUnverifiedVirtualAgeIndex;

	public static bool EnableSwimmingMovementRestriction;

	public static bool EnableUpdateCheckEndingOpt;

	public static int DirectionRulerAngleStringRange;

	public static bool PatchForWrongErrorCodeDuringGMSDKLogin;

	public static bool PatchForWrongErrorCodeDuringGMSDKBind;

	public static bool EnableGMSDKAppleCustomAgeGate;

	public static int GMSDKAppleCustomAgeGateThreshold1;

	public static int GMSDKAppleCustomAgeGateThreshold2;

	public static int GMSDKAppleCustomAgeGateThreshold3;

	public static bool EnableShuffleParams;

	public static bool EnableVoiceToTextLimitMemory;

	public static bool ForceUseVodka;

	public static float UpOffsetInCrouch;

	public static readonly int DisableKillRefreshGetTime;

	public static readonly int DisableGinInfoSend;

	public static readonly int GinInfoBRAliveThreshold;

	public static readonly int AntiHackResetSubgameInterval;

	public static bool ForceDisableVodka;

	public static int POIDisplayHeight;

	public static int POINameMaxWidth;

	public static int POINameMinWidth;

	public static bool EnablePOINameItemVFXCachePool;

	public static bool ASRSendRawBinary;

	public static bool GachaVideoUseUnityVideoPlayer;

	public static bool EnableSwimVehicleOverlapCheck;

	public static bool WalkingVehicleOverlapCheckUseCharacterControllerCenter;

	public static bool EnableGBFootballKickHitflyEnterMoveplatform;

	public static bool EnableResetVelocityOnForceSyncVehicleState;

	public static bool EnableLimitedContentMask;

	public static bool EnableNameLabelBitOptimization;

	public static bool UMACombineCapacityOptimize;

	public static int PhotoWallMaxEditableImages;

	public static int PhotoWallEditableImageMaxSide;

	public static int PhotoWallGCSUploadTimeout;

	public static readonly int SkillMightyMaxEnergy;

	public static readonly int SkillMightyFullTipsTime;

	public static bool EnableGetComponentsGCOpt;

	public static bool DebuggerAllLogs;

	public static bool OptMotoSyncTransform;

	public static bool EnableCustomUIAtlasReleaser;

	public static readonly int SkillMightyUpgradeTipsCD;

	public static readonly string Ninth_GP_SkillMighty;

	public static bool EnableVehicleSeatRigidbodiesRuntime;

	public static bool EnableSocialLobbyStoreLastPos;

	public static bool EnableLootForceShowWhenLastkill;

	public static int LootForceShowRange;

	public static bool ForbidChestJumpEffect;

	public static float ForbidChestJumpEffectTime;

	public static bool EnableUGCHalfwayJoin;

	public static float UGCInviteCoolDown;

	public static float UGCJoinCoolDown;

	public static float InstantSurveyMatchmakingDelaySeconds;

	public static float InstantSurveyCDSeconds;

	public static float InstantSurveyNoAnswerAutoCloseSeconds;

	public static float InstantSurveyVoiceQuestionCDSeconds;

	public static uint InstantSurveyShowLowestLevel;

	public static float InstantSurveyAnswerVFXDelaySeconds;

	public static int PhotoWallCuttingTargetMinHeight;

	public static int PhotoWallCuttingTargetMinWidth;

	public static bool EnableCheckBuf;

	public static bool ForceEmoteOnly1PAudio;

	public static float SOCIALLOBBYDANCEPOOLBANNERCD;

	public static float SubgameLobbyLW_AVATAR_HEAD_HEIGHT;

	public static int SubgameLobbyLWStreakSpecialNum;

	public static int SubgameLobbyLWStreakMinNum;

	public static int SubGameLobbyLWCountdown;

	public static float LobbySocialAreaMatchmakingAlphaHideTime;

	public static bool VoiceBalanceCheckGameVoiceEngineVoiceOn_Wwise;

	public static uint DefaultFollowMoveEmoteID;

	public static float WukongIllusion_ModelAlpha;

	public static float WukongIllusion_HudAlpha;

	public static bool OptimizeCityHeroBoyIceWallDecal;

	public static bool FFVoiceIOSAllowHapticsDuringRecording;

	public static bool EnableUGCRigidbodyCollisionFromPlayer;

	public static float SocialLobbyPrivilegePlayerScaleUpCenterYDelta;

	public static float SocialLobbyPrivilegePlayerScaleDownCenterYDelta;

	public static float SocialLobbyPrivilegePlayerLegAndScaleUpCenterYDelta;

	public static float SocialLobbyPrivilegePlayerLegAndScaleDownCenterYDelta;

	public static float SocialLobbyPrivilegePlayerLegCenterYDelta;

	public static float SocialLobbyPrivilegePlayerFootUPCenterYDelta;

	public static float SocialLobbyPrivilegePlayerFootDownCenterYDelta;

	public static float SocialLobbyPrivilegeUpOffsetOnScaleUp;

	public static float SocialLobbyPrivilegeUpOffsetOnScaleDown;

	public static float SocialLobbyPrivilegeUpOffsetOnLegDeform;

	public static float SocialLobbyPrivilegeUpOffsetOnLegScaleUp;

	public static float SocialLobbyPrivilegeUpOffsetOnLegScaleDown;

	public static float SocialLobbyPrivilegeScaleUpMultiplier;

	public static float SocialLobbyPrivilegeScaleDownMultiplier;

	public static float SocialLobbyPrivilegeDeformHeadMultiplier;

	public static float SocialLobbyPrivilegeDeformHandMultiplier;

	public static float SocialLobbyPrivilegeDeformFootMultiplier;

	public static float SocialLobbyPrivilegeDeformArmMultiplier;

	public static float SocialLobbyPrivilegeDeformLegMultiplier;

	public static float SocialLobbyPrivilegeDeformNeckMultiplier;

	public static float SocialLobbyPrivilegeDeformHeadDownMultiplier;

	public static float SocialLobbyPrivilegeDeformHandDownMultiplier;

	public static float SocialLobbyPrivilegeDeformFootDownMultiplier;

	public static float SocialLobbyPrivilegeHudNameOffsetOnScaleUp;

	public static float SocialLobbyPrivilegeHudNameOffsetOnScaleDown;

	public static float SocialLobbyPrivilegeHudNameOffsetOnScaleUpAndLeg;

	public static float SocialLobbyPrivilegeHudNameOffsetOnScaleDownAndLeg;

	public static float SocialLobbyPrivilegeHudNameOffsetOnHeadDeform;

	public static float SocialLobbyPrivilegeHudNameOffsetOnLegDeform;

	public static float SocialLobbyPrivilegeHudNameOffsetOnHeadDownDeform;

	public static float SocialLobbyGroupAnimLightIntensity;

	public static bool VodkaForceComplex;

	public static bool SocialAreaRoomCanDownloadOptional;

	public static float HorseMoveEffectShowSpeed;

	public static bool EnableHorseSetSkipOptAll;

	public static bool EnableWeatherSkyboxRuntimeInstance;

	public static bool ChangeHighlightCameraActiveTime;

	public static float LobbySocialLWResultAvatarMaxOutlineWidth;

	public static int AuroraBoy1PRenderQNew;

	public static int TRANSPARENT_RENDERQUEUENew;

	public static bool ForceUpdateClothesChangeAnim;

	public static bool PauseOthersWhenForceTutorialOptionalDownload;

	public static bool HudItemInfosOpen;

	public static bool IsClearDistanceValueOnJoinedRoom;

	public static bool EnableInGameUGCVoiceInBR;

	public static bool EnableBigHeadResetHangmanager;

	public static bool EnableDeformHangSetupInSocialLobby;

	public static int LobbySocialCanBeHeardMaxPlayersNum;

	public static bool GameVoiceSetVoiceReciverIsLog;

	public static bool FixSetMicAndSpeakerMute;

	public static float GetCatapultHorizontalMinAngle(LevelCatapult levelCatapult)
	{
		return 0f;
	}

	public static float GetCatapultHorizontalMaxAngle(LevelCatapult levelCatapult)
	{
		return 0f;
	}

	public static float GetCatapultVerticalMinAngle(LevelCatapult levelCatapult)
	{
		return 0f;
	}

	public static float GetCatapultVerticalMaxAngle(LevelCatapult levelCatapult)
	{
		return 0f;
	}

	public static float GetCatapultSpeed(LevelCatapult levelCatapult)
	{
		return 0f;
	}
}
