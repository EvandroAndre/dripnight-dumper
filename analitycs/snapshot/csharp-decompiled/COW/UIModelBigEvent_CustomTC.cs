using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIModelBigEvent_CustomTC : UIBaseModel
{
	private sealed class _003C_003Ec__DisplayClass87_0
	{
		public UIModelBigEvent_CustomTC _003C_003E4__this;

		public uint piece;

		internal void _003CRequestCustomTCReward_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private UIModelBigEventTemplate m_UIModelBigEventTemplate;

	public const int PuzzleWight = 930;

	public const int PuzzleHight = 484;

	public const uint CirculateBoxId = 0u;

	private const string ModelBigEvent_CustomTC_Animation = "ModelBigEventCustomTCAnimation{0}";

	private const string ModelBigEvent_CustomTC_AnimationFirstIn = "ModelBigEvent_CustomTC_AnimationFirstIn{0}";

	public const string GuideDecipherKey = "CustomTC_Guide_Decipher";

	public const string GuideMissionKey = "CustomTC_Guide_Mission";

	public const string GuideTutorialKey = "CustomTC_Guide_Tutorial";

	private uint _003CCustomEventId_003Ek__BackingField;

	private uint _003CCurrentPiece_003Ek__BackingField;

	private uint _003CCurrentProgress_003Ek__BackingField;

	private uint _003CMaxProgress_003Ek__BackingField;

	private bool _003CAnimationSwitch_003Ek__BackingField;

	private uint _003CMaxPieceId_003Ek__BackingField;

	private uint _003CPieceRow_003Ek__BackingField;

	private uint _003CPieceCloumn_003Ek__BackingField;

	private uint _003CFreeCount_003Ek__BackingField;

	private bool _003CGuildDeipherShow_003Ek__BackingField;

	private bool _003CGuildMissionShow_003Ek__BackingField;

	private bool _003CHasCustomTCInfo_003Ek__BackingField;

	private bool m_HasCustomTCRedRequest;

	private bool m_HasServerCustomTCRed;

	private uint m_CurrentUseType;

	private CustomTCConstantDesc _003CConstant_003Ek__BackingField;

	private Dictionary<uint, CustomTCPieceInfo> m_PieceDict;

	private List<CSCustomTCMainRes.RewardInfo> m_UnreceiveRewards;

	private bool _003CIsDecoding_003Ek__BackingField;

	public const int PropID_CustomTCInfoRefresh = 2;

	public const int PropID_CustomTCDecode = 4;

	public const int PropID_CustomTCRewardRefresh = 8;

	public const int PropID_CustomTCRedRefresh = 16;

	public uint CustomEventId
	{
		get
		{
			return _003CCustomEventId_003Ek__BackingField;
		}
		private set
		{
			_003CCustomEventId_003Ek__BackingField = value;
		}
	}

	public uint CurrentPiece
	{
		get
		{
			return _003CCurrentPiece_003Ek__BackingField;
		}
		private set
		{
			_003CCurrentPiece_003Ek__BackingField = value;
		}
	}

	public uint CurrentProgress
	{
		get
		{
			return _003CCurrentProgress_003Ek__BackingField;
		}
		private set
		{
			_003CCurrentProgress_003Ek__BackingField = value;
		}
	}

	public uint MaxProgress
	{
		get
		{
			return _003CMaxProgress_003Ek__BackingField;
		}
		private set
		{
			_003CMaxProgress_003Ek__BackingField = value;
		}
	}

	public bool AnimationSwitch
	{
		get
		{
			return _003CAnimationSwitch_003Ek__BackingField;
		}
		private set
		{
			_003CAnimationSwitch_003Ek__BackingField = value;
		}
	}

	public uint MaxPieceId
	{
		get
		{
			return _003CMaxPieceId_003Ek__BackingField;
		}
		private set
		{
			_003CMaxPieceId_003Ek__BackingField = value;
		}
	}

	public uint PieceRow
	{
		get
		{
			return _003CPieceRow_003Ek__BackingField;
		}
		private set
		{
			_003CPieceRow_003Ek__BackingField = value;
		}
	}

	public uint PieceCloumn
	{
		get
		{
			return _003CPieceCloumn_003Ek__BackingField;
		}
		private set
		{
			_003CPieceCloumn_003Ek__BackingField = value;
		}
	}

	public uint FreeCount
	{
		get
		{
			return _003CFreeCount_003Ek__BackingField;
		}
		private set
		{
			_003CFreeCount_003Ek__BackingField = value;
		}
	}

	public bool GuildDeipherShow
	{
		get
		{
			return _003CGuildDeipherShow_003Ek__BackingField;
		}
		set
		{
			_003CGuildDeipherShow_003Ek__BackingField = value;
		}
	}

	public bool GuildMissionShow
	{
		get
		{
			return _003CGuildMissionShow_003Ek__BackingField;
		}
		set
		{
			_003CGuildMissionShow_003Ek__BackingField = value;
		}
	}

	public bool HasCustomTCInfo
	{
		get
		{
			return _003CHasCustomTCInfo_003Ek__BackingField;
		}
		set
		{
			_003CHasCustomTCInfo_003Ek__BackingField = value;
		}
	}

	public CustomTCConstantDesc Constant
	{
		get
		{
			return _003CConstant_003Ek__BackingField;
		}
		private set
		{
			_003CConstant_003Ek__BackingField = value;
		}
	}

	public Dictionary<uint, CustomTCPieceInfo> PiecesDict => null;

	public List<CSCustomTCMainRes.RewardInfo> UnclaimedRewards => null;

	public bool IsDecoding
	{
		get
		{
			return _003CIsDecoding_003Ek__BackingField;
		}
		private set
		{
			_003CIsDecoding_003Ek__BackingField = value;
		}
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Login(object[] data)
	{
	}

	public override void Logout(object[] data)
	{
	}

	public override void Init()
	{
	}

	private void ClearCachedData()
	{
	}

	public bool HasTutorialTips()
	{
		return false;
	}

	public void SetTutorialTips()
	{
	}

	public void RequestCustomTCInfos(uint useType)
	{
	}

	public void RequestDecodeCustomTCPiece(uint useType)
	{
	}

	public void RequestCustomTCReward(uint piece)
	{
	}

	public void RequestCustomTCRedPoint(uint useType)
	{
	}

	public bool TokenEnoughDecodePiece(uint useType)
	{
		return false;
	}

	public bool IsLobbyEntranceTipsNeedShow(uint useType, out bool showRewardTips)
	{
		showRewardTips = default(bool);
		return false;
	}

	public bool NeedShowOpenAnimation()
	{
		return false;
	}

	public void SetBigEventAnimationOpen()
	{
	}

	public bool NeedShowFirstAnimationIn()
	{
		return false;
	}

	public void SetBigEventAnimationFirstInOpen()
	{
	}

	public bool IsPuzzleMaskOpen()
	{
		return false;
	}

	public bool HasUnreceivedReward()
	{
		return false;
	}

	public uint GetCurrentPieceConsume()
	{
		return 0u;
	}

	private void AddUnclaimedRewards(uint pieceId, uint rewardAmount)
	{
	}

	private void RemoveUnclaimedRewards(uint pieceId)
	{
	}

	public CSCustomTCMainRes.RewardInfo GetUnclaimedRewards(uint pieceId)
	{
		return null;
	}

	public BaseItemInfo GetRepeatRewardBaseItemInfo()
	{
		return null;
	}

	public CustomTCPieceInfo GetPieceDesc(uint pieceId)
	{
		return null;
	}

	public string GetNoTokenWndBgCDNUrl(uint useType)
	{
		return null;
	}

	public string GetMainCloseBgCdnUrl(uint useType)
	{
		return null;
	}

	public string GetTCTextureCdnUrl(uint useType)
	{
		return null;
	}

	public string GetTCShareImageCdnUrl(uint useType)
	{
		return null;
	}

	public string GeTCTextureMaskCdnCdnUrl(uint useType)
	{
		return null;
	}

	public string GeTCTextureMaskLineUrl(uint useType)
	{
		return null;
	}

	public string GeTCTextureMaskFrameUrl(uint useType)
	{
		return null;
	}

	public string GetTCRewardPreviewBtnCdnUrl(uint useType)
	{
		return null;
	}

	public string GetTCDecipherBtnCdnUrl(uint useType)
	{
		return null;
	}

	public string GetTCShareBtnCdnUrl(uint useType)
	{
		return null;
	}

	public string GetTCShareRewardCdnUrl(uint useType)
	{
		return null;
	}

	public string GetTCCirculateBoxBgCdnUrl(uint useType)
	{
		return null;
	}

	public string GetTCCirculateBoxItemCdnUrl(uint useType)
	{
		return null;
	}

	public string GetTCCirculateBoxProgressCdnUrl(uint useType)
	{
		return null;
	}

	public string GetTCCirculateBoxTipsBgUrl(uint useType)
	{
		return null;
	}

	public string GetTCCirculateBoxRedCdnUrl(uint useType)
	{
		return null;
	}

	public string GetTCDecodingProgressBgUrl(uint useType)
	{
		return null;
	}

	public string GetTCDecodingProgressBg2Url(uint useType)
	{
		return null;
	}

	public string GetTCPieceRewardSelectedCdnUrl(uint useType)
	{
		return null;
	}

	public string GetTCRewardPreviewBgUrl(uint useType)
	{
		return null;
	}

	public string GetTCRewardsOverviewBgUrl(uint useType)
	{
		return null;
	}

	public string GetTCRewardsOverviewListBgUrl(uint useType)
	{
		return null;
	}

	public string GetTCDecodingProgressTipsUrl(uint useType)
	{
		return null;
	}

	public string GetTCDecipheringAnimationBgUrl(uint useType)
	{
		return null;
	}

	public string GetTCDecipheringAnimationTipsBgUrl(uint useType)
	{
		return null;
	}

	public string GetTCDecipheringAnimationCancelBtnUrl(uint useType)
	{
		return null;
	}

	public string GetTCPerfectDecipheringBgUrl(uint useType)
	{
		return null;
	}

	public string GetTCStartAnimationPrintBgUrl(uint useType)
	{
		return null;
	}

	public string GetTCStartAnimationPrintUrl(uint useType)
	{
		return null;
	}

	public string GetTCStartSuccessBgUrl(uint useType)
	{
		return null;
	}

	public string GetTCTeachingBubbleBgUrl(uint useType)
	{
		return null;
	}

	public string GeTCReceiveWindowBGUrl()
	{
		return null;
	}

	public string GeTCReceiveNormalBtnUrl()
	{
		return null;
	}

	public string GeTCReceiveLightBtnUrl()
	{
		return null;
	}

	public Color GetCommonPreviewCloseColor(uint useType)
	{
		return default(Color);
	}

	public Color GetTCDecodingProgressLocColour(uint useType)
	{
		return default(Color);
	}

	public Color GetTCDecodingProgressLocColour2(uint useType)
	{
		return default(Color);
	}

	public Color GetTCDecipheringAnimationNumColor(uint useType)
	{
		return default(Color);
	}

	public UIModelBigEventTemplate.LocStrWithColor GetNoTokenWndTitleDescLoc(uint useType)
	{
		return null;
	}

	public UIModelBigEventTemplate.LocStrWithColor GetTCRewardsOverviewBgTitleLoc(uint useType)
	{
		return null;
	}

	public UIModelBigEventTemplate.LocStrWithColor GetTCRewardsOverviewListBgTitleLoc(uint useType)
	{
		return null;
	}

	public UIModelBigEventTemplate.LocStrWithColor GetTCRewardPreviewBgTitleLoc(uint useType)
	{
		return null;
	}

	public UIModelBigEventTemplate.LocStrWithColor GetTCRewardPreviewBgDesLoc(uint useType)
	{
		return null;
	}

	public UIModelBigEventTemplate.LocStrWithColor GetTCDecipherBtnLoc(uint useType)
	{
		return null;
	}

	public UIModelBigEventTemplate.LocStrWithColor GetTCDecipherBtnFreeLoc(uint useType)
	{
		return null;
	}

	public UIModelBigEventTemplate.LocStrWithColor GetTCRewardPreviewBtnLoc(uint useType)
	{
		return null;
	}

	public UIModelBigEventTemplate.LocStrWithColor GetTCCirculateBoxLoc(uint useType)
	{
		return null;
	}

	public UIModelBigEventTemplate.LocStrWithColor TCCirculateBoxTipsLoc(uint useType)
	{
		return null;
	}

	public UIModelBigEventTemplate.LocStrWithColor GetTCDecodingProgressTipsTitleLoc(uint useType)
	{
		return null;
	}

	public UIModelBigEventTemplate.LocStrWithColor GetTCDecodingProgressTipsDesLoc(uint useType)
	{
		return null;
	}

	public UIModelBigEventTemplate.LocStrWithColor GetTCDecipheringAnimationTipsTitleLoc(uint useType)
	{
		return null;
	}

	public UIModelBigEventTemplate.LocStrWithColor GetTCDecipheringAnimationCancelLoc(uint useType)
	{
		return null;
	}

	public UIModelBigEventTemplate.LocStrWithColor GetTCPerfectDecipheringLoc(uint useType)
	{
		return null;
	}

	public UIModelBigEventTemplate.LocStrWithColor GetTCStartSuccessLoc(uint useType)
	{
		return null;
	}

	public UIModelBigEventTemplate.LocStrWithColor GetTCStartAnimationPrintLoc(uint useType)
	{
		return null;
	}

	public UIModelBigEventTemplate.LocStrWithColor GetTCReceiveTitleLoc()
	{
		return null;
	}

	public UIModelBigEventTemplate.LocStrWithColor GetTCTeachingBubbleLoc()
	{
		return null;
	}

	private bool GetResult(string str)
	{
		return false;
	}

	public bool ResetTempleVFXObject(GameObject vfxObj)
	{
		return false;
	}

	public ResourceID GetCirculateBoxVFX(uint useType)
	{
		return default(ResourceID);
	}

	public ResourceID GetCirculateBoxRewardVFX(uint useType)
	{
		return default(ResourceID);
	}

	public ResourceID GetTCDecipheringAnimationSuccessUIFX(uint useType)
	{
		return default(ResourceID);
	}

	public ResourceID GetTCDecipheringAnimationUIFX(uint useType)
	{
		return default(ResourceID);
	}

	public ResourceID GetTCStartAnimationPrintUIFX(uint useType)
	{
		return default(ResourceID);
	}

	public ResourceID GetTCStartSuccessUIFX(uint useType)
	{
		return default(ResourceID);
	}

	public ResourceID GetTCStartOpenUIFX(uint useType)
	{
		return default(ResourceID);
	}

	public ResourceID GetTCRewardPreviewUIFX(uint useType)
	{
		return default(ResourceID);
	}

	public ResourceID GetTCMainAnimationInUIFX(uint useType)
	{
		return default(ResourceID);
	}

	public ResourceID GetTCMainAnimationFirstInUIFX(uint useType)
	{
		return default(ResourceID);
	}

	public ResourceID GetDecodingProgressUIFX(uint useType)
	{
		return default(ResourceID);
	}

	public ResourceID GetTCPieceTransitionUIFX(uint useType)
	{
		return default(ResourceID);
	}

	public ResourceID GetTCMainBGUIFX(uint useType)
	{
		return default(ResourceID);
	}

	public ResourceID GetTCDecipherInSound(uint useType)
	{
		return default(ResourceID);
	}

	public ResourceID GetTCDecipherPerfectSound(uint useType)
	{
		return default(ResourceID);
	}

	public ResourceID GetTCDecipherSound(uint useType)
	{
		return default(ResourceID);
	}

	public ResourceID GetTCDecipherSuccessSound(uint useType)
	{
		return default(ResourceID);
	}

	public ResourceID GetTCOpenInSound(uint useType)
	{
		return default(ResourceID);
	}

	public ResourceID GetTCOpenSuccessSound(uint useType)
	{
		return default(ResourceID);
	}

	public ResourceID GetTCPieceUnlockSound(uint useType)
	{
		return default(ResourceID);
	}

	public ResourceID GetTCPieceProgressSound(uint useType)
	{
		return default(ResourceID);
	}

	private void _003CRequestCustomTCInfos_003Eb__85_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestDecodeCustomTCPiece_003Eb__86_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestCustomTCRedPoint_003Eb__88_0(HttpErrorCode errorCode, object res)
	{
	}

	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}
}
