using System.Collections.Generic;

namespace proto;

public class CSGetGameplaySurveySettingRes
{
	public List<GameplaySurveyDesc> survey_descs;

	public List<GameplayFeedbackQuestionDesc> feedback_question_descs;

	public List<GameplayFeedbackOptionDesc> feedback_option_descs;

	public List<QuickFeedbackQuestDesc> quick_feedback_quest_descs;
}
