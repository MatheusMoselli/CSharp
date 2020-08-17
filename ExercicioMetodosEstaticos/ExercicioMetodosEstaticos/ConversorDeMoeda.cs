namespace ExercicioMetodosEstaticos
{
    class ConversorDeMoeda
    {
        public static double IOF = 6.0;

        public static double DolarParaReal(double cotacao, double quantia)
        {
            double total = quantia * cotacao;
            return total + total * IOF / 100;
        }
    }
}
