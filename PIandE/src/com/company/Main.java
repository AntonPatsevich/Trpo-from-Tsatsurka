package com.company;

import java.math.BigDecimal;
import java.util.InputMismatchException;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        BigDecimal b1 = new BigDecimal(22.0);
        BigDecimal b2 = new BigDecimal(7.0);
        final double E = Math.E;
        double eToNthDigit = 0.0;
        System.out.println("To how many decimal places do you want to print PI?");
        int n = input.nextInt();

        if(n < 32627)
            System.out.println(b1.divide(b2, n, BigDecimal.ROUND_UP));
        else
            System.out.println("Limit exceeded !!!");



        if(n < 0){
            System.out.println("ERROR: The number given is a negative number");
            return;
        }
        else{
            eToNthDigit = ( Math.floor(E * Math.pow(10, n)) ) / Math.pow(10, n);
            System.out.println( "e with " + n + " decimal places is: " + eToNthDigit);
        }

    }
}
