public class Solution {
    public int NumSquares(int n) {
        // Based on Lagrange's Four Square theorem, there 
        // are only 4 possible results: 1, 2, 3, 4.

        // If n is a perfect square, return 1.
        if (IsPerfectSquare(n)) {
            return 1;
        }

        // The result is 4 if and only if n can be written in the 
        // form of 4^k*(8*m + 7). Please refer to 
        // Legendre's three-square theorem.
        while ((n & 3) == 0) { // n % 4 == 0  
            n >>= 2; // n /= 4
        }
        if ((n & 7) == 7) { // n % 8 == 7
            return 4;
        }

        // Check whether 2 is the result.
        int sqrtN = (int)Math.Sqrt(n);
        for (int i = 1; i <= sqrtN; i++) {
            if (IsPerfectSquare(n - i * i)) {
                return 2;
            }
        }

        return 3;
    }

    private bool IsPerfectSquare(int n) {
        int sqrtN = (int)Math.Sqrt(n);
        return sqrtN * sqrtN == n;
    }
}
