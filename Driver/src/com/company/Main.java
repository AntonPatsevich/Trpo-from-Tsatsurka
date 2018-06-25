package com.company;

import java.util.Scanner;

public class Main {

    public static class Card {

        /* Setting Vars */
        private Long cnum;


        public Card(Long cnum) {
            this.cnum = cnum;
        }


        public Long getCnum() {
            return cnum;
        }


        public void setCnum(Long cnum) {
            this.cnum = cnum;
        }


        public boolean validate() {
            String ccstring = Long.toString(cnum);
            char[] ccchar = ccstring.toCharArray();
            if (ccchar.length <= 19) {
                int sum = 0;
                for (int i = 0; i < ccchar.length; i++) {
                    if (i % 2 == 0) {
                        int val = Integer.parseInt(String.valueOf(ccchar[i]));
                        val = val * 2;
                        if (val > 9) {
                            sum += (1 + (val % 10));
                        } else {
                            sum += val;
                        }
                    } else {
                        sum += Integer.parseInt(String.valueOf(ccchar[i]));
                    }
                }
                if (sum % 10 == 0) {
                    return true;
                } else {
                    return false;
                }
            } else {
                return false;
            }
        }

    }

    public static void main(String[] args) {
        System.out.println("--------------------------");
        System.out.println("     CCValidator");
        System.out.println("     Tsatsura Nikita");
        System.out.println("--------------------------");
        System.out
                .println("Note: Please use Apache ANT to compile, run, or jar this project.");
        System.out
                .println("Note: To see some examples for cards check out \"input.txt\".");

        Scanner in = new Scanner(System.in);

        System.out.println("\nEnter a number to validate.");
        Long cnum = in.nextLong();
        Card tmp = new Card(cnum);
        boolean validity = tmp.validate();
        if (validity) {
            System.out.println("Card is valid.");
        } else {
            System.out.println("Card is NOT valid.");
        }

        in.close();
    }
}
