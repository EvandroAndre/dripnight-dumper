namespace COW;

public class BuildCtrlComponent
{
	private bool _003CHasOpenChooseSide_003Ek__BackingField;

	public UIBuildChooseAvatarSkillSideController m_ChooseSkillCtrl;

	public UIBuildChooseLoadoutSideController m_ChooseLoadoutCtrl;

	public UIBuildChoosePetSkillSideController m_ChoosePetSkillCtrl;

	public UICSBPBuildChooseAvatarSkillSideController m_CSBPChooseSkillCtrl;

	private bool IsCSBanPickMode;

	public bool HasOpenChooseSide
	{
		get
		{
			return _003CHasOpenChooseSide_003Ek__BackingField;
		}
		private set
		{
			_003CHasOpenChooseSide_003Ek__BackingField = value;
		}
	}

	public BuildCtrlComponent()
	{
	}

	public BuildCtrlComponent(bool isCSBanPickMode)
	{
	}

	public void OnOpenChooseAvatarSkillSide(int slot)
	{
	}

	public void OnAvatarEquipSkill(int slotIndex)
	{
	}

	public void OnOpenChoosePetSkillSide()
	{
	}

	public void OnOpenChooseLoadoutSide()
	{
	}

	public void CloseAllChooseSide()
	{
	}

	public bool GetChooseSkillCtrlMaxPanelDepth(out int depth)
	{
		depth = default(int);
		return false;
	}
}
