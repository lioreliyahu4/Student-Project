namespace Targil
{
    class Student
    {
        protected string StudantName;
        protected string ID;
        protected Grade[] gradesArray;

        public Student(string StudantName, string ID)
        {
            this.StudantName = StudantName;
            this.ID = ID;
        }
        public void SetName(string StudantName )
        {
            this.StudantName = StudantName;
        }
        public void SetId(string ID )
        {
            this.ID = ID;
        }
        public string GetName()
        {
            return this.StudantName;
        }
        public string GetId()
        {
            return this.ID;
        }

        public override string ToString()
        {
            return "name: " + this.GetName() + ", Avg: " + this.getStudentAvg();
        }

       
        protected void initGradesArr()
        {
            Console.Write("Hey new Student, please enter your grades\n");
            for(int i = 0; i < this.gradesArray.Length; i++)
            {
                Console.Write("Enter the subject: ");
                string subject =  Console.ReadLine();
                Console.Write("Enter the grade: ");
                int grade = int.Parse(Console.ReadLine());
                Grade gradeObj = new Grade(subject, grade);
                this.gradesArray[i] = gradeObj;
            }
        }
        public float getStudentAvg()
        {
            int sumOfGrades = 0;
            for(int i = 0; i < gradesArray.Length; i++)
            {
                sumOfGrades += gradesArray[i].getGrade();
            }
            return sumOfGrades/gradesArray.Length;
        }
       
    }

}