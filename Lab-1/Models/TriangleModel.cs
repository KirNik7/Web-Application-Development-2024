namespace Lab_1.Models
{
    public static class TriangleModel
    {
        public static bool CheckTriangleExists(double x, double y, double z)
        {
            // Проверяем условие существования треугольника
            return x + y > z && x + z > y && y + z > x;
        }
    }
}
