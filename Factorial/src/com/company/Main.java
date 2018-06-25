package com.company;

import java.math.BigDecimal;
import java.math.BigInteger;
import java.util.Scanner;

public class Main {

    static BigInteger one = BigInteger.valueOf(1);
    public static BigInteger factorial(int n)
    {
        BigInteger ret = BigInteger.ONE;
        for (int i = 1; i <= n; ++i) ret = ret.multiply(BigInteger.valueOf(i));
        return ret;
    }


    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        BigInteger result;
        int n = input.nextInt();
        if (n<0 || n>=1000)
        {
            System.out.println("Error; number must be positive or less than 1000");
        }
        else {
            System.out.println("Main method started");
            result = Main.factorial(n);
            System.out.println("Factorial ==> " + result);
            System.out.println("Main method ended");
        }
    }
}
