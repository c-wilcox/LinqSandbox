using System;
using System.Collections.Generic;

namespace DataSources
{
    public enum InterviewType
    {
        CasualPhoneScreen,
        TechnicalPhoneScreen,
        FaceToFace
    }

    public class InterviewInfo
    {
        public List<DateTime> ScheduledDates { get; set; }
        public InterviewType InterviewType { get; set; }
        public DateTime ActualDate { get; set; }
        public string PrincipalAttendee { get; set; }
        public List<string> Attendees { get; set; }
        public string Notes { get; set; }
        public RecruiterAgent RecruiterAgent { get; set; }
    }
}