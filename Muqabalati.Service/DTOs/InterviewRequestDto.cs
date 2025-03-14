﻿namespace Muqabalati.Service.DTOs
{
    public class InterviewRequestDto
    {

        /// <summary>
        /// اسم المتقدم للمقابلة.
        /// </summary>
        public string ApplicantName { get; set; } = "علي";

        /// <summary>
        /// اسم المحاور.
        /// </summary>
        public string InterviewerName { get; set; } = "محمد";

        /// <summary>
        /// موضوع المقابلة (مثل موضوع تقني محدد).
        /// </summary>
        public string Topic { get; set; } = "BACKEND C#";

        /// <summary>
        /// مستوى المهارات المطلوب (مثال: مبتدئ، متوسط، خبير).
        /// </summary>
        public string SkillLevel { get; set; } = "Junior";

        /// <summary>
        /// القسم الذي تنتمي إليه المقابلة (مثل البرمجة).
        /// </summary>
        public string Department { get; set; } = "Programming";

        /// <summary>
        /// اللهجة أو الأسلوب الذي سيتم به توجيه الأسئلة.
        /// </summary>
        public string Tone { get; set; } = "مصرية";

        /// <summary>
        /// لغة المصطلحات المستخدمة (مثل الإنجليزية).
        /// </summary>
        public string TerminologyLanguage { get; set; } = "الانجليزي";

        /// <summary>
        /// لغة المقابلة
        /// </summary>
        public string InterviewLanguage { get; set; } = "العربية";

        /// <summary>
        /// عدد الأسئلة المطلوبة.
        /// </summary>
        public int QuestionCount { get; set; } = 2;
    }
}
