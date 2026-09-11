using System;
using System.Collections.Generic;
using System.Text;
using GCommon;
using proto;

namespace COW;

public class UIModelQuickMessage : UIBaseModel
{
	public enum ChangeMsgOp
	{
		UnExpectError,
		Success,
		SwitchTwoMsg,
		ChangeMsgConfilict
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<BundleShowData, uint> _003C_003E9__34_0;

		public static Converter<BundleShowData, uint> _003C_003E9__35_0;

		internal uint _003CGetQuickMessageItemIdsByItemId_003Eb__34_0(BundleShowData item)
		{
			return 0u;
		}

		internal uint _003CCheckItemIsQuickMessage_003Eb__35_0(BundleShowData item)
		{
			return 0u;
		}
	}

	private sealed class _003C_003Ec__DisplayClass19_0
	{
		public UIModelQuickMessage _003C_003E4__this;

		public QuickMsgSettings savedData;

		public bool closeAfterSave;

		internal void _003CSaveQuickMsgAsync_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	public const uint PropID_GetQuickMessageOK = 2u;

	public const uint PropID_SaveQuickMessageOK = 4u;

	public const uint PropID_SaveQuickMessageFailure = 8u;

	public bool RequestServering;

	public bool RequestServerSuccess;

	private QuickMsgSettings m_ServerData;

	private QuickMsgSettings m_UIdata;

	private QuickMsgSettings m_DefaultData;

	private const string m_NewItemKey = "NewItemKey";

	private const string m_SoundSettingNewItemKey = "SoundSettingNewItemKey";

	private StringBuilder m_StringBuilder;

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Logout(object[] data)
	{
	}

	public void InitUIData()
	{
	}

	public void ClearUIData()
	{
	}

	public void OnStartMatch()
	{
	}

	public void GetQuickMsgFromServer()
	{
	}

	public void OnBackpackChanged()
	{
	}

	private void GetQuickMsgAsync()
	{
	}

	public void SaveQuickMsgAsync(bool closeAfterSave = false, string naviFrom = "")
	{
	}

	public void SwitchVocal()
	{
	}

	public uint GetVocal()
	{
		return 0u;
	}

	public int? GetMsgContainerIdx(EQuickChatCategory category, bool isList, uint msgId)
	{
		return null;
	}

	public int? BubbleMoveMsgSetting(EQuickChatCategory category, int startIdx, int targetIdx)
	{
		return null;
	}

	public ChangeMsgOp ChangeMsgSetting(EQuickChatCategory category, bool isList, int idx, uint msgId)
	{
		return ChangeMsgOp.UnExpectError;
	}

	public void GetMsgs(List<uint> result, EQuickChatCategory category, bool isListMsg)
	{
	}

	public ResourceID GetBasicMsgVoiceResId(uint msgId, uint? vocal = null, bool dontCheckNeedDownload = false)
	{
		return default(ResourceID);
	}

	public List<CSVBaseData> GetMsgsByGameMode(bool isList)
	{
		return null;
	}

	private QuickMsgSettings DeepCloneSettingFromDefault()
	{
		return null;
	}

	private QuickMsgModeSettings InitDefaultCategoryMsg(EQuickChatCategory category)
	{
		return null;
	}

	private QuickMsgSettings DeepCloneSetting(QuickMsgSettings data)
	{
		return null;
	}

	private void SendSaveLog(QuickMsgSettings cur, QuickMsgSettings pre, string naviFrom)
	{
	}

	private bool ArrayEquals<T>(T[] lhs, T[] rhs)
	{
		return false;
	}

	public void GetQuickMessageItemIdsByItemId(uint itemId, List<uint> msgList)
	{
	}

	public bool CheckItemIsQuickMessage(uint itemId)
	{
		return false;
	}

	public List<ResourceID> GetCustomizationNeedDownloadListByGroupId(uint groupId)
	{
		return null;
	}

	public List<ResourceID> GetAllCustomizationNeedDownloadList()
	{
		return null;
	}

	private void ReplaceInvalidMagIdToFakeId()
	{
	}

	private void ReplaceFakeIdToInvalidMagId()
	{
	}

	private bool CheckEquippedItems()
	{
		return false;
	}

	private bool CheckItemIsExpire(uint itemId)
	{
		return false;
	}

	private void ReplaceExpireItem()
	{
	}

	private void _003CGetQuickMsgAsync_003Eb__18_0(HttpErrorCode errorCode, object res)
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
