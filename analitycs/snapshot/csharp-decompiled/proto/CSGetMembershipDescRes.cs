using System.Collections.Generic;

namespace proto;

public class CSGetMembershipDescRes
{
	public List<MembershipDesc> rebate_descs;

	public List<MembershipAwardDesc> award_descs;

	public List<MembershipBigAwardDesc> big_award_descs;

	public bool membership_switch;

	public bool membership_purchase_switch;
}
