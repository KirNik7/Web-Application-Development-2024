namespace Lab_1.Models
{
    public static class OctantModel
    {
        public static string GetOctant(double x, double y, double z)
        {
            // Определяем в каком октанте лежит точка
            if (x > 0 && y > 0 && z > 0)
                return "I";

            else if (x > 0 && y < 0 && z > 0)
                return "II";

            else if (x > 0 && y < 0 && z < 0)
                return "III";

            else if (x > 0 && y > 0 && z < 0)
                return "IV";

            else if (x < 0 && y > 0 && z > 0)
                return "V";

            else if (x < 0 && y < 0 && z > 0)
                return "VI";

            else if (x < 0 && y < 0 && z < 0)
                return "VII";

            else if (x < 0 && y > 0 && z < 0)
                return "VIII";

            else
                return "Origin";
        }
    }
}
