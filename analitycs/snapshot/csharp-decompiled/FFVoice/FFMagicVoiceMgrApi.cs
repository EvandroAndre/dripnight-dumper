using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

namespace FFVoice;

public class FFMagicVoiceMgrApi
{
	public enum CallbackType
	{
		CALLBACK_TYPE_EVENT,
		CALLBACK_TYPE_VIPINFO
	}

	public class FFMVCallbackObject : MonoBehaviour
	{
		private void Start()
		{
		}

		private void FFMVCallback()
		{
		}
	}

	private static FFMagicVoiceMgrApi mInstance;

	private bool mAndroidInited;

	private bool mAndroidInitOK;

	private IFFMagicVoiceMgrCallback callback;

	[PreserveSig]
	private static extern int ffmv_setConfig(string strVoiceSvrDomain, string strDataReportSvrDomain);

	[PreserveSig]
	private static extern int ffmv_setUserInfo(string stra, string strAPPSecret, string strUserId, string strToken, string strNickName, int tokentype, ulong timestamp);

	[PreserveSig]
	private static extern int ffmv_getSDKVersion();

	[PreserveSig]
	private static extern bool ffmv_isVip();

	[PreserveSig]
	private static extern IntPtr ffmv_getMagicVoiceEffectInfoList();

	[PreserveSig]
	private static extern IntPtr ffmv_getPreviewEffectInfoList();

	[PreserveSig]
	private static extern int ffmv_setMagicVoiceInfo(int effectId);

	[PreserveSig]
	private static extern int ffmv_clearMagicVoiceInfo();

	[PreserveSig]
	private static extern int ffmv_setMagicVoiceAdjust(double dFS, double dSemitones);

	[PreserveSig]
	private static extern int ffmv_updateMagicVoiceEffectInfoList();

	[PreserveSig]
	private static extern bool ffmv_getMagicVoiceEffectEnabled();

	[PreserveSig]
	private static extern int ffmv_setPreviewMagicVoiceInfo(int effectId);

	[PreserveSig]
	private static extern int ffmv_setPreviewMagicVoiceAdjust(double dFS, double dSemitones);

	[PreserveSig]
	private static extern int ffmv_startPreviewMagicVoiceEffect();

	[PreserveSig]
	private static extern int ffmv_stopPreviewMagicVoiceEffect();

	[PreserveSig]
	private static extern IntPtr ffmv_getCbMessage();

	[PreserveSig]
	private static extern void ffmv_releaseString(IntPtr pStr);

	[PreserveSig]
	private static extern void ffmv_setDebug(bool isDebug);

	private void ParseJsonCallbackMessage(string strCbMessage)
	{
	}

	private void InitAndroidJava()
	{
	}

	public static FFMagicVoiceMgrApi GetInstance()
	{
		return null;
	}

	public FFMagicVoiceErrorCode SetConfig(string strVoiceSvrDomain, string strDataReportSvrDomain)
	{
		return FFMagicVoiceErrorCode.FFMV_SUCCESS;
	}

	public void SetCallback(IFFMagicVoiceMgrCallback callback)
	{
	}

	public FFMagicVoiceErrorCode SetUserInfo(string strAppKey, string strAppSecret, string strUserId, string strToken, string strNickName, ulong ulTimestamp)
	{
		return FFMagicVoiceErrorCode.FFMV_SUCCESS;
	}

	public int GetSDKVersion()
	{
		return 0;
	}

	public bool IsVip()
	{
		return false;
	}

	public FFMagicVoiceErrorCode GetMagicVoiceEffectInfoList(List<FFMagicVoiceEffectInfo> effectList)
	{
		return FFMagicVoiceErrorCode.FFMV_SUCCESS;
	}

	public FFMagicVoiceErrorCode SetMagicVoiceInfo(int effectId)
	{
		return FFMagicVoiceErrorCode.FFMV_SUCCESS;
	}

	public FFMagicVoiceErrorCode ClearMagicVoiceInfo()
	{
		return FFMagicVoiceErrorCode.FFMV_SUCCESS;
	}

	public FFMagicVoiceErrorCode SetMagicVoiceAdjust(double dFS, double dSemitones)
	{
		return FFMagicVoiceErrorCode.FFMV_SUCCESS;
	}

	public bool GetMagicVoiceEffectEnabled()
	{
		return false;
	}

	public FFMagicVoiceErrorCode UpdateMagicVoiceEffectInfoList()
	{
		return FFMagicVoiceErrorCode.FFMV_SUCCESS;
	}

	public FFMagicVoiceErrorCode GetPreviewEffectInfoList(List<FFMagicVoiceEffectInfo> effectList)
	{
		return FFMagicVoiceErrorCode.FFMV_SUCCESS;
	}

	public FFMagicVoiceErrorCode SetPreviewMagicVoiceInfo(int effectId)
	{
		return FFMagicVoiceErrorCode.FFMV_SUCCESS;
	}

	public FFMagicVoiceErrorCode SetPreviewMagicVoiceAdjust(double dFS, double dSemitones)
	{
		return FFMagicVoiceErrorCode.FFMV_SUCCESS;
	}

	public FFMagicVoiceErrorCode StartPreviewMagicVoiceEffect()
	{
		return FFMagicVoiceErrorCode.FFMV_SUCCESS;
	}

	public FFMagicVoiceErrorCode StopPreviewMagicVoiceEffect()
	{
		return FFMagicVoiceErrorCode.FFMV_SUCCESS;
	}

	public FFMagicVoiceErrorCode SetDebug(bool isDebug)
	{
		return FFMagicVoiceErrorCode.FFMV_SUCCESS;
	}
}
