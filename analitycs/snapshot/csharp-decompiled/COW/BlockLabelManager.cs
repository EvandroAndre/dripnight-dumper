using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using GCommon;

namespace COW;

public class BlockLabelManager : SingletonModule<BlockLabelManager>
{
	private enum ELabelType
	{
		Url,
		Email,
		PhoneNum
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static MatchEvaluator _003C_003E9__20_1;

		internal string _003CReplaceBlockLabel_003Eb__20_1(Match match)
		{
			return null;
		}
	}

	private UIModelLogin m_ModelLogin;

	private string m_SrcText;

	private string m_TrimText;

	private string m_Text;

	private List<string> m_BlockPattern;

	private string m_SpecialBlockPattern;

	private Regex m_Regex;

	private const uint m_LabelTypeNum = 3u;

	private const uint m_PhoneNumCount = 8u;

	private const string m_TipKey = "BR_ACCOUNT_DIRTY_NAME";

	private HashSet<int> m_PhoneNumSet;

	private List<string> m_ChatWebWhiteListLocal;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	private void ProcessChatWhitelist()
	{
	}

	public bool ContainBlockLabel(string text, bool showTip = false)
	{
		return false;
	}

	public string GetRapaceText(string text)
	{
		return null;
	}

	private bool ContainBlockLabel(int labelType)
	{
		return false;
	}

	private bool ContainBlockPhoneNum()
	{
		return false;
	}

	private void ReplaceBlockLabel(int labelType)
	{
	}

	private bool ContainWhiteList(string msg)
	{
		return false;
	}

	private string _003CReplaceBlockLabel_003Eb__20_0(Match match)
	{
		return null;
	}
}
