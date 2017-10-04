
/**
 * Created by abdulhakim
 * wecode.ng.
 */
/* Print half pyramid using java */


public class Main {

    public static void main(String[] args) {

        int ros = 5;

        for (int i = 0; i <= ros; i++) {



            for (int j = 0; j <= i ; j++) {
                String str = "*";

                // create a string made up of  n  copies of  s
                // String repeated = String.format(String.format("%%%ds", 2), " ").replace(" ",str);
                System.out.print(str );


            }
            System.out.print("\n");

        }
    }

}