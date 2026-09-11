using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using message;

namespace COW;

public class UIHudQuickChatContainerController : UIBaseController
{
	private sealed class _003C_003Ec__DisplayClass42_0
	{
		public UIHudQuickChatContainerController _003C_003E4__this;

		public uint value;

		internal void _003COnSendQuickChat_003Eb__0()
		{
		}
	}

	private UIHudQuickChatContainerView m_View;

	private List<QuickChatShowItem> m_ShowQueue;

	private Queue<QuickChatView> m_LabelPool;

	private uint m_UpdateCallID;

	private int m_BGOrigHeight;

	private uint m_uMutliThumbHideDelayCallID;

	private int m_nMutliThumbTimes;

	private bool m_IsStartMatchEndShow;

	private int m_MatchEndThumbUpCount;

	private float m_LastHelpMeQuickChatPlayShotTime;

	private HashSet<uint> m_HelpMeMuteQuickChatIds;

	public static float BR_MATCHENDLIKE_HEIGHT_WITH_FEEDBACK;

	public static float BR_MATCHENDLIKE_HEIGHT_WITH_NO_FEEDBACK;

	public static float CS_MATCHENDLIKE_HEIGHT_WITH_FEEDBACK;

	public static float CS_MATCHENDLIKE_HEIGHT_WITH_NO_FEEDBACK;

	private Dictionary<uint, LevelObjectQuickChatData> m_LevelObjectQuickChatData;

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	private void OnRecvQuickChat(object[] data)
	{
	}

	private void OnRecvTeamChat(object[] data)
	{
	}

	private void OnRecvQuickChatV2Message(object[] data)
	{
	}

	private string GetQuickChatV2ShowText(InGameQuickChatV2Message msg, InGameQuickChatV2 config, Player sender)
	{
		return null;
	}

	private void TryShowQuickChatV2Text(Player sender, string txt)
	{
	}

	private void TryShowTeamChatText(ClientInGameChatMessage msg, Player p)
	{
	}

	private void TryPlayQuickChatVoice(IFMLBFHBFCM res, uint id, IngameQuickChatData messageData)
	{
	}

	private void TryShowQuickChatText(IFMLBFHBFCM res, Player p, string txt, string responseIcon = "")
	{
	}

	private void HideThumbUpViewAndClearTimes()
	{
	}

	private void DelayHideThumbUpView()
	{
	}

	private void UpdateQuickChatShow()
	{
	}

	private void UpdateQuickChatHelpPurchaseShow(object[] data)
	{
	}

	private void UpdateTeamParachuteMarkPOIDistance()
	{
	}

	private void UpdateQuickChatTeamParachuteMarkPOI(object[] data)
	{
	}

	private void ResetPositionAndScrollToBottom()
	{
	}

	private void OnStartMatchEndShow(object[] data)
	{
	}

	private void OnMatchEnd(object[] data)
	{
	}

	private void ClearQuickChatDelay()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void RecordAndShowMatchEndThumbUp(int count)
	{
	}

	private void LogRequestMatchEndThumbUp()
	{
	}

	private void OnUGCFactionChange(object[] param)
	{
	}

	private void OnCancelSendQuickChat(uint value)
	{
	}

	private void OnSendQuickChat(uint value, uint objectId)
	{
	}

	private void DelaySendQuickChat(uint value)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
