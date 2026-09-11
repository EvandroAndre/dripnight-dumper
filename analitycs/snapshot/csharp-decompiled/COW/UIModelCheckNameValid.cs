using GCommon;

namespace COW;

public class UIModelCheckNameValid : UIBaseModel
{
	private sealed class _003C_003Ec__DisplayClass17_0
	{
		public UIModelCheckNameValid _003C_003E4__this;

		public uint propID;

		internal void _003CCheckContentIsDirtyWord_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	public const uint PropID_DirtyWordCheck = 2u;

	public const uint PropID_DirtyWordCheckOtherError = 4u;

	public const uint PropID_DirtyPlayerEditDesc = 8u;

	public const string NameIsNullOrEmptyKey = "T_41_SY_RENAME_EMPTY";

	public const string NameIsEqualKey = "T_41_SY_RENAME_REPEAT";

	public const string NameLengthIsNotValidKey = "T_41_SY_RENAME_LENGTH";

	public const string NameIsBlockKey = "T_41_SY_RENAME_EMAIL";

	public const string NameIsDigitKey = "T_41_SY_RENAME_NUM";

	public const string NameIsDirtyWordKey = "T_41_SY_RENAME_ILLEGAL";

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Init()
	{
	}

	public override void Login(object[] data)
	{
	}

	public override void Logout(object[] data)
	{
	}

	public bool CheckNameIsEqual(string curName, string newName)
	{
		return false;
	}

	public bool CheckNameLengthIsNotValid(string newName, int minValue = 1, int maxValue = int.MaxValue)
	{
		return false;
	}

	public bool CheckNameIsBlockLabel(string newName)
	{
		return false;
	}

	public bool CheckNameIsDigit(string newName)
	{
		return false;
	}

	public void CheckContentIsDirtyWord(string content, uint propID)
	{
	}

	public void CheckNameIsDirtyWord(string newName)
	{
	}

	public void CheckPlayerEditDescriptionIsDirtyWord(string newName)
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
