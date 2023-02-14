namespace Targil 
{
    class Grade
    {
        private string subject;
        private int grade;
        public Grade(string subject, int grade)
        {
            this.subject = subject;
            this.grade = grade;
        }
        public void setSubject(string subject)
        {
            this.subject = subject;
        }
        public void setGrade(int grade)
        {
            this.grade = grade;
        }
        public string getSubject()
        {
            return this.subject;
        }
        public int getGrade()
        {
            return this.grade;
        }
    }
}