using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExportSASData.Model
{
    public class ApprovalRecord
    {
        public string applyId { get; set; }
        public string applyUserId { get; set; }
        public string approvalContent { get; set; }
        public string approvalStatus { get; set; }
        public string approvalUserId { get; set; }
        public string ApprovalDate { get; set; }
        public string ApprovalUserType { get; set; }

    }
}
