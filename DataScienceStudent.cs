namespace Targil 
{
    class DataScienteceStudant: Student
    {
        public DataScienteceStudant(string studentName, string studentID, Grade[] grades = default): base(studentName, studentID)
        {
            if(grades == default) {
                this.gradesArray = new Grade[3];
                this.initGradesArr();
            }
            else {
                this.gradesArray = grades;
            }
            
            this.getStudentAvg();
        }

    }
    class MusicStudent: Student
    {
        public MusicStudent(string studentName, string studentID, Grade[] grades = default): base(studentName, studentID)
        {
            
            if(grades == default) {
                this.gradesArray = new Grade[2];
                this.initGradesArr();
            }
            else {
                this.gradesArray = grades;
            }
            this.getStudentAvg();

        }

    }
    class ElectronicStudent: Student
    {
        public ElectronicStudent(string studentName, string studentID, Grade[] grades = default): base(studentName, studentID)
        {
            if(grades == default) {
                this.gradesArray = new Grade[3];
                this.initGradesArr();
            }
            else {
                this.gradesArray = grades;
            }
            this.getStudentAvg();
        }

    }
}