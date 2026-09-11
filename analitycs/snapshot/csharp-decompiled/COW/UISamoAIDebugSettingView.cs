using GCommon;
using UnityEngine;

namespace COW;

public class UISamoAIDebugSettingView : UIBaseView
{
	public UIButton BtnClose;

	public UIButton BtnEnableSamo;

	public GameObject EnableSamoSwitch;

	public UIButton BtnSamoBRWarm;

	public GameObject SamoBRWarmSwitch;

	public UIInput TxtAddr;

	public UIInput TxtLevel;

	public UIInput TxtEnemyNum;

	public UIInput TxtTeammateNum;

	public UIInput TxtDramaID;

	public UIInput TxtCSZone;

	public UIButton BtnSaveParam;

	public UIInput TxtSkillIDs;

	public UIButton BtnUpdateEachSkill;

	public UIButton BtnSamoBRWarmNoDrama;

	public GameObject SamoBRWarmNoDramaSwitch;

	public UIButton BtnDisablePacketOptimize;

	public GameObject DisablePacketOptimizeSwitch;

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

	public GameObject EnableEachAISkillOn;

	public UIButton BtnUseGzip;

	public GameObject UseGzipSwitch;

	public UIButton BtnUseBotTeammate;

	public GameObject UseBotTeammateSwitch;

	public UIInput TxtSemiKillCount;

	public GameObject SemiSwitch;

	public UIButton BtnSemi;

	public UIInput TxtMapLayer;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
