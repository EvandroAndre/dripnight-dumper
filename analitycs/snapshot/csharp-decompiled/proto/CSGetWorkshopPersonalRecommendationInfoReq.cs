using System.Collections.Generic;

namespace proto;

public class CSGetWorkshopPersonalRecommendationInfoReq
{
	public string language;

	public List<string> history_recommended_workshop_codes;
}
