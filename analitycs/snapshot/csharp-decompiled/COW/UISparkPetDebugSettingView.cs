using GCommon;
using UnityEngine;

namespace COW;

public class UISparkPetDebugSettingView : UIBaseView
{
	public UIButton BtnClose;

	public UIButton BtnEnableSamo;

	public GameObject EnableSamoSwitch;

	public UIInput TxtLevel;

	public UIButton BtnSaveParam;

	public UIButton BtnRepeateClaim;

	public GameObject SetAllSkillContent;

	public UIInput Enemy1Skills;

	public UIInput Teammate1Skills;

	public UIInput Enemy2Skills;

	public UIInput Teammate2Skills;

	public UIInput Enemy3Skills;

	public UIInput Teammate3Skills;

	public UIInput Enemy4Skills;

	public UIInput Teammate4Skills;

	public UIButton BtnCloseSetSkillContent;

	public UIButton BtnEnableEachSkill;

	public GameObject EnableEachAISkillDetailOn;

	public GameObject EnableRepeateClaim;

	public UIInput TxtChooseTemper;

	public UIButton BtnChooseTemper;

	public UIInput TxtLobbyDialogue;

	public UIButton BtnDailyLogin;

	public GameObject EnableChooseTemper;

	public GameObject EnableLobbyDialogue;

	public UIButton BtnEnableAnim;

	public GameObject EnableAnimSwitch;

	public UIPanel TableCommands;

	public UITable2 Table2;

	public GameObject SettingScrollView;

	public UIButton BtnAnimSetting;

	public UIInput TxtState;

	public UIButton BtnChangeState;

	public GameObject EnableChangeState;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
