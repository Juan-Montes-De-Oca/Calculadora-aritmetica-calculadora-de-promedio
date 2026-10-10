public static class StudentGrade
{
    public static double StudentAvg(double gradeSum, double gradesCount)
    {
        return (gradeSum) / (gradesCount);
    }

    public static bool StudentStatus(double finalGrade)
    {
        return finalGrade >= 70;
    }
}