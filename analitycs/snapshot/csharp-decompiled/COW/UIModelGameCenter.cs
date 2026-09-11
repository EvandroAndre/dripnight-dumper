using GCommon;

namespace COW;

public class UIModelGameCenter : UIBaseModel
{
	public override uint GetModelType()
	{
		return 0u;
	}

	public void MaybeAuthAfterLogin()
	{
	}

	public bool IsAuthed()
	{
		return false;
	}
}
