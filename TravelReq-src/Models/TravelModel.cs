using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LuisBot.Models
{
    public class TravelModel
    {
        public enum TravelType { Domestic, International};
        public enum Domestic_PurposeofTravel { None=-1, Business=0, Cust_Mtg_Escalation, Cust_Mtg_Existing_Opp_Pursuit, Cust_Mtg_Relationship_Building , Internal_Review_and_Reporting, Project, Recruitment, Relocation, Talent_Enablement, Training, Transfer, Visa_Stamping };
        public enum International_PurposeofTravel { None = -1, Conducting_Interview = 0, Conference = 1, Cust_Mtg_Existing_Opp_Pursuit, Cust_Mtg_Lead_Development_and_Pursuit, Internal_Review_and_Reporting, Internal_Review_or_Meeting, M_and_A_Related , Project_Deputation_Long_Term, Project_Deputation_Short_Term, Talent_Enablement };
        public enum TravelMode { Flight,Train,Road};
    }
}

