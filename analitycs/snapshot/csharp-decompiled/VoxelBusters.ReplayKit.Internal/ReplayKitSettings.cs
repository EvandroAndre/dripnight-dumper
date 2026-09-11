using UnityEngine;

namespace VoxelBusters.ReplayKit.Internal;

public class ReplayKitSettings
{
	private const string strReplayKitVideoQualityKey = "ReplayKitVideoQuality";

	private const string ReplayKitMicrophoneKey = "ReplayKitMicrophoneKey";

	private const string ReplayKitAudioCodecCombineKey = "ReplayKitAudioCodecCombineKey";

	private const string ReplayKitVideoBitRateKey = "ReplayKitVideoBitRateKey";

	private const string AudioFormatCodeKey = "AudioFormatCodeKey";

	public static bool UsesMicrophone
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static VideoQuality VideoQuality
	{
		get
		{
			return VideoQuality.QUALITY_1080P;
		}
		set
		{
		}
	}

	public static bool EnableAudioCodecCombine
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool HighlightRecordRequestPermession => false;

	public static bool EnableVideoBitRate
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool EncodePCMFloat
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool UseMinimalEncoder => false;

	public static void SetUsesMicrophone(bool state)
	{
	}

	public static NativeVideoQualityType GetNativeVideoQualityType(VideoQuality videoQuality)
	{
		return NativeVideoQualityType.QUALITY_MATCH_SCREEN_SIZE;
	}

	public static NativeVideoQualityType GetNativeVideoQualityType()
	{
		return NativeVideoQualityType.QUALITY_MATCH_SCREEN_SIZE;
	}

	public static void SetAudioCodecCombine(bool state)
	{
	}

	public static void SetVideoBitRate(bool state)
	{
	}

	public static void SetAudioEncodeFormat(bool floating)
	{
	}

	public static Camera GetUICamera()
	{
		return null;
	}

	public static PostEffectManagerBase GetPostEffectManager()
	{
		return null;
	}
}
