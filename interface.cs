namespace Targil 
{
    interface IGraduationCertificatesManager
    {
        void addStudent(Student newstudent);
        bool removeStudent(Student newstodent);
        Student getStodentByID(string studentID);
        float getStudentAVG();
        Student getBestStudent();
        Student getWorstStudent();
    }


    class GraduationCertificatesManager: IGraduationCertificatesManager
    {
        private List<Student> studentArr;
        public GraduationCertificatesManager() 
        {
            this.studentArr = new List<Student>();
        }

        public void addStudent(Student newstudent)
        {
            this.studentArr.Add(newstudent);
        }

        public bool removeStudent(Student newstudent)
        {
            return this.studentArr.Remove(newstudent);
        }
        public Student getStodentByID(string studentID)
        {
            for(int i = 0; i< this.studentArr.Count; i++)
            {
                if(studentID == this.studentArr[i].GetId())
                {
                    return this.studentArr[i];
                }
                
            }
            return null;
        }
        public float getStudentAVG()
        {
            float sumOfAVG = 0;
            int countStudents = 0;
            for(int i = 0; i< this.studentArr.Count; i++)
            {
                sumOfAVG += this.studentArr[i].getStudentAvg();
                countStudents++;
            }
            return sumOfAVG/countStudents;
        }
        public Student getBestStudent()
        {
            Student bestStudent = this.studentArr[0];
            float bestGrade = bestStudent.getStudentAvg();
            for(int i = 0; i < this.studentArr.Count; i++)
            {
                if(bestGrade < this.studentArr[i].getStudentAvg())
                {
                    bestStudent = this.studentArr[i];
                    bestGrade = bestStudent.getStudentAvg();
                }
            }
            return bestStudent;
        }
        public Student getWorstStudent()
        {
            Student worstStudent = this.studentArr[0];
            float worstGrade = worstStudent.getStudentAvg();
            for(int i = 0; i < this.studentArr.Count; i++)
            {
                if(worstGrade > this.studentArr[i].getStudentAvg())
                {
                    worstStudent = this.studentArr[i];
                    worstGrade = worstStudent.getStudentAvg();
                }
            }
            return worstStudent;
        }

    }
}