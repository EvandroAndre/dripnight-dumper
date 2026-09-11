namespace FFVoice;

public struct FFMagicVoiceVipInfo
{
	public int StartTime;

	public int Duration;

	public bool IsPayed;

	public bool IsAlwaysVip;

	public int getVipEndTime()
	{
		return 0;
	}

	public FFMagicVoiceVipStatus getVipStatus()
	{
		return FFMagicVoiceVipStatus.FFMV_VIP_NeverVip;
	}

	public bool isVip()
	{
		return false;
	}

	public bool isPayed()
	{
		return false;
	}
}
