namespace CalcLib;

public static class MathUtils
{
    /// <summary>Наибольший общий делитель (алгоритм Евклида).</summary>
    public static long Gcd(long a, long b)
    {
        if (a < 0 || b < 0)
            throw new ArgumentOutOfRangeException(nameof(a), "Аргументы должны быть неотрицательными.");
        while (b != 0)
            (a, b) = (b, a % b);
        return a;
    }

    /// <summary>Наименьшее общее кратное; НОК(0, n) = 0.</summary>
    public static long Lcm(long a, long b) => 
        a == 0 || b == 0 ? 0 : a / Gcd(a, b) * b;

    /// <summary>Проверка числа на простоту.</summary>
    public static bool IsPrime(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i * i <= n; i++)
            if (n % i == 0) return false;
        return true;
    }

    /// <summary>Факториал; при переполнении выбрасывает OverflowException.</summary>
    public static long Factorial(int n)
    {
        if (n < 0)
            throw new ArgumentOutOfRangeException(nameof(n), "Факториал определён для n >= 0.");
        long result = 1;
        for (int i = 2; i <= n; i++)
            checked { result *= i; }
        return result;
    }
}