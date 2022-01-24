using System;
using System.Collections.Generic;

namespace RecruiterHelper
{
    public class Interviewer
    {
        private string firstName;
        private string lastName;
        private List<Requisitions> approvedReqsForInterviewing = new List<Requisitions>();


        public Interviewer(string first_name, string last_name)
        {
            firstName = first_name;
            lastName = last_name;
        }

        public void AddApprovedReq(Requisitions req)
        {
            if (!approvedReqsForInterviewing.Exists(x => x.Equals(req)))
            {
                approvedReqsForInterviewing.Add(req);
            }
        }

        public void RemoveApprovedReq(Requisitions req)
        {
            approvedReqsForInterviewing.Remove(req);
        }

        public bool IsApprovedForReq(Requisitions req)
        {
            return approvedReqsForInterviewing.Exists(x => x.Equals(req));
        }
    }
}
