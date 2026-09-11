using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIModelSecretMessage : UIBaseModel
{
	public enum ExchangeErrorCode
	{
		Unknown,
		Success,
		ModelNotReady,
		SeparatorNotFound,
		SecretMessageBorderNotFound,
		PrefixCodeNotFound,
		SecretCodeNotFound
	}

	private sealed class _003C_003Ec__DisplayClass15_0
	{
		public UIModelSecretMessage _003C_003E4__this;

		public uint secretMessageID;

		public uint activityID;

		internal void _003CRequestSecretMessageKey_003Eb__0(HttpErrorCode errorCode, object result)
		{
		}
	}

	public const char SECRET_MESSAGE_SEPARATOR = '@';

	public const uint PropID_SecretMessageDescReceived = 1u;

	public const uint PropID_SecretMessageReceived = 2u;

	public const uint PropID_SecretMessageExchanged = 4u;

	private readonly WaitingResponseHandler m_WaitingResponseHandler;

	private List<SecretMissionDesc> m_SecretMessageDescList;

	private bool IsReady => false;

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Init()
	{
	}

	protected override void OnCleanup()
	{
	}

	public override void Logout(object[] data)
	{
	}

	public void RequestSecretMessageDesc()
	{
	}

	private void OnRequestSecretMessageDescFinished(HttpErrorCode errorCode, object result)
	{
	}

	public void RequestSecretMessageKey(uint activityID)
	{
	}

	public void RequestExchangeSecretMessageKey(uint secretMissionID, ulong suffixCode)
	{
	}

	private void OnRequestExchangeSecretMessageKey(HttpErrorCode errorCode, object result)
	{
	}

	private uint GetSecretMessageIDWithActivityIDInternal(uint activityID)
	{
		return 0u;
	}

	private SecretMissionDesc GetSecretMessageDescWithIDInternal(uint secretMessageID)
	{
		return null;
	}

	public static string GetSecretMessageContent(string prefixKey, ulong secretCode)
	{
		return null;
	}

	public bool IsSystemAvailable()
	{
		return false;
	}

	public uint GetSecretMessageIDWithActivityID(uint activityID)
	{
		return 0u;
	}

	public uint GetSecretMessageExchangeLimit(uint secretMessageID)
	{
		return 0u;
	}

	public string GetSecretMessageTitleKey(uint secretMessageID)
	{
		return null;
	}

	public string GetSecretMessageCompleteContent(uint secretMessageID, string secretMessageContent)
	{
		return null;
	}

	public ExchangeErrorCode TryExchangeSecretMessageWithRawContent(uint secretMessageID, string rawContent)
	{
		return ExchangeErrorCode.Unknown;
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	public void _003C_003EiFixBaseProxy_OnCleanup()
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
